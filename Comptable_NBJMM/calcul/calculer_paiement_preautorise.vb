Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb

Public Class calculer_paiement_preautorise

    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim lbl25 As String
    Dim lbl24 As String
    Dim lbl23 As String
    Dim lbl22 As String
    Dim lbl37 As String

    Function start_preautoriser(ByVal message As String) As String

        proc_M()
        proc_N()
        proc_P()
        proc_Q()
        proc_Q5()

        Dim phrase As String

        phrase = "?" + lbl25 + "?" + lbl24 + "?" + lbl23 + "?" + lbl22 + "?" + lbl37

        message = message + phrase

        Return message

    End Function

    Sub proc_M()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl25 = myReader1.Item(0).ToString


        End While
        myConnection.Close()

    End Sub

    Sub proc_N()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl24 = myReader1.Item(0).ToString
        End While
        myConnection.Close()

    End Sub

    Sub proc_P()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl23 = myReader1.Item(0).ToString
        End While

        myConnection.Close()

    End Sub

    Sub proc_Q()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl22 = myReader1.Item(0).ToString
        End While

        myConnection.Close()

    End Sub

    Sub proc_Q5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl37 = myReader1.Item(0).ToString
        End While

        myConnection.Close()

    End Sub

    'Function proc_recuperer(ByVal numero As Integer) As String
    '    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    '    myConnection.Open()


    '    Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM listerDate where numero = " & numero & "", myConnection)
    '    Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

    '    Dim msg As String

    '    While myReader.Read
    '        'Dim newListViewItem As New ListViewItem

    '        msg = myReader.GetString(3)

    '    End While

    '    Return msg



    'End Function



End Class
