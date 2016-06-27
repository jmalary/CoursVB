Module Conversion

    Sub Main()
        Const taux As Double = 0.6
        Dim quantite As Integer
        Dim prix As Double
        Dim prixTotal As Double

        Dim chaine As String 'chaîne servant de tampon de lecture

        'lecture des données avec conversion des chaîne en valeur numérique
        'CInt convertit en Interger, CDbl convertit en Double
        'quantite = CInt(InputBox("Quantité: ", "Calcul fu prix"))
        'prix = CDbl(InputBox("Quantité: ", "Calcul fu prix"))
        chaine = InputBox("Quantité: ", "Calcul du prix")
        'prix = CD
        If IsNumeric(chaine) Then
            quantite = Integer.Parse(chaine)
            'quantite = CInt(chaine)
        Else
            MsgBox("Erreur")
        End If

        'Version 3

        'quantite = CInt(InputBox("Quantité: ", "Calcul fu prix"))
        'prix = CDbl(InputBox("Quantité: ", "Calcul fu prix"))

        chaine = InputBox("Prix: ", "Calcul du prix")
        If IsNumeric(chaine) Then
            prix = Double.Parse(chaine)
        Else
            MsgBox("Erreur")
        End If


        prixTotal = quantite * prix * (1 + taux)
        Console.WriteLine("Vous devez payer " & prixTotal & " $.")
        Console.ReadLine() 'pour

    End Sub

End Module
