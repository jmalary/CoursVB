Public Class ToolsMatch
    Dim pgcd As Integer
    Dim reste As Integer
    Dim a As Integer
    Dim b As Integer
    Public Sub New(ByVal a As Integer, ByVal b As Integer)
        Me.a = a
        Me.b = b
    End Sub

    Public Function euclide() As Integer

        If b > a Then
            Dim int As Integer
            int = a
            a = b
            b = int
        End If
        reste = a Mod b
        While reste <> 0
            a = b
            b = reste
            reste = a Mod b
        End While
        pgcd = b
        Return pgcd
    End Function

End Class
