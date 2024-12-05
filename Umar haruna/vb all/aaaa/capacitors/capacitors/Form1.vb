Public Class Form1
    Private Function GetStringTotal(ByVal strTemp As String) As Decimal
        GetStringTotal = 0
        For i = 1 To Len(strTemp)
            If IsNumeric(Mid(strTemp, i, 1)) Then
                GetStringTotal = GetStringTotal + Val(Mid(strTemp, i, 1))
            End If
        Next i

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("The total capacitors value is  " & Str(GetStringTotal(txtnumber.Text)) & " microfarad")
    End Sub
End Class
