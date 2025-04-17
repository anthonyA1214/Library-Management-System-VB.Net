Imports System.Data.SqlClient

Public Class AuthenticateUserResult
    Private _role As String
    Private _message As String
    Private _isSuccesful As Boolean

    Public Property Role As String
        Get
            Return _role
        End Get
        Set(value As String)
            _role = value
        End Set
    End Property

    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            _message = value
        End Set
    End Property

    Public Property IsSuccesful As Boolean
        Get
            Return _isSuccesful
        End Get
        Set(value As Boolean)
            _isSuccesful = value
        End Set
    End Property
End Class

Public Class AuthenticateUser
    Public Function authenticateUser(username As String, password As String) As AuthenticateUserResult
        Dim result As New AuthenticateUserResult
        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()
                Dim query As String = "
                    SELECT role, IsDeleted, IsApproved 
                    FROM tbl_staff 
                    WHERE username = @username COLLATE Latin1_General_CS_AS 
                      AND password = @password COLLATE Latin1_General_CS_AS"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            Dim isDeleted As Boolean = Convert.ToBoolean(dr("IsDeleted"))
                            Dim isApproved As Boolean = Convert.ToBoolean(dr("IsApproved"))

                            If Not isApproved Then
                                result.Message = "Your account is not approved yet."
                                result.IsSuccesful = False
                                Return result
                            End If

                            If isDeleted Then
                                result.Message = "Incorrect username or password."
                                result.IsSuccesful = False
                                Return result
                            End If

                            result.IsSuccesful = True
                            result.Role = dr("role").ToString().ToLower().Trim()
                        Else
                            result.Message = "Incorrect username or password."
                            result.IsSuccesful = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            result.IsSuccesful = False
            MessageBox.Show("An error occurred: " & ex.Message)
            result.Message = "An error occurred: " & ex.Message
        End Try

        Return result
    End Function

    Public Function authenticateBorrower(customMemberId As String, password As String) As AuthenticateUserResult
        Dim result As New AuthenticateUserResult

        Try
            Using conn As SqlConnection = dbConnection.GetConnection()
                conn.Open()

                Dim query As String = "
                    SELECT member_id, IsDeleted
                    FROM tbl_member
                    WHERE custom_member_id = @CustomMemberId COLLATE Latin1_General_CS_AS 
                      AND password = @Password COLLATE Latin1_General_CS_AS
                "

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomMemberId", customMemberId)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using dr As SqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            Dim isDeleted As Boolean = Convert.ToBoolean(dr("IsDeleted"))

                            If isDeleted Then
                                result.Message = "Your account has been deactivated."
                                result.IsSuccesful = False
                                Return result
                            End If

                            result.IsSuccesful = True
                            result.Role = "borrower"
                        Else
                            result.Message = "Incorrect Member ID or password."
                            result.IsSuccesful = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            result.IsSuccesful = False
            result.Message = "An error occurred: " & ex.Message
            MessageBox.Show(result.Message)
        End Try

        Return result
    End Function
End Class
