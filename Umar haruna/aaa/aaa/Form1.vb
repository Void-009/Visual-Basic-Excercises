Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBox1.Text)
        Do While a >= 9
            a = a + 1
            ListBox1.Text = a
        Loop
    End Sub
End Class
