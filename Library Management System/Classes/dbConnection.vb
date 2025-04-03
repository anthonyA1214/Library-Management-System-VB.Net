Imports System.Data.SqlClient

Public Class dbConnection
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=NHETTEFELICES04\SQLEXPRESS;Initial Catalog=db_LibraryManagementSystem;Integrated Security=True;"
        Dim conn As New SqlConnection(connectionString)
        Return conn
    End Function
End Class
