Imports prjEmploye
Imports System.Windows.Forms

Public Class Patron
    Inherits Employe 'indique que Patron hérite de la classe Employe
    'Patron hérite des données membres, des propriétés et des méthodes
    'mais pas des constructeurs, destructeur et événements

#Region "données membres"
    Private _chiffreAff As Double 'chiffre d'affaires de l'entreprise
    Private _taux As Double 'taux de rendement en % du chiffre d'affaire
#End Region

#Region "constructeurs et destructeur"
    Public Sub New(ByVal n As String, ByVal nas As String, ByVal t As Double, ByVal ca As Double)
        MyBase.New(n, nas, 1000)
        _taux = t
        _chiffreAff = ca
        MessageBox.Show("constructeur du patron")
    End Sub

    'si on n'avait aucune instruction à faire dans ce destructeur
    '(pas de MessageBox), le système en crée un destructeur par défaut
    'qui appele le destructeur de la classe de base
    Protected Overrides Sub finalize()
        MessageBox.Show("destructeur du patron")
        MyBase.Finalize()
    End Sub
#End Region

#Region "propriétés"
    Public Property chiffreAffaire() As Double
        Get
            Return _chiffreAff
        End Get
        Set(ByVal value As Double)
            _chiffreAff = value
        End Set
    End Property
#End Region

#Region "méthodes"
    'on redéfinit une méthode virtuelle
    Public Overrides Function CalculerSalaire() As Double
        MessageBox.Show("calcul du salaire du patron")

        Return Salaire + _taux / 100 * _chiffreAff
    End Function

    'on redéfinit une méthode par substitution simple
    Public Shadows Sub prendreVacances()
        MessageBox.Show("Vacances d'un patron")
    End Sub
#End Region

    'Public Shadows Event BurnOut(ByVal gravite As Double, ByVal qui As Employe)


End Class
