' Name:         Jenko Project
' Purpose:      Display the total of the sales
'               stored in a two-dimensional array
' Programmer:   Branden Barber on March 12, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the total sales
        Dim dblSales(,) As Double = {{1200.33, 2350.75},
                                    {3677.8, 2456.05},
                                    {750.67, 1345.99}}
        ' total the sales amounts stored in the array
        Dim dblTotal As Double
        'Using a For Each Loop
        For Each dblElement As Double In dblSales
            dblTotal = dblTotal + dblElement
        Next
        'reset total to use the nested for loop
        dblTotal = 0
        'using a nested for loop
        Dim intHighRow As Integer = dblSales.GetUpperBound(0)
        Dim intHighCol As Integer = dblSales.GetUpperBound(1)
        For intR As Integer = 0 To intHighRow
            For intC As Integer = 0 To intHighCol
                dblTotal += dblSales(intR, intC)
            Next intC
        Next intR

        lblTotal.Text = dblTotal.ToString("C2")

    End Sub
End Class
