<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        btnUserManagement = New Button()
        btnStudentManagement = New Button()
        btnCourseManagement = New Button()
        btnGradeManagement = New Button()
        btnEnrollmentManagement = New Button()
        btnGenerateReports = New Button()
        lblLoggedInUser = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnUserManagement
        ' 
        btnUserManagement.Location = New Point(45, 44)
        btnUserManagement.Name = "btnUserManagement"
        btnUserManagement.Size = New Size(175, 42)
        btnUserManagement.TabIndex = 0
        btnUserManagement.Text = "User Management"
        btnUserManagement.UseVisualStyleBackColor = True
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.Location = New Point(45, 127)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.Size = New Size(175, 48)
        btnStudentManagement.TabIndex = 1
        btnStudentManagement.Text = "Student Management"
        btnStudentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnCourseManagement
        ' 
        btnCourseManagement.Location = New Point(45, 211)
        btnCourseManagement.Name = "btnCourseManagement"
        btnCourseManagement.Size = New Size(175, 47)
        btnCourseManagement.TabIndex = 2
        btnCourseManagement.Text = "Course Management"
        btnCourseManagement.UseVisualStyleBackColor = True
        ' 
        ' btnGradeManagement
        ' 
        btnGradeManagement.Location = New Point(45, 383)
        btnGradeManagement.Name = "btnGradeManagement"
        btnGradeManagement.Size = New Size(175, 51)
        btnGradeManagement.TabIndex = 3
        btnGradeManagement.Text = "Grade Management"
        btnGradeManagement.UseVisualStyleBackColor = True
        ' 
        ' btnEnrollmentManagement
        ' 
        btnEnrollmentManagement.Location = New Point(45, 300)
        btnEnrollmentManagement.Name = "btnEnrollmentManagement"
        btnEnrollmentManagement.Size = New Size(175, 55)
        btnEnrollmentManagement.TabIndex = 4
        btnEnrollmentManagement.Text = "Enrollment Management"
        btnEnrollmentManagement.UseVisualStyleBackColor = True
        ' 
        ' btnGenerateReports
        ' 
        btnGenerateReports.Location = New Point(45, 458)
        btnGenerateReports.Name = "btnGenerateReports"
        btnGenerateReports.Size = New Size(175, 55)
        btnGenerateReports.TabIndex = 6
        btnGenerateReports.Text = "Generate Reports"
        btnGenerateReports.UseVisualStyleBackColor = True
        ' 
        ' lblLoggedInUser
        ' 
        lblLoggedInUser.AutoSize = True
        lblLoggedInUser.Location = New Point(58, 9)
        lblLoggedInUser.Name = "lblLoggedInUser"
        lblLoggedInUser.Size = New Size(0, 20)
        lblLoggedInUser.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(449, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 8
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 647)
        Controls.Add(Label1)
        Controls.Add(lblLoggedInUser)
        Controls.Add(btnGenerateReports)
        Controls.Add(btnEnrollmentManagement)
        Controls.Add(btnGradeManagement)
        Controls.Add(btnCourseManagement)
        Controls.Add(btnStudentManagement)
        Controls.Add(btnUserManagement)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnStudentManagement As Button
    Friend WithEvents btnCourseManagement As Button
    Friend WithEvents btnGradeManagement As Button
    Friend WithEvents btnEnrollmentManagement As Button
    Friend WithEvents btnGenerateReports As Button
    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents Label1 As Label
End Class
