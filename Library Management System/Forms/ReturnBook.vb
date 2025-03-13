Imports System.Data.SqlClient

Public Class ReturnBook
    Inherits Form

    Dim conn As SqlConnection = dbConnection.GetConnection()
    Dim issueid As Integer
    Dim bookid As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ClearTexts()
        lblIssueID.Text = String.Empty
        lblBookTitle.Text = String.Empty
        lblMemberName.Text = String.Empty
        lblIssueDate.Text = String.Empty
        lblDueDate.Text = String.Empty
    End Sub

    Private Sub LoadTable()
        Dim query As String = "SELECT tbl_issue.issue_id as [Issue ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) as [Member Name], tbl_book.title as [Book Title] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE status = 'Issued'"

        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvIssue.DataSource = dt
        dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        If String.IsNullOrEmpty(lblIssueID.Text) Then
            MessageBox.Show("Please select a record to return.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dialogResult As DialogResult = MessageBox.Show($"Are you sure you want to return the book '{lblBookTitle.Text}' issued to '{lblMemberName.Text}'?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialogResult = DialogResult.Yes Then
            Dim returndate As String = DateTime.Now.ToShortDateString()
            Try
                conn.Open()
                Dim returnQuery As String = "UPDATE tbl_issue SET return_date = @returndate, status = 'Returned' WHERE issue_id = @issueid"
                Dim returnCmd As New SqlCommand(returnQuery, conn)
                returnCmd.Parameters.AddWithValue("@returndate", returndate)
                returnCmd.Parameters.AddWithValue("@issueid", issueid)
                Dim checkreturn As Integer = returnCmd.ExecuteNonQuery()

                Dim updateQuery As String = "UPDATE tbl_book SET quantity = quantity + 1 WHERE book_id = @bookid"
                Dim updateCmd As New SqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@bookid", bookid)
                Dim checkupdate As Integer = updateCmd.ExecuteNonQuery()

                If checkreturn > 0 AndAlso checkupdate > 0 Then
                    MessageBox.Show("Returned book successfully.\nInventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                LoadTable()
            End Try
        End If
    End Sub

    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTexts()
        LoadTable()
        cbSearchBy.Text = "Member Name"
        dgvIssue.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT tbl_issue.issue_id as [Issue ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) as [Member Name], tbl_book.title as [Book Title] from tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE status = 'Issued'"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            LoadTable()
            Return
        End If

        If cbSearchBy.Text = "Member Name" Then
            query &= " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search"
        ElseIf cbSearchBy.Text = "Member ID" Then
            Dim id As Integer
            If Not Integer.TryParse(search, id) Then
                Return
            End If
            query &= " AND tbl_issue.member_id LIKE @search"
        ElseIf cbSearchBy.Text = "Issue ID" Then
            Dim id As Integer
            If Not Integer.TryParse(search, id) Then
                Return
            End If
            query &= " AND tbl_issue.issue_id LIKE @search"
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvIssue.DataSource = dt
    End Sub

    Private Sub dgvIssue_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIssue.CellClick
        If e.RowIndex >= 0 AndAlso dgvIssue.Rows(e.RowIndex).Cells(e.ColumnIndex) IsNot Nothing Then
            Try
                issueid = Integer.Parse(dgvIssue.Rows(e.RowIndex).Cells(0).Value.ToString())

                Dim query As String = "SELECT tbl_issue.issue_id, tbl_issue.book_id, tbl_book.title, tbl_member.first_name, tbl_member.last_name, tbl_issue.issue_date, tbl_issue.due_date FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.issue_id = @issueid AND tbl_issue.status = 'Issued'"

                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@issueid", issueid)

                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    lblIssueID.Text = reader("issue_id").ToString()
                    lblBookTitle.Text = reader("title").ToString()
                    lblMemberName.Text = $"{reader("first_name")} {reader("last_name")}"
                    lblIssueDate.Text = Convert.ToDateTime(reader("issue_date")).ToString("MM/dd/yyyy")
                    lblDueDate.Text = Convert.ToDateTime(reader("due_date")).ToString("MM/dd/yyyy")
                    bookid = Integer.Parse(reader("book_id").ToString())
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

End Class