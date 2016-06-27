Imports prjComptabilite

Public Class Form1
    Dim solde As Double

    Dim WithEvents cpt As Compte
   
    Private Sub bCreerCompte_Click(sender As System.Object, e As System.EventArgs) Handles bCreerCompte.Click




        Dim solde As Double = CDbl(txtSolde.Text)

        Dim cancel As Boolean

        Try
            If IsNumeric(solde) Then

                'cpt = New Comptabilite(txtNomClient.Text, CInt(txtNumCompte.Text), CDbl(txtSolde.Text)

                cpt = New Compte(txtNomClient.Text, CInt(txtNumCompte.Text), CDbl(txtSolde.Text))
                gbCompte.Enabled = False
                gbOperations.Visible = True
                LbSolde.Text = cpt.Solde.ToString
            End If
        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bDepot_Click(sender As System.Object, e As System.EventArgs) Handles bDepot.Click


        Dim msg As String
        LbErreur.Visible = False

        msg = InputBox("Montant", "GEstionComptable")

        Dim solde As Double = CDbl(msg)

        Dim cancel As Boolean

        Try
            If IsNumeric(solde) Then
                cpt.Depot(solde, cancel)
                If Not cancel Then
                    LbSolde.Text = cpt.Solde & " $ "
                End If


            End If
        Catch ex As Exception
            LbErreur.Text = "Le montant déposé ne peut être négatif !"

        End Try
    End Sub

    Private Sub bRetrait_Click(sender As System.Object, e As System.EventArgs) Handles bRetrait.Click

        Dim msg As String

        msg = InputBox("Montant", "GEstionComptable")

        solde = CDbl(msg)

        Dim cancel As Boolean

        Try
            If IsNumeric(solde) Then
                cpt.Retrait(solde, cancel)
                If Not cancel Then
                    LbSolde.Text = cpt.Solde & " $ "

                    
                End If
            End If
        Catch ex As SoldeInsuffisantException

            LbErreur.Visible = True
            LbErreur.Text = "Solde insuffisant pour retirer" & solde & " $. "
        End Try



    End Sub

    Private Sub cpt_RetraitEvent(ByVal s As Double, ByRef Cancel As Boolean) Handles cpt.RetraitEvent

        Dim reponse As DialogResult

        LbErreur.Visible = False
        reponse = MessageBox.Show("Vous êtes sur le point de retirer " & solde & " $ de votre compte, Voulez-vous continuer?", "Retrait", MessageBoxButtons.YesNo)
        If reponse = Windows.Forms.DialogResult.Yes Then



        Else

            Cancel = True
        End If




    End Sub


    Private Sub bFermer_Click(sender As System.Object, e As System.EventArgs) Handles bFermer.Click
        End
    End Sub
End Class
