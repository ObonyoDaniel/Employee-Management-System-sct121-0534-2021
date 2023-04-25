
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class Form3

    Dim con As New MySqlConnection("host=127.0.0.1; user=root; password=; database=employee_management;")
    Dim cmd As New MySqlCommand
    Dim i As Integer
    Public result As String
    Public dt As New DataTable
    Public da As New MySqlDataAdapter

    Public Sub Insert(ByVal sql As String)

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox6.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = "" Then

            MsgBox("Ensure all fields are filled.")

        Else

            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MessageBox.Show("User Has Not Been Inserted!")
                    Else
                        MessageBox.Show("User Has Been Inserted!")
                    End If

                End With

            Catch ex As Exception
            Finally
                con.Close()

            End Try

            TextBox1.ResetText()
            TextBox2.ResetText()
            TextBox6.ResetText()
            ComboBox1.ResetText()
            TextBox3.ResetText()

        End If


    End Sub

    Public Overloads Sub Update(ByVal sql As String)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox6.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = "" Then

            MsgBox("Ensure all fields are filled.")

        Else

            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery

                    If result = 0 Then
                        MessageBox.Show("User Has Not Been Updated!")
                    Else
                        MessageBox.Show("User Has Been Updated!")
                    End If
                End With

            Catch ex As Exception
                con.Close()
            End Try
            TextBox1.ResetText()
            TextBox2.ResetText()
            TextBox6.ResetText()
            ComboBox1.ResetText()
            TextBox3.ResetText()
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

    Public Sub Delete(ByVal sql As String)
        If TextBox1.Text = "" Then

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
            TextBox1.ResetText()
            TextBox2.ResetText()
            TextBox6.ResetText()
            ComboBox1.ResetText()
            TextBox3.ResetText()
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        TextBox6.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub


    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Reload("SELECT `User_ID`, `Fullname`, `Email_Address`, `Phone_Number`, `Title` FROM `users`", DataGridView1)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Delete("DELETE FROM `users` WHERE `Email_Address` = '" & TextBox1.Text & "'")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Update("UPDATE `users` SET `Fullname` = '" & TextBox6.Text & "', `Phone_Number` = '" & TextBox2.Text & "', `Title` = '" & ComboBox1.SelectedItem & "', `Password` = '" & TextBox3.Text & "' WHERE `Email_Address` = '" & TextBox1.Text & "'")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Insert("INSERT INTO `users`(`Fullname`, `Email_Address`, `Phone_Number`, `Title`, `Password`) VALUES ('" & TextBox6.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "')")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox6.ResetText()
        ComboBox1.ResetText()
        TextBox3.ResetText()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class