Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display_botton.Click
        massageLbl.Text = "GOOD MORNING"
        massageLbl.Text = "INA KWANA"
        massageLbl.Text = "BON'JOUR"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_button.Click
        Object.Method()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub massageLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles massageLbl.Click

    End Sub
End Class
