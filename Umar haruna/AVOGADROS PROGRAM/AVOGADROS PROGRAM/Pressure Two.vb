Public Class P2_F4

    Private Sub CAL_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAL_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")

        SAPI.speak("your value is" & p1_txt.Text)
        SAPI.speak("your value is" & v1_txt.Text)
        SAPI.speak("your value is" & t2_txt.Text)
        SAPI.speak("your value is" & v2_txt.Text)
        SAPI.speak("your value is" & t1_txt.Text & "kelvin")
        Dim V1, V2, T1, T2, P1, P2 As Double
        V1 = Val(v1_txt.Text)
        V2 = Val(v2_txt.Text)
        T1 = Val(t1_txt.Text)
        T2 = Val(t2_txt.Text)
        P1 = Val(p1_txt.Text)
        P2 = (P1 * V1 * T2) / (V2 * T1)
        SAPI.speak("Your  Result is the" & P2)
        MessageBox.Show(P2)


    End Sub

    Private Sub P2_F4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sapi
        sapi = CreateObject("sapi.spvoice")
        sapi.speak("welcome to the pressure two level")
    End Sub

    Private Sub t2_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2_txt.TextChanged

    End Sub
End Class