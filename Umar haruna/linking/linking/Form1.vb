Public Class Form1

    Private Sub btndialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndialog.Click
        Dim frmDialog As New FontDialog()
        frmDialog.showDialog()

    End Sub
End Class
