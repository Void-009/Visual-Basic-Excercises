Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim KE, m, v, h, PD As Double, g As Double = 9.8
        m = Val(Txt_m.Text)
        v = Val(Txt_v.Text)
        h = Val(Txt3_h.Text)
        KE = 1 / 2 * m * v ^ 2
        PD = m * g * h
        MessageBox.Show("KE=" & KE.ToString("F3") & " " & "Joules" & vbCrLf & vbCrLf & "PD=" & PD.ToString("F3") & " " & "joules", "YOUR RESULT")


    End Sub
End Class
