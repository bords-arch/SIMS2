<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentManagementForm
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
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtAddress = New TextBox()
        txtContactNo = New TextBox()
        dtpBirthDate = New DateTimePicker()
        cmbGender = New ComboBox()
        btnAddStudent = New Button()
        btnUpdateStudent = New Button()
        btnDeleteStudent = New Button()
        btnSaveStudent = New Button()
        dgvStudentList = New DataGridView()
        CType(dgvStudentList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(67, 22)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(156, 27)
        txtFirstName.TabIndex = 0
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(67, 79)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(156, 27)
        txtLastName.TabIndex = 1
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(67, 139)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(156, 27)
        txtAddress.TabIndex = 2
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Location = New Point(67, 192)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(156, 27)
        txtContactNo.TabIndex = 3
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Location = New Point(293, 22)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(239, 27)
        dtpBirthDate.TabIndex = 4
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(572, 24)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(175, 28)
        cmbGender.TabIndex = 5
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Location = New Point(192, 529)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(192, 60)
        btnAddStudent.TabIndex = 6
        btnAddStudent.Text = "Save Student"
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateStudent
        ' 
        btnUpdateStudent.Location = New Point(854, 535)
        btnUpdateStudent.Name = "btnUpdateStudent"
        btnUpdateStudent.Size = New Size(160, 49)
        btnUpdateStudent.TabIndex = 7
        btnUpdateStudent.Text = "Update Student"
        btnUpdateStudent.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteStudent
        ' 
        btnDeleteStudent.Location = New Point(654, 536)
        btnDeleteStudent.Name = "btnDeleteStudent"
        btnDeleteStudent.Size = New Size(171, 53)
        btnDeleteStudent.TabIndex = 8
        btnDeleteStudent.Text = "Delete Student"
        btnDeleteStudent.UseVisualStyleBackColor = True
        ' 
        ' btnSaveStudent
        ' 
        btnSaveStudent.Location = New Point(431, 533)
        btnSaveStudent.Name = "btnSaveStudent"
        btnSaveStudent.Size = New Size(150, 59)
        btnSaveStudent.TabIndex = 9
        btnSaveStudent.Text = "Save Student"
        btnSaveStudent.UseVisualStyleBackColor = True
        ' 
        ' dgvStudentList
        ' 
        dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudentList.Location = New Point(285, 101)
        dgvStudentList.Name = "dgvStudentList"
        dgvStudentList.RowHeadersWidth = 51
        dgvStudentList.Size = New Size(725, 394)
        dgvStudentList.TabIndex = 10
        ' 
        ' StudentManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 640)
        Controls.Add(dgvStudentList)
        Controls.Add(btnSaveStudent)
        Controls.Add(btnDeleteStudent)
        Controls.Add(btnUpdateStudent)
        Controls.Add(btnAddStudent)
        Controls.Add(cmbGender)
        Controls.Add(dtpBirthDate)
        Controls.Add(txtContactNo)
        Controls.Add(txtAddress)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Name = "StudentManagementForm"
        Text = "StudentManagementForm"
        CType(dgvStudentList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnUpdateStudent As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnSaveStudent As Button
    Friend WithEvents dgvStudentList As DataGridView
End Class
