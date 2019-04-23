Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'create and initialize variables
        Dim intLon1 As Integer, intLon2 As Integer, intLat1 As Integer, intLat2 As Integer, intEarthRadMiles As Integer = 3959, intAnswer As Integer
        Integer.TryParse(txtLon1.Text, intLon1)
        Integer.TryParse(txtLon2.Text, intLon2)
        Integer.TryParse(txtLat1.Text, intLat1)
        Integer.TryParse(txtLat2.Text, intLat2)
        'calculate distance between the points
        intAnswer = ((Math.Cos(intLon2 - intLon1)) * (Math.Cos(intLat1) * Math.Cos(intLat2))) + (Math.Sin(intLat1) + Math.Sin(intLat2))
        'intAnswer = Math.Cos(intLon2 - intLon1)
        'intAnswer *= Math.Cos(intLat1) * Math.Cos(intLat2)
        'intAnswer += Math.Sin(intLat1) + Math.Sin(intLat2)
        'radians = degrees*(pi/180Deg)
        intAnswer = intEarthRadMiles * (Math.Acos(intAnswer) * (Math.PI / 180))
        'display answer on screen
        lblDistance.Text = intAnswer & " Miles"
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
