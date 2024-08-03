<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnSave = New Button()
        btnClear = New Button()
        btnBack = New Button()
        txtLoginID = New TextBox()
        txtOldPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(479, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 0
        Label1.Text = "LoginID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(464, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 1
        Label2.Text = "Old Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(459, 362)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 2
        Label3.Text = "New Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(449, 430)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 20)
        Label4.TabIndex = 3
        Label4.Text = "Confirm Password"
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(396, 558)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 34)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(531, 558)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 34)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(679, 558)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 34)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtLoginID
        ' 
        txtLoginID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLoginID.Location = New Point(614, 220)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.Size = New Size(100, 27)
        txtLoginID.TabIndex = 7
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtOldPassword.Location = New Point(614, 283)
        txtOldPassword.Name = "txtOldPassword"
        txtOldPassword.Size = New Size(100, 27)
        txtOldPassword.TabIndex = 8
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNewPassword.Location = New Point(614, 354)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(100, 27)
        txtNewPassword.TabIndex = 9
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtConfirmPassword.Location = New Point(614, 422)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(100, 27)
        txtConfirmPassword.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(449, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(303, 31)
        Label5.TabIndex = 11
        Label5.Text = "CHANGE PASSWORD"
        ' 
        ' ChangePasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1221, 761)
        Controls.Add(Label5)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(txtOldPassword)
        Controls.Add(txtLoginID)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ChangePasswordForm"
        Text = "ChangePasswordForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label5 As Label
End Class
