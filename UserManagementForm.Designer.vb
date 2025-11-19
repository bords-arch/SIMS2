<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserManagementForm
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
        txtCourseName = New TextBox()
        txtCourseDescription = New TextBox()
        txtUnits = New TextBox()
        btnAddCourse = New Button()
        btnUpdateCourse = New Button()
        btnDeleteCourse = New Button()
        btnSaveCourse = New Button()
        dgvCourseList = New DataGridView()
        CType(dgvCourseList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(26, 12)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(356, 27)
        txtCourseName.TabIndex = 0
        ' 
        ' txtCourseDescription
        ' 
        txtCourseDescription.Location = New Point(437, 12)
        txtCourseDescription.Name = "txtCourseDescription"
        txtCourseDescription.Size = New Size(356, 27)
        txtCourseDescription.TabIndex = 1
        ' 
        ' txtUnits
        ' 
        txtUnits.Location = New Point(216, 77)
        txtUnits.Name = "txtUnits"
        txtUnits.Size = New Size(356, 27)
        txtUnits.TabIndex = 2
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.Location = New Point(26, 155)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(207, 36)
        btnAddCourse.TabIndex = 3
        btnAddCourse.Text = "Add Course"
        btnAddCourse.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateCourse
        ' 
        btnUpdateCourse.Location = New Point(266, 156)
        btnUpdateCourse.Name = "btnUpdateCourse"
        btnUpdateCourse.Size = New Size(167, 35)
        btnUpdateCourse.TabIndex = 4
        btnUpdateCourse.Text = "Update Course"
        btnUpdateCourse.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteCourse
        ' 
        btnDeleteCourse.Location = New Point(467, 156)
        btnDeleteCourse.Name = "btnDeleteCourse"
        btnDeleteCourse.Size = New Size(165, 34)
        btnDeleteCourse.TabIndex = 5
        btnDeleteCourse.Text = "Delete Course"
        btnDeleteCourse.UseVisualStyleBackColor = True
        ' 
        ' btnSaveCourse
        ' 
        btnSaveCourse.Location = New Point(675, 156)
        btnSaveCourse.Name = "btnSaveCourse"
        btnSaveCourse.Size = New Size(213, 35)
        btnSaveCourse.TabIndex = 6
        btnSaveCourse.Text = "Save Course"
        btnSaveCourse.UseVisualStyleBackColor = True
        ' 
        ' dgvCourseList
        ' 
        dgvCourseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourseList.Location = New Point(28, 245)
        dgvCourseList.Name = "dgvCourseList"
        dgvCourseList.RowHeadersWidth = 51
        dgvCourseList.Size = New Size(1041, 391)
        dgvCourseList.TabIndex = 7
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1088, 644)
        Controls.Add(dgvCourseList)
        Controls.Add(btnSaveCourse)
        Controls.Add(btnDeleteCourse)
        Controls.Add(btnUpdateCourse)
        Controls.Add(btnAddCourse)
        Controls.Add(txtUnits)
        Controls.Add(txtCourseDescription)
        Controls.Add(txtCourseName)
        Name = "Form4"
        Text = "Form4"
        CType(dgvCourseList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCourseDescription As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnUpdateCourse As Button
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents btnSaveCourse As Button
    Friend WithEvents dgvCourseList As DataGridView
End Class
