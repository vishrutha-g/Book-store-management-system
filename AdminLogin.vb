Imports System.Data.SqlClient

Public Class AdminLogin
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code can be added here
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Exit()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim query As String = "SELECT COUNT(1) FROM AdminTbl WHERE AdminNo=@AdminNo AND Password=@Password"
        Using connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AdminNo", Convert.ToInt32(AdminoTb.Text))
                command.Parameters.AddWithValue("@Password", PasswordTb.Text)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                If count = 1 Then
                    Dim bookForm = New Book()
                    bookForm.Show()
                    Me.Hide()
                Else
                    MsgBox("Wrong Admin Number or Password")
                End If
            End Using
        End Using
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub

    Private Sub PasswordTb_TextChanged(sender As Object, e As EventArgs) Handles PasswordTb.TextChanged
        ' Set the PasswordChar property to '*' to hide the entered password
        PasswordTb.PasswordChar = "*"
    End Sub
End Class
