Module Module1

    Sub Main()

        Dim tab(5, 10) As Integer  ' tableau de 6 lignes (de 0 à 5) et 11 éléments dans chaque ligne (de 0 à 10)
        Console.WriteLine("GetUpperBound(0) = " & tab.GetUpperBound(0))
        Console.WriteLine("GetUpperBound(1) = " & tab.GetUpperBound(1))

        'Assigner à chaque eléments du tableau la carrée de la somme de ses indices 

        For ligne As Integer = 0 To tab.GetUpperBound(0)
            For colonne As Integer = 0 To tab.GetUpperBound(1)
                tab(ligne, colonne) = ligne ^ 2 + colonne ^ 2
            Next
        Next

        'affichage du tableau
        Console.WriteLine()
        For ligne As Integer = 0 To tab.GetUpperBound(0)
            For colonne As Integer = 0 To tab.GetUpperBound(1)
                Console.Write("  " & tab(ligne, colonne))
            Next
            Console.WriteLine()
        Next
        'affichage avec la boucle for each.
        Console.WriteLine("Affichage avec la boucle for each")
        For Each valeur As Integer In tab
            Console.Write(valeur)
        Next

        'Une deuxième façon de déclarer un tableau à deux dimensions. 

        Dim tab1(,) As Char = {{"A"c, "B"c, "C"c, "D"c, "E"c}, _
                              {"F"c, "G"c, "H"c, "I"c, "J"c}, _
                              {"K"c, "L"c, "M"c, "N"c, "O"c}}
        'affichage du tableau 
        Console.WriteLine()
        For ligne As Integer = 0 To tab1.GetUpperBound(0)
            For colonne As Integer = 0 To tab1.GetUpperBound(1)
                Console.Write(tab1(ligne, colonne))
            Next
            Console.WriteLine()
        Next



        Console.ReadLine()

    End Sub

End Module
