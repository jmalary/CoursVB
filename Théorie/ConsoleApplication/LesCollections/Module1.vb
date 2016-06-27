Imports System.IO ' pour la gestion des fichiers 
Module Module1

    Sub Main()

        Dim fichier As New StreamReader("C:\Users\WebSourd\Desktop\p55\VBNet_P35\collections\contacts1.CSV") ' on lire dans un fichier   
        Dim ligne As String 'variable ligne qui va être le tompan de lecture.

        'ligne = fichier.ReadLine() ' cette instruction, si le fichier existe mais vide il ne rentre pas dans la boucle et 
        ''n'affiche pas une ligne vide 
        'Do While Not fichier.EndOfStream
        '    Console.WriteLine(ligne)
        '    ligne = fichier.ReadLine()
        'Loop

        'Lecture du fichier avec la contenu déposé dans un Arraylist
        Dim listeContact As New ArrayList
        ligne = fichier.ReadLine()
        Do While Not fichier.EndOfStream()
            listeContact.Add(ligne)
 
            ligne = fichier.ReadLine()
        Loop
        Console.WriteLine("*******************")
        'listeContact.Remove("Chan")
        'listeContact.RemoveAt(99)
        'affichage des données du ArrayLIst 
        For Each contact As String In listeContact

            Console.WriteLine(contact)
        Next
        Console.WriteLine("----------------")
        Console.WriteLine("Nombre decontacts  :" & listeContact.Count)
        Console.ReadLine()
    End Sub

End Module
