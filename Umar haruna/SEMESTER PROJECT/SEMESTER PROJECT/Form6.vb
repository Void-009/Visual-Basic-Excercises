Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_btn.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub cal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_btn.Click
        Dim p, n, v, r As Double
        Dim t As Double = Math.PI
        p = Txt_p.Text
        r = Txt_r.Text
        n = Txt_n.Text
        v = Txt_v.Text
        t = (p * v) / (n * r)
        t += 273
        MessageBox.Show(" The Temperature Is Equal to " & "  " & t.ToString("f3") & "  " & "kelvin", "YOUR RESULT IS")

    End Sub

    Private Sub c_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_btn.Click
        Txt_v.Clear()
        Txt_p.Text = ""
        Txt_r.Clear()
        Txt_n.Text = ""
    End Sub
End Class