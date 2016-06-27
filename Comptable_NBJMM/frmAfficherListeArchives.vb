Public Class frmAfficherListeArchives

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows
        frmMenu.Show()

    End Sub
End Class