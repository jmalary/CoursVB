Module Module1
    Enum typeSupport
        CD = 100
        DVD = 200
        Blueray = 300
    End Enum

    <Flags()> Enum typeLangue
        FR = 1 'francais
        EN = 2 'anglais
        ES = 4 'espagnol
        AR = 8 'arabe
        LSQ = 16 'LSQ
    End Enum
    Structure Film
        Dim titre As String
        Dim realisateur As String
        Dim annee As Integer
        Dim duree As Integer
        Dim support As typeSupport
        Dim langue As typeLangue
    End Structure




End Module
