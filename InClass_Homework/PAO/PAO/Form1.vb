Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstParties.Items.Add("Democrat")
        lstParties.Items.Add("Republican")
        lstParties.Items.Add("Independant")
        lstParties.SelectedIndex = 0

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        Dim fileOut As IO.StreamWriter
        fileOut = IO.File.AppendText("PAO.txt")
        fileOut.WriteLine(lstParties.SelectedItem)
        fileOut.WriteLine(txtAge.Text)
        fileOut.Close()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        Dim fileIn As IO.StreamReader

        If IO.File.Exists("PAO.txt") Then
            fileIn = IO.File.OpenText("PAO.txt")
            Dim strInput As String, intDem As Integer, intGOP As Integer, intInd As Integer
            Do Until fileIn.Peek = -1
                strInput = fileIn.ReadLine()
                If strInput = "Democrat" Then
                    intDem += 1
                ElseIf strInput = "Republican" Then
                    intGOP += 1
                Else
                    intInd += 1
                End If
                fileIn.ReadLine()
            Loop
            fileIn.Close()

            lblDem.Text = intDem.ToString
            lblGOP.Text = intGOP.ToString
            lblInd.Text = intInd.ToString
        Else
            MessageBox.Show("Cannot find PAO.txt", "PAO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dlgResponse As DialogResult
        dlgResponse = MessageBox.Show("Are you sure you want to exit?", "PAO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgResponse = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
