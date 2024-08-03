<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        btnLogin = New Button()
        txtLoginID = New TextBox()
        txtPassword = New TextBox()
        cboUserType = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Bright", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(434, 307)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 23)
        Label1.TabIndex = 0
        Label1.Text = "LoginID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Bright", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(428, 419)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 23)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(519, 644)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(136, 34)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtLoginID
        ' 
        txtLoginID.Location = New Point(621, 307)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.Size = New Size(155, 23)
        txtLoginID.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(621, 419)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(155, 23)
        txtPassword.TabIndex = 4
        ' 
        ' cboUserType
        ' 
        cboUserType.AllowDrop = True
        cboUserType.FormattingEnabled = True
        cboUserType.Items.AddRange(New Object() {"Admin", "Teacher", "Student"})
        cboUserType.Location = New Point(621, 536)
        cboUserType.Name = "cboUserType"
        cboUserType.Size = New Size(155, 23)
        cboUserType.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Bright", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(434, 536)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 23)
        Label3.TabIndex = 6
        Label3.Text = "Usertype"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Calisto MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(123, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(957, 43)
        Label4.TabIndex = 7
        Label4.Text = "COLLEGE ATTENDANCE MANAGEMENT SYSTEM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Calisto MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(519, 169)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 36)
        Label5.TabIndex = 8
        Label5.Text = "User Login "
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Bisque
        ClientSize = New Size(1224, 761)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cboUserType)
        Controls.Add(txtPassword)
        Controls.Add(txtLoginID)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboUserType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
