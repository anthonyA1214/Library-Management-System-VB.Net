Imports System.Data.SqlClient

Public Class Staff
    Public Property StaffId As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Username As String
    Public Property Password As String
    Public Property Email As String
    Public Property ContactNumber As String
    Public Property Role As String
    Public Property IsApproved As Boolean
    Public Property IsDeleted As Boolean

    Public Sub New(staffId As Integer, firstName As String, lastName As String, username As String, password As String, email As String, contactNumber As String, role As String, isApproved As Boolean, isDeleted As Boolean)
        Me.StaffId = staffId
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Username = username
        Me.Password = password
        Me.Email = email
        Me.ContactNumber = contactNumber
        Me.Role = role
        Me.IsApproved = isApproved
        Me.IsDeleted = isDeleted
    End Sub
End Class

Public Class ManageStaffs
    Public Function AddStaff(staff As Staff) As Boolean
        Using conn As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "INSERT INTO tbl_staff (first_name, last_name, username, password, email, contact_number, role, IsApproved, IsDeleted) VALUES(@firstname, @lastname, @username, @password, @email, @contactnumber, @role, @isApproved, @isDeleted)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstname", staff.FirstName)
                cmd.Parameters.AddWithValue("@lastname", staff.LastName)
                cmd.Parameters.AddWithValue("@username", staff.Username)
                cmd.Parameters.AddWithValue("@password", staff.Password)
                cmd.Parameters.AddWithValue("@email", staff.Email)
                cmd.Parameters.AddWithValue("@contactnumber", staff.ContactNumber)
                cmd.Parameters.AddWithValue("@role", staff.Role)
                cmd.Parameters.AddWithValue("@isApproved", staff.IsApproved)
                cmd.Parameters.AddWithValue("@isDeleted", staff.IsDeleted)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function

    Public Function UpdateStaff(staff As Staff) As Boolean
        Dim query As String = "UPDATE tbl_staff SET first_name = @firstname, last_name = @lastname, password = @password, contact_number = @contactnumber, role = @role WHERE staff_id = @staffid"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@staffid", staff.StaffId)
                cmd.Parameters.AddWithValue("@firstname", staff.FirstName)
                cmd.Parameters.AddWithValue("@lastname", staff.LastName)
                cmd.Parameters.AddWithValue("@username", staff.Username)
                cmd.Parameters.AddWithValue("@password", staff.Password)
                cmd.Parameters.AddWithValue("@email", staff.Email)
                cmd.Parameters.AddWithValue("@contactnumber", staff.ContactNumber)
                cmd.Parameters.AddWithValue("@role", staff.Role)
                cmd.Parameters.AddWithValue("@isApproved", staff.IsApproved)
                cmd.Parameters.AddWithValue("@isDeleted", staff.IsDeleted)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function
End Class
