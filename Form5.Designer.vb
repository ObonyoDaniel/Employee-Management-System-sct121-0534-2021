<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        PrintDialog1 = New PrintDialog()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        Button6 = New Button()
        DataGridView2 = New DataGridView()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Button2 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label9 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.Red
        Button5.Location = New Point(308, 323)
        Button5.Margin = New Padding(2, 2, 2, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(85, 29)
        Button5.TabIndex = 44
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(663, 218)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(678, 175)
        DataGridView1.TabIndex = 43
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Purple
        Button4.Location = New Point(278, 226)
        Button4.Margin = New Padding(2, 2, 2, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(85, 29)
        Button4.TabIndex = 42
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.DarkRed
        Button3.Location = New Point(38, 323)
        Button3.Margin = New Padding(2, 2, 2, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(85, 29)
        Button3.TabIndex = 41
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(154, 99)
        TextBox6.Margin = New Padding(2, 2, 2, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(199, 23)
        TextBox6.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(38, 100)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 20)
        Label7.TabIndex = 37
        Label7.Text = "Employee ID :"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.LimeGreen
        Button1.Location = New Point(38, 226)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 29)
        Button1.TabIndex = 33
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 133)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 23)
        TextBox1.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(38, 133)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 30
        Label4.Text = "Reason :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(38, 166)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 29
        Label3.Text = "Date :"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(130, 47)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 15)
        Label2.TabIndex = 28
        Label2.Text = "Welcome Employee!"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(18, 4)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 26)
        Label1.TabIndex = 27
        Label1.Text = "Employee Management System"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(573, 298)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 25)
        Label8.TabIndex = 47
        Label8.Text = "Users :"' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.Orange
        Button6.Location = New Point(509, 359)
        Button6.Margin = New Padding(2, 2, 2, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(136, 34)
        Button6.TabIndex = 48
        Button6.Text = "Load Users"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(764, 9)
        DataGridView2.Margin = New Padding(2, 2, 2, 2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.RowTemplate.Height = 33
        DataGridView2.Size = New Size(574, 175)
        DataGridView2.TabIndex = 50
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(596, 95)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 25)
        Label5.TabIndex = 51
        Label5.Text = "Leave Requests :"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(154, 268)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(199, 23)
        TextBox2.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(38, 268)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 20)
        Label6.TabIndex = 52
        Label6.Text = "Request ID :"' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Orange
        Button2.Location = New Point(596, 150)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 34)
        Button2.TabIndex = 54
        Button2.Text = "Load Requests"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(130, 166)
        TextBox3.Margin = New Padding(2, 2, 2, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(199, 23)
        TextBox3.TabIndex = 55
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(130, 196)
        TextBox4.Margin = New Padding(2, 2, 2, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(199, 23)
        TextBox4.TabIndex = 57
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(38, 195)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 20)
        Label9.TabIndex = 56
        Label9.Text = "Time :"' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(959, 441)
        Controls.Add(TextBox4)
        Controls.Add(Label9)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DataGridView2)
        Controls.Add(Button6)
        Controls.Add(Label8)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form5"
        Text = "Form5"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
End Class
