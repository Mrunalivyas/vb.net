Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = 1
        While (i <= 50)
            If (i Mod 2) = 0 Then
                Label1.Text = Label1.Text & "   " & i
            Else
                Label2.Text = Label2.Text & "   " & i
            End If
            i = i + 1

        End While
    End Sub
End Class
