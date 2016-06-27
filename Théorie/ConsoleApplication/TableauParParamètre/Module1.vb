Module Module1

    Sub Main()
        Dim tableau() As Integer = {5, 10, 15, 20, 25}
        Console.WriteLine("Avant l'appel de la fonction")
        For Each Val As Integer In tableau
            Console.Write("  " & Val)
        Next
        Console.WriteLine()
        'appel de la fonction changer  
        changer(tableau)
        Console.WriteLine("Après appel de la fonction changer()")

        For Each Val As Integer In tableau
            Console.Write("  " & Val)
        Next
        Console.WriteLine()

        Console.WriteLine("Après appel de la fonction calculerSomme()")
        calculerSomme(tableau)

        For Each Val As Integer In tableau
            Console.Write("  " & Val)
        Next


        Console.ReadLine()
    End Sub
    'fonction qui va changer les éléments du tableau en le passant par paramètre.
    Sub changer(ByVal tab() As Integer) ' tableau passé en paramètre par valeur , dans ce cas c'est une copie du pointeur tableau
        'qui est passé en paramètre.
        For i As Integer = 0 To tab.GetUpperBound(0)
            tab(i) = CInt(tab(i) ^ 2) 'Mettre option strict on : conversion explicite obligatoire puisque l'opérateur 
            'exposant retourne toujours un double 
        Next
    End Sub

    'Fonction qui fait la somme
    Sub calculerSomme(ByRef tab() As Integer) ' on peut modidier tableau
        'Sub calculerSomme(ByVal tab() As Integer) on ne peut pas  modidier tableau, seulement ses éléments
        Dim somme As Integer
        'on ajoute la somme à la fin du tableau
        ReDim Preserve tab(tab.Length) 'ajoute l'élément
        For Each Val As Integer In tab
            somme += Val
        Next
        tab(tab.GetUpperBound(0)) = somme
    End Sub


End Module
