Imports System.Data.SqlClient
Imports System.Net
Imports System.Text.RegularExpressions
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class IssueBook
    Inherits Form

    Private conn As SqlConnection = dbConnection.GetConnection()

    Private issueid As Integer, bookid As Integer, memberid As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub loadMemberTable()
        Dim query As String = "
        SELECT 
            i.issue_id,
            i.book_id,
            i.member_id,
            i.custom_issue_id AS [Issue ID],
            b.title AS [Book Title],
            CONCAT(m.first_name, ' ', m.last_name) AS [Member Name],
            b.quantity AS [Quantity],
            i.status AS [Status]
        FROM 
            tbl_issue i
        JOIN 
            tbl_book b ON i.book_id = b.book_id
        JOIN 
            tbl_member m ON i.member_id = m.member_id
        WHERE 
            i.status = 'Pending'"

        Try
            Dim cmd As New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvMember.DataSource = dt ' dgvPending = your DataGridView control
        Catch ex As Exception
            MessageBox.Show("Failed to load pending requests. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Hide the internal ID columns but keep them in the DataGridView for reference
            dgvMember.Columns("issue_id").Visible = False
            dgvMember.Columns("book_id").Visible = False
            dgvMember.Columns("member_id").Visible = False
        End Try
    End Sub


    Private Sub clearTexts()
        lblMemberID.Text = ""
        lblMemberName.Text = ""
        lblBookID.Text = ""
        lblBookTitle.Text = ""
        lblBookAuthor.Text = ""
    End Sub

    Private Sub dgvMember_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMember.CellClick
        If e.RowIndex >= 0 AndAlso dgvMember.Rows(e.RowIndex).Cells(e.ColumnIndex) IsNot Nothing Then
            Dim row As DataGridViewRow = dgvMember.Rows(e.RowIndex)
            issueid = Convert.ToInt32(Row.Cells("issue_id").Value)
            bookid = Convert.ToInt32(Row.Cells("book_id").Value)
            memberid = Convert.ToInt32(Row.Cells("member_id").Value)

            Dim query As String = "
            SELECT 
                m.custom_member_id,
                m.first_name, 
                m.last_name,
                b.custom_book_id,
                b.title, 
                b.author
            FROM 
                tbl_issue i
            JOIN 
                tbl_member m ON i.member_id = m.member_id
            JOIN 
                tbl_book b ON i.book_id = b.book_id
            WHERE 
                i.issue_id = @issueid
            "

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@issueid", issueid) ' Make sure selectedIssueId is set

            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Dim issueRow = ds.Tables(0).Rows(0) ' Changed from 'row' to 'issueRow' to avoid conflict
                lblMemberID.Text = issueRow("custom_member_id").ToString()
                lblMemberName.Text = issueRow("first_name").ToString() & " " & issueRow("last_name").ToString()
                lblBookID.Text = issueRow("custom_book_id").ToString()
                lblBookTitle.Text = issueRow("title").ToString()
                lblBookAuthor.Text = issueRow("author").ToString()
            Else
                MessageBox.Show("No data found for this issue.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            conn.Open()
            Dim qtyQuery As String = "SELECT quantity FROM tbl_book WHERE book_id = @bookid"
            Dim qtyCmd As New SqlCommand(qtyQuery, conn)
            qtyCmd.Parameters.AddWithValue("@bookid", bookid)
            Dim quantity As Integer = Convert.ToInt32(qtyCmd.ExecuteScalar())

            If quantity <= 0 Then
                btnIssueBook.Enabled = False
            Else
                btnIssueBook.Enabled = True
            End If
            conn.Close()
        End If
    End Sub

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMemberTable()
        ' Hide the internal ID columns but keep them in the DataGridView for reference
        dgvMember.Columns("issue_id").Visible = False
        dgvMember.Columns("book_id").Visible = False
        dgvMember.Columns("member_id").Visible = False
        clearTexts()
        cbSearchBy1.Text = "Name"
        lblMemberName.AutoEllipsis = True
        lblBookTitle.AutoEllipsis = True
        lblBookAuthor.AutoEllipsis = True
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        If issueid = 0 OrElse bookid = 0 OrElse memberid = 0 Then
            MessageBox.Show("Please select a request from the table first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Do you want to approve this request?", "Approve Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        Try
            conn.Open()

            ' Get the member's membership type
            Dim getMembershipTypeQuery As String = "SELECT m.membership_type FROM tbl_member m WHERE m.member_id = @memberId"
            Dim getMembershipTypeCmd As New SqlCommand(getMembershipTypeQuery, conn)
            getMembershipTypeCmd.Parameters.AddWithValue("@memberId", memberid)
            Dim membershipType As String = Convert.ToString(getMembershipTypeCmd.ExecuteScalar())

            ' Determine the due date based on membership type
            Dim dueDate As Date
            Dim issueDate As Date = DateTime.Now.Date

            Select Case membershipType
                Case "Faculty"
                    dueDate = issueDate.AddDays(2) ' Faculty members get 2 days
                Case "Staff"
                    dueDate = issueDate.AddDays(4) ' Staff members get 4 days
                Case "Student"
                    dueDate = issueDate.AddDays(3) ' Students get 3 days
                Case Else
                    MessageBox.Show("Invalid membership type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
            End Select

            ' Get an available copy
            Dim getCopyQuery As String = "SELECT TOP 1 copy_id FROM tbl_book_copy WHERE book_id = @bookId AND status = 'Available'"
            Dim getCopyCmd As New SqlCommand(getCopyQuery, conn)
            getCopyCmd.Parameters.AddWithValue("@bookId", bookid)
            Dim copyId As Object = getCopyCmd.ExecuteScalar()

            If copyId Is Nothing Then
                MessageBox.Show("No available copy found for this book.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Update tbl_issue
            Dim updateIssueQuery As String = "UPDATE tbl_issue 
                                  SET status = 'Issued', copy_id = @copyId, issue_date = @issueDate, due_date = @dueDate 
                                  WHERE issue_id = @issueId"
            Dim updateIssueCmd As New SqlCommand(updateIssueQuery, conn)
            updateIssueCmd.Parameters.AddWithValue("@copyId", copyId)
            updateIssueCmd.Parameters.AddWithValue("@issueDate", issueDate)
            updateIssueCmd.Parameters.AddWithValue("@dueDate", dueDate)
            updateIssueCmd.Parameters.AddWithValue("@issueId", issueid)
            updateIssueCmd.ExecuteNonQuery()

            ' Update copy status
            Dim updateCopyQuery As String = "UPDATE tbl_book_copy SET status = 'Issued' WHERE copy_id = @copyId"
            Dim updateCopyCmd As New SqlCommand(updateCopyQuery, conn)
            updateCopyCmd.Parameters.AddWithValue("@copyId", copyId)
            updateCopyCmd.ExecuteNonQuery()

            ' Update quantity
            Dim updateQtyQuery As String = "UPDATE tbl_book SET quantity = quantity - 1 WHERE book_id = @bookId"
            Dim updateQtyCmd As New SqlCommand(updateQtyQuery, conn)
            updateQtyCmd.Parameters.AddWithValue("@bookId", bookid)
            updateQtyCmd.ExecuteNonQuery()

            MessageBox.Show("Request approved and book issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset selection and reload table
            issueid = 0
            bookid = 0
            memberid = 0
            lblMemberID.Text = ""
            lblMemberName.Text = ""
            lblBookID.Text = ""
            lblBookTitle.Text = ""
            lblBookAuthor.Text = ""
            loadMemberTable()

        Catch ex As Exception
            MessageBox.Show("Error approving request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tbSearch1_TextChanged(sender As Object, e As EventArgs) Handles tbSearch1.TextChanged
        Dim query As String = "SELECT custom_member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name] from tbl_member WHERE IsDeleted = 0"
        Dim search As String = tbSearch1.Text

        If String.IsNullOrEmpty(tbSearch1.Text) Then
            loadMemberTable()
            Return
        End If

        If cbSearchBy1.Text = "Name" Then
            query += " AND CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) LIKE @search"
        ElseIf cbSearchBy1.Text = "ID" Then
            Dim pattern As String = "^m-\d{6}$"
            If cbSearchBy1.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern, RegexOptions.IgnoreCase) Then Return
            query += " AND custom_member_id LIKE @search"
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
    End Sub

End Class