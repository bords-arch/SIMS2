Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private Shared _instance As MySqlConnection

    ' Private constructor to prevent instantiation from outside
    Private Sub New()
    End Sub

    ' Singleton method to get the single instance of MySQL connection
    Public Shared Function GetInstance() As MySqlConnection
        If _instance Is Nothing Then
            Dim connectionString As String = "server=172.17.100.15; id=user3025; password=pwd3025; database=dbvelos;"
            _instance = New MySqlConnection(connectionString)
        End If
        Return _instance
    End Function
End Class
