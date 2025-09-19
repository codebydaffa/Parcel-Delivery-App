Public Class RunnerHomepage
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer As Integer
        answer = MsgBox("are you sure you want to exit?", vbYesNo + vbDefaultButton1)
        If answer = vbYes Then
            LogoutExit.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AdminHomepage.Show()
        Me.Hide()
    End Sub
End Class
