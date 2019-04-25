' Name:         MusicBox Project
' Purpose:      Displays the records stored in a dataset
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TblBoxBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBoxBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MusicBoxDataSet)

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicBoxDataSet.tblBox' table. You can move, or remove it, as needed.
        Me.TblBoxTableAdapter.Fill(Me.MusicBoxDataSet.tblBox)

    End Sub
End Class
