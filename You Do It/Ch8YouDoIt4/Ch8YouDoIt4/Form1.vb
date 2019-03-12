Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strAlphabet As String = "Ashland University".ToUpper
        Dim strCharacter As String = InputBox("Enter a letter", "Which Letter").ToUpper
        Dim intIndex As Integer = strAlphabet.IndexOf(strCharacter), strChars As Integer = 5

        While strAlphabet.Length < (intIndex + strChars)
            strChars -= 1
        End While

        If intIndex <> -1 Then
            Label1.Text = strAlphabet.Substring(intIndex, strChars)
        Else
            Label1.Text = "Character/String not found!"
        End If

    End Sub
End Class
