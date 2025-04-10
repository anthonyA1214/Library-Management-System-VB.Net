Imports System.Data.SqlClient

Public Class ViewBooks
    Dim conn As SqlConnection = dbConnection.GetConnection()
    Private Sub updateFont()
        For Each c As DataGridViewColumn In dgvBook.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next

    End Sub

    Private Sub SearchFilter()
        Dim searchQuery As String = "
    SELECT 
        tbl_book.title AS [Title], 
        tbl_book.isbn AS [ISBN], 
        tbl_book_copy.accession_number AS [Accession Number], 
        tbl_book_copy.status AS [Status]
    FROM 
        tbl_book
    INNER JOIN 
        tbl_book_copy ON tbl_book.book_id = tbl_book_copy.book_id
    WHERE 
        tbl_book.IsDeleted = 0"

        Dim search As String = tbSearch.Text.Trim()
        Dim searchBy As String = cbSearchBy.Text
        Dim status As String = cbStatus.Text
        Dim bookTitle As String = cbBooks.Text

        ' Filter by Title or ISBN
        If Not String.IsNullOrEmpty(search) Then
            If searchBy = "Title" Then
                searchQuery &= " AND tbl_book.title LIKE @search"
            ElseIf searchBy = "ISBN" Then
                searchQuery &= " AND tbl_book.isbn LIKE @search"
            End If
        End If

        ' Filter by Book Title from ComboBox
        If bookTitle <> "All" AndAlso Not String.IsNullOrEmpty(bookTitle) Then
            searchQuery &= " AND tbl_book.title = @bookTitle"
        End If

        ' Filter by Book Copy Status (e.g., Available, Issued)
        If status <> "All" AndAlso Not String.IsNullOrEmpty(status) Then
            searchQuery &= " AND tbl_book_copy.status = @status"
        End If

        searchQuery &= " ORDER BY tbl_book.isbn ASC"

        Try
            conn.Open()
            Dim cmd As New SqlCommand(searchQuery, conn)

            If Not String.IsNullOrEmpty(search) Then
                cmd.Parameters.AddWithValue("@search", "%" & search & "%")
            End If

            If bookTitle <> "All" AndAlso Not String.IsNullOrEmpty(bookTitle) Then
                cmd.Parameters.AddWithValue("@bookTitle", bookTitle)
            End If

            If status <> "All" AndAlso Not String.IsNullOrEmpty(status) Then
                cmd.Parameters.AddWithValue("@status", status)
            End If

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBook.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error while searching: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub LoadTable()
        updateFont()
        Dim query As String = "
        SELECT 
            tbl_book.title AS [Title], 
            tbl_book.isbn AS [ISBN], 
            tbl_book_copy.accession_number AS [Accession Number], 
            tbl_book_copy.status AS [Status]
        FROM 
            tbl_book
        INNER JOIN 
            tbl_book_copy ON tbl_book.book_id = tbl_book_copy.book_id
        WHERE 
            tbl_book.IsDeleted = 0
        ORDER BY 
            tbl_book.isbn ASC"

        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
        dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub loadBooks()
        cbBooks.Items.Clear()
        cbBooks.Items.Add("All")
        Try
            Dim query As String = "SELECT title FROM tbl_book"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cbBooks.Items.Add(reader("title").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub ViewBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        loadBooks()
        cbSearchBy.Text = "Title"
        cbBooks.Text = "All"
        cbStatus.Text = "All"
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        SearchFilter()
    End Sub

    Private Sub cbBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBooks.SelectedIndexChanged
        SearchFilter()
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        SearchFilter()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbSearchBy.Text = "Title"
        cbBooks.Text = "All"
        cbStatus.Text = "All"
        tbSearch.Clear()
        LoadTable()
    End Sub
End Class