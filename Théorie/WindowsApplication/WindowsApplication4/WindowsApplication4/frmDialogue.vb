Public Class frmDialogue

    Private Sub FontDialog1_Apply(sender As System.Object, e As System.EventArgs) Handles FontDialog1.Apply

    End Sub

    Private Sub btnPolice_Click(sender As System.Object, e As System.EventArgs) Handles btnPolice.Click
        FontDialog1.ShowDialog()
        lblMessage.Font = FontDialog1.Font
    End Sub

    Private Sub lblMessage_Click(sender As System.Object, e As System.EventArgs) Handles lblMessage.Click
        

    End Sub

    Private Sub btnCouleur_Click(sender As System.Object, e As System.EventArgs) Handles btnCouleur.Click
        ColorDialog2.ShowDialog()
        Me.BackColor = ColorDialog2.Color
    End Sub

    Private Sub btnCouleurText_Click(sender As System.Object, e As System.EventArgs) Handles btnCouleurText.Click
        ColorDialog1.ShowDialog()
        lblMessage.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub frmDialogue_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'pour que l'heure s'affiche quand la feuille apparaît
        'pas après une seconde

    End Sub
End Class