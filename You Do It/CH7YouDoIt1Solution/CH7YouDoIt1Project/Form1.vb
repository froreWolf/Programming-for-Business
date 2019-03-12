Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dblInput As Double
        Double.TryParse(TextBox1.Text, dblInput)

        ShowDouble(dblInput)
        Label1.Text = Label1.Text & " " & dblInput.ToString
    End Sub

    Private Sub ShowDouble(ByVal dblNumber As Double)
        Label1.Text = (dblNumber * 2).ToString
    End Sub
End Class
