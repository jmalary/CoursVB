Public Class Form1

    Dim unFilm As Film


    Private Sub btAfficher_Click(sender As System.Object, e As System.EventArgs) Handles btAfficher.Click
        MessageBox.Show(String.Format("J'ai vu {0}, film de {1}, paru en {2} et qui dure {3} minutes", _
                                       unFilm.titre, unFilm.realisateur, unFilm.annee, unFilm.duree))

        MessageBox.Show("Support du film " & unFilm.support.ToString)
        'MessageBox.Show("Support du film " & unFilm.support)
        If (unFilm.langue And typeLangue.FR) = typeLangue.FR Then
            MsgBox("Disponible en français")
        End If

        If (unFilm.langue And typeLangue.EN) = typeLangue.EN Then
            MsgBox("Disponible en arabe")
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        With unFilm
            .titre = "Le dictateur"
            .realisateur = "Charles Chaplin"
            .annee = 1940
            .duree = 125
            .support = typeSupport.DVD
            .langue = typeLangue.FR Or typeLangue.EN

        End With

        'unFilm.titre = "Le dictateur"
        'unFilm.realisateur = "Charles Chaplin"
        'unFilm.annee = 1940
        'unFilm.duree = 125

    End Sub
End Class
