Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ticket.tickets

Public Class getTicket
    Private WithEvents printDocument As New PrintDocument()
    Dim tidX As Integer = SharedData.SharedValue

    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"



    Private Sub Button4_Click(sender As Object, e As EventArgs)





        Dim isNumber As Boolean

        ' Try to parse tidX as an integer
        If Integer.TryParse(tidX, isNumber) Then
            ' tidX is a valid integer
            ' You can continue with your code here




            If String.IsNullOrWhiteSpace(tidX) Then
                MessageBox.Show("Please enter a Ticket value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dataTable As New DataTable()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT directions.direction,routes.startTime,routes.date,directions.price,buses.prak,tickets.name,tickets.ticketdate FROM buses,directions,routes,tickets where buses.id=routes.busid and directions.id=routes.directionid and tickets.rid=routes.id and tickets.id=@id"
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Add the parameter to the adapter
                    adapter.SelectCommand.Parameters.AddWithValue("@id", tidX)


                    adapter.Fill(dataTable)

                    ' Check if any rows were returned
                    If dataTable.Rows.Count = 0 Then
                        'MessageBox.Show("No matching records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        For Each row As DataRow In dataTable.Rows
                            Dim direction As String = row("direction").ToString()
                            Dim startTime As String = row("startTime").ToString()
                            Dim [date] As String = row("date")
                            Dim price As Decimal = Convert.ToDecimal(row("price"))
                            Dim prak As String = row("prak").ToString()
                            Dim namex As String = row("name").ToString()
                            Dim datex As String = row("ticketdate").ToString()
                            Label7.Text = namex
                            Label11.Text = direction
                            Label14.Text = price & " RWF"
                            Label12.Text = startTime
                            Label13.Text = prak
                            Label19.Text = datex
                            'Label8.Text = "TICKET ID IS"
                        Next
                        DataGridView5.Visible = True
                        Label7.Visible = True
                        Label11.Visible = True
                        Label14.Visible = True
                        Label12.Visible = True
                        Label13.Visible = True

                        Label6.Visible = True
                        Label10.Visible = True
                        Label8.Visible = True
                        Label9.Visible = True
                        Label5.Visible = True
                        Label1.Visible = True

                        Label18.Visible = True
                        Label19.Visible = True




                    End If
                End Using
            End Using


        Else
            MessageBox.Show("Please enter a valid Ticket value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
    ' Event handler for printing
    Private Sub printDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument.PrintPage
        ' Create a Graphics object for drawing.
        Dim g As Graphics = e.Graphics
        Dim font As New Font("Arial", 12)

        ' Define the starting position for drawing.
        Dim x As Single = 100
        Dim y As Single = 100

        ' Loop through all controls on the form and print them.
        For Each control As Control In Me.Controls
            ' Check if the control is visible and printable.
            If control.Visible AndAlso control.CanSelect Then
                ' Draw the control on the page.
                Dim bmp As New Bitmap(control.Width, control.Height)
                control.DrawToBitmap(bmp, New Rectangle(0, 0, control.Width, control.Height))
                g.DrawImage(bmp, x, y)

                ' Move to the next position.
                y += control.Height + 20 ' Adjust the spacing as needed.
            End If
        Next


        ' Check if there are more pages to print.
        e.HasMorePages = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim printDialog As New PrintDialog()

        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Set the PrintDocument object to the selected printer
            printDocument.PrinterSettings = printDialog.PrinterSettings
            ' Start the printing process
            printDocument.Print()
        End If
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tickets.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub getTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Dim isNumber As Boolean

        ' Try to parse tidX as an integer
        If Integer.TryParse(tidX, isNumber) Then
            ' tidX is a valid integer
            ' You can continue with your code here






            Dim dataTable As New DataTable()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT directions.direction,routes.startTime,routes.date,directions.price,buses.prak,tickets.name,tickets.ticketdate FROM buses,directions,routes,tickets where buses.id=routes.busid and directions.id=routes.directionid and tickets.rid=routes.id and tickets.id=@id"

                Using adapter As New SqlDataAdapter(query, connection)
                    'MsgBox(tidX)

                    ' Add the parameter to the adapter
                    adapter.SelectCommand.Parameters.AddWithValue("@id", tidX)


                    adapter.Fill(dataTable)

                    ' Check if any rows were returned
                    If dataTable.Rows.Count = 0 Then
                        'MessageBox.Show("No matching records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        For Each row As DataRow In dataTable.Rows
                            Dim direction As String = row("direction").ToString()
                            Dim startTime As String = row("startTime").ToString()
                            Dim [date] As String = row("date")
                            Dim price As Decimal = Convert.ToDecimal(row("price"))
                            Dim prak As String = row("prak").ToString()
                            Dim namex As String = row("name").ToString()
                            Dim datex As String = row("ticketdate").ToString()
                            Label7.Text = namex
                            Label11.Text = direction
                            Label14.Text = price & " RWF"
                            Label12.Text = startTime
                            Label13.Text = prak
                            Label19.Text = datex
                            'Label8.Text = "TICKET ID IS"
                        Next
                        DataGridView5.Visible = True
                        Label7.Visible = True
                        Label11.Visible = True
                        Label14.Visible = True
                        Label12.Visible = True
                        Label13.Visible = True

                        Label6.Visible = True
                        Label10.Visible = True
                        Label8.Visible = True
                        Label9.Visible = True
                        Label5.Visible = True
                        Label1.Visible = True

                        Label18.Visible = True
                        Label19.Visible = True




                    End If
                End Using
            End Using


        Else
            MessageBox.Show("Please enter a valid Ticket value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub
End Class