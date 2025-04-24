<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueBook
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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbSearch1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbSearchBy1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvMember = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIssueBook = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblBookAuthor = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.guna2Panel1.SuspendLayout()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.guna2Panel5.SuspendLayout()
        CType(Me.guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.82098!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.17901!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.guna2Panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.guna2Panel5, 2, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(13, 12)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(865, 618)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'guna2Panel1
        '
        Me.guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel1.BorderRadius = 20
        Me.guna2Panel1.Controls.Add(Me.tbSearch1)
        Me.guna2Panel1.Controls.Add(Me.label2)
        Me.guna2Panel1.Controls.Add(Me.cbSearchBy1)
        Me.guna2Panel1.Controls.Add(Me.guna2PictureBox2)
        Me.guna2Panel1.Controls.Add(Me.panel5)
        Me.guna2Panel1.Controls.Add(Me.label1)
        Me.guna2Panel1.Controls.Add(Me.dgvMember)
        Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel1.Location = New System.Drawing.Point(4, 4)
        Me.guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(570, 610)
        Me.guna2Panel1.TabIndex = 10
        '
        'tbSearch1
        '
        Me.tbSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbSearch1.AutoRoundedCorners = True
        Me.tbSearch1.BorderRadius = 21
        Me.tbSearch1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch1.DefaultText = ""
        Me.tbSearch1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearch1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearch1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.tbSearch1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch1.Location = New System.Drawing.Point(344, 129)
        Me.tbSearch1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSearch1.Name = "tbSearch1"
        Me.tbSearch1.PlaceholderText = "Search pendings"
        Me.tbSearch1.SelectedText = ""
        Me.tbSearch1.Size = New System.Drawing.Size(191, 44)
        Me.tbSearch1.TabIndex = 36
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(53, 139)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(89, 23)
        Me.label2.TabIndex = 34
        Me.label2.Text = "Search by:"
        '
        'cbSearchBy1
        '
        Me.cbSearchBy1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbSearchBy1.AutoRoundedCorners = True
        Me.cbSearchBy1.BackColor = System.Drawing.Color.Transparent
        Me.cbSearchBy1.BorderRadius = 17
        Me.cbSearchBy1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSearchBy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchBy1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbSearchBy1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSearchBy1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSearchBy1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSearchBy1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSearchBy1.ItemHeight = 30
        Me.cbSearchBy1.Items.AddRange(New Object() {"Member ID", "Member Name", "Book Title", "Author", "Genre"})
        Me.cbSearchBy1.Location = New System.Drawing.Point(149, 128)
        Me.cbSearchBy1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSearchBy1.Name = "cbSearchBy1"
        Me.cbSearchBy1.Size = New System.Drawing.Size(179, 36)
        Me.cbSearchBy1.TabIndex = 33
        '
        'guna2PictureBox2
        '
        Me.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox2.Image = Global.Library_Management_System.My.Resources.Resources.user2
        Me.guna2PictureBox2.ImageRotate = 0!
        Me.guna2PictureBox2.Location = New System.Drawing.Point(129, 47)
        Me.guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox2.Name = "guna2PictureBox2"
        Me.guna2PictureBox2.Size = New System.Drawing.Size(60, 55)
        Me.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox2.TabIndex = 31
        Me.guna2PictureBox2.TabStop = False
        '
        'panel5
        '
        Me.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel5.Location = New System.Drawing.Point(142, 110)
        Me.panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(287, 4)
        Me.panel5.TabIndex = 29
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(189, 58)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(233, 32)
        Me.label1.TabIndex = 30
        Me.label1.Text = "Pending Borrowers"
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        Me.dgvMember.AllowUserToResizeColumns = False
        Me.dgvMember.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMember.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMember.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMember.ColumnHeadersHeight = 50
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvMember.Location = New System.Drawing.Point(9, 192)
        Me.dgvMember.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.RowHeadersWidth = 51
        Me.dgvMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMember.Size = New System.Drawing.Size(553, 395)
        Me.dgvMember.TabIndex = 28
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
        'guna2Panel5
        '
        Me.guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel5.BorderRadius = 20
        Me.guna2Panel5.Controls.Add(Me.Label5)
        Me.guna2Panel5.Controls.Add(Me.Label4)
        Me.guna2Panel5.Controls.Add(Me.Label3)
        Me.guna2Panel5.Controls.Add(Me.btnIssueBook)
        Me.guna2Panel5.Controls.Add(Me.guna2PictureBox5)
        Me.guna2Panel5.Controls.Add(Me.lblBookAuthor)
        Me.guna2Panel5.Controls.Add(Me.label15)
        Me.guna2Panel5.Controls.Add(Me.lblBookTitle)
        Me.guna2Panel5.Controls.Add(Me.label13)
        Me.guna2Panel5.Controls.Add(Me.lblBookID)
        Me.guna2Panel5.Controls.Add(Me.label11)
        Me.guna2Panel5.Controls.Add(Me.guna2PictureBox4)
        Me.guna2Panel5.Controls.Add(Me.lblMemberName)
        Me.guna2Panel5.Controls.Add(Me.label8)
        Me.guna2Panel5.Controls.Add(Me.lblMemberID)
        Me.guna2Panel5.Controls.Add(Me.label7)
        Me.guna2Panel5.Controls.Add(Me.guna2PictureBox3)
        Me.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel5.Location = New System.Drawing.Point(582, 4)
        Me.guna2Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel5.Name = "guna2Panel5"
        Me.guna2Panel5.Size = New System.Drawing.Size(279, 610)
        Me.guna2Panel5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(84, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 28)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Issue Book"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(84, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 28)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Book Details"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(84, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 28)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Borrower Details"
        '
        'btnIssueBook
        '
        Me.btnIssueBook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIssueBook.AutoRoundedCorners = True
        Me.btnIssueBook.BorderRadius = 23
        Me.btnIssueBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIssueBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIssueBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIssueBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIssueBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnIssueBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnIssueBook.ForeColor = System.Drawing.Color.White
        Me.btnIssueBook.Location = New System.Drawing.Point(39, 559)
        Me.btnIssueBook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(200, 49)
        Me.btnIssueBook.TabIndex = 47
        Me.btnIssueBook.Text = "Issue Book"
        '
        'guna2PictureBox5
        '
        Me.guna2PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox5.Image = Global.Library_Management_System.My.Resources.Resources.book5
        Me.guna2PictureBox5.ImageRotate = 0!
        Me.guna2PictureBox5.Location = New System.Drawing.Point(30, 342)
        Me.guna2PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox5.Name = "guna2PictureBox5"
        Me.guna2PictureBox5.Size = New System.Drawing.Size(47, 43)
        Me.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox5.TabIndex = 46
        Me.guna2PictureBox5.TabStop = False
        '
        'lblBookAuthor
        '
        Me.lblBookAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookAuthor.AutoSize = True
        Me.lblBookAuthor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookAuthor.Location = New System.Drawing.Point(155, 303)
        Me.lblBookAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookAuthor.MaximumSize = New System.Drawing.Size(113, 0)
        Me.lblBookAuthor.Name = "lblBookAuthor"
        Me.lblBookAuthor.Size = New System.Drawing.Size(61, 23)
        Me.lblBookAuthor.TabIndex = 39
        Me.lblBookAuthor.Text = "author"
        '
        'label15
        '
        Me.label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label15.Location = New System.Drawing.Point(27, 303)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(118, 23)
        Me.label15.TabIndex = 38
        Me.label15.Text = "Book Author:"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookTitle.Location = New System.Drawing.Point(155, 256)
        Me.lblBookTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookTitle.MaximumSize = New System.Drawing.Size(113, 0)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(39, 23)
        Me.lblBookTitle.TabIndex = 37
        Me.lblBookTitle.Text = "title"
        '
        'label13
        '
        Me.label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label13.Location = New System.Drawing.Point(27, 256)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(97, 23)
        Me.label13.TabIndex = 36
        Me.label13.Text = "Book Title:"
        '
        'lblBookID
        '
        Me.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookID.Location = New System.Drawing.Point(155, 215)
        Me.lblBookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(24, 23)
        Me.lblBookID.TabIndex = 35
        Me.lblBookID.Text = "id"
        '
        'label11
        '
        Me.label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(27, 215)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(79, 23)
        Me.label11.TabIndex = 34
        Me.label11.Text = "Book ID:"
        '
        'guna2PictureBox4
        '
        Me.guna2PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox4.Image = Global.Library_Management_System.My.Resources.Resources.book3
        Me.guna2PictureBox4.ImageRotate = 0!
        Me.guna2PictureBox4.Location = New System.Drawing.Point(30, 148)
        Me.guna2PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox4.Name = "guna2PictureBox4"
        Me.guna2PictureBox4.Size = New System.Drawing.Size(47, 43)
        Me.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox4.TabIndex = 33
        Me.guna2PictureBox4.TabStop = False
        '
        'lblMemberName
        '
        Me.lblMemberName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMemberName.Location = New System.Drawing.Point(171, 114)
        Me.lblMemberName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemberName.MaximumSize = New System.Drawing.Size(113, 0)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(53, 23)
        Me.lblMemberName.TabIndex = 30
        Me.lblMemberName.Text = "name"
        '
        'label8
        '
        Me.label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(27, 114)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(135, 23)
        Me.label8.TabIndex = 29
        Me.label8.Text = "Member Name:"
        '
        'lblMemberID
        '
        Me.lblMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMemberID.Location = New System.Drawing.Point(171, 73)
        Me.lblMemberID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(24, 23)
        Me.lblMemberID.TabIndex = 28
        Me.lblMemberID.Text = "id"
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(27, 74)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(106, 23)
        Me.label7.TabIndex = 27
        Me.label7.Text = "Member ID:"
        '
        'guna2PictureBox3
        '
        Me.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox3.Image = Global.Library_Management_System.My.Resources.Resources.user3
        Me.guna2PictureBox3.ImageRotate = 0!
        Me.guna2PictureBox3.Location = New System.Drawing.Point(30, 10)
        Me.guna2PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2PictureBox3.Name = "guna2PictureBox3"
        Me.guna2PictureBox3.Size = New System.Drawing.Size(47, 43)
        Me.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox3.TabIndex = 26
        Me.guna2PictureBox3.TabStop = False
        '
        'IssueBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 642)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "IssueBook"
        Me.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Text = "IssueBook"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.guna2Panel1.ResumeLayout(False)
        Me.guna2Panel1.PerformLayout()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.guna2Panel5.ResumeLayout(False)
        Me.guna2Panel5.PerformLayout()
        CType(Me.guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents tbSearch1 As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label2 As Label
    Private WithEvents cbSearchBy1 As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents panel5 As Panel
    Private WithEvents label1 As Label
    Private WithEvents dgvMember As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnIssueBook As Guna.UI2.WinForms.Guna2Button
    Private WithEvents guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblBookAuthor As Label
    Private WithEvents label15 As Label
    Private WithEvents lblBookTitle As Label
    Private WithEvents label13 As Label
    Private WithEvents lblBookID As Label
    Private WithEvents label11 As Label
    Private WithEvents guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents lblMemberName As Label
    Private WithEvents label8 As Label
    Private WithEvents lblMemberID As Label
    Private WithEvents label7 As Label
    Private WithEvents guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
