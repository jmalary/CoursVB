Module Module1

    Sub Main()
        'delegate sur une fonction qui recoit 2 entiers et retourne un entier
        Dim op As Func(Of Integer, Integer, Integer)
        'delegate sur une procédure qui reçoit un entier
        Dim act As Action(Of Integer)

        'expression lambda sur une ligne
        'op = Function(x As Integer, y As Integer) x * x + y * y
        'act = Sub(n As Integer) Console.WriteLine("Résultat = " & n)

        'expression lambda sur plusieurs ligne
        op = Function(x As Integer, y As Integer)
                 Return x * x + y * y
             End Function
        act = Sub(n As Integer)
                  Console.WriteLine("Résultat = " & n)
              End Sub

        act(op(4, 5))

        Console.ReadLine()

    End Sub

End Module
