<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LaVp = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        GroupBox1 = New GroupBox()
        btnSaveChanges = New Button()
        btnSave = New Button()
        txtGender = New TextBox()
        txtAge = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtContactNumber = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtName = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LaVp
        ' 
        LaVp.BackColor = Color.RosyBrown
        LaVp.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        LaVp.FullRowSelect = True
        LaVp.GridLines = True
        LaVp.Location = New Point(486, 30)
        LaVp.Name = "LaVp"
        LaVp.Size = New Size(534, 350)
        LaVp.TabIndex = 0
        LaVp.UseCompatibleStateImageBehavior = False
        LaVp.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "id"
        ColumnHeader1.Width = 0
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "No"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Name"
        ColumnHeader3.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Contact Number"
        ColumnHeader4.Width = 120
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Age"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Gender"
        ColumnHeader6.Width = 100
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Gray
        GroupBox1.Controls.Add(btnSaveChanges)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtGender)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtContactNumber)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(459, 350)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Beauty Salon Form"
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.LightGreen
        btnSaveChanges.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSaveChanges.Location = New Point(169, 301)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(137, 32)
        btnSaveChanges.TabIndex = 8
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightGreen
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(29, 301)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(74, 32)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtGender
        ' 
        txtGender.BackColor = Color.MistyRose
        txtGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGender.Location = New Point(191, 211)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(234, 29)
        txtGender.TabIndex = 7
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = Color.MistyRose
        txtAge.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(191, 153)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(234, 29)
        txtAge.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(29, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 21)
        Label4.TabIndex = 5
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 21)
        Label3.TabIndex = 4
        Label3.Text = "Age:"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.BackColor = Color.MistyRose
        txtContactNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContactNumber.Location = New Point(191, 104)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(234, 33)
        txtContactNumber.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 21)
        Label2.TabIndex = 2
        Label2.Text = "Contact Number:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 21)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.MistyRose
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(191, 50)
        txtName.Name = "txtName"
        txtName.Size = New Size(234, 29)
        txtName.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1090, 450)
        Controls.Add(GroupBox1)
        Controls.Add(LaVp)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LaVp As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnSaveChanges As Button

End Class
