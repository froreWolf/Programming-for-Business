Public Class Form1
    Private Sub TblCdsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCdsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblCdsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CDDataSet)
            MessageBox.Show("Record Saved", "CDs", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CDs", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CDDataSet.tblCds' table. You can move, or remove it, as needed.
        Me.TblCdsTableAdapter.Fill(Me.CDDataSet.tblCds)

    End Sub
End Class
