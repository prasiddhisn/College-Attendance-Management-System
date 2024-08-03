<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SViewAttendanceForm
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
        Label1 = New Label()
        backButton = New Button()
        filterButton = New Button()
        clearButton = New Button()
        subjectComboBox = New ComboBox()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(99, 143)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(997, 500)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(406, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 1
        Label1.Text = "Subject "
        ' 
        ' backButton
        ' 
        backButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        backButton.Location = New Point(560, 671)
        backButton.Name = "backButton"
        backButton.Size = New Size(75, 31)
        backButton.TabIndex = 2
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' filterButton
        ' 
        filterButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        filterButton.Location = New Point(647, 87)
        filterButton.Name = "filterButton"
        filterButton.Size = New Size(75, 29)
        filterButton.TabIndex = 4
        filterButton.Text = "Search"
        filterButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        clearButton.Location = New Point(747, 87)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(75, 29)
        clearButton.TabIndex = 5
        clearButton.Text = "Clear "
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' subjectComboBox
        ' 
        subjectComboBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        subjectComboBox.FormattingEnabled = True
        subjectComboBox.Location = New Point(474, 92)
        subjectComboBox.Name = "subjectComboBox"
        subjectComboBox.Size = New Size(121, 28)
        subjectComboBox.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calisto MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(388, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(495, 31)
        Label2.TabIndex = 7
        Label2.Text = "STUDENT ATTENDANCE RECORDS"
        ' 
        ' SViewAttendanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1224, 761)
        Controls.Add(Label2)
        Controls.Add(subjectComboBox)
        Controls.Add(clearButton)
        Controls.Add(filterButton)
        Controls.Add(backButton)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "SViewAttendanceForm"
        Text = "SViewAttendanceForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents filterButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents subjectComboBox As ComboBox
    Friend WithEvents Label2 As Label
End Class
