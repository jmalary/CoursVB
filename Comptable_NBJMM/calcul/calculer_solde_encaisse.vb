Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb


Public Class calculer_solde_encaisse

    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim lbl68 As String
    Dim lbl67 As String
    Dim lbl66 As String
    Dim lbl65 As String
    Dim lbl42 As String

    Function start_solde_encaisse(ByVal message As String) As String

        proc_AA()

        Dim phrase As String

        phrase = "?" + lbl68 + "?" + lbl67 + "?" + lbl66 + "?" + lbl65 + "?" + lbl42

        message = message + phrase

        Return message

    End Function

    Sub proc_AA()

        'Dim nbr1 As Double
        'Dim nbr2 As Double
        'Dim nbr3 As Double
        'Dim nbr4 As Double
        'Dim nbr5 As Double
        'Dim nbr6 As Double
        'Dim nbr7 As Double

        'Dim c As Double

        ''nbr1 = TextBox1.Text
        'nbr2 = TextBox12.Text
        'nbr3 = TextBox18.Text
        'nbr4 = Label17.Text
        'nbr5 = Label25.Text
        'nbr6 = Label29.Text
        'nbr7 = TextBox72.Text




        'c = nbr1 + nbr2 - nbr3 - nbr4 - nbr5 - nbr6 - nbr7

        'Label68.Text = Format$(c, "Currency")

        ''********************************************************************************

        'Dim S, s2 As String
        'S = Label68.Text
        'Dim answer As Char
        'answer = S.Substring(0, 1)
        'If answer = "(" Then

        '    s2 = S.Substring(0, S.Length - 1)

        '    Label68.Text = s2.Replace(CChar("("), CChar("-"))

        'Else
        '    'MsgBox("Positif")
        'End If

        '******************************************************************************************

    End Sub

End Class
