Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Directions
    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"

    Private Sub RefreshDataGridView()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT id,direction,price FROM directions"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView5.DataSource = dataTable
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles insertDataButton.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim dir As String = TextBox1.Text
        Dim am As String = TextBox2.Text




        Using connection As New SqlConnection(connectionString)
            connection.Open()
            If String.IsNullOrWhiteSpace(dir) OrElse String.IsNullOrWhiteSpace(am) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM buses WHERE prak = @pk"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@pk", dir)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Destination  already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO directions VALUES (@dir, @am)"
                Using command As New SqlCommand(query, connection)
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
            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()

            TextBox2.Clear()

            RefreshDataGridView()
        Else
            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Fetching data from the database

    End Sub

    Private Sub Directions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()

        Label1.Text = "Enter Id To delete/update"


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DeleteDataButton_Click(sender As Object, e As EventArgs) Handles DeleteDataButton.Click
        Dim pkToDelete As String = TextBox4.Text

        If String.IsNullOrWhiteSpace(pkToDelete) Then
            MessageBox.Show("Please enter a Direction id delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM directions WHERE id = @pk"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@pk", pkToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox1.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridView()
                Else
                    MessageBox.Show("No record found with the specified direction id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim id As String = TextBox4.Text
        Dim pkToUpdate As String = TextBox1.Text
        Dim newNumber As String = TextBox2.Text

        If String.IsNullOrWhiteSpace(id) Then
            MessageBox.Show("Please enter a direction id value to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim updateQuery As String = "UPDATE directions SET direction = @pk, price = @new, direction = @pk WHERE id = @id"
            Using updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@new", newNumber)
                updateCommand.Parameters.AddWithValue("@id", id)
                updateCommand.Parameters.AddWithValue("@pk", pkToUpdate)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshDataGridView() ' Refresh the DataGridView after update
                Else
                    MessageBox.Show("No record found with the specified Direction id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub seachButton_Click(sender As Object, e As EventArgs) Handles seachButton.Click
        Dim pkToDelete As String = TextBox1.Text

        If String.IsNullOrWhiteSpace(pkToDelete) Then
            MessageBox.Show("Please enter a direction value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT direction,price FROM directions WHERE direction = @pk"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", pkToDelete)

                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView5.DataSource = dataTable
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        routes.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        agents.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_Got(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        Label1.Visible = False
    End Sub

    Private Sub TextBox4_Lost(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        Label1.Visible = True
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub addB_Click(sender As Object, e As EventArgs) Handles addB.Click
        buses.Show()
        Me.Hide()
    End Sub
End Class