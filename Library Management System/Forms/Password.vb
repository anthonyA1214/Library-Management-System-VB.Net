Imports System.Data.SqlClient

Public Class Password
    Private Id As Integer
    Public Sub New(id As Integer)
        InitializeComponent()
        Me.Id = id
    End Sub

    Private Sub loadPassword()
        Dim password As String = ""
        Using conn As SqlConnection = dbConnection.GetConnection()
            Dim query As String = "SELECT password FROM tbl_member WHERE member_id = @memberid AND IsDeleted = 0"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@memberid", Id)

            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                password = reader("password").ToString()
            End If
        End Using
        tbCurrentPassword.Text = password
    End Sub

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPassword()
        visibility1.Visible = True
        visibility2.Visible = False
        visibility3.Visible = False
        tbCurrentPassword.UseSystemPasswordChar = True
        tbNewPassword.UseSystemPasswordChar = True
        tbConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub tbNewPassword_TextChanged(sender As Object, e As EventArgs) Handles tbNewPassword.TextChanged
        visibility2.Visible = True
        If String.IsNullOrEmpty(tbNewPassword.Text) Then
            visibility2.Visible = False
        End If
    End Sub

    Private Sub tbConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles tbConfirmPassword.TextChanged
        visibility3.Visible = True
        If String.IsNullOrEmpty(tbConfirmPassword.Text) Then
            visibility3.Visible = False
        End If
    End Sub

    Private Sub visibility1_Click(sender As Object, e As EventArgs) Handles visibility1.Click
        If tbCurrentPassword.UseSystemPasswordChar Then
            visibility1.Image = My.Resources.visibilityoff
            tbCurrentPassword.UseSystemPasswordChar = False
        Else
            visibility1.Image = My.Resources.visibilityon
            tbCurrentPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub visibility2_Click(sender As Object, e As EventArgs) Handles visibility2.Click
        If tbNewPassword.UseSystemPasswordChar Then
            visibility2.Image = My.Resources.visibilityoff
            tbNewPassword.UseSystemPasswordChar = False
        Else
            visibility2.Image = My.Resources.visibilityon
            tbNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub visibility3_Click(sender As Object, e As EventArgs) Handles visibility3.Click
        If tbConfirmPassword.UseSystemPasswordChar Then
            visibility3.Image = My.Resources.visibilityoff
            tbConfirmPassword.UseSystemPasswordChar = False
        Else
            visibility3.Image = My.Resources.visibilityon
            tbConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim newPassword As String = tbNewPassword.Text
        Dim confirmPassword As String = tbConfirmPassword.Text

        ' Input validations
        If String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("The New Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNewPassword.Focus()
            Return
        ElseIf String.IsNullOrEmpty(confirmPassword) Then
            MessageBox.Show("The Confirm Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbConfirmPassword.Focus()
            Return
        ElseIf newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please re-enter the password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNewPassword.Focus()
            Return
        End If

        ' Confirmation before update
        Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to change the password?", "Confirm Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = DialogResult.No Then
            Return
        End If

        ' Update password in database
        Dim query As String = "UPDATE tbl_member SET password = @password WHERE member_id = @memberid"
        Using conn As SqlConnection = dbConnection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@memberid", Id)
                cmd.Parameters.AddWithValue("@password", newPassword)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Password has been successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No records were updated. Please check the member ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                conn.Close()
            End Using
        End Using
    End Sub

End Class