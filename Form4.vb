Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form4

    Dim con As New MySqlConnection("host=127.0.0.1; user=root; password=; database=employee_management;")
    Dim cmd As New MySqlCommand
    Dim i As Integer
    Public result As String
    Public dt As New DataTable
    Public da As New MySqlDataAdapter

    Public Overloads Sub Update(ByVal sql As String)
        If TextBox6.Text = "" Then

            MsgBox("Ensure all fields are filled.")

        Else

            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MessageBox.Show("Request Has Not Been Updated!")
                    Else
                        MessageBox.Show("Request Has Been Approved!")
                    End If
                End With

            Catch ex As Exception
                con.Close()
            End Try

            TextBox6.ResetText()
        End If
    End Sub

    Public Overloads Sub Update1(ByVal sql As String)
        If TextBox6.Text = "" Then

            MsgBox("Ensure all fields are filled.")

        Else

            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MessageBox.Show("Request Has Not Been Updated!")
                    Else
                        MessageBox.Show("Request Has Been Disapproved!")
                    End If
                End With

            Catch ex As Exception
                con.Close()
            End Try
            TextBox6.ResetText()
        End If
    End Sub

    Public Sub Reload(ByVal sql As String, ByVal DGT As Object)
        Try
            dt = New DataTable
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DGT.datasource = dt

        Catch ex As Exception
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        TextBox6.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Update("UPDATE `leave_request` SET `Status`='Approved' WHERE `Leave_ID`='" & TextBox6.Text & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Update1("UPDATE `leave_request` SET `Status`='Disapproved' WHERE `Leave_ID`='" & TextBox6.Text & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Reload("SELECT * FROM `leave_request`", DataGridView1)
        Catch ex As Exception

        End Try

    End Sub
End Class