Public Class Form4

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_bt.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2_v.TextChanged

    End Sub

    Private Sub cal_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_bt.Click
        Dim p, v, r As Double
        Dim n As Double = Math.PI
        Dim t As Double
        p = Val(txt1_p.Text)
        r = Val(Txt3_r.Text)
        t = Val(Txt4_t.Text)
        v = Val(Txt2_v.Text)
        t += 273
        n = (p * v) / (r * t)
        MessageBox.Show("The Moles Number is Equal to" & "  " & n.ToString("F3") & "  " & "Mole", "YOUR RESULT IS")

    End Sub

    Private Sub c_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_bt.Click
        Txt2_v.Clear()
        txt1_p.Text = ""
        Txt3_r.Clear()

        Txt4_t.Text = ""
    End Sub
End Class