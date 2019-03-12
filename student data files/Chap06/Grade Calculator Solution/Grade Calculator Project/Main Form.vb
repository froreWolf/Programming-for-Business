' Name:         Grade Calculator Project
' Purpose:      Displays the total points earned and the grade for
'               any number of students
' Programmer:   Branden Barber on January 15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim dblTotal As Double, dblScore As Double
        Dim dlgResult As DialogResult

        Do
            dblTotal = 0
            For intCounter As Integer = 1 To 3
                Double.TryParse(InputBox("Please enter the score for test " & intCounter & "."), dblScore)
                dblTotal += dblScore
            Next
            lblTotalPoints.Text = dblTotal.ToString("N2")
            chooseGrade(dblTotal)
            dlgResult = MessageBox.Show("Would you like to enter another score?", "Again?", MessageBoxButtons.YesNo)
        Loop While (dlgResult = Windows.Forms.DialogResult.Yes)

    End Sub

    Private Sub chooseGrade(dblTotal As Double)

        Select Case (dblTotal)
            Case 0 To 179.99
                lblGrade.Text = "F"
            Case 180 To 209.99
                lblGrade.Text = "D"
            Case 210 To 239.99
                lblGrade.Text = "C"
            Case 240 To 269.99
                lblGrade.Text = "B"
            Case 270 To 300
                lblGrade.Text = "A"
        End Select

    End Sub
End Class
