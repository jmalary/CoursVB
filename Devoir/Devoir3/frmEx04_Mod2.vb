Public Class frmEx04_Mod2
    Public demarre As Boolean
    Public enteindreEnFeul As Boolean
    Public eteindre As Integer = 75
    Public hauteur As Integer

    Private Sub btmStop_Click(sender As System.Object, e As System.EventArgs) Handles btmStop.Click
        Me.Close()
    End Sub

    Private Sub btmEclair_Click(sender As System.Object, e As System.EventArgs) Handles btmEclair.Click
        btmEclair.Enabled = False
        btmStop.Enabled = True
        'TmrCourse.Enabled = True
        Timer1.Enabled = True
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If demarre = False Then

            If lblchange.Text = "True" Then
                PictureBox1.Image = Devoir3.My.Resources.Resources.tonnerre1
                lblchange.Text = "False"
            Else
                PictureBox1.Image = Devoir3.My.Resources.Resources.nuage0
                lblchange.Text = "True"

            End If
        Else
            If enteindreEnFeul = False Then
                btmPompiers.Enabled = True
                PictureBox1.Image = Devoir3.My.Resources.Resources.nuage0
                PictureBox2.Image = Devoir3.My.Resources.Resources.arbres_danse
                PictureBox2.Size = New Size(155, hauteur)
                PictureBox3.Visible = True
            End If
            End If

    End Sub


    Private Sub frmEx04_Mod2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        demarre = False
        hauteur = eteindre
        enteindreEnFeul = False
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        demarre = True
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btmPompiers_Click(sender As System.Object, e As System.EventArgs) Handles btmPompiers.Click
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        Timer3.Enabled = True

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        eteindre -= 4
        'PictureBox2.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y - 5)
        PictureBox2.Size = New Size(PictureBox2.Size.Width, PictureBox2.Size.Height + 1)
        PictureBox3.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y + 3)
        PictureBox3.Size = New Size(155, eteindre)
        If eteindre <= 0 Then
            Timer3.Enabled = False
            'demarre = False

            hauteur = PictureBox2.Size.Height
            PictureBox2.Image = Devoir3.My.Resources.Resources.bmparbre
            PictureBox2.Size = New Size(155, 126)
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            btmPompiers.Enabled = False
            'Timer3.Enabled = False
            enteindreEnFeul = True
            btmEclair.Enabled = True


        End If
    End Sub
End Class