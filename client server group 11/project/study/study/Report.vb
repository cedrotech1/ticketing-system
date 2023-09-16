Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Report
    Dim act As String = "activate"
    Dim number As String

    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"

    Private Sub RefreshDataGridView()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT directions.direction,routes.startTime,routes.date,directions.price,buses.prak,tickets.name FROM buses,directions,routes,tickets where buses.id=routes.busid and directions.id=routes.directionid and tickets.rid=routes.id "
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        DataGridView1.DataSource = dataTable


        Dim dataTablex As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryx As String = "SELECT sum(price) FROM buses, directions, routes, tickets WHERE buses.id = routes.busid AND directions.id = routes.directionid AND tickets.rid = routes.id"
            Using adapter As New SqlDataAdapter(queryx, connection)
                adapter.Fill(dataTablex)

                ' Check if any rows were returned
                If dataTablex.Rows.Count > 0 AndAlso dataTablex.Rows(0)(0) IsNot DBNull.Value Then
                    ' Extract the sum as a decimal (or the appropriate numeric type)
                    Dim sumPrice As Decimal = Convert.ToDecimal(dataTablex.Rows(0)(0))
                    'MsgBox("Sum of prices: " & sumPrice.ToString())
                    Label5.Text = sumPrice & " RWF"
                Else
                    Label5.Text = "0  RWF"
                End If
            End Using
        End Using


    End Sub
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub

    Private Sub seach_Click(sender As Object, e As EventArgs)
        Dim datex As String = TextBox2.Text



        If String.IsNullOrWhiteSpace(datex) Then
            MessageBox.Show("Please enter a date value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT directions.direction,routes.startTime,routes.date,directions.price,buses.prak,tickets.name FROM buses,directions,routes,tickets where buses.id=routes.busid and directions.id=routes.directionid and tickets.rid=routes.id and routes.date=@id"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@id", datex)


                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshDataGridView()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim datex As String = TextBox2.Text


        Dim dataTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT directions.direction,routes.startTime,routes.date,directions.price,buses.prak,tickets.name FROM buses,directions,routes,tickets where buses.id=routes.busid and directions.id=routes.directionid and tickets.rid=routes.id and routes.date=@id"
            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter

                adapter.SelectCommand.Parameters.AddWithValue("@id", datex)
                adapter.Fill(dataTable)
            End Using
        End Using

        Dim dataTablex As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryx As String = "SELECT sum(price) FROM buses, directions, routes, tickets WHERE buses.id = routes.busid AND directions.id = routes.directionid AND tickets.rid = routes.id and routes.date=@id"
            Using adapter As New SqlDataAdapter(queryx, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@id", datex)
                adapter.Fill(dataTablex)

                ' Check if any rows were returned
                If dataTablex.Rows.Count > 0 AndAlso dataTablex.Rows(0)(0) IsNot DBNull.Value Then
                    ' Extract the sum as a decimal (or the appropriate numeric type)
                    Dim sumPrice As Decimal = Convert.ToDecimal(dataTablex.Rows(0)(0))
                    'MsgBox("Sum of prices: " & sumPrice.ToString())
                    Label5.Text = sumPrice & " RWF"
                Else
                    Label5.Text = "0  RWF"
                End If
            End Using
        End Using

        ' Binding data to the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub addB_Click(sender As Object, e As EventArgs) Handles addB.Click


        buses.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        routes.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class