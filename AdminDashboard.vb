Public Class AdminDashboard

    ' Form load event - to display the logged-in user's name/role
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the current user role (assuming this value was passed from the login form)
        lblLoggedInUser.Text = "Logged in as: " & currentUserRole ' currentUserRole should be set during login
    End Sub

    Private Function CurrentUserRole() As String
        Throw New NotImplementedException()
    End Function

    ' Open User Management form when the corresponding button is clicked
    Private Sub BtnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        Dim userForm As New UserManagementForm()
        userForm.Show()
        Me.Hide()  ' Hide the Admin Dashboard form
    End Sub

    ' Open Student Management form when the corresponding button is clicked
    Private Sub BtnStudentManagement_Click(sender As Object, e As EventArgs) Handles btnStudentManagement.Click
        Dim studentForm As New StudentManagementForm()
        studentForm.Show()
        Me.Hide()  ' Hide the Admin Dashboard form
    End Sub

    ' Open Course Management form when the corresponding button is clicked
    Private Sub BtnCourseManagement_Click(sender As Object, e As EventArgs) Handles btnCourseManagement.Click
        Dim courseForm As New CourseManagementForm()
        courseForm.Show()
        Me.Hide()  ' Hide the Admin Dashboard form
    End Sub

    ' Open Enrollment Management form when the corresponding button is clicked
    Private Sub BtnEnrollmentManagement_Click(sender As Object, e As EventArgs) Handles btnEnrollmentManagement.Click
        Dim enrollmentForm As New EnrollmentManagementForm()
        enrollmentForm.Show()
        Me.Hide()  ' Hide the Admin Dashboard form
    End Sub

    ' Open Grade Management form when the corresponding button is clicked
    Private Sub BtnGradeManagement_Click(sender As Object, e As EventArgs) Handles btnGradeManagement.Click
        Dim gradeForm As New GradeManagementForm()
        gradeForm.Show()
        Me.Hide()  ' Hide the Admin Dashboard form
    End Sub

    ' Open Report Generation form when the corresponding button is clicked
    Private Sub BtnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        ' Example: Open a report form
        Dim reportForm As New ReportGenerationForm()
        reportForm.Show()
        Me.Hide()  ' Hide the Admin Dashboard form
    End Sub
End Class
