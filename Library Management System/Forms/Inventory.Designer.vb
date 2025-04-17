<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.cbAvailabilityStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbGenre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlSideMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.numQuantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnEnter = New Guna.UI2.WinForms.Guna2Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tbAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tbTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbExit2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblSideMenu = New System.Windows.Forms.Label()
        Me.guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvBook = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTopMenu.SuspendLayout()
        Me.guna2Panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSideMenu.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel5.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 20
        Me.pnlTopMenu.Controls.Add(Me.btnClear)
        Me.pnlTopMenu.Controls.Add(Me.label1)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Controls.Add(Me.cbSearchBy)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(13, 12)
        Me.pnlTopMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(865, 62)
        Me.pnlTopMenu.TabIndex = 12
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.AutoRoundedCorners = True
        Me.btnClear.BorderRadius = 23
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(673, 5)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 49)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(72, 22)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(89, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Search by:"
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbSearch.AutoRoundedCorners = True
        Me.tbSearch.BorderRadius = 21
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
        Me.tbSearch.Location = New System.Drawing.Point(376, 9)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search books"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(267, 44)
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
        Me.cbSearchBy.Items.AddRange(New Object() {"Title", "Author", "ISBN", "Publication Year", "ID"})
        Me.cbSearchBy.Location = New System.Drawing.Point(177, 9)
        Me.cbSearchBy.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(185, 36)
        Me.cbSearchBy.TabIndex = 0
        '
        'guna2Panel2
        '
        Me.guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel2.BorderRadius = 20
        Me.guna2Panel2.Controls.Add(Me.pictureBox1)
        Me.guna2Panel2.Controls.Add(Me.btnRefresh)
        Me.guna2Panel2.Controls.Add(Me.label3)
        Me.guna2Panel2.Controls.Add(Me.btnExport)
        Me.guna2Panel2.Controls.Add(Me.cbAvailabilityStatus)
        Me.guna2Panel2.Controls.Add(Me.label2)
        Me.guna2Panel2.Controls.Add(Me.cbGenre)
        Me.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel2.Location = New System.Drawing.Point(13, 74)
        Me.guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Size = New System.Drawing.Size(865, 133)
        Me.guna2Panel2.TabIndex = 15
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.Legends
        Me.pictureBox1.Location = New System.Drawing.Point(658, 12)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(195, 105)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRefresh.AutoRoundedCorners = True
        Me.btnRefresh.BorderRadius = 23
        Me.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(27, 71)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(200, 49)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh Inventory"
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(443, 26)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(149, 23)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Availability Status:"
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExport.AutoRoundedCorners = True
        Me.btnExport.BorderRadius = 23
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(27, 15)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(200, 49)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export Inventory"
        '
        'cbAvailabilityStatus
        '
        Me.cbAvailabilityStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbAvailabilityStatus.AutoRoundedCorners = True
        Me.cbAvailabilityStatus.BackColor = System.Drawing.Color.Transparent
        Me.cbAvailabilityStatus.BorderRadius = 17
        Me.cbAvailabilityStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAvailabilityStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAvailabilityStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbAvailabilityStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbAvailabilityStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbAvailabilityStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbAvailabilityStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbAvailabilityStatus.ItemHeight = 30
        Me.cbAvailabilityStatus.Items.AddRange(New Object() {"All", "Available", "Unavailable"})
        Me.cbAvailabilityStatus.Location = New System.Drawing.Point(447, 50)
        Me.cbAvailabilityStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAvailabilityStatus.Name = "cbAvailabilityStatus"
        Me.cbAvailabilityStatus.Size = New System.Drawing.Size(185, 36)
        Me.cbAvailabilityStatus.TabIndex = 4
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(248, 23)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 23)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Genre:"
        '
        'cbGenre
        '
        Me.cbGenre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbGenre.AutoRoundedCorners = True
        Me.cbGenre.BackColor = System.Drawing.Color.Transparent
        Me.cbGenre.BorderRadius = 17
        Me.cbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbGenre.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbGenre.ItemHeight = 30
        Me.cbGenre.Items.AddRange(New Object() {"All", "Title", "Author", "ISBN", "Genre", "Publication Year"})
        Me.cbGenre.Location = New System.Drawing.Point(252, 48)
        Me.cbGenre.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGenre.Name = "cbGenre"
        Me.cbGenre.Size = New System.Drawing.Size(185, 36)
        Me.cbGenre.TabIndex = 1
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.AutoScroll = True
        Me.pnlSideMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlSideMenu.BorderRadius = 20
        Me.pnlSideMenu.Controls.Add(Me.numQuantity)
        Me.pnlSideMenu.Controls.Add(Me.btnEnter)
        Me.pnlSideMenu.Controls.Add(Me.label7)
        Me.pnlSideMenu.Controls.Add(Me.label8)
        Me.pnlSideMenu.Controls.Add(Me.tbAuthor)
        Me.pnlSideMenu.Controls.Add(Me.label9)
        Me.pnlSideMenu.Controls.Add(Me.tbTitle)
        Me.pnlSideMenu.Controls.Add(Me.pbExit2)
        Me.pnlSideMenu.Controls.Add(Me.lblSideMenu)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlSideMenu.Location = New System.Drawing.Point(13, 207)
        Me.pnlSideMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(300, 423)
        Me.pnlSideMenu.TabIndex = 18
        '
        'numQuantity
        '
        Me.numQuantity.AutoRoundedCorners = True
        Me.numQuantity.BackColor = System.Drawing.Color.Transparent
        Me.numQuantity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.numQuantity.BorderRadius = 21
        Me.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numQuantity.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.numQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantity.Location = New System.Drawing.Point(16, 272)
        Me.numQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(267, 44)
        Me.numQuantity.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.AutoRoundedCorners = True
        Me.btnEnter.BorderRadius = 23
        Me.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnter.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(49, 324)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(200, 49)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "Enter"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(23, 247)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(81, 23)
        Me.label7.TabIndex = 11
        Me.label7.Text = "Quantity:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(23, 175)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(68, 23)
        Me.label8.TabIndex = 4
        Me.label8.Text = "Author:"
        '
        'tbAuthor
        '
        Me.tbAuthor.AutoRoundedCorners = True
        Me.tbAuthor.BorderRadius = 21
        Me.tbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAuthor.DefaultText = ""
        Me.tbAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAuthor.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAuthor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAuthor.Location = New System.Drawing.Point(16, 199)
        Me.tbAuthor.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.PlaceholderText = ""
        Me.tbAuthor.SelectedText = ""
        Me.tbAuthor.Size = New System.Drawing.Size(267, 44)
        Me.tbAuthor.TabIndex = 5
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(23, 98)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(46, 23)
        Me.label9.TabIndex = 1
        Me.label9.Text = "Title:"
        '
        'tbTitle
        '
        Me.tbTitle.AutoRoundedCorners = True
        Me.tbTitle.BorderRadius = 21
        Me.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTitle.DefaultText = ""
        Me.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTitle.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTitle.Location = New System.Drawing.Point(16, 123)
        Me.tbTitle.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.PlaceholderText = ""
        Me.tbTitle.SelectedText = ""
        Me.tbTitle.Size = New System.Drawing.Size(267, 44)
        Me.tbTitle.TabIndex = 1
        '
        'pbExit2
        '
        Me.pbExit2.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit2.ImageRotate = 0!
        Me.pbExit2.Location = New System.Drawing.Point(241, 7)
        Me.pbExit2.Margin = New System.Windows.Forms.Padding(4)
        Me.pbExit2.Name = "pbExit2"
        Me.pbExit2.Size = New System.Drawing.Size(33, 31)
        Me.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit2.TabIndex = 3
        Me.pbExit2.TabStop = False
        '
        'lblSideMenu
        '
        Me.lblSideMenu.AutoSize = True
        Me.lblSideMenu.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSideMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblSideMenu.Location = New System.Drawing.Point(20, 43)
        Me.lblSideMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSideMenu.Name = "lblSideMenu"
        Me.lblSideMenu.Size = New System.Drawing.Size(147, 37)
        Me.lblSideMenu.TabIndex = 2
        Me.lblSideMenu.Text = "Add Stock"
        '
        'guna2Panel5
        '
        Me.guna2Panel5.Controls.Add(Me.pnlGrid)
        Me.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel5.Location = New System.Drawing.Point(313, 207)
        Me.guna2Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel5.Name = "guna2Panel5"
        Me.guna2Panel5.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.guna2Panel5.Size = New System.Drawing.Size(565, 423)
        Me.guna2Panel5.TabIndex = 19
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvBook)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(13, 12)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.pnlGrid.Size = New System.Drawing.Size(539, 399)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvBook
        '
        Me.dgvBook.AllowUserToAddRows = False
        Me.dgvBook.AllowUserToDeleteRows = False
        Me.dgvBook.AllowUserToResizeColumns = False
        Me.dgvBook.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvBook.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBook.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBook.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBook.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvBook.Location = New System.Drawing.Point(13, 12)
        Me.dgvBook.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.RowHeadersVisible = False
        Me.dgvBook.RowHeadersWidth = 51
        Me.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBook.Size = New System.Drawing.Size(513, 375)
        Me.dgvBook.TabIndex = 0
        Me.dgvBook.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvBook.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvBook.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBook.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBook.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvBook.ThemeStyle.ReadOnly = True
        Me.dgvBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBook.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvBook.ThemeStyle.RowsStyle.Height = 22
        Me.dgvBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 642)
        Me.Controls.Add(Me.guna2Panel5)
        Me.Controls.Add(Me.pnlSideMenu)
        Me.Controls.Add(Me.guna2Panel2)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inventory"
        Me.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Text = "Inventory"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        Me.guna2Panel2.ResumeLayout(False)
        Me.guna2Panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlSideMenu.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel5.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label1 As Label
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label3 As Label
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents cbAvailabilityStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents label2 As Label
    Private WithEvents cbGenre As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pnlSideMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents numQuantity As Guna.UI2.WinForms.Guna2NumericUpDown
    Private WithEvents btnEnter As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents tbAuthor As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label9 As Label
    Private WithEvents tbTitle As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents pbExit2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblSideMenu As Label
    Private WithEvents guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvBook As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
End Class
