Module Factorielle

    Sub fctFactorielle()
        Dim nb1 As Integer
        Dim chaine As String 'chaîne servant de tampon de lecture
        Dim somme As Long



        chaine = InputBox("Quel est votre premier nombre ", "Nombre1")

        If IsNumeric(chaine) Then
            nb1 = Integer.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If

        somme = 1

        For i = 1 To nb1
            somme = i * somme
        Next i





        MsgBox("Votre reponse Fct est " & somme)

    End Sub
End Module

