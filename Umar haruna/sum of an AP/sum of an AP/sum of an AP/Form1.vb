Public Class Form1

    Private Sub calbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calbtn.Click
        Dim a, n, d, sum As enteger
        a = atxt.Text
        n = ntxt.Text
        d = dtxt.Text
        Sum= n*(n * (2 * a + (n - 1) * d)) / 2
        rslttxt.Text = "The sum of an AP is  " & sum
    End Sub
End Class
