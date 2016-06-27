Public Class frmMenu
    Private Sub ouvrirFenetre(ByVal f As Form, ByVal menu As ToolStripMenuItem)
        f.MdiParent = Me
        f.Show()
        menu.Enabled = False
    End Sub

    Private Sub Exemple1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exemple1ToolStripMenuItem.Click
        ouvrirFenetre(Form1, sender)
    End Sub

    Private Sub Exemple2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exemple2ToolStripMenuItem.Click
        ouvrirFenetre(Form2, sender)
    End Sub

    Private Sub Exemple3ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Exemple3ToolStripMenuItem.Click
        ouvrirFenetre(Form3, sender)
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub
End Class
