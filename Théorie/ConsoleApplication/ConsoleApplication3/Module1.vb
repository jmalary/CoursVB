Imports System.windows.forms
Module Module1

    Sub Main()
        Dim rep As DialogResult

        MessageBox.Show("texte du message", "titre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, _
                        MessageBoxDefaultButton.Button2)


        If rep = DialogResult.Yes Then
            MessageBox.Show("Vous avez répondu oui")
        ElseIf rep = DialogResult.No Then
            MessageBox.Show("Vous avez répondu non")

        End If

    End Sub

    Dim val As String = InputBox("question", "titre", "150")



End Module
