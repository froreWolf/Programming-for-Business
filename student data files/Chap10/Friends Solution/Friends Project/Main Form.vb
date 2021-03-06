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

        If IO.File.Exists("Friends.txt") Then
            Dim fileIn As IO.StreamReader = IO.File.OpenText("Friends.txt")

            While fileIn.Peek <> -1
                cboFriends.Items.Add(fileIn.ReadLine)
            End While

            fileIn.Close()
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim fileOut As IO.StreamWriter = IO.File.CreateText("Friends.txt")

        For Each item As String In cboFriends.Items
            fileOut.WriteLine(item)
        Next

        fileOut.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cboFriends.Items.Add(cboFriends.Text)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        cboFriends.Items.Remove(cboFriends.SelectedItem)
    End Sub
End Class
