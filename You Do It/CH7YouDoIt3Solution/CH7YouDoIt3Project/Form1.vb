Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intNumber As Integer
        Integer.TryParse(TextBox1.Text, intNumber)

        Label1.Text = GetBonus(intNumber).toString
    End Sub

    Private Function GetBonus(ByVal intNumber As Integer) As Double
        Return (intNumber * 0.1)
    End Function
End Class
