Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb


Public Class calculer_cheque
    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim lbl29 As String
    Dim lbl28 As String
    Dim lbl27 As String
    Dim lbl26 As String
    Dim lbl41 As String

    Function start_cheque(ByVal message As String) As String

        proc_R()
        proc_S()
        proc_T()
        proc_U()
        proc_U5()


        Dim phrase As String

        phrase = "?" + lbl29 + "?" + lbl28 + "?" + lbl27 + "?" + lbl26 + "?" + lbl41

        message = message + phrase

        Return message

    End Function

    Sub proc_R()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl29 = myReader1.Item(0).ToString


        End While

        myConnection.Close()

    End Sub

    Sub proc_S()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl28 = myReader1.Item(0).ToString
        End While

    End Sub

    Sub proc_T()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl27 = myReader1.Item(0).ToString
        End While
        myConnection.Close()


    End Sub

    Sub proc_U()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl26 = myReader1.Item(0).ToString
        End While
        myConnection.Close()


    End Sub


    Sub proc_U5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl41 = myReader1.Item(0).ToString
        End While
        myConnection.Close()


    End Sub

End Class
