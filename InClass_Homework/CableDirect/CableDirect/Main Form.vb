Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'get the items from the list boxes
        Dim intPremium As Integer, intConnections As Integer
        Dim dblResult As Double
        Integer.TryParse(lstPremium.SelectedItem.ToString, intPremium)
        Integer.TryParse(lstConnections.SelectedItem.ToString, intConnections)

        'determine if the customer is a business customer or not
        If radRes.Checked = True Then
            dblResult = (4.5 + 30 + (5 * intPremium))
        ElseIf intConnections <= 10 Then
            dblResult = (16.5 + 80 + (50 * intPremium))
        Else
            dblResult = (16.5 + 80 + (4 * (intConnections - 10)) + (50 * intPremium))
        End If

        lblOutput.Text = dblResult.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show("Are you sure you want to exit?", "Cable Direct", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radRes.Checked = True
        For i As Integer = 1 To 20
            lstPremium.Items.Add(i)
        Next
        For i As Integer = 1 To 100
            lstConnections.Items.Add(i)
        Next
        lstPremium.SelectedIndex = 0
        lstConnections.SelectedIndex = 0
    End Sub

    Private Sub ClearResult(sender As Object, e As EventArgs) Handles radBus.CheckedChanged, radRes.CheckedChanged, lstConnections.SelectedIndexChanged,
            lstPremium.SelectedIndexChanged
        lblOutput.Text = ""
    End Sub
End Class
