Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim outFile As IO.StreamWriter
        Dim strInput As String

        outFile = IO.File.CreateText("numbers.txt")
        strInput = InputBox("Enter a number. Click Cancel to end.", "Number")
        Do Until strInput = String.Empty
            outFile.WriteLine(strInput)
            strInput = InputBox("Enter a number. Click Cancel to end.", "Number")
        Loop
        outFile.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inFile As IO.StreamReader
        Dim dblTotal As Double = 0, dblInput As Double
        inFile = IO.File.OpenText("numbers.txt")

        If IO.File.Exists("numbers.txt") Then
            Do While inFile.Peek <> -1
                Double.TryParse(inFile.ReadLine, dblInput)
                dblTotal += dblInput
            Loop
        Else
            Label1.Text = "File does not exist"
        End If

        Label1.Text = dblTotal.ToString
    End Sub
End Class
