Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub t1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1_txt.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_btn.Click
        Dim v1, v2, t1, t2 As Double
        v2 = Val(v2_txt.Text)
        t2 = Val(t2_txt.Text)
        t1 = Val(t1_txt.Text)
        v1 = (v2 * t1) / t2
        MessageBox.Show("your answer is" & v1)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim v1, v2, t1, t2 As Double
        v1 = Val(v1_T.Text)
        t2 = Val(t2_T.Text)
        t1 = Val(t1_T.Text)
        v2 = (v1 * t2) / t1
        MessageBox.Show("your answer is" & v2)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim v1, v2, t1, t2 As Double
        v2 = Val(v2_TextBox.Text)
        v1 = Val(v1_TextBox.Text)
        t2 = Val(t2_TextBox.Text)
        t1 = (t2 * v1) / v2
        MessageBox.Show("your answer is" & t1)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim v1, v2, t1, t2 As Double
        v2 = Val(v2txt.Text)
        v1 = Val(v1txt.Text)
        t1 = Val(t1txt.Text)
        t2 = (v2 * t1) / v1
        MessageBox.Show("your answer is" & t2)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_btn.Click
        t2_T.Clear()
        t1_T.Clear()
        v1_T.Clear()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t1_txt.Clear()
        t2_txt.Clear()
        v2_txt.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_BTN.Click
        t2_TextBox.Clear()
        v1_TextBox.Clear()
        v2_TextBox.Clear()
    End Sub

    Private Sub t2_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2_TextBox.TextChanged

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        v2txt.Clear()
        v1txt.Clear()
        t1txt.Clear()

    End Sub
End Class
