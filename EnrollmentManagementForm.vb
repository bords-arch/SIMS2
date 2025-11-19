Public Class EnrollmentManagementForm
    Private students As New List(Of Student)()
    Private courses As New List(Of Course)()
    Private enrollments As New List(Of Enrollment)()
    Private selectedEnrollment As Enrollment = Nothing

    ' Load students, courses, and enrollment data on form load
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example data - in a real application, load this from a database
        students.Add(New Student() With {.ID = 1, .Name = "John Doe"})
        students.Add(New Student() With {.ID = 2, .Name = "Jane Smith"})
        courses.Add(New Course() With {.ID = 101, .Name = "Math 101"})
        courses.Add(New Course() With {.ID = 102, .Name = "Science 101"})

        ' Bind the ComboBoxes to students and courses
        cmbStudent.DataSource = students
        cmbStudent.DisplayMember = "Name"
        cmbStudent.ValueMember = "ID"

        cmbCourse.DataSource = courses
        cmbCourse.DisplayMember = "Name"
        cmbCourse.ValueMember = "ID"

        ' Refresh the Enrollment list in DataGridView
        RefreshEnrollmentList()
    End Sub

    ' Enroll a student in a course
    Private Sub btnEnrollStudent_Click(sender As Object, e As EventArgs) Handles btnEnrollStudent.Click
        If cmbStudent.SelectedIndex = -1 Or cmbCourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select both a student and a course.")
            Return
        End If

        Dim selectedStudent As Student = CType(cmbStudent.SelectedItem, Student)
        Dim selectedCourse As Course = CType(cmbCourse.SelectedItem, Course)

        ' Check if the student is already enrolled in the course
        If enrollments.Any(Function(enrollmentItem) enrollmentItem.StudentID = selectedStudent.ID AndAlso enrollmentItem.CourseID = selectedCourse.ID) Then
            MessageBox.Show("This student is already enrolled in this course.")
            Return
        End If

        ' Add new enrollment
        Dim enrollment As New Enrollment() With {
            .StudentID = selectedStudent.ID,
            .CourseID = selectedCourse.ID,
            .StudentName = selectedStudent.Name,
            .CourseName = selectedCourse.Name
        }

        enrollments.Add(enrollment)
        RefreshEnrollmentList()
    End Sub

    ' Update an existing enrollment
    Private Sub btnUpdateEnrollment_Click(sender As Object, e As EventArgs) Handles btnUpdateEnrollment.Click
        If selectedEnrollment IsNot Nothing Then
            ' Update enrollment details here if needed (e.g., changing course, etc.)
            Dim selectedStudent As Student = CType(cmbStudent.SelectedItem, Student)
            Dim selectedCourse As Course = CType(cmbCourse.SelectedItem, Course)

            selectedEnrollment.StudentName = selectedStudent.Name
            selectedEnrollment.CourseName = selectedCourse.Name
            selectedEnrollment.StudentID = selectedStudent.ID
            selectedEnrollment.CourseID = selectedCourse.ID

            RefreshEnrollmentList()
            ClearInputs()
        Else
            MessageBox.Show("Please select an enrollment to update.")
        End If
    End Sub

    ' Delete an enrollment
    Private Sub btnDeleteEnrollment_Click(sender As Object, e As EventArgs) Handles btnDeleteEnrollment.Click
        If selectedEnrollment IsNot Nothing Then
            enrollments.Remove(selectedEnrollment)
            RefreshEnrollmentList()
            ClearInputs()
        Else
            MessageBox.Show("Please select an enrollment to delete.")
        End If
    End Sub

    ' Handle selection from the Enrollment DataGridView
    Private Sub dgvEnrollmentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrollmentList.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEnrollmentList.Rows(e.RowIndex)
            selectedEnrollment = CType(row.DataBoundItem, Enrollment)

            ' Populate ComboBoxes with the selected enrollment details
            cmbStudent.SelectedValue = selectedEnrollment.StudentID
            cmbCourse.SelectedValue = selectedEnrollment.CourseID
        End If
    End Sub

    ' Refresh the DataGridView to show the updated enrollment list
    Private Sub RefreshEnrollmentList()
        ' Refresh the DataGridView with a new list to avoid unnecessary reset
        dgvEnrollmentList.DataSource = enrollments.ToList()
    End Sub

    ' Clear ComboBoxes and selected enrollment
    Private Sub ClearInputs()
        cmbStudent.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1
        selectedEnrollment = Nothing
    End Sub

    ' Student class to hold student data
    Public Class Student
        Public Property ID As Integer
        Public Property Name As String
    End Class

    ' Course class to hold course data
    Public Class Course
        Public Property ID As Integer
        Public Property Name As String
    End Class

    ' Enrollment class to hold enrollment data
    Public Class Enrollment
        Public Property StudentID As Integer
        Public Property CourseID As Integer
        Public Property StudentName As String
        Public Property CourseName As String
    End Class
End Class
