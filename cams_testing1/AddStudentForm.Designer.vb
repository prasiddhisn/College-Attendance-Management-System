<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudentForm
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
        Label6 = New Label()
        Label7 = New Label()
        dtpSDOB = New DateTimePicker()
        Label8 = New Label()
        txtSID = New TextBox()
        txtSName = New TextBox()
        txtSRollNo = New TextBox()
        txtSMobileNo = New TextBox()
        txtYear = New TextBox()
        txtSemester = New TextBox()
        txtPassword = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        txtLoginID = New TextBox()
        btnSave = New Button()
        btnClear = New Button()
        btnBack = New Button()
        Label11 = New Label()
        cmbCourseCode = New ComboBox()
        cmbCourse = New ComboBox()
        Label12 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(85, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(74, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Student Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(74, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 2
        Label3.Text = "Roll Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(75, 350)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 20)
        Label4.TabIndex = 3
        Label4.Text = "Date of Birth"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(66, 428)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 4
        Label5.Text = "Mobile Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(697, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 20)
        Label6.TabIndex = 5
        Label6.Text = "Course"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(705, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 20)
        Label7.TabIndex = 6
        Label7.Text = "Year"
        ' 
        ' dtpSDOB
        ' 
        dtpSDOB.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        dtpSDOB.Location = New Point(193, 344)
        dtpSDOB.Name = "dtpSDOB"
        dtpSDOB.Size = New Size(200, 27)
        dtpSDOB.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(686, 344)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 20)
        Label8.TabIndex = 8
        Label8.Text = "Semester"
        ' 
        ' txtSID
        ' 
        txtSID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSID.Location = New Point(208, 116)
        txtSID.Name = "txtSID"
        txtSID.Size = New Size(100, 27)
        txtSID.TabIndex = 9
        ' 
        ' txtSName
        ' 
        txtSName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSName.Location = New Point(208, 178)
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(100, 27)
        txtSName.TabIndex = 10
        ' 
        ' txtSRollNo
        ' 
        txtSRollNo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSRollNo.Location = New Point(208, 267)
        txtSRollNo.Name = "txtSRollNo"
        txtSRollNo.Size = New Size(100, 27)
        txtSRollNo.TabIndex = 11
        ' 
        ' txtSMobileNo
        ' 
        txtSMobileNo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSMobileNo.Location = New Point(208, 425)
        txtSMobileNo.Name = "txtSMobileNo"
        txtSMobileNo.Size = New Size(100, 27)
        txtSMobileNo.TabIndex = 12
        ' 
        ' txtYear
        ' 
        txtYear.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtYear.Location = New Point(842, 275)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(100, 27)
        txtYear.TabIndex = 14
        ' 
        ' txtSemester
        ' 
        txtSemester.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtSemester.Location = New Point(842, 341)
        txtSemester.Name = "txtSemester"
        txtSemester.Size = New Size(100, 27)
        txtSemester.TabIndex = 15
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(943, 449)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 27)
        txtPassword.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(591, 452)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 20)
        Label9.TabIndex = 17
        Label9.Text = "LoginID"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(855, 452)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 20)
        Label10.TabIndex = 18
        Label10.Text = "Password"
        ' 
        ' txtLoginID
        ' 
        txtLoginID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLoginID.Location = New Point(679, 452)
        txtLoginID.Name = "txtLoginID"
        txtLoginID.Size = New Size(100, 27)
        txtLoginID.TabIndex = 19
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(551, 584)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 33)
        btnSave.TabIndex = 20
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(705, 584)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 33)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(406, 584)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 33)
        btnBack.TabIndex = 22
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(679, 142)
        Label11.Name = "Label11"
        Label11.Size = New Size(93, 20)
        Label11.TabIndex = 23
        Label11.Text = "Course Code"
        ' 
        ' cmbCourseCode
        ' 
        cmbCourseCode.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourseCode.FormattingEnabled = True
        cmbCourseCode.Location = New Point(831, 135)
        cmbCourseCode.Name = "cmbCourseCode"
        cmbCourseCode.Size = New Size(121, 28)
        cmbCourseCode.TabIndex = 24
        ' 
        ' cmbCourse
        ' 
        cmbCourse.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(831, 205)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(121, 28)
        cmbCourse.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(481, 32)
        Label12.Name = "Label12"
        Label12.Size = New Size(221, 31)
        Label12.TabIndex = 26
        Label12.Text = "ADD STUDENT"
        ' 
        ' AddStudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1224, 694)
        Controls.Add(Label12)
        Controls.Add(cmbCourse)
        Controls.Add(cmbCourseCode)
        Controls.Add(Label11)
        Controls.Add(btnBack)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(txtLoginID)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtPassword)
        Controls.Add(txtSemester)
        Controls.Add(txtYear)
        Controls.Add(txtSMobileNo)
        Controls.Add(txtSRollNo)
        Controls.Add(txtSName)
        Controls.Add(txtSID)
        Controls.Add(Label8)
        Controls.Add(dtpSDOB)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddStudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpSDOB As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSID As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtSRollNo As TextBox
    Friend WithEvents txtSMobileNo As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbCourseCode As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents Label12 As Label
End Class
