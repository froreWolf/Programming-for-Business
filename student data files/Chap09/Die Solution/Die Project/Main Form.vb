' Name:         Die Project
' Purpose:      Displays the number of times 
'               each die face appears
' Programmer:   Branden Barber on February 26, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare arrays
    Private picDice(6) As PictureBox
    Private lblCounters(6) As Label
    Private intCounters(6) As Integer


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill picture box and label arrays
        picDice = {picPlaceHolder, picDie1, picDie2, picDie3, picDie4, picDie5, picDie6}
        lblCounters = {lblPlaceHolder, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6}

    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        ' calculates and displays the number 
        ' of times each die face appears

        Dim randGen As New Random
        Dim intRand As Integer

        'generate a random number 1-6
        intRand = randGen.Next(1, 7)
        'display current roll of the die
        picRandDie.Image = picDice(intRand).Image
        'update associated coutner
        intCounters(intRand) += 1
        'display updated counter
        lblCounters(intRand).Text = intCounters(intRand).ToString

    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        ' reset the counters and clear the
        ' counter labels

        For intSub As Integer = 1 To 6
            intCounters(intSub) = 0
            lblCounters(intSub).Text = String.Empty
        Next intSub

    End Sub
End Class
