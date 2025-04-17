Imports System.Data.SqlClient

Public Class BorrowerForm
    Dim conn As SqlConnection = dbConnection.GetConnection()
    Private Username As String
    Private Id As Integer
    Public Sub New(username As String, id As Integer)
        InitializeComponent()
        Me.Username = username
        Me.Id = id
    End Sub

    Private Sub updateFont()
        For Each c As DataGridViewColumn In dgvIssue1.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 11.0F, GraphicsUnit.Pixel)
        Next

        For Each c As DataGridViewColumn In dgvIssue2.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 11.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Private Sub BorrowerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        lblName.Text = Username & "!"
        ViewMemberRecords()
        updateFont()
        loadCount()
    End Sub

    Private Sub autoLoadDashboard_Tick(sender As Object, e As EventArgs) Handles autoLoadDashboard.Tick
        lblDateAndTime.Text = DateTime.Now.ToLongDateString() & " | " & DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialogResult = DialogResult.No Then Return
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub loadCount()
        Dim currentBorrowedQuery As String = "
    SELECT COUNT(*) AS [CurrentlyBorrowed]
    FROM tbl_issue
    WHERE member_id = @memberid AND return_date IS NULL;"

        Dim totalBorrowedQuery As String = "
    SELECT COUNT(*) AS [TotalBorrowed]
    FROM tbl_issue
    WHERE member_id = @memberid;"

        Dim cmd1 As New SqlCommand(currentBorrowedQuery, conn)
        Dim cmd2 As New SqlCommand(totalBorrowedQuery, conn)

        cmd1.Parameters.AddWithValue("@memberid", Id)
        cmd2.Parameters.AddWithValue("@memberid", Id)

        Dim da1 As New SqlDataAdapter(cmd1)
        Dim da2 As New SqlDataAdapter(cmd2)

        Dim ds As New DataSet()

        da1.Fill(ds, "currentBorrowed")
        da2.Fill(ds, "totalBorrowed")

        If ds.Tables("currentBorrowed").Rows.Count > 0 Then
            lblCurrentlyBorrowed.Text = ds.Tables("currentBorrowed").Rows(0)(0).ToString()
        Else
            lblCurrentlyBorrowed.Text = "0"
        End If

        If ds.Tables("totalBorrowed").Rows.Count > 0 Then
            lblTotalBorrowed.Text = ds.Tables("totalBorrowed").Rows(0)(0).ToString()
        Else
            lblTotalBorrowed.Text = "0"
        End If
    End Sub


    Private activeForm As Form = Nothing
    Private Sub hideDashboard()
        pnlTitle.Visible = False
        tlp1.Visible = False
        tlp2.Visible = False
    End Sub

    Private Sub showDashboard(sender As Object, e As FormClosedEventArgs)
        loadCount()
        ViewMemberRecords()
        pnlTitle.Visible = True
        tlp1.Visible = True
        tlp2.Visible = True
    End Sub

    Private Sub hideSubMenu()
        pnlSettingsSubMenu.Visible = False
    End Sub

    Private Sub showSubMenu(SubMenu As Panel)
        If SubMenu.Visible = False Then
            hideSubMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub

    Private Sub openForm(newForm As Form)
        hideDashboard()
        If activeForm IsNot Nothing Then
            RemoveHandler activeForm.FormClosed, AddressOf showDashboard
            activeForm.Close()
        End If

        activeForm = newForm
        newForm.TopLevel = False
        newForm.Dock = DockStyle.Fill
        newForm.FormBorderStyle = FormBorderStyle.None
        pnlContainer.Controls.Add(newForm)
        newForm.BringToFront()
        newForm.Show()
        AddHandler newForm.FormClosed, AddressOf showDashboard
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If
        hideSubMenu()
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        openForm(New Password(Id))
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        showSubMenu(pnlSettingsSubMenu)
    End Sub

    Private Sub ViewMemberRecords()
        Dim query1 As String = "SELECT tbl_issue.custom_issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Status], 'Not Returned' AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.member_id = @memberid AND tbl_issue.return_date IS NULL;"
        Dim query2 As String = "SELECT tbl_issue.custom_issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.return_date AS [Return Date], tbl_issue.status AS [Status], CASE WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date > tbl_issue.due_date THEN 'Overdue' ELSE 'On Time' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.member_id = @memberid;"

        Dim cmd1 As New SqlCommand(query1, conn)
        Dim cmd2 As New SqlCommand(query2, conn)

        cmd1.Parameters.AddWithValue("@memberid", Id)
        cmd2.Parameters.AddWithValue("@memberid", Id)

        Dim da1 As New SqlDataAdapter(cmd1)
        Dim da2 As New SqlDataAdapter(cmd2)

        Dim dt1 As New DataTable()
        Dim dt2 As New DataTable()

        da1.Fill(dt1)
        da2.Fill(dt2)

        dgvIssue1.DataSource = dt1
        dgvIssue2.DataSource = dt2

        dgvIssue1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvIssue2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvIssue1.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue1.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue1.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue1.ColumnHeadersDefaultCellStyle.ForeColor
        dgvIssue2.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssue2.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssue2.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssue2.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class