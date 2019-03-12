Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = (TextBox1.Text.Contains("9")).ToString
        Label2.Text = (TextBox1.Text.IndexOf("9")).ToString
    End Sub
End Class
