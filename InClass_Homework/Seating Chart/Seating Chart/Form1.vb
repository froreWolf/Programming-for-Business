Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnDisplayPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayPrice.Click
        'create array, populate it then get upper bounds
        Dim decPrices(,) As Double = {{450D, 450D, 450D, 450D},
                                      {425D, 425D, 425D, 425D},
                                      {400D, 400D, 400D, 400D},
                                      {375D, 375D, 375D, 375D},
                                      {375D, 375D, 375D, 375D},
                                      {350D, 350D, 350D, 350D}}
        Dim intMaxRow As Integer = decPrices.GetUpperBound(0)
        Dim intMaxCol As Integer = decPrices.GetUpperBound(1)
        'create variables for  row and column then assign input to them
        Dim intRow As Integer, intCol As Integer
        Integer.TryParse(txtRow.Text, intRow)
        Integer.TryParse(txtCol.Text, intCol)
        ' Make sure the row and col are within range, then display the seat price
        If intRow > intMaxRow OrElse intRow < 0 Then
            If intCol > intMaxCol OrElse intCol < 0 Then
                lblPrice.Text = "Error: Both"
            Else
                lblPrice.Text = "Error: Row"
            End If
        ElseIf intCol > intMaxCol OrElse intCol < 0 Then
            lblPrice.Text = "Error: Column"
        Else
            lblPrice.Text = decPrices(intRow, intCol).ToString("C2")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
