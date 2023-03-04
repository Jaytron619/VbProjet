Public Class homeUserControl
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "hh:mm:ss tt")
        lblDate.Text = Format(Date.Now, "dd MMMM,yyyy")
    End Sub
End Class
