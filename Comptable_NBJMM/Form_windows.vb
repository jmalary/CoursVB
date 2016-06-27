Public Class Form_windows

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'frmMenu.Show()
        'frmMenu.MdiParent = Me
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None7

        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Me

        frmMenu.Show()


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        ' Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Me
        frmMenu.Show()

    End Sub

    Private Sub ÀProposDeNBJMMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposDeNBJMMToolStripMenuItem.Click
        frmMenu.Close()
        'frmPropos.Show()
        frmAbout.Show()

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CalculatriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatriceToolStripMenuItem.Click
        frmMenu.Close()
        frmCalculatrice.MdiParent = Me
        frmCalculatrice.Show()


    End Sub

    Private Sub NoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoteToolStripMenuItem.Click
        frmMenu.Close()
        frmNotepad.MdiParent = Me
        frmNotepad.Show()



    End Sub

    Private Sub ContacterCentreDassistanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContacterCentreDassistanceToolStripMenuItem.Click
        frmMenu.Close()
        frmEmail.MdiParent = Me
        frmEmail.Show()
    End Sub

    Private Sub FichierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichierToolStripMenuItem.Click

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized


        frmMenu.Show()

    End Sub

    Private Sub SaisieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaisieToolStripMenuItem.Click

    End Sub

    Private Sub ChangeLheureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeLheureToolStripMenuItem.Click
        
        frmMenu.Close()
        frmDate.MdiParent = Me
        frmDate.Show()

    End Sub

    Private Sub OutilsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutilsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ListeDesChèquesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesChèquesToolStripMenuItem.Click
        
        frmMenu.Close()
        frmAfficherListeCheque.MdiParent = Me
        frmAfficherListeCheque.Show()



    End Sub

    Private Sub ListeDesPaiementsPréautoriséToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesPaiementsPréautoriséToolStripMenuItem.Click
        frmMenu.Close()
        frmPaiement.MdiParent = Me
        frmPaiement.Show()

    End Sub

    Private Sub ListeDesPaiementsDirectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesPaiementsDirectsToolStripMenuItem.Click
        frmMenu.Close()
        frmPaiement.MdiParent = Me
        frmPaiement.Show()

    End Sub

    Private Sub ListeDesArchivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesArchivesToolStripMenuItem.Click
        frmMenu.Close()
        frmAfficherListeArchives.MdiParent = Me
        frmAfficherListeArchives.Show()

    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        frmMenu.Close()
        frmEnregistrer.MdiParent = Me
        frmEnregistrer.Show()

        
    End Sub
End Class