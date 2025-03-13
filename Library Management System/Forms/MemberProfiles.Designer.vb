<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberProfiles
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlViewMemberRecords = New Guna.UI2.WinForms.Guna2Panel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvIssue2 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.label2 = New System.Windows.Forms.Label()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pbExit2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgvIssue1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.label8 = New System.Windows.Forms.Label()
        Me.pnlSelectMember = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvMember = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.pnlViewMemberRecords.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.guna2Panel2.SuspendLayout()
        CType(Me.dgvIssue2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel1.SuspendLayout()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIssue1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSelectMember.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 10
        Me.pnlTopMenu.Controls.Add(Me.label1)
        Me.pnlTopMenu.Controls.Add(Me.pbExit)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Controls.Add(Me.cbSearchBy)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(668, 50)
        Me.pnlTopMenu.TabIndex = 10
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
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.pnlViewMemberRecords, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.pnlSelectMember, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 50)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(668, 472)
        Me.tableLayoutPanel1.TabIndex = 11
        '
        'pnlViewMemberRecords
        '
        Me.pnlViewMemberRecords.Controls.Add(Me.tableLayoutPanel2)
        Me.pnlViewMemberRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewMemberRecords.Location = New System.Drawing.Point(337, 3)
        Me.pnlViewMemberRecords.Name = "pnlViewMemberRecords"
        Me.pnlViewMemberRecords.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlViewMemberRecords.Size = New System.Drawing.Size(328, 466)
        Me.pnlViewMemberRecords.TabIndex = 14
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.guna2Panel2, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.guna2Panel1, 0, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 2
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(318, 456)
        Me.tableLayoutPanel2.TabIndex = 1
        '
        'guna2Panel2
        '
        Me.guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel2.BorderRadius = 20
        Me.guna2Panel2.Controls.Add(Me.dgvIssue2)
        Me.guna2Panel2.Controls.Add(Me.label2)
        Me.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel2.Location = New System.Drawing.Point(3, 231)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.guna2Panel2.Size = New System.Drawing.Size(312, 222)
        Me.guna2Panel2.TabIndex = 2
        '
        'dgvIssue2
        '
        Me.dgvIssue2.AllowUserToAddRows = False
        Me.dgvIssue2.AllowUserToDeleteRows = False
        Me.dgvIssue2.AllowUserToResizeColumns = False
        Me.dgvIssue2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIssue2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIssue2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvIssue2.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvIssue2.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue2.Location = New System.Drawing.Point(10, 38)
        Me.dgvIssue2.Name = "dgvIssue2"
        Me.dgvIssue2.ReadOnly = True
        Me.dgvIssue2.RowHeadersVisible = False
        Me.dgvIssue2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue2.Size = New System.Drawing.Size(292, 174)
        Me.dgvIssue2.TabIndex = 40
        Me.dgvIssue2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvIssue2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvIssue2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvIssue2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvIssue2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvIssue2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvIssue2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvIssue2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvIssue2.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvIssue2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvIssue2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIssue2.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvIssue2.ThemeStyle.ReadOnly = True
        Me.dgvIssue2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvIssue2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvIssue2.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvIssue2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvIssue2.ThemeStyle.RowsStyle.Height = 22
        Me.dgvIssue2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvIssue2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(7, 7)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(213, 21)
        Me.label2.TabIndex = 39
        Me.label2.Text = "Currently Borrowed Books:"
        '
        'guna2Panel1
        '
        Me.guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel1.BorderRadius = 20
        Me.guna2Panel1.Controls.Add(Me.pbExit2)
        Me.guna2Panel1.Controls.Add(Me.dgvIssue1)
        Me.guna2Panel1.Controls.Add(Me.label8)
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.guna2Panel1.Size = New System.Drawing.Size(312, 222)
        Me.guna2Panel1.TabIndex = 1
        '
        'pbExit2
        '
        Me.pbExit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbExit2.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit2.ImageRotate = 0!
        Me.pbExit2.Location = New System.Drawing.Point(280, 7)
        Me.pbExit2.Name = "pbExit2"
        Me.pbExit2.Size = New System.Drawing.Size(25, 25)
        Me.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit2.TabIndex = 39
        Me.pbExit2.TabStop = False
        '
        'dgvIssue1
        '
        Me.dgvIssue1.AllowUserToAddRows = False
        Me.dgvIssue1.AllowUserToDeleteRows = False
        Me.dgvIssue1.AllowUserToResizeColumns = False
        Me.dgvIssue1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvIssue1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIssue1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvIssue1.ColumnHeadersHeight = 50
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvIssue1.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue1.Location = New System.Drawing.Point(10, 38)
        Me.dgvIssue1.Name = "dgvIssue1"
        Me.dgvIssue1.ReadOnly = True
        Me.dgvIssue1.RowHeadersVisible = False
        Me.dgvIssue1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue1.Size = New System.Drawing.Size(292, 174)
        Me.dgvIssue1.TabIndex = 38
        Me.dgvIssue1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvIssue1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvIssue1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvIssue1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvIssue1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvIssue1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvIssue1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvIssue1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvIssue1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvIssue1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvIssue1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIssue1.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvIssue1.ThemeStyle.ReadOnly = True
        Me.dgvIssue1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvIssue1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvIssue1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvIssue1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvIssue1.ThemeStyle.RowsStyle.Height = 22
        Me.dgvIssue1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvIssue1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(7, 7)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(154, 21)
        Me.label8.TabIndex = 37
        Me.label8.Text = "Borrowing History:"
        '
        'pnlSelectMember
        '
        Me.pnlSelectMember.Controls.Add(Me.pnlGrid)
        Me.pnlSelectMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSelectMember.Location = New System.Drawing.Point(3, 3)
        Me.pnlSelectMember.Name = "pnlSelectMember"
        Me.pnlSelectMember.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSelectMember.Size = New System.Drawing.Size(328, 466)
        Me.pnlSelectMember.TabIndex = 13
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
        Me.pnlGrid.Size = New System.Drawing.Size(308, 446)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        Me.dgvMember.AllowUserToResizeColumns = False
        Me.dgvMember.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMember.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMember.ColumnHeadersHeight = 50
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvMember.Location = New System.Drawing.Point(10, 10)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMember.Size = New System.Drawing.Size(288, 426)
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
        'MemberProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Name = "MemberProfiles"
        Me.Text = "MemberProfiles"
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.pnlViewMemberRecords.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.guna2Panel2.ResumeLayout(False)
        Me.guna2Panel2.PerformLayout()
        CType(Me.dgvIssue2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel1.ResumeLayout(False)
        Me.guna2Panel1.PerformLayout()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIssue1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSelectMember.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label1 As Label
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents pnlViewMemberRecords As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvIssue2 As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents label2 As Label
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pbExit2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents dgvIssue1 As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents label8 As Label
    Private WithEvents pnlSelectMember As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvMember As Guna.UI2.WinForms.Guna2DataGridView
End Class
