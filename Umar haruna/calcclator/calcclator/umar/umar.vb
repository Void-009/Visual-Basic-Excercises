Public Class Form1
    Dim a, b, r,0,9,8,7,6,5,4,3,2,1  As Double
    Dim Text1, Text2, Text3


    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles division.Click
        msglbl.Text = "/"
        a = Val(Text1.Text)
        b = Val(Text2.Text)
        r = a / b
        Text3.Text = r
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_MC.Click
        msglbl.Text = "MC"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_M.Click
        msglbl.Text = "M"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Sqr.Click
        msglbl.Text = "sqr"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msglbl.Text = 4
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msglbl.Text = 3
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msglbl.Text = 2
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_4.Click
        msglbl.Text = 4
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_MR.Click
        msglbl.Text = "MR"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_mul.Click
        msglbl.Text = "*"
        msglbl.Text = "/"
        a = Val(Text1.Text)
        b = Val(Text2.Text)
        r = a * b
        Text3.Text = r
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles point.Click
        msglbl.Text = "."
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_add.Click
        msglbl.Text = "+"
        msglbl.Text = "/"
        a = Val(Text1.Text)
        b = Val(Text2.Text)
        r = a + b
        Text3.Text = r
    End Sub

    Private Sub massagelbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msglbl.Click

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_sub.Click
        msglbl.Text = "-"
        msglbl.Text = "-"
        a = Val(Text1.Text)
        b = Val(Text2.Text)
        r = a - b
        Text3.Text = r

    End Sub

    Private Sub Button_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_7.Click
        msglbl.Text = 7
    End Sub

    Private Sub Button_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_8.Click

        msglbl.Text = 8
    End Sub

    Private Sub Button_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_0.Click
        msglbl.Text = 0
    End Sub

    Private Sub percent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percent.Click
        msglbl.Text = "%"
        msglbl.Text = "%"
        a = Val(Text1.Text)
        b = Val(Text2.Text)
        r = a % b
        Text3.Text = r
    End Sub

    Private Sub Button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_1.Click
        msglbl.Text = 1
    End Sub

    Private Sub Button_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_5.Click
        msglbl.Text = 5
    End Sub

    Private Sub Button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_2.Click
        msglbl.Text = 2
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        msglbl.Text = " "
    End Sub

    Private Sub CE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE.Click
        msglbl.Text = "CE"
    End Sub

    Private Sub equll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equll.Click
        msglbl.Text = "="
    End Sub

    Private Sub Button_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_3.Click
        msglbl.Text = 3
    End Sub

    Private Sub Button_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_6.Click
        msglbl.Text = 6
    End Sub

    Private Sub Button_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_9.Click
        msglbl.Text = 9
    End Sub

    Private Sub fraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraction.Click
        msglbl.Text = "-"
        msglbl.Text = "+/-"
        a = Val(Text1.Text)
        b = Val(Text2.Text)
        r = " a (1/2) b"
        Text3.Text = r
    End Sub

    Private Sub Button_Mplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Mplus.Click
        msglbl.Text = "M+"
    End Sub
End Class
