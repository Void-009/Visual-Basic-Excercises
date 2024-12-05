Public Class Form1

    Private Sub cal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_btn.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim x As Double
        Dim sqrt, sign As Single

        a = Val(txt1.Text)
        b = Val(txt2.Text)
        c = Val(txt3.Text)
        x = (-b + -(b ^ 2 - 4 * a * c)) / (2 * a)
        txt_result.Text = x
        sqrt = System.Math.Sqrt((b ^ 2 - 4 * a * c) / (2 * a))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txt_result.Clear()
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        printform1.print()
    End Sub
End Class
