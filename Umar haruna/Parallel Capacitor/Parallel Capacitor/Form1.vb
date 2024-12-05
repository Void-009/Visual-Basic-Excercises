Public Class Form1
    Dim a, b As Single


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As New Object
        Dim b, d As Integer
        c = TextBox1.Text
        c = InputBox("  ")

        d = InputBox("enter the capacitor", 1600, 155)
        If d <> String.Empty Then
            Try
                b = CInt(d)
                If b >= 1 Then
                    MessageBox.Show(b)
                    Exit Sub
                End If
                MessageBox.Show(d)


            Catch ex As Exception
                MessageBox.Show(c)
            End Try
        End If






    End Sub
End Class
