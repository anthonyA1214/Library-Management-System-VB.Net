<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageMembers
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
        Me.btnAddMember = New Guna.UI2.WinForms.Guna2Button()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlSideMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.numAge = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.cbMembershipType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEnter = New Guna.UI2.WinForms.Guna2Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbExit2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblSideMenu = New System.Windows.Forms.Label()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvMember = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSideMenu.SuspendLayout()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 10
        Me.pnlTopMenu.Controls.Add(Me.label1)
        Me.pnlTopMenu.Controls.Add(Me.btnAddMember)
        Me.pnlTopMenu.Controls.Add(Me.pbExit)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Controls.Add(Me.cbSearchBy)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(668, 50)
        Me.pnlTopMenu.TabIndex = 4
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(228, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 17)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Search by:"
        '
        'btnAddMember
        '
        Me.btnAddMember.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddMember.AutoRoundedCorners = True
        Me.btnAddMember.BorderRadius = 19
        Me.btnAddMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddMember.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnAddMember.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddMember.ForeColor = System.Drawing.Color.White
        Me.btnAddMember.Location = New System.Drawing.Point(66, 5)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(150, 40)
        Me.btnAddMember.TabIndex = 2
        Me.btnAddMember.Text = "Add Member"
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
        Me.tbSearch.Location = New System.Drawing.Point(456, 7)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search members"
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
        Me.cbSearchBy.Items.AddRange(New Object() {"Name", "ID"})
        Me.cbSearchBy.Location = New System.Drawing.Point(307, 7)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(140, 36)
        Me.cbSearchBy.TabIndex = 0
        '
        'pbExit
        '
        Me.pbExit.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit.ImageRotate = 0!
        Me.pbExit.Location = New System.Drawing.Point(7, 7)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(25, 25)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit.TabIndex = 1
        Me.pbExit.TabStop = False
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.AutoScroll = True
        Me.pnlSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlSideMenu.BorderRadius = 20
        Me.pnlSideMenu.Controls.Add(Me.tbEmail)
        Me.pnlSideMenu.Controls.Add(Me.label8)
        Me.pnlSideMenu.Controls.Add(Me.numAge)
        Me.pnlSideMenu.Controls.Add(Me.cbMembershipType)
        Me.pnlSideMenu.Controls.Add(Me.tbContactNumber)
        Me.pnlSideMenu.Controls.Add(Me.tbAddress)
        Me.pnlSideMenu.Controls.Add(Me.btnEnter)
        Me.pnlSideMenu.Controls.Add(Me.label7)
        Me.pnlSideMenu.Controls.Add(Me.label6)
        Me.pnlSideMenu.Controls.Add(Me.label5)
        Me.pnlSideMenu.Controls.Add(Me.label4)
        Me.pnlSideMenu.Controls.Add(Me.label3)
        Me.pnlSideMenu.Controls.Add(Me.tbLastName)
        Me.pnlSideMenu.Controls.Add(Me.label2)
        Me.pnlSideMenu.Controls.Add(Me.tbFirstName)
        Me.pnlSideMenu.Controls.Add(Me.pbExit2)
        Me.pnlSideMenu.Controls.Add(Me.lblSideMenu)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 50)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(225, 472)
        Me.pnlSideMenu.TabIndex = 5
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
        Me.tbEmail.Location = New System.Drawing.Point(12, 410)
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
        Me.label8.Location = New System.Drawing.Point(17, 390)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(43, 17)
        Me.label8.TabIndex = 17
        Me.label8.Text = "Email:"
        '
        'numAge
        '
        Me.numAge.AutoRoundedCorners = True
        Me.numAge.BackColor = System.Drawing.Color.Transparent
        Me.numAge.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numAge.BorderRadius = 17
        Me.numAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numAge.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.numAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAge.Location = New System.Drawing.Point(12, 224)
        Me.numAge.Name = "numAge"
        Me.numAge.Size = New System.Drawing.Size(200, 36)
        Me.numAge.TabIndex = 16
        '
        'cbMembershipType
        '
        Me.cbMembershipType.AutoRoundedCorners = True
        Me.cbMembershipType.BackColor = System.Drawing.Color.Transparent
        Me.cbMembershipType.BorderRadius = 17
        Me.cbMembershipType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMembershipType.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbMembershipType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbMembershipType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbMembershipType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbMembershipType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbMembershipType.ItemHeight = 30
        Me.cbMembershipType.Items.AddRange(New Object() {"Child", "Adult", "Senior"})
        Me.cbMembershipType.Location = New System.Drawing.Point(12, 469)
        Me.cbMembershipType.Name = "cbMembershipType"
        Me.cbMembershipType.Size = New System.Drawing.Size(200, 36)
        Me.cbMembershipType.TabIndex = 15
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
        Me.tbContactNumber.Location = New System.Drawing.Point(12, 348)
        Me.tbContactNumber.Name = "tbContactNumber"
        Me.tbContactNumber.PlaceholderText = ""
        Me.tbContactNumber.SelectedText = ""
        Me.tbContactNumber.Size = New System.Drawing.Size(200, 36)
        Me.tbContactNumber.TabIndex = 14
        '
        'tbAddress
        '
        Me.tbAddress.AutoRoundedCorners = True
        Me.tbAddress.BorderRadius = 17
        Me.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAddress.DefaultText = ""
        Me.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAddress.Location = New System.Drawing.Point(12, 286)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.PlaceholderText = ""
        Me.tbAddress.SelectedText = ""
        Me.tbAddress.Size = New System.Drawing.Size(200, 36)
        Me.tbAddress.TabIndex = 13
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
        Me.btnEnter.Location = New System.Drawing.Point(29, 511)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(150, 40)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "Enter"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(17, 449)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(119, 17)
        Me.label7.TabIndex = 11
        Me.label7.Text = "Membership Type:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(17, 328)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(113, 17)
        Me.label6.TabIndex = 9
        Me.label6.Text = "Contact Number:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(17, 266)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 17)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Address:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(17, 204)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(35, 17)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Age:"
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
        Me.lblSideMenu.Size = New System.Drawing.Size(153, 30)
        Me.lblSideMenu.TabIndex = 2
        Me.lblSideMenu.Text = "ADD MEMBER"
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(225, 50)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.guna2Panel3.Size = New System.Drawing.Size(443, 472)
        Me.guna2Panel3.TabIndex = 6
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvMember)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(10, 10)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlGrid.Size = New System.Drawing.Size(423, 452)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        Me.dgvMember.AllowUserToResizeColumns = False
        Me.dgvMember.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMember.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMember.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvMember.Location = New System.Drawing.Point(10, 10)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMember.Size = New System.Drawing.Size(403, 432)
        Me.dgvMember.TabIndex = 0
        Me.dgvMember.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvMember.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvMember.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMember.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMember.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvMember.ThemeStyle.ReadOnly = True
        Me.dgvMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMember.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvMember.ThemeStyle.RowsStyle.Height = 22
        Me.dgvMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ManageMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.pnlSideMenu)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Name = "ManageMembers"
        Me.Text = "ManageMembers"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlSideMenu.PerformLayout()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label1 As Label
    Private WithEvents btnAddMember As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pnlSideMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label8 As Label
    Private WithEvents numAge As Guna.UI2.WinForms.Guna2NumericUpDown
    Private WithEvents cbMembershipType As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents tbContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents tbAddress As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents btnEnter As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents tbLastName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label2 As Label
    Private WithEvents tbFirstName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents pbExit2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblSideMenu As Label
    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvMember As Guna.UI2.WinForms.Guna2DataGridView
End Class
