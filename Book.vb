Imports System.Data.SqlClient

Public Class Book
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Populate()

        Con.Open()
        Dim query = "select * from BookTbl2"
        Dim adapter As New SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As New DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Filter()
        Try
            If ComboBox2.SelectedItem IsNot Nothing Then
                Con.Open()
                Dim query = "SELECT * FROM BookTbl2 WHERE Category=@Category"
                Dim adapter As New SqlDataAdapter(query, Con)
                adapter.SelectCommand.Parameters.AddWithValue("@Category", ComboBox2.SelectedItem.ToString())
                Dim ds As New DataSet
                adapter.Fill(ds)
                BooksDGV.DataSource = ds.Tables(0)
            Else
                MsgBox("Please select a category.")
            End If
        Catch ex As SqlException
            MsgBox("SQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub


    Private Sub Reset()
        BookNameTb.Text = ""
        QtyTb.Text = ""
        PriceTb.Text = ""
        AuthorTb.Text = ""
        CatCb.SelectedIndex = -1
        Key = 0
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If BookNameTb.Text = "" Or AuthorTb.Text = "" Or QtyTb.Text = "" Or PriceTb.Text = "" Or CatCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = "insert into BookTbl2 values ('" & BookNameTb.Text & "','" & AuthorTb.Text & "','" & CatCb.SelectedItem.ToString & "','" & QtyTb.Text & "','" & PriceTb.Text & "')"

            Dim cmd As SqlCommand = New SqlCommand()
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book saved successfully")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub
    Dim Key = 0


    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Key = 0 Then
            MsgBox("Select the Book to be deleted")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from BookTbl2 where BId=" & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted successfully")
            Con.Close()
            Populate()
            Reset()
        End If

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Exit()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If BookNameTb.Text = "" Or AuthorTb.Text = "" Or QtyTb.Text = "" Or PriceTb.Text = "" Or CatCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = "UPDATE BookTbl2 SET Title='" & BookNameTb.Text & "', Author='" & AuthorTb.Text & "', Category='" & CatCb.SelectedItem.ToString & "', Quantity=" & QtyTb.Text & ", Price=" & PriceTb.Text & " WHERE BId=" & Key
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Updated Successfully")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Filter()

    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Populate()
    End Sub

    Private Sub BooksDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BooksDGV.CellDoubleClick
        Dim row As DataGridViewRow = BooksDGV.Rows(e.RowIndex)
        BookNameTb.Text = row.Cells(1).Value.ToString
        AuthorTb.Text = row.Cells(2).Value.ToString
        CatCb.SelectedItem = row.Cells(3).Value.ToString
        QtyTb.Text = row.Cells(4).Value.ToString
        PriceTb.Text = row.Cells(5).Value.ToString
        If BookNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New users()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New Book()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Obj = New login
        Obj.Show()
        Hide()
    End Sub

    Private Sub FlowLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel4.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim Obj = New Employee
        Obj.Show()
        Hide()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Filter()
    End Sub
End Class
