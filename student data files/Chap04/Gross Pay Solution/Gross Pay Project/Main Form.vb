' Name:         Gross Pay Project
' Purpose:      Display the gross pay
' Programmer:   Branden Barber on October 16, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        ' clear gross pay

        lblGross.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate gross pay

        Const dblRATE As Double = 10.75
        Dim dblHours As Double

        'store hours in a variable
        Double.TryParse(txtHours.Text, dblHours)

        If dblHours < 0 OrElse dblHours > 40 Then
            lblGross.Text = "Incorrect number of hours"
        Else
            'calculate and display gross pay
            lblGross.Text = (dblHours * dblRATE).ToString("C2")
        End If
    End Sub
End Class
