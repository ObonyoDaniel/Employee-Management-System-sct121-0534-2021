<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        Button6 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.LimeGreen
        Button1.Location = New Point(29, 262)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 29)
        Button1.TabIndex = 13
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(153, 166)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(190, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(145, 134)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(29, 134)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 10
        Label4.Text = "Email Address :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(29, 167)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 9
        Label3.Text = "Phone Number :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(121, 48)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 15)
        Label2.TabIndex = 8
        Label2.Text = "Welcome Administrator! "' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(8, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 26)
        Label1.TabIndex = 7
        Label1.Text = "Employee Management System"' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(114, 232)
        TextBox3.Margin = New Padding(2, 2, 2, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(199, 23)
        TextBox3.TabIndex = 17
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(29, 198)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 15
        Label5.Text = "Title :"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(29, 231)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 20)
        Label6.TabIndex = 14
        Label6.Text = "Password :"' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(145, 100)
        TextBox6.Margin = New Padding(2, 2, 2, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(199, 23)
        TextBox6.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(29, 101)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 20)
        Label7.TabIndex = 19
        Label7.Text = "Fullname :"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Manager", "Doctor", "Financier", "Accountant", "Engineer", "Nurse"})
        ComboBox1.Location = New Point(80, 203)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 23)
        ComboBox1.TabIndex = 21
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.OrangeRed
        Button2.Location = New Point(227, 262)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 29)
        Button2.TabIndex = 22
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.DarkRed
        Button3.Location = New Point(29, 306)
        Button3.Margin = New Padding(2, 2, 2, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(85, 29)
        Button3.TabIndex = 23
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Purple
        Button4.Location = New Point(227, 306)
        Button4.Margin = New Padding(2, 2, 2, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(85, 29)
        Button4.TabIndex = 24
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(384, 100)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(578, 175)
        DataGridView1.TabIndex = 25
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.Red
        Button5.Location = New Point(384, 306)
        Button5.Margin = New Padding(2, 2, 2, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(85, 29)
        Button5.TabIndex = 26
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.Orange
        Button6.Location = New Point(817, 306)
        Button6.Margin = New Padding(2, 2, 2, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(146, 29)
        Button6.TabIndex = 27
        Button6.Text = "Load Users"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(959, 348)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
