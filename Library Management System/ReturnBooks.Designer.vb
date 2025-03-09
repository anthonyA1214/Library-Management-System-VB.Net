<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBooks
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
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.label8 = New System.Windows.Forms.Label()
        Me.dgvIssue = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnReturnBook = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblIssueID = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopMenu.SuspendLayout()
        Me.guna2Panel1.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(707, 191)
        Me.guna2Panel3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.guna2Panel3.Size = New System.Drawing.Size(1047, 1030)
        Me.guna2Panel3.TabIndex = 11
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.label8)
        Me.pnlGrid.Controls.Add(Me.dgvIssue)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(27, 24)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.pnlGrid.Size = New System.Drawing.Size(993, 982)
        Me.pnlGrid.TabIndex = 0
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(16, 24)
        Me.label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(284, 54)
        Me.label8.TabIndex = 36
        Me.label8.Text = "Loan Records:"
        '
        'dgvIssue
        '
        Me.dgvIssue.AllowUserToAddRows = False
        Me.dgvIssue.AllowUserToDeleteRows = False
        Me.dgvIssue.AllowUserToResizeColumns = False
        Me.dgvIssue.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIssue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIssue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvIssue.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvIssue.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue.Location = New System.Drawing.Point(27, 81)
        Me.dgvIssue.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dgvIssue.Name = "dgvIssue"
        Me.dgvIssue.ReadOnly = True
        Me.dgvIssue.RowHeadersVisible = False
        Me.dgvIssue.RowHeadersWidth = 102
        Me.dgvIssue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue.Size = New System.Drawing.Size(939, 870)
        Me.dgvIssue.TabIndex = 0
        Me.dgvIssue.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvIssue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvIssue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvIssue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvIssue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvIssue.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvIssue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvIssue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvIssue.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvIssue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvIssue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvIssue.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvIssue.ThemeStyle.ReadOnly = True
        Me.dgvIssue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvIssue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvIssue.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvIssue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvIssue.ThemeStyle.RowsStyle.Height = 22
        Me.dgvIssue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvIssue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 10
        Me.pnlTopMenu.Controls.Add(Me.label7)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Controls.Add(Me.cbSearchBy)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(707, 24)
        Me.pnlTopMenu.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(1047, 167)
        Me.pnlTopMenu.TabIndex = 10
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(58, 17)
        Me.label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(180, 45)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Search by:"
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbSearch.AutoRoundedCorners = True
        Me.tbSearch.BorderRadius = 42
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
        Me.tbSearch.Location = New System.Drawing.Point(455, 64)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(19, 21, 19, 21)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search records"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(533, 86)
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
        Me.cbSearchBy.Items.AddRange(New Object() {"Member Name", "Member ID", "Issue ID"})
        Me.cbSearchBy.Location = New System.Drawing.Point(66, 64)
        Me.cbSearchBy.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(367, 36)
        Me.cbSearchBy.TabIndex = 0
        '
        'guna2Panel2
        '
        Me.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.guna2Panel2.Location = New System.Drawing.Point(694, 24)
        Me.guna2Panel2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Size = New System.Drawing.Size(13, 1197)
        Me.guna2Panel2.TabIndex = 9
        '
        'guna2Panel1
        '
        Me.guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel1.BorderRadius = 20
        Me.guna2Panel1.Controls.Add(Me.btnReturnBook)
        Me.guna2Panel1.Controls.Add(Me.pbExit)
        Me.guna2Panel1.Controls.Add(Me.guna2PictureBox2)
        Me.guna2Panel1.Controls.Add(Me.lblDueDate)
        Me.guna2Panel1.Controls.Add(Me.lblIssueDate)
        Me.guna2Panel1.Controls.Add(Me.lblMemberName)
        Me.guna2Panel1.Controls.Add(Me.lblBookTitle)
        Me.guna2Panel1.Controls.Add(Me.lblIssueID)
        Me.guna2Panel1.Controls.Add(Me.label6)
        Me.guna2Panel1.Controls.Add(Me.label5)
        Me.guna2Panel1.Controls.Add(Me.label4)
        Me.guna2Panel1.Controls.Add(Me.label3)
        Me.guna2Panel1.Controls.Add(Me.label2)
        Me.guna2Panel1.Controls.Add(Me.panel5)
        Me.guna2Panel1.Controls.Add(Me.label1)
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel1.Location = New System.Drawing.Point(27, 24)
        Me.guna2Panel1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(667, 1197)
        Me.guna2Panel1.TabIndex = 8
        '
        'btnReturnBook
        '
        Me.btnReturnBook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReturnBook.AutoRoundedCorners = True
        Me.btnReturnBook.BorderRadius = 46
        Me.btnReturnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturnBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnReturnBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnReturnBook.ForeColor = System.Drawing.Color.White
        Me.btnReturnBook.Location = New System.Drawing.Point(133, 765)
        Me.btnReturnBook.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(400, 95)
        Me.btnReturnBook.TabIndex = 48
        Me.btnReturnBook.Text = "Return Book"
        '
        'lblDueDate
        '
        Me.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDueDate.Location = New System.Drawing.Point(307, 646)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(139, 45)
        Me.lblDueDate.TabIndex = 25
        Me.lblDueDate.Text = "duedate"
        '
        'lblIssueDate
        '
        Me.lblIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIssueDate.AutoSize = True
        Me.lblIssueDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblIssueDate.Location = New System.Drawing.Point(307, 558)
        Me.lblIssueDate.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(156, 45)
        Me.lblIssueDate.TabIndex = 24
        Me.lblIssueDate.Text = "issuedate"
        '
        'lblMemberName
        '
        Me.lblMemberName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMemberName.Location = New System.Drawing.Point(307, 470)
        Me.lblMemberName.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(101, 45)
        Me.lblMemberName.TabIndex = 23
        Me.lblMemberName.Text = "name"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookTitle.Location = New System.Drawing.Point(307, 382)
        Me.lblBookTitle.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(75, 45)
        Me.lblBookTitle.TabIndex = 22
        Me.lblBookTitle.Text = "title"
        '
        'lblIssueID
        '
        Me.lblIssueID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIssueID.AutoSize = True
        Me.lblIssueID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblIssueID.Location = New System.Drawing.Point(307, 293)
        Me.lblIssueID.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblIssueID.Name = "lblIssueID"
        Me.lblIssueID.Size = New System.Drawing.Size(47, 45)
        Me.lblIssueID.TabIndex = 21
        Me.lblIssueID.Text = "id"
        '
        'label6
        '
        Me.label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(16, 646)
        Me.label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(173, 45)
        Me.label6.TabIndex = 20
        Me.label6.Text = "Due Date:"
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(16, 558)
        Me.label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(189, 45)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Issue Date:"
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(16, 470)
        Me.label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(261, 45)
        Me.label4.TabIndex = 18
        Me.label4.Text = "Member Name:"
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(16, 382)
        Me.label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(185, 45)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Book Title:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(16, 293)
        Me.label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(150, 45)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Issue ID:"
        '
        'panel5
        '
        Me.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel5.Location = New System.Drawing.Point(24, 217)
        Me.panel5.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(619, 7)
        Me.panel5.TabIndex = 15
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(147, 112)
        Me.label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(467, 65)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Issued Book Details"
        '
        'pbExit
        '
        Me.pbExit.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit.ImageRotate = 0!
        Me.pbExit.Location = New System.Drawing.Point(19, 17)
        Me.pbExit.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(67, 60)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit.TabIndex = 27
        Me.pbExit.TabStop = False
        '
        'guna2PictureBox2
        '
        Me.guna2PictureBox2.Image = Global.Library_Management_System.My.Resources.Resources.book4
        Me.guna2PictureBox2.ImageRotate = 0!
        Me.guna2PictureBox2.Location = New System.Drawing.Point(24, 95)
        Me.guna2PictureBox2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2PictureBox2.Name = "guna2PictureBox2"
        Me.guna2PictureBox2.Size = New System.Drawing.Size(120, 107)
        Me.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox2.TabIndex = 26
        Me.guna2PictureBox2.TabStop = False
        '
        'ReturnBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1781, 1245)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Controls.Add(Me.guna2Panel2)
        Me.Controls.Add(Me.guna2Panel1)
        Me.MinimumSize = New System.Drawing.Size(1771, 1216)
        Me.Name = "ReturnBooks"
        Me.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.Text = "ReturnBooks"
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.dgvIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        Me.guna2Panel1.ResumeLayout(False)
        Me.guna2Panel1.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label8 As Label
    Private WithEvents dgvIssue As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label7 As Label
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnReturnBook As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblDueDate As Label
    Private WithEvents lblIssueDate As Label
    Private WithEvents lblMemberName As Label
    Private WithEvents lblBookTitle As Label
    Private WithEvents lblIssueID As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents panel5 As Panel
    Private WithEvents label1 As Label
End Class
