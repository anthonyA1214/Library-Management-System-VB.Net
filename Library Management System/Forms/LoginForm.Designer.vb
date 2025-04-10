<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIncorrect = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.lblLinkRegister = New System.Windows.Forms.LinkLabel()
        Me.cbShowPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.tbUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSelectUserrole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlContainer.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pnlContainer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pnlContainer.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.pnlContainer.Controls.Add(Me.cbSelectUserrole)
        Me.pnlContainer.Controls.Add(Me.Label3)
        Me.pnlContainer.Controls.Add(Me.lblIncorrect)
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Controls.Add(Me.tbPassword)
        Me.pnlContainer.Controls.Add(Me.pbExit)
        Me.pnlContainer.Controls.Add(Me.lblLinkRegister)
        Me.pnlContainer.Controls.Add(Me.cbShowPassword)
        Me.pnlContainer.Controls.Add(Me.btnLogin)
        Me.pnlContainer.Controls.Add(Me.tbUsername)
        Me.pnlContainer.Controls.Add(Me.pictureBox2)
        Me.pnlContainer.Controls.Add(Me.pictureBox3)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlContainer.Location = New System.Drawing.Point(809, 0)
        Me.pnlContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(436, 681)
        Me.pnlContainer.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(100, 539)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Don't have an account?"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.BackColor = System.Drawing.Color.Transparent
        Me.lblIncorrect.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrect.Location = New System.Drawing.Point(73, 389)
        Me.lblIncorrect.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(205, 21)
        Me.lblIncorrect.TabIndex = 19
        Me.lblIncorrect.Text = "Incorrect Username or Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 46)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Welcome to LMS"
        '
        'tbPassword
        '
        Me.tbPassword.Animated = True
        Me.tbPassword.AutoRoundedCorners = True
        Me.tbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.tbPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbPassword.BorderRadius = 17
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.DefaultText = ""
        Me.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Location = New System.Drawing.Point(101, 346)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PlaceholderText = "Password"
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(227, 36)
        Me.tbPassword.TabIndex = 2
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
        Me.pbExit.TabIndex = 6
        Me.pbExit.TabStop = False
        '
        'lblLinkRegister
        '
        Me.lblLinkRegister.AutoSize = True
        Me.lblLinkRegister.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!)
        Me.lblLinkRegister.Location = New System.Drawing.Point(128, 562)
        Me.lblLinkRegister.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLinkRegister.Name = "lblLinkRegister"
        Me.lblLinkRegister.Size = New System.Drawing.Size(157, 19)
        Me.lblLinkRegister.TabIndex = 17
        Me.lblLinkRegister.TabStop = True
        Me.lblLinkRegister.Text = "REGISTER HERE"
        '
        'cbShowPassword
        '
        Me.cbShowPassword.AutoSize = True
        Me.cbShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbShowPassword.CheckedState.BorderRadius = 0
        Me.cbShowPassword.CheckedState.BorderThickness = 0
        Me.cbShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbShowPassword.CheckMarkColor = System.Drawing.Color.Bisque
        Me.cbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbShowPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowPassword.ForeColor = System.Drawing.Color.Black
        Me.cbShowPassword.Location = New System.Drawing.Point(73, 415)
        Me.cbShowPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(151, 27)
        Me.cbShowPassword.TabIndex = 3
        Me.cbShowPassword.Text = "Show Password"
        Me.cbShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbShowPassword.UncheckedState.BorderRadius = 0
        Me.cbShowPassword.UncheckedState.BorderThickness = 0
        Me.cbShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.BorderRadius = 18
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.DarkGreen
        Me.btnLogin.FillColor2 = System.Drawing.Color.LimeGreen
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(109, 468)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(208, 46)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        '
        'tbUsername
        '
        Me.tbUsername.Animated = True
        Me.tbUsername.AutoRoundedCorners = True
        Me.tbUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.tbUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tbUsername.BorderRadius = 17
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.DefaultText = ""
        Me.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Location = New System.Drawing.Point(99, 277)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PlaceholderText = "Username"
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(227, 36)
        Me.tbUsername.TabIndex = 1
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(60, 281)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(33, 32)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 7
        Me.pictureBox2.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pictureBox3.Image = Global.Library_Management_System.My.Resources.Resources.lock
        Me.pictureBox3.Location = New System.Drawing.Point(60, 350)
        Me.pictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(33, 32)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox3.TabIndex = 9
        Me.pictureBox3.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.White
        Me.pictureBox4.Image = Global.Library_Management_System.My.Resources.Resources.logo
        Me.pictureBox4.Location = New System.Drawing.Point(103, 18)
        Me.pictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(557, 503)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox4.TabIndex = 26
        Me.pictureBox4.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.label1.Location = New System.Drawing.Point(225, 576)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(268, 28)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Discover, Borrow, and Enjoy!"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 75
        Me.Guna2Elipse1.TargetControl = Me
        '
        'guna2PictureBox1
        '
        Me.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.guna2PictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.left_pic
        Me.guna2PictureBox1.ImageRotate = 0!
        Me.guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox1.Name = "guna2PictureBox1"
        Me.guna2PictureBox1.Size = New System.Drawing.Size(833, 681)
        Me.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guna2PictureBox1.TabIndex = 27
        Me.guna2PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(61, 528)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(555, 42)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Library Management System"
        '
        'cbSelectUserrole
        '
        Me.cbSelectUserrole.AutoRoundedCorners = True
        Me.cbSelectUserrole.BackColor = System.Drawing.Color.Transparent
        Me.cbSelectUserrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSelectUserrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSelectUserrole.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSelectUserrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSelectUserrole.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbSelectUserrole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSelectUserrole.ItemHeight = 30
        Me.cbSelectUserrole.Items.AddRange(New Object() {"Borrower", "Staff"})
        Me.cbSelectUserrole.Location = New System.Drawing.Point(99, 208)
        Me.cbSelectUserrole.Name = "cbSelectUserrole"
        Me.cbSelectUserrole.Size = New System.Drawing.Size(227, 36)
        Me.cbSelectUserrole.TabIndex = 22
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 681)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents pbExit As PictureBox
    Private WithEvents lblLinkRegister As LinkLabel
    Private WithEvents cbShowPassword As Guna.UI2.WinForms.Guna2CheckBox
    Private WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientTileButton
    Private WithEvents tbUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents lblIncorrect As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents cbSelectUserrole As Guna.UI2.WinForms.Guna2ComboBox
End Class
