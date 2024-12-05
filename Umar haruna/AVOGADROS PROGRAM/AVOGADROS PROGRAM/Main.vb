Public Class Main

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome user's you have choosed the formular for calculating Pressure 1")
        P1_f3.Show()
    End Sub

    Private Sub v1_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome user's you have choosed the formular for calculating volume 1")
        V1_F1.Show()

    End Sub

    Private Sub v2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2_btn.Click

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome user's you have choosed the formular for calculating volume 2")
        V2_F2.Show()
    End Sub

    Private Sub p2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome user's you have choosed the formular for calculating Pressure 2")
        P2_F4.Show()
    End Sub

    Private Sub t1_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(" welcome user's you have choosed the formular for calculating temperature 1")
        T1_F5.Show()
    End Sub

    Private Sub t2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2_btn.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome user's you have choosed the formular for calculating temperature 2")
        T2_F6.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("thank you user's see you later")
        Me.Close()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sapi
        sapi = CreateObject("sapi.spvoice")

        sapi.speak("Hi user welcome to the main page")

    End Sub
End Class
