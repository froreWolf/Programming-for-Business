' Name:         Zip Project
' Purpose:      Display a shipping charge
' Programmer:   Branden Barber on February 13, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtZip_Enter(sender As Object, e As EventArgs) Handles txtZip.Enter
        txtZip.SelectAll()
    End Sub

    Private Sub txtZip_TextChanged(sender As Object, e As EventArgs) Handles txtZip.TextChanged
        lblShipping.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'get the zipcode and store in a variable
        Dim strZip As String = txtZip.Text
        'check if the zip code is valid
        If strZip Like "#####" AndAlso (strZip.Substring(0, 3) Like "605" OrElse strZip.Substring(0, 3) Like "606") Then
            If strZip.Substring(0, 3) Like "605" Then
                lblShipping.Text = "$25"
            Else
                lblShipping.Text = "$30"
            End If
        Else
            lblShipping.Text = "Invalid Zip"
        End If


    End Sub

    Private Sub txtZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
