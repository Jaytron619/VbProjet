Public Class Splashscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        splashLoader.Width += 3
        If splashLoader.Width >= 800 Then
            Timer1.Stop()
            mainForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
