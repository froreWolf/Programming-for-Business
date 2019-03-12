Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strinput As String = TextBox1.Text

        strinput = strinput.Trim

        If strinput.Length > 3 Then
            strinput = strinput.Insert(1, "#")
        End If

        strinput = strinput.PadRight(10, "*"c)
        Label1.Text = strinput
    End Sub
End Class
