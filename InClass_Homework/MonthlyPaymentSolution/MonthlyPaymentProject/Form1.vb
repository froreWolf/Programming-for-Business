Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblPrinciple As Double, dblRate As Double, dblPayment As Double

        Double.TryParse(lstRates.SelectedItem.ToString, dblRate)
        Double.TryParse(txtPrinciple.Text, dblPrinciple)

        txtMonthlyPayment.Text = ""

        For intYears As Integer = 15 To 30 Step 5
            dblPayment = Financial.Pmt(dblRate / 100 / 12, intYears * 12, dblPrinciple)
            txtMonthlyPayment.Text = txtMonthlyPayment.Text & intYears.ToString("N") & " years: " & dblPayment.ToString("C2") & ControlChars.NewLine
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For dblRates As Double = 2D To 7D Step 0.5D
            lstRates.Items.Add(dblRates.ToString("N1"))
        Next

        lstRates.SelectedIndex = 0
    End Sub

    Private Sub lstRates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRates.SelectedIndexChanged
        txtMonthlyPayment.Text = ""
    End Sub

    Private Sub txtPrinciple_TextChanged(sender As Object, e As EventArgs) Handles txtPrinciple.TextChanged
        txtMonthlyPayment.Text = ""
    End Sub
End Class
