Public Class Form3

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pr_btn.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub calculat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculat_btn.Click
        Dim p, n, t, r As Double
        Dim v As Double = Math.PI
        n = TextBox1_n.Text
        r = TextBox2_r.Text
        t = TextBox3_t.Text
        p = TextBox4_p.Text
        t += 273
        v = (n * r * t) / p
        MessageBox.Show("The Volume is Equal to" & "  " & v.ToString("f3") & "  " & "dm^3 ", "YOUR RESULT IS")


    End Sub

    Private Sub cl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cl_btn.Click
        TextBox1_n.Clear()
        TextBox2_r.Text = ""
        TextBox3_t.Clear()
        TextBox4_p.Text = ""
    End Sub
End Class