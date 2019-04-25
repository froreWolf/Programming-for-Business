'Dollars to Euros
'Branden Barber April 25, 2019

Option Strict On
Option Infer Off
Option Explicit On

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub imgBtnClickHere_Click(sender As Object, e As ImageClickEventArgs) Handles imgBtnClickHere.Click
        'get user input
        Dim dcmInput As Decimal
        Const EUROS_PER_DOLLAR As Decimal = CDec(0.897408)
        Decimal.TryParse(txtInput.Text, dcmInput)
        'convert to euros
        dcmInput *= EUROS_PER_DOLLAR
        'display result on webpage
        lblEuros.Text = dcmInput.ToString("C4")
    End Sub
End Class