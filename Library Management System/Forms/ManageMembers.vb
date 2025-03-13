Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Partial Public Class ManageMembers
    Inherits Form

    Dim conn As SqlConnection = dbConnection.GetConnection()
    Dim selectionMode As Integer
    Dim memberid As Integer
    Dim checkrow As Integer

    Private userRole As String

    Public Sub New(userrole As String)
        InitializeComponent()
        userrole = userrole
    End Sub

    Private Sub HandleLogin(userRole As String)
        If userRole = "Staff" Then
            dgvMember.Columns("delete").Visible = False
        ElseIf userRole = "Admin" Then
            dgvMember.Columns("delete").Visible = True
        End If
    End Sub

    Private Sub clearTexts()
        tbFirstName.Clear()
        tbLastName.Clear()
        tbAddress.Clear()
        tbContactNumber.Clear()
        tbEmail.Clear()
        cbMembershipType.Text = "Child"
    End Sub

    Private Sub loadTable()
        Dim query As String = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
        dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim updateImgCol As New DataGridViewImageColumn() With {
            .Name = "update",
            .HeaderText = String.Empty,
            .Image = My.Resources.edit,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }
        Dim deleteImgCol As New DataGridViewImageColumn() With {
            .Name = "delete",
            .HeaderText = String.Empty,
            .Image = My.Resources.delete,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }
        If dgvMember.Columns("update") Is Nothing Then
            dgvMember.Columns.Add(updateImgCol)
        End If
        If dgvMember.Columns("delete") Is Nothing Then
            dgvMember.Columns.Add(deleteImgCol)
        End If
        dgvMember.Columns("update").DisplayIndex = dgvMember.Columns.Count - 1
        dgvMember.Columns("delete").DisplayIndex = dgvMember.Columns.Count - 1
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor
        HandleLogin(userRole)
    End Sub

    Private Sub ManageMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        pnlSideMenu.Visible = False
        cbSearchBy.Text = "Name"
    End Sub

    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        lblSideMenu.Text = "ADD MEMBER"
        selectionMode = 1
        clearTexts()
        cbMembershipType.Text = "Child"
        If pnlSideMenu.Visible = False Then
            pnlSideMenu.Visible = True
        Else
            pnlSideMenu.Visible = False
        End If
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub

    Private Sub dgvMember_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMember.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvMember.Columns("update").Index Then
            Dim query As String = "SELECT * from tbl_member WHERE member_id = @memberid"
            memberid = Integer.Parse(dgvMember.Rows(e.RowIndex).Cells("Member ID").Value.ToString())
            selectionMode = 2
            clearTexts()
            lblSideMenu.Text = "UPDATE MEMBER"
            pnlSideMenu.Visible = True
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@memberid", memberid)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            tbFirstName.Text = ds.Tables(0).Rows(0)(1).ToString()
            tbLastName.Text = ds.Tables(0).Rows(0)(2).ToString()
            numAge.Value = Decimal.Parse(ds.Tables(0).Rows(0)(3).ToString())
            tbAddress.Text = ds.Tables(0).Rows(0)(4).ToString()
            tbContactNumber.Text = ds.Tables(0).Rows(0)(5).ToString()
            tbEmail.Text = ds.Tables(0).Rows(0)(6).ToString()
            cbMembershipType.Text = ds.Tables(0).Rows(0)(7).ToString()
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvMember.Columns("delete").Index Then
            Dim query As String = "UPDATE tbl_member SET IsDeleted = 1 WHERE member_id = @memberid"
            memberid = Integer.Parse(dgvMember.Rows(e.RowIndex).Cells("Member ID").Value.ToString())
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@memberid", memberid)
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dialogResult = DialogResult.No Then
                    Return
                End If
                checkrow = cmd.ExecuteNonQuery()
                If checkrow > 0 Then
                    MessageBox.Show("Member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                clearTexts()
                loadTable()
            End Try
        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            loadTable()
            Return
        End If

        If cbSearchBy.Text = "Name" Then
            query &= " AND CONCAT(first_name, ' ', last_name) LIKE @search"
        ElseIf cbSearchBy.Text = "ID" Then
            If Not Integer.TryParse(search, Nothing) Then
                Return
            End If
            query &= " AND member_id LIKE @search"
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
    End Sub

    Private Sub dgvMember_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvMember.CellToolTipTextNeeded
        If dgvMember.Columns(e.ColumnIndex).Name = "update" Then
            e.ToolTipText = "Update"
        End If
        If dgvMember.Columns(e.ColumnIndex).Name = "delete" Then
            e.ToolTipText = "Delete"
        End If
    End Sub

    Private Sub pbExit2_Click(sender As Object, e As EventArgs) Handles pbExit2.Click
        pnlSideMenu.Visible = False
        clearTexts()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If String.IsNullOrEmpty(tbFirstName.Text) Then
            MessageBox.Show("First Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbFirstName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbLastName.Text) Then
            MessageBox.Show("Last Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbLastName.Focus()
            Return
        ElseIf numAge.Value = 0 Then
            MessageBox.Show("Age field cannot be zero!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numAge.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbAddress.Text) Then
            MessageBox.Show("Address field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbAddress.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbContactNumber.Text) Then
            MessageBox.Show("Contact Number field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbContactNumber.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbEmail.Text) Then
            MessageBox.Show("Email field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbEmail.Focus()
            Return
        End If

        Dim member As New Member(memberid, tbFirstName.Text, tbLastName.Text, Integer.Parse(numAge.Text), tbAddress.Text, tbContactNumber.Text, tbEmail.Text, cbMembershipType.Text)
        Dim memberManager As New ManageMembers(userRole)

        Try
            Dim nameRegex As New Regex("^[a-zA-Z\s]+$", RegexOptions.IgnoreCase)
            Dim matchFirstName As Match = nameRegex.Match(tbFirstName.Text)
            If Not matchFirstName.Success Then
                MessageBox.Show("First name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbFirstName.Focus()
                Return
            End If

            Dim matchLastName As Match = nameRegex.Match(tbLastName.Text)
            If Not matchLastName.Success Then
                MessageBox.Show("Last name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbLastName.Focus()
                Return
            End If

            Dim regex As New Regex("^09[\d]{9}$", RegexOptions.IgnoreCase)
            Dim match As Match = regex.Match(tbContactNumber.Text)
            If Not match.Success Then
                MessageBox.Show("Invalid contact number format. Please ensure the number starts with '09' and is 11 digits long (e.g., '09123456789').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbContactNumber.Focus()
                Return
            End If

            Dim regex2 As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase)
            Dim match2 As Match = regex2.Match(tbEmail.Text)
            If Not match2.Success Then
                MessageBox.Show("Invalid email format. Please ensure the email includes an '@' symbol and a valid domain (e.g., 'example@domain.com').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbEmail.Focus()
                Return
            End If

            If selectionMode = 2 Then
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to update this member?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.No Then
                    Return
                End If
            End If

            conn.Open()
            Dim result As Boolean
            Select Case selectionMode
                Case 1
                    result = memberManager.AddMember(member)
                    If result Then
                        MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pnlSideMenu.Visible = False
                    Else
                        MessageBox.Show("Failed to add the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case 2
                    result = memberManager.UpdateMember(member)
                    If result Then
                        MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pnlSideMenu.Visible = False
                    Else
                        MessageBox.Show("Failed to update the member.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As SqlException
            If ex.Number = 2627 Then
                MessageBox.Show("The email address already exists.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            conn.Close()
            loadTable()
        End Try
    End Sub
End Class