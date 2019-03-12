' Name:         Rearrange Name Project
' Purpose:      Change a name from first, space, and last 
'               to last, comma, space, and first
' Programmer:   Branden Barber on Feb 5, 2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRearrange_Click(sender As Object, e As EventArgs) Handles btnRearrange.Click
        ' rearranges and then displays a name

        Dim strName As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim intIndex As Integer

        ' assign the input to a variable
        strName = txtName.Text.Trim

        ' search for the space in the name
        Dim bolSpaceFound As Boolean = False
        intIndex = strName.IndexOf(" ")
        If intIndex <> -1 Then
            bolSpaceFound = True
        End If

        ' if the input contains a space
        If bolSpaceFound Then

            ' separate the first and last names
            strFirstName = strName.Substring(0, intIndex)
            strLastName = strName.Substring(intIndex + 1)
            ' display last name, comma, space, and first name
            lblRearrangedName.Text = strLastName & ", " & strFirstName
        Else    ' the name does not contain a space
            MessageBox.Show("Invalid name format",
                            "Rearrange Name",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
