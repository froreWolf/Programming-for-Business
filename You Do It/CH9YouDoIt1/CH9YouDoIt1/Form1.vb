Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNums() As Integer = {2, 4, 6, 8, 10, 12}
        Label1.Text = intNums.Length.ToString()
        Label2.Text = (intNums.GetUpperBound(0) + 1).ToString()
    End Sub
End Class
