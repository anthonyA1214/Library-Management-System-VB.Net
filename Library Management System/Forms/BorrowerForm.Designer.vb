﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowerForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowerForm))
        Me.pnlSideMenu = New System.Windows.Forms.Panel()
        Me.pnlSettingsSubMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.autoLoadDashboard = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTitleBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlTitle = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDateAndTime = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.tlp2 = New System.Windows.Forms.TableLayoutPanel()
        Me.guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvIssue2 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.label13 = New System.Windows.Forms.Label()
        Me.guna2Panel15 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvIssue1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tlp1 = New System.Windows.Forms.TableLayoutPanel()
        Me.guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalBorrowed = New System.Windows.Forms.Label()
        Me.guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblCurrentlyBorrowed = New System.Windows.Forms.Label()
        Me.guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBorrow = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlSideMenu.SuspendLayout()
        Me.pnlSettingsSubMenu.SuspendLayout()
        Me.guna2Panel1.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        Me.tlp2.SuspendLayout()
        Me.guna2Panel11.SuspendLayout()
        CType(Me.dgvIssue2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel15.SuspendLayout()
        CType(Me.dgvIssue1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp1.SuspendLayout()
        Me.guna2Panel3.SuspendLayout()
        Me.guna2Panel4.SuspendLayout()
        Me.guna2Panel2.SuspendLayout()
        Me.guna2Panel6.SuspendLayout()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.AutoScroll = True
        Me.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlSideMenu.Controls.Add(Me.pnlSettingsSubMenu)
        Me.pnlSideMenu.Controls.Add(Me.btnSettings)
        Me.pnlSideMenu.Controls.Add(Me.btnBorrow)
        Me.pnlSideMenu.Controls.Add(Me.btnLogout)
        Me.pnlSideMenu.Controls.Add(Me.btnDashboard)
        Me.pnlSideMenu.Controls.Add(Me.guna2Panel1)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(333, 717)
        Me.pnlSideMenu.TabIndex = 4
        '
        'pnlSettingsSubMenu
        '
        Me.pnlSettingsSubMenu.Controls.Add(Me.btnPassword)
        Me.pnlSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSettingsSubMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnlSettingsSubMenu.Location = New System.Drawing.Point(0, 350)
        Me.pnlSettingsSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSettingsSubMenu.Name = "pnlSettingsSubMenu"
        Me.pnlSettingsSubMenu.Size = New System.Drawing.Size(333, 55)
        Me.pnlSettingsSubMenu.TabIndex = 36
        '
        'btnPassword
        '
        Me.btnPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPassword.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPassword.Location = New System.Drawing.Point(0, 0)
        Me.btnPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Padding = New System.Windows.Forms.Padding(33, 0, 0, 0)
        Me.btnPassword.Size = New System.Drawing.Size(333, 49)
        Me.btnPassword.TabIndex = 5
        Me.btnPassword.Text = "Change Password"
        Me.btnPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'guna2Panel1
        '
        Me.guna2Panel1.Controls.Add(Me.guna2PictureBox5)
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(333, 185)
        Me.guna2Panel1.TabIndex = 2
        '
        'autoLoadDashboard
        '
        Me.autoLoadDashboard.Enabled = True
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.btnClose)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(333, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(928, 31)
        Me.pnlTitleBar.TabIndex = 5
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.lblDateAndTime)
        Me.pnlTitle.Controls.Add(Me.lblName)
        Me.pnlTitle.Controls.Add(Me.Label4)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(333, 31)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(928, 123)
        Me.pnlTitle.TabIndex = 6
        '
        'lblDateAndTime
        '
        Me.lblDateAndTime.AutoSize = True
        Me.lblDateAndTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAndTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDateAndTime.Location = New System.Drawing.Point(12, 66)
        Me.lblDateAndTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateAndTime.Name = "lblDateAndTime"
        Me.lblDateAndTime.Size = New System.Drawing.Size(145, 28)
        Me.lblDateAndTime.TabIndex = 2
        Me.lblDateAndTime.Text = "Date and Time"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(135, 11)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(116, 54)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "user!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 54)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hello,"
        '
        'pnlContainer
        '
        Me.pnlContainer.AutoScroll = True
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnlContainer.BorderRadius = 5
        Me.pnlContainer.Controls.Add(Me.tlp2)
        Me.pnlContainer.Controls.Add(Me.tlp1)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(333, 154)
        Me.pnlContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(928, 563)
        Me.pnlContainer.TabIndex = 7
        '
        'tlp2
        '
        Me.tlp2.ColumnCount = 2
        Me.tlp2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp2.Controls.Add(Me.guna2Panel11, 1, 0)
        Me.tlp2.Controls.Add(Me.guna2Panel15, 0, 0)
        Me.tlp2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlp2.Location = New System.Drawing.Point(0, 154)
        Me.tlp2.Margin = New System.Windows.Forms.Padding(4)
        Me.tlp2.Name = "tlp2"
        Me.tlp2.RowCount = 1
        Me.tlp2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp2.Size = New System.Drawing.Size(928, 308)
        Me.tlp2.TabIndex = 7
        '
        'guna2Panel11
        '
        Me.guna2Panel11.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel11.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.guna2Panel11.BorderRadius = 20
        Me.guna2Panel11.BorderThickness = 1
        Me.guna2Panel11.Controls.Add(Me.dgvIssue2)
        Me.guna2Panel11.Controls.Add(Me.label13)
        Me.guna2Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel11.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel11.Location = New System.Drawing.Point(468, 4)
        Me.guna2Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel11.Name = "guna2Panel11"
        Me.guna2Panel11.Size = New System.Drawing.Size(456, 300)
        Me.guna2Panel11.TabIndex = 2
        '
        'dgvIssue2
        '
        Me.dgvIssue2.AllowUserToAddRows = False
        Me.dgvIssue2.AllowUserToDeleteRows = False
        Me.dgvIssue2.AllowUserToResizeColumns = False
        Me.dgvIssue2.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvIssue2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIssue2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvIssue2.ColumnHeadersHeight = 50
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue2.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvIssue2.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue2.Location = New System.Drawing.Point(7, 49)
        Me.dgvIssue2.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIssue2.Name = "dgvIssue2"
        Me.dgvIssue2.ReadOnly = True
        Me.dgvIssue2.RowHeadersVisible = False
        Me.dgvIssue2.RowHeadersWidth = 51
        Me.dgvIssue2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue2.Size = New System.Drawing.Size(440, 209)
        Me.dgvIssue2.TabIndex = 5
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
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label13.Location = New System.Drawing.Point(9, 9)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(256, 37)
        Me.label13.TabIndex = 0
        Me.label13.Text = "Borrowing History"
        '
        'guna2Panel15
        '
        Me.guna2Panel15.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel15.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.guna2Panel15.BorderRadius = 20
        Me.guna2Panel15.BorderThickness = 1
        Me.guna2Panel15.Controls.Add(Me.dgvIssue1)
        Me.guna2Panel15.Controls.Add(Me.label10)
        Me.guna2Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel15.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel15.Location = New System.Drawing.Point(4, 4)
        Me.guna2Panel15.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel15.Name = "guna2Panel15"
        Me.guna2Panel15.Size = New System.Drawing.Size(456, 300)
        Me.guna2Panel15.TabIndex = 1
        '
        'dgvIssue1
        '
        Me.dgvIssue1.AllowUserToAddRows = False
        Me.dgvIssue1.AllowUserToDeleteRows = False
        Me.dgvIssue1.AllowUserToResizeColumns = False
        Me.dgvIssue1.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvIssue1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIssue1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvIssue1.ColumnHeadersHeight = 50
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue1.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvIssue1.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue1.Location = New System.Drawing.Point(7, 49)
        Me.dgvIssue1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIssue1.Name = "dgvIssue1"
        Me.dgvIssue1.ReadOnly = True
        Me.dgvIssue1.RowHeadersVisible = False
        Me.dgvIssue1.RowHeadersWidth = 51
        Me.dgvIssue1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue1.Size = New System.Drawing.Size(441, 209)
        Me.dgvIssue1.TabIndex = 4
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
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(9, 9)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(271, 37)
        Me.label10.TabIndex = 0
        Me.label10.Text = "Currently Borrowed"
        '
        'tlp1
        '
        Me.tlp1.ColumnCount = 2
        Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp1.Controls.Add(Me.guna2Panel3, 1, 0)
        Me.tlp1.Controls.Add(Me.guna2Panel2, 0, 0)
        Me.tlp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlp1.Location = New System.Drawing.Point(0, 0)
        Me.tlp1.Margin = New System.Windows.Forms.Padding(4)
        Me.tlp1.Name = "tlp1"
        Me.tlp1.RowCount = 1
        Me.tlp1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp1.Size = New System.Drawing.Size(928, 154)
        Me.tlp1.TabIndex = 5
        '
        'guna2Panel3
        '
        Me.guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel3.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.guna2Panel3.BorderRadius = 20
        Me.guna2Panel3.BorderThickness = 1
        Me.guna2Panel3.Controls.Add(Me.Label1)
        Me.guna2Panel3.Controls.Add(Me.lblTotalBorrowed)
        Me.guna2Panel3.Controls.Add(Me.guna2Panel4)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel3.Location = New System.Drawing.Point(468, 4)
        Me.guna2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Size = New System.Drawing.Size(456, 146)
        Me.guna2Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Borrowed"
        '
        'lblTotalBorrowed
        '
        Me.lblTotalBorrowed.AutoSize = True
        Me.lblTotalBorrowed.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBorrowed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTotalBorrowed.Location = New System.Drawing.Point(11, 12)
        Me.lblTotalBorrowed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalBorrowed.Name = "lblTotalBorrowed"
        Me.lblTotalBorrowed.Size = New System.Drawing.Size(46, 54)
        Me.lblTotalBorrowed.TabIndex = 3
        Me.lblTotalBorrowed.Text = "0"
        '
        'guna2Panel4
        '
        Me.guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2Panel4.BorderRadius = 25
        Me.guna2Panel4.Controls.Add(Me.guna2PictureBox2)
        Me.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.guna2Panel4.Location = New System.Drawing.Point(382, 9)
        Me.guna2Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel4.Name = "guna2Panel4"
        Me.guna2Panel4.Size = New System.Drawing.Size(67, 62)
        Me.guna2Panel4.TabIndex = 0
        '
        'guna2Panel2
        '
        Me.guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.guna2Panel2.BorderRadius = 20
        Me.guna2Panel2.BorderThickness = 1
        Me.guna2Panel2.Controls.Add(Me.label3)
        Me.guna2Panel2.Controls.Add(Me.lblCurrentlyBorrowed)
        Me.guna2Panel2.Controls.Add(Me.guna2Panel6)
        Me.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel2.Location = New System.Drawing.Point(4, 4)
        Me.guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Size = New System.Drawing.Size(456, 146)
        Me.guna2Panel2.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(16, 71)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(189, 28)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Currently Borrowed"
        '
        'lblCurrentlyBorrowed
        '
        Me.lblCurrentlyBorrowed.AutoSize = True
        Me.lblCurrentlyBorrowed.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentlyBorrowed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblCurrentlyBorrowed.Location = New System.Drawing.Point(11, 12)
        Me.lblCurrentlyBorrowed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentlyBorrowed.Name = "lblCurrentlyBorrowed"
        Me.lblCurrentlyBorrowed.Size = New System.Drawing.Size(46, 54)
        Me.lblCurrentlyBorrowed.TabIndex = 3
        Me.lblCurrentlyBorrowed.Text = "0"
        '
        'guna2Panel6
        '
        Me.guna2Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2Panel6.BorderRadius = 25
        Me.guna2Panel6.Controls.Add(Me.guna2PictureBox1)
        Me.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.guna2Panel6.Location = New System.Drawing.Point(382, 9)
        Me.guna2Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel6.Name = "guna2Panel6"
        Me.guna2Panel6.Size = New System.Drawing.Size(67, 62)
        Me.guna2Panel6.TabIndex = 0
        '
        'guna2PictureBox2
        '
        Me.guna2PictureBox2.Image = Global.Library_Management_System.My.Resources.Resources.book2
        Me.guna2PictureBox2.ImageRotate = 0!
        Me.guna2PictureBox2.Location = New System.Drawing.Point(17, 16)
        Me.guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox2.Name = "guna2PictureBox2"
        Me.guna2PictureBox2.Size = New System.Drawing.Size(33, 31)
        Me.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox2.TabIndex = 1
        Me.guna2PictureBox2.TabStop = False
        '
        'guna2PictureBox1
        '
        Me.guna2PictureBox1.Image = CType(resources.GetObject("guna2PictureBox1.Image"), System.Drawing.Image)
        Me.guna2PictureBox1.ImageRotate = 0!
        Me.guna2PictureBox1.Location = New System.Drawing.Point(17, 16)
        Me.guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox1.Name = "guna2PictureBox1"
        Me.guna2PictureBox1.Size = New System.Drawing.Size(33, 31)
        Me.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox1.TabIndex = 0
        Me.guna2PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnClose.Image = Global.Library_Management_System.My.Resources.Resources.close
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(883, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(45, 31)
        Me.btnClose.TabIndex = 0
        '
        'btnSettings
        '
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnSettings.Image = Global.Library_Management_System.My.Resources.Resources.settings
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.Location = New System.Drawing.Point(0, 295)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnSettings.Size = New System.Drawing.Size(333, 55)
        Me.btnSettings.TabIndex = 35
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnBorrow
        '
        Me.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrow.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBorrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnBorrow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnBorrow.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnBorrow.Image = Global.Library_Management_System.My.Resources.Resources.images_removebg_preview
        Me.btnBorrow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBorrow.Location = New System.Drawing.Point(0, 240)
        Me.btnBorrow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnBorrow.Size = New System.Drawing.Size(333, 55)
        Me.btnBorrow.TabIndex = 34
        Me.btnBorrow.Text = "Borrow Book"
        Me.btnBorrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLogout
        '
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnLogout.Image = Global.Library_Management_System.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(0, 662)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(333, 55)
        Me.btnLogout.TabIndex = 30
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnDashboard
        '
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnDashboard.Image = Global.Library_Management_System.My.Resources.Resources.dashboard
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.Location = New System.Drawing.Point(0, 185)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(333, 55)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'guna2PictureBox5
        '
        Me.guna2PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2PictureBox5.Image = Global.Library_Management_System.My.Resources.Resources.logo_removebg_preview
        Me.guna2PictureBox5.ImageRotate = 0!
        Me.guna2PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.guna2PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox5.Name = "guna2PictureBox5"
        Me.guna2PictureBox5.Size = New System.Drawing.Size(333, 185)
        Me.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox5.TabIndex = 0
        Me.guna2PictureBox5.TabStop = False
        '
        'BorrowerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1261, 717)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.pnlSideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowerForm"
        Me.Text = "BorrowerForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlSettingsSubMenu.ResumeLayout(False)
        Me.guna2Panel1.ResumeLayout(False)
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlContainer.ResumeLayout(False)
        Me.tlp2.ResumeLayout(False)
        Me.guna2Panel11.ResumeLayout(False)
        Me.guna2Panel11.PerformLayout()
        CType(Me.dgvIssue2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel15.ResumeLayout(False)
        Me.guna2Panel15.PerformLayout()
        CType(Me.dgvIssue1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp1.ResumeLayout(False)
        Me.guna2Panel3.ResumeLayout(False)
        Me.guna2Panel3.PerformLayout()
        Me.guna2Panel4.ResumeLayout(False)
        Me.guna2Panel2.ResumeLayout(False)
        Me.guna2Panel2.PerformLayout()
        Me.guna2Panel6.ResumeLayout(False)
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnlSideMenu As Panel
    Private WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Private WithEvents autoLoadDashboard As Timer
    Friend WithEvents pnlTitleBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pnlTitle As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblDateAndTime As Label
    Private WithEvents lblName As Label
    Private WithEvents Label4 As Label
    Private WithEvents pnlContainer As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tlp2 As TableLayoutPanel
    Private WithEvents guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvIssue2 As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents label13 As Label
    Private WithEvents guna2Panel15 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvIssue1 As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents label10 As Label
    Private WithEvents tlp1 As TableLayoutPanel
    Private WithEvents guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents Label1 As Label
    Private WithEvents lblTotalBorrowed As Label
    Private WithEvents guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents label3 As Label
    Private WithEvents lblCurrentlyBorrowed As Label
    Private WithEvents guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents pnlSettingsSubMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnPassword As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnBorrow As Guna.UI2.WinForms.Guna2Button
End Class
