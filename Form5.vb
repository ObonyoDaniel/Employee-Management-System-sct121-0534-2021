Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form5

    Dim con As New MySqlConnection("host=127.0.0.1; user=root; password=; database=employee_management;")
    Dim cmd As New MySqlCommand
    Dim i As Integer
    Public result As String
    Public dt As New DataTable
    Public da As New MySqlDataAdapter


    Public Sub Insert(ByVal sql As String)

        If TextBox1.Text = "" Or TextBox6.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then

            MsgBox("Ensure all fields are filled.")

        Else

            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MessageBox.Show("Request Has Not Been Inserted!")
                    Else
                        MessageBox.Show("Request Has Been Inserted!")
                    End If

                End With

            Catch ex As Exception
            Finally
                con.Close()

            End Try

            TextBox1.ResetText()
            TextBox6.ResetText()
            TextBox3.ResetText()
            TextBox4.ResetText()


        End If


    End Sub

    Public Sub Delete(ByVal sql As String)
        If TextBox2.Text = "" Then

            MsgBox("Ensure Email is filled.")

        Else
            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MessageBox.Show("User Has Not Been Deleted!")
                    Else
                        MessageBox.Show("User Has Been Deleted!")
                    End If
                End With

            Catch ex As Exception
                con.Close()
            End Try
            TextBox2.ResetText()

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

    Public Sub Reload1(ByVal sql As String, ByVal DGT As Object)
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Delete("DELETE FROM `leave_request` WHERE `Leave_ID` = '" & TextBox2.Text & "'")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox2.Text = DataGridView2.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ResetText()
        TextBox6.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Insert("INSERT INTO `leave_request`(`User_ID`, `Date`, `Time`, `Reason`, `Status`) VALUES ('" & TextBox6.Text & "','" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox1.Text & "','Pending')")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Reload("SELECT * FROM `leave_request`", DataGridView2)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Reload("SELECT `User_ID`, `Fullname`, `Email_Address`, `Phone_Number`, `Title` FROM `users`", DataGridView1)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class