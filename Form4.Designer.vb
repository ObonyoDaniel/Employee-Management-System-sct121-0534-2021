<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button2 = New Button()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Button6 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Button5.Location = New Point(51, 336)
        Button5.Name = "Button5"
        Button5.Size = New Size(121, 48)
        Button5.TabIndex = 44
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(532, 123)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(967, 291)
        DataGridView1.TabIndex = 43
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.OrangeRed
        Button2.Location = New Point(329, 237)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 48)
        Button2.TabIndex = 40
        Button2.Text = "Disapprove"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(183, 168)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(282, 31)
        TextBox6.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(51, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 30)
        Label7.TabIndex = 37
        Label7.Text = "Leave ID :"' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.LimeGreen
        Button1.Location = New Point(51, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 48)
        Button1.TabIndex = 33
        Button1.Text = "Approve"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(183, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 25)
        Label2.TabIndex = 28
        Label2.Text = "Welcome Administrator! "' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(22, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 41)
        Label1.TabIndex = 27
        Label1.Text = "Employee Management System"' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.Orange
        Button6.Location = New Point(289, 336)
        Button6.Name = "Button6"
        Button6.Size = New Size(194, 56)
        Button6.TabIndex = 49
        Button6.Text = "Load Requests"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1514, 457)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
End Class
