Imports ClosedXML.Excel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CirculationReport
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub updateFont()
        For Each c As DataGridViewColumn In dgvIssue.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Dim conn As SqlConnection = dbConnection.GetConnection()

    Private Sub loadData()
        updateFont()
        Dim loadTableQuery As String = "SELECT tbl_issue.custom_issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.status AS [Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id"
        Dim query As String = "SELECT (SELECT COUNT(*) FROM tbl_issue) AS [Total Items Borrowed], (SELECT COUNT(*) FROM tbl_issue WHERE return_date IS NOT NULL) AS [Total Items Returned], (SELECT COUNT(*) FROM tbl_issue WHERE return_date IS NULL AND due_date < GETDATE()) AS [Overdue Items]"

        Dim cmd As New SqlCommand(loadTableQuery, conn)
        Dim cmd2 As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim da2 As New SqlDataAdapter(cmd2)
        conn.Open()
        Dim dr As SqlDataReader = cmd2.ExecuteReader()
        If dr.Read() Then
            lblTotalItemsBorrowed.Text = dr("Total Items Borrowed").ToString()
            lblTotalItemsReturned.Text = dr("Total Items Returned").ToString()
            lblOverdueItems.Text = dr("Overdue Items").ToString()
        End If
        dr.Close()
        conn.Close()
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvIssue.DataSource = dt
        dgvIssue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvIssue.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub CirculationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        cbSearchBy.Text = "Issue ID"
        cbLoanStatus.Text = "All"
        cbReturnStatus.Text = "All"
    End Sub

    Private Sub searchFilter()
        Dim query As String = "SELECT tbl_issue.custom_issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.status AS [Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE 1=1"
        Dim search As String = tbSearch.Text
        Dim loanStatus As String = cbLoanStatus.Text
        Dim returnStatus As String = cbReturnStatus.Text

        If Not String.IsNullOrEmpty(search) Then
            If cbSearchBy.Text = "Issue ID" Then
                Dim pattern As String = "^i-\d{6}$"
                If cbSearchBy.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern, RegexOptions.IgnoreCase) Then Return
                query &= " AND tbl_issue.custom_issue_id LIKE @search"
            ElseIf cbSearchBy.Text = "Book Title" Then
                query &= " AND tbl_book.title LIKE @search"
            ElseIf cbSearchBy.Text = "Member Name" Then
                query &= " AND CONCAT(first_name, ' ', last_name) LIKE @search"
            End If
        End If

        If cbLoanStatus.Text <> "All" Then
            query &= " AND tbl_issue.status = @loanStatus"
        End If

        If cbReturnStatus.Text <> "All" Then
            If returnStatus = "Overdue" Then
                query &= " AND tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE()"
            ElseIf returnStatus = "Not Returned" Then
                query &= " AND tbl_issue.return_date IS NULL AND tbl_issue.due_date >= GETDATE()"
            ElseIf returnStatus = "On Time" Then
                query &= " AND tbl_issue.return_date IS NOT NULL AND tbl_issue.return_date <= tbl_issue.due_date"
            ElseIf returnStatus = "Late Return" Then
                query &= " AND tbl_issue.return_date IS NOT NULL AND tbl_issue.return_date > tbl_issue.due_date"
            End If
        End If

        Dim cmd As New SqlCommand(query, conn)

        If cbLoanStatus.Text <> "All" Then
            cmd.Parameters.AddWithValue("@loanStatus", loanStatus)
        End If

        If Not String.IsNullOrEmpty(search) Then
            cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvIssue.DataSource = dt
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        searchFilter()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvIssue.Rows.Count = 0 Then
            MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog() With {
            .Filter = "Excel Workbook | *.xlsx",
            .Title = "Save Excel File",
            .FileName = "CirculationReport.xlsx"
        }
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim worksheet = workbook.Worksheets.Add("CirculationReport")

                        Dim colIndex As Integer = 1
                        For i As Integer = 0 To dgvIssue.Columns.Count - 1
                            If TypeOf dgvIssue.Columns(i) Is DataGridViewImageColumn Then
                                Continue For
                            End If

                            worksheet.Cell(1, colIndex).Value = dgvIssue.Columns(i).HeaderText
                            colIndex += 1
                        Next

                        For i As Integer = 0 To dgvIssue.Rows.Count - 1
                            colIndex = 1
                            For j As Integer = 0 To dgvIssue.Columns.Count - 1
                                If TypeOf dgvIssue.Columns(j) Is DataGridViewImageColumn Then
                                    Continue For
                                End If

                                If dgvIssue.Rows(i).Cells(j).Value IsNot Nothing Then
                                    worksheet.Cell(i + 2, colIndex).Value = dgvIssue.Rows(i).Cells(j).Value.ToString()
                                End If
                                colIndex += 1
                            Next
                        Next

                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Export successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cbLoanStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLoanStatus.SelectedIndexChanged
        searchFilter()
    End Sub

    Private Sub cbReturnStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReturnStatus.SelectedIndexChanged
        searchFilter()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbLoanStatus.Text = "All"
        cbReturnStatus.Text = "All"
        tbSearch.Clear()
        searchFilter()
    End Sub
End Class