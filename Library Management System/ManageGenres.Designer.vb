﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageGenres
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
        Me.dgvGenre = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlAddGenre = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSaveGenre = New Guna.UI2.WinForms.Guna2Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbGenreName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddGenre = New Guna.UI2.WinForms.Guna2Button()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbExit2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pbExit = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2Panel3.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddGenre.SuspendLayout()
        Me.pnlTopMenu.SuspendLayout()
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(27, 310)
        Me.guna2Panel3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.guna2Panel3.Size = New System.Drawing.Size(1727, 911)
        Me.guna2Panel3.TabIndex = 37
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvGenre)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(27, 24)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.pnlGrid.Size = New System.Drawing.Size(1673, 863)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvGenre
        '
        Me.dgvGenre.AllowUserToAddRows = False
        Me.dgvGenre.AllowUserToDeleteRows = False
        Me.dgvGenre.AllowUserToResizeColumns = False
        Me.dgvGenre.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvGenre.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGenre.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGenre.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGenre.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGenre.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGenre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGenre.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvGenre.Location = New System.Drawing.Point(27, 24)
        Me.dgvGenre.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dgvGenre.Name = "dgvGenre"
        Me.dgvGenre.ReadOnly = True
        Me.dgvGenre.RowHeadersVisible = False
        Me.dgvGenre.RowHeadersWidth = 102
        Me.dgvGenre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGenre.Size = New System.Drawing.Size(1619, 815)
        Me.dgvGenre.TabIndex = 0
        Me.dgvGenre.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen
        Me.dgvGenre.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvGenre.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvGenre.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvGenre.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvGenre.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvGenre.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvGenre.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvGenre.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.dgvGenre.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGenre.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvGenre.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvGenre.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGenre.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvGenre.ThemeStyle.ReadOnly = True
        Me.dgvGenre.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgvGenre.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvGenre.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvGenre.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvGenre.ThemeStyle.RowsStyle.Height = 22
        Me.dgvGenre.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.dgvGenre.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pnlAddGenre
        '
        Me.pnlAddGenre.BackColor = System.Drawing.Color.Transparent
        Me.pnlAddGenre.BorderRadius = 10
        Me.pnlAddGenre.Controls.Add(Me.pbExit2)
        Me.pnlAddGenre.Controls.Add(Me.btnSaveGenre)
        Me.pnlAddGenre.Controls.Add(Me.label2)
        Me.pnlAddGenre.Controls.Add(Me.tbGenreName)
        Me.pnlAddGenre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlAddGenre.Location = New System.Drawing.Point(27, 155)
        Me.pnlAddGenre.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlAddGenre.Name = "pnlAddGenre"
        Me.pnlAddGenre.Size = New System.Drawing.Size(1727, 155)
        Me.pnlAddGenre.TabIndex = 36
        '
        'btnSaveGenre
        '
        Me.btnSaveGenre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveGenre.AutoRoundedCorners = True
        Me.btnSaveGenre.BorderRadius = 46
        Me.btnSaveGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaveGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnSaveGenre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSaveGenre.ForeColor = System.Drawing.Color.White
        Me.btnSaveGenre.Location = New System.Drawing.Point(388, 45)
        Me.btnSaveGenre.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnSaveGenre.Name = "btnSaveGenre"
        Me.btnSaveGenre.Size = New System.Drawing.Size(400, 95)
        Me.btnSaveGenre.TabIndex = 3
        Me.btnSaveGenre.Text = "Save Genre"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(818, 14)
        Me.label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(216, 45)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Genre Name:"
        '
        'tbGenreName
        '
        Me.tbGenreName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbGenreName.AutoRoundedCorners = True
        Me.tbGenreName.BorderRadius = 42
        Me.tbGenreName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbGenreName.DefaultText = ""
        Me.tbGenreName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbGenreName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbGenreName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbGenreName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbGenreName.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbGenreName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbGenreName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbGenreName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbGenreName.Location = New System.Drawing.Point(804, 62)
        Me.tbGenreName.Margin = New System.Windows.Forms.Padding(19, 21, 19, 21)
        Me.tbGenreName.Name = "tbGenreName"
        Me.tbGenreName.PlaceholderText = ""
        Me.tbGenreName.SelectedText = ""
        Me.tbGenreName.Size = New System.Drawing.Size(533, 86)
        Me.tbGenreName.TabIndex = 3
        '
        'guna2Panel1
        '
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.guna2Panel1.Location = New System.Drawing.Point(27, 143)
        Me.guna2Panel1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(1727, 12)
        Me.guna2Panel1.TabIndex = 35
        '
        'pnlTopMenu
        '
        Me.pnlTopMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopMenu.BorderRadius = 10
        Me.pnlTopMenu.Controls.Add(Me.btnAddGenre)
        Me.pnlTopMenu.Controls.Add(Me.pbExit)
        Me.pnlTopMenu.Controls.Add(Me.tbSearch)
        Me.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTopMenu.Location = New System.Drawing.Point(27, 24)
        Me.pnlTopMenu.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pnlTopMenu.Name = "pnlTopMenu"
        Me.pnlTopMenu.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.pnlTopMenu.Size = New System.Drawing.Size(1727, 119)
        Me.pnlTopMenu.TabIndex = 34
        '
        'btnAddGenre
        '
        Me.btnAddGenre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddGenre.AutoRoundedCorners = True
        Me.btnAddGenre.BorderRadius = 46
        Me.btnAddGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnAddGenre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddGenre.ForeColor = System.Drawing.Color.White
        Me.btnAddGenre.Location = New System.Drawing.Point(388, 12)
        Me.btnAddGenre.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAddGenre.Name = "btnAddGenre"
        Me.btnAddGenre.Size = New System.Drawing.Size(400, 95)
        Me.btnAddGenre.TabIndex = 2
        Me.btnAddGenre.Text = "Add Genre"
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
        Me.tbSearch.Location = New System.Drawing.Point(804, 17)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(19, 21, 19, 21)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search genres"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(533, 86)
        Me.tbSearch.TabIndex = 1
        '
        'pbExit2
        '
        Me.pbExit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbExit2.ImageRotate = 0!
        Me.pbExit2.Location = New System.Drawing.Point(1636, 17)
        Me.pbExit2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pbExit2.Name = "pbExit2"
        Me.pbExit2.Size = New System.Drawing.Size(67, 60)
        Me.pbExit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit2.TabIndex = 3
        Me.pbExit2.TabStop = False
        '
        'pbExit
        '
        Me.pbExit.ImageRotate = 0!
        Me.pbExit.Location = New System.Drawing.Point(19, 17)
        Me.pbExit.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(67, 60)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbExit.TabIndex = 1
        Me.pbExit.TabStop = False
        '
        'ManageGenres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1781, 1245)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.pnlAddGenre)
        Me.Controls.Add(Me.guna2Panel1)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.MinimumSize = New System.Drawing.Size(1771, 1216)
        Me.Name = "ManageGenres"
        Me.Padding = New System.Windows.Forms.Padding(27, 24, 27, 24)
        Me.Text = "ManageGenres"
        Me.guna2Panel3.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvGenre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddGenre.ResumeLayout(False)
        Me.pnlAddGenre.PerformLayout()
        Me.pnlTopMenu.ResumeLayout(False)
        CType(Me.pbExit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvGenre As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents pnlAddGenre As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pbExit2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents btnSaveGenre As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label2 As Label
    Private WithEvents tbGenreName As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnAddGenre As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pbExit As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
