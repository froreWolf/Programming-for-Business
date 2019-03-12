Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intNums() As Integer = {6208, 9420, 1062, 6969, 4413, 9345, 1752, 8723, 6723, 7323, 1187, 1235, 7632, 14551, 12312}
        Dim intHighSub As Integer = intNums.getUpperBound(0), intSub As Integer

        For Each nums As Integer In intNums
            ListBox1.Items.Add(nums)
        Next

        For intSub = 0 To intHighSub
            intNums(intSub) += 5
        Next

        intSub = 0
        Do While (intSub <= intHighSub)
            ListBox2.Items.Add(intNums(intSub))
            intSub += 1
        Loop
    End Sub


End Class
