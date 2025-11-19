Public Class User
    Public Property UserId As Integer
    Public Property Username As String
    Public Property Password As String
    Public Property Role As String

    ' Constructor to initialize the user object
    Public Sub New(userId As Integer, username As String, password As String, role As String)
        Me.UserId = userId
        Me.Username = username
        Me.Password = password
        Me.Role = role
    End Sub
End Class
