Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb


Public Class calculer_paiement_direct
    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim lbl17 As String
    Dim lbl19 As String
    Dim lbl20 As String
    Dim lbl21 As String
    Dim lbl36 As String

    Function start_direct(ByVal message As String) As String
        proc_J()
        proc_K()
        proc_L()
        proc_O()
        proc_O5()

        Dim phrase As String

        phrase = "?" + lbl17 + "?" + lbl19 + "?" + lbl20 + "?" + lbl21 + "?" + lbl36

        message = message + phrase

        Return message

    End Function

    Sub proc_J()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl17 = myReader1.Item(0).ToString


        End While

        myConnection.Close()


    End Sub

    Sub proc_K()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl19 = myReader1.Item(0).ToString
        End While

        myConnection.Close()


    End Sub

    Sub proc_L()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl20 = myReader1.Item(0).ToString
        End While
        myConnection.Close()


    End Sub

    Sub proc_O()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl21 = myReader1.Item(0).ToString
        End While
        myConnection.Close()


    End Sub

    Sub proc_O5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            lbl36 = myReader1.Item(0).ToString
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
