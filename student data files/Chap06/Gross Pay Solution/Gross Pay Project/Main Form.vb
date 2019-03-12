' Name:         Gross Pay Project
' Purpose:      Displays an employee's gross pay
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblHours As Double, dblRate As Double, dblGrossPay As Double
        Double.TryParse(lstHours.SelectedItem.ToString, dblHours)
        Double.TryParse(lstRates.SelectedItem.ToString, dblRate)

        dblGrossPay = dblHours * dblRate
        lblGross.Text = dblGrossPay.ToString("N2")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate lists
        For decHours As Decimal = 0.5D To 40D Step 0.5D
            lstHours.Items.Add(decHours.ToString("N1"))
        Next
        For decRates As Decimal = 8D To 15D Step 0.5D
            lstRates.Items.Add(decRates.ToString("N2"))
        Next
        'select an option
        lstHours.SelectedIndex = 79
        lstRates.SelectedIndex = 4
    End Sub


End Class
