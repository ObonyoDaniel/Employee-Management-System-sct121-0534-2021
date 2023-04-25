<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(103, 33)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 26)
        Label1.TabIndex = 0
        Label1.Text = "Employee Management System"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 76)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 15)
        Label2.TabIndex = 1
        Label2.Text = "Welcome! Kindly sign to proceed..."' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(64, 148)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(64, 112)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 3
        Label4.Text = "Email Address :"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(181, 112)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(181, 148)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(199, 23)
        TextBox2.TabIndex = 5
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.LimeGreen
        Button1.Location = New Point(230, 224)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 29)
        Button1.TabIndex = 6
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Administrator", "Other (e.g. Employee)"})
        ComboBox1.Location = New Point(181, 186)
        ComboBox1.Margin = New Padding(2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(199, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(64, 188)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 8
        Label5.Text = "Title :"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
End Class
