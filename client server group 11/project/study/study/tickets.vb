Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class tickets
    Dim act As String = "activate"
    Dim number As String
    Dim n As Integer
    Dim x As Integer
    Dim num As Integer

    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"
    Public Class SharedData
        Public Shared SharedValue As String
    End Class
    Private Sub RefreshDataGridView()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT routes.id,directions.direction,routes.startTime,buses.numbers,date FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub pricessub()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT direction,price FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView3.DataSource = dataTable
    End Sub
    Private Sub routes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
        pricessub()
        PictureBox2.Visible = False


    End Sub





    Private Sub insertDataButton_Click(sender As Object, e As EventArgs) Handles insertDataButton.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim dir As String = Tid.Text
        Dim am As String = TextBox3.Text




        Using connection As New SqlConnection(connectionString)
            connection.Open()
            If String.IsNullOrWhiteSpace(dir) OrElse String.IsNullOrWhiteSpace(am) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim dataTablezz As New DataTable()

            Using connectionx As New SqlConnection(connectionString)

                Dim queryx As String = "SELECT busid FROM routes routes WHERE id = @id"
                Using adapter As New SqlDataAdapter(queryx, connectionx)
                    adapter.SelectCommand.Parameters.AddWithValue("@id", dir) ' Replace yourIdValue with the actual value you want to use for the parameter.
                    adapter.Fill(dataTablezz)
                End Using
            End Using

            For Each row As DataRow In dataTablezz.Rows
                x = Convert.ToInt32(row(0)) ' Use index 0 to get the count value
            Next
            ' MsgBox(x)








            Dim dataTableyy As New DataTable()

            Using connectionx As New SqlConnection(connectionString)

                Dim queryz As String = "SELECT numbers FROM buses routes WHERE id = @id"
                Using adapter As New SqlDataAdapter(queryz, connectionx)
                    adapter.SelectCommand.Parameters.AddWithValue("@id", x) ' Replace yourIdValue with the actual value you want to use for the parameter.
                    adapter.Fill(dataTableyy)
                End Using
            End Using

            ' Check if the record with the same pk already exists
            Dim checkQueryx As String = "SELECT COUNT(*) FROM routes WHERE id = @id"
            Using checkCommand As New SqlCommand(checkQueryx, connection)
                checkCommand.Parameters.AddWithValue("@id", dir)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then
                    ' exists = True
                    MessageBox.Show("That route dose not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PictureBox2.Visible = False
                    Return
                End If
            End Using

            For Each row As DataRow In dataTableyy.Rows
                num = Convert.ToInt32(row(0)) ' Use index 0 to get the count value
            Next
            'MsgBox(num)

            If num <= 0 Then
                ' exists = True
                MessageBox.Show("tickets sold out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PictureBox2.Visible = True
                Return
            End If



            ' If the record doesn't exist, proceed with insertion
            If Not exists Then

                Dim dataTableb As New DataTable()

                Using connectionx As New SqlConnection(connectionString)

                    Dim queryx As String = "SELECT COUNT(id) FROM tickets"
                    Using adapter As New SqlDataAdapter(queryx, connectionx)
                        adapter.Fill(dataTableb)
                    End Using
                End Using

                For Each row As DataRow In dataTableb.Rows
                    n = Convert.ToInt32(row(0)) ' Use index 0 to get the count value
                Next
                n = n + 1

                Dim query As String = "INSERT INTO tickets VALUES (@id,@dir, @am,@date)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@dir", dir)
                    command.Parameters.AddWithValue("@am", am)
                    command.Parameters.AddWithValue("@id", n)
                    command.Parameters.AddWithValue("@date", DateTime.Now)
                    'command.Parameters.AddWithValue("@id", number)


                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("Ticket booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            PictureBox2.Visible = False

            TextBox2.Clear()

            RefreshDataGridView()

            Dim dataTableb As New DataTable()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim queryx As String = "SELECT COUNT(id) FROM tickets"
                Using adapter As New SqlDataAdapter(queryx, connection)
                    ' No need to add a parameter to the adapter for this query
                    adapter.Fill(dataTableb)
                End Using
            End Using
            For Each row As DataRow In dataTableb.Rows
                number = Convert.ToInt32(row(0)) ' Use index 0 to get the count value
            Next



            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim up As Integer = num - 1

                Dim updateQuery As String = "UPDATE buses SET numbers = @number  WHERE id = @id"
                Using updateCommand As New SqlCommand(updateQuery, connection)

                    updateCommand.Parameters.AddWithValue("@id", x)
                    updateCommand.Parameters.AddWithValue("@number", up)
                    updateCommand.ExecuteNonQuery()

                End Using
            End Using



            'MsgBox("Number of routes: " & Number)
            ' Tid.Text = number.ToString()
            'Label6.Text = n
            'Label8.Text = "TICKET ID IS"
            'DataGridView3.Visible = False
            SharedData.SharedValue = n
            ' MsgBox(n)

            getTicket.Show()
            Me.Hide()

        Else
            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Fetching data from the database

    End Sub

    Private Sub seach_Click(sender As Object, e As EventArgs) Handles seach.Click
        Dim datex As String = TextBox2.Text
        Dim timex As String = TextBox1.Text


        If String.IsNullOrWhiteSpace(datex) OrElse String.IsNullOrWhiteSpace(timex) Then
            MessageBox.Show("Please enter a date value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT routes.id,directions.direction,routes.startTime,routes.date,buses.numbers,directions.price FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid and date = @pk and startTime=@s and status=@st"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", datex)
                adapter.SelectCommand.Parameters.AddWithValue("@s", timex)
                adapter.SelectCommand.Parameters.AddWithValue("@st", act)

                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        getTicket.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datex As String = TextBox2.Text
        Dim timex As String = TextBox2.Text


        If String.IsNullOrWhiteSpace(datex) OrElse String.IsNullOrWhiteSpace(timex) Then
            MessageBox.Show("Please enter a date value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT routes.id,directions.direction,routes.startTime,routes.date,buses.numbers,directions.price FROM buses,directions,routes where buses.id=routes.busid and directions.id=routes.directionid and date = @pk and startTime=@s and status=@st"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@pk", datex)
                adapter.SelectCommand.Parameters.AddWithValue("@s", timex)
                adapter.SelectCommand.Parameters.AddWithValue("@st", act)

                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub
End Class
