Imports System.Windows.Forms
Public Class mainForm

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If sidePanel.Width = 200 Then
            sidePanel.Width = 40
            Logo1.Visible = False
        Else
            sidePanel.Width = 200
            Logo1.Visible = True
        End If
    End Sub

    Public Sub showControl(scontrol As Control)
        contentPanel.Controls.Clear()
        scontrol.Dock = DockStyle.Fill
        scontrol.BringToFront()
        scontrol.Focus()
        scontrol.BackColor = Color.FromArgb(240, 240, 240)
        contentPanel.Controls.Add(scontrol)
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New loginUserControl
        showControl(login)
        sidePanel.Visible = False
        lblLogOut.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim login As New loginUserControl
        showControl(login)
        sidePanel.Visible = False
        lblLogOut.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        openURL("")
    End Sub
    Private Sub openURL(ByVal url As String)
        Try
            System.Diagnostics.Process.Start(url)
        Catch ex As Exception
            MessageBox.Show("No default browser foumd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim home As New homeUserControl
        showControl(home)
    End Sub

    Private Sub btnAdmission_Click(sender As Object, e As EventArgs) Handles btnAdmission.Click
        Dim admiss As New admissionUserControl
        showControl(admiss)
    End Sub

    Private Sub btnStudents_Click_1(sender As Object, e As EventArgs) Handles btnStudents.Click
        Dim students As New studentsUserControl
        showControl(students)
    End Sub

    Private Sub btnStaff_Click_1(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staff As New staffUserControl
        showControl(staff)
    End Sub

    Private Sub btnLevel_Click_1(sender As Object, e As EventArgs) Handles btnLevel.Click
        Dim level As New levelUserControl
        showControl(level)
    End Sub

    Private Sub btnCourses_Click_1(sender As Object, e As EventArgs) Handles btnCourses.Click
        Dim courses As New coursesUserControl
        showControl(courses)
    End Sub

    Private Sub btnFees_Click_1(sender As Object, e As EventArgs) Handles btnFees.Click
        Dim fees As New feesUserControl
        showControl(fees)
    End Sub

    Private Sub btnLibrary_Click_1(sender As Object, e As EventArgs) Handles btnLibrary.Click
        Dim library As New LibraryUserControl
        showControl(library)
    End Sub
End Class