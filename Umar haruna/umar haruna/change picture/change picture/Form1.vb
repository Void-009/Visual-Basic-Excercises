Public Class Form1

    Private Sub waterlilies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waterlilies.CheckedChanged

    End Sub

    Private Sub sunset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sunset.CheckedChanged

    End Sub

    Private Sub winter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles winter.CheckedChanged
        Me.photo.BackgroundImage = System.Drawing.Image.FromFile("vlcsnap.png")

    End Sub

    Private Sub photo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photo.Click
        Me.photo.Image = System.Drawing.Image.FromFile("Winter.jpg")
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
