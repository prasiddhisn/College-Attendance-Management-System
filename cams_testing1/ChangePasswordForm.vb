Imports System.Data.SqlClient

Public Class ChangePasswordForm

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
        If txtLoginID.Text <> "" AndAlso txtOldPassword.Text <> "" AndAlso txtNewPassword.Text <> "" AndAlso txtConfirmPassword.Text <> "" Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    ' Retrieve the password associated with the provided LoginID
                    Dim query As String = "SELECT Password FROM Login WHERE LoginID = @LoginID"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
                        Dim dbPassword As String = Convert.ToString(command.ExecuteScalar())

                        ' Check if the entered old password matches the password retrieved from the database
                        If dbPassword = txtOldPassword.Text Then
                            ' Update password in Login table
                            Dim updateQuery As String = "UPDATE Login SET Password = @NewPassword WHERE LoginID = @LoginID"
                            Using updateCommand As New SqlCommand(updateQuery, connection)
                                updateCommand.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
                                updateCommand.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text)
                                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                                If rowsAffected > 0 Then
                                    MessageBox.Show("Password changed successfully!")
                                    ClearFields()
                                Else
                                    MessageBox.Show("LoginID not found.")
                                End If
                            End Using
                        Else
                            MessageBox.Show("Incorrect LoginID or Old Password.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error changing password: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please fill in all required fields.")
        End If
    End Sub


    ' Validate input fields
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtLoginID.Text) OrElse String.IsNullOrWhiteSpace(txtOldPassword.Text) OrElse String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return False
        End If
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("New password and confirm password do not match.")
            Return False
        End If
        If txtNewPassword.Text = txtOldPassword.Text Then
            MessageBox.Show("Your New Password cannot be the same as your Old Password!")
            Return False
        End If
        Return True
    End Function

    ' Clear all input fields
    Private Sub ClearFields()
        txtLoginID.Clear()
        txtOldPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub

    ' Button to clear all input fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
    Private Sub txtLoginID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoginID.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9).")
        End If
    End Sub

    ' KeyPress event handler for Old Password TextBox
    Private Sub txtOldPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldPassword.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9).")
        End If
    End Sub

    ' KeyPress event handler for New Password TextBox
    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9).")
        End If
    End Sub

    ' KeyPress event handler for Confirm Password TextBox
    Private Sub txtConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmPassword.KeyPress
        ' Check if the entered character is not a letter or digit
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
            MessageBox.Show("Invalid character entered! Please use only character and numeric values (a-z, A-Z, 0-9).")
        End If
    End Sub
    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
