' Name:         Sum or Difference Project
' Purpose:      Display the sum of two numbers or
'               the difference between both numbers
' Programmer:   Branden Barber on October 9, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtOperation.TextChanged, txtFirst.TextChanged, txtSecond.TextChanged
        ' clear lblAnswer

        lblAnswer.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblResult As Double
        Dim strOption As String

        Double.TryParse(txtFirst.Text, dblNum1)
        Double.TryParse(txtSecond.Text, dblNum2)
        strOption = txtOperation.Text

        If strOption = "1" Then
            dblResult = dblNum1 + dblNum2
            lblAnswer.Text = "The sum is " & dblResult.ToString("N2") & "."
        Else
            dblResult = dblNum1 - dblNum2
            lblAnswer.Text = "The difference is " & dblResult.ToString("N2") & "."
        End If
    End Sub
End Class
