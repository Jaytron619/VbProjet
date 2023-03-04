Imports System.Data.SqlClient
Imports VbProjet.mainForm
Imports VbProjet.homeUserControl
Public Class loginUserControl

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sqlCon As New SqlConnection("Data Source=JAYTRON;Initial Catalog=VbProject;Integrated Security=True")
        Dim sqlCmd As New SqlCommand("SELEct *from Login where Username=@username and Password=@password", sqlCon)
        sqlCmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text
        sqlCmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text
        Dim adpt As New SqlDataAdapter(sqlCmd)
        Dim table As New DataTable

        adpt.Fill(table)
        If table.Rows.Count <= 0 Then
            MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim hme As New homeUserControl
            mainForm.showControl(hme)
            mainForm.sidePanel.Visible = True
            mainForm.lblLogOut.Visible = True

        End If
    End Sub


    Private Sub btnShow_CheckedChanged_1(sender As Object, e As EventArgs) Handles btnShow.CheckedChanged
        If btnShow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
