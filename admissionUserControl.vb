Imports System.Data.SqlClient
Imports System.IO
Public Class admissionUserControl
    Dim Sqlcon As New SqlConnection("Data Source=JAYTRON;Initial Catalog=VbProject;Integrated Security=True")
    Private Sub admissionUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCombo()

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


    Private Sub Clear()
        txtStudentID.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtOtherName.Text = String.Empty
        cmbGender.Text = ""
        dtpDOB.Value = Date.Now
        rtxtEmailAddress.Text = String.Empty
        rtxtResidentialAddress.Text = String.Empty
        txtHomePhone.Text = String.Empty
        txtMobilePhone.Text = String.Empty
        txtCity.Text = String.Empty
        txtRegionState.Text = String.Empty
        txtCountry.Text = String.Empty
        txtPostalCode.Text = String.Empty
        txtFatherName.Text = String.Empty
        txtFatherOccupation.Text = String.Empty
        txtMotherName.Text = String.Empty
        txtMotherOccupation.Text = String.Empty
        dtpRegDate.Value = Date.Now
        cmbLevel.Text = ""
        txtProgramme.Text = String.Empty
        cmbSession.Text = ""
    End Sub

    Private Sub UpdateCombo()
        cmbSearch.Items.Clear()

        Try
            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM studentAdmission"
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            While SQLReader.Read()
                cmbSearch.Items.Add(SQLReader.Item("ID"))

            End While
            Sqlcon.Close()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ms As New MemoryStream
        imageBox.Image.Save(ms, imageBox.Image.RawFormat)
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand
            com.CommandText = " INSERT INTO studentAdmission VALUES (" & txtStudentID.Text & ", '" & txtFirstName.Text & "', '" & txtLastName.Text & "',
            '" & txtOtherName.Text & "','" & cmbGender.SelectedItem & "', '" & dtpDOB.Value.ToString("dd MMMM,yyyy") & "' ,'" & rtxtEmailAddress.Text & "',
            '" & rtxtResidentialAddress.Text & "', '" & txtHomePhone.Text & "', '" & txtMobilePhone.Text & "','" & txtCity.Text & "',
           '" & txtRegionState.Text & "','" & txtCountry.Text & "', '" & txtPostalCode.Text & "','" & txtFatherName.Text & "','" & txtFatherOccupation.Text & "','" & txtMotherName.Text & "',
            '" & txtMotherOccupation.Text & "','" & dtpRegDate.Value.ToString("dd MMMM,yyyy") & "','" & cmbLevel.SelectedItem & "','" & txtProgramme.Text & "','" & cmbSession.SelectedItem & "',@img)"
            com.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
            If com.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Insertion was successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Sqlcon.Close()

        Catch ex As Exception
            MessageBox.Show("Student_ID Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateCombo()
    End Sub

    Private Sub btnAddNew_Click_1(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Clear()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show(" Select an ID and edit the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " UPDATE studentAdmission SET First_Name= '" & txtFirstName.Text & "', Last_Name='" & txtLastName.Text & "',Other_Name='" & txtOtherName.Text & "',Gender='" & cmbGender.SelectedItem & "', Date_0f_Birth='" & dtpDOB.Value.ToString("dd/MMMM/yyyy") & "' ,Email_Address='" & rtxtEmailAddress.Text & "',
                Residential_Address='" & rtxtResidentialAddress.Text & "', Home_Phone='" & txtHomePhone.Text & "', Mobile_Phone'" & txtMobilePhone.Text & "',City='" & txtCity.Text & "',
                Region/State='" & txtRegionState.Text & "',Country='" & txtCountry.Text & "', Zip/Postal_Code='" & txtPostalCode.Text & "',Father's_Name='" & txtFatherName.Text & "',Father's_Occupation='" & txtFatherOccupation.Text & "',Mother's_Name='" & txtMotherName.Text & "',
                Mother's_Occupation='" & txtMotherOccupation.Text & "',Registration_Date='" & dtpRegDate.Value.ToString("dd MMMM,yyyy") & "',Level='" & cmbLevel.SelectedItem & "',Programme='" & txtProgramme.Text & "',Session='" & cmbSession.SelectedItem & "' WHERE ID=" & txtStudentID.Text

                If com.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Record was edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Sqlcon.Close()
            Catch x As Exception
                MessageBox.Show("Error occured whiles editing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        UpdateCombo()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show(" Select an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim dr As New DialogResult
            dr = MessageBox.Show("Do you want to Delete the Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DialogResult.Yes Then
                Sqlcon.Open()
                Dim com As SqlCommand = Sqlcon.CreateCommand()
                com.CommandText = " DELETE FROM studentAdmission WHERE ID=" & txtStudentID.Text
                com.ExecuteNonQuery()
                Sqlcon.Close()
            End If
        End If
        UpdateCombo()
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        Try

            Sqlcon.Open()
            Dim com As SqlCommand = Sqlcon.CreateCommand()
            com.CommandText = " SELECT * FROM staffAdmission WHERE ID=" & cmbSearch.SelectedItem
            Dim SQLReader As SqlDataReader = com.ExecuteReader()

            SQLReader.Read()

            txtStudentID.Text = SQLReader.Item("Student_ID")
            txtFirstName.Text = SQLReader.Item("First_Name")
            txtLastName.Text = SQLReader.Item("Last_Name")
            txtOtherName.Text = SQLReader.Item("Other_Name")
            cmbGender.Text = SQLReader.Item("Gender")
            dtpDOB.Value = SQLReader.Item("Date_of_Birth")
            rtxtEmailAddress.Text = SQLReader.Item("Email_Address")
            rtxtResidentialAddress.Text = SQLReader.Item("Residential_Address")
            txtHomePhone.Text = SQLReader.Item("Home_Phone")
            txtMobilePhone.Text = SQLReader.Item("Mobile_Phone")
            txtCity.Text = SQLReader.Item("City")
            txtRegionState.Text = SQLReader.Item("Region/State")
            txtCountry.Text = SQLReader.Item("Country")
            txtPostalCode.Text = SQLReader.Item("Zip/Postal_Code")
            txtFatherName.Text = SQLReader.Item("Father's_Name")
            txtFatherOccupation.Text = SQLReader.Item("Father's_Occupation")
            txtMotherName.Text = SQLReader.Item("Mother's_Name")
            txtMotherOccupation.Text = SQLReader.Item("Mother's_Occupation")
            dtpRegDate.Value = SQLReader.Item("Registration_Date")
            cmbLevel.Text = SQLReader.Item("Level")
            txtProgramme.Text = SQLReader.Item("Programme")
            cmbSession.Text = SQLReader.Item("Session")

            Dim img() As Byte
            img = SQLReader.Item("Picture")
            Dim ms As New MemoryStream(img)
            imageBox.Image = Image.FromStream(ms)

            Sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(" Select an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
