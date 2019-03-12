Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strNames() As String = {"Juan", "Brooj ", "Drib", "Evalyn", "Freya", "Raven", "Winter", "Rowan", "Khana"}

        For Each i As String In strNames
            MessageBox.Show(i, "Clueless Crusaders")
        Next

        Dim intCounter As Integer = 0
        Do While intCounter < strNames.Length
            MessageBox.Show(strNames(intCounter), "Clueless Crusaders")
            intCounter += 1
        Loop

        For i As Integer = 0 To strNames.GetUpperBound(0)
            MessageBox.Show(strNames(i), "Clueless Crusaders")
        Next

    End Sub
End Class
