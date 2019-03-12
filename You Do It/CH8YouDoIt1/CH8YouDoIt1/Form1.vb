Public Class Form1
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        'get dat text yo
        Dim strInput As String
        strInput = TextBox1.Text
        'trim dat text yo
        strInput = strInput.Trim

        If strInput.Length > 4 Then
            'cut the string down to four characters
            strInput = strInput.Remove(4)
        End If

        'display the string
        Label1.Text = strInput

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
