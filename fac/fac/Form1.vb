Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim fact As Integer
        Dim i As Integer
        n = TextBox1.Text
        While (i <= n)
            fact = fact * i
            i = i + 1
        End While

        MessageBox.Show("fact of no " & TextBox1.Text & "is" & fact)


    End Sub
End Class
