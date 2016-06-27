Public Class frmCouleur

    Private Sub hsbRouge_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbRouge.Scroll
        Me.BackColor = Color.FromArgb(e.NewValue, Me.BackColor.G, Me.BackColor.B)
    End Sub

    Private Sub hsbVert_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbVert.Scroll
        Me.BackColor = Color.FromArgb(Me.BackColor.R, e.NewValue, Me.BackColor.B)
    End Sub

    Private Sub hsbBleu_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbBleu.Scroll
        Me.BackColor = Color.FromArgb(Me.BackColor.R, Me.BackColor.B, e.NewValue)
    End Sub

    Private Sub frmCouleur_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        hsbRouge.Value = Me.BackColor.R
        hsbVert.Value = Me.BackColor.G
        hsbBleu.Value = Me.BackColor.B
    End Sub
End Class