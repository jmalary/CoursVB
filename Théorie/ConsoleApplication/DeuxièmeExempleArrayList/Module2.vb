Module Module2
    Sub afficherListe(ByVal liste As ArrayList)
        For Each contact As Object In liste
            Console.WriteLine(contact)
        Next
        Console.WriteLine("************************")
        Console.WriteLine("Nombre d'élements  : " & liste.Count)


        Console.ReadLine()
    End Sub

    Sub chargerListe(ByVal liste As ArrayList)
        Dim fichier As New System.IO.StreamReader("C:\datavb\contacts1.csv")
        Dim nom As String
        nom = fichier.ReadLine()
        Do Until fichier.EndOfStream ' ou Do While not fichier.endOfStream  
            liste.Add(nom)
            nom = fichier.ReadLine()
        Loop

        fichier.Close()
    End Sub

    'Hashtable 

End Module
