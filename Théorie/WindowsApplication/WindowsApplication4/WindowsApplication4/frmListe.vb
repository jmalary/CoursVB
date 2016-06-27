Public Class frmListe

    Private Sub lstTaille_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstTaille.SelectedIndexChanged
        Label1.Font = New Font(Label1.Font.Name, CSng(lstTaille.SelectedItem), _
                               Label1.Font.Style)
    End Sub

    Private Sub frmListe_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        lstTaille.SelectedIndex = 1 'le deuxieme élément (10)
        cboNom.SelectedIndex = 1 'deuxième élément (MS Sans Serif)
    End Sub

    Private Sub cboNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboNom.SelectedIndexChanged
        Label1.Font = New Font(cboNom.SelectedItem.ToString, _
                                Label1.Font.Size, Label1.Font.Style)
    End Sub

    Private Sub btnAjouter_Click(sender As System.Object, e As System.EventArgs) Handles btnAjouter.Click
        'vérifier le contenu de la zone est déjà dans la liste
        If cboNom.Items.Contains(cboNom.Text) Then
            MessageBox.Show("Cette police existe déjà", "Attention", _
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            cboNom.Items.Add(cboNom.Text)
            cboNom.Text = "" 'ou cboNom.text = String.Empty
        End If
    End Sub

    Private Sub btnTransfert_Click(sender As System.Object, e As System.EventArgs) Handles btnTransfert.Click
        For i As Integer = ListBox1.SelectedIndices.Count - 1 To 0 Step -1
            ListBox2.Items.Add(ListBox1.SelectedItem(i))
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndices.Item(i))

        Next

    End Sub

    Private Sub btnTout_Click(sender As System.Object, e As System.EventArgs) Handles btnTout.Click
        'transférer les éléments de la première liste à la deuxième
        For Each nom As String In ListBox1.Items
            ListBox2.Items.Add(nom)
        Next
        'vider la première liste
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class