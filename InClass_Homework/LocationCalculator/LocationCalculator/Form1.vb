Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'create and initialize variables
        Dim dblLon1 As Double, dblLon2 As Double, dblLat1 As Double, dblLat2 As Double
        Dim intEarthRadMiles As Integer = 3959, dblAnswer As Double
        Integer.TryParse(txtLon1.Text, dblLon1)
        Integer.TryParse(txtLon2.Text, dblLon2)
        Integer.TryParse(txtLat1.Text, dblLat1)
        Integer.TryParse(txtLat2.Text, dblLat2)
        dblLon1 = dblLon1 * Math.PI / 180
        dblLon2 = dblLon2 * Math.PI / 180
        dblLat1 = dblLat1 * Math.PI / 180
        dblLat2 = dblLat2 * Math.PI / 180
        'calculate distance between the points
        Try
            dblAnswer = ((Math.Cos(dblLon2 - dblLon1)) * (Math.Cos(dblLat1) * Math.Cos(dblLat2))) + (Math.Sin(dblLat1) + Math.Sin(dblLat2))
            dblAnswer = intEarthRadMiles * Math.Acos(dblAnswer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Distance Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'display answer on screen
        lblDistance.Text = dblAnswer & " Miles"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgResponse As DialogResult
        dlgResponse = MessageBox.Show("Are you sure you want to exit?", "Distance Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dlgResponse = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TxtLon1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLon1.KeyPress, txtLon2.KeyPress, txtLat1.KeyPress, txtLat2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtLon1_TextChanged(sender As Object, e As EventArgs) Handles txtLon1.TextChanged, txtLon2.TextChanged, txtLat1.TextChanged, txtLat2.TextChanged
        lblDistance.Text = String.Empty
    End Sub
End Class
