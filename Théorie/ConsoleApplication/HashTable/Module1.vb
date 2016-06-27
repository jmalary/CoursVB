Imports System.IO
Module Module1
    Structure Contact
        Dim numero As Integer
        Dim nom As String
        Dim annee As Integer
        Dim ville As String
        Sub afficher()
            Console.writeLine(numero & vbTab & nom & vbTab & annee & vbTab & ville)
        End Sub
    End Structure

    Sub Main()
        Dim fichier As New StreamReader("C:\Users\WebSourd\Desktop\p55\VBNet_P35\collections\contacts2.csv")
        Dim ligne As String 'tampon de lecture.
        Dim unContact As Contact
        Dim htliste As New Collections.Hashtable()
        ligne = fichier.ReadLine()
        Do While Not fichier.EndOfStream
            Dim tab(3) As String 'tableau de 4 chaines 
            tab = ligne.Split(";"c) 'le ; est considere comme un caractere
            With unContact
                .numero = tab(0)
                .nom = tab(1)
                .annee = tab(2)
                .ville = tab(3)
                '.afficher()
            End With

            'Console.WriteLine("Num  : " & tab(0) & "  nom :" & tab(1) & " annee :" & tab(2) & _
            '                 "ville : " & tab(3))
            htliste.Add(unContact.numero, unContact)
            ligne = fichier.ReadLine()
        Loop
        fichier.Close()
        Console.WriteLine("Affichage des cles ")

        For Each cle As Object In htliste.Keys
            Console.WriteLine(cle.ToString())
        Next
        Console.ReadLine()   'pause avec readline  
        Console.WriteLine("Affichage des enregistrements :")
        For Each donnee As Contact In htliste.Values
            donnee.afficher()
        Next

        Console.WriteLine("Affichage du couple cle valeur du hashtable")
        'Affichage du couple cle valeur a la fois 
        Try
            For Each cle As DictionaryEntry In htliste
                'Console.WriteLine(cle.Key)
                cle.Value.afficher()
                Console.WriteLine()
            Next

        Catch ex As InvalidCastException
            MsgBox("InvalidCast")
        Catch ex As Exception
        End Try

        Console.ReadLine()
    End Sub

End Module
