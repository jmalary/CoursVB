

Public Class frmEx05_Mod2

    Public imgCoueur() As PictureBox 'tableau de pointeurs sur des "Image" 
    Public vitesse As Integer


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btmGO.Click

        If btmGO.Text = "Go" Then
            btmGO.Text = "Stop"
            TmrCourse.Enabled = True
            debuterAnimation()
        Else
            btmGO.Text = "Go"
            TmrCourse.Enabled = False
            arreterAnimation()
           
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles TmrCourse.Tick
        Dim no As Integer 'numéro de l'étiquette qui va avancer d'un pas
        Dim jet As Random = New Random

        'version sans tableau
        no = jet.Next(1, 5) 'choix aléatoire entre 1 et 4
        Select Case no
            Case 1
                PictureBox1.Location = New Point(PictureBox1.Location.X + 10, _
                                            PictureBox1.Location.Y)

                If PictureBox1.Location.X + PictureBox1.Width >= linArrive.X1 Then
                    TmrCourse.Enabled = False 'On arrête la course(Timer)
                    arreterAnimation()
                    MessageBox.Show("Le coureur A est gagnant")
                    'btmRecommencer.Enabled = True
                    TmrCourse.Enabled = False
                    FinishAnimation()
                End If
            Case 2
                PictureBox2.Location = New Point(PictureBox2.Location.X + 10, _
                                            PictureBox2.Location.Y)

                If PictureBox2.Location.X + PictureBox2.Width >= linArrive.X1 Then
                    TmrCourse.Enabled = False 'On arrête la course(Timer)
                    arreterAnimation()
                    MessageBox.Show("Le coureur b est gagnant")
                    'btmRecommencer.Enabled = True
                    TmrCourse.Enabled = False

                    FinishAnimation()
                End If
            Case 3
                PictureBox3.Location = New Point(PictureBox3.Location.X + 10, _
                                            PictureBox3.Location.Y)

                If PictureBox3.Location.X + PictureBox3.Width >= linArrive.X1 Then
                    TmrCourse.Enabled = False 'On arrête la course(Timer)
                    arreterAnimation()
                    MessageBox.Show("Le coureur c est gagnant")
                    TmrCourse.Enabled = False
                    'btmRecommencer.Enabled = True

                    FinishAnimation()
                End If
            Case 4
                PictureBox4.Location = New Point(PictureBox4.Location.X + 10, _
                                            PictureBox4.Location.Y)

                If PictureBox4.Location.X + PictureBox4.Width >= linArrive.X1 Then
                    TmrCourse.Enabled = False 'On arrête la course(Timer)
                    arreterAnimation()
                    MessageBox.Show("Le coureur D est gagnant")
                    TmrCourse.Enabled = False
                    'btmRecommencer.Enabled = True

                    FinishAnimation()
                End If
        End Select


    End Sub


    Private Sub frmEx05_Mod2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        imgCoueur = New PictureBox(4) {}

        imgCoueur(0) = PictureBox1
        imgCoueur(1) = PictureBox2
        imgCoueur(2) = PictureBox3
        imgCoueur(3) = PictureBox4


    End Sub


    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs)
        vitesse = TrackBar1.Value
        TmrCourse.Interval = vitesse
    End Sub

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        Me.Close()
    End Sub

    Sub arreterAnimation()
        PictureBox1.Image = Devoir3.My.Resources.Resources.chiensFix
        PictureBox2.Image = Devoir3.My.Resources.Resources.chatFix
        PictureBox3.Image = Devoir3.My.Resources.Resources.sourisFix
        PictureBox4.Image = Devoir3.My.Resources.Resources.elephantFix


    End Sub


    Sub FinishAnimation()
        PictureBox1.Location = New Point(0, PictureBox1.Location.Y)
        PictureBox2.Location = New Point(0, PictureBox2.Location.Y)
        PictureBox3.Location = New Point(0, PictureBox3.Location.Y)
        PictureBox4.Location = New Point(0, PictureBox4.Location.Y)

        btmGO.Text = "Go"

    End Sub







    Sub debuterAnimation()
        PictureBox1.Image = Devoir3.My.Resources.Resources.chiens02
        PictureBox2.Image = Devoir3.My.Resources.Resources.chat
        PictureBox3.Image = Devoir3.My.Resources.Resources.souris
        PictureBox4.Image = Devoir3.My.Resources.Resources.elephant

    End Sub

    Private Sub TrackBar1_Scroll_1(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        TmrCourse.Interval = TrackBar1.Value
    End Sub
End Class