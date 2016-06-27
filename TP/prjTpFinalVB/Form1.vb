Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmMenu.Show()
        frmMenu.MdiParent = Me
    End Sub
End Class