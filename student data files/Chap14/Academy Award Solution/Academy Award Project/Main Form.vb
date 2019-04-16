' Name:         Academy Award Project
' Purpose:      Displays the records stored in a dataset
'               Allows the user to add records to and 
'               delete records from a dataset
' Programmer:   Branden Barber on April 16 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            TblMoviesTableAdapter.Update(MoviesDataSet.tblMovies)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MoviesDataSet.tblMovies)
        TblMoviesBindingSource.Sort = "YearWon"

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' add a record to the dataset
        Dim intYear As Integer, intLength As Integer
        Integer.TryParse(txtAddYear.Text, intYear)
        Integer.TryParse(txtLength.Text, intLength)

        Try
            MoviesDataSet.tblMovies.AddtblMoviesRow(intYear, txtTitle.Text, txtDirector.Text, intLength)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' delete a record from the dataset
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Delete winner from year" & lstDeleteYear.Text & "?", "confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.Yes Then
            Dim row As DataRow
            Dim intYear As Integer
            Integer.TryParse(lstDeleteYear.Text, intYear)
            row = MoviesDataSet.tblMovies.FindByYearWon(intYear)
            row.Delete()
        End If

        Try
            TblMoviesTableAdapter.Update(MoviesDataSet.tblMovies)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddYear_Enter(sender As Object, e As EventArgs) Handles txtAddYear.Enter
        txtAddYear.SelectAll()
    End Sub

    Private Sub txtDirector_Enter(sender As Object, e As EventArgs) Handles txtDirector.Enter
        txtDirector.SelectAll()
    End Sub

    Private Sub txtLength_Enter(sender As Object, e As EventArgs) Handles txtLength.Enter
        txtLength.SelectAll()
    End Sub

    Private Sub txtTitle_Enter(sender As Object, e As EventArgs) Handles txtTitle.Enter
        txtTitle.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) _
        Handles txtAddYear.KeyPress, txtLength.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
