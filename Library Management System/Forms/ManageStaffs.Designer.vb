<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStaffs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAddStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlSideMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.visibility2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.visibility1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tbContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEnter = New Guna.UI2.WinForms.Guna2Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbExit2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblSideMenu = New System.Windows.Forms.Label()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvStaff = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTopMenu.SuspendLayout()
        Me.pnlSideMenu.SuspendLayout()
        Me.guna2Panel1.SuspendLayout()
        CType(Me.visibility2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel2.SuspendLayout()
        CType(Me.visibility1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 10
        Me.pnlTopMenu.Controls.Add(Me.label1)
        Me.pnlTopMenu.Controls.Add(Me.btnAddStaff)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Controls.Add(Me.cbSearchBy)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(10, 10)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(648, 50)
        Me.pnlTopMenu.TabIndex = 7
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(218, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 17)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Search by:"
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddStaff.AutoRoundedCorners = True
        Me.btnAddStaff.BorderRadius = 19
        Me.btnAddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddStaff.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnAddStaff.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddStaff.ForeColor = System.Drawing.Color.White
        Me.btnAddStaff.Location = New System.Drawing.Point(56, 5)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(150, 40)
        Me.btnAddStaff.TabIndex = 2
        Me.btnAddStaff.Text = "Add Staff"
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbSearch.AutoRoundedCorners = True
        Me.tbSearch.BorderRadius = 17
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.DefaultText = ""
        Me.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.Location = New System.Drawing.Point(446, 7)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search staffs"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(200, 36)
        Me.tbSearch.TabIndex = 1
        '
        'cbSearchBy
        '
        Me.cbSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbSearchBy.AutoRoundedCorners = True
        Me.cbSearchBy.BackColor = System.Drawing.Color.Transparent
        Me.cbSearchBy.BorderRadius = 17
        Me.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchBy.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSearchBy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSearchBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSearchBy.ItemHeight = 30
        Me.cbSearchBy.Items.AddRange(New Object() {"Name", "Username", "ID"})
        Me.cbSearchBy.Location = New System.Drawing.Point(297, 7)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(140, 36)
        Me.cbSearchBy.TabIndex = 0
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.AutoScroll = True
        Me.pnlSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlSideMenu.BorderRadius = 20
        Me.pnlSideMenu.Controls.Add(Me.guna2Panel1)
        Me.pnlSideMenu.Controls.Add(Me.guna2Panel2)
        Me.pnlSideMenu.Controls.Add(Me.label7)
        Me.pnlSideMenu.Controls.Add(Me.cbRole)
        Me.pnlSideMenu.Controls.Add(Me.label9)
        Me.pnlSideMenu.Controls.Add(Me.label5)
        Me.pnlSideMenu.Controls.Add(Me.tbUsername)
        Me.pnlSideMenu.Controls.Add(Me.tbEmail)
        Me.pnlSideMenu.Controls.Add(Me.label8)
        Me.pnlSideMenu.Controls.Add(Me.tbContactNumber)
        Me.pnlSideMenu.Controls.Add(Me.btnEnter)
        Me.pnlSideMenu.Controls.Add(Me.label6)
        Me.pnlSideMenu.Controls.Add(Me.label4)
        Me.pnlSideMenu.Controls.Add(Me.label3)
        Me.pnlSideMenu.Controls.Add(Me.tbLastName)
        Me.pnlSideMenu.Controls.Add(Me.label2)
        Me.pnlSideMenu.Controls.Add(Me.tbFirstName)
        Me.pnlSideMenu.Controls.Add(Me.pbExit2)
        Me.pnlSideMenu.Controls.Add(Me.lblSideMenu)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlSideMenu.Location = New System.Drawing.Point(10, 60)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(225, 452)
        Me.pnlSideMenu.TabIndex = 8
        '
        'guna2Panel1
        '
        Me.guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.guna2Panel1.BorderRadius = 17
        Me.guna2Panel1.BorderThickness = 1
        Me.guna2Panel1.Controls.Add(Me.tbConfirmPassword)
        Me.guna2Panel1.Controls.Add(Me.visibility2)
        Me.guna2Panel1.FillColor = System.Drawing.Color.White
        Me.guna2Panel1.Location = New System.Drawing.Point(13, 346)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(200, 36)
        Me.guna2Panel1.TabIndex = 40
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
        Me.tbConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.PlaceholderText = ""
        Me.tbConfirmPassword.SelectedText = ""
        Me.tbConfirmPassword.Size = New System.Drawing.Size(164, 33)
        Me.tbConfirmPassword.TabIndex = 4
        '
        'visibility2
        '
        Me.visibility2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.visibility2.BackColor = System.Drawing.Color.Transparent
        Me.visibility2.Image = Global.Library_Management_System.My.Resources.Resources.visibilityon
        Me.visibility2.ImageRotate = 0!
        Me.visibility2.Location = New System.Drawing.Point(171, 6)
        Me.visibility2.Name = "visibility2"
        Me.visibility2.Size = New System.Drawing.Size(25, 25)
        Me.visibility2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.visibility2.TabIndex = 39
        Me.visibility2.TabStop = False
        Me.visibility2.UseTransparentBackground = True
        '
        'guna2Panel2
        '
        Me.guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.guna2Panel2.BorderRadius = 17
        Me.guna2Panel2.BorderThickness = 1
        Me.guna2Panel2.Controls.Add(Me.tbPassword)
        Me.guna2Panel2.Controls.Add(Me.visibility1)
        Me.guna2Panel2.FillColor = System.Drawing.Color.White
        Me.guna2Panel2.Location = New System.Drawing.Point(12, 287)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Size = New System.Drawing.Size(200, 36)
        Me.guna2Panel2.TabIndex = 39
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
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(164, 33)
        Me.tbPassword.TabIndex = 4
        '
        'visibility1
        '
        Me.visibility1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.visibility1.BackColor = System.Drawing.Color.Transparent
        Me.visibility1.Image = Global.Library_Management_System.My.Resources.Resources.visibilityon
        Me.visibility1.ImageRotate = 0!
        Me.visibility1.Location = New System.Drawing.Point(171, 6)
        Me.visibility1.Name = "visibility1"
        Me.visibility1.Size = New System.Drawing.Size(25, 25)
        Me.visibility1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.visibility1.TabIndex = 39
        Me.visibility1.TabStop = False
        Me.visibility1.UseTransparentBackground = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(17, 326)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(121, 17)
        Me.label7.TabIndex = 24
        Me.label7.Text = "Confirm Password:"
        '
        'cbRole
        '
        Me.cbRole.AutoRoundedCorners = True
        Me.cbRole.BackColor = System.Drawing.Color.Transparent
        Me.cbRole.BorderRadius = 17
        Me.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRole.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbRole.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbRole.ItemHeight = 30
        Me.cbRole.Items.AddRange(New Object() {"Staff", "Admin"})
        Me.cbRole.Location = New System.Drawing.Point(11, 523)
        Me.cbRole.Name = "cbRole"
        Me.cbRole.Size = New System.Drawing.Size(200, 36)
        Me.cbRole.TabIndex = 22
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(17, 503)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(37, 17)
        Me.label9.TabIndex = 21
        Me.label9.Text = "Role:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(17, 267)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(69, 17)
        Me.label5.TabIndex = 20
        Me.label5.Text = "Password:"
        '
        'tbUsername
        '
        Me.tbUsername.AutoRoundedCorners = True
        Me.tbUsername.BorderRadius = 17
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.DefaultText = ""
        Me.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Location = New System.Drawing.Point(12, 227)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PlaceholderText = ""
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(200, 36)
        Me.tbUsername.TabIndex = 19
        '
        'tbEmail
        '
        Me.tbEmail.AutoRoundedCorners = True
        Me.tbEmail.BorderRadius = 17
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.DefaultText = ""
        Me.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Location = New System.Drawing.Point(12, 464)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PlaceholderText = ""
        Me.tbEmail.SelectedText = ""
        Me.tbEmail.Size = New System.Drawing.Size(200, 36)
        Me.tbEmail.TabIndex = 18
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(17, 444)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(43, 17)
        Me.label8.TabIndex = 17
        Me.label8.Text = "Email:"
        '
        'tbContactNumber
        '
        Me.tbContactNumber.AutoRoundedCorners = True
        Me.tbContactNumber.BorderRadius = 17
        Me.tbContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbContactNumber.DefaultText = ""
        Me.tbContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbContactNumber.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbContactNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbContactNumber.Location = New System.Drawing.Point(11, 405)
        Me.tbContactNumber.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbContactNumber.Name = "tbContactNumber"
        Me.tbContactNumber.PlaceholderText = ""
        Me.tbContactNumber.SelectedText = ""
        Me.tbContactNumber.Size = New System.Drawing.Size(200, 36)
        Me.tbContactNumber.TabIndex = 14
        '
        'btnEnter
        '
        Me.btnEnter.AutoRoundedCorners = True
        Me.btnEnter.BorderRadius = 19
        Me.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnter.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(29, 565)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(150, 40)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "Enter"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(17, 385)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(113, 17)
        Me.label6.TabIndex = 9
        Me.label6.Text = "Contact Number:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(17, 204)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 17)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Username:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(17, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 17)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Last Name:"
        '
        'tbLastName
        '
        Me.tbLastName.AutoRoundedCorners = True
        Me.tbLastName.BorderRadius = 17
        Me.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLastName.DefaultText = ""
        Me.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLastName.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLastName.Location = New System.Drawing.Point(12, 162)
        Me.tbLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.PlaceholderText = ""
        Me.tbLastName.SelectedText = ""
        Me.tbLastName.Size = New System.Drawing.Size(200, 36)
        Me.tbLastName.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(17, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(77, 17)
        Me.label2.TabIndex = 1
        Me.label2.Text = "First Name:"
        '
        'tbFirstName
        '
        Me.tbFirstName.AutoRoundedCorners = True
        Me.tbFirstName.BorderRadius = 17
        Me.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbFirstName.DefaultText = ""
        Me.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFirstName.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFirstName.Location = New System.Drawing.Point(12, 100)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.PlaceholderText = ""
        Me.tbFirstName.SelectedText = ""
        Me.tbFirstName.Size = New System.Drawing.Size(200, 36)
        Me.tbFirstName.TabIndex = 1
        '
        'pbExit2
        '
        Me.pbExit2.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit2.ImageRotate = 0!
        Me.pbExit2.Location = New System.Drawing.Point(181, 6)
        Me.pbExit2.Name = "pbExit2"
        Me.pbExit2.Size = New System.Drawing.Size(25, 25)
        Me.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit2.TabIndex = 3
        Me.pbExit2.TabStop = False
        '
        'lblSideMenu
        '
        Me.lblSideMenu.AutoSize = True
        Me.lblSideMenu.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSideMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblSideMenu.Location = New System.Drawing.Point(15, 35)
        Me.lblSideMenu.Name = "lblSideMenu"
        Me.lblSideMenu.Size = New System.Drawing.Size(124, 30)
        Me.lblSideMenu.TabIndex = 2
        Me.lblSideMenu.Text = "ADD STAFF"
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(235, 60)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.guna2Panel3.Size = New System.Drawing.Size(423, 452)
        Me.guna2Panel3.TabIndex = 9
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvStaff)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(10, 10)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.pnlGrid.Size = New System.Drawing.Size(403, 432)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvStaff
        '
        Me.dgvStaff.AllowUserToAddRows = False
        Me.dgvStaff.AllowUserToDeleteRows = False
        Me.dgvStaff.AllowUserToResizeColumns = False
        Me.dgvStaff.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvStaff.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStaff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStaff.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaff.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaff.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvStaff.Location = New System.Drawing.Point(10, 10)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.ReadOnly = True
        Me.dgvStaff.RowHeadersVisible = False
        Me.dgvStaff.RowHeadersWidth = 51
        Me.dgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStaff.Size = New System.Drawing.Size(383, 412)
        Me.dgvStaff.TabIndex = 0
        Me.dgvStaff.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStaff.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStaff.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStaff.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStaff.ThemeStyle.ReadOnly = True
        Me.dgvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStaff.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStaff.ThemeStyle.RowsStyle.Height = 22
        Me.dgvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ManageStaffs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.pnlSideMenu)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Name = "ManageStaffs"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Text = "ManageStaffs"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlSideMenu.PerformLayout()
        Me.guna2Panel1.ResumeLayout(False)
        CType(Me.visibility2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel2.ResumeLayout(False)
        CType(Me.visibility1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label1 As Label
    Private WithEvents btnAddStaff As Guna.UI2.WinForms.Guna2Button
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pnlSideMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tbConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents visibility2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents visibility1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents label7 As Label
    Private WithEvents cbRole As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents label9 As Label
    Private WithEvents label5 As Label
    Private WithEvents tbUsername As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label8 As Label
    Private WithEvents tbContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnEnter As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label6 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents tbLastName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label2 As Label
    Private WithEvents tbFirstName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents pbExit2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblSideMenu As Label
    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvStaff As Guna.UI2.WinForms.Guna2DataGridView
End Class
