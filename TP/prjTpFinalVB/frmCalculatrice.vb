Public Class frmCalculatrice

    Dim nombre As String
    Dim demarre As Boolean
    Dim memoire As Integer
    Dim parenthese As Boolean = False

    

    Private Sub btm7_Click(sender As System.Object, e As System.EventArgs) Handles btm0.Click, btm1.Click, btm2.Click, btm3.Click, btm4.Click, _
        btm5.Click, btm6.Click, btm7.Click, btm8.Click, btm9.Click

        If demarre = False Then
            demarre = True
            initialiser()
        End If

        nombre &= CInt(CType(sender, Button).Tag)


        txtReponse.Text = nombre


    End Sub

    Sub initialiser()

        btmMR.Enabled = True
        btmMC.Enabled = True
        BtmMS.Enabled = True
        btmMAjouter.Enabled = True
        btmMenlever.Enabled = True
        btmC.Enabled = True

        btmParam1.Enabled = True
        btmParam2.Enabled = True
        btmAjouter.Enabled = True
        btmSoustraire.Enabled = True
        btmX.Enabled = True
        btmDiv.Enabled = True
        btmegale.Enabled = True
        txtReponse.Enabled = True


    End Sub

    Sub Desactiver()

       
        btmParam1.Enabled = False
        btmParam2.Enabled = False
        btmAjouter.Enabled = False
        btmSoustraire.Enabled = False
        btmX.Enabled = False
        btmDiv.Enabled = False




    End Sub







    Private Sub btmMR_Click(sender As System.Object, e As System.EventArgs) Handles btmMR.Click, btmMC.Click, BtmMS.Click, btmMAjouter.Click, btmMenlever.Click, btmC.Click, btmegale.Click


        Dim msg As String

        msg = (CType(sender, Button).Tag)



        Select Case msg
            Case "mr" : txtReponse.Text = CInt(memoire)
            Case "mc" : memoire = 0
            Case "c" : txtReponse.Text = ""
                nombre = ""
            Case "ms" : memoire = txtReponse.Text
                lblMemtoire.Text = "Mémoire:  " & CInt(memoire)
            Case "majouter"
                Dim nbr2 As Double = CDbl(txtReponse.Text)
                memoire += nbr2
                lblMemtoire.Text = "Mémoire:  " & CInt(memoire)
                nombre = ""
            Case "menlever"
                Dim nbr2 As Double = CDbl(txtReponse.Text)
                memoire -= nbr2
                lblMemtoire.Text = "Mémoire:  " & CInt(memoire)
                nombre = ""
            Case "egale"
                nombre = txtReponse.Text
                ajouterElementTableau()
                nombre = ""
                demarre = False
                Desactiver()
        End Select


    End Sub


    Private Sub frmCalculatrice_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        demarre = False
        nombre = ""
        memoire = 0
    End Sub

    Private Sub btmAjouter_Click(sender As System.Object, e As System.EventArgs) Handles btmAjouter.Click, btmSoustraire.Click, btmX.Click, btmDiv.Click, btmParam1.Click, btmParam2.Click

        nombre &= CStr(CType(sender, Button).Tag)

        txtReponse.Text = nombre


    End Sub


    Sub ajouterElementTableau()

        Dim traiterTab As Tableau

        traiterTab = New Tableau(nombre, parenthese)

        nombre = traiterTab.ajouterElementTab


        Dim calcule As FaireCalcul

        calcule = New FaireCalcul(nombre)

        Dim apres_rep = calcule.calculer

        txtReponse.Text = apres_rep.ToString

    End Sub

   

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
        frmMenu.Show()
        frmMenu.WindowState = FormWindowState.Maximized
    End Sub


End Class
