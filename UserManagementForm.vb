Public Class UserManagementForm
    ' In-memory list to simulate a database
    Private courses As New List(Of Course)()
    Private selectedCourse As Course = Nothing

    ' Load courses into DataGridView on form load
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCourseList()
    End Sub

    ' Add a new course
    Private Sub BtnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim course As New Course() With {
            .Name = txtCourseName.Text,
            .Description = txtCourseDescription.Text,
            .Units = Integer.Parse(txtUnits.Text)
        }

        courses.Add(course)
        RefreshCourseList()
        ClearInputs()
    End Sub

    ' Update an existing course
    Private Sub BtnUpdateCourse_Click(sender As Object, e As EventArgs) Handles btnUpdateCourse.Click
        If selectedCourse IsNot Nothing Then
            selectedCourse.Name = txtCourseName.Text
            selectedCourse.Description = txtCourseDescription.Text
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

    ' Save changes to a database (Placeholder for actual database code)
    Private Sub BtnSaveCourse_Click(sender As Object, e As EventArgs) Handles btnSaveCourse.Click
        MessageBox.Show("Changes saved!")
    End Sub

    ' Handle course selection from the DataGridView
    Private Sub DgvCourseList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourseList.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCourseList.Rows(e.RowIndex)
            selectedCourse = CType(row.DataBoundItem, Course)

            txtCourseName.Text = selectedCourse.Name
            txtCourseDescription.Text = selectedCourse.Description
            txtUnits.Text = selectedCourse.Units.ToString()
        End If
    End Sub

    ' Refresh the DataGridView with the updated list of courses
    Private Sub RefreshCourseList()
        dgvCourseList.DataSource = Nothing
        dgvCourseList.DataSource = courses
    End Sub

    ' Clear the input fields
    Private Sub ClearInputs()
        txtCourseName.Clear()
        txtCourseDescription.Clear()
        txtUnits.Clear()
        selectedCourse = Nothing
    End Sub

    ' Course class to hold the course data
    Public Class Course
        Public Property Name As String
        Public Property Description As String
        Public Property Units As Integer
    End Class
End Class
