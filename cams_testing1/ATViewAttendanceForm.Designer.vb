<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATViewAttendanceForm
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
        DataGridView1 = New DataGridView()
        filterButton = New Button()
        backButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        studentIDTextBox = New TextBox()
        clearButton = New Button()
        courseComboBox = New ComboBox()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(116, 165)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(964, 459)
        DataGridView1.TabIndex = 0
        ' 
        ' filterButton
        ' 
        filterButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        filterButton.Location = New Point(777, 110)
        filterButton.Name = "filterButton"
        filterButton.Size = New Size(123, 29)
        filterButton.TabIndex = 1
        filterButton.Text = "Search"
        filterButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        backButton.Location = New Point(543, 664)
        backButton.Name = "backButton"
        backButton.Size = New Size(90, 29)
        backButton.TabIndex = 2
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(190, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 3
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(479, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 4
        Label2.Text = "Course"
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        studentIDTextBox.Location = New Point(277, 112)
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.Size = New Size(100, 27)
        studentIDTextBox.TabIndex = 6
        ' 
        ' clearButton
        ' 
        clearButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        clearButton.Location = New Point(921, 107)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(120, 32)
        clearButton.TabIndex = 7
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' courseComboBox
        ' 
        courseComboBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        courseComboBox.FormattingEnabled = True
        courseComboBox.Location = New Point(552, 110)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(121, 28)
        courseComboBox.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(397, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(437, 31)
        Label3.TabIndex = 9
        Label3.Text = "VIEW STUDENT ATTENDANCE"
        ' 
        ' ATViewAttendanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1224, 761)
        Controls.Add(Label3)
        Controls.Add(courseComboBox)
        Controls.Add(clearButton)
        Controls.Add(studentIDTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(backButton)
        Controls.Add(filterButton)
        Controls.Add(DataGridView1)
        Name = "ATViewAttendanceForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TViewAttendanceForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents filterButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents studentIDTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents courseComboBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
