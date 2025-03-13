Imports ClosedXML.Excel
Imports System.Data.SqlClient

Public Class MemberActivityReport
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim conn As SqlConnection = dbConnection.GetConnection()

    Private Sub LoadTable()
        Dim query As String = "SELECT tbl_member.member_id AS [Member ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], COUNT(tbl_issue.issue_id) AS [Total Borrowed Books], SUM(CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.issue_id IS NOT NULL THEN 1 ELSE 0 END) AS [Currently Borrowed], SUM(CASE WHEN tbl_issue.return_date IS NOT NULL THEN 1 ELSE 0 END) AS [Returned Books] FROM tbl_member LEFT JOIN tbl_issue ON tbl_member.member_id = tbl_issue.member_id GROUP BY tbl_member.member_id, tbl_member.first_name, tbl_member.last_name"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
        dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub MemberActivityReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSearchBy.Text = "Name"
        LoadTable()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT tbl_member.member_id AS [Member ID], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], COUNT(tbl_issue.issue_id) AS [Total Borrowed Books], SUM(CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.issue_id IS NOT NULL THEN 1 ELSE 0 END) AS [Currently Borrowed], SUM(CASE WHEN tbl_issue.return_date IS NOT NULL THEN 1 ELSE 0 END) AS [Returned Books] FROM tbl_member LEFT JOIN tbl_issue ON tbl_member.member_id = tbl_issue.member_id WHERE 1=1"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            LoadTable()
            Return
        End If

        If cbSearchBy.Text = "Name" Then
            query &= " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search"
        ElseIf cbSearchBy.Text = "ID" Then
            Dim id As Integer
            If Not Integer.TryParse(search, id) Then
                Return
            End If
            query &= " AND tbl_member.member_id LIKE @search"
        End If

        query &= " GROUP BY tbl_member.member_id, tbl_member.first_name, tbl_member.last_name ORDER BY [Total Borrowed Books] DESC"

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvMember.Rows.Count = 0 Then
            MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog() With {
            .Filter = "Excel Workbook | *.xlsx",
            .Title = "Save Excel File",
            .FileName = "MemberActivityReport.xlsx"
        }
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim worksheet = workbook.Worksheets.Add("MemberActivityReport")
                        Dim colIndex As Integer = 1

                        For i As Integer = 0 To dgvMember.Columns.Count - 1
                            If TypeOf dgvMember.Columns(i) Is DataGridViewImageColumn Then
                                Continue For
                            End If

                            worksheet.Cell(1, colIndex).Value = dgvMember.Columns(i).HeaderText
                            colIndex += 1
                        Next

                        For i As Integer = 0 To dgvMember.Rows.Count - 1
                            colIndex = 1
                            For j As Integer = 0 To dgvMember.Columns.Count - 1
                                If TypeOf dgvMember.Columns(j) Is DataGridViewImageColumn Then
                                    Continue For
                                End If

                                If dgvMember.Rows(i).Cells(j).Value IsNot Nothing Then
                                    worksheet.Cell(i + 2, colIndex).Value = dgvMember.Rows(i).Cells(j).Value.ToString()
                                End If
                                colIndex += 1
                            Next
                        Next

                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Export successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub
End Class