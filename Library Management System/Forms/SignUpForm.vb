Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Partial Public Class SignupForm
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Dim conn As SqlConnection = dbConnection.GetConnection()

    Private Sub lblLinkBack2Login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLinkBack2Login.LinkClicked
        Me.Close()
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim checkrow As Integer

        If String.IsNullOrEmpty(tbFirstName.Text) Then
            MessageBox.Show("The First Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbFirstName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbLastName.Text) Then
            MessageBox.Show("The Last Name field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbLastName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbUsername.Text) Then
            MessageBox.Show("The Username field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbPassword.Text) Then
            MessageBox.Show("The Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbConfirmPassword.Text) Then
            MessageBox.Show("The Confirm Password field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbConfirmPassword.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbEmail.Text) Then
            MessageBox.Show("The Email field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbEmail.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbContactNumber.Text) Then
            MessageBox.Show("The Contact Number field cannot be empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbContactNumber.Focus()
            Return
        ElseIf tbUsername.Text.Length < 3 OrElse tbUsername.Text.Length > 20 Then
            MessageBox.Show("The Username must be between 3 and 20 characters long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbUsername.Focus()
            Return
        ElseIf tbPassword.Text.Length < 8 Then
            MessageBox.Show("The Password must be at least 8 characters long!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Return
        ElseIf tbPassword.Text <> tbConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match. Please re-enter the password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbPassword.Focus()
            Return
        End If

        Dim firstname As String = tbFirstName.Text
        Dim lastname As String = tbLastName.Text
        Dim username As String = tbUsername.Text
        Dim password As String = tbPassword.Text
        Dim confirmpassword As String = tbConfirmPassword.Text
        Dim email As String = tbEmail.Text
        Dim contactnumber As String = tbContactNumber.Text
        Dim query As String

        Try
            Dim nameRegex As New Regex("^[a-zA-Z\s]+$", RegexOptions.IgnoreCase)
            Dim matchFirstName As Match = nameRegex.Match(firstname)
            If Not matchFirstName.Success Then
                MessageBox.Show("First name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbFirstName.Focus()
                Return
            End If

            Dim matchLastName As Match = nameRegex.Match(lastname)
            If Not matchLastName.Success Then
                MessageBox.Show("Last name should not contain numbers or special characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbLastName.Focus()
                Return
            End If

            Dim regex As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase)
            Dim match As Match = regex.Match(email)
            If Not match.Success Then
                MessageBox.Show("Invalid email format. Please ensure the email includes an '@' symbol and a valid domain (e.g., 'example@domain.com').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbEmail.Focus()
                Return
            End If

            Dim regex2 As New Regex("^09[\d]{9}$", RegexOptions.IgnoreCase)
            Dim match2 As Match = regex2.Match(contactnumber)
            If Not match2.Success Then
                MessageBox.Show("Invalid contact number format. Please ensure the number starts with '09' and is 11 digits long (e.g., '09123456789').", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbContactNumber.Focus()
                Return
            End If

            conn.Open()
            Dim cmd As New SqlCommand()
            query = "INSERT INTO tbl_staff (first_name, last_name, username, password, email, contact_number) VALUES(@firstname, @lastname, @username, @password, @email, @contactnumber)"
            cmd.CommandText = query
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@firstname", firstname)
            cmd.Parameters.AddWithValue("@lastname", lastname)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@contactnumber", contactnumber)

            checkrow = cmd.ExecuteNonQuery()

            If checkrow > 0 Then
                MessageBox.Show("Your account has been submitted successfully. Please wait for approval.", "Signup Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There was an error while submitting your account. Please try again later.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As SqlException
            If ex.Number = 2627 OrElse ex.Number = 2601 Then
                MessageBox.Show("The username or email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibility1.Visible = False
        visibility2.Visible = False
        tbPassword.UseSystemPasswordChar = True
        tbConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub tbPassword_TextChanged(sender As Object, e As EventArgs) Handles tbPassword.TextChanged
        visibility1.Visible = True
        If String.IsNullOrEmpty(tbPassword.Text) Then
            visibility1.Visible = False
        End If
    End Sub

    Private Sub tbConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles tbConfirmPassword.TextChanged
        visibility2.Visible = True
        If String.IsNullOrEmpty(tbConfirmPassword.Text) Then
            visibility2.Visible = False
        End If
    End Sub

    Private Sub visibility1_Click(sender As Object, e As EventArgs) Handles visibility1.Click
        If tbPassword.UseSystemPasswordChar Then
            visibility1.Image = My.Resources.visibilityoff
            tbPassword.UseSystemPasswordChar = False
        Else
            visibility1.Image = My.Resources.visibilityon
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub visibility2_Click(sender As Object, e As EventArgs) Handles visibility2.Click
        If tbConfirmPassword.UseSystemPasswordChar Then
            visibility2.Image = My.Resources.visibilityoff
            tbConfirmPassword.UseSystemPasswordChar = False
        Else
            visibility2.Image = My.Resources.visibilityon
            tbConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class