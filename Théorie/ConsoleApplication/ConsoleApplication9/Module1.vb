Module Module1

    Sub Main()
        Dim afficher As Action(Of String) 'afficher est un "delegate" sur une action
        '(un pointeur sur un Sub qui reçoit une chaîne en paramètre)
        afficher = AddressOf msgConsole
        afficher("Bonjour")

        afficher = AddressOf msgBoite
        afficher("Allo")
    End Sub

    Sub msgConsole(ByVal chaine As String)
        Console.WriteLine("*****************")
        Console.WriteLine(chaine)
        Console.WriteLine("*****************")
        Console.ReadLine()

    End Sub

    Sub msgBoite(ByVal message As String)
        MsgBox(message, vbInformation, "ISI")
    End Sub
End Module
