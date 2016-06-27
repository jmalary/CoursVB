Public Class frmEx01_Mod2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For i As Integer = ListBox1.SelectedIndices.Count - 1 To 0 Step -1
            ListBox2.Items.Add(ListBox1.SelectedItem) 'ou: .add( ListBox1.SelectedItems(i)) si MultiSelect
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndices.Item(i))

        Next

        If ListBox1.Items.Count = 0 Then
            Button2.Enabled = False
        End If
        Button4.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'transférer les éléments de la première liste à la deuxième
        For Each nom As String In ListBox1.Items
            ListBox2.Items.Add(nom)
        Next
        'vider la première liste
        ListBox1.Items.Clear()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        For i As Integer = ListBox2.SelectedIndices.Count - 1 To 0 Step -1
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndices.Item(i))

        Next
        If ListBox1.Items.Count = 0 Then
            Button4.Enabled = False
        End If
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'transférer les éléments de la première liste à la deuxième
        For Each nom As String In ListBox2.Items
            ListBox1.Items.Add(nom)
        Next
        'vider la première liste
        ListBox2.Items.Clear()
        Button4.Enabled = False


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Button3.Enabled = True
    End Sub
End Class