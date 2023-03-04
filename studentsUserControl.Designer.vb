<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentsUserControl
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
        Me.studentDataGrid = New System.Windows.Forms.DataGridView()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbColumns = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.studentDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentDataGrid
        '
        Me.studentDataGrid.AllowUserToAddRows = False
        Me.studentDataGrid.AllowUserToDeleteRows = False
        Me.studentDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentDataGrid.Location = New System.Drawing.Point(3, 110)
        Me.studentDataGrid.Name = "studentDataGrid"
        Me.studentDataGrid.ReadOnly = True
        Me.studentDataGrid.RowHeadersVisible = False
        Me.studentDataGrid.Size = New System.Drawing.Size(994, 562)
        Me.studentDataGrid.TabIndex = 0
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(423, 10)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(128, 19)
        Me.MaterialLabel1.TabIndex = 8
        Me.MaterialLabel1.Text = "STUDENTS DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbColumns
        '
        Me.cmbColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbColumns.FormattingEnabled = True
        Me.cmbColumns.ItemHeight = 13
        Me.cmbColumns.Items.AddRange(New Object() {"Student_ID", "First_Name", "Last_Name"})
        Me.cmbColumns.Location = New System.Drawing.Point(15, 75)
        Me.cmbColumns.Name = "cmbColumns"
        Me.cmbColumns.Size = New System.Drawing.Size(199, 21)
        Me.cmbColumns.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(220, 75)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(203, 20)
        Me.txtSearch.TabIndex = 11
        '
        'studentsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbColumns)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.studentDataGrid)
        Me.Name = "studentsUserControl"
        Me.Size = New System.Drawing.Size(1000, 675)
        CType(Me.studentDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentDataGrid As DataGridView
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbColumns As ComboBox
    Friend WithEvents txtSearch As TextBox
End Class
