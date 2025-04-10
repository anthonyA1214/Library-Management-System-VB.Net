Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ViewRecords
    Inherits Form

    Dim conn As SqlConnection = dbConnection.GetConnection()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub updateFont()
        ' Change cell font
        For Each c As DataGridViewColumn In dgvIssue.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next

    End Sub

    Private Sub LoadTable()
        updateFont()
        Dim query As String = "SELECT tbl_issue.custom_issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvIssue.DataSource = dt
        dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvIssue.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub ViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCustomRange.Visible = False
        LoadTable()
        cbLoanStatus.Text = "All"
        cbDateRange.Text = "All"
        cbSearchBy.Text = "Member Name"
    End Sub

    Private Sub SearchFilter()
        Dim searchQuery As String = "SELECT tbl_issue.custom_issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE 1 = 1"

        Dim search As String = tbSearch.Text
        Dim status As String = cbLoanStatus.Text
        Dim startDate As String = dtpStartDate.Value.ToString("MM/dd/yyyy")
        Dim endDate As String = dtpEndDate.Value.ToString("MM/dd/yyyy")

        If Not String.IsNullOrEmpty(search) Then
            If cbSearchBy.Text = "Member Name" Then
                searchQuery &= " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search"
            ElseIf cbSearchBy.Text = "Book Title" Then
                searchQuery &= " AND tbl_book.title LIKE @search"
            End If
        End If

        If cbLoanStatus.Text <> "All" Then
            searchQuery &= " AND tbl_issue.status = @status"
        End If

        If cbDateRange.Text <> "All" Then
            If cbDateRange.Text = "Last 7 Days" Then
                searchQuery &= " AND tbl_issue.issue_date >= DATEADD(day, -7, GETDATE())"
            ElseIf cbDateRange.Text = "This Month" Then
                searchQuery &= " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE()) AND MONTH(tbl_issue.due_date) = MONTH(GETDATE())"
            ElseIf cbDateRange.Text = "This Year" Then
                searchQuery &= " AND YEAR(tbl_issue.issue_date) = YEAR(GETDATE())"
            ElseIf cbDateRange.Text = "Custom Range" Then
                searchQuery &= " AND tbl_issue.issue_date BETWEEN @startdate AND @enddate"
            End If
        End If

        Dim cmd As New SqlCommand(searchQuery, conn)

        If Not String.IsNullOrEmpty(search) Then
            cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        End If

        If cbLoanStatus.Text <> "All" Then
            cmd.Parameters.AddWithValue("@status", status)
        End If

        If cbDateRange.Text = "Custom Range" Then
            cmd.Parameters.AddWithValue("@startdate", startDate)
            cmd.Parameters.AddWithValue("@enddate", endDate)
        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvIssue.DataSource = dt
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        SearchFilter()
    End Sub

    Private Sub cbLoanStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoanStatus.SelectedIndexChanged
        SearchFilter()
    End Sub

    Private Sub cbDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDateRange.SelectedIndexChanged
        SearchFilter()
        If cbDateRange.Text = "Custom Range" Then
            pnlCustomRange.Visible = True
        Else
            pnlCustomRange.Visible = False
        End If
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        SearchFilter()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        SearchFilter()
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbSearchBy.Text = "Member Name"
        cbLoanStatus.Text = "All"
        cbDateRange.Text = "All"
        tbSearch.Clear()
        SearchFilter()
    End Sub
End Class