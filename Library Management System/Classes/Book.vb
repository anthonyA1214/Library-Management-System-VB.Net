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
        Dim bookId As Integer
        Dim queryBook As String = "INSERT INTO tbl_book (title, author, isbn, genre, publication_year, quantity)
                           OUTPUT INSERTED.book_id 
                           VALUES (@title, @author, @isbn, @genre, @publicationyear, @quantity)"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()

            Using trans As SqlTransaction = conn.BeginTransaction()
                Try
                    Using cmdBook As New SqlCommand(queryBook, conn, trans)
                        cmdBook.Parameters.AddWithValue("@title", book.Title)
                        cmdBook.Parameters.AddWithValue("@author", book.Author)
                        cmdBook.Parameters.AddWithValue("@isbn", book.ISBN)
                        cmdBook.Parameters.AddWithValue("@genre", book.Genre)
                        cmdBook.Parameters.AddWithValue("@publicationyear", book.PublicationYear)
                        cmdBook.Parameters.AddWithValue("@quantity", book.Quantity)

                        bookId = Convert.ToInt32(cmdBook.ExecuteScalar())
                    End Using

                    Dim queryCopy As String = "INSERT INTO tbl_book_copy (book_id, isbn, copy_number)
                                       VALUES (@book_id, @isbn, @copy_number)"

                    For i As Integer = 1 To book.Quantity
                        Using cmdCopy As New SqlCommand(queryCopy, conn, trans)
                            cmdCopy.Parameters.AddWithValue("@book_id", bookId)
                            cmdCopy.Parameters.AddWithValue("@isbn", book.ISBN)
                            cmdCopy.Parameters.AddWithValue("@copy_number", i)
                            cmdCopy.ExecuteNonQuery()
                        End Using
                    Next

                    trans.Commit()
                    Return True

                Catch ex As Exception
                    trans.Rollback()
                    Return False
                End Try
            End Using
        End Using

    End Function

    Public Function UpdateBook(book As Book) As Boolean
        Dim query As String = "UPDATE tbl_book SET title = @title, author = @author, genre = @genre, publication_year = @publicationyear WHERE book_id = @bookid"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@bookid", book.BookId)
                cmd.Parameters.AddWithValue("@title", book.Title)
                cmd.Parameters.AddWithValue("@author", book.Author)
                cmd.Parameters.AddWithValue("@genre", book.Genre)
                cmd.Parameters.AddWithValue("@publicationyear", book.PublicationYear)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function
End Class