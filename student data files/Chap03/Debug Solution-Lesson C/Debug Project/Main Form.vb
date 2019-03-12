' Name:         Debug Project
' Purpose:      Calculates the average of three test scores
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the average of three test scores

        Dim decTest1 As Decimal
        Dim decTest2 As Decimal
        Dim decTest3 As Decimal
        Dim decAverage As Decimal

        ' convert input to numbers
        Decimal.TryParse(txtTest1.Text, decTest1)
        Decimal.TryParse(txtTest2.Text, decTest2) 'found an oddity here, changed txtTest1.Text to txtTest2.Text
        Decimal.TryParse(txtTest3.Text, decTest3) 'found another one. It was putting it into decTest2 instead of 3 so decTest3 stayed as 0

        ' calculate and display the average
        decAverage = (decTest1 + decTest2 + decTest3) / 3 'added parenthese to fix the order of operations
        lblAverage.Text = decAverage.ToString("N2")
    End Sub
End Class
