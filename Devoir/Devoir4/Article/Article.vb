Imports System.Windows.Forms

Public Class Article

#Region "données membres"
    Private _nom As String
    Private _reference As String
    Private _quantiteStock As Integer
    Private _min As Integer
    Private _max As Integer
    Private Shared nbArticle As Integer
#End Region

#Region "constructeurs et destructeurs"
    Public Sub New()
        nbArticle += 1
        MessageBox.Show("constructeur d'article")
    End Sub

    Public Sub New(ByVal n As String, ByVal ref As String, ByVal qtStock As Integer, ByVal min As Integer, ByVal max As Integer)
        'affection des paramètres aux données membres
        _nom = n
        _reference = ref
        _quantiteStock = qtStock
        _min = min
        _max = max

        nbArticle += 1
        MessageBox.Show("contructeur d'article")
    End Sub

    Protected Overrides Sub Finalize()
        MessageBox.Show("destructeur d'article")
        nbArticle -= 1
    End Sub

#End Region

#Region "proprietés"

    Public Property Nom() As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    Public Property Reference() As String
        Get
            Return _reference
        End Get
        Set(value As String)
            _reference = value
        End Set
    End Property

    Public Property QuantitesStock() As Integer
        Get
            Return _quantiteStock
        End Get
        Set(value As Integer)
            _quantiteStock = value

        End Set
    End Property


    Public Property Min() As Integer
        Get
            Return _min
        End Get
        Set(value As Integer)
            _min = value
        End Set
    End Property

    Public Property Max() As Integer
        Get
            Return _max
        End Get
        Set(value As Integer)
            _max = value
        End Set
    End Property

    Public Shared ReadOnly Property NombreArticle() As Integer
        Get
            Return nbArticle
        End Get
    End Property

#End Region

#Region "méthodes"
    Public Overridable Sub DeposerDuStock(ByVal q As Integer, ByRef Cancel As Boolean)
        'h = nombre d'heures travaillées dans la semaine
        'valeur par défaut (Optional) est _Semaine (la constante de la class valant 37,5)

        If q < 0 Then
            Throw New QuantiteException()
        End If




        If _max < _quantiteStock Then
            RaiseEvent DepassementDeStock(q, Cancel)

        End If

        _quantiteStock += q


    End Sub

    Public Overridable Sub RetirerDuStock(ByVal q As Integer, ByRef Cancel As Boolean)

        Cancel = False
        If q < 0 Then
            Throw New QuantiteException()
        End If

        If q > _quantiteStock Then
            Throw New QuantiteNonDisponibleException("erreur retirer")
        End If

        If _quantiteStock - q < _min Then
            RaiseEvent RuptureDeStock(_quantiteStock - q - _min, Cancel)
        End If

        If Not Cancel Then
            _quantiteStock -= q
        End If


    End Sub

    Public Overrides Function toString() As String

        Return _nom & " " & _reference & " " & _quantiteStock & _min & " " & _max

    End Function


        'événement
    Public Event DepassementDeStock(q As Integer, ByRef Cancel As Boolean)
    Public Event RuptureDeStock(ByVal q As Integer, ByRef Cancel As Boolean)

#End Region
End Class
