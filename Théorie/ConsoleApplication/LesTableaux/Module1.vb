Module Module1

    Sub Main()
        'Dim notes(4) As Single ' 4 est le numero du dernier indice du tableau. Single=double
        'notes(0) = 23.7
        'notes(1) = 12.7
        'notes(2) = 13.4
        'notes(3) = 1.4
        'notes(4) = 5.38
        ''OU bien on peut déclarer un tableau en l'initialisant.

        'Dim notes() As Single = {23.7, 12.7, 13.4, 1.4, 5.38}

        '' Ou bien un pointeur sur un tableau
        'Dim total As Single 'accumulateur(somme des éléments)
        Dim total As Double 'accumulateur(somme des éléments)
        Dim notes() As Double
        notes = New Double(4) {23.7, 12.7, 13.4, 1.4, 5.38} ' déclare un pointeur sur un tableau de taille 5 éléments
        'Affichage des élements du tableau
        For i As Integer = 0 To 4
            Console.WriteLine(notes(i))
        Next
        'Addition des ééléments du tableau

        For Each val As Double In notes
            Console.WriteLine(val)
            total += val
        Next

        Console.WriteLine("Somme : " & total & vbCrLf & "moyenne :" & total / 5)
        ' afficher le nombre d'éléments dans un tableau
        Console.WriteLine("nombre d'éléments  : " & notes.Length)

        'Récupérer l'indice du premier éléments du tableau et afficher l'element correspondant
        Console.WriteLine("indice du premier élément  " & notes(notes.GetLowerBound(0))) 'le paramètre passé dans GetLowerBound est
        'lenuméro de la dimension
        'Récupérer l'indice du dernier éléments du tableau
        Console.WriteLine("indice du premier élément  " & notes(notes.GetUpperBound(0)))

        Dim ref1, ref2 As Object  'déclaration de deux pointeurs.
        ref1 = notes ' affectation de L'adresse de notes dans ref1
        ReDim Preserve notes(5)
        ref2 = notes
        Console.WriteLine("Après Redim")
        For Each val As Single In notes
            Console.WriteLine(val)
        Next
        ' on compare les adresses avant et après 
        If Object.ReferenceEquals(ref1, ref2) Then
            MsgBox("Même instance")
        Else
            MsgBox("Instances différentes")
        End If




        Console.ReadLine()

    End Sub

End Module
