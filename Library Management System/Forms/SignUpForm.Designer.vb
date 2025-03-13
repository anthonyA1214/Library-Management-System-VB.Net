<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblLinkBack2Login = New System.Windows.Forms.LinkLabel()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.visibility1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.visibility2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tbConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel2.SuspendLayout()
        CType(Me.visibility1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel3.SuspendLayout()
        CType(Me.visibility2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFirstName
        '
        Me.tbFirstName.AutoRoundedCorners = True
        Me.tbFirstName.BackColor = System.Drawing.Color.Transparent
        Me.tbFirstName.BorderColor = System.Drawing.Color.Black
        Me.tbFirstName.BorderRadius = 21
        Me.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbFirstName.DefaultText = ""
        Me.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFirstName.Location = New System.Drawing.Point(24, 132)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.PlaceholderText = "First Name"
        Me.tbFirstName.SelectedText = ""
        Me.tbFirstName.Size = New System.Drawing.Size(185, 44)
        Me.tbFirstName.TabIndex = 1
        '
        'tbLastName
        '
        Me.tbLastName.AutoRoundedCorners = True
        Me.tbLastName.BackColor = System.Drawing.Color.Transparent
        Me.tbLastName.BorderColor = System.Drawing.Color.Black
        Me.tbLastName.BorderRadius = 21
        Me.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLastName.DefaultText = ""
        Me.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLastName.Location = New System.Drawing.Point(217, 132)
        Me.tbLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.PlaceholderText = "Last Name"
        Me.tbLastName.SelectedText = ""
        Me.tbLastName.Size = New System.Drawing.Size(185, 44)
        Me.tbLastName.TabIndex = 2
        '
        'tbUsername
        '
        Me.tbUsername.AutoRoundedCorners = True
        Me.tbUsername.BackColor = System.Drawing.Color.Transparent
        Me.tbUsername.BorderColor = System.Drawing.Color.Black
        Me.tbUsername.BorderRadius = 21
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.DefaultText = ""
        Me.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Location = New System.Drawing.Point(27, 210)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PlaceholderText = ""
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(373, 44)
        Me.tbUsername.TabIndex = 3
        '
        'tbEmail
        '
        Me.tbEmail.AutoRoundedCorners = True
        Me.tbEmail.BackColor = System.Drawing.Color.Transparent
        Me.tbEmail.BorderColor = System.Drawing.Color.Black
        Me.tbEmail.BorderRadius = 21
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.DefaultText = ""
        Me.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Location = New System.Drawing.Point(27, 448)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PlaceholderText = "example@example.com"
        Me.tbEmail.SelectedText = ""
        Me.tbEmail.Size = New System.Drawing.Size(373, 44)
        Me.tbEmail.TabIndex = 6
        '
        'tbContactNumber
        '
        Me.tbContactNumber.AutoRoundedCorners = True
        Me.tbContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.tbContactNumber.BorderColor = System.Drawing.Color.Black
        Me.tbContactNumber.BorderRadius = 21
        Me.tbContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbContactNumber.DefaultText = ""
        Me.tbContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbContactNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbContactNumber.Location = New System.Drawing.Point(27, 530)
        Me.tbContactNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbContactNumber.Name = "tbContactNumber"
        Me.tbContactNumber.PlaceholderText = "0000 000 0000"
        Me.tbContactNumber.SelectedText = ""
        Me.tbContactNumber.Size = New System.Drawing.Size(373, 44)
        Me.tbContactNumber.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoRoundedCorners = True
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderRadius = 22
        Me.btnSubmit.BorderThickness = 1
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.DarkGreen
        Me.btnSubmit.FillColor2 = System.Drawing.Color.LimeGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(109, 588)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(208, 46)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        '
        'lblLinkBack2Login
        '
        Me.lblLinkBack2Login.AutoSize = True
        Me.lblLinkBack2Login.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!)
        Me.lblLinkBack2Login.Location = New System.Drawing.Point(87, 645)
        Me.lblLinkBack2Login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLinkBack2Login.Name = "lblLinkBack2Login"
        Me.lblLinkBack2Login.Size = New System.Drawing.Size(252, 19)
        Me.lblLinkBack2Login.TabIndex = 33
        Me.lblLinkBack2Login.TabStop = True
        Me.lblLinkBack2Login.Text = "Already have an account?"
        '
        'pbExit
        '
        Me.pbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pbExit.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit.Location = New System.Drawing.Point(373, 18)
        Me.pbExit.Margin = New System.Windows.Forms.Padding(4)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(33, 31)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit.TabIndex = 34
        Me.pbExit.TabStop = False
        '
        'guna2Panel2
        '
        Me.guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.guna2Panel2.BorderRadius = 17
        Me.guna2Panel2.BorderThickness = 1
        Me.guna2Panel2.Controls.Add(Me.tbPassword)
        Me.guna2Panel2.Controls.Add(Me.visibility1)
        Me.guna2Panel2.FillColor = System.Drawing.Color.White
        Me.guna2Panel2.Location = New System.Drawing.Point(27, 292)
        Me.guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Size = New System.Drawing.Size(373, 44)
        Me.guna2Panel2.TabIndex = 38
        '
        'tbPassword
        '
        Me.tbPassword.BorderColor = System.Drawing.Color.Transparent
        Me.tbPassword.BorderRadius = 17
        Me.tbPassword.BorderThickness = 0
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.DefaultText = ""
        Me.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Location = New System.Drawing.Point(1, 2)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(325, 41)
        Me.tbPassword.TabIndex = 4
        '
        'visibility1
        '
        Me.visibility1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.visibility1.BackColor = System.Drawing.Color.Transparent
        Me.visibility1.Image = Global.Library_Management_System.My.Resources.Resources.visibilityon
        Me.visibility1.ImageRotate = 0!
        Me.visibility1.Location = New System.Drawing.Point(335, 7)
        Me.visibility1.Margin = New System.Windows.Forms.Padding(4)
        Me.visibility1.Name = "visibility1"
        Me.visibility1.Size = New System.Drawing.Size(33, 31)
        Me.visibility1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.visibility1.TabIndex = 39
        Me.visibility1.TabStop = False
        Me.visibility1.UseTransparentBackground = True
        '
        'guna2Panel3
        '
        Me.guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.guna2Panel3.BorderRadius = 17
        Me.guna2Panel3.BorderThickness = 1
        Me.guna2Panel3.Controls.Add(Me.visibility2)
        Me.guna2Panel3.Controls.Add(Me.tbConfirmPassword)
        Me.guna2Panel3.FillColor = System.Drawing.Color.White
        Me.guna2Panel3.Location = New System.Drawing.Point(27, 372)
        Me.guna2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Size = New System.Drawing.Size(373, 44)
        Me.guna2Panel3.TabIndex = 39
        '
        'visibility2
        '
        Me.visibility2.BackColor = System.Drawing.Color.Transparent
        Me.visibility2.Image = Global.Library_Management_System.My.Resources.Resources.visibilityon
        Me.visibility2.ImageRotate = 0!
        Me.visibility2.Location = New System.Drawing.Point(335, 7)
        Me.visibility2.Margin = New System.Windows.Forms.Padding(4)
        Me.visibility2.Name = "visibility2"
        Me.visibility2.Size = New System.Drawing.Size(33, 31)
        Me.visibility2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.visibility2.TabIndex = 39
        Me.visibility2.TabStop = False
        Me.visibility2.UseTransparentBackground = True
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.BorderColor = System.Drawing.Color.Transparent
        Me.tbConfirmPassword.BorderRadius = 17
        Me.tbConfirmPassword.BorderThickness = 0
        Me.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbConfirmPassword.DefaultText = ""
        Me.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbConfirmPassword.Location = New System.Drawing.Point(1, 2)
        Me.tbConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.PlaceholderText = ""
        Me.tbConfirmPassword.SelectedText = ""
        Me.tbConfirmPassword.Size = New System.Drawing.Size(325, 41)
        Me.tbConfirmPassword.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 42)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "LMS Sign Up Form"
        '
        'guna2Panel1
        '
        Me.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.guna2Panel1.Controls.Add(Me.Label7)
        Me.guna2Panel1.Controls.Add(Me.Label6)
        Me.guna2Panel1.Controls.Add(Me.Label5)
        Me.guna2Panel1.Controls.Add(Me.Label4)
        Me.guna2Panel1.Controls.Add(Me.Label3)
        Me.guna2Panel1.Controls.Add(Me.Label2)
        Me.guna2Panel1.Controls.Add(Me.Label1)
        Me.guna2Panel1.Controls.Add(Me.guna2Panel3)
        Me.guna2Panel1.Controls.Add(Me.guna2Panel2)
        Me.guna2Panel1.Controls.Add(Me.pbExit)
        Me.guna2Panel1.Controls.Add(Me.lblLinkBack2Login)
        Me.guna2Panel1.Controls.Add(Me.btnSubmit)
        Me.guna2Panel1.Controls.Add(Me.tbContactNumber)
        Me.guna2Panel1.Controls.Add(Me.tbEmail)
        Me.guna2Panel1.Controls.Add(Me.tbUsername)
        Me.guna2Panel1.Controls.Add(Me.tbLastName)
        Me.guna2Panel1.Controls.Add(Me.tbFirstName)
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(427, 690)
        Me.guna2Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 500)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Contact Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(31, 418)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 23)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 23)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Name:"
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 690)
        Me.Controls.Add(Me.guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignupForm"
        Me.Text = "SignUpForm"
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel2.ResumeLayout(False)
        CType(Me.visibility1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel3.ResumeLayout(False)
        CType(Me.visibility2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel1.ResumeLayout(False)
        Me.guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tbFirstName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents tbLastName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents tbUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents tbContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnSubmit As Guna.UI2.WinForms.Guna2GradientButton
    Private WithEvents lblLinkBack2Login As LinkLabel
    Private WithEvents pbExit As PictureBox
    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents visibility1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents visibility2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents tbConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
