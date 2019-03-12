' Name:         Social Security Project
' Purpose:      Removes the dashes from a social security number
' Programmer:   Branden Barber on February 13, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As System.EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As System.EventArgs) Handles txtNumber.TextChanged
        lblNumber.Text = String.Empty
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'get input and store in variable
        Dim strInput As String = txtNumber.Text
        'test if the input is valid
        If strInput Like "###-##-####" Then
            strInput = strInput.Remove(3, 1)
            strInput = strInput.Remove(5, 1)
            lblNumber.Text = strInput
        Else
            lblNumber.Text = "Invalid!"
        End If

    End Sub
End Class

