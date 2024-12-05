

Public Class Form1



    Private Function GetStringTotal(ByVal strTemp As String) As Decimal
        GetStringTotal = 0
        For i = 1 To Len(strTemp)
            If IsNumeric(Mid(strTemp, i, 1)) Then
                GetStringTotal = GetStringTotal + Val(Mid(strTemp, i, 1))
            End If
        Next i

    End Function


    Private controlLocation As New Point(180, 70)
    Private xLocation As New Point(12, 73)


    Dim a, c As Integer, s As Control




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        a += 1
        ' Only allow 5 buttons, just to simplify drawing of the user interface.
        If a <= 10 Then
            ' Create a new Button
            Dim b As New TextBox
            Dim o As New Label

            ' Add properties to the form.
            b.Name = "btn" + a.ToString()
            b.Tag = Tag
            b.Width = 100
            b.Height = 20
            b.TabIndex = 0
            b.ToString()
            b.Multiline = False
            b.Location = New Point(controlLocation.X, controlLocation.Y)
            controlLocation.Y += b.Height + 5
            Controls.Add(b)
            o.Name = "btn" + a.ToString()
            o.Text = "Enter_The_Value_Of_capacitor" + a.ToString()
            o.Tag = Tag
            o.Width = 170
            o.Height = 20
            o.TabIndex = 0
            o.ToString()
        
            o.Location = New Point(xLocation.X, xLocation.Y)
            xLocation.Y += b.Height + 5
            Controls.Add(o)

        End If
    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim b As New TextBox, c, g As Double, v As String





        b.Text = c
        v = (CInt(c))
        MsgBox("The total capacitors value is  " & Str(GetStringTotal(v)) & " microfarad")


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim b As New TextBox
        b.Text = " "
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
