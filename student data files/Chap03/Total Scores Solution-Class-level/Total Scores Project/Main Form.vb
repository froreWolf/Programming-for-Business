' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   Branden Barber on September 11, 2018

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    ' class-level variable used
    ' to accumulate the scores
    'Private decTotal As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim decScore As Decimal
        Static decTotal As Decimal 'this is only precedure level but a static variable will stay
        'total the scores
        Decimal.TryParse(txtScore.Text, decScore)
        decTotal += decScore
        lblTotal.Text = Convert.ToString(decTotal)
        txtScore.Focus()

    End Sub

End Class
