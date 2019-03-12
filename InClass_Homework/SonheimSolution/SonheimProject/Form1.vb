Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim dblAssetCost As Double, intUsefulLife As Integer, dblSalvageValue As Double

        Double.TryParse(txtAssetCost.Text, dblAssetCost)
        Integer.TryParse(lstUsefulLife.SelectedItem.ToString, intUsefulLife)
        Double.TryParse(txtSalvageValue.Text, dblSalvageValue)

        txtSchedule.Text = "Year" & ControlChars.Tab & "Depreciation" & ControlChars.NewLine

        For intCounter As Integer = 1 To intUsefulLife
            txtSchedule.Text = txtSchedule.Text & intCounter & ControlChars.Tab &
                Financial.DDB(dblAssetCost, dblSalvageValue, intUsefulLife, intCounter).ToString("C2") & ControlChars.NewLine
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub ValidateInput(sender As Object, e As KeyPressEventArgs) Handles txtAssetCost.KeyPress, txtSalvageValue.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intCounter As Integer = 3 To 20
            lstUsefulLife.Items.Add(intCounter)
        Next
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs) Handles txtAssetCost.TextChanged, txtSalvageValue.TextChanged, lstUsefulLife.SelectedIndexChanged
        txtSchedule.Text = ""
    End Sub
End Class
