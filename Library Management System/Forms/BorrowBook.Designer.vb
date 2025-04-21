<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BorrowBook
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
        Me.guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cbAvailabilityStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbGenre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlTopMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlGrid = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvBook = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.guna2Panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopMenu.SuspendLayout()
        Me.guna2CustomGradientPanel2.SuspendLayout()
        Me.guna2Panel5.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guna2Panel2
        '
        Me.guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Panel2.BorderRadius = 20
        Me.guna2Panel2.Controls.Add(Me.pictureBox1)
        Me.guna2Panel2.Controls.Add(Me.label3)
        Me.guna2Panel2.Controls.Add(Me.cbAvailabilityStatus)
        Me.guna2Panel2.Controls.Add(Me.label2)
        Me.guna2Panel2.Controls.Add(Me.cbGenre)
        Me.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2Panel2.Location = New System.Drawing.Point(13, 74)
        Me.guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel2.Name = "guna2Panel2"
        Me.guna2Panel2.Size = New System.Drawing.Size(865, 107)
        Me.guna2Panel2.TabIndex = 17
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Image = Global.Library_Management_System.My.Resources.Resources.Legends
        Me.pictureBox1.Location = New System.Drawing.Point(509, 7)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(167, 92)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(311, 26)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(149, 23)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Availability Status:"
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
        Me.cbAvailabilityStatus.Location = New System.Drawing.Point(315, 50)
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
        Me.label2.Location = New System.Drawing.Point(116, 23)
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
        Me.cbGenre.Location = New System.Drawing.Point(120, 48)
        Me.cbGenre.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGenre.Name = "cbGenre"
        Me.cbGenre.Size = New System.Drawing.Size(185, 36)
        Me.cbGenre.TabIndex = 1
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
        Me.pnlTopMenu.TabIndex = 16
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
        Me.btnClear.Location = New System.Drawing.Point(674, 5)
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
        Me.cbSearchBy.Location = New System.Drawing.Point(178, 9)
        Me.cbSearchBy.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(185, 36)
        Me.cbSearchBy.TabIndex = 0
        '
        'guna2CustomGradientPanel2
        '
        Me.guna2CustomGradientPanel2.Controls.Add(Me.Guna2Button1)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.label10)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.lblGenre)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.lblAuthor)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.lblBookTitle)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.label6)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.Label4)
        Me.guna2CustomGradientPanel2.Controls.Add(Me.Label5)
        Me.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.guna2CustomGradientPanel2.Location = New System.Drawing.Point(13, 454)
        Me.guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2"
        Me.guna2CustomGradientPanel2.Size = New System.Drawing.Size(865, 176)
        Me.guna2CustomGradientPanel2.TabIndex = 59
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 23
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(674, 60)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(152, 49)
        Me.Guna2Button1.TabIndex = 13
        Me.Guna2Button1.Text = "Borrow"
        '
        'label10
        '
        Me.label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(175, 76)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(72, 23)
        Me.label10.TabIndex = 55
        Me.label10.Text = "Author:"
        '
        'lblGenre
        '
        Me.lblGenre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGenre.AutoSize = True
        Me.lblGenre.BackColor = System.Drawing.Color.Transparent
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblGenre.Location = New System.Drawing.Point(244, 113)
        Me.lblGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(56, 23)
        Me.lblGenre.TabIndex = 53
        Me.lblGenre.Text = "Genre"
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblAuthor.Location = New System.Drawing.Point(243, 76)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(63, 23)
        Me.lblAuthor.TabIndex = 52
        Me.lblAuthor.Text = "Author"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBookTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(243, 34)
        Me.lblBookTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(86, 23)
        Me.lblBookTitle.TabIndex = 51
        Me.lblBookTitle.Text = "Book Title"
        '
        'label6
        '
        Me.label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(185, 113)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(62, 23)
        Me.label6.TabIndex = 50
        Me.label6.Text = "Genre:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Book Title:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 28)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Book Info:"
        '
        'guna2Panel5
        '
        Me.guna2Panel5.Controls.Add(Me.pnlGrid)
        Me.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel5.Location = New System.Drawing.Point(13, 181)
        Me.guna2Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel5.Name = "guna2Panel5"
        Me.guna2Panel5.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.guna2Panel5.Size = New System.Drawing.Size(865, 273)
        Me.guna2Panel5.TabIndex = 60
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
        Me.pnlGrid.Size = New System.Drawing.Size(839, 249)
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
        Me.dgvBook.Size = New System.Drawing.Size(813, 225)
        Me.dgvBook.TabIndex = 1
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
        'BorrowBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 642)
        Me.Controls.Add(Me.guna2Panel5)
        Me.Controls.Add(Me.guna2CustomGradientPanel2)
        Me.Controls.Add(Me.guna2Panel2)
        Me.Controls.Add(Me.pnlTopMenu)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BorrowBook"
        Me.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Text = "BorrowBook"
        Me.guna2Panel2.ResumeLayout(False)
        Me.guna2Panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopMenu.ResumeLayout(False)
        Me.pnlTopMenu.PerformLayout()
        Me.guna2CustomGradientPanel2.ResumeLayout(False)
        Me.guna2CustomGradientPanel2.PerformLayout()
        Me.guna2Panel5.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label3 As Label
    Private WithEvents cbAvailabilityStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents label2 As Label
    Private WithEvents cbGenre As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pnlTopMenu As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label1 As Label
    Private WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents cbSearchBy As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents label10 As Label
    Private WithEvents lblGenre As Label
    Private WithEvents lblAuthor As Label
    Private WithEvents lblBookTitle As Label
    Private WithEvents label6 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents pnlGrid As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents dgvBook As Guna.UI2.WinForms.Guna2DataGridView
End Class
