'Imports prjPatron
'Imports prjEmploye

'Public Class frmHeritage
'    Friend unGars As Employe
'    Friend bigBoss As Patron
'    'Remarque: les classes ne sont pas instanciées,
'    'on n'a que les pointeurs = Nothing

'    Private Sub btmCréer_Click(sender As System.Object, e As System.EventArgs) Handles btmCréer.Click
'        Try
'            If rbEmploye.Checked = True Then
'                unGars = New Employe(txtNom.Text, txtNAS.Text, CDbl(txtSalaire.Text))
'            ElseIf rbPatron.Checked = True Then
'                bigBoss = New Patron(txtNom.Text, txtNAS.Text, CDbl(txtSalaire.Text), CDbl(txtNbHeure.Text))
'            Else
'                unGars = New Patron(txtNom.Text, txtNAS.Text, CDbl(txtSalaire.Text), CDbl(txtNbHeure.Text))
'            End If
'            panCree.Enabled = False
'            panMethodes.Enabled = True
'            btmDetruire.Enabled = True
'        Catch ex As InvalidCastException
'            MessageBox.Show("valeur non numérique " & ex.Message)
'            txtSalaire.Text = ""
'            txtSalaire.Focus()
'        Catch ex As ExploitationException
'            MessageBox.Show(ex.Message)
'            txtSalaire.Focus()
'        End Try

'    End Sub


'    Private Sub btVacances_Click(sender As System.Object, e As System.EventArgs) Handles btVacances.Click
'        If Not unGars Is Nothing Then
'            unGars.prendreVacances()
'        Else
'            bigBoss.prendreVacances()
'        End If
'    End Sub

'    Private Sub btmCalculer_Click(sender As Object, e As System.EventArgs) Handles btmCalculer.Click
'        'on devrait ajouter un Try - Catch 
'        If Not unGars Is Nothing Then
'            MessageBox.Show("Salaire = " & unGars.CalculerSalaire(CDbl(txtNbHeure.Text)))
'        Else
'            MessageBox.Show("Salaire = " & bigBoss.CalculerSalaire(CDbl(txtNbHeure.Text)))
'        End If
'    End Sub

'    Private Sub btmAugmenter_Click(sender As Object, e As System.EventArgs) Handles btmAugmenter.Click
'        If Not unGars Is Nothing Then
'            unGars.augmenterSalaire()
'        Else
'            bigBoss.augmenterSalaire()
'        End If
'    End Sub

'    Private Sub btmDetruire_Click(sender As Object, e As System.EventArgs) Handles btmDetruire.Click
'        If Not unGars Is Nothing Then
'            unGars = Nothing
'        Else
'            bigBoss = Nothing
'        End If
'        GC.Collect() 'déclenche le " garbage collector"
'        panCree.Enabled = True
'        panMethodes.Enabled = False
'        btmDetruire.Enabled = False

'    End Sub

'    Private Sub rbPatron_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPatron.CheckedChanged, rbEmploye.CheckedChanged, rbEmpPat.CheckedChanged
'        Dim rb As RadioButton = CType(sender, RadioButton)

'        If rb.Name <> "rbEmploye" And rb.Checked = True Then
'            lblSalaire.Text = "taux de rendement"
'            lblNbHeure.Text = "chiffre d'affaire"
'        Else
'            lblSalaire.Text = "salaire"
'            lblNbHeure.Text = "nombre d'heures"
'        End If
'    End Sub

'    Private Sub frmHeritage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

'    End Sub
'End Class
