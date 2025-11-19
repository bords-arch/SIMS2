<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeManagementForm
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
        cmbGradeStudent = New ComboBox()
        cmbGradeCourse = New ComboBox()
        txtMidtermGrade = New TextBox()
        txtFinalGrade = New TextBox()
        btnSaveGrade = New Button()
        txtRemarks = New TextBox()
        SuspendLayout()
        ' 
        ' cmbGradeStudent
        ' 
        cmbGradeStudent.FormattingEnabled = True
        cmbGradeStudent.Location = New Point(85, 44)
        cmbGradeStudent.Name = "cmbGradeStudent"
        cmbGradeStudent.Size = New Size(223, 28)
        cmbGradeStudent.TabIndex = 0
        ' 
        ' cmbGradeCourse
        ' 
        cmbGradeCourse.FormattingEnabled = True
        cmbGradeCourse.Location = New Point(82, 106)
        cmbGradeCourse.Name = "cmbGradeCourse"
        cmbGradeCourse.Size = New Size(228, 28)
        cmbGradeCourse.TabIndex = 1
        ' 
        ' txtMidtermGrade
        ' 
        txtMidtermGrade.Location = New Point(424, 51)
        txtMidtermGrade.Name = "txtMidtermGrade"
        txtMidtermGrade.Size = New Size(210, 27)
        txtMidtermGrade.TabIndex = 2
        ' 
        ' txtFinalGrade
        ' 
        txtFinalGrade.Location = New Point(412, 117)
        txtFinalGrade.Name = "txtFinalGrade"
        txtFinalGrade.Size = New Size(223, 27)
        txtFinalGrade.TabIndex = 3
        ' 
        ' btnSaveGrade
        ' 
        btnSaveGrade.Location = New Point(757, 67)
        btnSaveGrade.Name = "btnSaveGrade"
        btnSaveGrade.Size = New Size(145, 65)
        btnSaveGrade.TabIndex = 4
        btnSaveGrade.Text = "Save Grade"
        btnSaveGrade.UseVisualStyleBackColor = True
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(409, 184)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(227, 27)
        txtRemarks.TabIndex = 5
        ' 
        ' GradeManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1099, 635)
        Controls.Add(txtRemarks)
        Controls.Add(btnSaveGrade)
        Controls.Add(txtFinalGrade)
        Controls.Add(txtMidtermGrade)
        Controls.Add(cmbGradeCourse)
        Controls.Add(cmbGradeStudent)
        Name = "GradeManagementForm"
        Text = "GradeManagement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbGradeStudent As ComboBox
    Friend WithEvents cmbGradeCourse As ComboBox
    Friend WithEvents txtMidtermGrade As TextBox
    Friend WithEvents txtFinalGrade As TextBox
    Friend WithEvents btnSaveGrade As Button
    Friend WithEvents txtRemarks As TextBox
End Class
