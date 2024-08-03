<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyAttendanceForm
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
        savechangesButton = New Button()
        backButton = New Button()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        Label8 = New Label()
        studentid = New ComboBox()
        studentname = New ComboBox()
        course = New ComboBox()
        subject = New ComboBox()
        teachername = New ComboBox()
        attendancestatus = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        updateButton = New Button()
        attendanceid = New TextBox()
        clearButton = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        loginid = New ComboBox()
        coursecode = New ComboBox()
        subjectcode = New ComboBox()
        teacherid = New ComboBox()
        deleteRecordButton = New Button()
        Label13 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(268, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 3
        Label1.Text = "Attendance ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(44, 450)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 4
        Label2.Text = "Subject Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(350, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 20)
        Label3.TabIndex = 5
        Label3.Text = "Attendance Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(42, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 20)
        Label4.TabIndex = 6
        Label4.Text = "Student Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(42, 561)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 20)
        Label5.TabIndex = 7
        Label5.Text = "Teacher Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(399, 353)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 8
        Label6.Text = "Date "
        ' 
        ' savechangesButton
        ' 
        savechangesButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        savechangesButton.Location = New Point(423, 661)
        savechangesButton.Name = "savechangesButton"
        savechangesButton.Size = New Size(102, 29)
        savechangesButton.TabIndex = 18
        savechangesButton.Text = "Save Changes"
        savechangesButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        backButton.Location = New Point(117, 661)
        backButton.Name = "backButton"
        backButton.Size = New Size(82, 29)
        backButton.TabIndex = 19
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(700, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(784, 501)
        DataGridView1.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(63, 182)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 21
        Label7.Text = "Student ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(81, 341)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 20)
        Label8.TabIndex = 22
        Label8.Text = "Course"
        ' 
        ' studentid
        ' 
        studentid.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        studentid.FormattingEnabled = True
        studentid.Location = New Point(166, 174)
        studentid.Name = "studentid"
        studentid.Size = New Size(121, 28)
        studentid.TabIndex = 23
        ' 
        ' studentname
        ' 
        studentname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        studentname.FormattingEnabled = True
        studentname.Location = New Point(166, 226)
        studentname.Name = "studentname"
        studentname.Size = New Size(121, 28)
        studentname.TabIndex = 24
        ' 
        ' course
        ' 
        course.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        course.FormattingEnabled = True
        course.Location = New Point(166, 333)
        course.Name = "course"
        course.Size = New Size(121, 28)
        course.TabIndex = 25
        ' 
        ' subject
        ' 
        subject.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        subject.FormattingEnabled = True
        subject.Location = New Point(168, 442)
        subject.Name = "subject"
        subject.Size = New Size(121, 28)
        subject.TabIndex = 26
        ' 
        ' teachername
        ' 
        teachername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        teachername.FormattingEnabled = True
        teachername.Location = New Point(166, 553)
        teachername.Name = "teachername"
        teachername.Size = New Size(121, 28)
        teachername.TabIndex = 27
        ' 
        ' attendancestatus
        ' 
        attendancestatus.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        attendancestatus.FormattingEnabled = True
        attendancestatus.Location = New Point(495, 277)
        attendancestatus.Name = "attendancestatus"
        attendancestatus.Size = New Size(121, 28)
        attendancestatus.TabIndex = 28
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(467, 348)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 27)
        DateTimePicker1.TabIndex = 29
        ' 
        ' updateButton
        ' 
        updateButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        updateButton.Location = New Point(318, 661)
        updateButton.Name = "updateButton"
        updateButton.Size = New Size(75, 29)
        updateButton.TabIndex = 30
        updateButton.Text = "Update changes"
        updateButton.UseVisualStyleBackColor = True
        ' 
        ' attendanceid
        ' 
        attendanceid.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        attendanceid.Location = New Point(376, 62)
        attendanceid.Name = "attendanceid"
        attendanceid.Size = New Size(100, 27)
        attendanceid.TabIndex = 31
        ' 
        ' clearButton
        ' 
        clearButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        clearButton.Location = New Point(214, 661)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(75, 29)
        clearButton.TabIndex = 32
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(84, 134)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 20)
        Label9.TabIndex = 33
        Label9.Text = "Login ID"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(50, 288)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 20)
        Label10.TabIndex = 34
        Label10.Text = "Course Code"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(48, 395)
        Label11.Name = "Label11"
        Label11.Size = New Size(97, 20)
        Label11.TabIndex = 35
        Label11.Text = "Subject Code"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(64, 505)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 20)
        Label12.TabIndex = 36
        Label12.Text = "Teacher ID"
        ' 
        ' loginid
        ' 
        loginid.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        loginid.FormattingEnabled = True
        loginid.Location = New Point(166, 126)
        loginid.Name = "loginid"
        loginid.Size = New Size(121, 28)
        loginid.TabIndex = 37
        ' 
        ' coursecode
        ' 
        coursecode.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        coursecode.FormattingEnabled = True
        coursecode.Location = New Point(166, 280)
        coursecode.Name = "coursecode"
        coursecode.Size = New Size(121, 28)
        coursecode.TabIndex = 38
        ' 
        ' subjectcode
        ' 
        subjectcode.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        subjectcode.FormattingEnabled = True
        subjectcode.Location = New Point(166, 387)
        subjectcode.Name = "subjectcode"
        subjectcode.Size = New Size(121, 28)
        subjectcode.TabIndex = 39
        ' 
        ' teacherid
        ' 
        teacherid.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        teacherid.FormattingEnabled = True
        teacherid.Location = New Point(166, 497)
        teacherid.Name = "teacherid"
        teacherid.Size = New Size(121, 28)
        teacherid.TabIndex = 40
        ' 
        ' deleteRecordButton
        ' 
        deleteRecordButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        deleteRecordButton.Location = New Point(548, 661)
        deleteRecordButton.Name = "deleteRecordButton"
        deleteRecordButton.Size = New Size(119, 29)
        deleteRecordButton.TabIndex = 41
        deleteRecordButton.Text = "Delete Record"
        deleteRecordButton.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(789, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(618, 31)
        Label13.TabIndex = 42
        Label13.Text = "MODIFY STUDENT ATTENDNACE RECORDS"
        ' 
        ' ModifyAttendanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1496, 761)
        Controls.Add(Label13)
        Controls.Add(deleteRecordButton)
        Controls.Add(teacherid)
        Controls.Add(subjectcode)
        Controls.Add(coursecode)
        Controls.Add(loginid)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(clearButton)
        Controls.Add(attendanceid)
        Controls.Add(updateButton)
        Controls.Add(DateTimePicker1)
        Controls.Add(attendancestatus)
        Controls.Add(teachername)
        Controls.Add(subject)
        Controls.Add(course)
        Controls.Add(studentname)
        Controls.Add(studentid)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(backButton)
        Controls.Add(savechangesButton)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ModifyAttendanceForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ModifyAttendanceForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents savechangesButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents studentid As ComboBox
    Friend WithEvents studentname As ComboBox
    Friend WithEvents course As ComboBox
    Friend WithEvents subject As ComboBox
    Friend WithEvents teachername As ComboBox
    Friend WithEvents attendancestatus As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents updateButton As Button
    Friend WithEvents attendanceid As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents loginid As ComboBox
    Friend WithEvents coursecode As ComboBox
    Friend WithEvents subjectcode As ComboBox
    Friend WithEvents teacherid As ComboBox
    Friend WithEvents deleteRecordButton As Button
    Friend WithEvents Label13 As Label
End Class
