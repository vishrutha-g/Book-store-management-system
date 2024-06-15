Imports System.Data.SqlClient

Public Class Bill
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\BOOK.mdf;Integrated Security=True;Connect Timeout=30")
    Public Property UserName As String
    Private Sub Populate()
        Using Con
            Con.Open()
            Dim query = "SELECT * FROM BookTbl2"
            Dim adapter As New SqlDataAdapter(query, Con)
            Dim builder As New SqlCommandBuilder(adapter)
            Dim ds As New DataSet
            adapter.Fill(ds)
            Book1DGV.DataSource = ds.Tables(0)
        End Using
    End Sub

    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Dim i As Integer = 0
    Dim Key As Integer = 0
    Dim Stock As Integer = 0
    Dim GrdTotal As Integer = 0

    Private Sub Book1DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Book1DGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Book1DGV.Rows(e.RowIndex)
            BNameTb.Text = row.Cells(1).Value.ToString
            PricesTb.Text = row.Cells(5).Value.ToString
            Stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub UpdateBook()
        Dim NewQty As Integer = Stock - Convert.ToInt32(QtyTb.Text)

        If NewQty < 0 Then
            MsgBox("Not enough stock available.")
            Exit Sub
        End If

        If String.IsNullOrEmpty(QtyTb.Text) OrElse Key = 0 Then
            MsgBox("Missing Information")
            Exit Sub
        End If

        Dim query As String = "UPDATE BookTbl2 SET Quantity = " & NewQty & " WHERE BId = " & Key

        Using Con As New SqlConnection("Your connection string here")
            Con.Open()
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Updated Successfully")
            Populate()
        End Using
    End Sub

    Private Sub AddToBillBtn_Click(sender As Object, e As EventArgs) Handles AddToBillBtn.Click
        If PricesTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Enter The Quantity")
        ElseIf BNameTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf Convert.ToInt32(QtyTb.Text) > Stock Then
            MsgBox("Not Enough Stock")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Dim total As Integer = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PricesTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = BNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = PricesTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QtyTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total

            GrdTotal += total
            TotalLbl.Text = "Rs" & GrdTotal
        End If
    End Sub

    Private Sub Reset()
        BNameTb.Text = ""
        PricesTb.Text = ""
        QtyTb.Text = ""
        ClientNameTb.Text = ""
    End Sub


    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Exit()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("BookStore", New Font("Century Gothic", 25), Brushes.MediumVioletRed, 100, 40)
        e.Graphics.DrawString("======Your Bill====", New Font("Arial", 20), Brushes.PaleVioletRed, 250, 100)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 60, 120)
        e.Graphics.DrawString("Total amoount rs " + GrdTotal.ToString, New Font("century Gothic", 15), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("  ========Thank You For Your Services===============", New Font("Century Gothic", 15), Brushes.MediumVioletRed, 120, 665)
    End Sub

    Private Sub But_Click(sender As Object, e As EventArgs) Handles But.Click
        Using printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = PrintDocument1
            printPreviewDialog.ShowDialog()
        End Using
    End Sub


    Private Sub AddBill()
        Try
            Con.Open()
            Dim query As String = "INSERT INTO BillTbl (UserName, ClientName, Amount) VALUES (@UserName, @ClientName, @Amount)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@UserName", UserName)
            cmd.Parameters.AddWithValue("@ClientName", ClientNameTb.Text)
            cmd.Parameters.AddWithValue("@Amount", GrdTotal)
            cmd.ExecuteNonQuery()
            MsgBox("Bill saved successfully")
        Catch ex As SqlException
            MsgBox("SQL Error: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error saving bill: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub





    Private Sub RetsetBtn_Click(sender As Object, e As EventArgs) Handles RetsetBtn.Click
        Reset()
    End Sub

    Private Sub FlowLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel4.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Obj = New login
        Obj.Show()
        Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Obj = New BookDetailsForm
        Obj.Show()
        Hide()
    End Sub
End Class
