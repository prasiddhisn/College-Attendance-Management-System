Public Class TeacherForm

    Private Sub btnModifyAttendance_Click(sender As Object, e As EventArgs) Handles btnModifyAttendance.Click
        ' Open the ModifyAttendanceForm
        Dim modifyAttendanceForm As New ModifyAttendanceForm()
        modifyAttendanceForm.Show()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        ' Open the ViewAttendanceForm
        Dim ATviewAttendanceForm As New ATViewAttendanceForm()
        ATviewAttendanceForm.Show()
    End Sub


    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        ' Open the AddStudentForm
        Dim addStudentForm As New AddStudentForm(Me)
        addStudentForm.Show()
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

    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
