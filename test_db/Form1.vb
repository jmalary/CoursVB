Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DareddTableAdapter.Fill(Me.SMSDataSet.Daredd)

    End Sub
End Class
