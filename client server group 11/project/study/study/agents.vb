Imports System.Data.SqlClient

Public Class agents
    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"
    Dim ad As String = "admin"


    Private Sub RefreshDataGridView()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT id,full_names,username FROM users where username!=@ad"
            Using adapter As New SqlDataAdapter(query, connection)

                adapter.SelectCommand.Parameters.AddWithValue("@ad", ad)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView5.DataSource = dataTable
    End Sub
    Private Sub insertDataButton_Click(sender As Object, e As EventArgs) Handles insertDataButton.Click

        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim fn As String = TextBox3.Text
        Dim dir As String = TextBox1.Text
        Dim am As String = TextBox2.Text




        Using connection As New SqlConnection(connectionString)
            connection.Open()
            If String.IsNullOrWhiteSpace(dir) OrElse String.IsNullOrWhiteSpace(am) OrElse String.IsNullOrWhiteSpace(fn) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE username = @pk"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@pk", dir)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("agent user  already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO users VALUES (@fn,@dir, @am)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@fn", fn)
                    command.Parameters.AddWithValue("@dir", dir)
                    command.Parameters.AddWithValue("@am", am)


                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("agent user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox3.Clear()
            TextBox2.Clear()

            RefreshDataGridView()
        Else
            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Fetching data from the database


    End Sub

    Private Sub agents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
        Label6.Visible = False

    End Sub

    Private Sub DeleteDataButton_Click(sender As Object, e As EventArgs) Handles DeleteDataButton.Click
        Dim pkToDelete As String = TextBox4.Text

        If String.IsNullOrWhiteSpace(pkToDelete) Then
            MessageBox.Show("Please enter a username to  delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM users WHERE id = @pk"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@pk", pkToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox1.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridView()
                Else
                    MessageBox.Show("No user angent that has that id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim fn As String = TextBox3.Text
        Dim pkToUpdate As String = TextBox1.Text
        Dim newNumber As String = TextBox2.Text
        Dim id As Integer = TextBox4.Text

        If String.IsNullOrWhiteSpace(id) Then
            MessageBox.Show("Please enter a id value to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim updateQuery As String = "UPDATE users SET full_names = @fn, username = @user,password= @ps WHERE id = @id"
            Using updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@fn", fn)
                updateCommand.Parameters.AddWithValue("@user", pkToUpdate)
                updateCommand.Parameters.AddWithValue("@ps", newNumber)
                updateCommand.Parameters.AddWithValue("@id", id)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("user/agent updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshDataGridView() ' Refresh the DataGridView after update
                    TextBox1.Clear()
                    TextBox3.Clear()
                    TextBox2.Clear()
                Else
                    MessageBox.Show("No record found with the specified id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub










    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub addB_Click(sender As Object, e As EventArgs) Handles addB.Click
        buses.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Directions.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        routes.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_Got(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        Label6.Visible = True
    End Sub

    Private Sub TextBox4_Lost(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        Label6.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub
End Class