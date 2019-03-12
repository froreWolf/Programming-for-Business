Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intNum As Integer
        Dim intDoubleNum As Integer

        Integer.TryParse(TextBox1.Text, intNum)
        Call CalcDouble(intNum, intDoubleNum)
        Label1.Text = intDoubleNum.ToString
    End Sub

    Private Sub CalcDouble(ByVal intNum As Integer, ByRef intNum2 As Integer)
        intNum2 = intNum * 2
    End Sub
End Class
