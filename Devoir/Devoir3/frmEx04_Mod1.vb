Public Class frmEx04_Mod1


    Dim nb1 As Integer
    Dim nb2 As Integer


    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        lblMsg1.Visible = False
    End Sub


    Private Sub frmEx04_Mod1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If RadioButton1.Checked = True Then
            lblMessage.Text = "Addition"
        ElseIf RadioButton2.Checked = True Then
            lblMessage.Text = "Soustraction"
        Else
            lblMessage.Text = ""
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        If RadioButton1.Checked = True Then
            lblMessage.Text = "Addition"
            lblOperation.Text = "+"
            TextBox1.Visible = True
            lblNombre1.Visible = True
            lblOperation.Visible = True
            lblReponse.Text = ""
        ElseIf RadioButton2.Checked = True Then
            lblMessage.Text = "Soustraction"
            lblOperation.Text = "-"
            TextBox1.Visible = True
            lblNombre1.Visible = True
            lblOperation.Visible = True
            lblReponse.Text = ""
        ElseIf RadioButton3.Checked = True Then
            lblMessage.Text = "Multiplication"
            lblOperation.Text = "X"
            TextBox1.Visible = True
            lblNombre1.Visible = True
            lblOperation.Visible = True
            lblReponse.Text = ""
        ElseIf RadioButton4.Checked = True Then
            lblMessage.Text = "Division"
            lblOperation.Text = ":"
            TextBox1.Visible = True
            lblNombre1.Visible = True
            lblOperation.Visible = True
            lblReponse.Text = ""
        ElseIf RadioButton5.Checked = True Then
            lblMessage.Text = "Factorielle"
            TextBox1.Visible = False
            TextBox1.Text = "0"
            lblNombre1.Visible = False
            lblOperation.Text = ""
            btmCalculer.Enabled = False
            lblNombre2.Text = "Factorielle de "
            lblMsg1.Visible = False
            lblMsg2.Visible = True
            lblMsg2.Text = "Entrer un nombre entier"
            lblReponse.Text = ""
        End If

    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox2.GotFocus
        lblMsg2.Visible = True

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        btmCalculer.Enabled = True
        lblMsg2.Visible = False
    End Sub

    Private Sub btmCalculer_Click(sender As System.Object, e As System.EventArgs) Handles btmCalculer.Click
        Try
            nb1 = CInt(TextBox1.Text)
            nb2 = CInt(TextBox2.Text)
        Catch ex As InvalidCastException
        End Try

        Dim reponse As String
        reponse = ""
        Select Case lblOperation.Text
            Case "+" : reponse = CDbl(nb1) + CDbl(nb2)
            Case "-" : reponse = CDbl(nb1) - CDbl(nb2)
            Case "X" : reponse = CDbl(nb1) * CDbl(nb2)
            Case ":"
                If nb2.ToString <> "0" Then
                    reponse = CDbl(nb1) / CDbl(nb2)
                Else
                    reponse = "Division par 0 !!"
                End If
            Case Else : reponse = fctFactorielle(nb2)
        End Select

        lblReponse.Text = reponse

    End Sub


    Function fctFactorielle(ByVal nb As Integer) As String

        Dim chaine As String 'chaîne servant de tampon de lecture
        Dim somme As Long

        somme = 1

        For i = 1 To nb
            somme = i * somme
        Next


        chaine = somme


        Return chaine

    End Function
End Class