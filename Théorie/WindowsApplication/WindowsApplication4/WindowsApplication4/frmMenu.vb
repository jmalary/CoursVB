Public Class frmMenu

    Private Sub ChoixToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChoixToolStripMenuItem.Click
        frmChoix.Show()
        frmChoix.MdiParent = Me
    End Sub

    Private Sub ListeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListeToolStripMenuItem.Click
        frmListe.Show()
    End Sub

    Private Sub DialogueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DialogueToolStripMenuItem.Click
        frmDialogue.Show()
    End Sub

    Private Sub HorlogeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HorlogeToolStripMenuItem.Click
        frmHorloge.Show()
    End Sub

    Private Sub ChronomètreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChronomètreToolStripMenuItem.Click
        frmChrono.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        frmCourse.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub DessinToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DessinToolStripMenuItem.Click
        frmDessin.Show()
    End Sub

    Private Sub BarresDeDéfilementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarresDeDéfilementToolStripMenuItem.Click
        frmDefilement.Show()
    End Sub

    Private Sub CouleurToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CouleurToolStripMenuItem.Click
        frmCouleur.Show()
    End Sub

    Private Sub btmAfficher_Click(sender As System.Object, e As System.EventArgs) Handles btmAfficher.Click
        MsgBox(TextBox1.Text & " et " & TextBox2.Text)
    End Sub

    Private Sub btmEffacer_Click(sender As System.Object, e As System.EventArgs) Handles btmEffacer.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
