' Name:         Addition Project
' Purpose:      Display the sum of the numbers entered
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level accumulator
    Private intSum As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allow the text box to accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblSum.Text = String.Empty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intNum As Integer

        Do
            Integer.TryParse(InputBox("Enter a number to add, or -99 to quit.", "Adding..."), intNum)
            If intNum <> -99 Then
                txtList.Text = txtList.Text & intNum.ToString() & ControlChars.NewLine
                intSum += intNum
                lblSum.Text = intSum.ToString
            End If
        Loop While intNum <> -99
    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        txtList.Clear()
        txtNumber.Clear()
        lblSum.Text = ""
        intSum = 0
    End Sub
End Class