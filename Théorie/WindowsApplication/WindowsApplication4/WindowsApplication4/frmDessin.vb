Public Class frmDessin

    Private Sub btnFeu_Click(sender As System.Object, e As System.EventArgs) Handles btnFeu.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox2.Visible = False
        Timer1.Enabled = False
    End Sub
End Class