Public Class frmEx06_Mod1

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged
        reinitialiser()

        If RadioButton1.Checked = True Then
            Button1.Enabled = False
            lblMessage.ForeColor = Color.Red
        ElseIf RadioButton2.Checked = True Then
            Button2.Enabled = False
            lblMessage.ForeColor = Color.Green
        ElseIf RadioButton3.Checked = True Then
            Button3.Enabled = False
            lblMessage.ForeColor = Color.Blue
        ElseIf RadioButton4.Checked = True Then
            Button4.Enabled = False
            lblMessage.ForeColor = Color.White
        ElseIf RadioButton3.Checked = True Then
            Button5.Enabled = False
            lblMessage.ForeColor = Color.Black
        End If
    End Sub


    Sub reinitialiser()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True

    End Sub
    
    Private Sub btmFerme_Click(sender As System.Object, e As System.EventArgs) Handles btmFerme.Click
        Me.Close()
    End Sub
End Class