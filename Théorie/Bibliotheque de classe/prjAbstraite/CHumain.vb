
Public Class CHumain
    Inherits CAnimal

    Private _nom As String

    'constructeur
    Public Sub New()
        MsgBox("constructeur d'un humain")
        _nom = "Inconnu"
    End Sub

    'destructeur
    Protected Overrides Sub Finalize()
        MsgBox("destructeur de l'humain")

    End Sub

    'propriété
    Public Property nom() As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    'définition de la méthode virtuelle pure héritée de CAnimal
    Public Overrides Sub grandir()
        MsgBox("l'humain grandit")
    End Sub

    'nouvelle méthode
    Public Sub parler()
        MsgBox("l'humain parle")
    End Sub

    Public Overrides Sub grossir(valeur As Integer)
        MyBase.grossir(valeur)
        MsgBox("l'humain grossit")
    End Sub
End Class
