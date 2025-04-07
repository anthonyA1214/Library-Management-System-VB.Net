Imports System.Data.SqlClient

Public Class dbConnection
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=DESKTOP-V0TL6JC\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;Encrypt=False;"
        Dim conn As New SqlConnection(connectionString)
        Return conn
    End Function
End Class
