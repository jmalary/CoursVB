Public Class frmTable

    Dim nombre As Integer
    Dim op As String
    Dim compteur As Integer

    Private Sub btm7_Click(sender As System.Object, e As System.EventArgs) Handles btm0.Click, btm1.Click, btm2.Click, btm3.Click, btm4.Click, _
        btm5.Click, btm6.Click, btm7.Click, btm8.Click, btm9.Click

        initialiser()

        nombre = CInt(CType(sender, Button).Tag)

        lblChiffre.Text = CStr(nombre)
    End Sub


    Sub initialiser()

        btmAjouter.Enabled = True
        btmSoustraire.Enabled = True
        btmMuplication.Enabled = True
        btmDivison.Enabled = True



    End Sub

    Private Sub btmAjouter_Click(sender As System.Object, e As System.EventArgs) Handles btmAjouter.Click, btmSoustraire.Click, btmMuplication.Click, btmDivison.Click

        op = (CType(sender, Button).Tag)

        lblOperation.Text = op

        btmCalculer.Enabled = True


    End Sub


    Private Sub frmTable_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        op = ""
        desactive()
    End Sub


    Function fonc_A() As Double

        Dim reponse As Double

        Select Case op
            Case "+" : reponse = CDbl(nombre) + CDbl(compteur)
            Case "-" : reponse = CDbl(nombre) - CDbl(compteur)
            Case "x" : reponse = CDbl(nombre) * CDbl(compteur)
            Case "/" : reponse = CDbl(nombre) / CDbl(compteur)
        End Select



        Return reponse

    End Function


    Private Sub btmCalculer_Click(sender As System.Object, e As System.EventArgs) Handles btmCalculer.Click

        Dim msg As String
        'Dim rep As Double

        msg = ""
        lblTable.Text = ""

        For i = 0 To 9 Step 1
            compteur = i
            msg += CInt(i + 1) & ".   " & CInt(nombre) & "  " & op & "   " & i & " = " & CDbl(fonc_A()) & vbCrLf & " "

        Next

        lblTable.Text = msg

        btmCalculer.Enabled = False
        desactive()
        btmRecommencer.Enabled = True


    End Sub

    Sub desactive()

        Dim btmBoolen As Boolean = False

        If btm1.Enabled = False Then
            btmBoolen = True
        Else
            btmBoolen = False
        End If

        btm0.Enabled = btmBoolen
        btm1.Enabled = btmBoolen
        btm2.Enabled = btmBoolen
        btm3.Enabled = btmBoolen
        btm4.Enabled = btmBoolen
        btm5.Enabled = btmBoolen
        btm6.Enabled = btmBoolen
        btm7.Enabled = btmBoolen
        btm8.Enabled = btmBoolen
        btm9.Enabled = btmBoolen
        btmAjouter.Enabled = btmBoolen
        btmSoustraire.Enabled = btmBoolen
        btmMuplication.Enabled = btmBoolen
        btmDivison.Enabled = btmBoolen

    End Sub

    Private Sub btmRecommencer_Click(sender As System.Object, e As System.EventArgs) Handles btmRecommencer.Click
        desactive()
        lblChiffre.Text = ""
        lblOperation.Text = ""
        lblTable.Text = ""
        btmRecommencer.Enabled = False
    End Sub

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
        frmMenu.Show()
        frmMenu.WindowState = FormWindowState.Maximized
    End Sub

    Sub activerButton()

    End Sub


End Class