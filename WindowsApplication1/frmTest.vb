'Imports prjEmploye

'Public Class frmTest
'    Dim WithEvents emp As Employe 'pointeur sur un Employe à Nothing
'    '(New n'a pas été fait donc pas d'instance)
'    Dim colEmployes As New ArrayList


'    Private Sub btmCreer_Click(sender As System.Object, e As System.EventArgs) Handles btmCreer.Click
'        Try
'            emp = New Employe(txtNom.Text, txtNAS.Text, CDbl(txtTaux.Text))
'            lstEmployes.Items.Add(emp.Nom & " : " & emp.Salaire)
'            colEmployes.Add(emp)
'            txtNom.Text = ""
'            txtNAS.Text = ""
'            txtTaux.Text = ""
'            txtNom.Focus()
'        Catch ex As InvalidCastException
'            MsgBox("Entrez une valeur numérique" & vbCrLf & ex.Message)
'            txtTaux.Text = ""
'            txtTaux.Focus()
'        Catch ex As ExploitationException
'            MsgBox("Le salaire est trop bas. " & vbCrLf & ex.Message)
'            txtTaux.Focus()
'        Catch ex As Exception 'autre exception
'            MsgBox(ex.Message)
'        End Try
'        lblNbEmployes.Text = "Nombre d'employés: " & Employe.NombreEmployes

'        'txtNom.Text = ""
'        'txtNAS.Text = ""
'        'txtTaux.Text = ""
'        'txtNom.Focus()

'    End Sub

'    'Private Sub btmRetirer_Click(sender As System.Object, e As System.EventArgs) Handles btmRetirer.Click
'    '    lstEmployes.Items.RemoveAt(lstEmployes.SelectedIndex)
'    '    emp = Nothing
'    '    System.GC.Collect()
'    '    lblNbEmployes.Text = "Nombre d'employés: " & Employe.NombreEmployes
'    '    Me.Refresh()

'    'End Sub

'    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
'        lstSalaire.Items.Clear()
'        For Each emp As Employe In colEmployes
'            'on parcout la collection des employés de la liste
'            Dim valeur As String
'            valeur = InputBox("entrez le nombre d'heures travaillées par " & emp.Nom)
'            If IsNumeric(valeur) Then
'                lstSalaire.Items.Add(emp.Nom & " : " & emp.CalculerSalaire(CDbl(valeur)) & "$")
'            Else
'                lstSalaire.Items.Add(emp.Nom & " : " & emp.CalculerSalaire() & " $")
'            End If

'        Next
'    End Sub

'    Private Sub txtTaux_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTaux.TextChanged

'    End Sub

'    Private Sub emp_BurnOut() Handles emp.BurnOut
'        MessageBox.Show("L'employe va faire un burn-out", "Attention", _
'                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'    End Sub
'End Class
