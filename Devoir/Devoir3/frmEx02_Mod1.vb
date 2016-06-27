Public Class frmEx02_Mod1

    Private Sub btnBonjour_Click(sender As System.Object, e As System.EventArgs) Handles btnBonjour.Click

        If TextBox1.Text = "" Then
            MsgBox("Entre votre nom")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Entre votre prenom")
        Else
            lblMessage.Text = "Bonjour " & TextBox1.Text & " " & TextBox2.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class