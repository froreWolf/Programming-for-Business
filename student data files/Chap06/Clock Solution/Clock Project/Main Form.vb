' Name:         Clock Project
' Purpose:      Displays minutes and seconds
' Programmer:   Branden Barber on January 8, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'displays minutes (0 through 2 only)
        'and seconds (0 through 59 only)

        For intMinutes As Integer = 0 To 30
            lblMinutes.Text = intMinutes.ToString
            For intSeconds As Integer = 0 To 59
                lblSeconds.Text = intSeconds.ToString
                'refresh interface and then pause execution
                Me.Refresh()
                'System.Threading.Thread.Sleep(500)
            Next intSeconds
        Next intMinutes
    End Sub
End Class
