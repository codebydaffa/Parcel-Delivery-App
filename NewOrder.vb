Public Class NewOrder
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserHomepage.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OrderDetails.Show()
        Me.Hide()
    End Sub
End Class