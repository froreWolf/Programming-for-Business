' Name:         Kettleson Project
' Purpose:      Display a bonus amount
' Programmer:   Branden Barber on October 25, 2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays a bonus 

        Dim dblSales As Double
        Dim dblBonus As Double

        Double.TryParse(txtSales.Text, dblSales)


        If dblSales <= 15000 Then
            dblBonus = dblSales * 0.0015
        Else
            If dblSales <= 25000 Then
                dblBonus = dblSales * 0.02
            Else
                If dblSales <= 50000 Then
                    dblBonus = dblSales * 0.03
                Else
                    If dblSales > 50000 Then
                        dblBonus = dblSales * 0.04
                    End If
                End If
            End If
        End If

        lblBonus.Text = dblBonus.ToString("C2")
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class
