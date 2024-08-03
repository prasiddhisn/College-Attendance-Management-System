Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ModifyAttendanceForm
    Dim connectionString As String = "Data Source=IDEAPAD-GAMING;Initial Catalog=cams;Integrated Security=True"
    Dim connection As SqlConnection
    Dim isFormLoaded As Boolean = False ' Flag to prevent loading data before form is fully loaded
    Dim attendanceDataTable As New DataTable()
    Dim loginDataTable As New DataTable()
    Dim studentDataTable As New DataTable()
    Dim courseDataTable As New DataTable()
    Dim subjectDataTable As New DataTable()
    Dim teacherDataTable As New DataTable()

    Private Sub ModifyAttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the connection
        connection = New SqlConnection(connectionString)
        connection.Open()

        ' Populate comboboxes
        PopulateComboBoxes()

        Try
            ' Create columns in the DataTable
            attendanceDataTable.Columns.Add("AttendanceID")
            attendanceDataTable.Columns.Add("LoginID")
            attendanceDataTable.Columns.Add("SID")
            attendanceDataTable.Columns.Add("SName")
            attendanceDataTable.Columns.Add("CourseCode")
            attendanceDataTable.Columns.Add("Course")
            attendanceDataTable.Columns.Add("SubjectCode")
            attendanceDataTable.Columns.Add("SubjectName")
            attendanceDataTable.Columns.Add("TID")
            attendanceDataTable.Columns.Add("TName")
            attendanceDataTable.Columns.Add("AttendanceStatus")
            attendanceDataTable.Columns.Add("Date", GetType(DateTime))

            ' Assign the DataTable as the DataGridView's DataSource
            DataGridView1.DataSource = attendanceDataTable
            isFormLoaded = True
        Catch ex As Exception
            MessageBox.Show($"Error creating columns in the DataTable: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateComboBoxes()
        ' Populate cascading combo boxes
        PopulateLoginIDComboBox()
        PopulateStudentComboBox()
        PopulateCourseComboBox()
        PopulateSubjectComboBox()
        PopulateTeacherComboBox()

        ' Populate Attendance Status combo box
        attendancestatus.Items.AddRange({"Present", "Absent"})
    End Sub

    Private Sub PopulateLoginIDComboBox()
        ' Populate LoginID combo box with options starting with "S"
        Dim query As String = "SELECT LoginID FROM Login WHERE LoginID LIKE 'S%'"
        Dim adapter As New SqlDataAdapter(query, connection)

        adapter.Fill(loginDataTable)
        loginid.DataSource = loginDataTable
        loginid.DisplayMember = "LoginID"
    End Sub

    Private Sub PopulateStudentComboBox()
        ' Populate StudentID and StudentName combo boxes
        Dim query As String = "SELECT SID, SName FROM Student"
        Dim adapter As New SqlDataAdapter(query, connection)

        adapter.Fill(studentDataTable)
        studentid.DataSource = studentDataTable
        studentid.DisplayMember = "SID"
        studentname.DataSource = studentDataTable
        studentname.DisplayMember = "SName"
    End Sub

    Private Sub PopulateCourseComboBox()
        ' Populate CourseCode and Course combo boxes
        Dim query As String = "SELECT CourseCode, Course FROM Course"
        Dim adapter As New SqlDataAdapter(query, connection)

        adapter.Fill(courseDataTable)
        coursecode.DataSource = courseDataTable
        coursecode.DisplayMember = "CourseCode"
        course.DataSource = courseDataTable
        course.DisplayMember = "Course"
    End Sub

    Private Sub PopulateSubjectComboBox()
        ' Populate SubjectCode and Subject combo boxes
        Dim query As String = "SELECT SubjectCode, SubjectName FROM Subject"
        Dim adapter As New SqlDataAdapter(query, connection)

        adapter.Fill(subjectDataTable)
        subjectcode.DataSource = subjectDataTable
        subjectcode.DisplayMember = "SubjectCode"
        subject.DataSource = subjectDataTable
        subject.DisplayMember = "SubjectName"
    End Sub

    Private Sub PopulateTeacherComboBox()
        ' Populate TeacherID and TeacherName combo boxes
        Dim query As String = "SELECT TID, TName FROM Teacher"
        Dim adapter As New SqlDataAdapter(query, connection)

        adapter.Fill(teacherDataTable)
        teacherid.DataSource = teacherDataTable
        teacherid.DisplayMember = "TID"
        teachername.DataSource = teacherDataTable
        teachername.DisplayMember = "TName"
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        ' Check if form is fully loaded
        If Not isFormLoaded Then
            MessageBox.Show("The form is not fully loaded yet. Please wait until it is fully loaded before performing this action.", "Form Not Fully Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Validate input fields
        If Not ValidateFields() Then
            Return
        End If

        ' Add details to DataGridView

        Dim row As DataRow = attendanceDataTable.NewRow()
        row("AttendanceID") = attendanceid.Text
        row("LoginID") = loginid.Text
        row("SID") = studentid.Text
        row("SName") = studentname.Text
        row("CourseCode") = coursecode.Text
        row("Course") = course.Text
        row("SubjectCode") = subjectcode.Text
        row("SubjectName") = subject.Text
        row("TID") = teacherid.Text
        row("TName") = teachername.Text
        row("AttendanceStatus") = attendancestatus.Text
        row("Date") = DateTimePicker1.Value

        attendanceDataTable.Rows.Add(row)

    End Sub

    Private Sub savechangesButton_Click(sender As Object, e As EventArgs) Handles savechangesButton.Click
        ' Check if form is fully loaded
        If Not isFormLoaded Then
            Return
        End If

        ' Check if DataGridView contains data
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No attendance records to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if any row in DataGridView contains all cells empty
        Dim allRowsEmpty = True
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrWhiteSpace(cell.Value?.ToString()) Then
                    allRowsEmpty = False
                    Exit For
                End If
            Next
            If Not allRowsEmpty Then
                Exit For
            End If
        Next

        ' If all rows are empty, show error and return
        If allRowsEmpty Then
            MessageBox.Show("Please fill in at least one attendance record before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate DataGridView
        If Not ValidateDataGridView() Then
            MessageBox.Show("Please ensure that all the cells in the table are filled before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save changes to the database
        Try
            ' Create a data adapter with select and insert command
            Dim adapter As New SqlDataAdapter("SELECT * FROM Attendance", connection)
            Dim builder As New SqlCommandBuilder(adapter)

            ' Update the database with changes in the DataTable
            adapter.Update(attendanceDataTable)

            MessageBox.Show("The attendance details have successfully been saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving changes to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ValidateFields() As Boolean
        ' Validate if all fields are filled
        If String.IsNullOrWhiteSpace(attendanceid.Text) OrElse
            String.IsNullOrWhiteSpace(loginid.Text) OrElse
            String.IsNullOrWhiteSpace(studentid.Text) OrElse
            String.IsNullOrWhiteSpace(studentname.Text) OrElse
            String.IsNullOrWhiteSpace(coursecode.Text) OrElse
            String.IsNullOrWhiteSpace(course.Text) OrElse
            String.IsNullOrWhiteSpace(subjectcode.Text) OrElse
            String.IsNullOrWhiteSpace(subject.Text) OrElse
            String.IsNullOrWhiteSpace(teacherid.Text) OrElse
            String.IsNullOrWhiteSpace(teachername.Text) OrElse
            String.IsNullOrWhiteSpace(attendancestatus.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function ValidateDataGridView() As Boolean
        ' Validate if all cells in DataGridView are filled
        Dim lastRowIndex As Integer = DataGridView1.Rows.Count - 1

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Index = lastRowIndex AndAlso row.IsNewRow Then
                Continue For ' Skip validation for the last empty row
            End If

            For Each cell As DataGridViewCell In row.Cells
                If String.IsNullOrWhiteSpace(cell.Value?.ToString()) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function


    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear all input fields and reset combobox selections
        attendanceid.Clear()
        loginid.SelectedIndex = -1
        studentid.SelectedIndex = -1
        studentname.SelectedIndex = -1
        coursecode.SelectedIndex = -1
        course.SelectedIndex = -1
        subjectcode.SelectedIndex = -1
        subject.SelectedIndex = -1
        teacherid.SelectedIndex = -1
        teachername.SelectedIndex = -1
        attendancestatus.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Today
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' Close the current form
        Me.Close()
    End Sub

    Private Sub deleteRecordButton_Click(sender As Object, e As EventArgs) Handles deleteRecordButton.Click
        ' Delete selected record from DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Check if the selected row is empty
            Dim isEmptyRow As Boolean = True
            For Each cell As DataGridViewCell In selectedRow.Cells
                If Not String.IsNullOrEmpty(cell.Value?.ToString()) Then
                    isEmptyRow = False
                    Exit For
                End If
            Next

            If isEmptyRow Then
                MessageBox.Show("You cannot delete an empty row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                DataGridView1.Rows.Remove(selectedRow)
            End If
        End If
    End Sub



    Private Sub attendanceid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles attendanceid.KeyPress
        ' Check if the pressed key is a digit or a control key (like backspace or delete)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancel the key press event
            e.Handled = True
            ' Show error message
            MessageBox.Show("Invalid character entered. Please use only numeric values (0-9) in the Attendance ID field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class