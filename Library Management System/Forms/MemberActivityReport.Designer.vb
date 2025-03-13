<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberActivityReport
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
        Me.pnlAddGenre = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvMember = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlAddGenre.SuspendLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAddGenre
        '
        Me.pnlAddGenre.BackColor = System.Drawing.Color.Transparent
        Me.pnlAddGenre.BorderRadius = 10
        Me.pnlAddGenre.Controls.Add(Me.btnExport)
        Me.pnlAddGenre.Controls.Add(Me.label1)
        Me.pnlAddGenre.Controls.Add(Me.tbSearch)
        Me.pnlAddGenre.Controls.Add(Me.cbSearchBy)
        Me.pnlAddGenre.Controls.Add(Me.pbExit)
        Me.pnlAddGenre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlAddGenre.Location = New System.Drawing.Point(0, 0)
        Me.pnlAddGenre.Name = "pnlAddGenre"
        Me.pnlAddGenre.Size = New System.Drawing.Size(668, 50)
        Me.pnlAddGenre.TabIndex = 61
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
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "Export Report"
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(228, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 17)
        Me.label1.TabIndex = 6
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
        Me.tbSearch.TabIndex = 5
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
        Me.cbSearchBy.TabIndex = 4
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
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(0, 50)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.guna2Panel3.Size = New System.Drawing.Size(668, 472)
        Me.guna2Panel3.TabIndex = 65
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
        Me.pnlGrid.Size = New System.Drawing.Size(648, 452)
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
        Me.dgvMember.Size = New System.Drawing.Size(628, 432)
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
        'MemberActivityReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.pnlAddGenre)
        Me.Name = "MemberActivityReport"
        Me.Text = "MemberActivityReport"
        Me.pnlAddGenre.ResumeLayout(False)
        Me.pnlAddGenre.PerformLayout()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlAddGenre As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label1 As Label
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvMember As Guna.UI2.WinForms.Guna2DataGridView
End Class
