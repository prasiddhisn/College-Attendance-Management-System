Public Class StudentForm
    Private connectionString As String = "Data Source=IDEAPAD-GAMING;Initial Catalog=cams;Integrated Security=True"


    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        ' Open the ViewAttendanceForm
        Dim viewAttendanceForm As New SViewAttendanceForm()
        viewAttendanceForm.Show()
    End Sub


    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ' Open the ChangePasswordForm
        Dim changePasswordForm As New ChangePasswordForm(Me)
        changePasswordForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Close the current form (AdminForm) and show the login form (LoginForm)
        Me.Close()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
