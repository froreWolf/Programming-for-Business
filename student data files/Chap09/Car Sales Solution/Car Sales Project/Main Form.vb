﻿' Name:         Car Sales Project
' Purpose:      Display the amount sold for each car type
' Programmer:   Branden Barber on February 28, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill the list box with values

        lstCarType.Items.Add("New")
        lstCarType.Items.Add("Used")
        lstCarType.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds the amount sold to the appropriate total

        ' declare accumulator array and variables
        Static Dim intTotalSold(2) As Integer
        Dim intNumSold As Integer
        Integer.TryParse(txtSold.Text, intNumSold)

        ' update array value
        If lstCarType.SelectedIndex = 0 Then
            intTotalSold(0) += intNumSold
        Else
            intTotalSold(1) += intNumSold
        End If

        ' display array values
        lblNew.Text = intTotalSold(0).ToString
        lblUsed.Text = intTotalSold(1).ToString

        txtSold.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSold_Enter(sender As Object, e As EventArgs) Handles txtSold.Enter
        txtSold.SelectAll()
    End Sub

    Private Sub txtSold_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSold.KeyPress
        ' allow numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtSold.TextChanged, lstCarType.SelectedIndexChanged
        lblNew.Text = String.Empty
        lblUsed.Text = String.Empty
    End Sub
End Class
