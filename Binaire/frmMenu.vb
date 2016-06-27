Public Class Form1

    Private Sub LireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LireToolStripMenuItem.Click
        frmAffichage.MdiParent = Me
        frmAffichage.Show()
    End Sub

    Private Sub ÉcrireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ÉcrireToolStripMenuItem.Click
        frmSaisie.MdiParent = Me
        frmSaisie.Show()
    End Sub
End Class
