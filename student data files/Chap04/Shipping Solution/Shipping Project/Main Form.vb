' Name:         Shipping Project
' Purpose:      Display a shipping message
' Programmer:   Branden Barber on October 23, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim strInput As String = txtId.Text

        strInput = strInput.ToUpper()

        If strInput = "TN" OrElse strInput = "KY" OrElse strInput = "IN" Then
            lblMsg.Text = "We ship to this state"
        Else
            lblMsg.Text = "We do not ship to this state"
        End If

    End Sub
End Class
