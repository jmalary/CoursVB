Public Class frmQuiz
    Dim nombreQuiz As Integer
    Dim compteurQuiz As Integer
    Dim nombreOperation As Integer
    Dim choixOperation As Integer
    Dim compteurJuste As Integer
    Dim compteurFaux As Integer
    Dim lstoperations As New ArrayList
    Dim aleatoire As Random = New Random

    Private Sub frmQuiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nombreQuiz = 10
        'MsgBox("Le nombre de Quiz est :" & nombreQuiz)
        txtnbQuiz.Text = CStr(nombreQuiz)
    End Sub

    Private Sub CbAddition_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbAddition.CheckedChanged, _
CbDivision.CheckedChanged, CbMultiplication.CheckedChanged, CbSoustraction.CheckedChanged
        If CType(sender, CheckBox).Checked = True Then
            nombreOperation = nombreOperation + 1
            btStartQuiz.Enabled = True
        Else
            nombreOperation = nombreOperation - 1
        End If

        If (CbAddition.Checked = False And CbDivision.Checked = False And CbMultiplication.Checked = False _
    And CbSoustraction.Checked = False) Then
            btStartQuiz.Enabled = False
        End If
    End Sub

    Private Sub btStartQuiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStartQuiz.Click
        MsgBox("Nombre de Quiz =  " & nombreQuiz)
        If CbAddition.Checked = True Then
            btAddition.Visible = True
            lstoperations.Add("+")
        Else
            btAddition.Visible = False
        End If

        If CbSoustraction.Checked = True Then
            btSoustraction.Visible = True
            lstoperations.Add("-")
        Else
            btSoustraction.Visible = False
        End If

        If CbDivision.Checked = True Then
            btdivision.Visible = True
            lstoperations.Add(":")
        Else
            btdivision.Visible = False
        End If

        If CbMultiplication.Checked = True Then
            btmultiplication.Visible = True
            lstoperations.Add("*")
        Else
            btmultiplication.Visible = False
        End If
        PannelQuiz.Visible = True
        GbOpérations.Visible = False
        gbResultat.Visible = True
        GenererOperation()
        'activer les boutons visibles par activation de tous les boutons
        btAddition.Enabled = True
        btSoustraction.Enabled = True
        btmultiplication.Enabled = True
        btdivision.Enabled = True
        'affichage des éléments de la boite de dialogue
        lblResultMessage.Visible = False
        lblValeur1.Visible = True
        lblValeur2.Visible = True
        lblResultat.Visible = True


    End Sub
    Private Sub btNouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNouveau.Click
        PannelQuiz.Visible = False
        CbAddition.Checked = False
        CbDivision.Checked = False
        CbMultiplication.Checked = False
        CbSoustraction.Checked = False
        btStartQuiz.Enabled = False
        GbOpérations.Visible = True
        gbResultat.Visible = False
        compteurJuste = 0
        compteurFaux = 0
        compteurQuiz = 0  'initialisation du compteur Quiz
        lblresponseJuste.Text = "Réponse exacte" & compteurJuste
        lblReponsefausse.Text = "Réponse fausse" & compteurFaux
        lstoperations.Clear()
    End Sub
    'methode pour génerer les opérations du quiz
    Public Sub GenererOperation()

        Dim valeur1 = aleatoire.Next(0, 13)
        Dim valeur2 = aleatoire.Next(0, 13)
        Dim resultat As Integer
        'incrementer le compteur des Quiz
        compteurQuiz = compteurQuiz + 1
        If compteurQuiz <= nombreQuiz Then

            choixOperation = aleatoire.Next(0, nombreOperation)
            ' MsgBox("choixOperation " & lstoperations(choixOperation).ToString)
            lblValeur1.Text = CStr(valeur1)
            lblValeur2.Text = CStr(valeur2)
            Select Case lstoperations(choixOperation).ToString
                Case "+"
                    resultat = valeur1 + valeur2
                Case "-"
                    resultat = valeur1 - valeur2
                Case "*"
                    resultat = valeur1 * valeur2
                Case ":"
                    resultat = CInt(valeur1 / valeur2)
            End Select

            lblResultat.Text = CStr(resultat)
            lblNumQuestion.Text = "Numero Question :" & compteurQuiz
        Else
            MsgBox("Fin du Quiz Vous avez eu " & (compteurJuste / nombreQuiz) * 100 & "  %")
            afficherResultat()
            lblResultMessage.Visible = True
            lblValeur1.Visible = False
            lblValeur2.Visible = False
            lblResultat.Visible = False
            btAddition.Enabled = False
            btSoustraction.Enabled = False
            btmultiplication.Enabled = False
            btdivision.Enabled = False
        End If
    End Sub

    Private Sub btSoustraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSoustraction.Click
        If btSoustraction.Text.Equals(lstoperations(choixOperation).ToString) Then
            compteurJuste = compteurJuste + 1
            lblresponseJuste.Text = "Réponse exacte : " & compteurJuste
        Else
            compteurFaux = compteurFaux + 1
            lblReponsefausse.Text = "Réponse(s) Fausse(s)  :" & compteurFaux
        End If
        GenererOperation()
    End Sub

    Private Sub btAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddition.Click
        If btAddition.Text.Equals(lstoperations(choixOperation).ToString) Then
            compteurJuste = compteurJuste + 1
            lblresponseJuste.Text = "Réponse exacte :  " & compteurJuste
        Else
            compteurFaux = compteurFaux + 1
            lblReponsefausse.Text = "Réponse(s) Fausse(s)  : " & compteurFaux
        End If
        GenererOperation()
    End Sub

    Private Sub btdivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdivision.Click
        If btdivision.Text.Equals(lstoperations(choixOperation).ToString) Then
            compteurJuste = compteurJuste + 1
            lblresponseJuste.Text = "Réponse exacte : " & compteurJuste
        Else
            compteurFaux = compteurFaux + 1
            lblReponsefausse.Text = "Réponse(s) Fausse(s)  :" & compteurFaux
        End If
        GenererOperation()
    End Sub

    Private Sub btmultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmultiplication.Click
        If btmultiplication.Text.Equals(lstoperations(choixOperation).ToString) Then
            compteurJuste = compteurJuste + 1
            lblresponseJuste.Text = "Réponse exacte : " & compteurJuste
        Else
            compteurFaux = compteurFaux + 1
            lblReponsefausse.Text = "Réponse(s) Fausse(s)  :" & compteurFaux
        End If

        GenererOperation()
    End Sub

    Private Sub txtnbQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnbQuiz.TextChanged
        Try
            nombreQuiz = CInt(txtnbQuiz.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub afficherResultat()
        'MsgBox("Fin du Quiz Vous avez eu " & (compteurJuste / nombreQuiz) * 100 & "  %")
        Dim resultat As Double
        resultat = (compteurJuste / nombreQuiz) * 100
        If resultat < 50 Then
            lblResultMessage.Text = resultat & "  % avec plus d'exercices,Tu pourras être mieux !!!"
        ElseIf resultat >= 50 And resultat < 70 Then
            lblResultMessage.Text = resultat & "  %  Moyen,Tu pourras être mieux !!!"
        ElseIf resultat >= 70 And resultat < 90 Then
            lblResultMessage.Text = resultat & "  %  Bravo!!!"
        ElseIf resultat >= 90 Then
            lblResultMessage.Text = resultat & "  %  Excellent!!!"
        End If
    End Sub


End Class