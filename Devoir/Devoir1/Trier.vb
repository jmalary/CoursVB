Module Trier
    Sub fctOrdre()
        Dim nb1 As Integer
        Dim nb2 As Integer
        Dim nb3 As Integer
        Dim chaine As String 'chaîne servant de tampon de lecture
        'Dim somme As Integer
        Dim ab As Boolean
        Dim bc As Boolean
        Dim ac As Boolean

        chaine = InputBox("Quel est votre premier nombre ", "Nombre1")

        If IsNumeric(chaine) Then
            nb1 = Integer.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If

        chaine = InputBox("Quel est votre deuxieme nombre ", "Nombre2")

        If IsNumeric(chaine) Then
            nb2 = Integer.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If

        chaine = InputBox("Quel est votre troisieme nombre ", "Nombre3")

        If IsNumeric(chaine) Then
            nb3 = Integer.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If

        If nb1 = nb2 Or nb2 = nb3 Or nb1 = nb3 Then

            MsgBox("Tri impossible pour cause d'égalité entre les chiffres a, b ou c\n")
        Else
            ab = nb1 < nb2
            bc = nb2 < nb3
            ac = nb1 < nb3

            If ab = True Then
                If bc = True Then
                    MsgBox("otre reponse est " & nb1 & " - " & nb2 & " - " & nb3)
                Else
                    If ac = True Then
                        MsgBox("otre reponse est " & nb1 & " - " & nb3 & " - " & nb2)
                    Else
                        MsgBox("otre reponse est " & nb3 & " - " & nb1 & " - " & nb2)
                    End If
                End If
            Else
                If bc = True Then
                    If ac = True Then
                        MsgBox("otre reponse est " & nb2 & " - " & nb1 & " - " & nb3)
                    Else
                        MsgBox("otre reponse est " & nb2 & " - " & nb3 & " - " & nb1)
                    End If
                Else
                    MsgBox("otre reponse est " & nb3 & " - " & nb2 & " - " & nb1)
                End If

            End If

        End If



        'ab()
        'bc()
        'ac()


        'MsgBox("Votre reponse est " & somme)

    End Sub

End Module
