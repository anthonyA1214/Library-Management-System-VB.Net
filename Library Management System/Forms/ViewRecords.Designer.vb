<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRecords
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvIssue = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlCustomRange = New Guna.UI2.WinForms.Guna2Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.label4 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbDateRange = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbLoanStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomRange.SuspendLayout()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(27, 346)
        Me.guna2Panel3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.guna2Panel3.Size = New System.Drawing.Size(1727, 875)
        Me.guna2Panel3.TabIndex = 11
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvIssue)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(27, 24)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.pnlGrid.Size = New System.Drawing.Size(1673, 827)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvIssue
        '
        Me.dgvIssue.AllowUserToAddRows = False
        Me.dgvIssue.AllowUserToDeleteRows = False
        Me.dgvIssue.AllowUserToResizeColumns = False
        Me.dgvIssue.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvIssue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvIssue.ColumnHeadersHeight = 50
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIssue.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue.Location = New System.Drawing.Point(27, 24)
        Me.dgvIssue.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dgvIssue.Name = "dgvIssue"
        Me.dgvIssue.ReadOnly = True
        Me.dgvIssue.RowHeadersVisible = False
        Me.dgvIssue.RowHeadersWidth = 102
        Me.dgvIssue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue.Size = New System.Drawing.Size(1619, 779)
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
        'pnlCustomRange
        '
        Me.pnlCustomRange.BackColor = System.Drawing.Color.Transparent
        Me.pnlCustomRange.BorderRadius = 10
        Me.pnlCustomRange.Controls.Add(Me.label5)
        Me.pnlCustomRange.Controls.Add(Me.dtpEndDate)
        Me.pnlCustomRange.Controls.Add(Me.label4)
        Me.pnlCustomRange.Controls.Add(Me.dtpStartDate)
        Me.pnlCustomRange.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCustomRange.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlCustomRange.Location = New System.Drawing.Point(27, 191)
        Me.pnlCustomRange.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlCustomRange.Name = "pnlCustomRange"
        Me.pnlCustomRange.Size = New System.Drawing.Size(1727, 155)
        Me.pnlCustomRange.TabIndex = 10
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(868, 10)
        Me.label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(164, 45)
        Me.label5.TabIndex = 42
        Me.label5.Text = "End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpEndDate.AutoRoundedCorners = True
        Me.dtpEndDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpEndDate.BorderRadius = 42
        Me.dtpEndDate.BorderThickness = 1
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpEndDate.CustomFormat = ""
        Me.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpEndDate.ForeColor = System.Drawing.Color.White
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(876, 57)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(464, 86)
        Me.dtpEndDate.TabIndex = 43
        Me.dtpEndDate.Value = New Date(2024, 11, 27, 16, 25, 35, 105)
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(388, 10)
        Me.label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(179, 45)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Start Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpStartDate.AutoRoundedCorners = True
        Me.dtpStartDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpStartDate.BorderRadius = 42
        Me.dtpStartDate.BorderThickness = 1
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpStartDate.CustomFormat = ""
        Me.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStartDate.ForeColor = System.Drawing.Color.White
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(396, 57)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(464, 86)
        Me.dtpStartDate.TabIndex = 41
        Me.dtpStartDate.Value = New Date(2024, 11, 27, 16, 25, 35, 105)
        '
        'guna2Panel1
        '
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.guna2Panel1.Location = New System.Drawing.Point(27, 179)
        Me.guna2Panel1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(1727, 12)
        Me.guna2Panel1.TabIndex = 9
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 10
        Me.pnlTopMenu.Controls.Add(Me.label3)
        Me.pnlTopMenu.Controls.Add(Me.label2)
        Me.pnlTopMenu.Controls.Add(Me.cbDateRange)
        Me.pnlTopMenu.Controls.Add(Me.cbLoanStatus)
        Me.pnlTopMenu.Controls.Add(Me.label1)
        Me.pnlTopMenu.Controls.Add(Me.pbExit)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Controls.Add(Me.cbSearchBy)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(27, 24)
        Me.pnlTopMenu.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Size = New System.Drawing.Size(1727, 155)
        Me.pnlTopMenu.TabIndex = 8
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(1351, 10)
        Me.label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(290, 45)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Date Range Filter:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(975, 10)
        Me.label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(200, 45)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Loan Status:"
        '
        'cbDateRange
        '
        Me.cbDateRange.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbDateRange.AutoRoundedCorners = True
        Me.cbDateRange.BackColor = System.Drawing.Color.Transparent
        Me.cbDateRange.BorderRadius = 17
        Me.cbDateRange.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDateRange.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbDateRange.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDateRange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbDateRange.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbDateRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbDateRange.ItemHeight = 30
        Me.cbDateRange.Items.AddRange(New Object() {"All", "Last 7 Days", "This Month", "This Year", "Custom Range"})
        Me.cbDateRange.Location = New System.Drawing.Point(1359, 57)
        Me.cbDateRange.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbDateRange.Name = "cbDateRange"
        Me.cbDateRange.Size = New System.Drawing.Size(353, 36)
        Me.cbDateRange.TabIndex = 3
        '
        'cbLoanStatus
        '
        Me.cbLoanStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbLoanStatus.AutoRoundedCorners = True
        Me.cbLoanStatus.BackColor = System.Drawing.Color.Transparent
        Me.cbLoanStatus.BorderRadius = 17
        Me.cbLoanStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLoanStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLoanStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbLoanStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbLoanStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbLoanStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbLoanStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbLoanStatus.ItemHeight = 30
        Me.cbLoanStatus.Items.AddRange(New Object() {"All", "Issued", "Returned"})
        Me.cbLoanStatus.Location = New System.Drawing.Point(983, 57)
        Me.cbLoanStatus.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbLoanStatus.Name = "cbLoanStatus"
        Me.cbLoanStatus.Size = New System.Drawing.Size(353, 36)
        Me.cbLoanStatus.TabIndex = 2
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(116, 10)
        Me.label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(174, 45)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Search by:"
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
        Me.tbSearch.Location = New System.Drawing.Point(500, 57)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(19, 21, 19, 21)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search records"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(467, 86)
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
        Me.cbSearchBy.Items.AddRange(New Object() {"Member Name", "Member ID", "Book Title", "Book ID"})
        Me.cbSearchBy.Location = New System.Drawing.Point(124, 57)
        Me.cbSearchBy.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(353, 36)
        Me.cbSearchBy.TabIndex = 0
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
        Me.pbExit.TabIndex = 1
        Me.pbExit.TabStop = False
        '
        'ViewRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1781, 1245)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.pnlCustomRange)
        Me.Controls.Add(Me.guna2Panel1)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Name = "ViewRecords"
        Me.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.Text = "ViewRecords"
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomRange.ResumeLayout(False)
        Me.pnlCustomRange.PerformLayout()
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvIssue As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents pnlCustomRange As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label5 As Label
    Private WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents label4 As Label
    Private WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents cbDateRange As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents cbLoanStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents label1 As Label
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
End Class
