Public MustInherit Class CAnimal
    'MustInherit indique que la classe est abstraite (mot - clé obligatoire)
    Implements IVivant 'on implémente (pas héritage)
    Private _taille As Integer
    Private _poids As Integer
    Private _age As Integer

    Public Sub New()
        MsgBox("constructeur d'animal")
    End Sub

    Protected Overrides Sub Finalize()
        MsgBox("destructeur de l'animal")
    End Sub

    Public Property taille() As Integer
        Get
            Return _taille
        End Get
        Set(value As Integer)
            _taille = value
        End Set
    End Property

    Public Property poids() As Integer
        Get
            Return _poids
        End Get
        Set(value As Integer)
            _poids = value
        End Set
    End Property
#Region "implémentation de l'interface"
    Public ReadOnly Property age As Integer Implements IVivant.age
        Get
            Return _age
        End Get
    End Property

    Public Sub naitre() Implements IVivant.naitre
        _age = 0
        MsgBox("l'animal nait")
    End Sub

    Public Sub vieillir() Implements IVivant.vieillir
        _age +=
        MsgBox("l'animal vieillit")

    End Sub
#End Region

    'méthode virtuelle
    Public Overridable Sub grossir(ByVal valeur As Integer)
        _poids += valeur
        MsgBox("l'animal grossit")
    End Sub

    'méthode virtuelle pure
    Public MustOverride Sub grandir()
    'la classe devient automatiquement une classe abstraite
    '(ne peut pas être instanciée)
    'les hériters devront la définir pour ne pas être classes abstraites elles aussi

End Class
