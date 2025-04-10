Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class LoginForm
    Dim conn As SqlConnection = dbConnection.GetConnection()

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIncorrect.Visible = False
        AcceptButton = btnLogin
        cbSelectUserrole.SelectedIndex = 0
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbSelectUserrole.Text = "Borrower" Then
            If String.IsNullOrEmpty(tbUsername.Text) OrElse String.IsNullOrEmpty(tbPassword.Text) Then
                lblIncorrect.Text = "Member ID and password are required."
                lblIncorrect.Visible = True
                Return
            End If

            Dim customMemberId As String = tbUsername.Text.Trim()
            Dim password As String = tbPassword.Text

            Dim authBorrower As New AuthenticateUser()
            Dim authResult As AuthenticateUserResult = authBorrower.authenticateBorrower(customMemberId, password)

            If authResult.IsSuccesful() Then
                Dim firstName As String = ""
                Dim memberId As Integer

                Using conn As SqlConnection = dbConnection.GetConnection()
                    Dim query As String = "SELECT member_id, first_name FROM tbl_member WHERE custom_member_id = @customMemberId AND IsDeleted = 0"
                    Dim cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@customMemberId", customMemberId)

                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        firstName = reader("first_name").ToString()
                        memberId = reader("member_id").ToString()
                    End If
                End Using

                Dim borrowerForm As New BorrowerForm(firstName, memberId)
                borrowerForm.Show()
                Me.Hide()
            Else
                lblIncorrect.Text = authResult.Message
                lblIncorrect.Visible = True
            End If
        End If


        If cbSelectUserrole.Text = "Staff" Then
            If String.IsNullOrEmpty(tbUsername.Text) OrElse String.IsNullOrEmpty(tbPassword.Text) Then
                lblIncorrect.Text = "Username and password is required."
                lblIncorrect.Visible = True
                Return
            End If

            Dim username As String = tbUsername.Text
            Dim password As String = tbPassword.Text

            Dim auth As New AuthenticateUser()
            Dim authResult As AuthenticateUserResult = auth.authenticateUser(username, password)

            If authResult.IsSuccesful() Then
                If authResult.Role = "admin" Then
                    Dim adminForm As New AdminForm(username)
                    adminForm.Show()
                    Me.Hide()
                Else
                    Dim userForm As New UserForm(username)
                    userForm.Show()
                    Me.Hide()
                End If
            Else
                lblIncorrect.Text = authResult.Message
                lblIncorrect.Visible = True
            End If
        End If
    End Sub

    Private Sub tbPassword_Enter(sender As Object, e As EventArgs) Handles tbPassword.Enter
        If cbShowPassword.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged
        lblIncorrect.Visible = False
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        lblIncorrect.Visible = False
    End Sub

    Private Sub lblLinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLinkRegister.LinkClicked
        tbUsername.Clear()
        tbPassword.Clear()
        cbShowPassword.Checked = False

        Dim signup As New SignUpForm()
        signup.TopLevel = False
        signup.Dock = DockStyle.Fill
        signup.FormBorderStyle = FormBorderStyle.None
        pnlContainer.Controls.Add(signup)
        signup.BringToFront()
        signup.Show()

    End Sub
End Class
