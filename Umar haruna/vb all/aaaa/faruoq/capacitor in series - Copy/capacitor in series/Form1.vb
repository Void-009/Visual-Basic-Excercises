Public Class Form1
    Dim result As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        result = 1 / (TextBox1.Text)
        TextBox2.Text = "result = " & result
        Button1.Visible = False
        TextBox3.Visible = True
        TextBox1.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        result = (1 / TextBox1.Text) + (1 / TextBox3.Text)
        TextBox2.Text = "result = " & result
        Button1.Visible = False
        TextBox1.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
        Button3.Visible = False
        Button4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        result = (1 / TextBox1.Text) + (1 / TextBox3.Text) + (1 / TextBox4.Text) + (1 / TextBox5.Text) + (1 / TextBox5.Text)
        TextBox2.Text = "result = " & result
        Button1.Visible = True
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox1.Visible = True
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        result = (1 / TextBox1.Text) + (1 / TextBox3.Text) + (1 / TextBox4.Text) + (1 / TextBox5.Text)
        TextBox2.Text = "result = " & result
        Button1.Visible = False
        TextBox1.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = True
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        result = (1 / TextBox1.Text) + (1 / TextBox3.Text) + (1 / TextBox4.Text)
        TextBox2.Text = "result = " & result
        Button1.Visible = False
        TextBox1.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = True
        TextBox6.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = True
        Button6.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
    End Sub
End Class
