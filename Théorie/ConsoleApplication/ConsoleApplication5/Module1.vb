Module Module1
    'programme qui demande à l'utilisateur d'entrer une phrase
    'puis spécifie ensuite si la phrase contient au moins une lettre
    'ou un chiffre

    'on modifie le programme pour faire plûtot
    'afficher le nombre de lettres
    'Faire afficher toutes les lettres de la phrase

    Sub Main()
        Dim phrase As String = InputBox("Entrez une phrase: ")
        Dim lettres As String = "abcdefghijklmnopqrstuvwxyz"
        Dim chiffres As String = "0123456789"
        Dim nblettres As Integer 'par défaut initialisée à 0
        Dim nbChiffre As Integer 'par défaut initialisée à 0
        Dim tabLettres As String = ""
        'liste des lettres de la phrase (dans l'ordre)
        'par défaut initialisé ""

        phrase = phrase.ToLower()
        'parcourir la chaine phrase
        'For i As Integer = 0 To phrase.Length - 1
        For Each car As Char In phrase
            'dès qu'une lettre est trouvée
            'If lettres.IndexOf(phrase(i)) <> -1 Then
            If lettres.IndexOf(car) <> -1 Then
                'Console.WriteLine("Votre phrase contient au moins une lettre")
                nblettres += 1
                tabLettres &= car
                'Exit For
            Else
                nbChiffre += 1
            End If


        Next

        Console.WriteLine("nombre de lettres: " & nblettres)
        Console.WriteLine("nombre de lettres de la phrase: " & tabLettres)
        'qwerty 456 /$%%%? adobe $$$$

        For i As Integer = 0 To phrase.Length - 1
            'dès qu'une chiffre est trouvée
            If chiffres.IndexOf(phrase(i)) <> -1 Then
                Console.WriteLine("Votre phrase contient au moins une chiffre :" & nbChiffre)
                Exit For
            End If


        Next


        Console.Read()

    End Sub

End Module
