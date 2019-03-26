' Name:         Friends Project
' Purpose:      Allows the user to add names to and delete names from a combo box.
'               Also reads names from and writes names to a sequential access file.
' Programmer:   Branden Barber on March 21, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim fileOut As IO.StreamWriter = IO.File.AppendText("Friends.txt")


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        cboFriends.Items.Remove(cboFriends.SelectedIndex)
    End Sub
End Class
