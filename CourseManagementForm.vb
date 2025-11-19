Public Class CourseManagementForm
    ' List to store course data (replace with database logic as needed)
    Private courses As New List(Of Course)()
    Private selectedCourse As Course = Nothing

    ' Load courses data when the form loads
    Private Sub CourseManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example data - in a real application, load this from a database
        courses.Add(New Course() With {.ID = 101, .Name = "Math 101", .Units = 3})
        courses.Add(New Course() With {.ID = 102, .Name = "Science 101", .Units = 4})

        ' Bind the DataGridView to the courses list
        RefreshCourseList()
    End Sub

    ' Add a new course
    Private Sub BtnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        If String.IsNullOrWhiteSpace(txtCourseName.Text) OrElse String.IsNullOrWhiteSpace(txtUnits.Text) Then
            MessageBox.Show("Please provide course name and units.")
            Return
        End If

        ' Create a new course and add it to the list
        Dim newCourse As New Course() With {
            .ID = courses.Max(Function(c) c.ID) + 1, ' Generate new ID based on existing ones
            .Name = txtCourseName.Text,
            .Units = Integer.Parse(txtUnits.Text)
        }

        courses.Add(newCourse)
        RefreshCourseList()
        ClearInputs()
    End Sub

    ' Update an existing course
    Private Sub BtnUpdateCourse_Click(sender As Object, e As EventArgs) Handles btnUpdateCourse.Click
        If selectedCourse IsNot Nothing Then
            ' Update course details
            selectedCourse.Name = txtCourseName.Text
            selectedCourse.Units = Integer.Parse(txtUnits.Text)

            RefreshCourseList()
            ClearInputs()
        Else
            MessageBox.Show("Please select a course to update.")
        End If
    End Sub

    ' Delete a course
    Private Sub BtnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        If selectedCourse IsNot Nothing Then
            courses.Remove(selectedCourse)
            RefreshCourseList()
            ClearInputs()
        Else
            MessageBox.Show("Please select a course to delete.")
        End If
    End Sub

    ' Handle selection from the DataGridView
    Private Sub DgvCourseList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourseList.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected course from the DataGridView
            Dim row As DataGridViewRow = dgvCourseList.Rows(e.RowIndex)
            selectedCourse = CType(row.DataBoundItem, Course)

            ' Populate the TextBoxes with the selected course data
            txtCourseName.Text = selectedCourse.Name
            txtUnits.Text = selectedCourse.Units.ToString()
        End If
    End Sub

    ' Refresh the DataGridView to show updated course list
    Private Sub RefreshCourseList()
        dgvCourseList.DataSource = Nothing
        dgvCourseList.DataSource = courses
    End Sub

    ' Clear the TextBoxes and the selected course
    Private Sub ClearInputs()
        txtCourseName.Clear()
        txtUnits.Clear()
        selectedCourse = Nothing
    End Sub

    ' Course class to hold course data
    Public Class Course
        Public Property ID As Integer
        Public Property Name As String
        Public Property Units As Integer
    End Class

End Class
