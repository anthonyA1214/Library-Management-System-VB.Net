Imports System.Data.SqlClient

Public Class Book
    Public Property BookId As Integer
    Public Property Title As String
    Public Property Author As String
    Public Property ISBN As String
    Public Property Genre As String
    Public Property PublicationYear As Integer
    Public Property Quantity As Integer

    Public Sub New(bookId As Integer, title As String, author As String, iSBN As String, genre As String, publicationYear As Integer, quantity As Integer)
        Me.BookId = bookId
        Me.Title = title
        Me.Author = author
        Me.ISBN = iSBN
        Me.Genre = genre
        Me.PublicationYear = publicationYear
        Me.Quantity = quantity
    End Sub
End Class

Public Class ManageBooks
    Public Function AddBook(book As Book) As Boolean
        Dim query As String = "INSERT INTO tbl_book (title, author, isbn, genre, publication_year, quantity) VALUES (@title, @author, @isbn, @genre, @publicationyear, @quantity)"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@title", book.Title)
                cmd.Parameters.AddWithValue("@author", book.Author)
                cmd.Parameters.AddWithValue("@isbn", book.ISBN)
                cmd.Parameters.AddWithValue("@genre", book.Genre)
                cmd.Parameters.AddWithValue("@publicationyear", book.PublicationYear)
                cmd.Parameters.AddWithValue("@quantity", book.Quantity)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function

    Public Function UpdateBook(book As Book) As Boolean
        Dim query As String = "UPDATE tbl_book SET title = @title, author = @author, isbn = @isbn, genre = @genre, publication_year = @publicationyear, quantity = @quantity WHERE book_id = @bookid"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@bookid", book.BookId)
                cmd.Parameters.AddWithValue("@title", book.Title)
                cmd.Parameters.AddWithValue("@author", book.Author)
                cmd.Parameters.AddWithValue("@isbn", book.ISBN)
                cmd.Parameters.AddWithValue("@genre", book.Genre)
                cmd.Parameters.AddWithValue("@publicationyear", book.PublicationYear)
                cmd.Parameters.AddWithValue("@quantity", book.Quantity)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function
End Class