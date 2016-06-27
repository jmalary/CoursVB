Module Module1

    'programme qui demande à l'utilisateur un caractère (+, - ou %) et deux entiers,
    'puis affiche le résultat de l'opérateur de l'opération coorespondance
    Sub Main()
        Dim operation As Func(Of Integer, Integer, Integer) = Nothing
        'operation est un "delegate" (pointeur) sur un fonction qui reçoit 2 entiers
        'et retour un entier / initialisé à Nothing ( Null en C/C++)

        Dim nb1, nb2 As Integer
        Dim touche As ConsoleKeyInfo 'code d'une touche du clavier

        Console.WriteLine("Opération (+, - ou %): ")
        touche = Console.ReadKey 'lit une touche de clavier ( getch() en C)
        nb1 = CInt(InputBox("Entrez le premier nombre:"))
        nb2 = CInt(InputBox("Entrez le deuxieme nombre:"))

        'tester la touche lue
        'operation = getOperation(touche.KeyChar)
        'Select Case touche.KeyChar
        '    Case "+"c 'C: '+' pour un caractère, "+" pour une chaîne)
        '        operation = AddressOf plus
        '    Case "-"c
        '        operation = AddressOf moins
        '    Case "%"c
        '        operation = AddressOf modulo
        'End Select

        Console.WriteLine()
        'Console.WriteLine("Résultat =- " & operation(nb1, nb2))
        'calculer(operation, nb1, nb2)
        calculer(getOperation(touche.KeyChar), nb1, nb2)
        Console.ReadLine()

    End Sub


    Function plus(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    Function moins(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a - b
    End Function

    Function modulo(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a Mod b
    End Function

    Sub calculer(ByVal op As Func(Of Integer, Integer, Integer), _
                 ByVal a As Integer, ByVal b As Integer)

        Console.WriteLine("Résultat = " & op(a, b))
    End Sub

    Function getOperation(ByVal touche As Char) As Func(Of Integer, Integer, Integer)

        Dim op As Func(Of Integer, Integer, Integer)

        Select Case touche
            Case "+"c
                op = AddressOf plus
            Case "-"c
                op = AddressOf moins
            Case "%"c
                op = AddressOf modulo
            Case Else
                op = Nothing
        End Select
        Return op
    End Function



End Module
