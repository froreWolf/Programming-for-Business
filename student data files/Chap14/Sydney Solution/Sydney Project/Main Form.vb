Option Explicit On
Option Strict On
Option Infer Off
' Name:         Sydney Project
' Purpose:      Displays the records from a dataset
'               Allows the user to add and delete records
' Programmer:   Branden Barber on April 25, 2019

Imports System.ComponentModel

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductsDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.ProductsDataSet.tblProducts)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddNumber_Enter(sender As Object, e As EventArgs) Handles txtAddNumber.Enter
        txtAddNumber.SelectAll()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' allows the text box to accept numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'get user input
        Dim strNum As String, strName As String, intNumber As Integer
        strNum = txtAddNumber.Text
        strName = txtName.Text
        Integer.TryParse(txtPrice.Text, intNumber)
        'add a new record to the database (on page 827 of book)
        Try
            ProductsDataSet.tblProducts.AddtblProductsRow(strNum, strName, intNumber)
        Catch ex As Exception
            MessageBox.Show("Duplicate Record", "Sydney", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'table does not stay updated!!!!!!
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'ensure that the user wants to delete the record (pg 833 in the book)
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Are you sure you want to delete" & lblDeleteNumber.Text & "?", "Sydney Project",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgButton = Windows.Forms.DialogResult.Yes Then
            Dim row As DataRow, strNumber As String = lblDeleteNumber.Text
            row = ProductsDataSet.tblProducts.FindByItemNum(strNumber)
            row.Delete()
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            TblProductsTableAdapter.Update(ProductsDataSet.tblProducts)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Products", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
