Public Class Tableau

    Dim a As String
    Dim b As Boolean

    Public Sub New(ByVal a As String, ByVal b As Boolean)
        Me.a = a
        Me.b = b
    End Sub


    Public Function ajouterElementTab() As String

        Dim msg As String = ""
        Dim verify As Boolean = False


        Dim sc As String = a
        Dim s As String = a

        Dim pos1, pos2 As Integer

        Dim tabvaleur(12) As String
        Dim tabopera() As Char = {"+"c, "-"c, "*"c, "/"c, "("c, ")"c}

        pos1 = sc.IndexOf("(")
        pos2 = sc.IndexOf(")")

        'Verifiéer s'il n'y a pas de parenthèse
        If pos1 <> -1 Then
            sc = s.Substring(pos1, pos2 - pos1 + 1)
            b = True
        End If

        Dim chaine As String
        chaine = ""

        'Verifiéer s'il n'y a pas de parenthèse
        If pos1 <> -1 Then
            For Each c As Char In sc

                If c <> ")" And c <> "(" Then
                    chaine &= c
                End If
            Next
        End If

        'obtenir la variable chaine 
        Dim tabopera1() As Char = {"+"c, "-"c, "*"c, "/"c}
        Dim operat As Char

        If pos1 <> -1 Then
            For Each c As Char In tabopera1

                If chaine.Contains(c) Then
                    operat = c
                End If
            Next
        End If


        Dim tabCalculer(3) As String 'tableau de 4 chaines 
        Dim nombre1 As Double
        Dim nombre2 As Double
        Dim temp As Double

        If pos1 <> -1 Then
            tabCalculer = chaine.Split(operat)
            nombre1 = CDbl(tabCalculer(0))
            nombre2 = CDbl(tabCalculer(1))


            Select Case operat
                Case "-"c : temp = nombre1 - nombre2
                Case "+"c : temp = nombre1 + nombre2
                Case "*"c : temp = nombre1 * nombre2
                Case "/"c : temp = nombre1 / nombre2
            End Select


            a = a.Replace(sc, CStr(temp))
        End If



        Return a
    End Function

End Class
