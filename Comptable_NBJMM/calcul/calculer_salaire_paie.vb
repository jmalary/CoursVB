Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb


Public Class calculer_salaire_paie

    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim txt72 As String
    Dim txt71 As String
    Dim txt70 As String
    Dim txt69 As String
    Dim txt22 As String

    Function start_salaire_paie(ByVal message As String) As String

        proc_V()
        proc_W()
        proc_X()
        proc_Y()
        proc_Y5()

        Dim phrase As String

        phrase = "?" + txt72 + "?" + txt71 + "?" + txt70 + "?" + txt69 + "?" + txt22

        message = message + phrase

        Return message

    End Function

    Sub proc_V()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt72 = myReader1.Item(0).ToString


        End While
        myConnection.Close()


    End Sub

    Sub proc_W()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt71 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub

    Sub proc_X()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt70 = myReader1.Item(0).ToString


        End While
        myConnection.Close()


    End Sub

    Sub proc_Y()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt69 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub

    Sub proc_Y5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt22 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub




End Class
