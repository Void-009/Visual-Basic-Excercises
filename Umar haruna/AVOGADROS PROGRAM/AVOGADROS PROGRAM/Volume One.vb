Public Class V1_F1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compute_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(p2_txt.Text)
        SAPI.speak(v2_txt.Text)
        SAPI.speak(t1_txt.Text)
        SAPI.speak(p1_txt.Text)
        SAPI.speak(t2_txt.Text)
        Dim V1, V2, T1, T2, P1, P2 As Double
        P2 = Val(p2_txt.Text)
        V2 = Val(v2_txt.Text)
        T1 = Val(t1_txt.Text)
        T2 = Val(t2_txt.Text)
        P1 = Val(p1_txt.Text)
        V1 = (P2 * V2 * T1) / (V1 * T2)
        SAPI.speak("Your  Result is the" & V1)
        MessageBox.Show(V1)
    End Sub

    Private Sub V1_F1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sapi
        sapi = CreateObject("sapi.spvoice")
        sapi.speak("welcome to the volume one level")
    End Sub
End Class