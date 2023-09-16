Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm1
    Dim connectionString As String = "Data Source=cit\sqlexpress;Initial Catalog=ticket;Integrated Security=True"



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Me.Close()
        ' MsgBox("yes")

        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' SQL query to retrieve the password for the entered username
            Dim query As String = "SELECT password FROM Users WHERE username = @username"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)

                Dim storedPassword As String = Convert.ToString(command.ExecuteScalar())

                If String.IsNullOrEmpty(storedPassword) Then
                    ' Username not found in the database
                    MessageBox.Show("Username not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf storedPassword = password Then
                    ' Passwords match
                    If username = "admin" Then
                        ' If the username is "admin," redirect to a different form


                        Dim homeForm As New Home()
                        homeForm.Show()
                    Else
                        ' For other users, show the "Home" form
                        Dim tickets As New tickets()
                        tickets.Show()
                    End If
                    Me.Hide() ' Hide the login form
                Else
                    ' Passwords don't match, display an error message
                    MessageBox.Show("Incorrect password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
