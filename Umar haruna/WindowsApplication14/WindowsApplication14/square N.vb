Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtL.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsqure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsqure.Click
        Dim iL As Integer
        Dim iAns As Double
        '-- input
        iL = txtL.Text
        '-- processing
        iAns = (4 * iL)
        '-- output
        txtsqure.Text = iAns
    End Sub
End Class
