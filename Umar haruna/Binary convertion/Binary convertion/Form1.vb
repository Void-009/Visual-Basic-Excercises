Public Class Form1
    Public Shared Function IntToBin(ByVal intValue As Integer) As String
        Dim sb As New System.Text.StringBuilder()
        Dim tempstr As String
        If intValue = 0 Then
            Return "0000"
        End If
        While intValue <> 0
            sb.Insert(0, (intValue Mod 2).ToString())
            intValue \= 2
        End While
        tempstr = sb.ToString()
        While Len(tempstr) <> 4
            tempstr = CStr("0") + CStr(tempstr)
        End While
        Return tempstr

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a, b, c As Integer, d As String
        d = ""

        a = input_txt.Text
        If (a <= 15) Then
            result_lbl.Text = IntToBin(Val(a))
        Else
            While a <> 0
                b = a Mod 10
                c = a \ 10
                d = CStr(IntToBin(Val(b))) + CStr(d)
                a = b

            End While
            result_lbl.Text = d
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c As Integer, d As String
        d = ""

        a = input_txt.Text
        If (a <= 15) Then
            result_lbl.Text = IntToBin(Val(a))
        Else
            While a <> 0
                b = a Mod 10
                c = a \ 10
                d = CStr(IntToBin(Val(b))) + CStr(d)
                a = b

            End While
            result_lbl.Text = d
        End If
    End Sub
End Class