'Name           Recipe
'Purpose        Display number of tablespoons and teaspoons
'Programmer     Branden Barber on March 28, 2019

Option Explicit On
Option Strict On
Option Infer Off


Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'calculates number of teaspoons and tablespoons

        Dim decOriginalTeaspoons As Decimal, decMultiplyBy As Decimal
        Dim decTotalTeaspoons As Decimal, decNewTeaspoons As Decimal
        Dim intNewTablespoons As Integer

        Decimal.TryParse(txtOriginalTeaSpoons.Text, decOriginalTeaspoons)
        Decimal.TryParse(txtMultiplyBy.Text, decMultiplyBy)

        decTotalTeaspoons = decOriginalTeaspoons * decMultiplyBy
        intNewTablespoons = Convert.ToInt32(decTotalTeaspoons) \ 3
        decNewTeaspoons = decTotalTeaspoons Mod 3

        lblTablespoons.Text = intNewTablespoons.ToString("N0")
        lblTeaspoons.Text = decNewTeaspoons.ToString("N2")

    End Sub
End Class
