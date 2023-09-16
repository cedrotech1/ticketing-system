Imports System.Data.SqlClient

Public Class buses
    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"

    Private Sub RefreshDataGridView()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT id,prak,category,numbers FROM buses"
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
        Dim pk As String = TextBox1.Text
        Dim ct As String = ComboBox1.Text
        Dim number As String = TextBox2.Text
        'Dim message As String = "pk: " & pk & vbCrLf & "ct: " & ct & vbCrLf & "number: " & number

        'MsgBox(message)


        Using connection As New SqlConnection(connectionString)
            connection.Open()
            If String.IsNullOrWhiteSpace(pk) OrElse String.IsNullOrWhiteSpace(ct) OrElse String.IsNullOrWhiteSpace(number) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM buses WHERE prak = @pk"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@pk", pk)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Record with the same prak number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO buses VALUES (@pk, @ct, @number)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@pk", pk)
                    command.Parameters.AddWithValue("@ct", ct)
                    command.Parameters.AddWithValue("@number", number)

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
            ComboBox1.SelectedIndex = -1
            TextBox2.Clear()

            RefreshDataGridView()
        Else
            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Fetching data from the database

    End Sub

    Private Sub buses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
        ' MsgBox("hello form")
        Label1.Text = "Enter Id To delete/update"


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles DeleteDataButton.Click
        Dim pkToDelete As String = TextBox4.Text

        If String.IsNullOrWhiteSpace(pkToDelete) Then
            MessageBox.Show("Please enter a bus id value to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM buses WHERE id = @pk"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@pk", pkToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox1.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridView()
                Else
                    MessageBox.Show("No record found with the specified PRAKE NUMBER.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim id As String = TextBox4.Text
        Dim pkToUpdate As String = TextBox1.Text
        Dim newCt As String = ComboBox1.Text
        Dim newNumber As String = TextBox2.Text

        If String.IsNullOrWhiteSpace(pkToUpdate) Then
            MessageBox.Show("Please enter a Buss id value to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim updateQuery As String = "UPDATE buses SET category = @ct, numbers = @number, prak = @pk WHERE id = @id"
            Using updateCommand As New SqlCommand(updateQuery, connection)

                updateCommand.Parameters.AddWithValue("@id", id)
                updateCommand.Parameters.AddWithValue("@ct", newCt)
                updateCommand.Parameters.AddWithValue("@number", newNumber)
                updateCommand.Parameters.AddWithValue("@pk", pkToUpdate)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshDataGridView() ' Refresh the DataGridView after update
                Else
                    MessageBox.Show("No record found with the specified buss id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub seachButton_Click(sender As Object, e As EventArgs) Handles seachButton.Click
        Dim pkToDelete As String = TextBox1.Text

        If String.IsNullOrWhiteSpace(pkToDelete) Then
            MessageBox.Show("Please enter a PK value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM buses WHERE prak = @pk"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", pkToDelete)

                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView5.DataSource = dataTable
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Directions.Show()
        Me.Hide()
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

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click

        Me.Hide()
        Home.Show()
    End Sub
End Class
