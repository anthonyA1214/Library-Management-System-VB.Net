Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AdminForm
    Inherits Form

    Dim conn As SqlConnection = dbConnection.GetConnection()
    Private Username As String

    Public Sub New(username As String)
        InitializeComponent()
        Me.Username = username
    End Sub

    Private Sub hideDashboard()
        pnlTitle.Visible = False
        tlp1.Visible = False
        tlp2.Visible = False
        tlp3.Visible = False
        tlp4.Visible = False
    End Sub

    Private Sub showDashboard(sender As Object, e As FormClosedEventArgs)
        loadTable()
        pnlTitle.Visible = True
        tlp1.Visible = True
        tlp2.Visible = True
        tlp3.Visible = True
        tlp4.Visible = True
    End Sub

    Private Sub hideSubMenu()
        pnlBooksSubMenu.Visible = False
        pnlMembersSubMenu.Visible = False
        pnlBorrowReturnSubMenu.Visible = False
        pnlReportsSubMenu.Visible = False
        pnlUserManagementSubMenu.Visible = False
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

    Private Sub loadCount()
        Dim query1 As String = "SELECT COUNT(*) FROM tbl_book"
        Dim query2 As String = "SELECT COUNT(*) FROM tbl_member"
        Dim query3 As String = "SELECT COUNT(*) FROM tbl_issue WHERE status = 'Issued'"
        Dim query4 As String = "SELECT COUNT(*) FROM tbl_issue WHERE return_date IS NULL AND due_date < GETDATE()"

        Dim cmd1 As New SqlCommand(query1, conn)
        Dim cmd2 As New SqlCommand(query2, conn)
        Dim cmd3 As New SqlCommand(query3, conn)
        Dim cmd4 As New SqlCommand(query4, conn)

        Dim da1 As New SqlDataAdapter(cmd1)
        Dim da2 As New SqlDataAdapter(cmd2)
        Dim da3 As New SqlDataAdapter(cmd3)
        Dim da4 As New SqlDataAdapter(cmd4)

        Dim ds As New DataSet()

        da1.Fill(ds, "BookCount")
        da2.Fill(ds, "MemberCount")
        da3.Fill(ds, "IssuedCount")
        da4.Fill(ds, "OverdueCount")

        lblCountBook.Text = ds.Tables("BookCount").Rows(0)(0).ToString()
        lblCountMember.Text = ds.Tables("MemberCount").Rows(0)(0).ToString()
        lblIssuedBook.Text = ds.Tables("IssuedCount").Rows(0)(0).ToString()
        lblOverdueBook.Text = ds.Tables("OverdueCount").Rows(0)(0).ToString()
    End Sub

    Private Sub loadTable()
        Dim issueQuery As String = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Loan Status], CASE WHEN tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE() THEN 'Overdue' WHEN tbl_issue.return_date IS NULL THEN 'Not Returned' WHEN tbl_issue.return_date <= tbl_issue.due_date THEN 'On Time' ELSE 'Late Return' END AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.status = 'Issued'"
        dgvIssuedBook.DataSource = loadData(issueQuery)
        dgvIssuedBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim overdueQuery As String = "SELECT tbl_issue.issue_id AS [Issue ID], tbl_book.title AS [Book Title], CONCAT(tbl_member.first_name, ' ', tbl_member.last_name) AS [Member Name], tbl_issue.issue_date AS [Issue Date], tbl_issue.due_date AS [Due Date], tbl_issue.status AS [Loan Status], 'Overdue' AS [Return Status] FROM tbl_issue INNER JOIN tbl_book ON tbl_issue.book_id = tbl_book.book_id INNER JOIN tbl_member ON tbl_issue.member_id = tbl_member.member_id WHERE tbl_issue.return_date IS NULL AND tbl_issue.due_date < GETDATE()"
        dgvOverdueBook.DataSource = loadData(overdueQuery)
        dgvOverdueBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim memberQuery As String = "SELECT TOP 5 member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 0"
        dgvMember.DataSource = loadData(memberQuery)
        dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim bookQuery As String = "SELECT TOP 5 book_id as [Book ID], title as [Title], author as [Author], genre as [Genre], publication_year as [Publication Year] from tbl_book WHERE IsDeleted = 0"
        dgvBook.DataSource = loadData(bookQuery)
        dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Function loadData(query As String) As DataTable
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        showSubMenu(pnlBooksSubMenu)
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        showSubMenu(pnlMembersSubMenu)
    End Sub

    Private Sub btnBorrowReturn_Click(sender As Object, e As EventArgs) Handles btnBorrowReturn.Click
        showSubMenu(pnlBorrowReturnSubMenu)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        showSubMenu(pnlReportsSubMenu)
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnStaffManagement.Click
        showSubMenu(pnlUserManagementSubMenu)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        showSubMenu(pnlSettingsSubMenu)
    End Sub

    Private activeForm As Form = Nothing

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

    Private Sub btnManageBooks_Click(sender As Object, e As EventArgs) Handles btnManageBooks.Click
        openForm(New ManageBooks())
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        openForm(New Inventory("Admin"))
    End Sub

    Private Sub btnManageMembers_Click(sender As Object, e As EventArgs) Handles btnManageMembers.Click
        openForm(New ManageMembers("Admin"))
    End Sub

    Private Sub btnMemberProfiles_Click(sender As Object, e As EventArgs) Handles btnMemberProfiles.Click
        openForm(New MemberProfiles())
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs)
        openForm(New IssueBook())
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs)
        openForm(New ReturnBook())
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        openForm(New ViewRecords())
    End Sub

    Private Sub btnCirculationReports_Click(sender As Object, e As EventArgs) Handles btnCirculationReports.Click
        openForm(New CirculationReport())
    End Sub

    Private Sub btnMemberActivityReports_Click(sender As Object, e As EventArgs) Handles btnMemberActivityReports.Click
        openForm(New MemberActivityReport())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialogResult = DialogResult.No Then Return
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        lblName.Text = Username & "!"
        loadTable()
        loadCount()
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMember.ColumnHeadersDefaultCellStyle.BackColor
        dgvMember.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvMember.ColumnHeadersDefaultCellStyle.ForeColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBook.ColumnHeadersDefaultCellStyle.ForeColor
        dgvOverdueBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvOverdueBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvOverdueBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvOverdueBook.ColumnHeadersDefaultCellStyle.ForeColor
        dgvIssuedBook.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvIssuedBook.ColumnHeadersDefaultCellStyle.BackColor
        dgvIssuedBook.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvIssuedBook.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub autoLoadCount_Tick(sender As Object, e As EventArgs) Handles autoLoadCount.Tick
        loadCount()
        lblDateAndTime.Text = DateTime.Now.ToLongDateString() & " | " & DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub btnAddNewMember_Click(sender As Object, e As EventArgs)
        openForm(New ManageMembers("Admin"))
    End Sub

    Private Sub btnAddNewBook_Click(sender As Object, e As EventArgs)
        openForm(New ManageBooks())
    End Sub

    Private Sub lblMemberSeeAll_Click(sender As Object, e As EventArgs) Handles lblMemberSeeAll.Click
        openForm(New MemberProfiles())
    End Sub

    Private Sub lblBookSeeAll_Click(sender As Object, e As EventArgs) Handles lblBookSeeAll.Click
        openForm(New Inventory("Admin"))
    End Sub

    Private Sub btnIssueBook2_Click(sender As Object, e As EventArgs)
        openForm(New IssueBook())
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageStaffs.Click
        openForm(New ManageStaffs())
    End Sub

    Private Sub btnUserApproval_Click(sender As Object, e As EventArgs) Handles btnStaffApproval.Click
        openForm(New StaffApproval())
    End Sub

    Private Sub btnManageGenre_Click(sender As Object, e As EventArgs) 
        openForm(New ManageGenres("Admin"))
    End Sub

    Private Sub btnRecycleBin_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        openForm(New Archive())
    End Sub

    Private Sub autoLoadDashboard_Tick(sender As Object, e As EventArgs) Handles autoLoadDashboard.Tick
        loadCount()
        loadBorrowerStatistics()
        lblDateAndTime.Text = DateTime.Now.ToLongDateString() & " | " & DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub loadBorrowerStatistics()
        Dim query As String = "SELECT tbl_member.membership_type, COUNT(tbl_issue.issue_id) AS total_borrowed FROM tbl_member JOIN tbl_issue ON tbl_member.member_id = tbl_issue.member_id GROUP BY tbl_member.membership_type"

        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        borrowerstatistics.Series.Clear()
        borrowerstatistics.Titles.Clear()
        borrowerstatistics.Titles.Add("Books Borrowed by Membership Type")

        Dim series As New System.Windows.Forms.DataVisualization.Charting.Series("Total Borrowed") With {
            .ChartType = SeriesChartType.Column
        }

        While dr.Read()
            Dim membershipType As String = dr("membership_type").ToString()
            Dim totalBorrowed As Integer = Convert.ToInt32(dr("total_borrowed"))

            series.Points.AddXY(membershipType, totalBorrowed)
        End While

        dr.Close()
        conn.Close()

        borrowerstatistics.Series.Add(series)
    End Sub
End Class