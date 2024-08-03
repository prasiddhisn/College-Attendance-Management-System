Public Class LoginForm

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Input validation
        If (txtLoginID.Text = "") Then
            MsgBox("Enter the LoginID")
            txtLoginID.Focus() ' Focus the username textbox'
            Exit Sub
        End If

        If (txtPassword.Text = "") Then
            MsgBox("Enter the Password")
            txtPassword.Focus() ' Focus the password textbox'
            Exit Sub
        End If

        Try
            ' Establish database connection
            con = New SqlConnection("Data Source=IDEAPAD-GAMING;Initial Catalog=cams;Integrated Security=True")
            con.Open()

            ' Create parameterized query to prevent SQL injection
            Dim query As String = "SELECT COUNT(*) FROM Login WHERE LoginID = @Username AND Password = @Password"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", txtLoginID.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            ' Execute the query
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check if login credentials are valid
            If (count > 0) Then
                Dim userType As String
                Select Case txtLoginID.Text.Substring(0, 1).ToUpper()
                    Case "S"
                        userType = "Student"
                    Case "T"
                        userType = "Teacher"
                    Case Else
                        userType = cboUserType.SelectedItem.ToString()
                End Select

                ' Verify the selected user type against the allowed types
                If txtLoginID.Text.Substring(0, 1).ToUpper() = "S" AndAlso cboUserType.SelectedItem.ToString() <> "Student" Then
                    MsgBox("You are only authorized to access the Student option.")
                    Exit Sub
                ElseIf txtLoginID.Text.Substring(0, 1).ToUpper() = "T" AndAlso cboUserType.SelectedItem.ToString() <> "Teacher" Then
                    MsgBox("You are only authorized to access the Teacher option.")
                    Exit Sub
                End If

                ' Show the appropriate form based on the user type
                Select Case userType
                    Case "Admin"
                        AdminForm.Show()
                    Case "Teacher"
                        TeacherForm.Show()
                    Case "Student"
                        StudentForm.Show()
                End Select
                Me.Hide() ' Hide the login form
            Else
                MsgBox("Invalid LoginID or Password")
                txtLoginID.Text = ""
                txtPassword.Text = ""
            End If

        Catch ex As Exception
            ' Handle exceptions
            MsgBox("An error occurred: " & ex.Message)
        Finally
            ' Close the database connection
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub



    Private Sub txtLoginID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoginID.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MsgBox("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the LoginID field.")
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MsgBox("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9) in the Password field.")
        End If
    End Sub



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserType.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
