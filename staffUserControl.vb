Imports System.Data.SqlClient
Imports System.IO
Public Class staffUserControl
    Dim Sqlcon As New SqlConnection("Data Source=JAYTRON;Initial Catalog=VbProject;Integrated Security=True")
    Private Sub staffUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrid()
        UpdateCombo()

    End Sub

    Private Sub UpdateGrid()

        Try
            Dim qry As String = "SELECT * FROM staffAdmission "
            Sqlcon.Open()

            Dim ad As New SqlDataAdapter(qry, Sqlcon)
            Dim ds As New DataTable()
            ad.Fill(ds)
            staffDataGrid.DataSource = ds

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Dim imageLocation As String
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click

        Try
            Dim dialog As New OpenFileDialog()
            dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All files (*.*)|*.*"
            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                imageLocation = dialog.FileName
                imageBox.ImageLocation = imageLocation
            End If
        Catch ex As Exception
            MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateCombo()
        cmbID.Items.Clear()

        Try
            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM staffAdmission"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                cmbID.Items.Add(SQLReader.Item("ID"))

            End While
            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(" Select an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Clear()
        txtID.Text = String.Empty
        txtFIrstName.Text = String.Empty
        txtLastName.Text = String.Empty
        cmbGender.Text = ""
        txtQualification.Text = String.Empty
        dtpDateEmployed.Value = Date.Now
        txtCourseAssigned1.Text = String.Empty
        txtCourseAssigned2.Text = String.Empty
        txtCourseAssigned3.Text = String.Empty

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtID.Text = "" And txtFIrstName.Text = "" And txtLastName.Text = "" And txtQualification.Text = "" And txtCourseAssigned1.Text = "" And txtCourseAssigned2.Text = "" And txtCourseAssigned3.Text = "" Then
            MessageBox.Show("Fill in the spaces provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim ms As New MemoryStream
            imageBox.Image.Save(ms, imageBox.Image.RawFormat)
            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand
                com.CommandText = " INSERT INTO staffAdmission VALUES (" & txtID.Text & ", '" & txtFIrstName.Text & "', 
            '" & txtLastName.Text & "','" & cmbGender.SelectedItem & "', '" & txtQualification.Text & "', '" & dtpDateEmployed.Value.ToString("dd MMMM,yyyy") & "'
            , '" & txtCourseAssigned1.Text & "', '" & txtCourseAssigned2.Text & "', '" & txtCourseAssigned3.Text & "', @img)"
                com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()

            Catch ex As Exception
                MessageBox.Show("ID Already Exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            UpdateGrid()
            UpdateCombo()

        End If
    End Sub

    Private Sub btnAddNew_Click_1(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Clear()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtID.Text = "" Then
            MessageBox.Show(" Select an ID and edit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE staffAdmission SET First_Name= '" & txtFIrstName.Text & "', Last_Name='" & txtLastName.Text & "',Gender= '" & cmbGender.SelectedItem & "',Qualification= '" & txtQualification.Text & "',
            Date_Employed='" & dtpDateEmployed.Value.ToString("dd MMMM,yyyy") & "', Course_Assigned_1='" & txtCourseAssigned1.Text & "',
            Course_Assigned_2='" & txtCourseAssigned2.Text & "', Course_Assigned_3='" & txtCourseAssigned3.Text & "' WHERE ID=" & txtID.Text

                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record was edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
            Catch x As Exception
                MessageBox.Show("Error occured whiles editing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        UpdateGrid()
        UpdateCombo()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = "" Then
            MessageBox.Show(" Select an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As New DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DialogResult.Yes Then
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " DELETE FROM staffAdmission WHERE ID=" & txtID.Text
                com.ExecuteNonQuery()
                Sqlcon.Close()

            End If

        End If
        UpdateGrid()
        UpdateCombo()

    End Sub

    Private Sub txtSearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim qry As String = "SELECT * FROM staffAdmission where First_Name like '%" + txtSearch.Text + "%'"
        Sqlcon.Open()
        Dim ad As New SqlDataAdapter(qry, Sqlcon)
        Dim ds As New DataTable()
        ad.Fill(ds)
        staffDataGrid.DataSource = ds
        Sqlcon.Close()
    End Sub

    Private Sub cmbID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbID.SelectedIndexChanged
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM staffAdmission WHERE ID=" & cmbID.SelectedItem
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()
            txtID.Text = SQLReader.Item("ID")
            txtFIrstName.Text = SQLReader.Item("First_Name")
            txtLastName.Text = SQLReader.Item("Last_Name")
            cmbGender.Text = SQLReader.Item("Gender")
            txtQualification.Text = SQLReader.Item("Qualification")
            dtpDateEmployed.Value = SQLReader.Item("Date_Employed")
            txtCourseAssigned1.Text = SQLReader.Item("Course_Assigned_1")
            txtCourseAssigned2.Text = SQLReader.Item("Course_Assigned_2")
            txtCourseAssigned3.Text = SQLReader.Item("Course_Assigned_3")
            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            imageBox.Image = Image.FromStream(ms)

            Sqlcon.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
