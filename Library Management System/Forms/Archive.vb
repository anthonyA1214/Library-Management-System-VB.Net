Imports System.Data.SqlClient

Partial Public Class Archive
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub updateFont()
        ' Change cell font
        For Each c As DataGridViewColumn In dgvRecycleBin.Columns
            c.DefaultCellStyle.Font = New Font("Arial", 12.0F, GraphicsUnit.Pixel)
        Next
    End Sub

    Dim conn As SqlConnection = dbConnection.GetConnection()

    Private Sub loadBookTable()
        updateFont()
        Dim query As String = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 1"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvRecycleBin.DataSource = dt
        dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        loadImgCol()
    End Sub

    Private Sub loadMemberTable()
        updateFont()
        Dim query As String = "SELECT custom_member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 1"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvRecycleBin.DataSource = dt
        dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        loadImgCol()
    End Sub

    Private Sub loadStaffTable()
        updateFont()
        Dim query As String = "SELECT custom_staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 1 AND IsApproved = 1"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvRecycleBin.DataSource = dt
        dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        loadImgCol()
    End Sub

    Private Sub loadGenreTable()
        updateFont()
        Dim query As String = "SELECT custom_genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 1"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvRecycleBin.DataSource = dt
        dgvRecycleBin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        loadImgCol()
    End Sub

    Private Sub loadImgCol()
        Dim restoreImgCol As New DataGridViewImageColumn() With {
            .Name = "restore",
            .HeaderText = String.Empty,
            .Image = My.Resources.restorefromtrash,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }
        Dim deleteImgCol As New DataGridViewImageColumn() With {
            .Name = "delete",
            .HeaderText = String.Empty,
            .Image = My.Resources.deleteforever,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }

        If dgvRecycleBin.Columns("restore") Is Nothing Then
            dgvRecycleBin.Columns.Add(restoreImgCol)
        End If
        If dgvRecycleBin.Columns("delete") Is Nothing Then
            dgvRecycleBin.Columns.Add(deleteImgCol)
        End If

        dgvRecycleBin.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvRecycleBin.ColumnHeadersDefaultCellStyle.BackColor
        dgvRecycleBin.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvRecycleBin.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub loadTable()
        dgvRecycleBin.Columns.Clear()
        If cbSelectTable.Text = "Book" Then
            loadBookTable()
        ElseIf cbSelectTable.Text = "Member" Then
            loadMemberTable()
        ElseIf cbSelectTable.Text = "Staff" Then
            loadStaffTable()
        ElseIf cbSelectTable.Text = "Genre" Then
            loadGenreTable()
        End If
    End Sub

    Private Sub loadSearchBy()
        cbSearchBy.Items.Clear()
        If cbSelectTable.Text = "Book" Then
            cbSearchBy.Items.Add("Title")
            cbSearchBy.Items.Add("Author")
            cbSearchBy.Items.Add("ISBN")
            cbSearchBy.Items.Add("Publication Year")
            cbSearchBy.Items.Add("ID")
            cbSearchBy.Text = "Title"
        ElseIf cbSelectTable.Text = "Member" Then
            cbSearchBy.Items.Add("Name")
            cbSearchBy.Items.Add("ID")
            cbSearchBy.Text = "Name"
        ElseIf cbSelectTable.Text = "Staff" Then
            cbSearchBy.Items.Add("Name")
            cbSearchBy.Items.Add("Username")
            cbSearchBy.Items.Add("ID")
            cbSearchBy.Text = "Name"
        ElseIf cbSelectTable.Text = "Genre" Then
            cbSearchBy.Items.Add("Name")
            cbSearchBy.Items.Add("ID")
            cbSearchBy.Text = "Name"
        End If
    End Sub

    Private Sub RecycleBin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSelectTable.Text = "Book"
        loadTable()
        loadSearchBy()
    End Sub

    Private Sub cbSelectTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSelectTable.SelectedIndexChanged
        loadTable()
        loadSearchBy()
    End Sub

    Private Sub dgvRecycleBin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecycleBin.CellContentClick
        Dim query As String = ""
        Dim idCol As String = ""
        Dim tableName As String = cbSelectTable.SelectedItem.ToString()
        Dim checkrow As Integer
        Dim cmd As New SqlCommand()
        If e.ColumnIndex >= 0 AndAlso e.ColumnIndex = dgvRecycleBin.Columns("restore").Index Then
            Select Case tableName
                Case "Book"
                    query = "UPDATE tbl_book SET IsDeleted = 0 WHERE book_id = @id"
                    idCol = "Book ID"
                Case "Member"
                    query = "UPDATE tbl_member SET IsDeleted = 0 WHERE member_id = @id"
                    idCol = "Member ID"
                Case "Staff"
                    query = "UPDATE tbl_staff SET IsDeleted = 0 WHERE staff_id = @id"
                    idCol = "Staff ID"
                Case "Genre"
                    query = "UPDATE tbl_genre SET IsDeleted = 0 WHERE genre_id = @id"
                    idCol = "Genre ID"
            End Select
            Try
                Dim id As Integer = Integer.Parse(dgvRecycleBin.Rows(e.RowIndex).Cells(idCol).Value.ToString())
                Dim dialogResult As DialogResult = MessageBox.Show($"Are you sure you want to restore this {tableName} record?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dialogResult = DialogResult.No Then Return

                conn.Open()
                cmd.CommandText = query
                cmd.Connection = conn

                cmd.Parameters.AddWithValue("@id", id)

                checkrow = cmd.ExecuteNonQuery()

                If checkrow > 0 Then
                    MessageBox.Show($"{tableName} record restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"Failed to restore {tableName} record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                loadTable()
                conn.Close()
            End Try
        End If

        If e.ColumnIndex >= 0 AndAlso e.ColumnIndex = dgvRecycleBin.Columns("delete").Index Then
            Select Case tableName
                Case "Book"
                    query = "DELETE FROM tbl_book WHERE book_id = @id"
                    idCol = "Book ID"
                Case "Member"
                    query = "DELETE FROM tbl_member WHERE member_id = @id"
                    idCol = "Member ID"
                Case "Staff"
                    query = "DELETE FROM tbl_staff WHERE staff_id = @id"
                    idCol = "Staff ID"
                Case "Genre"
                    query = "DELETE FROM tbl_genre WHERE genre_id = @id"
                    idCol = "Genre ID"
            End Select

            Try
                Dim id As Integer = Integer.Parse(dgvRecycleBin.Rows(e.RowIndex).Cells(idCol).Value.ToString())
                Dim dialogResult As DialogResult = MessageBox.Show($"Are you sure you want to permanently delete this {tableName} record? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If dialogResult = DialogResult.No Then Return

                conn.Open()
                cmd.CommandText = query
                cmd.Connection = conn

                cmd.Parameters.AddWithValue("@id", id)

                checkrow = cmd.ExecuteNonQuery()

                If checkrow > 0 Then
                    MessageBox.Show($"{tableName} record deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show($"Failed to delete {tableName} record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                loadTable()
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub dgvRecycleBin_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvRecycleBin.CellToolTipTextNeeded
        If dgvRecycleBin.Columns(e.ColumnIndex).Name = "restore" Then
            e.ToolTipText = "Restore"
        End If
        If dgvRecycleBin.Columns(e.ColumnIndex).Name = "delete" Then
            e.ToolTipText = "Delete Permanently"
        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = ""
        Dim tableName As String = ""

        If cbSelectTable.SelectedItem IsNot Nothing Then
            tableName = cbSelectTable.SelectedItem.ToString()
        Else
            Return
        End If

        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(search) Then
            loadTable()
            Return
        End If

        Select Case tableName
            Case "Book"
                query = "SELECT custom_book_id as [Book ID], title as [Title], author as [Author], isbn as [ISBN], genre as [Genre], publication_year as [Publication Year], quantity as [Quantity] from tbl_book WHERE IsDeleted = 1"
                Dim pattern As String = "^b-\d{6}$"  ' ^b- means starting with 'b-', \d{6} means exactly six digits, $ means end of the string
                If cbSearchBy.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern) Then Return
                If cbSearchBy.Text = "Title" Then
                    query += " AND title LIKE @search"
                ElseIf cbSearchBy.Text = "Author" Then
                    query += " AND author LIKE @search"
                ElseIf cbSearchBy.Text = "ISBN" Then
                    query += " AND isbn LIKE @search"
                ElseIf cbSearchBy.Text = "Publication Year" Then
                    query += " AND publication_year LIKE @search"
                ElseIf cbSearchBy.Text = "ID" Then
                    query += " AND custom_book_id LIKE @search"
                End If
            Case "Member"
                query = "SELECT custom_member_id AS [Member ID], CONCAT(first_name, ' ', last_name) AS [Member Name], age AS [Age], address AS [Address], contact_number AS [Contact Number], email AS [Email], membership_type AS [Membership Type] from tbl_member WHERE IsDeleted = 1"
                Dim pattern As String = "^m-\d{6}$"  ' ^b- means starting with 'b-', \d{6} means exactly six digits, $ means end of the string
                If cbSearchBy.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern) Then Return
                If cbSearchBy.Text = "Name" Then
                    query += " AND CONCAT(first_name, ' ', last_name) LIKE @search"
                ElseIf cbSearchBy.Text = "ID" Then
                    query += " AND custom_member_id LIKE @search"
                End If
            Case "Staff"
                query = "SELECT custom_staff_id AS [Staff ID], CONCAT(first_name, ' ', last_name) AS [Staff Name], username AS [Username], password AS [Password], email AS [Email], contact_number AS [Contact Number], role AS [Role] from tbl_staff WHERE IsDeleted = 1 AND IsApproved = 1"
                Dim pattern As String = "^s-\d{6}$"  ' ^b- means starting with 'b-', \d{6} means exactly six digits, $ means end of the string
                If cbSearchBy.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern) Then Return
                If cbSearchBy.Text = "Name" Then
                    query += " AND CONCAT(first_name, ' ', last_name) LIKE @search"
                ElseIf cbSearchBy.Text = "Username" Then
                    query += " AND username LIKE @search"
                ElseIf cbSearchBy.Text = "ID" Then
                    query += " AND custom_staff_id LIKE @search"
                End If
            Case "Genre"
                query = "SELECT custom_genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 1"
                Dim pattern As String = "^g-\d{6}$"  ' ^b- means starting with 'b-', \d{6} means exactly six digits, $ means end of the string
                If cbSearchBy.Text = "ID" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(search, pattern) Then Return
                If cbSearchBy.Text = "Name" Then
                    query += " AND genre_name LIKE @search"
                ElseIf cbSearchBy.Text = "ID" Then
                    query += " AND custom_genre_id LIKE @search"
                End If
        End Select

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" + search + "%")

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvRecycleBin.DataSource = dt
    End Sub


    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class