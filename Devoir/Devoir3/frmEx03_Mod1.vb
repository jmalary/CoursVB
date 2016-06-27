Public Class frmEx03_Mod1

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim nb1, nb2, nb3, somme As Double

        If TextBox1.Text = "" Then
            MsgBox("Erreur dans la saisie Qunantité ")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Erreur dans la saisie PU ")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Erreur dans la saisie TAUX TVA ")
        Else
            nb1 = Convert.ToDouble(TextBox1.Text.ToString())
            nb2 = Convert.ToDouble(TextBox2.Text.ToString())
            nb3 = Convert.ToDouble(TextBox3.Text.ToString())
            nb3 += 1
            somme = nb1 * nb2 * nb3
            lblReponse.Text = somme.ToString
        End If

    End Sub

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
    End Sub
End Class