Public Class P1_f3

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2_bt.TextChanged

    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1_bt.TextChanged

    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1_bt.TextChanged

    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2_bt.TextChanged

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_bt.TextChanged

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_bt.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(p2_bt.Text)
        SAPI.speak(v2_bt.Text)
        SAPI.speak(t1_bt.Text)
        SAPI.speak(v1_bt.Text)
        SAPI.speak(t2_bt.Text)
        Dim V1, V2, T1, T2, P1, P2 As Double
        V1 = Val(v1_bt.Text)
        V2 = Val(v2_bt.Text)
        T1 = Val(t1_bt.Text)
        T2 = Val(t2_bt.Text)
        P2 = Val(p2_bt.Text)
        P1 = (P2 * V2 * T1) / (V1 * T2)
        SAPI.speak("Your  Result is the" & P1)
        MessageBox.Show(P1)
    End Sub

    Private Sub P1_f3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sapi
        sapi = CreateObject("sapi.spvoice")

        sapi.speak("welcome to the pressure one level")
    End Sub
End Class