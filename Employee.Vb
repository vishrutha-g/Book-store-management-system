Imports System.Data.SqlClient

Public Class Employee
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False")

    Private Sub Populate()
        Con.Open()
        Dim query = "SELECT * FROM EmpTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmpDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Reset()
        EmpnameTb.Text = ""
        EmpphoneTb.Text = ""
        EmpaddressTb.Text = ""
        EmppasswordTb.Text = ""
        Key = 0
    End Sub
    Private Sub EmpSaveBtn_Click(sender As Object, e As EventArgs) Handles EmpsaveBtn.Click
        Try
            If EmpnameTb.Text = "" Or EmpphoneTb.Text = "" Or EmpaddressTb.Text = "" Or EmppasswordTb.Text = "" Then
                MsgBox("Missing information")
            Else
                Con.Open()
                Dim query As String
                query = "INSERT INTO EmpTbl (Name, Phone, Address, Password) VALUES ('" & EmpnameTb.Text & "','" & EmpphoneTb.Text & "','" & EmpaddressTb.Text & "','" & EmppasswordTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee saved successfully")
                Con.Close()
                Populate()
                Empreset()
            End If
        Catch ex As Exception
            MsgBox("Error saving employee: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub


    Private Sub EmpDeleteBtn_Click(sender As Object, e As EventArgs) Handles EmpdeleteTb.Click
        If Key = 0 Then
            MsgBox("Select the employee to be deleted")
        Else
            Con.Open()
            Dim query As String
            query = "DELETE FROM EmpTbl WHERE Id=" & Key
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee deleted successfully")
            Con.Close()
            Populate()
            Empreset()
        End If
    End Sub

    Private Sub EmpeditBtn_Click(sender As Object, e As EventArgs) Handles EmpeditTb.Click
        If EmpnameTb.Text = "" Or EmpphoneTb.Text = "" Or EmpaddressTb.Text = "" Or EmppasswordTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = "UPDATE EmpTbl SET Name='" & EmpnameTb.Text & "', Phone='" & EmpphoneTb.Text & "', Address='" & EmpaddressTb.Text & "', Password='" & EmppasswordTb.Text & "' WHERE Id=" & Key
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated Successfully")
            Con.Close()
            Populate()
            Empreset()
        End If
    End Sub
    Dim Key As Integer = 0

    Private Sub EmpDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmpDGV.CellMouseClick
        Dim row As DataGridViewRow = EmpDGV.Rows(e.RowIndex)
        EmpnameTb.Text = row.Cells(1).Value.ToString
        EmpphoneTb.Text = row.Cells(2).Value.ToString
        EmpaddressTb.Text = row.Cells(3).Value.ToString
        EmppasswordTb.Text = row.Cells(4).Value.ToString
        Key = Convert.ToInt32(row.Cells(0).Value)
    End Sub
    Private Sub Empreset()
        ' Reset the employee form fields '
        EmpnameTb.Text = ""
        EmpphoneTb.Text = ""
        EmpaddressTb.Text = ""
        EmppasswordTb.Text = ""
        Key = 0
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate() ' Call the Populate method directly '
    End Sub

    Private Sub EmpresetBtn_Click(sender As Object, e As EventArgs) Handles EmpresetBtn.Click
        Reset()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub
End Class

