<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnModifyAttendance = New Button()
        btnViewAttendance = New Button()
        btnAddStudent = New Button()
        btnChangePassword = New Button()
        btnLogout = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnModifyAttendance
        ' 
        btnModifyAttendance.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnModifyAttendance.Location = New Point(439, 189)
        btnModifyAttendance.Name = "btnModifyAttendance"
        btnModifyAttendance.Size = New Size(285, 46)
        btnModifyAttendance.TabIndex = 0
        btnModifyAttendance.Text = "Modify Attendance"
        btnModifyAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnViewAttendance
        ' 
        btnViewAttendance.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnViewAttendance.Location = New Point(439, 296)
        btnViewAttendance.Name = "btnViewAttendance"
        btnViewAttendance.Size = New Size(285, 48)
        btnViewAttendance.TabIndex = 1
        btnViewAttendance.Text = "View Attendance"
        btnViewAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddStudent.Location = New Point(439, 398)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(285, 48)
        btnAddStudent.TabIndex = 3
        btnAddStudent.Text = "Add Student"
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnChangePassword.Location = New Point(439, 497)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(285, 46)
        btnChangePassword.TabIndex = 4
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.Location = New Point(1095, 719)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(117, 30)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(458, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 34)
        Label1.TabIndex = 6
        Label1.Text = "TEACHER PAGE"
        ' 
        ' TeacherForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1224, 761)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Controls.Add(btnChangePassword)
        Controls.Add(btnAddStudent)
        Controls.Add(btnViewAttendance)
        Controls.Add(btnModifyAttendance)
        Name = "TeacherForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TeacherForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnModifyAttendance As Button
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
