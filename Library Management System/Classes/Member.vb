Imports System.Data.SqlClient

Public Class Member
    Public Property MemberId As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Age As Integer
    Public Property Address As String
    Public Property ContactNumber As String
    Public Property Email As String
    Public Property MembershipType As String

    Public Sub New(memberId As Integer, firstName As String, lastName As String, age As Integer, address As String, contactNumber As String, email As String, membershipType As String)
        Me.MemberId = memberId
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Age = age
        Me.Address = address
        Me.ContactNumber = contactNumber
        Me.Email = email
        Me.MembershipType = membershipType
    End Sub
End Class

Public Class ManageMembers
    Public Function AddMember(member As Member) As Boolean
        Dim query As String = "INSERT INTO tbl_member(first_name, last_name, age, address, contact_number, email, membership_type) VALUES(@firstname, @lastname, @age, @address, @contactnumber, @email, @membershiptype)"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@firstname", member.FirstName)
                cmd.Parameters.AddWithValue("@lastname", member.LastName)
                cmd.Parameters.AddWithValue("@age", member.Age)
                cmd.Parameters.AddWithValue("@address", member.Address)
                cmd.Parameters.AddWithValue("@contactnumber", member.ContactNumber)
                cmd.Parameters.AddWithValue("@email", member.Email)
                cmd.Parameters.AddWithValue("@membershiptype", member.MembershipType)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function

    Public Function UpdateMember(member As Member) As Boolean
        Dim query As String = "UPDATE tbl_member SET first_name = @firstname, last_name = @lastname, age = @age, address = @address, contact_number = @contactnumber, email = @email, membership_type = @membershiptype WHERE member_id = @memberid"

        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@memberid", member.MemberId)
                cmd.Parameters.AddWithValue("@firstname", member.FirstName)
                cmd.Parameters.AddWithValue("@lastname", member.LastName)
                cmd.Parameters.AddWithValue("@age", member.Age)
                cmd.Parameters.AddWithValue("@address", member.Address)
                cmd.Parameters.AddWithValue("@contactnumber", member.ContactNumber)
                cmd.Parameters.AddWithValue("@email", member.Email)
                cmd.Parameters.AddWithValue("@membershiptype", member.MembershipType)
                Dim checkrow As Integer = cmd.ExecuteNonQuery()
                Return checkrow > 0
            End Using
        End Using
    End Function
End Class