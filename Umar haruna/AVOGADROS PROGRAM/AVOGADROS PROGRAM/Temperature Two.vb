Public Class T2_F6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(p2_txt.Text)
        SAPI.speak(v2_txt.Text)
        SAPI.speak(t1_txt.Text)
        SAPI.speak(p1_txt.Text)
        SAPI.speak(v1_txt.Text)
        Dim V1, V2, T1, T2, P1, P2 As Double
        V1 = Val(v1_txt.Text)
        V2 = Val(v2_txt.Text)
        P2 = Val(p1_txt.Text)
        T1 = Val(t1_txt.Text)
        P1 = Val(p1_txt.Text)
        T2 = (P2 * V2 * T1) / (V1 * P1)
        SAPI.speak("Your  Result is the" & T2)
        MessageBox.Show(T2)
    End Sub

    Private Sub T2_F6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sapi
        sapi = CreateObject("sapi.spvoice")
        sapi.speak("welcome to the temperature two level")
    End Sub
End Class