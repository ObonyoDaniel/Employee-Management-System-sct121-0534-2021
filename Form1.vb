Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("host=127.0.0.1; user=root; password=; database=employee_management;")

        Try
            con.Open()

            If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedItem = "" Then

                MsgBox("Ensure all fields are filled.")
                Exit Sub

            ElseIf ComboBox1.SelectedItem = "Administrator" Then

                Dim cmd As New MySqlCommand("SELECT * FROM users WHERE Email_Address = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "' AND Title = 'Administrator'", con)
                Dim sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                sda.Fill(dt)
                If (dt.Rows.Count > 0) Then

                    TextBox1.ResetText()

                    TextBox2.ResetText()

                    ComboBox1.ResetText()



                    MessageBox.Show("Login Successful")

                    Form2.Show()
                    Me.Hide()

                Else

                    TextBox1.ResetText()

                    TextBox2.ResetText()

                    ComboBox1.ResetText()

                    MessageBox.Show("Wrong Credentials! Kindly try again.")

                End If

            ElseIf ComboBox1.SelectedItem = "Other (e.g. Employee)" Then

                Dim cmd As New MySqlCommand("SELECT * FROM users WHERE Email_Address = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'", con)
                Dim sda As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                sda.Fill(dt)
                If (dt.Rows.Count > 0) Then

                    TextBox1.ResetText()

                    TextBox2.ResetText()

                    ComboBox1.ResetText()

                    MessageBox.Show("Login Successful")

                    Form5.Show()
                    Me.Hide()

                End If

            Else

                TextBox1.ResetText()

                TextBox2.ResetText()

                ComboBox1.ResetText()

                MessageBox.Show("An error occured")

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
