Public Class Form1
    Dim mark As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt1.TextChanged

    End Sub

    Private Sub compute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compute.Click
        mark = Txt1.Text

        If mark < 100 And mark >= 75 Then

            txt2.Text = "your grade is  A"

        End If
        If mark < 75 And mark >= 60 Then

            txt2.Text = "your grade is B "

        End If
        If mark < 60 And mark >= 50 Then

            txt2.Text = "your grade is  C"

        End If
        If mark < 50 And mark >= 40 Then

            txt2.Text = "your grade is D"

        End If
        If mark < 40 And mark >= 30 Then
            txt2.Text = "your grade is E"
        End If
        If mark < 30 And mark >= 0 Then


            txt2.Text = "your grade is F"


        End If

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Txt1.Text = ""
        txt2.Text = ""
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Exit the program
        Me.Close()
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        PrintForm1.Print()
    End Sub
End Class