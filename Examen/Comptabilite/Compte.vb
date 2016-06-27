Imports System.Windows.Forms

Public Class Compte

#Region "données membres"

    Private _NomClient As String
    Private _NumClient As Integer
    Private _Solde As Double
    Private Shared nbCompte As Integer

#End Region

#Region "constructeurs et destructeurs"

    Public Sub New()
        nbCompte += 1
        MessageBox.Show("constructeur de compte")

    End Sub

    Public Sub New(ByVal nom As String, ByVal num As Integer, ByVal d As Double)
        _NomClient = nom
        _NumClient = num
        _Solde = d

        nbCompte += 1
        MessageBox.Show("constructeur de compte")

    End Sub

    Protected Overrides Sub Finalize()
        MessageBox.Show("destructeur de compte")
        nbCompte -= 1
    End Sub


#End Region

#Region "proprietés"
    Public Property NomClient() As String
        Get
            Return _NomClient
        End Get
        Set(value As String)
            _NomClient = value
        End Set
    End Property

    Public Property NumClient() As Integer
        Get
            Return _NumClient
        End Get
        Set(value As Integer)
            _NumClient = value
        End Set
    End Property

    Public Property Solde() As Double
        Get
            Return _Solde
        End Get
        Set(value As Double)
            _Solde = value
        End Set
    End Property

#End Region

#Region "méthodes"

    Public Overridable Sub Depot(ByVal d As Double, ByRef Cancel As Boolean)

        If d < 0 Then
            Throw New Exception()
        End If

        _Solde += d
    End Sub

    Public Overridable Sub Retrait(ByVal d As Double, ByRef Cancel As Boolean)

        Cancel = False

        If d < 0 Then
            Throw New Exception
        End If

        If d > _Solde Then
            Throw New SoldeInsuffisantException("Erreur Retrait")
        End If

        If d < _Solde Then
            RaiseEvent RetraitEvent(_Solde - d, Cancel)
        End If

        If Not Cancel Then
            _Solde -= d
        End If

    End Sub

    Public Event RetraitEvent(ByVal d As Double, ByRef cancel As Boolean)
#End Region

End Class
