Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intNums() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}, intCounter As Integer = 0, intTotal As Integer = 0

        Do While intCounter < intNums.Length
            intTotal += intNums(intCounter)
            intCounter += 1
        Loop

        Label1.Text = intTotal.ToString
        intTotal = 0

        For Each num As Integer In intNums
            intTotal += num
        Next

        Label2.Text = intTotal.ToString
        intTotal = 0

        For i As Integer = 0 To intNums.Length - 1
            intTotal += intNums(i)
        Next

        Label3.Text = intTotal.ToString

    End Sub
End Class
