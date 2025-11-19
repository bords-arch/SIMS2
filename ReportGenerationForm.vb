Public Class ReportGenerationForm
    ' List of students, courses, and enrollments
    Private students As New List(Of Student)()
    Private courses As New List(Of Course)()
    Private enrollments As New List(Of Enrollment)()

    ' Form Load event: Initialize sample data
    Private Sub ReportGenerationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example data - In a real application, this would come from a database
        students.Add(New Student() With {.ID = 1, .Name = "John Doe"})
        students.Add(New Student() With {.ID = 2, .Name = "Jane Smith"})
        students.Add(New Student() With {.ID = 3, .Name = "Emily Clark"})

        courses.Add(New Course() With {.ID = 101, .Name = "Math 101", .Units = 3})
        courses.Add(New Course() With {.ID = 102, .Name = "Science 101", .Units = 4})

        ' Enrollments data
        enrollments.Add(New Enrollment() With {.StudentID = 1, .CourseID = 101, .StudentName = "John Doe", .CourseName = "Math 101"})
        enrollments.Add(New Enrollment() With {.StudentID = 2, .CourseID = 102, .StudentName = "Jane Smith", .CourseName = "Science 101"})
        enrollments.Add(New Enrollment() With {.StudentID = 3, .CourseID = 101, .StudentName = "Emily Clark", .CourseName = "Math 101"})

        ' Set default selection to display a report on form load
        GenerateReport()
    End Sub

    ' Generate the report and display it in a TextBox or RichTextBox
    Private Sub GenerateReport()
        ' Clear existing report text
        Textreport.Clear()

        ' Add report title
        Textreport.AppendText("Enrollment Report" & Environment.NewLine)
        Textreport.AppendText("===================" & Environment.NewLine)

        ' Loop through enrollments and display student names with their respective courses
        For Each enrollment In enrollments
            Dim studentName As String = enrollment.StudentName
            Dim courseName As String = enrollment.CourseName
            Textreport.AppendText($"{studentName} is enrolled in {courseName}" & Environment.NewLine)
        Next

        Textreport.AppendText(Environment.NewLine & "End of Report")
    End Sub

    ' Button Click event to regenerate the report
    Private Sub BtnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        GenerateReport()
    End Sub

    ' Clear the report display
    Private Sub BtnClearReport_Click(sender As Object, e As EventArgs) Handles btnClearReport.Click
        Textreport.Clear()
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
        Public Property Units As Integer
    End Class

    ' Enrollment class to hold enrollment data
    Public Class Enrollment
        Public Property StudentID As Integer
        Public Property CourseID As Integer
        Public Property StudentName As String
        Public Property CourseName As String
    End Class
End Class
