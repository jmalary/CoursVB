Module Module1

    Sub Main()

        Dim chaine As String

        chaine = "Vive VB.Net"
        Console.WriteLine(chaine(0))
        Console.WriteLine("premier caractère: " & chaine(3))
        Console.WriteLine("nombre de caracteres: " & chaine.Length)
        Console.WriteLine("premier caractère: " & chaine(chaine.Length - 1))

        For cpt As Integer = 0 To chaine.Length - 1
            'Console.WriteLine(chaine(cpt))
        Next

        For Each c As Char In chaine
            Console.WriteLine(c)
        Next


        Console.ReadLine()

    End Sub

End Module
