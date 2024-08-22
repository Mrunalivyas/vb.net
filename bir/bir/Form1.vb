Public Class Form1
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While (i <= 31)
            ComboBox1.Items.Add(i)
            i = i + 1
        End While
        i = 1
        While (i <= 12)
            ComboBox2.Items.Add(i)
            i = i + 1
        End While
        i = 2000
        While (i <= 2022)
            ComboBox3.Items.Add(i)
            i = i + 1

        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        age = 2022 - ComboBox3.SelectedItem()
        TextBox1.Text = age

    End Sub
End Class
