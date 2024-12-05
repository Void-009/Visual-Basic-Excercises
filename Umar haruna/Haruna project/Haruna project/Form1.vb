Public Class Form1


    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_rbtn.CheckedChanged

        If m_rbtn.Checked Then
            a_lbl.Text = "Enter_The_Flux_Density"
            b_lbl.Text = "Enter_The_Area"
            a_lbl.Visible = True
            b_lbl.Show()
            b_lbl.Visible = True
            a_lbl.Show()
            End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles area_rbtn.CheckedChanged
        Dim a, b As Char
        If area_rbtn.Checked Then

            ' Add properties to the form.
            a_lbl.Text = "Enter_The_Magnetic_Flux"
            a_lbl.Visible = True
            ' Add properties to the form.
            b_lbl.Text = "Enter_The_Flux_Density"
            b_lbl.Visible = True
            b_lbl.Show()
            a_lbl.Show()

        End If
    End Sub

    Private Sub f_rbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_rbtn.CheckedChanged
        Dim a, b As Char
        If f_rbtn.Checked Then
            a_lbl.Text = "Enter_The_Magnetic_Density"
            b_lbl.Text = "Enter_The_Area"
            a_lbl.Visible = True
            b_lbl.Visible = True
            b_lbl.Show()
            a_lbl.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Double
        If m_rbtn.Checked Then
            a = Val(a_txt.Text)
            b = Val(b_txt.Text)
            c = a / b
            MessageBox.Show("Your M_Flux Is" & " " & c & " " & "wb", "The Result")

        End If
        If f_rbtn.Checked Then
            a = Val(a_txt.Text)
            b = Val(b_txt.Text)
            c = a * b
            MessageBox.Show("Your Flux_Density Is" & " " & c & " " & "wb/m^2", "The Result")

        End If
        If area_rbtn.Checked Then
            a = Val(a_txt.Text)
            b = Val(b_txt.Text)
            c = a / b
            MessageBox.Show("Your Flux_Density Is" & " " & c & " " & "m^2", "The Result")

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a_txt.Clear()
        b_txt.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        printform1.print()
    End Sub
End Class
