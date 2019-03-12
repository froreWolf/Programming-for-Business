' Name:         Brewers Project
' Purpose:      Displays the total pounds sold and the 
'               average pounds sold during a 6-month period
' Programmer:   Branden Barber on February 19, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the total and average pounds sold
        Dim dblPoundsPerMonth() As Double = {170.5, 224, 190.5, 193, 250.5, 236}
        Dim dblTotal As Double, dblAvg As Double

        For Each i As Double In dblPoundsPerMonth
            dblTotal += i
        Next

        dblAvg = dblTotal / dblPoundsPerMonth.Length
        'add to labels
        lblTotal.Text = dblTotal.ToString("N2")
        lblAvg.Text = dblAvg.ToString("N2")


    End Sub
End Class
