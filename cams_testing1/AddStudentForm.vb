Imports System.Data.SqlClient

Public Class AddStudentForm

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
            If ValidateInput() Then
                ' Additional validation for specific fields
                If Not IsValidSID(txtSID.Text) Then
                    MessageBox.Show("Invalid SID! Please use only character and numeric values (a-z, A-Z, 0-9) in the SID field.")
                    Return
                End If

                If Not IsValidSName(txtSName.Text) Then
                    MessageBox.Show("Invalid SName! Please use only character values (a-z, A-Z) in the SName field.")
                    Return
                End If

                If Not IsValidMobileNo(txtSMobileNo.Text) Then
                    MessageBox.Show("Invalid Mobile No! Please use only numeric values (0-9) in the Mobile No field.")
                    Return
                End If

                If Not IsValidRollNo(txtSRollNo.Text) Then
                    MessageBox.Show("Invalid Roll No! Please use only character and numeric values (a-z, A-Z, 0-9) in the Roll No field.")
                    Return
                End If

                If Not IsValidYear(txtYear.Text) Then
                    MessageBox.Show("Invalid Year! Please use only character and numeric values (a-z, A-Z, 0-9) in the Year field.")
                    Return
                End If

                If Not IsValidSemester(txtSemester.Text) Then
                    MessageBox.Show("Invalid Semester! Please use only character and numeric values (a-z, A-Z, 0-9) in the Semester field.")
                    Return
                End If

                If Not IsValidLoginID(txtLoginID.Text) Then
                    MessageBox.Show("Invalid LoginID! Please use only character and numeric values (a-z, A-Z, 0-9) in the LoginID field.")
                    Return
                End If

                If Not IsValidPassword(txtPassword.Text) Then
                    MessageBox.Show("Invalid Password! Please use only character and numeric values (a-z, A-Z, 0-9) in the Password field.")
                    Return
                End If
            End If

            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Insert into Login table
                    Dim loginQuery As String = "INSERT INTO Login (Usertype, LoginID, Password) VALUES ('Student', @LoginID, @Password)"
                    Using loginCommand As New SqlCommand(loginQuery, connection)
                        loginCommand.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
                        loginCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                        loginCommand.ExecuteNonQuery()
                    End Using

                    ' Insert into Student table
                    Dim studentQuery As String = "INSERT INTO Student (LoginID, SID, SName, SRollNo, SDOB, SMobileNo, CourseCode, Course, Year, Semester) VALUES (@LoginID, @SID, @SName, @SRollNo, @SDOB, @SMobileNo, @CourseCode, @Course, @Year, @Semester)"
                    Using studentCommand As New SqlCommand(studentQuery, connection)
                        studentCommand.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
                        studentCommand.Parameters.AddWithValue("@SID", txtSID.Text)
                        studentCommand.Parameters.AddWithValue("@SName", txtSName.Text)
                        studentCommand.Parameters.AddWithValue("@SRollNo", txtSRollNo.Text)
                        studentCommand.Parameters.AddWithValue("@SDOB", Convert.ToDateTime(dtpSDOB.Value))
                        studentCommand.Parameters.AddWithValue("@SMobileNo", txtSMobileNo.Text)
                        studentCommand.Parameters.AddWithValue("@CourseCode", cmbCourseCode.SelectedValue)
                        studentCommand.Parameters.AddWithValue("@Course", cmbCourse.Text)
                        studentCommand.Parameters.AddWithValue("@Year", txtYear.Text)
                        studentCommand.Parameters.AddWithValue("@Semester", txtSemester.Text)
                        studentCommand.ExecuteNonQuery()
                    End Using
                End Using

                ' Show success message
                MessageBox.Show("Student details saved successfully!")

                ' Clear all fields after successful saving
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error saving student details: " & ex.Message)
            End Try
        End If
    End Sub

    ' Validate input fields
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtLoginID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(txtSID.Text) OrElse String.IsNullOrWhiteSpace(txtSName.Text) OrElse String.IsNullOrWhiteSpace(txtSRollNo.Text) OrElse String.IsNullOrWhiteSpace(cmbCourseCode.Text) OrElse String.IsNullOrWhiteSpace(cmbCourse.Text) OrElse String.IsNullOrWhiteSpace(txtYear.Text) OrElse String.IsNullOrWhiteSpace(txtSemester.Text) Then
            MessageBox.Show("Please fill in all the required fields!")
            Return False
        End If
        Return True
    End Function

    ' Clear all input fields
    Private Sub ClearFields()
        txtLoginID.Clear()
        txtPassword.Clear()
        txtSID.Clear()
        txtSName.Clear()
        txtSRollNo.Clear()
        dtpSDOB.Value = Date.Now
        txtSMobileNo.Clear()
        cmbCourseCode.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1
        txtYear.Clear()
        txtSemester.Clear()
    End Sub

    ' Button to clear all input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub AddStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Courses into ComboBox
        LoadCourses()
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
                    cmbCourseCode.ValueMember = "CourseCode" ' Set ValueMember to CourseCode column
                    cmbCourse.DataSource = courseTable
                    cmbCourse.DisplayMember = "Course"
                    cmbCourse.ValueMember = "CourseCode" ' Set ValueMember to CourseCode column
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading course data: {ex.Message}")
        End Try
    End Sub
    ' KeyPress event handler for SID TextBox
    Private Sub txtSID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSID.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Student ID field.")
        End If
    End Sub

    ' KeyPress event handler for SName TextBox
    Private Sub txtSName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSName.KeyPress
        ' Check if the pressed key is a letter or a space
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            ' Cancel the key press
            e.Handled = True
            ' Show error message
            MessageBox.Show("Invalid character entered! Please use only character values (a-z, A-Z) in the Student Name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' KeyPress event handler for Mobile No TextBox
    Private Sub txtSMobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSMobileNo.KeyPress
        ' Check if the entered character is not a digit
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only numeric values (0-9) in the Mobile N field.")
        End If
    End Sub

    ' KeyPress event handler for Roll Number TextBox
    Private Sub txtRollNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSRollNo.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Roll Number field.")
        End If
    End Sub

    ' KeyPress event handler for Year TextBox
    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Year field.")
        End If
    End Sub

    ' KeyPress event handler for Semester TextBox
    Private Sub txtSemester_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSemester.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Semester field.")
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

    Private Function IsValidSID(sid As String) As Boolean
        ' Check if the entered SID contains only alphanumeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(sid, "^[a-zA-Z0-9]+$")
    End Function

    Private Function IsValidSName(sname As String) As Boolean
        ' Check if the entered SName contains only alphabetic characters and white spaces
        Return System.Text.RegularExpressions.Regex.IsMatch(sname, "^[a-zA-Z\s]+$")
    End Function


    Private Function IsValidMobileNo(mobileNo As String) As Boolean
        ' Check if the entered Mobile No contains only numeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(mobileNo, "^[0-9]+$")
    End Function

    Private Function IsValidRollNo(rollNo As String) As Boolean
        ' Check if the entered Roll No contains only alphanumeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(rollNo, "^[a-zA-Z0-9]+$")
    End Function

    Private Function IsValidYear(year As String) As Boolean
        ' Check if the entered Year contains only alphanumeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(year, "^[a-zA-Z0-9]+$")
    End Function

    Private Function IsValidSemester(semester As String) As Boolean
        ' Check if the entered Semester contains only alphanumeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(semester, "^[a-zA-Z0-9]+$")
    End Function

    Private Function IsValidLoginID(loginID As String) As Boolean
        ' Check if the entered LoginID contains only alphanumeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(loginID, "^[a-zA-Z0-9]+$")
    End Function

    Private Function IsValidPassword(password As String) As Boolean
        ' Check if the entered Password contains only alphanumeric characters
        Return System.Text.RegularExpressions.Regex.IsMatch(password, "^[a-zA-Z0-9]+$")
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class


