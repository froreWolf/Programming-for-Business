Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim intDaysIncreased As Integer, intDaysDecreased As Integer, intDaysSame As Integer
        Dim dblAverage As Double, dblCurrent As Double, dblPrevious As Double
        Dim dblPrices() As Double = {2.25, 2.4, 1.97, 1.97, 1.99, 1.97, 2.25, 2.87, 2.5, 2.4, 2.4, 2.4, 2.98, 2.12, 1.6,
                                        1.57, 1.57, 1.59, 1.9, 2.23, 2.4, 2.62, 2.72, 2.61, 2.62, 2.52, 2.1, 2.01, 2, 1.9}


        'start by getting the first array element and adding it to the total
        dblPrevious = dblPrices(0)
        dblAverage = dblPrevious

        For i As Integer = 1 To dblPrices.GetUpperBound(0)
            dblCurrent = dblPrices(i)
            'decide which counting variable to increase
            If dblCurrent > dblPrevious Then
                intDaysIncreased += 1
            ElseIf dblCurrent < dblPrevious Then
                intDaysDecreased += 1
            Else
                intDaysSame += 1
            End If
            'calculate running average
            dblAverage = (dblAverage + dblCurrent) / 2
            'set the current variable to the previous to set up for next iteration
            dblPrevious = dblCurrent
        Next

        lblIncrease.Text = intDaysIncreased.ToString
        lblDecrease.Text = intDaysDecreased.ToString
        lblSame.Text = intDaysSame.ToString
        lblAverage.Text = dblAverage.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Stock Market", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
