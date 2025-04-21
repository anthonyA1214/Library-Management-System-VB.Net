Imports System.Data.SqlClient

Public Class BorrowBook

    Private conn As SqlConnection = dbConnection.GetConnection()
    Private bookid As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub updateFont()
        ' Change cell font
        For Each c As DataGridViewColumn In dgvBook.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Private Sub LoadTable()
        updateFont()
        Dim query As String = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity], CASE WHEN quantity > 0 THEN 'Available' ELSE 'Unavailable' END AS [Availability Status] from tbl_book WHERE IsDeleted = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
        dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        AddHandler dgvBook.CellFormatting, AddressOf dgvBook_CellFormatting
    End Sub

    Private Sub LoadGenre()
        cbGenre.Items.Clear()
        Try
            Dim query As String = "SELECT genre_name FROM tbl_genre"
            cbGenre.Items.Add("All")
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

    Private Sub BorrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadGenre()
        cbSearchBy.Text = "Title"
        cbGenre.Text = "All"
        cbAvailabilityStatus.Text = "All"
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub dgvBook_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If dgvBook.Columns(e.ColumnIndex).Name = "Quantity" AndAlso e.Value IsNot Nothing Then
            Dim quantity As Integer
            If Integer.TryParse(e.Value.ToString(), quantity) Then
                If quantity = 0 Then
                    dgvBook.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                ElseIf quantity < 5 Then
                    dgvBook.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 153)
                Else
                    dgvBook.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225)
                End If
            End If
        End If
    End Sub

    Private Sub dgvBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SearchFilter()
        Dim query As String = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity], CASE WHEN quantity > 0 THEN 'Available' ELSE 'Unavailable' END AS [Availability Status] FROM tbl_book WHERE IsDeleted = 0"

        If Not String.IsNullOrEmpty(tbSearch.Text) Then
            Dim search As String = tbSearch.Text
            Dim pattern As String = "^b-\d{6}$"  ' ^b- means starting with 'b-', \d{6} means exactly six digits, $ means end of the string
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
        End If

        ' Check if cbGenre has a selected item before using it
        If cbGenre.SelectedItem IsNot Nothing AndAlso cbGenre.SelectedItem.ToString() <> "All" Then
            Dim genre As String = cbGenre.SelectedItem.ToString()
            query += " AND genre LIKE @genre"
        End If

        ' Check if cbAvailabilityStatus has a selected item before using it
        If cbAvailabilityStatus.SelectedItem IsNot Nothing AndAlso cbAvailabilityStatus.Text <> "All" Then
            If cbAvailabilityStatus.Text = "Available" Then
                query += " AND quantity > 0"
            ElseIf cbAvailabilityStatus.Text = "Unavailable" Then
                query += " AND quantity = 0"
            End If
        End If

        Dim cmd As New SqlCommand(query, conn)

        ' Add parameters only if the search textbox is not empty
        If Not String.IsNullOrEmpty(tbSearch.Text) Then
            Dim search As String = tbSearch.Text
            cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        End If

        ' Add genre parameter only if a genre is selected
        If cbGenre.SelectedItem IsNot Nothing AndAlso cbGenre.SelectedItem.ToString() <> "All" Then
            Dim genre As String = cbGenre.SelectedItem.ToString()
            cmd.Parameters.AddWithValue("@genre", genre)
        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvBook.DataSource = dt
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        SearchFilter()
    End Sub

    Private Sub cbGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGenre.SelectedIndexChanged
        SearchFilter()
    End Sub

    Private Sub cbAvailabilityStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAvailabilityStatus.SelectedIndexChanged
        SearchFilter()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbSearchBy.Text = "Title"
        cbGenre.Text = "All"
        cbAvailabilityStatus.Text = "All"
        tbSearch.Clear()
        SearchFilter()
    End Sub
End Class