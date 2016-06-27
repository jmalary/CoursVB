Public Class QuantiteException
    Inherits ApplicationException
    Public Sub New()
        MyBase.New("La quantité négative") 'MyBase équivant au "super" de Java
    End Sub

End Class
