Imports System.Windows.Forms

Public Class Employe
#Region "données membres"
    Private _nom As String
    Private _nas As String 'numéro d'assurance sociale
    Private _salaire As Double 'salaire horaire ($/h)
    Private Const _Semaine As Double = 37.5 'nombre d'heures de travail par semaine
    Private Shared nbEmployes As Integer 'équivalent de static en C++/Java
    'Shared est associé à la classe, pas à une instance
#End Region

#Region "constructeurs et destructeurs"
    'constructeurs(méthodes automatiquement appelées lorsqu'une instance est créé)
    'New est le nom obligatoire des constructeurs
    Public Sub New()
        nbEmployes += 1
        MessageBox.Show("constructeur d'employe")
    End Sub

    'le constructeur peut être surchargé (overloaded)
    Public Sub New(ByVal n As String, ByVal nas As String, ByVal sal As Double)
        'affection des paramètres aux données membres
        _nom = n
        _nas = nas
        Salaire = sal 'on passe par le Set de la propriety(pour tester l'exception)
        ' _salaire = salaire

        nbEmployes += 1
        MessageBox.Show("contructeur d'employe")
    End Sub

    'destructeur(automatiquement appelé quand l'instance disparaît de la mémoire)
    'jamais public (jamais invoqué hors de la classe),
    'mais Protected  parce que le destructeur des héritiers doivent pouvoir l'appeler
    'Overrides indique qu'il est polymorphé(virtuel),
    '  parce que Employé hérite automatiquement de la classe Object
    'Finalise est le nom obligatoire du destructeur

    Protected Overrides Sub Finalize()
        MessageBox.Show("destructeur de Employe")
        nbEmployes -= 1
    End Sub


#End Region

#Region "proprietés"
    'En VB.Net: les méthodes Get et Set sont regroupées en "propriétés"
    'qui pourront être invoqué avec "instance.Nom_de_la_propriété"
    Public Property Nom() As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property
    Public ReadOnly Property NAS() As String
        'ReadOnly indique'on a un Get, mais pas de Set
        'On peut saisir la valeur, mais pas la changer
        'WriteOnly existe aussi
        Get
            Return _nas
        End Get
    End Property
    Public Property Salaire() As Double
        Get
            Return _salaire
        End Get
        Set(value As Double)
            If value < 10.1 Then 'si le salaire est inférieur au salaire minimum
                Throw New ExploitationException("salaire insuffisant")
            End If
            _salaire = value
        End Set
    End Property
    Public ReadOnly Property SEMAINE() As Double
        Get
            Return _Semaine
        End Get
    End Property
    Public Shared ReadOnly Property NombreEmployes() As Integer
        Get
            Return nbEmployes
        End Get
    End Property
#End Region

#Region "méthodes"
    'Overridable déclare la méthode comme virtuelle
    '(pourra être reédinie dans un héritier sans problème -> polymorphisme)
    Public Overridable Function CalculerSalaire(ByVal h As Double) As Double
        'h = nombre d'heures travaillées dans la semaine
        'valeur par défaut (Optional) est _Semaine (la constante de la class valant 37,5)
        MessageBox.Show("Calcul du salaire d'un employé")
        If h > 70 Then
            RaiseEvent BurnOut(h - 70, Me)
        End If
        Return _salaire * h
    End Function

    Public Overridable Function CalculerSalaire() As Double
        MsgBox("calcul du salaire d'un employé")

        Return _salaire * _Semaine

    End Function

    Public Sub prendreVacances()
        'juste pour tester l'héritage
        MessageBox.Show("vacances d'un employe")
    End Sub

    Public Sub augmenterSalaire()
        'pour tester l'héritage avec polymorphisme
        MessageBox.Show("augmentation d'un employe")
        CalculerSalaire()
    End Sub

#End Region

    'Événement
    Public Event BurnOut(gravite As Double, qui As Employe)

End Class
