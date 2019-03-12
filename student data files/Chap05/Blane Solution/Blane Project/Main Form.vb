' Name:         Blane Project
' Purpose:      Display the total amount owed
' Programmer:   Branden Barber on October 25, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRegistrants_Enter(sender As Object, e As EventArgs) Handles txtRegistrants.Enter
        txtRegistrants.SelectAll()
    End Sub

    Private Sub txtRegistrants_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegistrants.KeyPress
        ' accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRegistrants_TextChanged(sender As Object, e As EventArgs) Handles txtRegistrants.TextChanged
        lblTotalOwed.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the total amount owed

        Dim intRegistrants As Integer
        Dim intTotalDue As Integer = 0

        ' assign input to a variable
        Integer.TryParse(txtRegistrants.Text, intRegistrants)

        ' determine total owed

        Dim intCounter As Integer
        For intCounter = 1 To intRegistrants
            Select Case intCounter
                Case <= 3
                    intTotalDue += 150
                Case 3 To 10
                    intTotalDue += 100
                Case > 10
                    intTotalDue += 60
            End Select
        Next

        ' display total owed
        lblTotalOwed.Text = intTotalDue.ToString("C0")

        txtRegistrants.Focus()
    End Sub


End Class
