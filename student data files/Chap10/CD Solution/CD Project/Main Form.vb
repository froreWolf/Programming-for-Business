' Name:         CD Project
' Purpose:      Adds and deletes list box entries
'               Reads information from a sequential access file
'               Writes information to a sequential access file
' Programmer:   Branden Barber on March 19, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' save the list box information

        ' declare a StreamWriter variable
        Dim outFile As IO.StreamWriter
        ' open the file for output
        outFile = IO.File.CreateText("CDs.txt")
        ' write each line in the list box
        For intIndex As Integer = 0 To lstCds.Items.Count - 1
            outFile.WriteLine(lstCds.Items(intIndex))
        Next
        ' close the file
        outFile.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with data 
        ' stored in a sequential access file

        ' declare variables
        Dim inFile As IO.StreamReader
        'verify that the file exists
        If IO.File.Exists("CDs.txt") Then
            'open the file for input
            inFile = IO.File.OpenText("CDs.txt")
            Do Until inFile.Peek = -1
                lstCds.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Can't find the CDs.txt file", "CD Collection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds CD information to the list box

        ' declare variables
        Dim strName As String, strArtist As String, strPrice As String, strDate As String
        Dim strConcatenatedInfo As String, dblPrice As Double
        ' get the CD information
        strName = InputBox("CD name:", "CD Collection")
        strArtist = InputBox("Artist", "CD Collection")
        strPrice = InputBox("Price", "CD Collection")
        strDate = InputBox("Date Purchased", "CD Collection")
        ' format the price, then concatenate the
        ' input items, using 40 spaces for the 
        ' CD name, 25 spaces for the artist name,
        ' and 5 spaces for the price
        Double.TryParse(strPrice, dblPrice)
        strPrice = dblPrice.ToString("N2")
        strConcatenatedInfo = strName.PadRight(27) & strDate.PadRight(13) & strArtist.PadRight(25) & strPrice.PadLeft(5)
        ' add the information to the list box
        lstCds.Items.Add(strConcatenatedInfo)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' removes the selected line from the list box

        ' if a line is selected, remove the line
        If lstCds.SelectedIndex <> -1 Then
            lstCds.Items.Remove(lstCds.SelectedIndex)
        End If
    End Sub
End Class
