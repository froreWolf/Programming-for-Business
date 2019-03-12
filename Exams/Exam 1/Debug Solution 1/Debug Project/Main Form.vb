' Name:         Debug Project
' Purpose:      Displays the city name included in an address
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddress_Enter(sender As Object, e As EventArgs) Handles txtAddress.Enter
        txtAddress.SelectAll()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the city name

        Const strPROMPT As String =
            "Please enter a city name followed by a comma, a space, and a state name."
        Dim strAddress As String
        Dim strCity As String
        Dim intIndex As Integer

        strAddress = txtAddress.Text

        ' find the comma
        intIndex = strAddress.IndexOf(",")

        If intIndex <> -1 Then
            ' if the address contains a comma,
            ' assign the city name to the strCity variable,
            ' then display the city name; otherwise,
            ' display an appropriate message
            strCity = strAddress.Substring(intIndex + 1, (strAddress.Length - 1) - intIndex)
            MessageBox.Show(strCity, "City Name",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(strPROMPT, "City Name",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtAddress.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the total due

        Dim intQuantity As Integer
        Dim decPrice As Decimal
        Dim decDue As Decimal

        Integer.TryParse(txtQuantity.Text, intQuantity)
        Decimal.TryParse(lstPrices.SelectedItem.ToString.Remove(0, 1), decPrice)

        decDue = intQuantity * decPrice
        lblDue.Text = decDue.ToString("C2")
    End Sub

    Private Sub txtQuantity_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, lstPrices.SelectedIndexChanged
        lblDue.Text = String.Empty
    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fills the list box with prices

        For decPrice As Decimal = 5 To 10 Step 0.5D
            lstPrices.Items.Add(decPrice.ToString("C2"))
        Next decPrice
        lstPrices.SelectedIndex = 0
    End Sub

    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        Me.Close()

    End Sub

    Private Sub btnExit3_Click(sender As Object, e As EventArgs) Handles btnExit3.Click
        Me.Close()

    End Sub

    Private Sub txtLetters_Enter(sender As Object, e As EventArgs) Handles txtLetters.Enter
        txtLetters.SelectAll()
    End Sub

    Private Sub txtLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetters.KeyPress
        ' accepts only letters and the Backspace key

        If (e.KeyChar.ToString.ToUpper < "A" OrElse e.KeyChar.ToString.ToUpper > "Z") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLetters_TextChanged(sender As Object, e As EventArgs) Handles txtLetters.TextChanged
        lblLettersWithSpaces.Text = String.Empty
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' inserts a space after each letter

        Dim strLetters As String

        strLetters = txtLetters.Text

        If strLetters.Length = 5 Then
            lblLettersWithSpaces.Text = strLetters.Substring(0, 1)
            For intIndex As Integer = 0 To strLetters.Length - 1
                lblLettersWithSpaces.Text = lblLettersWithSpaces.Text & " " & strLetters.Substring(intIndex, 1)
            Next intIndex
        Else
            MessageBox.Show("Please enter 5 letters", "Debugging Exercise", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtLetters.Focus()
    End Sub
End Class
