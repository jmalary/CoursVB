Imports prjArticle

Public Class Form1

    Dim WithEvents art As Article 'pointeur sur un Article à Nothing
    '(New n'a pas été fait donc pas d'instance)

    Dim colArticle As New ArrayList


    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        End
    End Sub

    Private Sub btmCreer_Click(sender As System.Object, e As System.EventArgs) Handles btmCreer.Click


        'art = New Article(txtNom.Text, CInt(txtRef.Text), CInt(txtQuantite.Text), 0)
        If CInt(txtMax.Text) >= CInt(txtStock.Text) And CInt(txtMin.Text) <= CInt(txtStock.Text) Then
            art = New Article(txtNom.Text, txtRef.Text, CInt(txtStock.Text), CInt(txtMin.Text), CInt(txtMax.Text))
            ApresChamps()
            lblAffStock.Text = art.QuantitesStock

        End If







    End Sub

    Sub ApresChamps()
        txtRef.Enabled = False
        txtNom.Enabled = False
        txtStock.Enabled = False
        txtMin.Enabled = False
        txtMax.Enabled = False
        btmCreer.Enabled = False
        lblQuantite.Enabled = True
        txtQuantite.Enabled = True
        btmEntree.Enabled = True
        btmSortie.Enabled = True

    End Sub

    Private Sub btmEntree_Click(sender As System.Object, e As System.EventArgs) Handles btmEntree.Click

        Dim qte As Integer = CInt(txtQuantite.Text)

        Dim cancel As Boolean
        Try
            If IsNumeric(qte) Then
                art.DeposerDuStock(qte, cancel)
                If Not cancel Then 'cancel à true=annuler
                    ' not cancel = pas annulé
                    lblAffStock.Text = art.QuantitesStock
                    lblMessage.Text = "MAJ Stock OK"
                    txtQuantite.Text = ""
                    txtQuantite.Focus()
                End If
            End If
        Catch ex As QuantiteException
            lblMessage.Text = "negative"
            txtQuantite.Text = ""
            txtQuantite.Focus()

        End Try




    End Sub

    Private Sub btmSortie_Click(sender As System.Object, e As System.EventArgs) Handles btmSortie.Click

        Dim qte As Integer = CInt(txtQuantite.Text)

        Dim cancel As Boolean

        Try
            If IsNumeric(qte) Then

                art.RetirerDuStock(qte, cancel)
                If Not cancel Then 'cancel à true=annuler
                    ' not cancel = pas annulé
                    lblAffStock.Text = art.QuantitesStock
                End If
            End If

            txtQuantite.Text = ""
            txtQuantite.Focus()

        Catch ex As QuantiteNonDisponibleException
 
        End Try

    End Sub

    Private Sub art_RuptureDeStock(q As Integer, ByRef Cancel As Boolean) Handles art.RuptureDeStock
        Dim reponse As DialogResult
        reponse = MessageBox.Show("Stock", "seul atteint", MessageBoxButtons.YesNo)
        If reponse = Windows.Forms.DialogResult.Yes Then
            Cancel = True
            lblMessage.Text = "MAJ Annulé"

        Else
            lblMessage.Text = "MAJ OK"
        End If

        txtQuantite.Text = ""
        txtQuantite.Focus()

    End Sub

End Class
