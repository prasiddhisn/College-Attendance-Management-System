<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTeacherForm
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
        Label5 = New Label()
        txtTID = New TextBox()
        txtTeacherName = New TextBox()
        txtMobileNo = New TextBox()
        txtLoginID = New TextBox()
        btnSave = New Button()
        Label6 = New Label()
        btnClear = New Button()
        txtPassword = New TextBox()
        btnBack = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        cmbCourseCode = New ComboBox()
        cmbCourse = New ComboBox()
        cmbSubjectCode = New ComboBox()
        cmbSubjectName = New ComboBox()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(176, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Teacher ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(155, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Teacher Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(146, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mobile Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(675, 282)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 3
        Label4.Text = "Subject Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(416, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 20)
        Label5.TabIndex = 4
        Label5.Text = "LoginID"
        ' 
        ' txtTID
        ' 
        txtTID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTID.Location = New Point(308, 115)
        txtTID.Name = "txtTID"
        txtTID.Size = New Size(100, 27)
        txtTID.TabIndex = 5
        ' 
        ' txtTeacherName
        ' 
        txtTeacherName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTeacherName.Location = New Point(308, 179)
        txtTeacherName.Name = "txtTeacherName"
        txtTeacherName.Size = New Size(100, 27)
        txtTeacherName.TabIndex = 6
        ' 
        ' txtMobileNo
        ' 
        txtMobileNo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMobileNo.Location = New Point(308, 241)
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(100, 27)
        txtMobileNo.TabIndex = 7
        ' 
        ' txtLoginID
        ' 
        txtLoginID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLoginID.Location = New Point(554, 381)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.Size = New Size(100, 27)
        txtLoginID.TabIndex = 9
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(512, 568)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 32)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(416, 452)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 11
        Label6.Text = "Password"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(641, 568)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 32)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(554, 444)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 27)
        txtPassword.TabIndex = 13
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(402, 568)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 32)
        btnBack.TabIndex = 14
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(690, 164)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 20)
        Label7.TabIndex = 15
        Label7.Text = "Course"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(675, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 20)
        Label8.TabIndex = 16
        Label8.Text = "Course Code"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(675, 223)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 20)
        Label9.TabIndex = 17
        Label9.Text = "Subject Code"
        ' 
        ' cmbCourseCode
        ' 
        cmbCourseCode.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourseCode.FormattingEnabled = True
        cmbCourseCode.Location = New Point(875, 105)
        cmbCourseCode.Name = "cmbCourseCode"
        cmbCourseCode.Size = New Size(121, 28)
        cmbCourseCode.TabIndex = 18
        ' 
        ' cmbCourse
        ' 
        cmbCourse.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(875, 156)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(121, 28)
        cmbCourse.TabIndex = 19
        ' 
        ' cmbSubjectCode
        ' 
        cmbSubjectCode.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbSubjectCode.FormattingEnabled = True
        cmbSubjectCode.Location = New Point(875, 220)
        cmbSubjectCode.Name = "cmbSubjectCode"
        cmbSubjectCode.Size = New Size(121, 28)
        cmbSubjectCode.TabIndex = 20
        ' 
        ' cmbSubjectName
        ' 
        cmbSubjectName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbSubjectName.FormattingEnabled = True
        cmbSubjectName.Location = New Point(875, 279)
        cmbSubjectName.Name = "cmbSubjectName"
        cmbSubjectName.Size = New Size(121, 28)
        cmbSubjectName.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(471, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(221, 31)
        Label10.TabIndex = 22
        Label10.Text = "ADD TEACHER"
        ' 
        ' AddTeacherForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1220, 660)
        Controls.Add(Label10)
        Controls.Add(cmbSubjectName)
        Controls.Add(cmbSubjectCode)
        Controls.Add(cmbCourse)
        Controls.Add(cmbCourseCode)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btnBack)
        Controls.Add(txtPassword)
        Controls.Add(btnClear)
        Controls.Add(Label6)
        Controls.Add(btnSave)
        Controls.Add(txtLoginID)
        Controls.Add(txtMobileNo)
        Controls.Add(txtTeacherName)
        Controls.Add(txtTID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddTeacherForm"
        Text = "AddTeacherForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTID As TextBox
    Friend WithEvents txtTeacherName As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCourseCode As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbSubjectCode As ComboBox
    Friend WithEvents cmbSubjectName As ComboBox
    Friend WithEvents Label10 As Label
End Class
