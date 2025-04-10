Imports System.Data.SqlClient

Partial Public Class ManageBooks
    Inherits Form

    Private conn As SqlConnection = dbConnection.GetConnection()
    Private selectionMode As Integer
    Public bookid As Integer
    Private checkrow As Integer

    Public Sub New()
        InitializeComponent()
        pnlSideMenu.Visible = False
    End Sub

    Private Sub updateFont()
        For Each c As DataGridViewColumn In dgvBook.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Private Sub loadTable()
        updateFont()
        Dim query As String = "
        SELECT 
            tbl_book.custom_book_id AS [Book ID], 
            tbl_book.title AS [Title], 
            tbl_book.author AS [Author], 
            tbl_book.isbn AS [ISBN], 
            tbl_book.genre AS [Genre], 
            tbl_book.publication_year AS [Publication Year], 
            COUNT(tbl_book_copy.copy_id) AS [Total Copies]
        FROM 
            tbl_book
        LEFT JOIN 
            tbl_book_copy ON tbl_book.book_id = tbl_book_copy.book_id
        WHERE 
            tbl_book.IsDeleted = 0
        GROUP BY 
            tbl_book.custom_book_id, 
            tbl_book.title, 
            tbl_book.author, 
            tbl_book.isbn, 
            tbl_book.genre, 
            tbl_book.publication_year
        "
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
        dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

        If dgvBook.Columns("update") Is Nothing Then
            dgvBook.Columns.Add(updateImgCol)
        End If
        If dgvBook.Columns("delete") Is Nothing Then
            dgvBook.Columns.Add(deleteImgCol)
        End If

        dgvBook.Columns("update").DisplayIndex = dgvBook.Columns.Count - 1
        dgvBook.Columns("delete").DisplayIndex = dgvBook.Columns.Count - 1

        dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub loadGenre()
        cbGenre.Items.Clear()
        Try
            Dim query As String = "SELECT genre_name FROM tbl_genre"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cbGenre.Items.Add(reader("genre_name").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clearTexts()
        tbTitle.Clear()
        tbAuthor.Clear()
        tbISBN.Clear()
        cbGenre.Text = String.Empty
        dtpPublicationYear.Text = String.Empty
        numQuantity.Value = 0
    End Sub

    Private Sub ManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSideMenu.Visible = False
        selectionMode = 0
        loadTable()
        loadGenre()
        cbSearchBy.Text = "Title"
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        numQuantity.Enabled = True
        tbISBN.Enabled = True
        lblSideMenu.Text = "ADD BOOK"
        selectionMode = 1
        clearTexts()
        If pnlSideMenu.Visible = False Then
            pnlSideMenu.Visible = True
        Else
            pnlSideMenu.Visible = False
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If String.IsNullOrEmpty(tbTitle.Text) Then
            MessageBox.Show("The Title field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbTitle.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbAuthor.Text) Then
            MessageBox.Show("The Author field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbAuthor.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbISBN.Text) Then
            MessageBox.Show("The ISBN field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbISBN.Focus()
            Return
        ElseIf String.IsNullOrEmpty(cbGenre.Text) Then
            MessageBox.Show("The Genre field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbGenre.Focus()
            Return
        ElseIf Not Integer.TryParse(dtpPublicationYear.Text, Nothing) Then
            MessageBox.Show("The Publication Year field must contain a valid year!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpPublicationYear.Focus()
            Return
        ElseIf numQuantity.Value <= 0 AndAlso selectionMode <> 2 Then
            MessageBox.Show("The Quantity must be greater than 0!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numQuantity.Focus()
            Return
        End If

        Dim book As New Book(bookid, tbTitle.Text, tbAuthor.Text, tbISBN.Text, cbGenre.Text, Integer.Parse(dtpPublicationYear.Text), Integer.Parse(numQuantity.Text))
        Dim bookManager As New ManageBooks()

        Try
            If selectionMode = 2 Then
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to update this book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.No Then
                    Return
                End If
            End If

            Dim result As Boolean
            Select Case selectionMode
                Case 1
                    result = bookManager.AddBook(book)
                    If result Then
                        MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pnlSideMenu.Visible = False
                    Else
                        MessageBox.Show("Failed to add the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case 2
                    result = bookManager.UpdateBook(book)
                    If result Then
                        MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        pnlSideMenu.Visible = False
                    Else
                        MessageBox.Show("Failed to update the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As SqlException
            If ex.Number = 2627 Then
                MessageBox.Show("The ISBN already exists", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            conn.Close()
            loadTable()
        End Try
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub dgvBook_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvBook.CellToolTipTextNeeded
        If dgvBook.Columns(e.ColumnIndex).Name = "update" Then
            e.ToolTipText = "Update"
        End If
        If dgvBook.Columns(e.ColumnIndex).Name = "delete" Then
            e.ToolTipText = "Delete"
        End If
    End Sub

    Private Sub dgvBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBook.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvBook.Columns("update").Index Then
            numQuantity.Enabled = False
            tbISBN.Enabled = False
            Dim customBookId As String = dgvBook.Rows(e.RowIndex).Cells("Book ID").Value.ToString()
            bookid = Integer.Parse(customBookId.Substring(2))

            selectionMode = 2
            clearTexts()
            lblSideMenu.Text = "UPDATE BOOK"
            pnlSideMenu.Visible = True

            Dim query As String = "SELECT * FROM tbl_book WHERE book_id = @bookid"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@bookid", bookid)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)

            tbTitle.Text = ds.Tables(0).Rows(0)(2).ToString()
            tbAuthor.Text = ds.Tables(0).Rows(0)(3).ToString()
            tbISBN.Text = ds.Tables(0).Rows(0)(4).ToString()
            cbGenre.Text = ds.Tables(0).Rows(0)(5).ToString()
            Dim publicationYear As Integer = Integer.Parse(ds.Tables(0).Rows(0)(6).ToString())
            dtpPublicationYear.Value = New DateTime(publicationYear, 1, 1)
            numQuantity.Value = Decimal.Parse(ds.Tables(0).Rows(0)(7).ToString())
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvBook.Columns("delete").Index Then
            Dim customBookId As String = dgvBook.Rows(e.RowIndex).Cells("Book ID").Value.ToString()
            bookid = Integer.Parse(customBookId.Substring(2))
            Dim query As String = "UPDATE tbl_book SET IsDeleted = 1 WHERE book_id = @bookid"
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@bookid", bookid)
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dialogResult = DialogResult.No Then Return
                checkrow = cmd.ExecuteNonQuery()
                If checkrow > 0 Then
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim query As String = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 0"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            loadTable()
            Return
        End If

        Dim pattern As String = "^b-\d{6}$"
        If cbSearchBy.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern) Then Return

        If cbSearchBy.Text = "Title" Then
            query += " AND title LIKE @search"
        ElseIf cbSearchBy.Text = "Author" Then
            query += " AND author LIKE @search"
        ElseIf cbSearchBy.Text = "ISBN" Then
            query += " AND isbn LIKE @search"
        ElseIf cbSearchBy.Text = "Publication Year" Then
            query += " AND publication_year LIKE @search"
        ElseIf cbSearchBy.Text = "ID" Then
            query += " AND custom_book_id LIKE @search"
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
    End Sub

    Private Sub pbExit2_Click(sender As Object, e As EventArgs) Handles pbExit2.Click
        pnlSideMenu.Visible = False
        selectionMode = 0
    End Sub
End Class