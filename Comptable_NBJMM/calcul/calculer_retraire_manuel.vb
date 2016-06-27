Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb



Public Class calculer_retraire_manuel
    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim txt18 As String
    Dim txt17 As String
    Dim txt16 As String
    Dim txt15 As String
    Dim txt21 As String

    Function start_retraire(ByVal message As String) As String
        proc_F()
        proc_G()
        proc_H()
        proc_I()
        proc_I5()

        Dim phrase As String

        phrase = "?" + txt18 + "?" + txt17 + "?" + txt16 + "?" + txt15 + "?" + txt21

        'Dim message As String = proc_recuperer(numero)
        ' MsgBox(message)

        message = message + phrase

        Return message



    End Function

    Sub proc_F()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt18 = myReader1.Item(0).ToString


        End While

        myConnection.Close()

    End Sub

    Sub proc_G()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt17 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub

    Sub proc_H()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt16 = myReader1.Item(0).ToString


        End While

        myConnection.Close()

    End Sub

    Sub proc_I()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt15 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub

    Sub proc_I5()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt21 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub


End Class
