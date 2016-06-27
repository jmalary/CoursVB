Public Class frmEx02_Mod2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        lblMessage.TextAlign = ContentAlignment.TopLeft
    End Sub

    Private Sub btmPolice_Click(sender As System.Object, e As System.EventArgs) Handles btmPolice.Click
        FontDialog1.ShowDialog()
        lblMessage.Font = FontDialog1.Font
    End Sub

    Private Sub btmCouleur_Click(sender As System.Object, e As System.EventArgs) Handles btmCouleur.Click
        ColorDialog1.ShowDialog()
        lblMessage.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        lblMessage.TextAlign = ContentAlignment.TopCenter

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lblMessage.TextAlign = ContentAlignment.TopRight
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        lblMessage.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        lblMessage.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        lblMessage.TextAlign = ContentAlignment.BottomLeft
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        lblMessage.TextAlign = ContentAlignment.BottomCenter
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        lblMessage.TextAlign = ContentAlignment.BottomRight
    End Sub
End Class