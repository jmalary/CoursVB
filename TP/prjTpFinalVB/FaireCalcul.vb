Public Class FaireCalcul

    Dim a As String

    Public Sub New(ByVal a As String)
        Me.a = a
    End Sub

    Public Function calculer() As Double

        Dim tabOp() As Char = {"+"c, "-"c, "*"c, "/"c}
        Dim listeOp As String
        Dim tabVal(4) As String
        Dim nombre1, nombre2 As String
        '  Dim reponse As Double


        Dim nbr As Integer



        tabVal = a.Split(tabOp)

        listeOp = a.Remove(0, tabVal(0).Length)

        For i As Integer = 1 To tabVal.Length - 1
            listeOp = listeOp.Remove(i, tabVal(i).Length)
        Next

        nbr = 0
        For Each c As String In tabVal
            If c = "" Then
                Exit For
            End If

            nbr += 1

        Next

        If nbr <> tabVal.Length Then 's'il en a trouvé un
            'ne rien faire s'il n'en trouve pas
            tabVal(nbr) = "-" & tabVal(nbr + 1)
            tabVal(nbr + 1) = ""
            listeOp = listeOp.Remove(nbr, 1)
        End If


        Dim rep As Double

        Do While listeOp.Contains("*") Or listeOp.Contains("/")

            Dim op As Char

            nbr = 0


            For Each c As Char In listeOp
                If c = "*" Or c = "/" Then
                    op = c
                    Exit For
                End If

                nbr += 1 'nombre de *

            Next

            nombre1 = tabVal(nbr)
            nombre2 = tabVal(nbr + 1)

            Dim nbr1, nbr2 As Double


            nbr1 = CDbl(nombre1)
            nbr2 = CDbl(nombre2)


            Select Case op
                Case "*" : rep = nombre1 * nombre2
                Case "/" : rep = nombre1 / nombre2
            End Select
            tabVal(nbr) = rep

            listeOp = listeOp.Remove(nbr, 1)
        Loop


        Do While listeOp <> ""

            Dim op As Char

            nbr = 0


            For Each c As Char In listeOp
                If c = "+" Or c = "-" Then
                    op = c
                    Exit For
                End If

                nbr += 1 'nombre de *

            Next


            nombre1 = tabVal(nbr)
            nombre2 = tabVal(nbr + 1)

            Dim nbr1, nbr2 As Double


            nbr1 = CDbl(nombre1)
            nbr2 = CDbl(nombre2)


            Select Case op
                Case "+" : rep = nbr1 + nbr2
                Case "-" : rep = nbr1 - nbr2
            End Select

            listeOp = listeOp.Remove(nbr, 1)
        Loop




        Return rep
    End Function

End Class
