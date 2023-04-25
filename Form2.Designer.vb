<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label2 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.LimeGreen
        Button1.Location = New Point(286, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 48)
        Button1.TabIndex = 13
        Button1.Text = "Manage Employees"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(492, 25)
        Label2.TabIndex = 8
        Label2.Text = "Welcome Administrator! Kindly select an option to proceed..."' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(181, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 41)
        Label1.TabIndex = 7
        Label1.Text = "Employee Management System"' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.LimeGreen
        Button2.Location = New Point(269, 273)
        Button2.Name = "Button2"
        Button2.Size = New Size(283, 48)
        Button2.TabIndex = 14
        Button2.Text = "Manage Leave Requests"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(286, 357)
        Button3.Name = "Button3"
        Button3.Size = New Size(245, 48)
        Button3.TabIndex = 15
        Button3.Text = "Logout"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
