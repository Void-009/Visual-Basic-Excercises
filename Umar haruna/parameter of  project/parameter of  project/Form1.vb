Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim L, T, r, P As Double
        Dim PI As Decimal = 3.142
        r = Val(r_txt.Text)
        T = Val(T_txt.Text)
        L = (T / 360) * 2 * PI * r + 2 * r
        P = L + 2 * r


        MessageBox.Show(P & "m", "YOUR RESULT")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        T_txt.Clear()
        r_txt.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim SAPI
        SAPI = CreateObject("sapi.spvoice")
        SAPI.speak("see you later")
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PrintForm1.Print()

    End Sub

    Private Sub r_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r_txt.TextChanged
        Dim SAPI
        SAPI = CreateObject("sapi.spvoice")
        SAPI.speak(r_txt.Text)

    End Sub

    Private Sub T_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_txt.TextChanged
        Dim SAPI
        SAPI = CreateObject("sapi.spvoice")
        SAPI.speak(T_txt.Text)
    End Sub
End Class
