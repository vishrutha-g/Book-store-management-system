Imports System.Data.SqlClient

Public Class Form1
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim query As String = "INSERT INTO AdminTbl (AdminNo, Username, Password) VALUES (@AdminNo, @Username, @Password)"
        Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AdminNo", Convert.ToInt32(AdminnoTb.Text))
                command.Parameters.AddWithValue("@Username", UsernameTb.Text)
                command.Parameters.AddWithValue("@Password", PasswordTb.Text)
                connection.Open()
                command.ExecuteNonQuery()
                MsgBox("Admin user added successfully")
            End Using
        End Using
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim query As String = "DELETE FROM AdminTbl WHERE AdminNo = @AdminNo"
        Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AdminNo", Convert.ToInt32(AdminnoTb.Text))
                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()
                If result > 0 Then
                    MsgBox("Admin user deleted successfully")
                Else
                    MsgBox("Admin user not found")
                End If
            End Using
        End Using
    End Sub

    Private Sub CountBtn_Click(sender As Object, e As EventArgs) Handles countBtn.Click
        Try
            Dim query As String = "SELECT COUNT(*) FROM AdminTbl"
            Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    CountLbl.Text = "Count: " & count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error counting admins: " & ex.Message)
        End Try
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        AdminnoTb.Clear()
        UsernameTb.Clear()
        PasswordTb.Clear()

    End Sub
End Class
