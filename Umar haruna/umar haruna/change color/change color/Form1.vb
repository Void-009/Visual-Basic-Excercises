Public Class Form1

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox_one.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Red.CheckedChanged
        BackColor = Color.Red
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        BackgroundImageLayout = ImageLayout.Center

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yellow.CheckedChanged
        BackColor = Color.Yellow
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gray.CheckedChanged
        BackColor = Color.Gray
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLack.CheckedChanged
        BackColor = Color.Black
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles white.CheckedChanged
        BackColor = Color.White
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox_two.Enter
        BackColor = Color.White
    End Sub

    Private Sub Blue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.CheckedChanged
        BackColor = Color.Blue
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
