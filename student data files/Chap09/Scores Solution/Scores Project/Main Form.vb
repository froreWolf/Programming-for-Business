' Name:         Scores Project
' Purpose:      Display the number of students earning a specific score
' Programmer:   Branden Barber on February 21, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim intScores() As Integer = {88, 72, 99, 20, 66, 95, 99, 100, 72, 88, 78, 45, 57, 89, 95, 78, 75, 88, 72, 88}
        Dim intInput As Integer, intCounter As Integer
        Integer.TryParse(InputBox("Please Enter a Score", "Scores"), intInput)

        For Each num As Integer In intScores
            If num = intInput Then
                intCounter += 1
            End If
        Next

        MessageBox.Show(intCounter.ToString & " students have achieved the score " & intInput.ToString, "scores", MessageBoxButtons.OK)
    End Sub
End Class
