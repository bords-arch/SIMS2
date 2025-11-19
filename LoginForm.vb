Imports MySql.Data.MySqlClient

Public Class LoginForm

    ' When the Login button is clicked
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Connection to MySQL database
        Dim conn As MySqlConnection = DBConnection.GetInstance()

        ' SQL command to check username, password, and role in the database
        Dim cmd As New MySqlCommand("SELECT * FROM tbl_users WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' If credentials are found in the database
            If reader.Read() Then
                ' Check the role (Admin/Staff)
                If reader("role").ToString() = "Admin" Then
                    ' If admin, open Admin Dashboard and hide login form
                    Dim adminForm As New AdminDashboard()
                    adminForm.Show()
                    Me.Hide()
                ElseIf reader("role").ToString() = "Staff" Then
                    ' If staff, open Staff Dashboard and hide login form
                    Dim staffForm As New StaffDashboard()
                    staffForm.Show()
                    Me.Hide()
                End If
            Else
                ' If login fails, display error message
                lblLoginStatus.Text = "Invalid login credentials"
                lblLoginStatus.ForeColor = Color.Red
            End If
        Catch ex As Exception
            ' If there's an error connecting to the database
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' When the form loads, populate role options in the ComboBox
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Staff")
        cmbRole.SelectedIndex = 0  ' Set default role to "Admin"
    End Sub
End Class
