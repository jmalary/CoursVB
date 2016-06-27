Module Multiple
    Sub fctMultiplication()
        Dim nb1 As Integer
        Dim nb2 As Integer
        Dim chaine As String 'chaîne servant de tampon de lecture
        Dim somme As Integer


        chaine = InputBox("Quel est votre premier nombre ", "Nombre1")

        If IsNumeric(chaine) Then
            nb1 = Integer.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If

        chaine = InputBox("Quel est votre deuxieme nombre ", "Nombre1")

        If IsNumeric(chaine) Then
            nb2 = Integer.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If

        somme = nb1 * nb2

        MsgBox("Votre reponse est " & somme)

    End Sub
End Module
