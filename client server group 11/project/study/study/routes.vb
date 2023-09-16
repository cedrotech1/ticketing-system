Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class routes
    ' Dim statusx As String = TextBox2.Text
    Dim did As Integer
    Dim number As String
    Dim selectedItemId As Integer = -1 ' Variable to store the selected item's ID
    Dim selectedItemIdb As Integer = -1 ' Variable to store the selected item's ID
    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"

    Private Sub activate()
        Dim dataTable As New DataTable()

        ComboBoxD.Items.Clear() ' Clear existing items
        ComboBoxB.Items.Clear() ' Clear existing items

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim act As String = ComboBox1.Text

            Dim query As String = "SELECT routes.id,buses.prak,directions.direction,routes.startTime,routes.date,buses.numbers,status FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid and status = @pk"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", act)

                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub


    Private Sub RefreshDataGridView()
        Dim dataTable As New DataTable()

        ComboBoxD.Items.Clear() ' Clear existing items
        ComboBoxB.Items.Clear() ' Clear existing items

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryz As String = "SELECT routes.id,buses.prak,buses.numbers,directions.direction,routes.startTime,routes.date,buses.numbers,status FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid"
            Using adapter As New SqlDataAdapter(queryz, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable





        Dim query As String = "SELECT id, direction FROM directions"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim itemName As String = reader("direction").ToString()
                    Dim itemId As Integer = CInt(reader("id"))
                    ComboBoxD.Items.Add(itemName)
                    ComboBoxD.ValueMember = "id"
                    ComboBoxD.DisplayMember = "direction"

                End While

                reader.Close()
            End Using

        End Using

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Dim query1 As String = "SELECT id, prak FROM buses"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query1, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim itemName As String = reader("prak").ToString()
                    Dim itemId As Integer = CInt(reader("id"))
                    ComboBoxB.Items.Add(itemName)
                    ComboBoxB.ValueMember = "id"
                    ComboBoxB.DisplayMember = "prak"

                End While

                reader.Close()
            End Using
        End Using

        Dim dataTableb As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryx As String = "SELECT COUNT(id) FROM routes"
            Using adapter As New SqlDataAdapter(queryx, connection)
                ' No need to add a parameter to the adapter for this query
                adapter.Fill(dataTableb)
            End Using
        End Using

        For Each row As DataRow In dataTableb.Rows
            number = Convert.ToInt32(row(0)) ' Use index 0 to get the count value
        Next


        number = number + 1
        ' MsgBox("Number of routes: " & number)
        Tid.Text = number.ToString()
    End Sub
    Private Sub routes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()



    End Sub

    Private Sub ComboBoxB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxB.SelectedIndexChanged
        If ComboBoxD.SelectedIndex <> -1 Then
            selectedItemIdb = CInt(ComboBoxB.SelectedValue)
        Else
            selectedItemIdb = -1
        End If
    End Sub


    Private Sub ComboBoxD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxD.SelectedIndexChanged
        If ComboBoxD.SelectedIndex <> -1 Then
            selectedItemId = CInt(ComboBoxD.SelectedValue)
        Else
            selectedItemId = -1
        End If
    End Sub

    Private Sub insertDataButton_Click(sender As Object, e As EventArgs) Handles insertDataButton.Click

        Dim C As String = ComboBoxD.Text
        ' Dim Tid As Integer


        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM directions WHERE direction = @pk"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", C)

                adapter.Fill(dataTable)
            End Using
        End Using

        For Each row As DataRow In dataTable.Rows
            did = Convert.ToInt32(row("id")) ' Replace "id" with the actual column name for the ID

        Next
        'MsgBox("ID: " & did)
        'MsgBox("id iii: " & number)


        'MsgBox(C)




        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        Dim Cb As String = ComboBoxB.Text
        Dim bid As Integer

        Dim dataTableb As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM buses WHERE prak = @pk"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", Cb)

                adapter.Fill(dataTableb)
            End Using
        End Using

        For Each row As DataRow In dataTableb.Rows
            bid = Convert.ToInt32(row("id")) ' Replace "id" with the actual column name for the ID

        Next
        'MsgBox("ID: " & bid)
        Dim datex As String = TextBox1.Text
        Dim statusx As String = ComboBox1.Text
        Dim s As String = "activate"

        Dim time As String = TT.Text

        ' MsgBox("time: " & time)
        'MsgBox("BID: " & bid)
        'MsgBox("status: " & statusx)
        'MsgBox("datex: " & datex)


        Dim success As Boolean = False
        Dim exists As Boolean = False




        Using connection As New SqlConnection(connectionString)
            connection.Open()
            If String.IsNullOrWhiteSpace(number) OrElse String.IsNullOrWhiteSpace(bid) OrElse String.IsNullOrWhiteSpace(number) OrElse String.IsNullOrWhiteSpace(time) OrElse String.IsNullOrWhiteSpace(statusx) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM routes WHERE id = @pk"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@pk", bid)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("that buss is occupied in onother routes(journey !).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' Check if buss equipied___________________________________
            Dim checkQueryx As String = "SELECT COUNT(*) FROM routes WHERE busid = @pk and status=@s"
            Using checkCommand As New SqlCommand(checkQueryx, connection)
                checkCommand.Parameters.AddWithValue("@pk", number)
                checkCommand.Parameters.AddWithValue("@s", s)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("that route  already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then

                Dim status As String = ComboBox1.Text

                Dim query As String = "INSERT INTO routes VALUES ( @id,@bid, @did,@date,@time,@st)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@bid", bid)
                    command.Parameters.AddWithValue("@did", did)
                    command.Parameters.AddWithValue("@date", datex)
                    command.Parameters.AddWithValue("@time", time)
                    command.Parameters.AddWithValue("@st", status)
                    command.Parameters.AddWithValue("@id", number)
                    'MsgBox("status: " & status)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'time.Clear()
            'ComboBox1.SelectedIndex = -1
            'TextBox2.Clear()

            RefreshDataGridView()
        Else
            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Fetching data from the database





    End Sub

    Private Sub Tid_TextChanged(sender As Object, e As EventArgs) Handles Tid.TextChanged
        number = Tid.Text

    End Sub




    Private Sub DeleteDataButton_Click(sender As Object, e As EventArgs) Handles DeleteDataButton.Click
        If String.IsNullOrWhiteSpace(number) Then
            MessageBox.Show("Please enter a PK value to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM routes WHERE id = @pk"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@pk", number)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'TextBox1.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridView()
                Else
                    MessageBox.Show("No record found with the specified PK.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If selectedItemId <> -1 Then
            Dim C As String = ComboBoxD.Text
            ' Dim Tid As Integer


            Dim dataTable As New DataTable()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM directions WHERE direction = @pk"
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Add the parameter to the adapter
                    adapter.SelectCommand.Parameters.AddWithValue("@pk", C)

                    adapter.Fill(dataTable)
                End Using
            End Using

            For Each row As DataRow In dataTable.Rows
                did = Convert.ToInt32(row("id")) ' Replace "id" with the actual column name for the ID

            Next
            'MsgBox("ID: " & did)
            'MsgBox("id iii: " & number)


            'MsgBox(C)
        Else
            MsgBox("Please select a direction.")
        End If



        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        If selectedItemIdb <> -1 Then
            Dim Cb As String = ComboBoxB.Text
            Dim bid As Integer

            Dim dataTableb As New DataTable()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM buses WHERE prak = @pk"
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Add the parameter to the adapter
                    adapter.SelectCommand.Parameters.AddWithValue("@pk", Cb)

                    adapter.Fill(dataTableb)
                End Using
            End Using

            For Each row As DataRow In dataTableb.Rows
                bid = Convert.ToInt32(row("id")) ' Replace "id" with the actual column name for the ID

            Next
            MsgBox("ID: " & bid)
            Dim datex As String = TextBox1.Text
            Dim statusx As String = ComboBox1.Text

            Dim time As String = TT.Text

            ' MsgBox("time: " & time)
            'MsgBox("BID: " & bid)
            'MsgBox("status: " & statusx)
            'MsgBox("datex: " & datex)


            Dim success As Boolean = False
            Dim exists As Boolean = False




            Using connection As New SqlConnection(connectionString)
                connection.Open()
                If String.IsNullOrWhiteSpace(number) OrElse String.IsNullOrWhiteSpace(bid) OrElse String.IsNullOrWhiteSpace(number) OrElse String.IsNullOrWhiteSpace(time) OrElse String.IsNullOrWhiteSpace(statusx) Then
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Check if the record with the same pk already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM routes WHERE id = @pk"
                Using checkCommand As New SqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@pk", number)
                    Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                    If count = 0 Then
                        exists = True
                        MessageBox.Show("that route does not  already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                ' If the record doesn't exist, proceed with insertion
                If Not exists Then

                    Dim status As String = ComboBox1.Text
                    Dim query As String = "UPDATE routes SET busid = @bid, directionid = @did, date = @date, startTime = @time, status = @st WHERE id = @id"

                    ' Dim query As String = "INSERT INTO routes VALUES ( @id,@bid, @did,@date,@time,@st)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@bid", bid)
                        command.Parameters.AddWithValue("@did", did)
                        command.Parameters.AddWithValue("@date", datex)
                        command.Parameters.AddWithValue("@time", time)
                        command.Parameters.AddWithValue("@st", status)
                        command.Parameters.AddWithValue("@id", number)
                        MsgBox("status: " & status)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            success = True
                        End If
                    End Using
                End If
            End Using


            If success Then
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'time.Clear()
                'ComboBox1.SelectedIndex = -1
                'TextBox2.Clear()

                RefreshDataGridView()
            Else
                MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Fetching data from the database




        Else
            MsgBox("Please select a direction.")
        End If
    End Sub

    Private Sub seach_Click(sender As Object, e As EventArgs) Handles seach.Click
        Dim pkToDelete As String = TextBox2.Text

        If String.IsNullOrWhiteSpace(pkToDelete) Then
            MessageBox.Show("Please enter a date value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT routes.id,buses.prak,directions.direction,routes.startTime,routes.date,buses.numbers,status FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid and date = @pk"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", pkToDelete)

                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ref.Click
        RefreshDataGridView()
        MessageBox.Show("successfully Refrashed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub addB_Click(sender As Object, e As EventArgs) Handles addB.Click


        buses.Show()
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

    Private Sub Buttonv_Click(sender As Object, e As EventArgs) Handles Buttonv.Click
        Directions.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshDataGridView()
        MessageBox.Show("successfully Refrashed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        activate()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub
End Class



















































