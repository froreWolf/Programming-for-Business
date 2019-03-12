Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboBox1
        ComboBox1.Items.Add("Henry")
        ComboBox1.Items.Add("Gerald")
        ComboBox1.Items.Add("Maxwell")
        ComboBox1.SelectedIndex = 0
        'ComboBox2
        ComboBox2.Items.Add("Jenny")
        ComboBox2.Items.Add("Rachel")
        ComboBox2.Items.Add("Craig")
        ComboBox2.SelectedIndex = 0

        'ComboBox3
        ComboBox3.Items.Add("Stanley")
        ComboBox3.Items.Add("Henrietta")
        ComboBox3.Items.Add("Erwin")
        ComboBox3.SelectedIndex = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Are you sure you want to exit?", "Don't Leave Me", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub
End Class
