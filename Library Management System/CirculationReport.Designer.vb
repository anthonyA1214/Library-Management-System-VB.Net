<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CirculationReport
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
        Me.pnlAddGenre = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lblOverdueItems = New System.Windows.Forms.Label()
        Me.lblTotalItemsReturned = New System.Windows.Forms.Label()
        Me.lblTotalItemsBorrowed = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvIssue = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlAddGenre.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2CustomGradientPanel2.SuspendLayout()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAddGenre
        '
        Me.pnlAddGenre.BackColor = System.Drawing.Color.Transparent
        Me.pnlAddGenre.BorderRadius = 10
        Me.pnlAddGenre.Controls.Add(Me.btnExport)
        Me.pnlAddGenre.Controls.Add(Me.label7)
        Me.pnlAddGenre.Controls.Add(Me.cbSearchBy)
        Me.pnlAddGenre.Controls.Add(Me.pbExit)
        Me.pnlAddGenre.Controls.Add(Me.tbSearch)
        Me.pnlAddGenre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlAddGenre.Location = New System.Drawing.Point(0, 0)
        Me.pnlAddGenre.Name = "pnlAddGenre"
        Me.pnlAddGenre.Size = New System.Drawing.Size(668, 54)
        Me.pnlAddGenre.TabIndex = 56
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExport.AutoRoundedCorners = True
        Me.btnExport.BorderRadius = 19
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(72, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(150, 40)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export Report"
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(228, 18)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(70, 17)
        Me.label7.TabIndex = 5
        Me.label7.Text = "Search by:"
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
        Me.cbSearchBy.Items.AddRange(New Object() {"Issue ID", "Book Title", "Member Name"})
        Me.cbSearchBy.Location = New System.Drawing.Point(307, 7)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(140, 36)
        Me.cbSearchBy.TabIndex = 4
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
        Me.tbSearch.PlaceholderText = "Search records"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(200, 36)
        Me.tbSearch.TabIndex = 1
        '
        'pbExit
        '
        Me.pbExit.Image = Global.Library_Management_System.My.Resources.Resources.reject2
        Me.pbExit.ImageRotate = 0!
        Me.pbExit.Location = New System.Drawing.Point(7, 7)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(25, 25)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit.TabIndex = 3
        Me.pbExit.TabStop = False
        '
        'guna2CustomGradientPanel2
        '
        Me.guna2CustomGradientPanel2.Controls.Add(Me.label10)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.lblOverdueItems)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.lblTotalItemsReturned)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.lblTotalItemsBorrowed)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.label6)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.label2)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.label1)
        Me.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 379)
        Me.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2"
        Me.guna2CustomGradientPanel2.Size = New System.Drawing.Size(668, 143)
        Me.guna2CustomGradientPanel2.TabIndex = 57
        '
        'label10
        '
        Me.label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(171, 62)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(141, 17)
        Me.label10.TabIndex = 55
        Me.label10.Text = "Total Items Returned:"
        '
        'lblOverdueItems
        '
        Me.lblOverdueItems.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblOverdueItems.AutoSize = True
        Me.lblOverdueItems.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdueItems.Location = New System.Drawing.Point(315, 90)
        Me.lblOverdueItems.Name = "lblOverdueItems"
        Me.lblOverdueItems.Size = New System.Drawing.Size(39, 20)
        Me.lblOverdueItems.TabIndex = 53
        Me.lblOverdueItems.Text = "_____"
        '
        'lblTotalItemsReturned
        '
        Me.lblTotalItemsReturned.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalItemsReturned.AutoSize = True
        Me.lblTotalItemsReturned.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemsReturned.Location = New System.Drawing.Point(315, 61)
        Me.lblTotalItemsReturned.Name = "lblTotalItemsReturned"
        Me.lblTotalItemsReturned.Size = New System.Drawing.Size(39, 20)
        Me.lblTotalItemsReturned.TabIndex = 52
        Me.lblTotalItemsReturned.Text = "_____"
        '
        'lblTotalItemsBorrowed
        '
        Me.lblTotalItemsBorrowed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalItemsBorrowed.AutoSize = True
        Me.lblTotalItemsBorrowed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemsBorrowed.Location = New System.Drawing.Point(317, 28)
        Me.lblTotalItemsBorrowed.Name = "lblTotalItemsBorrowed"
        Me.lblTotalItemsBorrowed.Size = New System.Drawing.Size(39, 20)
        Me.lblTotalItemsBorrowed.TabIndex = 51
        Me.lblTotalItemsBorrowed.Text = "_____"
        '
        'label6
        '
        Me.label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(210, 92)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(102, 17)
        Me.label6.TabIndex = 50
        Me.label6.Text = "Overdue Items:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(168, 29)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(144, 17)
        Me.label2.TabIndex = 48
        Me.label2.Text = "Total Items Borrowed:"
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(17, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(136, 21)
        Me.label1.TabIndex = 48
        Me.label1.Text = "Report Overview:"
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(0, 54)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.guna2Panel3.Size = New System.Drawing.Size(668, 325)
        Me.guna2Panel3.TabIndex = 60
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvIssue)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(10, 10)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlGrid.Size = New System.Drawing.Size(648, 305)
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
        Me.dgvIssue.Location = New System.Drawing.Point(10, 10)
        Me.dgvIssue.Name = "dgvIssue"
        Me.dgvIssue.ReadOnly = True
        Me.dgvIssue.RowHeadersVisible = False
        Me.dgvIssue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue.Size = New System.Drawing.Size(628, 285)
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
        'CirculationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.guna2CustomGradientPanel2)
        Me.Controls.Add(Me.pnlAddGenre)
        Me.Name = "CirculationReport"
        Me.Text = "CirculationReport"
        Me.pnlAddGenre.ResumeLayout(False)
        Me.pnlAddGenre.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2CustomGradientPanel2.ResumeLayout(False)
        Me.guna2CustomGradientPanel2.PerformLayout()
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlAddGenre As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label7 As Label
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents label10 As Label
    Private WithEvents lblOverdueItems As Label
    Private WithEvents lblTotalItemsReturned As Label
    Private WithEvents lblTotalItemsBorrowed As Label
    Private WithEvents label6 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvIssue As Guna.UI2.WinForms.Guna2DataGridView
End Class
