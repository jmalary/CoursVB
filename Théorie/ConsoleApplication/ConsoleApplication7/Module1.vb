Module Module1

    Sub Main()
        Dim chaine1 As String = ""
        Dim chaine2 As New System.Text.StringBuilder()
        Dim t1, t2 As DateTime

        t1 = Date.Now() 'heure du système immédiat
        Console.WriteLine("Avant la boucle: " & t1.ToLongTimeString & ":" & t1.Millisecond)

        For i As Integer = 1 To 100000
            chaine1 &= i
            'chaine2.Append(i)
        Next

        t2 = Date.Now() 'Heure du système immédiat
        Console.WriteLine("Après la boucle: " & t2.ToLongTimeString & ":" & t2.Millisecond)
        Console.WriteLine("durée: " & (t2 - t1).TotalMilliseconds)
        Console.ReadLine()
    End Sub

End Module
