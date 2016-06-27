Module Module1

    Sub Main()

        Dim chaine As New System.Text.StringBuilder()

        chaine.AppendLine("Objet StringBuilder")
        chaine.AppendLine("Ceci est une chaîne de caractères dans un StringBuilder: ")
        chaine.Append("La classe StringBuidler permet d'optimiser les performancesé lorsqu'il")
        chaine.Append("s'agit de concaténer de nombreuse châines dans une boucle")


        chaine.Remove(0, 19)
        chaine.Replace("String", "STRING")
        chaine.Insert(0, "XXXXXX")


        Console.WriteLine(chaine)
        Console.ReadLine()


    End Sub

End Module
