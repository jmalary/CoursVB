Public Class frmEx03_Mod2

    Dim nb1 As Integer
    Dim nb2 As Integer
    Dim op As Integer
    Dim temps As Date


    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
    End Sub

    Private Sub btmOperateur_Click(sender As System.Object, e As System.EventArgs) Handles btmOperateur.Click
 

        Dim jet As Random = New Random

        nb1 = jet.Next(1, 100) 'choix aléatoire entre 1 et 4
        nb2 = jet.Next(1, 100) 'choix aléatoire entre 1 et 4
        op = jet.Next(1, 3) 'choix aléatoire entre 1 et 4


        lblNb1.Text = nb1.ToString
        lblnb2.Text = nb2.ToString

        Select Case op
            Case 1 : lblOp.Text = "+"
            Case 2 : lblOp.Text = "-"
            Case 3 : lblOp.Text = "X"
        End Select

        TextBox1.Enabled = True

        tmrChrono.Enabled = True
        'lblEssai.Text += 1
        btmOperateur.Enabled = False
        TextBox1.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles tmrChrono.Tick
        ' temps = temps.AddSeconds(1)
        'lblChrono.Text = FormatDateTime(temps, DateFormat.LongTime)
        lblChrono.Text += 1

    End Sub

    Private Sub btmCorrige_Click(sender As System.Object, e As System.EventArgs) Handles btmCorrige.Click

        Dim reponse As Integer
        Select Case op
            Case 1 : reponse = CInt(nb1) + CInt(nb2)
            Case 2 : reponse = CInt(nb1) - CInt(nb2)
            Case 3 : reponse = CInt(nb1) * CInt(nb2)
        End Select

        

        If reponse = CInt(TextBox1.Text) Then
            PictureBox1.Image = Devoir3.My.Resources.bravo
            lblOui_Non.Text = "OUI !!!"
            lblEssai.Text = 0
            lblChrono.Text = 0
            tmrChrono.Enabled = False
            btmOperateur.Enabled = True
            TextBox1.Enabled = False
            btmCorrige.Enabled = False

        Else
            PictureBox1.Image = Devoir3.My.Resources.non
            lblOui_Non.Text = "NON !!!"
            lblEssai.Text += 1
            btmCorrige.Text = "Réessayer"
        End If

        PictureBox1.Visible = True
        lblOui_Non.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        btmCorrige.Enabled = True
        PictureBox1.Visible = False
        lblOui_Non.Visible = False
        btmCorrige.Text = "Corriger"


    End Sub

    Private Sub lblNb1_Click(sender As System.Object, e As System.EventArgs) Handles lblNb1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblEssai_Click(sender As System.Object, e As System.EventArgs) Handles lblEssai.Click

    End Sub
End Class