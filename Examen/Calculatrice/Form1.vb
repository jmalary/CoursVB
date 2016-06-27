Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblOp.Text = "+"
        txtA.Text = 0
        txtB.Text = 0
        txtA.Focus()
        lblResultat.Text = "0"

        comboOperation.SelectedIndex = 0 'premiere élement ( Arial)
    End Sub

  


    Private Sub comboOperation_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboOperation.SelectedIndexChanged

        Dim op As String
        Dim selection As Integer
        selection = comboOperation.SelectedIndex
        op = ""

        Select Case selection
            Case 0 : op = "+"
            Case 1 : op = "-"
            Case 2 : op = "X"
            Case 3 : op = "Mod"

        End Select

        lblOp.Text = op.ToString

        calculer()
        txtA.Focus()
    End Sub

    Private Sub btnCalculer_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculer.Click

        calculer()

    End Sub

    Sub calculer()
        Dim op As String
        Dim resultat As Integer

        op = lblOp.Text

        Select Case op
            Case "+" : resultat = CInt(txtA.Text) + CInt(txtB.Text)
            Case "-" : resultat = CInt(txtA.Text) - CInt(txtB.Text)
            Case "X" : resultat = CInt(txtA.Text) * CInt(txtB.Text)
            Case "Mod" : resultat = CInt(txtA.Text) Mod CInt(txtB.Text)

        End Select

        lblResultat.Text = resultat.ToString
    End Sub

    Private Sub btmFermer_Click(sender As System.Object, e As System.EventArgs) Handles btmFermer.Click
        quitter()
    End Sub

    Sub quitter()
        End
    End Sub

    Private Sub txtA_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtA.TextChanged



        If IsNumeric(txtA.Text) Then
            btnCalculer.Enabled = True
        Else
            btnCalculer.Enabled = False
        End If
    End Sub

    Private Sub txtB_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtB.TextChanged

        If IsNumeric(txtB.Text) Then
            btnCalculer.Enabled = True
        Else
            btnCalculer.Enabled = False
        End If
    End Sub
End Class
