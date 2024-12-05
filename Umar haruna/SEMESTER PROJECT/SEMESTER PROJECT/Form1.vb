Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_rb.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_rb.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_rb.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n_rb.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If p_rb.Checked Then
            Form2.Show()
        End If
        If v_rb.Checked Then
            Form3.Show()
        End If
        If n_rb.Checked Then
            Form4.Show()
        End If
        If r_rb.Checked Then
            Form5.Show()
        End If
        If t_rb.Checked Then
            Form6.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
End Class
