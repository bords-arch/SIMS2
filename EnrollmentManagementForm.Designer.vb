<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnrollmentManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmbStudent = New ComboBox()
        cmbCourse = New ComboBox()
        btnEnrollStudent = New Button()
        btnUpdateEnrollment = New Button()
        btnDeleteEnrollment = New Button()
        dgvEnrollmentList = New DataGridView()
        CType(dgvEnrollmentList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbStudent
        ' 
        cmbStudent.FormattingEnabled = True
        cmbStudent.Location = New Point(42, 27)
        cmbStudent.Name = "cmbStudent"
        cmbStudent.Size = New Size(242, 28)
        cmbStudent.TabIndex = 0
        ' 
        ' cmbCourse
        ' 
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(40, 85)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(246, 28)
        cmbCourse.TabIndex = 1
        ' 
        ' btnEnrollStudent
        ' 
        btnEnrollStudent.Location = New Point(355, 36)
        btnEnrollStudent.Name = "btnEnrollStudent"
        btnEnrollStudent.Size = New Size(134, 53)
        btnEnrollStudent.TabIndex = 2
        btnEnrollStudent.Text = "Enroll Student"
        btnEnrollStudent.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEnrollment
        ' 
        btnUpdateEnrollment.Location = New Point(517, 36)
        btnUpdateEnrollment.Name = "btnUpdateEnrollment"
        btnUpdateEnrollment.Size = New Size(138, 53)
        btnUpdateEnrollment.TabIndex = 3
        btnUpdateEnrollment.Text = "Update Enrollment"
        btnUpdateEnrollment.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteEnrollment
        ' 
        btnDeleteEnrollment.Location = New Point(695, 36)
        btnDeleteEnrollment.Name = "btnDeleteEnrollment"
        btnDeleteEnrollment.Size = New Size(142, 53)
        btnDeleteEnrollment.TabIndex = 4
        btnDeleteEnrollment.Text = "Delete Enrollment"
        btnDeleteEnrollment.UseVisualStyleBackColor = True
        ' 
        ' dgvEnrollmentList
        ' 
        dgvEnrollmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEnrollmentList.Location = New Point(38, 164)
        dgvEnrollmentList.Name = "dgvEnrollmentList"
        dgvEnrollmentList.RowHeadersWidth = 51
        dgvEnrollmentList.Size = New Size(1009, 439)
        dgvEnrollmentList.TabIndex = 5
        ' 
        ' EnrollmentManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 635)
        Controls.Add(dgvEnrollmentList)
        Controls.Add(btnDeleteEnrollment)
        Controls.Add(btnUpdateEnrollment)
        Controls.Add(btnEnrollStudent)
        Controls.Add(cmbCourse)
        Controls.Add(cmbStudent)
        Name = "EnrollmentManagementForm"
        Text = "EnrollmentManagementForm"
        CType(dgvEnrollmentList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents btnEnrollStudent As Button
    Friend WithEvents btnUpdateEnrollment As Button
    Friend WithEvents btnDeleteEnrollment As Button
    Friend WithEvents dgvEnrollmentList As DataGridView
End Class
