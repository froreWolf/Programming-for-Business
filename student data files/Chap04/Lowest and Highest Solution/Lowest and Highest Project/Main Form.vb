' Name:         Lowest and Highest Project
' Purpose:      Display the lowest and highest of two scores
' Programmer:   Branden Barber on October 4, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtScore1.TextChanged, txtScore2.TextChanged
        ' clear message

        lblMessage.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'first get the data from the textBoxes and store them in variables
        Dim dblScore1 As Double, dblScore2 As Double
        Double.TryParse(txtScore1.Text, dblScore1)
        Double.TryParse(txtScore2.Text, dblScore2)
        'if statement to decide which score is higher
        If dblScore1 > dblScore2 Then
            lblMessage.Text = "The highest score is " & dblScore1.ToString("F2") &
                ControlChars.NewLine & "The lowest score is " & dblScore2.ToString("F1")
        Else
            lblMessage.Text = "The highest score is " & dblScore2.ToString("F2") &
                ControlChars.NewLine & "The lowest score is " & dblScore1.ToString("F1")
        End If
    End Sub
End Class
