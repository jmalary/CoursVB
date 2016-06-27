Public Class frmFraction
    Dim numerateur1 As Integer
    Dim numerateur2 As Integer
    Dim Denomenateur1 As Integer
    Dim Denomenateur2 As Integer
    Dim denomenateurCommun As Integer
    Dim resultNumerateur As Integer
    Dim calcule As ToolsMatch

    Private Sub btFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFermer.Click
        Me.Close()
    End Sub

    Private Sub txtValue1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValue1.KeyPress, _
        txtValue2.KeyPress, txtValue3.KeyPress, txtValue4.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            'Tous les caractères non numériques ne sont pas traités sur le TextBox.
            e.Handled = True
        End If
    End Sub

    Private Sub btCalculuer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCalculuer.Click
        numerateur1 = CInt(txtValue1.Text)
        Denomenateur1 = CInt(txtValue2.Text)
        numerateur2 = CInt(txtValue3.Text)
        Denomenateur2 = CInt(txtValue4.Text)
        If (Denomenateur1 = 0 Or Denomenateur2 = 0) Then
            btCalculuer.Enabled = False
            MsgBox("Division par 0 impossible !!!!")
        Else
            Select Case lblOperateur.Text
                Case "+"
                    additionFraction()
                    'faire le traitement pour une addition de fractions
                Case "-"
                    SoustractionFraction()
                    'faire le traitement pour une soustraction de fractions
                Case "*"
                    multiplicationFraction()
                    'faire le traitement pour une multiplication de fractions  

                Case "/"
                    divisionFraction()
                    'faire le traitement pour une division de fractions
            End Select
        End If

    End Sub

    Private Sub RBAddition_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBAddition.CheckedChanged, _
        RBSoustraction.CheckedChanged, RbMultplication.CheckedChanged, RbDivision.CheckedChanged
        Dim radiobutton As RadioButton = CType(sender, RadioButton)
        lblOperateur.Text = CStr(CType(sender, RadioButton).Tag)
        lblOperateur.Tag = (CType(sender, RadioButton).Tag)
    End Sub

    Private Sub frmFraction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RBAddition.Checked = True
        btCalculuer.Enabled = False
    End Sub

    Private Sub txtValue1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValue1.TextChanged, _
        txtValue2.TextChanged, txtValue3.TextChanged, txtValue4.TextChanged
        If (txtValue1.Text <> "" And txtValue2.Text <> "" And txtValue3.Text <> "" And txtValue4.Text <> "") Then
            btCalculuer.Enabled = True
        End If
    End Sub

    Private Sub additionFraction()
        If (Denomenateur1 <> Denomenateur2) Then
            denomenateurCommun = Denomenateur1 * Denomenateur2
            numerateur1 = numerateur1 * Denomenateur2
            numerateur2 = numerateur2 * Denomenateur1
        ElseIf Denomenateur1 = Denomenateur2 Then
            denomenateurCommun = Denomenateur1
        End If
        resultNumerateur = numerateur1 + numerateur2
        lblResultFrac1.Text = CStr(resultNumerateur)
        lblResultFrac2.Text = CStr(denomenateurCommun)
    End Sub

    Private Sub SoustractionFraction()
        If (Denomenateur1 <> Denomenateur2) Then
            denomenateurCommun = Denomenateur1 * Denomenateur2
            numerateur1 = numerateur1 * Denomenateur2
            numerateur2 = numerateur2 * Denomenateur1
        ElseIf Denomenateur1 = Denomenateur2 Then
            denomenateurCommun = Denomenateur1
        End If
        resultNumerateur = numerateur1 - numerateur2
        lblResultFrac1.Text = CStr(resultNumerateur)
        lblResultFrac2.Text = CStr(denomenateurCommun)
    End Sub

    Private Sub multiplicationFraction()
        denomenateurCommun = Denomenateur1 * Denomenateur2
        resultNumerateur = numerateur1 * numerateur2
        lblResultFrac1.Text = CStr(resultNumerateur)
        lblResultFrac2.Text = CStr(denomenateurCommun)
    End Sub
    Private Sub divisionFraction()
        denomenateurCommun = Denomenateur1 * numerateur2
        resultNumerateur = numerateur1 * Denomenateur2
        lblResultFrac1.Text = CStr(resultNumerateur)
        lblResultFrac2.Text = CStr(denomenateurCommun)
    End Sub


    'Private Function euclide() As Integer
    '    Dim pgcd As Integer
    '    Dim reste As Integer
    '    Dim a As Integer
    '    Dim b As Integer
    '    If CInt(lblResultFrac1.Text) > CInt(lblResultFrac2.Text) Then
    '        a = CInt(lblResultFrac1.Text)
    '        b = CInt(lblResultFrac2.Text)
    '    Else
    '        a = CInt(lblResultFrac2.Text)
    '        b = CInt(lblResultFrac1.Text)
    '    End If
    '    reste = a Mod b
    '    While reste <> 0
    '        a = b
    '        b = reste
    '        reste = a Mod b
    '    End While
    '    pgcd = b
    '    MsgBox("Le pgcd de  " & CInt(lblResultFrac1.Text) & "et " & CInt(lblResultFrac2.Text) & " == " & pgcd)


    '    Return pgcd
    'End Function

    Private Sub btReduire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReduire.Click

        calcule = New ToolsMatch(CInt(lblResultFrac1.Text), CInt(lblResultFrac2.Text))
        Dim diviseur = calcule.euclide
        MsgBox("Diviseur " & diviseur)
        resultNumerateur = CInt(resultNumerateur / diviseur)
        denomenateurCommun = CInt(denomenateurCommun / diviseur)
        lblResultFrac1.Text = CStr(resultNumerateur)
        lblResultFrac2.Text = CStr(denomenateurCommun)
    End Sub
End Class