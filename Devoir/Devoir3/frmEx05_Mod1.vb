Public Class frmEx05_Mod1
    Dim total As Integer
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lblPrix_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged


        If CType(sender, CheckBox).Checked = True Then
            CheckBox1.Checked = False
            total += CInt(CType(sender, CheckBox).Tag)
        Else
            total -= CInt(CType(sender, CheckBox).Tag)
        End If
        Label3.Text = "Prix total : " & total & " DH"

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            total = 50000
        End If
        Label3.Text = "Prix total : " & total & " DH"
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class