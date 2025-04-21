<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CirculationReport
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAddGenre = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.cbReturnStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbLoanStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnExport = New Guna.UI2.WinForms.Guna2Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbSearchBy = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.pnlAddGenre.Controls.Add(Me.btnClear)
        Me.pnlAddGenre.Controls.Add(Me.cbReturnStatus)
        Me.pnlAddGenre.Controls.Add(Me.Label4)
        Me.pnlAddGenre.Controls.Add(Me.Label3)
        Me.pnlAddGenre.Controls.Add(Me.cbLoanStatus)
        Me.pnlAddGenre.Controls.Add(Me.btnExport)
        Me.pnlAddGenre.Controls.Add(Me.label7)
        Me.pnlAddGenre.Controls.Add(Me.cbSearchBy)
        Me.pnlAddGenre.Controls.Add(Me.tbSearch)
        Me.pnlAddGenre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAddGenre.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlAddGenre.Location = New System.Drawing.Point(13, 12)
        Me.pnlAddGenre.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAddGenre.Name = "pnlAddGenre"
        Me.pnlAddGenre.Size = New System.Drawing.Size(865, 169)
        Me.pnlAddGenre.TabIndex = 56
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
        Me.btnClear.Location = New System.Drawing.Point(682, 60)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 49)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        '
        'cbReturnStatus
        '
        Me.cbReturnStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbReturnStatus.AutoRoundedCorners = True
        Me.cbReturnStatus.BackColor = System.Drawing.Color.Transparent
        Me.cbReturnStatus.BorderRadius = 17
        Me.cbReturnStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbReturnStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReturnStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbReturnStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbReturnStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbReturnStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbReturnStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbReturnStatus.ItemHeight = 30
        Me.cbReturnStatus.Items.AddRange(New Object() {"All", "On Time", "Late Return", "Overdue"})
        Me.cbReturnStatus.Location = New System.Drawing.Point(451, 112)
        Me.cbReturnStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbReturnStatus.Name = "cbReturnStatus"
        Me.cbReturnStatus.Size = New System.Drawing.Size(172, 36)
        Me.cbReturnStatus.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(458, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Return Status:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Loan Status:"
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
        Me.cbLoanStatus.Location = New System.Drawing.Point(258, 112)
        Me.cbLoanStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoanStatus.Name = "cbLoanStatus"
        Me.cbLoanStatus.Size = New System.Drawing.Size(172, 36)
        Me.cbLoanStatus.TabIndex = 7
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExport.AutoRoundedCorners = True
        Me.btnExport.BorderRadius = 23
        Me.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExport.FillColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(31, 60)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(203, 49)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export Report"
        '
        'label7
        '
        Me.label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(260, 7)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(89, 23)
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
        Me.cbSearchBy.Location = New System.Drawing.Point(252, 34)
        Me.cbSearchBy.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(176, 36)
        Me.cbSearchBy.TabIndex = 4
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
        Me.tbSearch.Location = New System.Drawing.Point(450, 31)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PlaceholderText = "Search records"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(203, 44)
        Me.tbSearch.TabIndex = 1
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
        Me.guna2CustomGradientPanel2.Location = New System.Drawing.Point(13, 454)
        Me.guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2"
        Me.guna2CustomGradientPanel2.Size = New System.Drawing.Size(865, 176)
        Me.guna2CustomGradientPanel2.TabIndex = 57
        '
        'label10
        '
        Me.label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(215, 76)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(182, 23)
        Me.label10.TabIndex = 55
        Me.label10.Text = "Total Items Returned:"
        '
        'lblOverdueItems
        '
        Me.lblOverdueItems.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblOverdueItems.AutoSize = True
        Me.lblOverdueItems.BackColor = System.Drawing.Color.Transparent
        Me.lblOverdueItems.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdueItems.Location = New System.Drawing.Point(395, 111)
        Me.lblOverdueItems.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOverdueItems.Name = "lblOverdueItems"
        Me.lblOverdueItems.Size = New System.Drawing.Size(52, 25)
        Me.lblOverdueItems.TabIndex = 53
        Me.lblOverdueItems.Text = "_____"
        '
        'lblTotalItemsReturned
        '
        Me.lblTotalItemsReturned.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalItemsReturned.AutoSize = True
        Me.lblTotalItemsReturned.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalItemsReturned.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemsReturned.Location = New System.Drawing.Point(394, 75)
        Me.lblTotalItemsReturned.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalItemsReturned.Name = "lblTotalItemsReturned"
        Me.lblTotalItemsReturned.Size = New System.Drawing.Size(52, 25)
        Me.lblTotalItemsReturned.TabIndex = 52
        Me.lblTotalItemsReturned.Text = "_____"
        '
        'lblTotalItemsBorrowed
        '
        Me.lblTotalItemsBorrowed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalItemsBorrowed.AutoSize = True
        Me.lblTotalItemsBorrowed.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalItemsBorrowed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemsBorrowed.Location = New System.Drawing.Point(394, 34)
        Me.lblTotalItemsBorrowed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalItemsBorrowed.Name = "lblTotalItemsBorrowed"
        Me.lblTotalItemsBorrowed.Size = New System.Drawing.Size(52, 25)
        Me.lblTotalItemsBorrowed.TabIndex = 51
        Me.lblTotalItemsBorrowed.Text = "_____"
        '
        'label6
        '
        Me.label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(267, 113)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(132, 23)
        Me.label6.TabIndex = 50
        Me.label6.Text = "Overdue Items:"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(211, 36)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(187, 23)
        Me.label2.TabIndex = 48
        Me.label2.Text = "Total Items Borrowed:"
        '
        'label1
        '
        Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(11, 6)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(173, 28)
        Me.label1.TabIndex = 48
        Me.label1.Text = "Report Overview:"
        '
        'guna2Panel3
        '
        Me.guna2Panel3.Controls.Add(Me.pnlGrid)
        Me.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.guna2Panel3.Location = New System.Drawing.Point(13, 181)
        Me.guna2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.guna2Panel3.Name = "guna2Panel3"
        Me.guna2Panel3.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.guna2Panel3.Size = New System.Drawing.Size(865, 273)
        Me.guna2Panel3.TabIndex = 60
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.Transparent
        Me.pnlGrid.BorderRadius = 20
        Me.pnlGrid.Controls.Add(Me.dgvIssue)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlGrid.Location = New System.Drawing.Point(13, 12)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.pnlGrid.Size = New System.Drawing.Size(839, 249)
        Me.pnlGrid.TabIndex = 0
        '
        'dgvIssue
        '
        Me.dgvIssue.AllowUserToAddRows = False
        Me.dgvIssue.AllowUserToDeleteRows = False
        Me.dgvIssue.AllowUserToResizeColumns = False
        Me.dgvIssue.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvIssue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvIssue.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIssue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvIssue.ColumnHeadersHeight = 50
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(134, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIssue.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvIssue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIssue.GridColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dgvIssue.Location = New System.Drawing.Point(13, 12)
        Me.dgvIssue.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIssue.Name = "dgvIssue"
        Me.dgvIssue.ReadOnly = True
        Me.dgvIssue.RowHeadersVisible = False
        Me.dgvIssue.RowHeadersWidth = 51
        Me.dgvIssue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvIssue.Size = New System.Drawing.Size(813, 225)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 642)
        Me.Controls.Add(Me.guna2Panel3)
        Me.Controls.Add(Me.guna2CustomGradientPanel2)
        Me.Controls.Add(Me.pnlAddGenre)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CirculationReport"
        Me.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.Text = "CirculationReport"
        Me.pnlAddGenre.ResumeLayout(False)
        Me.pnlAddGenre.PerformLayout()
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
    Private WithEvents Label3 As Label
    Private WithEvents cbLoanStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents Label4 As Label
    Private WithEvents cbReturnStatus As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
End Class
