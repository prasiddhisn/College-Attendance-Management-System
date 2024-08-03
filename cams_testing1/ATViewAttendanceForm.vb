Imports System.Data.SqlClient

Public Class ATViewAttendanceForm

    Private connectionString As String = "Data Source=IDEAPAD-GAMING;Initial Catalog=cams;Integrated Security=True"

    Private Sub ATViewAttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load course data into ComboBox
        LoadCourses()
        ' Load attendance data initially
        LoadAttendanceData()
    End Sub

    Private Sub LoadCourses()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Course FROM Course"
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        courseComboBox.Items.Add(reader("Course").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading course data: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadAttendanceData()
        Dim query As String = "SELECT * FROM Attendance"
        Dim filters As New List(Of String)

        If Not String.IsNullOrEmpty(studentIDTextBox.Text) Then
            filters.Add("SID = @SID")
        End If

        If Not String.IsNullOrEmpty(courseComboBox.Text) Then
            filters.Add("Course = @Course")
        End If

        If filters.Count > 0 Then
            query &= " WHERE " & String.Join(" AND ", filters)
        End If

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            If Not String.IsNullOrEmpty(studentIDTextBox.Text) Then
                command.Parameters.AddWithValue("@SID", studentIDTextBox.Text)
            End If

            If Not String.IsNullOrEmpty(courseComboBox.Text) Then
                command.Parameters.AddWithValue("@Course", courseComboBox.Text)
            End If

            Dim adapter As New SqlDataAdapter(command)
            Dim attendanceTable As New DataTable()
            adapter.Fill(attendanceTable)
            DataGridView1.DataSource = attendanceTable
        End Using
    End Sub
    ' Handle KeyPress event for Course textbox
    Private Sub courseTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles courseComboBox.KeyPress
        ' Check if the entered character is not a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character values (a-z, A-Z) in the Course field.")
        End If
    End Sub

    ' Handle KeyPress event for Student ID textbox
    Private Sub studentIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studentIDTextBox.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Student ID field.")
        End If
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        ' Close the form or navigate to the previous form
        Me.Close()
    End Sub

    Private Sub filterButton_Click(sender As Object, e As EventArgs) Handles filterButton.Click
        LoadAttendanceData()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' Clear filter options and reload all records
        studentIDTextBox.Clear()
        courseComboBox.SelectedIndex = -1
        LoadAttendanceData()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
