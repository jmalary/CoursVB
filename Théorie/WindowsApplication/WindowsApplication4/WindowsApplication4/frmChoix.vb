Public Class frmChoix

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkItalique.CheckedChanged

        Dim a As System.Drawing.FontStyle
        If (Label1.Font.Style And FontStyle.Italic) = 0 Then
            a = Label1.Font.Style Or FontStyle.Italic
        Else
            a = Label1.Font.Style And (Not FontStyle.Italic)
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, a)

    End Sub

    Private Sub chkGras_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGras.CheckedChanged
        Dim a As System.Drawing.FontStyle
        If (Label1.Font.Style And FontStyle.Bold) = 0 Then
            a = Label1.Font.Style Or FontStyle.Bold
        Else
            a = Label1.Font.Style And (Not FontStyle.Bold)
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, a)
    End Sub

    Private Sub chkUnderline_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUnderline.CheckedChanged
        Dim a As System.Drawing.FontStyle
        If (Label1.Font.Style And FontStyle.Underline) = 0 Then
            a = Label1.Font.Style Or FontStyle.Underline
        Else
            a = Label1.Font.Style And (Not FontStyle.Underline)
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, a)

    End Sub

    Private Sub chkStrikeOut_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkStrikeOut.CheckedChanged
        Dim a As System.Drawing.FontStyle
        If (Label1.Font.Style And FontStyle.Strikeout) = 0 Then
            a = Label1.Font.Style Or FontStyle.Strikeout
        Else
            a = Label1.Font.Style And (Not FontStyle.Strikeout)
        End If
        Label1.Font = New Font(Label1.Font.Name, Label1.Font.Size, a)

    End Sub

    Private Sub rb8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb8.CheckedChanged, rb12.CheckedChanged, rb24.CheckedChanged, rb10.CheckedChanged
        If CType(sender, RadioButton).Text <> "" Then
            Label1.Font = New Font(Label1.Font.Name, CSng(CType(sender, RadioButton).Text), Label1.Font.Style)
        End If

    End Sub


    Private Sub rbArial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbArial.CheckedChanged, rbCourier.CheckedChanged

        Label1.Font = New Font(CType(sender, RadioButton).Text, _
                            Label1.Font.Size, Label1.Font.Style)

    End Sub
End Class