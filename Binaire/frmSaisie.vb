Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmSaisie

    Private Sub frmSaisie_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim nomFichier As String = "C:\Personne.bin"
        's'assurer que le fichier existe
        'OpenOnCreate: creer le fichier s'il n'existe pas
        Dim fichier As New FileStream(nomFichier, FileMode.OpenOrCreate)
        fichier.Close()
    End Sub

    Private Sub btmEnregistrer_Click(sender As System.Object, e As System.EventArgs) Handles btmEnregistrer.Click
        Dim lui As Personne
        lui.nom = txtNom.Text
        lui.salaire = CDbl(txtSalaire.Text) 'normalement on valide
        'avec Try - Catch, Parse, isNumeric, etc.
        txtNom.Text = ""
        txtSalaire.Text = ""

        Dim nomFichier As String = "Personnes.bin"
        'on ouvre le fichier pour ajouter à la fin 

        Dim fichier As New FileStream(nomFichier, FileMode.Append)
        Dim f As New BinaryFormatter
        f.Serialize(fichier, lui)
        fichier.Close()


    End Sub
End Class