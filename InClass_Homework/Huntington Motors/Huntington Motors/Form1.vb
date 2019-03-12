Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'static variables
        Static intFull As Integer, intPart As Integer, intNew As Integer, intUsed As Integer
        'get user input
        Dim strID As String = txtID.Text
        Dim intCarsSold As Integer
        Integer.TryParse(txtNumberSold.Text, intCarsSold)
        'add cars sold to totals
        If strID Like "[12][FPfp]**" Then
            'add the new/used sales
            If strID.Substring(0, 1) Like "1" Then
                intNew += intCarsSold
            ElseIf strID.Substring(0, 1) Like "2" Then
                intUsed += intCarsSold
            End If
            'add the full/part time sales
            If strID.Substring(1, 1) Like "[Ff]" Then
                intFull += intCarsSold
            ElseIf strID.Substring(1, 1) Like "[Pp]" Then
                intPart += intCarsSold
            End If
        End If

        lblFullTime.Text = intFull.ToString
        lblPartTime.Text = intPart.ToString
        lblNewCar.Text = intNew.ToString
        lblUsedCar.Text = intUsed.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Huntington Motors", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
