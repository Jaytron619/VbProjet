Imports System.Data.SqlClient
Imports System.IO
Public Class studentsUserControl
    Dim Sqlcon As New SqlConnection("Data Source=JAYTRON;Initial Catalog=VbProject;Integrated Security=True")


    Private Sub studentsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()

    End Sub

    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM studentAdmission "
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cmbColumns.Text = "First_Name" Then

            Dim qry As String = "SELECT * FROM studentAdmission where First_Name like '" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()

        ElseIf cmbColumns.Text = "Student_ID" Then

            Dim qry As String = "SELECT * FROM studentAdmission where Student_ID like '" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()

        ElseIf cmbColumns.Text = "Last_Name" Then

            Dim qry As String = "SELECT * FROM studentAdmission where Last_Name like '" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()
        Else
            Dim qry As String = "SELECT * FROM studentAdmission where Student_ID like '" + txtSearch.Text.ToString() + "%'"
            Sqlcon.Open()
            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            studentDataGrid.DataSource = ds
            Sqlcon.Close()

        End If
    End Sub



End Class
