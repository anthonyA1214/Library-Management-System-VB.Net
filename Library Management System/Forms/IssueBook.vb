Imports System.Data.SqlClient
Imports System.Net
Imports System.Text.RegularExpressions

Public Class IssueBook
    Inherits Form

    Private conn As SqlConnection = dbConnection.GetConnection()

    Private bookid As Integer, memberid As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub updateFont()
        ' Change cell font
        For Each c As DataGridViewColumn In dgvBook.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Private Sub loadMemberTable()
        updateFont()
        Dim query As String = "SELECT custom_member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name] from tbl_member WHERE IsDeleted = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvMember.DataSource = dt
        dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub loadBookTable()
        updateFont()
        Dim query As String = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
        dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub clearTexts()
        lblMemberID.Text = ""
        lblMemberName.Text = ""
        lblBookID.Text = ""
        lblBookTitle.Text = ""
        lblBookAuthor.Text = ""
    End Sub

    Private Sub dgvBook_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso dgvBook.Rows(e.RowIndex).Cells(e.ColumnIndex) IsNot Nothing Then
            Dim customBookId As String = dgvBook.Rows(e.RowIndex).Cells(0).Value.ToString()
            bookid = Integer.Parse(customBookId.Substring(2))

            Dim query As String = "SELECT * from tbl_book WHERE book_id = @bookid"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@bookid", bookid)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            lblBookID.Text = ds.Tables(0).Rows(0)(1).ToString()
            lblBookTitle.Text = ds.Tables(0).Rows(0)(2).ToString()
            lblBookAuthor.Text = ds.Tables(0).Rows(0)(3).ToString()
        End If
    End Sub

    Private Sub dgvMember_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMember.CellClick
        If e.RowIndex >= 0 AndAlso dgvMember.Rows(e.RowIndex).Cells(e.ColumnIndex) IsNot Nothing Then
            Dim customBookId As String = dgvMember.Rows(e.RowIndex).Cells(0).Value.ToString()
            memberid = Integer.Parse(customBookId.Substring(2))

            Dim query As String = "SELECT * from tbl_member WHERE member_id = @memberid"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@memberid", memberid)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            lblMemberID.Text = ds.Tables(0).Rows(0)(1).ToString()
            lblMemberName.Text = ds.Tables(0).Rows(0)(2).ToString() & " " & ds.Tables(0).Rows(0)(3).ToString()
        End If
    End Sub

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMemberTable()
        loadBookTable()
        clearTexts()
        cbSearchBy1.Text = "Name"
        cbSearchBy2.Text = "Title"
        lblMemberName.AutoEllipsis = True
        lblBookTitle.AutoEllipsis = True
        lblBookAuthor.AutoEllipsis = True
        dtpIssueDate.Value = DateTime.Now.Date
        dtpDueDate.Value = DateTime.Now.Date
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        Dim issuedate As DateTime = dtpIssueDate.Value
        Dim duedate As DateTime = dtpDueDate.Value
        Dim currentdate As DateTime = DateTime.Now.Date

        If memberid = 0 OrElse bookid = 0 Then
            MessageBox.Show("Please select a borrower and a book.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()

            ' Check book quantity
            Dim checkQtyQuery As String = "SELECT quantity FROM tbl_book WHERE book_id = @bookid"
            Dim checkQtyCmd As New SqlCommand(checkQtyQuery, conn)
            checkQtyCmd.Parameters.AddWithValue("@bookid", bookid)
            Dim copiesAvailable As Integer = Convert.ToInt32(checkQtyCmd.ExecuteScalar())

            If issuedate < currentdate Then
                MessageBox.Show("Issue date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpIssueDate.Value = currentdate
                Return
            End If

            If copiesAvailable <= 0 Then
                MessageBox.Show("No available copies for this book.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If duedate < issuedate Then
                MessageBox.Show("Due date must be after issue date.", "Invalid Due Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Check borrowing limit
            Dim limitQuery As String = "SELECT mt.borrowing_limit FROM tbl_member m JOIN tbl_membership_type mt ON m.membership_type = mt.membership_type WHERE m.member_id = @memberid"
            Dim limitCmd As New SqlCommand(limitQuery, conn)
            limitCmd.Parameters.AddWithValue("@memberid", memberid)
            Dim borrowingLimit As Integer = Convert.ToInt32(limitCmd.ExecuteScalar())

            Dim countQuery As String = "SELECT COUNT(*) FROM tbl_issue WHERE member_id = @memberid AND status = 'Issued'"
            Dim countCmd As New SqlCommand(countQuery, conn)
            countCmd.Parameters.AddWithValue("@memberid", memberid)
            Dim borrowedCount As Integer = Convert.ToInt32(countCmd.ExecuteScalar())

            If borrowedCount >= borrowingLimit Then
                MessageBox.Show($"This member has reached their borrowing limit of {borrowingLimit} books.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Find an available copy
            Dim copyQuery As String = "SELECT TOP 1 copy_id FROM tbl_book_copy WHERE book_id = @bookid AND status = 'Available'"
            Dim copyCmd As New SqlCommand(copyQuery, conn)
            copyCmd.Parameters.AddWithValue("@bookid", bookid)
            Dim copy_id As Object = copyCmd.ExecuteScalar()

            If copy_id Is Nothing Then
                MessageBox.Show("No available copies found in copy table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to issue this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogResult = DialogResult.Yes Then
                ' Insert issue record with copy_id
                Dim issueQuery As String = "INSERT INTO tbl_issue (book_id, member_id, issue_date, due_date, status, copy_id) VALUES (@bookid, @memberid, @issuedate, @duedate, 'Issued', @copyid)"
                Dim issueCmd As New SqlCommand(issueQuery, conn)
                issueCmd.Parameters.AddWithValue("@bookid", bookid)
                issueCmd.Parameters.AddWithValue("@memberid", memberid)
                issueCmd.Parameters.AddWithValue("@issuedate", issuedate)
                issueCmd.Parameters.AddWithValue("@duedate", duedate)
                issueCmd.Parameters.AddWithValue("@copyid", copy_id)
                Dim checkIssue As Integer = issueCmd.ExecuteNonQuery()

                ' Update copy status
                Dim updateCopyQuery As String = "UPDATE tbl_book_copy SET status = 'Issued' WHERE copy_id = @copyid"
                Dim updateCopyCmd As New SqlCommand(updateCopyQuery, conn)
                updateCopyCmd.Parameters.AddWithValue("@copyid", copy_id)
                Dim checkUpdateCopy As Integer = updateCopyCmd.ExecuteNonQuery()

                ' Decrease quantity in tbl_book
                Dim updateQtyQuery As String = "UPDATE tbl_book SET quantity = quantity - 1 WHERE book_id = @bookid"
                Dim updateQtyCmd As New SqlCommand(updateQtyQuery, conn)
                updateQtyCmd.Parameters.AddWithValue("@bookid", bookid)
                updateQtyCmd.ExecuteNonQuery()

                If checkIssue > 0 AndAlso checkUpdateCopy > 0 Then
                    MessageBox.Show("Book issued successfully. Inventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearTexts()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            loadBookTable()
            loadMemberTable()
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

    Private Sub tbSearch2_TextChanged(sender As Object, e As EventArgs)
        Dim query As String = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0"
        Dim search As String = tbSearch2.Text

        If String.IsNullOrEmpty(tbSearch2.Text) Then
            loadBookTable()
            Return
        End If

        If cbSearchBy2.Text = "Title" Then
            query += " AND title LIKE @search"
        ElseIf cbSearchBy2.Text = "Author" Then
            query += " AND author LIKE @search"
        ElseIf cbSearchBy2.Text = "ISBN" Then
            query += " AND isbn LIKE @search"
        ElseIf cbSearchBy2.Text = "ID" Then
            Dim pattern As String = "^b-\d{6}$"
            If Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern, RegexOptions.IgnoreCase) Then Return
            query += " AND custom_book_id LIKE @search" ' Use custom_book_id instead of book_id
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class