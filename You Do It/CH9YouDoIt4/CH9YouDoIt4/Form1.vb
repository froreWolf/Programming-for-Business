Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dblNums() As Double = {123.14, 110, 174.22, 101.01, 561.1231532, 101.01}
        Dim dblLowest As Double = dblNums(0)

        For i As Integer = 1 To dblNums.GetUpperBound(0)
            If dblNums(i) < dblLowest Then
                dblLowest = dblNums(i)
            End If
        Next

        Label1.Text = dblLowest.ToString
    End Sub
End Class
