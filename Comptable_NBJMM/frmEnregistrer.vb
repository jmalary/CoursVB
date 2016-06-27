Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb

Public Class frmEnregistrer

    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand

    Dim test_a As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows
        frmMenu.Show()
    End Sub

    Private Sub frmEnregistrer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = Date.Now
        Dim today = DateCourant

        Dim jour As String

        Dim day = today.Day

        Dim month = today.Month

        Dim years = today.Year

        ' MsgBox(Date.Today.DayOfWeek)


        Dim Mois As String

        Select Case Date.Today.DayOfWeek
            Case 0
                jour = "Dimanche"
            Case 1
                jour = "Lundi"
            Case 2
                jour = "Mardi"
            Case 3
                jour = "Mercredi"
            Case 4
                jour = "Jeudi"
            Case 5
                jour = "Vendredi"
            Case 6
                jour = "Samedi"

        End Select

        Select Case month
            Case 1
                Mois = "janvier"
            Case 2
                Mois = "février"
            Case 3
                Mois = "mars"
            Case 4
                Mois = "avril"
            Case 5
                Mois = "mai"
            Case 6
                Mois = "juin"
            Case 7
                Mois = "juillet"
            Case 8
                Mois = "aout"
            Case 9
                Mois = "septembre"
            Case 10
                Mois = "octobre"
            Case 11
                Mois = "novembre"
            Case 12
                Mois = "decembre"

        End Select

        Dim courant = String.Concat(jour, " ", day, " ", Mois, " ", years)

        'Label8.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Label1.Text = courant + "   " + Format(Now(), "HH:mm:ss")

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim message As String = ""



        Dim apport As calculer_Apport

        apport = New calculer_Apport()

        message = apport.start_apport()
        'Dim numero As Integer = apport.test()

        'numero = numero + 1

        Dim retrait As calculer_retraire_manuel

        retrait = New calculer_retraire_manuel()

        message = retrait.start_retraire(message)

        Dim direct As calculer_paiement_direct

        direct = New calculer_paiement_direct()

        message = direct.start_direct(message)

        Dim preautoriser As calculer_paiement_preautorise

        preautoriser = New calculer_paiement_preautorise()

        message = preautoriser.start_preautoriser(message)

        Dim circulation As calculer_cheque

        circulation = New calculer_cheque()

        message = circulation.start_cheque(message)

        Dim salaire As calculer_salaire_paie

        salaire = New calculer_salaire_paie()

        message = salaire.start_salaire_paie(message)







    End Sub
End Class