Module Divison
    Sub fctDivison()
        Dim nb1 As Integer
        Dim nb2 As Integer
        Dim chaine As String 'chaîne servant de tampon de lecture
        Dim somme As Double



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

        If nb2 <> 0 Then
            somme = nb1 / nb2
        Else
            MsgBox("Erreur  zero ")
        End If

        MsgBox("Votre reponse est " & somme)

    End Sub

End Module
