Imports System.Data.SqlClient

Public Class login
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UserNameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter UserName and Password")
        Else
            Con.Open()
            Dim query As String = "select * from UserTbl where name='" & UserNameTb.Text & "' and password='" & PasswordTb.Text & "'"
            Dim cmd As New SqlCommand(query, Con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            sda.Fill(ds)
            Dim a As Integer = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username or Password")
            Else

                Dim Bi = New Bill
                Bill.UserName = UserNameTb.Text
                Bi.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Exit()
    End Sub
    Private Sub AdminBtn_Click(sender As Object, e As EventArgs) Handles AdminBtn.Click
        Dim adminForm As New AdminLogin()
        adminForm.Show()
        Me.Hide()
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PasswordChar property to '*' to hide the entered password
        PasswordTb.PasswordChar = "*"
    End Sub

End Class
