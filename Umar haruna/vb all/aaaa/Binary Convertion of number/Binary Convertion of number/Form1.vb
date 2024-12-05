Public Class Form1
    Public Shared Function IntToBin(ByVal intValue As Integer) As String
        Dim sb As New System.Text.StringBuilder()
        Dim tempstr As String 'declaration of variable as string data type
        If intValue = 0 Then
            Return "00"
        End If
        While intValue <> 0
            sb.Insert(0, (intValue Mod 2).ToString())
            intValue \= 2 ' arithmetic operation
        End While
        tempstr = sb.ToString()
        While Len(tempstr) <> 5
            tempstr = CStr("0") + CStr(tempstr) ' arithmetic operation
        End While
        Return tempstr 'returning value

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer, d As String
        d = ""

        a = Val(input_txt.Text) ' claring textbox
        If (a <= 30) Then
            result_txt.Text = IntToBin(Val(a)) ' claring textbox
        Else
            While a <> 0 ' while statement
                b = a Mod 10 'to find modulus
                c = a \ 10

                d = CStr(IntToBin(Val(b))) + CStr(d)
                a = b

            End While
            result_txt.Text = d 'collecting value from user
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        result_txt.Text = "" ' claring textbox
        input_txt.Text = "" ' claring textbox
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() ' closing textbox
    End Sub

    Private Sub input_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input_txt.TextChanged
        result_txt.Clear()
    End Sub
End Class
