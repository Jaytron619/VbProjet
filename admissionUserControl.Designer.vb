<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admissionUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admissionUserControl))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imageBox = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtOtherName = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.rtxtEmailAddress = New System.Windows.Forms.RichTextBox()
        Me.rtxtResidentialAddress = New System.Windows.Forms.RichTextBox()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtRegionState = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.txtFatherOccupation = New System.Windows.Forms.TextBox()
        Me.txtMotherName = New System.Windows.Forms.TextBox()
        Me.txtMotherOccupation = New System.Windows.Forms.TextBox()
        Me.dtpRegDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.txtProgramme = New System.Windows.Forms.TextBox()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 609)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 66)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.VbProjet.My.Resources.Resources.delete_25px
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(761, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(233, 44)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.VbProjet.My.Resources.Resources.update_file_25px
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(514, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(240, 44)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Update Record"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNew.Location = New System.Drawing.Point(255, 14)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(253, 44)
        Me.btnAddNew.TabIndex = 1
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(8, 14)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(239, 44)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 17)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Select An ID To Edit"
        '
        'btnUploadImage
        '
        Me.btnUploadImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadImage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUploadImage.Location = New System.Drawing.Point(778, 189)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(159, 32)
        Me.btnUploadImage.TabIndex = 22
        Me.btnUploadImage.Text = "Upload Image"
        Me.btnUploadImage.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(89, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 17)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Student ID"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 454)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Region/ State"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(82, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Occupation"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(753, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "City"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(75, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Father Name"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gender"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(426, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 515)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Registration Date"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(431, 401)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Mobile Phone"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Home Phone"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(519, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Other name"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "First Name"
        '
        'imageBox
        '
        Me.imageBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imageBox.Image = CType(resources.GetObject("imageBox.Image"), System.Drawing.Image)
        Me.imageBox.Location = New System.Drawing.Point(784, 44)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(143, 138)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageBox.TabIndex = 24
        Me.imageBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Email Address"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Residential Address"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(427, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Mother Name"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(464, 452)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 17)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Country"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(682, 450)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Zip/Postal Code"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(82, 554)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Programme"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(464, 547)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 17)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Session"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(467, 505)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 17)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Level"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(435, 311)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 17)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Occupation"
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(170, 194)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(122, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(379, 194)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(114, 22)
        Me.txtLastName.TabIndex = 2
        '
        'txtOtherName
        '
        Me.txtOtherName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOtherName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherName.Location = New System.Drawing.Point(609, 194)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(131, 22)
        Me.txtOtherName.TabIndex = 3
        '
        'cmbGender
        '
        Me.cmbGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(170, 239)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(122, 25)
        Me.cmbGender.TabIndex = 4
        '
        'dtpDOB
        '
        Me.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDOB.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Location = New System.Drawing.Point(525, 239)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(215, 22)
        Me.dtpDOB.TabIndex = 5
        '
        'rtxtEmailAddress
        '
        Me.rtxtEmailAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxtEmailAddress.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtEmailAddress.Location = New System.Drawing.Point(170, 347)
        Me.rtxtEmailAddress.Name = "rtxtEmailAddress"
        Me.rtxtEmailAddress.Size = New System.Drawing.Size(159, 39)
        Me.rtxtEmailAddress.TabIndex = 6
        Me.rtxtEmailAddress.Text = ""
        '
        'rtxtResidentialAddress
        '
        Me.rtxtResidentialAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxtResidentialAddress.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtResidentialAddress.Location = New System.Drawing.Point(522, 345)
        Me.rtxtResidentialAddress.Name = "rtxtResidentialAddress"
        Me.rtxtResidentialAddress.Size = New System.Drawing.Size(178, 39)
        Me.rtxtResidentialAddress.TabIndex = 7
        Me.rtxtResidentialAddress.Text = ""
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHomePhone.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomePhone.Location = New System.Drawing.Point(170, 403)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(138, 22)
        Me.txtHomePhone.TabIndex = 8
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMobilePhone.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilePhone.Location = New System.Drawing.Point(524, 399)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(139, 22)
        Me.txtMobilePhone.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(790, 402)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(147, 22)
        Me.txtCity.TabIndex = 10
        '
        'txtRegionState
        '
        Me.txtRegionState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRegionState.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegionState.Location = New System.Drawing.Point(168, 451)
        Me.txtRegionState.Name = "txtRegionState"
        Me.txtRegionState.Size = New System.Drawing.Size(140, 22)
        Me.txtRegionState.TabIndex = 11
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCountry.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(524, 449)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(139, 22)
        Me.txtCountry.TabIndex = 12
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPostalCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(790, 447)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(147, 22)
        Me.txtPostalCode.TabIndex = 13
        '
        'txtFatherName
        '
        Me.txtFatherName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFatherName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherName.Location = New System.Drawing.Point(170, 275)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(163, 22)
        Me.txtFatherName.TabIndex = 14
        '
        'txtFatherOccupation
        '
        Me.txtFatherOccupation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFatherOccupation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherOccupation.Location = New System.Drawing.Point(170, 310)
        Me.txtFatherOccupation.Name = "txtFatherOccupation"
        Me.txtFatherOccupation.Size = New System.Drawing.Size(161, 22)
        Me.txtFatherOccupation.TabIndex = 16
        '
        'txtMotherName
        '
        Me.txtMotherName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMotherName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherName.Location = New System.Drawing.Point(523, 273)
        Me.txtMotherName.Name = "txtMotherName"
        Me.txtMotherName.Size = New System.Drawing.Size(177, 22)
        Me.txtMotherName.TabIndex = 15
        '
        'txtMotherOccupation
        '
        Me.txtMotherOccupation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMotherOccupation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherOccupation.Location = New System.Drawing.Point(521, 308)
        Me.txtMotherOccupation.Name = "txtMotherOccupation"
        Me.txtMotherOccupation.Size = New System.Drawing.Size(179, 22)
        Me.txtMotherOccupation.TabIndex = 17
        '
        'dtpRegDate
        '
        Me.dtpRegDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpRegDate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDate.Location = New System.Drawing.Point(167, 510)
        Me.dtpRegDate.Name = "dtpRegDate"
        Me.dtpRegDate.Size = New System.Drawing.Size(220, 22)
        Me.dtpRegDate.TabIndex = 18
        '
        'cmbLevel
        '
        Me.cmbLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbLevel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.cmbLevel.Location = New System.Drawing.Point(525, 497)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(124, 25)
        Me.cmbLevel.TabIndex = 19
        '
        'txtProgramme
        '
        Me.txtProgramme.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProgramme.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgramme.Location = New System.Drawing.Point(167, 549)
        Me.txtProgramme.Name = "txtProgramme"
        Me.txtProgramme.Size = New System.Drawing.Size(220, 22)
        Me.txtProgramme.TabIndex = 20
        '
        'cmbSession
        '
        Me.cmbSession.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbSession.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Items.AddRange(New Object() {"Regular", "Weekend", "Distance"})
        Me.cmbSession.Location = New System.Drawing.Point(525, 544)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(179, 25)
        Me.cmbSession.TabIndex = 21
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStudentID.BackColor = System.Drawing.Color.White
        Me.txtStudentID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(166, 128)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(114, 22)
        Me.txtStudentID.TabIndex = 0
        '
        'cmbSearch
        '
        Me.cmbSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(164, 11)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(130, 25)
        Me.cmbSearch.TabIndex = 23
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(395, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(195, 23)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "STUDENT ADMISSION"
        '
        'admissionUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.cmbSession)
        Me.Controls.Add(Me.txtProgramme)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.dtpRegDate)
        Me.Controls.Add(Me.txtMotherOccupation)
        Me.Controls.Add(Me.txtMotherName)
        Me.Controls.Add(Me.txtFatherOccupation)
        Me.Controls.Add(Me.txtFatherName)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtRegionState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtMobilePhone)
        Me.Controls.Add(Me.txtHomePhone)
        Me.Controls.Add(Me.rtxtResidentialAddress)
        Me.Controls.Add(Me.rtxtEmailAddress)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtOtherName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnUploadImage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.imageBox)
        Me.Controls.Add(Me.Label16)
        Me.Name = "admissionUserControl"
        Me.Size = New System.Drawing.Size(1000, 675)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents imageBox As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtOtherName As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents rtxtEmailAddress As RichTextBox
    Friend WithEvents rtxtResidentialAddress As RichTextBox
    Friend WithEvents txtHomePhone As TextBox
    Friend WithEvents txtMobilePhone As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtRegionState As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents txtFatherName As TextBox
    Friend WithEvents txtFatherOccupation As TextBox
    Friend WithEvents txtMotherName As TextBox
    Friend WithEvents txtMotherOccupation As TextBox
    Friend WithEvents dtpRegDate As DateTimePicker
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents txtProgramme As TextBox
    Friend WithEvents cmbSession As ComboBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Label24 As Label
End Class
