Public Class Form1

    'disposed est appelé par le destructeur (quand la fenêtre est fermée)
    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmMenu.Exemple1ToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.TitreTableAdapter.Fill(Me.MusiqueDataSet.Titre)
    End Sub

    Private Sub btnAfficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfficher.Click
        For Each membre As musiqueDataSet.TitreRow In Me.MusiqueDataSet.Titre
            lstComplete.Items.Add(membre.Item(0) & " - " & membre.Item(1) _
                                  & " / " & membre.Item(2))
        Next
    End Sub
End Class