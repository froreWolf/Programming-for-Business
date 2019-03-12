Public Class Form1
    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        'get input and clean it
        Dim strInput As String = txtInput.Text
        strInput.Trim()
        'check if the first letter is a vowel
        If strInput Like "[aeiouAEIOU]*" Then
            strInput = strInput & "-way"
        ElseIf Not strInput.ToLower().Contains("a") AndAlso Not strInput.ToLower().Contains("e") AndAlso Not strInput.ToLower().Contains("i") AndAlso
             Not strInput.ToLower().Contains("o") AndAlso Not strInput.ToLower().Contains("u") AndAlso Not strInput.ToLower().Contains("y") Then
            strInput = strInput & "-way"
        Else
            'tranlate the word until the first letter is a vowel
            While strInput Like "[!aeiouyAEIOUY]*"
                strInput = strInput & strInput.Substring(0, 1).ToLower()
                strInput = strInput.Remove(0, 1)
            End While
            'tack ay to the end of the word
            strInput = strInput & "ay"
        End If

        lblOutput.Text = strInput


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgResponse As DialogResult
        dlgResponse = MessageBox.Show("Are you sure you want to exit?", "Pig Latin", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgResponse = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
