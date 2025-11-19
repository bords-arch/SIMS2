Public Class GradeManagementForm
    Private students As New List(Of Student)()
    Private courses As New List(Of Course)()
    Private grades As New List(Of Grade)()
    Private selectedGrade As Grade = Nothing

    ' Load students, courses on form load
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example data - In a real application, load this from a database
        students.Add(New Student() With {.ID = 1, .Name = "John Doe"})
        students.Add(New Student() With {.ID = 2, .Name = "Jane Smith"})
        courses.Add(New Course() With {.ID = 101, .Name = "Math 101"})
        courses.Add(New Course() With {.ID = 102, .Name = "Science 101"})

        ' Bind ComboBoxes to students and courses
        cmbGradeStudent.DataSource = students
        cmbGradeStudent.DisplayMember = "Name"
        cmbGradeStudent.ValueMember = "ID"

        cmbGradeCourse.DataSource = courses
        cmbGradeCourse.DisplayMember = "Name"
        cmbGradeCourse.ValueMember = "ID"
    End Sub

    ' Save the grade information
    Private Sub btnSaveGrade_Click(sender As Object, e As EventArgs) Handles btnSaveGrade.Click
        ' Get selected student and course from ComboBoxes
        Dim selectedStudent As Student = CType(cmbGradeStudent.SelectedItem, Student)
        Dim selectedCourse As Course = CType(cmbGradeCourse.SelectedItem, Course)

        ' Ensure grades are entered
        If String.IsNullOrWhiteSpace(txtMidtermGrade.Text) OrElse String.IsNullOrWhiteSpace(txtFinalGrade.Text) Then
            MessageBox.Show("Please enter both Midterm and Final grades.")
            Return
        End If

        ' Parse the grades
        Dim midtermGrade As Integer
        Dim finalGrade As Integer
        If Not Integer.TryParse(txtMidtermGrade.Text, midtermGrade) OrElse Not Integer.TryParse(txtFinalGrade.Text, finalGrade) Then
            MessageBox.Show("Please enter valid numeric grades.")
            Return
        End If

        ' Create or update the grade record
        selectedGrade = grades.FirstOrDefault(Function(g) g.StudentID = selectedStudent.ID AndAlso g.CourseID = selectedCourse.ID)

        If selectedGrade Is Nothing Then
            ' If no existing grade record, create a new one
            selectedGrade = New Grade() With {
                .StudentID = selectedStudent.ID,
                .CourseID = selectedCourse.ID,
                .StudentName = selectedStudent.Name,
                .CourseName = selectedCourse.Name,
                .MidtermGrade = midtermGrade,
                .FinalGrade = finalGrade,
                .Remarks = txtRemarks.Text
            }
            grades.Add(selectedGrade)
        Else
            ' If the grade already exists, update it
            selectedGrade.MidtermGrade = midtermGrade
            selectedGrade.FinalGrade = finalGrade
            selectedGrade.Remarks = txtRemarks.Text
        End If

        MessageBox.Show("Grade information saved successfully.")
        ClearInputs()
    End Sub

    ' Clear the input fields
    Private Sub ClearInputs()
        cmbGradeStudent.SelectedIndex = -1
        cmbGradeCourse.SelectedIndex = -1
        txtMidtermGrade.Clear()
        txtFinalGrade.Clear()
        txtRemarks.Clear()
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

    ' Grade class to hold grade data
    Public Class Grade
        Public Property StudentID As Integer
        Public Property CourseID As Integer
        Public Property StudentName As String
        Public Property CourseName As String
        Public Property MidtermGrade As Integer
        Public Property FinalGrade As Integer
        Public Property Remarks As String
    End Class
End Class