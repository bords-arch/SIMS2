<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseManagementForm
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
        btnAddCourse = New Button()
        txtCourseName = New TextBox()
        txtUnits = New TextBox()
        btnUpdateCourse = New Button()
        btnDeleteCourse = New Button()
        dgvCourseList = New DataGridView()
        CType(dgvCourseList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.Location = New Point(98, 52)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(126, 49)
        btnAddCourse.TabIndex = 0
        btnAddCourse.Text = "Button1"
        btnAddCourse.UseVisualStyleBackColor = True
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(283, 84)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(117, 27)
        txtCourseName.TabIndex = 1
        ' 
        ' txtUnits
        ' 
        txtUnits.Location = New Point(181, 147)
        txtUnits.Name = "txtUnits"
        txtUnits.Size = New Size(172, 27)
        txtUnits.TabIndex = 2
        ' 
        ' btnUpdateCourse
        ' 
        btnUpdateCourse.Location = New Point(580, 105)
        btnUpdateCourse.Name = "btnUpdateCourse"
        btnUpdateCourse.Size = New Size(101, 48)
        btnUpdateCourse.TabIndex = 3
        btnUpdateCourse.Text = "Button1"
        btnUpdateCourse.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteCourse
        ' 
        btnDeleteCourse.Location = New Point(428, 161)
        btnDeleteCourse.Name = "btnDeleteCourse"
        btnDeleteCourse.Size = New Size(111, 46)
        btnDeleteCourse.TabIndex = 4
        btnDeleteCourse.Text = "Button1"
        btnDeleteCourse.UseVisualStyleBackColor = True
        ' 
        ' dgvCourseList
        ' 
        dgvCourseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourseList.Location = New Point(25, 300)
        dgvCourseList.Name = "dgvCourseList"
        dgvCourseList.RowHeadersWidth = 51
        dgvCourseList.Size = New Size(909, 196)
        dgvCourseList.TabIndex = 5
        ' 
        ' CourseManagementForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(983, 511)
        Controls.Add(dgvCourseList)
        Controls.Add(btnDeleteCourse)
        Controls.Add(btnUpdateCourse)
        Controls.Add(txtUnits)
        Controls.Add(txtCourseName)
        Controls.Add(btnAddCourse)
        Name = "CourseManagementForm"
        Text = "CourseManagementForm"
        CType(dgvCourseList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddCourse As Button
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnUpdateCourse As Button
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents dgvCourseList As DataGridView
End Class
