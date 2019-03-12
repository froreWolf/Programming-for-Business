Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'get input and store in a variable
        Dim strInput As String = txtInput.Text, strReverse As String = ""
        strInput = strInput.Trim
        'for loop to get the backwards version of the word
        For i As Integer = strInput.Length - 1 To 0 Step -1
            strReverse = strReverse & strInput.Substring(i, 1)
        Next
        'test if the input is a palindrome
        If strInput Like strReverse Then
            lblOutput.Text = "Palindrome: True"
        Else
            lblOutput.Text = "Palindrome: False"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
