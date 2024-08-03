Imports System.Data.SqlClient

Public Class AddTeacherForm

    ' Connection string for connecting to the database
    Dim connectionString As String = "Data Source=IDEAPAD-GAMING;Initial Catalog=cams;Integrated Security=True"
    Dim previousForm As Form ' Store reference to the previous form

    ' Constructor to accept the reference to the previous form
    Public Sub New(previousForm As Form)
        InitializeComponent()
        Me.previousForm = previousForm
    End Sub

    ' Button to go back to the previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the previous form
        Me.Close()
        previousForm.Show()
    End Sub

    ' Save button click event handler
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if all required fields are filled
        If ValidateInput() Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Insert into Teacher table
                    Dim teacherQuery As String = "INSERT INTO Teacher (TID, TName, TMobileNo, CourseCode, Course, SubjectCode, SubjectName) VALUES (@TID, @TName, @TMobileNo, @CourseCode, @Course, @SubjectCode, @SubjectName)"
                    Using teacherCommand As New SqlCommand(teacherQuery, connection)
                        teacherCommand.Parameters.AddWithValue("@TID", txtTID.Text)
                        teacherCommand.Parameters.AddWithValue("@TName", txtTeacherName.Text)
                        teacherCommand.Parameters.AddWithValue("@TMobileNo", txtMobileNo.Text)
                        teacherCommand.Parameters.AddWithValue("@CourseCode", cmbCourseCode.Text)
                        teacherCommand.Parameters.AddWithValue("@Course", cmbCourse.Text)
                        teacherCommand.Parameters.AddWithValue("@SubjectCode", cmbSubjectCode.Text)
                        teacherCommand.Parameters.AddWithValue("@SubjectName", cmbSubjectName.Text)
                        teacherCommand.ExecuteNonQuery()
                    End Using


                    ' Insert into Login table
                    Dim loginQuery As String = "INSERT INTO Login (Usertype, LoginID, Password) VALUES ('Teacher', @LoginID, @Password)"
                    Using loginCommand As New SqlCommand(loginQuery, connection)
                        loginCommand.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
                        loginCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                        loginCommand.ExecuteNonQuery()
                    End Using
                End Using

                ' Show success message
                MessageBox.Show("Teacher details saved successfully!")

                ' Clear all fields after successful saving
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error saving teacher details: " & ex.Message)
            End Try
        End If
    End Sub

    ' Validate input fields
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtTID.Text) OrElse String.IsNullOrWhiteSpace(txtTeacherName.Text) OrElse String.IsNullOrWhiteSpace(txtMobileNo.Text) OrElse String.IsNullOrWhiteSpace(cmbCourseCode.Text) OrElse String.IsNullOrWhiteSpace(cmbCourse.Text) OrElse String.IsNullOrWhiteSpace(cmbSubjectCode.Text) OrElse String.IsNullOrWhiteSpace(cmbSubjectName.Text) OrElse String.IsNullOrWhiteSpace(txtLoginID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return False
        End If
        Return True
    End Function

    ' Clear all input fields
    Private Sub ClearFields()
        txtTID.Clear()
        txtTeacherName.Clear()
        txtMobileNo.Clear()
        cmbCourseCode.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1
        cmbSubjectCode.SelectedIndex = -1
        cmbSubjectName.SelectedIndex = -1
        txtLoginID.Clear()
        txtPassword.Clear()
    End Sub

    ' Button to clear all input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub AddTeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Courses and Subjects
        LoadCourses()
        LoadSubjects()
    End Sub

    ' Load Courses into ComboBox
    Private Sub LoadCourses()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT CourseCode, Course FROM Course"
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim courseTable As New DataTable()
                    adapter.Fill(courseTable)
                    cmbCourseCode.DataSource = courseTable
                    cmbCourseCode.DisplayMember = "CourseCode"
                    cmbCourse.DataSource = courseTable
                    cmbCourse.DisplayMember = "Course"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading course data: {ex.Message}")
        End Try
    End Sub

    ' Load Subjects into ComboBox
    Private Sub LoadSubjects()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT SubjectCode, SubjectName FROM Subject"
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim subjectTable As New DataTable()
                    adapter.Fill(subjectTable)
                    cmbSubjectCode.DataSource = subjectTable
                    cmbSubjectCode.DisplayMember = "SubjectCode"
                    cmbSubjectName.DataSource = subjectTable
                    cmbSubjectName.DisplayMember = "SubjectName"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading subject data: {ex.Message}")
        End Try
    End Sub

    Private Sub txtTeacherName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeacherName.KeyPress
        ' Check if the pressed key is a letter or a space
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            ' Cancel the key press
            e.Handled = True
            ' Show error message
            MessageBox.Show("Invalid character entered. Please use only character values (a-z, A-Z) in the Teacher Name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' KeyPress event handler for Mobile No TextBox
    Private Sub txtMobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNo.KeyPress
        ' Check if the entered character is not a digit
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only numeric values (0-9) in the Mobile Number field.")
        End If
    End Sub

    ' KeyPress event handler for Teacher ID TextBox
    Private Sub txtTeacherID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTID.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Teacher ID field.")
        End If
    End Sub

    ' KeyPress event handler for LoginID TextBox
    Private Sub txtLoginID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoginID.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the LoginID field.")
        End If
    End Sub

    ' KeyPress event handler for Password TextBox
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Password field.")
        End If
    End Sub
End Class

