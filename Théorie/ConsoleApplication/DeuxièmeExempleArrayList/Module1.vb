Module Module1

    Sub Main()
        Dim listeContacts As New ArrayList
        chargerListe(listeContacts)
        afficherListe(listeContacts)
        Console.WriteLine("Après le tri")
        listeContacts.Sort()  ' Tri du ArrayList 
        afficherListe(listeContacts)

        Dim unNom As String = InputBox("Contact à Supprimer :")
        If listeContacts.Contains(unNom) Then
            listeContacts.Remove(unNom) ' permet de supprimer le contact de la liste mais pas du fichier.
            MsgBox("Le contact " & unNom & "a été retiré de la liste ")
            Console.Clear()
            afficherListe(listeContacts)
        Else
            MsgBox("Le contact " & unNom & "n'existe pas dans la liste")
        End If

    End Sub

End Module
