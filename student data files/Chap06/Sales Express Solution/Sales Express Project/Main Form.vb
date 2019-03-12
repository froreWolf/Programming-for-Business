﻿' Name:         Sales Express Project
' Purpose:      Displays the average sales amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the average sales amount

        Const strPROMPT As String =
            "Enter a sales amount. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Sales Entry"
        Dim strInputSales As String
        Dim decSales As Decimal
        Dim intNumSales As Integer
        Dim decTotalSales As Decimal
        Dim decAvgSales As Decimal

        ' get first sales amount
        strInputSales = InputBox(strPROMPT, strTITLE, "0")
        ' repeat as long as the user enters a sales amount
        Do While strInputSales <> String.Empty
            'convert the sales amount to a number
            Decimal.TryParse(strInputSales, decSales)
            'display the sales amount in the text box
            txtList.Text = txtList.Text & decSales.ToString("N2") & ControlChars.NewLine
            'update the counter and accumulator
            intNumSales += 1
            decTotalSales += decSales
            'get next sales amount
            strInputSales = InputBox(strPROMPT, strTITLE)
        Loop

        ' verify that the counter is greater than 0
        If intNumSales > 0 Then
            decAvgSales = decTotalSales / intNumSales
            lblAvg.Text = decAvgSales.ToString("C2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

End Class
