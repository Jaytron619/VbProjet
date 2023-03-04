Imports System.Data
Imports System.Data.SqlClient
Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

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
            Me.Hide()
            mainForm.Show()

        End If


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnShow_CheckedChanged(sender As Object, e As EventArgs) Handles btnShow.CheckedChanged
        If btnShow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class