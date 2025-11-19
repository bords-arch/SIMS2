Imports MySql.Data.MySqlClient

Public Class StudentManagementForm
    ' Connection string
    Dim conn As MySqlConnection = DBConnection.GetInstance()

    ' Load student records into the DataGridView when the form loads
    Private Sub StudentManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.SelectedIndex = 0 ' Default gender
    End Sub

    ' Method to load student records into the DataGridView
    Private Sub LoadStudents()
        Dim query As String = "SELECT student_id, first_name, last_name, birth_date, gender, address, contact_no FROM tbl_students"
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            conn.Open()
            adapter.Fill(dt)
            dgvStudentList.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Add a new student
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        ' Clear fields for new entry
        ClearFields()
    End Sub

    ' Save a new or updated student record
    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        Dim query As String
        If txtFirstName.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Please fill in all required fields!")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtAddress.Text) Then
            txtAddress.Text = "" ' Handle empty address as optional
        End If

        If btnSaveStudent.Text = "Save" Then
            ' Insert new student record
            query = "INSERT INTO tbl_students (first_name, last_name, birth_date, gender, address, contact_no) VALUES (@first_name, @last_name, @birth_date, @gender, @address, @contact_no)"
        Else
            ' Update existing student record
            query = "UPDATE tbl_students SET first_name=@first_name, last_name=@last_name, birth_date=@birth_date, gender=@gender, address=@address, contact_no=@contact_no WHERE student_id=@student_id"
        End If

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text)
        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text)
        cmd.Parameters.AddWithValue("@birth_date", dtpBirthDate.Value)
        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@contact_no", txtContactNo.Text)

        If btnSaveStudent.Text = "Update" Then
            cmd.Parameters.AddWithValue("@student_id", dgvStudentList.SelectedRows(0).Cells(0).Value) ' Get student_id for update
        End If

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student data saved successfully!")
            LoadStudents() ' Reload the students list
            ClearFields()  ' Clear fields after save
        Catch ex As Exception
            MessageBox.Show("Error saving student data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Delete selected student record
    Private Sub btnDeleteStudent_Click(sender As Object, e As EventArgs) Handles btnDeleteStudent.Click
        If dgvStudentList.SelectedRows.Count > 0 Then
            Dim studentId As Integer = dgvStudentList.SelectedRows(0).Cells(0).Value
            Dim query As String = "DELETE FROM tbl_students WHERE student_id=@student_id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@student_id", studentId)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Student deleted successfully!")
                LoadStudents() ' Reload students list
            Catch ex As Exception
                MessageBox.Show("Error deleting student: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a student to delete.")
        End If
    End Sub

    ' Update student details when selecting a student from DataGridView
    Private Sub dgvStudentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentList.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvStudentList.Rows(e.RowIndex)
            txtFirstName.Text = selectedRow.Cells("first_name").Value.ToString()
            txtLastName.Text = selectedRow.Cells("last_name").Value.ToString()
            dtpBirthDate.Value = Convert.ToDateTime(selectedRow.Cells("birth_date").Value)
            cmbGender.SelectedItem = selectedRow.Cells("gender").Value.ToString()
            txtAddress.Text = selectedRow.Cells("address").Value.ToString()
            txtContactNo.Text = selectedRow.Cells("contact_no").Value.ToString()

            btnSaveStudent.Text = "Update"  ' Change button text to "Update"
        End If
    End Sub

    ' Clear input fields
    Private Sub ClearFields()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtContactNo.Clear()
        cmbGender.SelectedIndex = 0  ' Default to "Male"
        dtpBirthDate.Value = DateTime.Now
        btnSaveStudent.Text = "Save"  ' Reset button text to "Save"
    End Sub
End Class
