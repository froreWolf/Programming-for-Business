Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblRate As Double, dblCurVal As Double, dblTerm As Double
        Double.TryParse(txtRate.Text, dblRate)
        Double.TryParse(txtCurrentVal.Text, dblCurVal)
        Double.TryParse(txtTerm.Text, dblTerm)

        lblResult.Text = getMonthlyPayment(dblRate, dblCurVal, dblTerm).ToString("C2")
    End Sub

    Private Function getMonthlyPayment(dblRate As Double, dblCurrentValue As Double, dblTerm As Double) As Double

        Return ((dblRate / 12) * dblCurrentValue) / (1 - (1 + (dblRate / 12)) ^ -(dblTerm * 12))
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearValue(sender As Object, e As EventArgs) Handles txtRate.TextChanged, txtTerm.TextChanged, txtCurrentVal.TextChanged
        lblResult.Text = ""
    End Sub

    Private Sub inputValidation(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress, txtTerm.KeyPress, txtCurrentVal.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class