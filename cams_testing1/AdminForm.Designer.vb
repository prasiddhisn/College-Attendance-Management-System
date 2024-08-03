<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        btnAddTeacher = New Button()
        btnChangePassword = New Button()
        btnLogout = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnModifyAttendance
        ' 
        btnModifyAttendance.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnModifyAttendance.Location = New Point(431, 163)
        btnModifyAttendance.Name = "btnModifyAttendance"
        btnModifyAttendance.Size = New Size(273, 34)
        btnModifyAttendance.TabIndex = 0
        btnModifyAttendance.Text = "Modify Attendance "
        btnModifyAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnViewAttendance
        ' 
        btnViewAttendance.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnViewAttendance.Location = New Point(431, 258)
        btnViewAttendance.Name = "btnViewAttendance"
        btnViewAttendance.Size = New Size(273, 34)
        btnViewAttendance.TabIndex = 1
        btnViewAttendance.Text = "View Attendance"
        btnViewAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddStudent.Location = New Point(431, 350)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(273, 34)
        btnAddStudent.TabIndex = 3
        btnAddStudent.Text = "Add Student"
        btnAddStudent.UseVisualStyleBackColor = True
        ' 
        ' btnAddTeacher
        ' 
        btnAddTeacher.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddTeacher.Location = New Point(431, 444)
        btnAddTeacher.Name = "btnAddTeacher"
        btnAddTeacher.Size = New Size(273, 34)
        btnAddTeacher.TabIndex = 4
        btnAddTeacher.Text = "Add Teacher"
        btnAddTeacher.UseVisualStyleBackColor = True
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnChangePassword.Location = New Point(431, 530)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(273, 34)
        btnChangePassword.TabIndex = 6
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.Location = New Point(1094, 717)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(118, 32)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(464, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 34)
        Label1.TabIndex = 8
        Label1.Text = "ADMIN PAGE"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1224, 761)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Controls.Add(btnChangePassword)
        Controls.Add(btnAddTeacher)
        Controls.Add(btnAddStudent)
        Controls.Add(btnViewAttendance)
        Controls.Add(btnModifyAttendance)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnModifyAttendance As Button
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnAddTeacher As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
