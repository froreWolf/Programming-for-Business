' Name:         Area Calculator Project
' Purpose:      Displays the area of a circle
' Programmer:   Branden Barber on September 11, 2018

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Const dblPI As Double = 3.14153
        Dim dblRadius As Double
        Dim dblArea As Double

        Double.TryParse(txtRadius.Text, dblRadius)
        dblArea = dblPI * dblRadius ^ 2
        lblArea.Text = Format(dblArea, "Standard")

    End Sub
End Class
