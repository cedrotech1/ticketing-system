Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Home

    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"

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

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim query As String = "SELECT COUNT(id) as buses FROM buses"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
                For Each row As DataRow In dataTable.Rows
                    Dim buses As String = row("buses").ToString()
                    Label10.Text = buses
                Next
            End Using
        End Using
        '  ___________________________________________________________________________

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim query As String = "SELECT COUNT(id) as directions FROM directions"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
                For Each row As DataRow In dataTable.Rows
                    Dim directions As String = row("directions").ToString()
                    Label6.Text = directions
                Next
            End Using
        End Using
        '  ___________________________________________________________________________
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim query As String = "SELECT COUNT(id) as routes FROM routes"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
                For Each row As DataRow In dataTable.Rows
                    Dim routes As String = row("routes").ToString()
                    Label8.Text = routes
                Next
            End Using
        End Using
        '  ___________________________________________________________________________

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim query As String = "SELECT COUNT(id) as users FROM users"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
                For Each row As DataRow In dataTable.Rows
                    Dim users As String = row("users").ToString()
                    Label1.Text = users - 1
                Next
            End Using
        End Using
        '  ___________________________________________________________________________

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim query As String = "SELECT sum(price) as price FROM buses, directions, routes, tickets WHERE buses.id = routes.busid AND directions.id = routes.directionid AND tickets.rid = routes.id"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
                For Each row As DataRow In dataTable.Rows
                    Dim price As String = row("price").ToString()
                    Label11.Text = price
                Next
            End Using
        End Using
        '  ___________________________________________________________________________
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
