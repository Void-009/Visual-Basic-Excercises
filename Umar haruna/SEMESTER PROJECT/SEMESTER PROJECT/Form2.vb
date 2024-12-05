Public Class Form2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cal.Click
        Dim n, t, v, r As Double
        Dim p As Double = Math.PI
        n = Txt_N.Text
        r = Txt_R.Text
        t = Txt_T.Text
        v = Txt_V.Text
        t += 273
        p = (n * r * t) / v
        MessageBox.Show("The Pressure is Equal to" & "  " & p.ToString("f3") & "  " & "atm ", "YOUR RESULT IS")


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_c.Click
        Txt_N.Clear()
        Txt_R.Text = ""
        Txt_T.Clear()
        Txt_V.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_p.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class