Public Class Form1

    Private Sub Addtton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addtton.Click
        Dim number1, number2, sum As Integer
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        sum = number1 + number2
        TextBox3.Text = "The sum is=" & sum
        'End of Addition'
    End Sub

    Private Sub SubtButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubtButton.Click
        Dim number1, number2, subt As Integer
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        subt = number1 - number2
        TextBox3.Text = "The subt is=" & subt
        'End of Subtraction'
    End Sub

    Private Sub MultButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultButton.Click
        Dim number1, number2, mult As Integer
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        mult = number1 * number2
        TextBox3.Text = "The mult is=" & mult
        'End of Multiplication'
    End Sub

    Private Sub DivButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivButton.Click
        Dim number1, number2, div As Double
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        div = number1 / number2
        TextBox3.Text = "The div is=" & div
        'End of Division'
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
End Class
