Imports System.Data.SqlClient
Public Class Users
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private Sub Populate()
        Try
            Con.Open()
            Dim query = "SELECT * FROM UserTbl"
            Dim adapter As New SqlDataAdapter(query, Con)
            Dim builder As New SqlCommandBuilder(adapter)
            Dim ds As New DataSet
            adapter.Fill(ds)
            UserDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Reset()
        UnameTb.Text = ""
        PhoneTb.Text = ""
        AddressTb.Text = ""
        PasswordTb.Text = ""
        Key = 0
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If UnameTb.Text = "" Or PhoneTb.Text = "" Or AddressTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Missing information")
        Else
            Try
                Using Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

                    Con.Open()
                    Dim query As String = "INSERT INTO UserTbl (name, Phone, Address, Password) VALUES(@name, @phone, @address, @password)"
                    Dim cmd As New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@name", UnameTb.Text)
                    cmd.Parameters.AddWithValue("@phone", PhoneTb.Text)
                    cmd.Parameters.AddWithValue("@address", AddressTb.Text)
                    cmd.Parameters.AddWithValue("@password", PasswordTb.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("User saved successfully")
                    Populate()
                    Reset()
                End Using
            Catch ex As Exception
                MsgBox("Error saving user: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Dim Key As Integer = 0

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = 0 Then
            MsgBox("Select the user to be deleted")
        Else
            Con.Open()
            Dim query As String
            query = "DELETE FROM UserTbl WHERE Id=" & Key
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User deleted successfully")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub UserDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDGV.CellMouseClick
        Dim row As DataGridViewRow = UserDGV.Rows(e.RowIndex)
        UnameTb.Text = row.Cells(1).Value.ToString
        PhoneTb.Text = row.Cells(2).Value.ToString
        AddressTb.Text = row.Cells(3).Value.ToString
        PasswordTb.Text = row.Cells(4).Value.ToString
        Key = Convert.ToInt32(row.Cells(0).Value)
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If UnameTb.Text = "" Or PhoneTb.Text = "" Or AddressTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = "UPDATE UserTbl SET name='" & UnameTb.Text & "',Phone='" & PhoneTb.Text & "',Address='" & AddressTb.Text & "',Password='" & PasswordTb.Text & "' WHERE Id=" & Key
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Successfully")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Dim Obj = New Book()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim Obj = New users()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Dim Obj = New login
        Obj.Show()
        Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj = New Employee
        Obj.Show()
        Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
