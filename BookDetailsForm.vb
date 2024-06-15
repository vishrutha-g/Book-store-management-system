Public Class BookDetailsForm
    Private Sub BookDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj = New Bill
        Obj.Show()
        Hide()
    End Sub
End Class