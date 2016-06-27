Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary


Public Class frmAffichage

    Private Sub btmAfficher_Click(sender As System.Object, e As System.EventArgs) Handles btmAfficher.Click
        Dim element As New Personne
        'vider la liste pour ne pas l'avoir en double
        lstPersonnes.Items.Clear()

        Dim fichier As New FileStream("Personnes.bin", FileMode.Open)
        Dim f As New BinaryFormatter
        Do While Not fichier.Position = fichier.Length
            element = f.Deserialize(fichier)
            lstPersonnes.Items.Add(element.nom & ": " & element.salaire & " $")
        Loop

        fichier.Close()


    End Sub

    Private Sub frmAffichage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class