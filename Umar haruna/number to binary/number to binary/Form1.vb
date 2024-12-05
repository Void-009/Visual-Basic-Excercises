Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, x1, x2 As Decimal

        a = Val(input_txt.Text)
        b = Val(input22_txt.Text)
        c = Val(input2_txt.Text)

        x1 = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
        x2 = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
        result_txt.Text = ("Your Result Is" & " " & x1.ToString("f3") & " " & "or" & " " & x2.ToString("f3"))


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_ContextMenuStripChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.ContextMenuStripChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub input_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input_txt.TextChanged
        input2_txt.Clear()
        input22_txt.Clear()
        result_txt.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
