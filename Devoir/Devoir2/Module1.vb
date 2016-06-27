Module Module1

    Sub Main()

        Dim tableau() As Integer = {"27", "80", "81"}
        Dim nbr As Integer
        Dim val1, val2, val3 As String
        Dim demarre As Boolean
        Dim somme As Double

        demarre = False
        val1 = ""
        val2 = ""
        val3 = ""
        Do

            If nbr = 0 Then
                val1 = InputBox("Entrez le nombre de lettres Moins de 27 g ", "Lettre")
                nbr = nbr + 1
            ElseIf nbr = 1 Then
                val2 = InputBox("Entrez le nombre de lettres 27 g à 80g ", "Lettre")
                nbr = nbr + 1
            Else
                val3 = InputBox("Entrez le nombre de lettre à 80g et plus ", "Lettre")
                demarre = True
            End If


        Loop While demarre = False

        somme = CInt(val1) * 0.45

        somme = somme + CInt(val2) * 0.9

        somme = somme + CInt(val3) * 1.45

        If somme > 7.50 Then
            somme = somme * 0.9
        End If

        MsgBox("La facture total à payer :  " & somme)

    End Sub

End Module
