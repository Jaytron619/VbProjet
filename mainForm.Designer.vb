<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Logo1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.btnFees = New System.Windows.Forms.Button()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnLevel = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnAdmission = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.topPanel.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidePanel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.topPanel.Controls.Add(Me.lblLogOut)
        Me.topPanel.Controls.Add(Me.Label1)
        Me.topPanel.Controls.Add(Me.PictureBox6)
        Me.topPanel.Controls.Add(Me.PictureBox2)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(1200, 45)
        Me.topPanel.TabIndex = 0
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLogOut.Location = New System.Drawing.Point(1089, 12)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(55, 17)
        Me.lblLogOut.TabIndex = 10
        Me.lblLogOut.Text = "Log Out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(47, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SCHOOL MANAGEMENT SYSTEM"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.VbProjet.My.Resources.Resources.school_25px1
        Me.PictureBox6.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1163, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.btnLibrary)
        Me.sidePanel.Controls.Add(Me.btnFees)
        Me.sidePanel.Controls.Add(Me.btnCourses)
        Me.sidePanel.Controls.Add(Me.btnLevel)
        Me.sidePanel.Controls.Add(Me.btnStaff)
        Me.sidePanel.Controls.Add(Me.btnStudents)
        Me.sidePanel.Controls.Add(Me.btnAdmission)
        Me.sidePanel.Controls.Add(Me.btnHome)
        Me.sidePanel.Controls.Add(Me.PictureBox5)
        Me.sidePanel.Controls.Add(Me.Logo1)
        Me.sidePanel.Controls.Add(Me.PictureBox4)
        Me.sidePanel.Controls.Add(Me.PictureBox3)
        Me.sidePanel.Controls.Add(Me.PictureBox1)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 45)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(200, 675)
        Me.sidePanel.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(170, 624)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Logo1
        '
        Me.Logo1.Image = CType(resources.GetObject("Logo1.Image"), System.Drawing.Image)
        Me.Logo1.Location = New System.Drawing.Point(12, 18)
        Me.Logo1.Name = "Logo1"
        Me.Logo1.Size = New System.Drawing.Size(146, 77)
        Me.Logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo1.TabIndex = 7
        Me.Logo1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(102, 624)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VbProjet.My.Resources.Resources.instagram_25px
        Me.PictureBox3.Location = New System.Drawing.Point(136, 624)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(172, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(200, 45)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1000, 675)
        Me.contentPanel.TabIndex = 2
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.topPanel
        '
        'btnLibrary
        '
        Me.btnLibrary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLibrary.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLibrary.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibrary.ForeColor = System.Drawing.Color.White
        Me.btnLibrary.Image = Global.VbProjet.My.Resources.Resources.book_shelf_25px1
        Me.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLibrary.Location = New System.Drawing.Point(-3, 443)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(205, 37)
        Me.btnLibrary.TabIndex = 25
        Me.btnLibrary.Text = "Library"
        Me.btnLibrary.UseVisualStyleBackColor = False
        '
        'btnFees
        '
        Me.btnFees.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnFees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFees.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFees.ForeColor = System.Drawing.Color.White
        Me.btnFees.Image = CType(resources.GetObject("btnFees.Image"), System.Drawing.Image)
        Me.btnFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFees.Location = New System.Drawing.Point(-3, 408)
        Me.btnFees.Name = "btnFees"
        Me.btnFees.Size = New System.Drawing.Size(205, 37)
        Me.btnFees.TabIndex = 24
        Me.btnFees.Text = "Fees"
        Me.btnFees.UseVisualStyleBackColor = False
        '
        'btnCourses
        '
        Me.btnCourses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCourses.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourses.ForeColor = System.Drawing.Color.White
        Me.btnCourses.Image = CType(resources.GetObject("btnCourses.Image"), System.Drawing.Image)
        Me.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourses.Location = New System.Drawing.Point(-3, 371)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(205, 37)
        Me.btnCourses.TabIndex = 23
        Me.btnCourses.Text = "Courses"
        Me.btnCourses.UseVisualStyleBackColor = False
        '
        'btnLevel
        '
        Me.btnLevel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel.ForeColor = System.Drawing.Color.White
        Me.btnLevel.Image = CType(resources.GetObject("btnLevel.Image"), System.Drawing.Image)
        Me.btnLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLevel.Location = New System.Drawing.Point(-2, 334)
        Me.btnLevel.Name = "btnLevel"
        Me.btnLevel.Size = New System.Drawing.Size(205, 37)
        Me.btnLevel.TabIndex = 22
        Me.btnLevel.Text = "Level"
        Me.btnLevel.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaff.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.White
        Me.btnStaff.Image = CType(resources.GetObject("btnStaff.Image"), System.Drawing.Image)
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(-3, 299)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(205, 37)
        Me.btnStaff.TabIndex = 21
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnStudents
        '
        Me.btnStudents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudents.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.ForeColor = System.Drawing.Color.White
        Me.btnStudents.Image = CType(resources.GetObject("btnStudents.Image"), System.Drawing.Image)
        Me.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudents.Location = New System.Drawing.Point(-3, 262)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(205, 37)
        Me.btnStudents.TabIndex = 20
        Me.btnStudents.Text = "Students"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnAdmission
        '
        Me.btnAdmission.AccessibleDescription = ""
        Me.btnAdmission.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmission.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmission.ForeColor = System.Drawing.Color.White
        Me.btnAdmission.Image = CType(resources.GetObject("btnAdmission.Image"), System.Drawing.Image)
        Me.btnAdmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmission.Location = New System.Drawing.Point(-3, 228)
        Me.btnAdmission.Name = "btnAdmission"
        Me.btnAdmission.Size = New System.Drawing.Size(205, 37)
        Me.btnAdmission.TabIndex = 19
        Me.btnAdmission.Text = "Admission"
        Me.btnAdmission.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(-3, 194)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(205, 37)
        Me.btnHome.TabIndex = 18
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.topPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm"
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidePanel.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topPanel As Panel
    Friend WithEvents sidePanel As Panel
    Friend WithEvents contentPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Logo1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnLibrary As Button
    Friend WithEvents btnFees As Button
    Friend WithEvents btnCourses As Button
    Friend WithEvents btnLevel As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnAdmission As Button
    Friend WithEvents btnHome As Button
End Class
