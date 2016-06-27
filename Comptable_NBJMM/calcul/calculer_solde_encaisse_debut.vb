Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb


Public Class vb_calculer_solde_encaisse_debut

    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim txt1 As String

    Function start_apport() As String

        proc_A()

        Dim phrase As String

        phrase = txt1 + "?"

        Return phrase


    End Function

    Sub proc_A()


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Solde_encaisses_debut where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt1 = myReader1.Item(0).ToString
            'TextBox1.Text = myReader1.Item(0).ToString
            'TextBox1.Text = FormatCurrency(myReader1.Item(0).ToString)


        End While

        myConnection.Close()

    End Sub


End Class
