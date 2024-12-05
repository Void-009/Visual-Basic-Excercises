Public Class T1_F5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compute_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(p1_txt.Text)
        SAPI.speak(v1_txt.Text)
        SAPI.speak(t2_txt.Text)
        SAPI.speak(p2_txt.Text)
        SAPI.speak(v2_txt.Text)
        Dim V1, V2, T1, T2, P1, P2 As Double
        V1 = Val(v1_txt.Text)
        V2 = Val(v2_txt.Text)
        P2 = Val(p2_txt.Text)
        T2 = Val(t2_txt.Text)
        P1 = Val(p1_txt.Text)
        T1 = (P1 * V1 * T2) / (V2 * P2)
        SAPI.speak("Your  Result is the" & T1)
        MessageBox.Show(T1)
    End Sub

    Private Sub T1_F5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sapi
        sapi = CreateObject("sapi.spvoice")
        sapi.speak("welcome to the temperature one level")
    End Sub
End Class