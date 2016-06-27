Public Class FrmMDI

    Dim numero As Integer = 0
    '=0 est inutilise puisque les variables sont à 0 par défaut

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As System.EventArgs) Handles NouveauToolStripMenuItem.Click
        Dim f As New frmEdit
        f.Text = "Bloc-notes" & numero
        f.MdiParent = Me
        f.WindowState = FormWindowState.Maximized
        f.Show()

    End Sub


    Private Sub CascadeHorizontaleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CascadeHorizontaleToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CascadeVerticcaleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CascadeVerticcaleToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub IcônesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IcônesToolStripMenuItem.Click
        For Each f In Me.MdiChildren
            f.WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub ArrangerLesIcônesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArrangerLesIcônesToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
End Class
