Imports System.Data.SqlClient

Public Class MemberProfiles
    Inherits Form

    Dim conn As SqlConnection = dbConnection.GetConnection()
    Dim memberid As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadMemberTable()
        Dim query As String = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
        dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim viewactivityImgCol As New DataGridViewImageColumn With {
            .Name = "viewactivity",
            .HeaderText = String.Empty,
            .Image = My.Resources.browseactivity,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        If dgvMember.Columns("viewactivity") Is Nothing Then
            dgvMember.Columns.Add(viewactivityImgCol)
        End If
        dgvMember.Columns("viewactivity").DisplayIndex = dgvMember.Columns.Count - 1
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub ViewMemberRecords()
        Dim query1 As String = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date > tbl_issue.due_date THEN 'Overdue' ELSE 'On Time' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.member_id = @memberid;"
        Dim query2 As String = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Loan Status], 'Not Returned' AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.member_id = @memberid AND tbl_issue.return_date IS NULL;"

        Dim cmd1 As New SqlCommand(query1, conn)
        Dim cmd2 As New SqlCommand(query2, conn)

        cmd1.Parameters.AddWithValue("@memberid", memberid)
        cmd2.Parameters.AddWithValue("@memberid", memberid)

        Dim da1 As New SqlDataAdapter(cmd1)
        Dim da2 As New SqlDataAdapter(cmd2)

        Dim dt1 As New DataTable()
        Dim dt2 As New DataTable()

        da1.Fill(dt1)
        da2.Fill(dt2)

        dgvIssue1.DataSource = dt1
        dgvIssue2.DataSource = dt2

        dgvIssue1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvIssue2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvIssue1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue1.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue1.ColumnHeadersDefaultCellStyle.ForeColor
        dgvIssue2.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue2.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue2.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue2.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub MemberProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableLayoutPanel1.ColumnStyles(1).Width = 0
        cbSearchBy.Text = "Name"
        LoadMemberTable()
    End Sub

    Private Sub dgvMember_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMember.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvMember.Columns("viewactivity").Index Then
            tableLayoutPanel1.ColumnStyles(1).Width = 50
            memberid = Integer.Parse(dgvMember.Rows(e.RowIndex).Cells("Member ID").Value.ToString())
            ViewMemberRecords()
        End If
    End Sub

    Private Sub dgvMember_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvMember.CellToolTipTextNeeded
        If dgvMember.Columns(e.ColumnIndex).Name = "viewactivity" Then
            e.ToolTipText = "View Activity"
        End If
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub

    Private Sub pbExit2_Click(sender As Object, e As EventArgs) Handles pbExit2.Click
        tableLayoutPanel1.ColumnStyles(1).Width = 0
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            LoadMemberTable()
            Return
        End If

        If cbSearchBy.Text = "Name" Then
            query &= " AND CONCAT(first_name, ' ', last_name) LIKE @search"
        ElseIf cbSearchBy.Text = "ID" Then
            Dim id As Integer
            If Not Integer.TryParse(search, id) Then
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
End Class