Public Class QuantiteNonDisponibleException
    Inherits ApplicationException
    Public Sub New(ByVal message As String)
        MyBase.New(message) 'MyBase équivant au "super" de Java
    End Sub

End Class
