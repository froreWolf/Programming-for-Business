Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text Like "##*" Then
            Label1.Text = "OK"
        Else
            Label1.Text = "Not OK..."
        End If
    End Sub
End Class
