Imports System.Data.SqlClient

Public Class StaffApproval
    Inherits Form

    Dim conn As SqlConnection = dbConnection.GetConnection()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadTable()
        Dim query As String = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvStaff.DataSource = dt
        dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim approveImgCol As New DataGridViewImageColumn With {
            .Name = "approve",
            .HeaderText = String.Empty,
            .Image = My.Resources.check,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        Dim rejectImgCol As New DataGridViewImageColumn With {
            .Name = "reject",
            .HeaderText = String.Empty,
            .Image = My.Resources.cancel,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        If dgvStaff.Columns("approve") Is Nothing Then
            dgvStaff.Columns.Add(approveImgCol)
        End If
        If dgvStaff.Columns("reject") Is Nothing Then
            dgvStaff.Columns.Add(rejectImgCol)
        End If

        dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStaff.ColumnHeadersDefaultCellStyle.BackColor
        dgvStaff.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub dgvStaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellContentClick
        Dim staffid As Integer
        Dim checkrow As Integer

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaff.Columns("approve").Index Then
            Dim query As String = "UPDATE tbl_staff SET IsApproved = 1 WHERE staff_id = @staffid"
            staffid = Integer.Parse(dgvStaff.Rows(e.RowIndex).Cells("Staff ID").Value.ToString())

            Try
                conn.Open()
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to approve this signup?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.No Then Return

                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@staffid", staffid)

                checkrow = cmd.ExecuteNonQuery()
                If checkrow > 0 Then
                    MessageBox.Show("Signup request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to approve the signup request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                LoadTable()
            End Try
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvStaff.Columns("reject").Index Then
            Dim query As String = "DELETE FROM tbl_staff WHERE staff_id = @staffid"
            staffid = Integer.Parse(dgvStaff.Rows(e.RowIndex).Cells("Staff ID").Value.ToString())

            Try
                conn.Open()
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to reject this signup?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.No Then Return

                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@staffid", staffid)

                checkrow = cmd.ExecuteNonQuery()
                If checkrow > 0 Then
                    MessageBox.Show("Signup request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to reject the signup request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                LoadTable()
            End Try
        End If
    End Sub

    Private Sub dgvStaff_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvStaff.CellToolTipTextNeeded
        If dgvStaff.Columns(e.ColumnIndex).Name = "approve" Then
            e.ToolTipText = "Approve"
        End If
        If dgvStaff.Columns(e.ColumnIndex).Name = "reject" Then
            e.ToolTipText = "Reject"
        End If
    End Sub

    Private Sub StaffApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        cbSearchBy.Text = "Name"
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number] from tbl_staff WHERE IsDeleted = 0 AND IsApproved = 0"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(search) Then
            LoadTable()
            Return
        End If

        If cbSearchBy.Text = "Name" Then
            query &= " AND CONCAT(first_name, ' ', last_name) LIKE @search"
        ElseIf cbSearchBy.Text = "Username" Then
            query &= " AND username = @search"
        ElseIf cbSearchBy.Text = "ID" Then
            query &= " AND staff_id = @search"
        End If

        Dim cmd As New SqlCommand(query, conn)
        If cbSearchBy.Text = "Name" Then
            cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        Else
            cmd.Parameters.AddWithValue("@search", search)
        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvStaff.DataSource = dt
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub

End Class