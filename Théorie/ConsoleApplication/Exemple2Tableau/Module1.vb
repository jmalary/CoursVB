Module Module1

    Sub Main()
        Dim tab() As Char = {"B"c, "C"c, "A"c, "E"c, "D"c, "F"c, "E"c, "J"c, "H"c, "K"c, "M"c, "E"c, "K"c}
        'Recherche d'un éléments
        Dim car As Char = "E"c

        Console.WriteLine("Première apparition du : " & car & " : " & _
                          Array.IndexOf(tab, car))

        Console.WriteLine("Dernière apparition du : " & car & " : " & _
                          Array.LastIndexOf(tab, car))
        'Recherche dans un tableau
        Array.Sort(tab) ' ordre en croissant 
        For Each caract As Char In tab
            Console.WriteLine("  " & caract)
        Next

        Dim position As Integer = Array.BinarySearch(tab, car)
        Console.WriteLine(" trouvé à la position " & position)
        'Si pas trouvé retourne -(nombre d'elements + 1)
        Console.ReadLine()
    End Sub

End Module
