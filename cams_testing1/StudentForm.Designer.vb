<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        btnViewAttendance = New Button()
        btnChangePassword = New Button()
        btnLogout = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewAttendance
        ' 
        btnViewAttendance.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnViewAttendance.Location = New Point(461, 293)
        btnViewAttendance.Name = "btnViewAttendance"
        btnViewAttendance.Size = New Size(247, 38)
        btnViewAttendance.TabIndex = 0
        btnViewAttendance.Text = "View Attendance"
        btnViewAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnChangePassword.Location = New Point(461, 426)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(247, 36)
        btnChangePassword.TabIndex = 2
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogout.Location = New Point(1108, 723)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(104, 26)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(461, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 34)
        Label1.TabIndex = 4
        Label1.Text = "STUDENT PAGE"
        ' 
        ' StudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1224, 761)
        Controls.Add(Label1)
        Controls.Add(btnLogout)
        Controls.Add(btnChangePassword)
        Controls.Add(btnViewAttendance)
        Name = "StudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
