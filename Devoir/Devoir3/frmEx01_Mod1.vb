Public Class frmEx01_Mod1

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim prenom As String

        prenom = InputBox("Quel est votre nom ?", "Bienvenue")

        lblMessage.Text = "Bonjour " & prenom
    End Sub
End Class