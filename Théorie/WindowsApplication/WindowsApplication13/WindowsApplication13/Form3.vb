Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TitreTableAdapter.Fill(Me.MusiqueDataSet.Titre)

    End Sub
End Class