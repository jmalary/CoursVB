Imports prjAbstraite

Public Class Form1

    Dim liste As New ArrayList



    Private Sub btnAjouter_Click(sender As System.Object, e As System.EventArgs) Handles btnAjouter.Click
        'déclarer une variable de type CAnimal
        '(base de CChien et de CHumain)

        Dim bibitte As CAnimal
        If rbChien.Checked Then
            bibitte = New CChien
        Else
            bibitte = New CHumain
        End If

        'l'ajouter dans le ArrayList
        liste.Add(bibitte)

    End Sub

    Private Sub btmAfficher_Click(sender As System.Object, e As System.EventArgs) Handles btmAfficher.Click
        lstAnimal.Items.Clear()
        For Each membre As CAnimal In liste
            'afficher les propriétés communes (de CAnimal)
            membre.grossir(5)
            membre.grossir(5)

            lstAnimal.Items.Add(membre.poids & " kg, " & membre.taille & " cm")

            'Afficher les données spécifique à l'instance
            Select Case membre.GetType().Name()
                Case "CChien"
                    lstAnimal.Items.Add("   " & CType(membre, CChien).race)
                Case "CHumain"
                    lstAnimal.Items.Add("   " & CType(membre, CHumain).nom)
            End Select
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
