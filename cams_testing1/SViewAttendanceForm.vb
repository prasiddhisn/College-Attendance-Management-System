Imports System.Data.SqlClient

Public Class SViewAttendanceForm

    Private connectionString As String = "Data Source=IDEAPAD-GAMING;Initial Catalog=cams;Integrated Security=True"
    Private studentID As String = ""

    Private Sub SViewAttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Prompt the user to enter the Student ID
        ValidateAndLoadAttendanceData()
        ' Populate subjectComboBox with values from the Subject table
        PopulateSubjectComboBox()
    End Sub

    Private Sub PopulateSubjectComboBox()
        Dim query As String = "SELECT SubjectName FROM Subject"

        Try
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    subjectComboBox.Items.Add(reader("SubjectName").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ValidateAndLoadAttendanceData()
        Try
            ' Prompt the user to enter the Student ID
            Do
                studentID = InputBox("Please enter the Student ID:", "Enter Student ID")

                ' If the user cancels or provides an empty ID, close the form
                If String.IsNullOrEmpty(studentID) Then
                    Me.Close()
                    Exit Sub
                ElseIf Not IsValidStudentID(studentID) Then
                    MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Student ID field.", "Invalid Input")
                ElseIf Not CheckStudentIDExistence(studentID) Then
                    MessageBox.Show("Invalid ID: Enter your student ID to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    LoadAttendanceData(studentID)
                    Exit Sub
                End If
            Loop While True
        Catch ex As Exception
            ' Handle any unexpected errors
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Function IsValidStudentID(studentID As String) As Boolean
        For Each c As Char In studentID
            If Not Char.IsLetterOrDigit(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function CheckStudentIDExistence(studentID As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Student WHERE SID = @SID"
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@SID", studentID)
            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub LoadAttendanceData(ByVal studentID As String)
        Dim query As String = "SELECT * FROM Attendance WHERE SID = @SID"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@SID", studentID)

            Dim adapter As New SqlDataAdapter(command)
            Dim attendanceTable As New DataTable()
            adapter.Fill(attendanceTable)
            DataGridView1.DataSource = attendanceTable
        End Using
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub filterButton_Click(sender As Object, e As EventArgs) Handles filterButton.Click
        ' Apply filter based on subject name selected in the ComboBox
        Dim subjectName As String = subjectComboBox.Text.Trim()

        If Not String.IsNullOrEmpty(subjectName) Then
            Dim dv As New DataView(CType(DataGridView1.DataSource, DataTable))
            dv.RowFilter = "SubjectName = '" & subjectName & "'"
            DataGridView1.DataSource = dv
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear filter and reload all records
        subjectComboBox.SelectedIndex = -1
        LoadAttendanceData(studentID)
    End Sub

    Private Sub subjectComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles subjectComboBox.KeyPress
        ' Check if the entered character is not a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character values (a-z, A-Z) in the Subject field.", "Invalid Input")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class


