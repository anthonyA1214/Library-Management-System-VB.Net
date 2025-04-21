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
        Me.btnIssueBook = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label17 = New System.Windows.Forms.Label()
        Me.dtpDueDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.label16 = New System.Windows.Forms.Label()
        Me.dtpIssueDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblBookAuthor = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.guna2Panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.guna2Panel5, 2, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(648, 502)
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
        Me.guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.guna2Panel1.Name = "guna2Panel1"
        Me.guna2Panel1.Size = New System.Drawing.Size(426, 496)
        Me.guna2Panel1.TabIndex = 10
        '
        'tbSearch1
        '
        Me.tbSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbSearch1.AutoRoundedCorners = True
        Me.tbSearch1.BorderRadius = 17
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
        Me.tbSearch1.Location = New System.Drawing.Point(257, 105)
        Me.tbSearch1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbSearch1.Name = "tbSearch1"
        Me.tbSearch1.PlaceholderText = "Search pendings"
        Me.tbSearch1.SelectedText = ""
        Me.tbSearch1.Size = New System.Drawing.Size(143, 36)
        Me.tbSearch1.TabIndex = 36
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(39, 113)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(70, 17)
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
        Me.cbSearchBy1.Location = New System.Drawing.Point(111, 104)
        Me.cbSearchBy1.Name = "cbSearchBy1"
        Me.cbSearchBy1.Size = New System.Drawing.Size(135, 36)
        Me.cbSearchBy1.TabIndex = 33
        '
        'guna2PictureBox2
        '
        Me.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox2.Image = Global.Library_Management_System.My.Resources.Resources.user2
        Me.guna2PictureBox2.ImageRotate = 0!
        Me.guna2PictureBox2.Location = New System.Drawing.Point(96, 38)
        Me.guna2PictureBox2.Name = "guna2PictureBox2"
        Me.guna2PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox2.TabIndex = 31
        Me.guna2PictureBox2.TabStop = False
        '
        'panel5
        '
        Me.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panel5.Location = New System.Drawing.Point(106, 89)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(215, 3)
        Me.panel5.TabIndex = 29
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(141, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(184, 25)
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
        Me.dgvMember.Location = New System.Drawing.Point(8, 156)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersVisible = False
        Me.dgvMember.RowHeadersWidth = 51
        Me.dgvMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMember.Size = New System.Drawing.Size(413, 321)
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
        Me.guna2Panel5.Controls.Add(Me.btnIssueBook)
        Me.guna2Panel5.Controls.Add(Me.guna2PictureBox5)
        Me.guna2Panel5.Controls.Add(Me.guna2HtmlLabel3)
        Me.guna2Panel5.Controls.Add(Me.label17)
        Me.guna2Panel5.Controls.Add(Me.dtpDueDate)
        Me.guna2Panel5.Controls.Add(Me.label16)
        Me.guna2Panel5.Controls.Add(Me.dtpIssueDate)
        Me.guna2Panel5.Controls.Add(Me.lblBookAuthor)
        Me.guna2Panel5.Controls.Add(Me.label15)
        Me.guna2Panel5.Controls.Add(Me.lblBookTitle)
        Me.guna2Panel5.Controls.Add(Me.label13)
        Me.guna2Panel5.Controls.Add(Me.lblBookID)
        Me.guna2Panel5.Controls.Add(Me.label11)
        Me.guna2Panel5.Controls.Add(Me.guna2PictureBox4)
        Me.guna2Panel5.Controls.Add(Me.guna2HtmlLabel2)
        Me.guna2Panel5.Controls.Add(Me.lblMemberName)
        Me.guna2Panel5.Controls.Add(Me.label8)
        Me.guna2Panel5.Controls.Add(Me.lblMemberID)
        Me.guna2Panel5.Controls.Add(Me.label7)
        Me.guna2Panel5.Controls.Add(Me.guna2PictureBox3)
        Me.guna2Panel5.Controls.Add(Me.guna2HtmlLabel1)
        Me.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel5.Location = New System.Drawing.Point(435, 3)
        Me.guna2Panel5.Name = "guna2Panel5"
        Me.guna2Panel5.Size = New System.Drawing.Size(210, 496)
        Me.guna2Panel5.TabIndex = 9
        '
        'btnIssueBook
        '
        Me.btnIssueBook.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIssueBook.AutoRoundedCorners = True
        Me.btnIssueBook.BorderRadius = 19
        Me.btnIssueBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIssueBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIssueBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIssueBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIssueBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnIssueBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnIssueBook.ForeColor = System.Drawing.Color.White
        Me.btnIssueBook.Location = New System.Drawing.Point(30, 454)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(150, 40)
        Me.btnIssueBook.TabIndex = 47
        Me.btnIssueBook.Text = "Issue Book"
        '
        'guna2PictureBox5
        '
        Me.guna2PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox5.Image = Global.Library_Management_System.My.Resources.Resources.book5
        Me.guna2PictureBox5.ImageRotate = 0!
        Me.guna2PictureBox5.Location = New System.Drawing.Point(23, 278)
        Me.guna2PictureBox5.Name = "guna2PictureBox5"
        Me.guna2PictureBox5.Size = New System.Drawing.Size(35, 35)
        Me.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox5.TabIndex = 46
        Me.guna2PictureBox5.TabStop = False
        '
        'guna2HtmlLabel3
        '
        Me.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.guna2HtmlLabel3.Location = New System.Drawing.Point(64, 290)
        Me.guna2HtmlLabel3.Name = "guna2HtmlLabel3"
        Me.guna2HtmlLabel3.Size = New System.Drawing.Size(84, 23)
        Me.guna2HtmlLabel3.TabIndex = 44
        Me.guna2HtmlLabel3.Text = "Issue Book"
        '
        'label17
        '
        Me.label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label17.Location = New System.Drawing.Point(21, 392)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(70, 17)
        Me.label17.TabIndex = 43
        Me.label17.Text = "Due Date:"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDueDate.AutoRoundedCorners = True
        Me.dtpDueDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpDueDate.BorderRadius = 17
        Me.dtpDueDate.BorderThickness = 1
        Me.dtpDueDate.Checked = True
        Me.dtpDueDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpDueDate.CustomFormat = ""
        Me.dtpDueDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDueDate.ForeColor = System.Drawing.Color.White
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDueDate.Location = New System.Drawing.Point(21, 412)
        Me.dtpDueDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDueDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(174, 36)
        Me.dtpDueDate.TabIndex = 42
        Me.dtpDueDate.Value = New Date(2024, 11, 27, 16, 25, 35, 105)
        '
        'label16
        '
        Me.label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label16.Location = New System.Drawing.Point(21, 333)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(76, 17)
        Me.label16.TabIndex = 41
        Me.label16.Text = "Issue Date:"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpIssueDate.AutoRoundedCorners = True
        Me.dtpIssueDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtpIssueDate.BorderRadius = 17
        Me.dtpIssueDate.BorderThickness = 1
        Me.dtpIssueDate.Checked = True
        Me.dtpIssueDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpIssueDate.CustomFormat = ""
        Me.dtpIssueDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dtpIssueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpIssueDate.ForeColor = System.Drawing.Color.White
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIssueDate.Location = New System.Drawing.Point(17, 353)
        Me.dtpIssueDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpIssueDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(174, 36)
        Me.dtpIssueDate.TabIndex = 40
        Me.dtpIssueDate.Value = New Date(2024, 11, 27, 16, 25, 35, 105)
        '
        'lblBookAuthor
        '
        Me.lblBookAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookAuthor.AutoSize = True
        Me.lblBookAuthor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookAuthor.Location = New System.Drawing.Point(117, 246)
        Me.lblBookAuthor.MaximumSize = New System.Drawing.Size(85, 0)
        Me.lblBookAuthor.Name = "lblBookAuthor"
        Me.lblBookAuthor.Size = New System.Drawing.Size(46, 17)
        Me.lblBookAuthor.TabIndex = 39
        Me.lblBookAuthor.Text = "author"
        '
        'label15
        '
        Me.label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label15.Location = New System.Drawing.Point(21, 246)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(91, 17)
        Me.label15.TabIndex = 38
        Me.label15.Text = "Book Author:"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookTitle.Location = New System.Drawing.Point(117, 208)
        Me.lblBookTitle.MaximumSize = New System.Drawing.Size(85, 0)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(29, 17)
        Me.lblBookTitle.TabIndex = 37
        Me.lblBookTitle.Text = "title"
        '
        'label13
        '
        Me.label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label13.Location = New System.Drawing.Point(21, 208)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(75, 17)
        Me.label13.TabIndex = 36
        Me.label13.Text = "Book Title:"
        '
        'lblBookID
        '
        Me.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblBookID.Location = New System.Drawing.Point(117, 175)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(19, 17)
        Me.lblBookID.TabIndex = 35
        Me.lblBookID.Text = "id"
        '
        'label11
        '
        Me.label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(21, 175)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(61, 17)
        Me.label11.TabIndex = 34
        Me.label11.Text = "Book ID:"
        '
        'guna2PictureBox4
        '
        Me.guna2PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox4.Image = Global.Library_Management_System.My.Resources.Resources.book3
        Me.guna2PictureBox4.ImageRotate = 0!
        Me.guna2PictureBox4.Location = New System.Drawing.Point(23, 120)
        Me.guna2PictureBox4.Name = "guna2PictureBox4"
        Me.guna2PictureBox4.Size = New System.Drawing.Size(35, 35)
        Me.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox4.TabIndex = 33
        Me.guna2PictureBox4.TabStop = False
        '
        'guna2HtmlLabel2
        '
        Me.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.guna2HtmlLabel2.Location = New System.Drawing.Point(64, 132)
        Me.guna2HtmlLabel2.Name = "guna2HtmlLabel2"
        Me.guna2HtmlLabel2.Size = New System.Drawing.Size(99, 23)
        Me.guna2HtmlLabel2.TabIndex = 31
        Me.guna2HtmlLabel2.Text = "Book Details"
        '
        'lblMemberName
        '
        Me.lblMemberName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMemberName.Location = New System.Drawing.Point(129, 93)
        Me.lblMemberName.MaximumSize = New System.Drawing.Size(85, 0)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(40, 17)
        Me.lblMemberName.TabIndex = 30
        Me.lblMemberName.Text = "name"
        '
        'label8
        '
        Me.label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(21, 93)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(103, 17)
        Me.label8.TabIndex = 29
        Me.label8.Text = "Member Name:"
        '
        'lblMemberID
        '
        Me.lblMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblMemberID.Location = New System.Drawing.Point(129, 59)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(19, 17)
        Me.lblMemberID.TabIndex = 28
        Me.lblMemberID.Text = "id"
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(21, 60)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(81, 17)
        Me.label7.TabIndex = 27
        Me.label7.Text = "Member ID:"
        '
        'guna2PictureBox3
        '
        Me.guna2PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2PictureBox3.Image = Global.Library_Management_System.My.Resources.Resources.user3
        Me.guna2PictureBox3.ImageRotate = 0!
        Me.guna2PictureBox3.Location = New System.Drawing.Point(23, 8)
        Me.guna2PictureBox3.Name = "guna2PictureBox3"
        Me.guna2PictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox3.TabIndex = 26
        Me.guna2PictureBox3.TabStop = False
        '
        'guna2HtmlLabel1
        '
        Me.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.guna2HtmlLabel1.Location = New System.Drawing.Point(64, 17)
        Me.guna2HtmlLabel1.Name = "guna2HtmlLabel1"
        Me.guna2HtmlLabel1.Size = New System.Drawing.Size(130, 23)
        Me.guna2HtmlLabel1.TabIndex = 24
        Me.guna2HtmlLabel1.Text = "Borrower Details"
        '
        'IssueBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 522)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "IssueBook"
        Me.Padding = New System.Windows.Forms.Padding(10)
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
    Private WithEvents guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents label17 As Label
    Private WithEvents dtpDueDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents label16 As Label
    Private WithEvents dtpIssueDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Private WithEvents lblBookAuthor As Label
    Private WithEvents label15 As Label
    Private WithEvents lblBookTitle As Label
    Private WithEvents label13 As Label
    Private WithEvents lblBookID As Label
    Private WithEvents label11 As Label
    Private WithEvents guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents lblMemberName As Label
    Private WithEvents label8 As Label
    Private WithEvents lblMemberID As Label
    Private WithEvents label7 As Label
    Private WithEvents guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
