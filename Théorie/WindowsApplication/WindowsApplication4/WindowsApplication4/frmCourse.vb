Public Class frmCourse

    Public lblCoueur() As Label 'tableau de pointeurs sur des "Label" 


    Private Sub btmDepart_Click(sender As System.Object, e As System.EventArgs) Handles btmDepart.Click
        TmrCourse.Enabled = True
        btmDepart.Enabled = False
    End Sub

    Private Sub TmrCourse_Tick(sender As System.Object, e As System.EventArgs) Handles TmrCourse.Tick
        Dim no As Integer 'numéro de l'étiquette qui va avancer d'un pas
        Dim jet As Random = New Random

        'version sans tableau
        'no = jet.Next(1, 5) 'choix aléatoire entre 1 et 4
        'Select Case no
        '    Case 1
        '        Label1.Location = New Point(Label1.Location.X + 10, _
        '                                    Label1.Location.Y)

        '        If Label1.Location.X + Label1.Width >= linArrive.X1 Then
        '            TmrCourse.Enabled = False 'On arrête la course(Timer)
        '            MessageBox.Show("Le coureur A est gagnant")
        '            btmRecommencer.Enabled = True
        '        End If
        '    Case 2
        '        Label2.Location = New Point(Label2.Location.X + 10, _
        '                                    Label2.Location.Y)

        '        If Label2.Location.X + Label2.Width >= linArrive.X1 Then
        '            TmrCourse.Enabled = False 'On arrête la course(Timer)
        '            MessageBox.Show("Le coureur b est gagnant")
        '            btmRecommencer.Enabled = True
        '        End If
        '    Case 3
        '        Label3.Location = New Point(Label3.Location.X + 10, _
        '                                    Label3.Location.Y)

        '        If Label3.Location.X + Label3.Width >= linArrive.X1 Then
        '            TmrCourse.Enabled = False 'On arrête la course(Timer)
        '            MessageBox.Show("Le coureur c est gagnant")
        '            btmRecommencer.Enabled = True
        '        End If
        '    Case 4
        '        Label4.Location = New Point(Label4.Location.X + 10, _
        '                                    Label4.Location.Y)

        '        If Label4.Location.X + Label4.Width >= linArrive.X1 Then
        '            TmrCourse.Enabled = False 'On arrête la course(Timer)
        '            MessageBox.Show("Le coureur D est gagnant")
        '            btmRecommencer.Enabled = True
        '        End If
        'End Select

        'version avev tableau
        no = jet.Next(0, lblCoueur.Length)
        lblCoueur(no).Location = New Point(lblCoueur(no).Location.X + 10, _
                                            lblCoueur(no).Location.Y)

        If lblCoueur(no).Location.X + lblCoueur(no).Width >= linArrive.X1 Then
            TmrCourse.Enabled = False 'On arrête la course(Timer)
            MessageBox.Show("Le coureur " & (no + 1) & " est gagnant")
            btmRecommencer.Enabled = True
        End If

    End Sub

    Private Sub btmRecommencer_Click(sender As System.Object, e As System.EventArgs) Handles btmRecommencer.Click
        'ramener les étiquettes au départ
        'version sans tableau

        'Label1.Location = New Point(12, Label1.Location.Y)
        'Label2.Location = New Point(12, Label2.Location.Y)
        'Label3.Location = New Point(12, Label3.Location.Y)
        'Label4.Location = New Point(12, Label4.Location.Y)

        'version avec tableau
        For i As Integer = 0 To lblCoueur.Length - 1
            lblCoueur(i).Location = New Point(12, lblCoueur(i).Location.Y)
        Next


        'réinitialiser les boutons
        btmDepart.Enabled = True
        btmRecommencer.Enabled = False
    End Sub

    Private Sub frmCourse_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lblCoueur = New Label(5) {}

        'lblCoueur(0) = Label1
        'lblCoueur(1) = Label2
        'lblCoueur(2) = Label3
        'lblCoueur(3) = Label4

        For i As Integer = 0 To lblCoueur.Length - 1
            lblCoueur(i) = New Label
            lblCoueur(i).Text = "#" & (i + 1)
            lblCoueur(i).BorderStyle = BorderStyle.Fixed3D
            lblCoueur(i).AutoSize = True
            lblCoueur(i).Location = New Point(12, 20 * i + 30)
            'ajouter a la collection des contrôles de la feuill
            Me.Controls.Add(lblCoueur(i))
        Next

    End Sub


    Private Sub linArrive_Click(sender As System.Object, e As System.EventArgs) Handles linArrive.Click

    End Sub
End Class