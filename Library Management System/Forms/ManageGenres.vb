Imports System.Data.SqlClient

Partial Public Class ManageGenres
    Inherits Form

    Private userRole As String

    Public Sub New(userrole As String)
        InitializeComponent()
        userrole = userrole
    End Sub

    Private Sub HandleLogin(userRole As String)
        If userRole = "Staff" Then
            dgvGenre.Columns("delete").Visible = False
        ElseIf userRole = "Admin" Then
            dgvGenre.Columns("delete").Visible = True
        End If
    End Sub

    Dim conn As SqlConnection = dbConnection.GetConnection()
    Dim checkrow As Integer

    Private Sub loadTable()
        Dim query As String = "SELECT genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 0"
        Dim cmd As New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvGenre.DataSource = dt
        dgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim deleteImgCol As New DataGridViewImageColumn() With {
            .Name = "delete",
            .HeaderText = String.Empty,
            .Image = My.Resources.delete,
            .ImageLayout = DataGridViewImageCellLayout.Zoom,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        }
        If dgvGenre.Columns("delete") Is Nothing Then
            dgvGenre.Columns.Add(deleteImgCol)
        End If
        HandleLogin(userRole)

        dgvGenre.Columns("delete").DisplayIndex = dgvGenre.Columns.Count - 1
    End Sub

    Private Sub clearTexts()
        tbGenreName.Clear()
    End Sub

    Private Sub btnAddGenre_Click(sender As Object, e As EventArgs) Handles btnAddGenre.Click
        If Not pnlAddGenre.Visible Then
            pnlAddGenre.Visible = True
        Else
            pnlAddGenre.Visible = False
        End If
    End Sub

    Private Sub btnSaveGenre_Click(sender As Object, e As EventArgs) Handles btnSaveGenre.Click
        Dim genre As String = tbGenreName.Text.Trim()
        If String.IsNullOrEmpty(tbGenreName.Text) Then
            MessageBox.Show("Please enter a genre name.")
            Return
        End If
        Dim query As String = "INSERT into tbl_genre(genre_name) values(@genre)"
        Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to add this genre?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialogResult = DialogResult.Yes Then
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@genre", genre)
                checkrow = cmd.ExecuteNonQuery()
                If checkrow > 0 Then
                    MessageBox.Show("Genre added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadTable()
                    clearTexts()
                Else
                    MessageBox.Show("Failed to add the genre.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As SqlException
                If ex.Number = 2627 Then
                    MessageBox.Show("This genre name already exists.", "Duplicate Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub ManageGenres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        pnlAddGenre.Visible = False
        dgvGenre.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvGenre.ColumnHeadersDefaultCellStyle.BackColor
        dgvGenre.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvGenre.ColumnHeadersDefaultCellStyle.ForeColor
    End Sub

    Private Sub dgvGenre_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGenre.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvGenre.Columns("delete").Index Then
            Dim query As String = "UPDATE tbl_genre SET IsDeleted = 1 WHERE genre_name = @genre"
            Dim genre As String = dgvGenre.Rows(e.RowIndex).Cells("Genre Name").Value.ToString()
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@genre", genre)
                Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete this genre?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dialogResult = DialogResult.No Then Return
                checkrow = cmd.ExecuteNonQuery()
                If checkrow > 0 Then
                    MessageBox.Show("Genre deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete the genre.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred. {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                loadTable()
            End Try
        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        Dim query As String = "SELECT genre_id AS [Genre ID], genre_name AS [Genre Name] from tbl_genre WHERE IsDeleted = 0 AND genre_name LIKE @search"
        Dim search As String = tbSearch.Text

        If String.IsNullOrEmpty(tbSearch.Text) Then
            loadTable()
            Return
        End If

        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvGenre.DataSource = dt
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub

    Private Sub pbExit2_Click(sender As Object, e As EventArgs) Handles pbExit2.Click
        pnlAddGenre.Visible = False
    End Sub

    Private Sub dgvGenre_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles dgvGenre.CellToolTipTextNeeded
        If dgvGenre.Columns(e.ColumnIndex).Name = "delete" Then
            e.ToolTipText = "Delete"
        End If
    End Sub
End Class