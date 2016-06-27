Public Class CChien
    Inherits CAnimal
    Private _race As String

    Public Sub New()
        MsgBox("constructeur d'un chien")
        _race = "quelconque"
    End Sub

    Protected Overrides Sub Finalize()
        MsgBox("destruction d'un chien")
    End Sub

    Public Property race() As String
        Get
            Return _race
        End Get
        Set(value As String)
            _race = value
        End Set
    End Property

    'définition de la méthode virtuelle pure héritée de CAnimal
    Public Overrides Sub grandir()
        MsgBox("destruction d'un chien")

    End Sub
End Class
