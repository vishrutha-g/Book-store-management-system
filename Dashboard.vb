Imports System.Data.SqlClient
Public Class Dashboard
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub CountBooks()
        Dim BookNum As Integer
        Con.Open()
        Dim Sql = "select COUNT(*) from BookTbl2"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Sql, Con)
        BookNum = cmd.ExecuteScalar
        BookLbl.Text = BookNum
        Con.Close()
    End Sub
    Private Sub CountUsers()
        Dim UserNum As Integer
        Con.Open()
        Dim Sql = "select COUNT(*) from UserTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Sql, Con)
        UserNum = cmd.ExecuteScalar
        UserLbl.Text = UserNum
        Con.Close()
    End Sub
    Private Sub SumAmount()
        Try
            Con.Open()
            Dim Sql = "SELECT ISNULL(SUM(Amount), 0) FROM BillTbl"
            Dim cmd As New SqlCommand(Sql, Con)
            Dim result = cmd.ExecuteScalar()
            Dim Amount As Integer = If(result IsNot Nothing AndAlso Not Convert.IsDBNull(result), Convert.ToInt32(result), 0)
            AmountLbl.Text = Amount.ToString()
        Catch ex As Exception
            MessageBox.Show("Error calculating total amount: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub CountEmployee()
        Dim EmpNum As Integer
        Con.Open()
        Dim Sql = "select COUNT(*) from EmpTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Sql, Con)
        EmpNum = cmd.ExecuteScalar
        EmployeeLbl.Text = EmpNum
        Con.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountBooks()
        CountUsers()
        SumAmount()
        CountEmployee()
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj = New Employee
        Obj.Show()
        Hide()
    End Sub
End Class