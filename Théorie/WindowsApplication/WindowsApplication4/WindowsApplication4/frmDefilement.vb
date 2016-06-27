Public Class frmDefilement

    Private Sub hsbLongueur_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles hsbLongueur.Scroll
        Ovale.Size = New Size(hsbLongueur.Value, Ovale.Size.Height)
    End Sub

    Private Sub frmDefilement_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        hsbLongueur.Value = Ovale.Size.Width
        vsbHauteur.Value = Ovale.Size.Height
    End Sub

    Private Sub vsbHauteur_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles vsbHauteur.Scroll
        Ovale.Size = New Size(Ovale.Size.Width, vsbHauteur.Value)
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        hsbLongueur.SmallChange = TrackBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        vsbHauteur.SmallChange = TrackBar2.Value
    End Sub
End Class