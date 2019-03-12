' Name:         Rose Project
' Purpose:      Displays the price of a ticket
' Programmer:   Branden Barber on February 26, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private dblPrices() As Double = {103, 95, 75.5, 32.5, 88, 10}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSection.SelectedIndexChanged
        lblPrice.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSection.Items.Add("A")
        lstSection.Items.Add("B")
        lstSection.Items.Add("C")
        lstSection.Items.Add("D")
        lstSection.Items.Add("E")
        lstSection.Items.Add("F")
        lstSection.SelectedIndex = 0
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        lblPrice.Text = dblPrices(lstSection.SelectedIndex).ToString
    End Sub
End Class
