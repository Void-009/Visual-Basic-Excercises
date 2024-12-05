Public Class Form5

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_btn.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Dim p, n, t, v As Double
        Dim r As Double = Math.PI
        t = t_txt.Text
        v = v_txt.Text
        n = n_txt.Text
        p = p_txt.Text
        t += 273
        r = (p * v) / (n * t)

        MessageBox.Show("The Relative Moles Number is Equal to " & "  " & r.ToString("f3") & "  " & "atm dm^3 K^-1 mol^-1", "YOUR RESULT IS")

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        v_txt.Clear()
        p_txt.Text = ""
        n_txt.Clear()
        t_txt.Text = ""
    End Sub
End Class