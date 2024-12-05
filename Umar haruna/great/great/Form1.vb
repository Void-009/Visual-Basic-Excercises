Public Class Form1
    Dim button1,
    button2,
    button3
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Display_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display_Button.Click

        msgLbl.Text = "GOOD_MORNING"
        If msgLbl.Text = "GOOD_MORNING" Then
            button1.visible = False
            button2.visible = True
            button3.visible = False
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display_Button.Click
        msgLbl.Text = "ina kwana"
        If msgLbl.Text = "ina kwana" Then
            button1.visible = False
            button2.visible = False
            button3.visible = True
        End If
    End Sub

    
    Private Sub Button2_click()
        msgLbl.Text = "BON'JOUR"
        If msgLbl.Text = "BON'JOUR" Then
            button1.visible = True
            button2.visible = False
            button3.visible = False
        End If
    End Sub

    Private Sub Clear_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Button.Click
        msgLbl.Text = " "

    End Sub

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub msgLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgLbl.Click

    End Sub



End Class
