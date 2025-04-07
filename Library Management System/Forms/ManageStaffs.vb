Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Partial Public Class ManageStaffs
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub updateFont()
        ' Change cell font
        For Each c As DataGridViewColumn In dgvStaff.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Dim conn As SqlConnection = dbConnection.GetConnection()
    Dim selectionMode, staffid, checkrow As Integer

    Private Sub clearTexts()
        tbFirstName.Clear()
        tbLastName.Clear()
        tbUsername.Clear()
        tbPassword.Clear()
        tbEmail.Clear()
        tbContactNumber.Clear()
        cbRole.Text = String.Empty
    End Sub

    Private Sub loadTable()
        updateFont()
        Dim query As String = "SELECT custom_staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 1"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvStaff.DataSource = dt
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim updateImgCol As New DataGridViewImageColumn With {
            .Name = "update",
            .HeaderText = String.Empty,
            .Image = My.Resources.edit,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        ' Removed the delete image column
        If dgvStaff.Columns("update") Is Nothing Then
            dgvStaff.Columns.Add(updateImgCol)
        End If

        dgvStaff.Columns("update").DisplayIndex = dgvStaff.Columns.Count - 1
        dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStaff.ColumnHeadersDefaultCellStyle.BackColor
        dgvStaff.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If String.IsNullOrEmpty(tbFirstName.Text) Then
            MessageBox.Show("The First Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbFirstName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbLastName.Text) Then
            MessageBox.Show("The Last Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbLastName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbUsername.Text) Then
            MessageBox.Show("The Username field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbPassword.Text) Then
            MessageBox.Show("The Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbConfirmPassword.Text) Then
            MessageBox.Show("The Confirm Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbConfirmPassword.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbEmail.Text) Then
            MessageBox.Show("The Email field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbEmail.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbContactNumber.Text) Then
            MessageBox.Show("The Contact Number field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbContactNumber.Focus()
            Return
        ElseIf tbUsername.Text.Length < 3 OrElse tbUsername.Text.Length > 20 Then
            MessageBox.Show("The Username must be between 3 and 20 characters long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Return
        ElseIf tbPassword.Text.Length < 8 Then
            MessageBox.Show("The Password must be at least 8 characters long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Return
        ElseIf tbPassword.Text <> tbConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match. Please re-enter the password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Return
        End If

        Dim isApproved As Boolean = True
        Dim isDeleted As Boolean = False

        Dim staff As New Staff(staffid, tbFirstName.Text, tbLastName.Text, tbUsername.Text, tbPassword.Text, tbEmail.Text, tbContactNumber.Text, cbRole.Text, isApproved, isDeleted)
        Dim staffManager As New ManageStaffs()

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
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to update this staff?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.No Then Return
            End If

            Dim result As Boolean
            Select Case selectionMode
                Case 1
                    result = staffManager.AddStaff(staff)
                    If result Then
                        MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pnlSideMenu.Visible = False
                    Else
                        MessageBox.Show("Failed to add the staff.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case 2
                    result = staffManager.UpdateStaff(staff)
                    If result Then
                        MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pnlSideMenu.Visible = False
                    Else
                        MessageBox.Show("Failed to update the staff.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As SqlException
            If ex.Number = 2627 OrElse ex.Number = 2601 Then
                MessageBox.Show("The username or email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            conn.Close()
            loadTable()
        End Try
    End Sub

    Private Sub dgvStaff_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvStaff.CellToolTipTextNeeded
        If dgvStaff.Columns(e.ColumnIndex).Name = "update" Then
            e.ToolTipText = "Update"
        End If
        ' Removed the delete tooltip
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaff.Columns("update").Index Then
            Dim query As String = "SELECT * FROM tbl_staff WHERE staff_id = @staffid"
            staffid = Integer.Parse(dgvStaff.Rows(e.RowIndex).Cells("Staff ID").Value.ToString())
            selectionMode = 2
            clearTexts()
            lblSideMenu.Text = "UPDATE STAFF"
            pnlSideMenu.Visible = True

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@staffid", staffid)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            tbFirstName.Text = ds.Tables(0).Rows(0)(1).ToString()
            tbLastName.Text = ds.Tables(0).Rows(0)(2).ToString()
            tbUsername.Text = ds.Tables(0).Rows(0)(3).ToString()
            tbPassword.Text = ds.Tables(0).Rows(0)(4).ToString()
            tbConfirmPassword.Text = ds.Tables(0).Rows(0)(4).ToString()
            tbEmail.Text = ds.Tables(0).Rows(0)(5).ToString()
            tbContactNumber.Text = ds.Tables(0).Rows(0)(6).ToString()
            cbRole.Text = ds.Tables(0).Rows(0)(7).ToString()
        End If

        ' Removed the delete functionality section
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 1"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            loadTable()
            Return
        End If

        If cbSearchBy.Text = "Name" Then
            query += " AND CONCAT(first_name, ' ', last_name) LIKE @search"
        ElseIf cbSearchBy.Text = "Username" Then
            query += " AND username LIKE @search"
        ElseIf cbSearchBy.Text = "ID" Then
            query += " AND staff_id LIKE @search"
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" + search + "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvStaff.DataSource = dt
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pbExit2_Click(sender As Object, e As EventArgs) Handles pbExit2.Click
        pnlSideMenu.Visible = False
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        visibility1.Visible = True
        If String.IsNullOrEmpty(tbPassword.Text) Then
            visibility1.Visible = False
        End If
    End Sub

    Private Sub tbConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles tbConfirmPassword.TextChanged
        visibility2.Visible = True
        If String.IsNullOrEmpty(tbConfirmPassword.Text) Then
            visibility2.Visible = False
        End If
    End Sub

    Private Sub visibility1_Click(sender As Object, e As EventArgs) Handles visibility1.Click
        If tbPassword.UseSystemPasswordChar Then
            visibility1.Image = My.Resources.visibilityoff
            tbPassword.UseSystemPasswordChar = False
        Else
            visibility1.Image = My.Resources.visibilityon
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub visibility2_Click(sender As Object, e As EventArgs) Handles visibility2.Click
        If tbConfirmPassword.UseSystemPasswordChar Then
            visibility2.Image = My.Resources.visibilityoff
            tbConfirmPassword.UseSystemPasswordChar = False
        Else
            visibility2.Image = My.Resources.visibilityon
            tbConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ManageStaffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        selectionMode = 0
        pnlSideMenu.Visible = False
        cbSearchBy.Text = "Name"
        tbPassword.UseSystemPasswordChar = True
        tbConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        lblSideMenu.Text = "ADD STAFF"
        selectionMode = 1
        clearTexts()
        If Not pnlSideMenu.Visible Then pnlSideMenu.Visible = True Else pnlSideMenu.Visible = False
    End Sub
End Class