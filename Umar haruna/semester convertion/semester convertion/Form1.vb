Public Class Form1
    Dim a, b, c, d As Long, e, x As String
    Function inttobin(ByVal a As Long)
        b = a
        Do
            c = b Mod 2
            d = CStr(c) + d

        Loop
    End Function
    Function bintoint(ByVal binary As String)
        e = Len(binary)
        For x = 1 To e
            c = c + Val(Mid(binary, e - x + 1, 1))

        Next
        bintoint = c

    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2 = inttobin(Val(TextBox1.Text))
    End Sub
End Class
