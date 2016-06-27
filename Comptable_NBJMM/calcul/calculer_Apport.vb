Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb


Public Class calculer_Apport
    Dim myConnString As String = GlobalVariables.User_Access

    Dim myConnection As New OleDb.OleDbConnection(myConnString)
    Dim con As System.Data.OleDb.OleDbConnection
    Dim sqlStr As String
    Dim cmd As System.Data.OleDb.OleDbCommand


    Dim txt12 As String
    Dim txt11 As String
    Dim txt10 As String
    Dim txt9 As String
    Dim txt20 As String

    Function start_apport() As String
        proc_B()
        proc_C()
        proc_D()
        proc_E()
        proc_E5()

        Dim phrase As String

        phrase = txt12 + "?" + txt11 + "?" + txt10 + "?" + txt9 + "?" + txt20

        Return phrase


    End Function

    Sub proc_B()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt12 = myReader1.Item(0).ToString



        End While
        myConnection.Close()


    End Sub

    Sub proc_C()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read


            txt11 = myReader1.Item(0).ToString
            'TextBox11.Text = myReader1.Item(0).ToString



        End While

        myConnection.Close()


    End Sub

    Sub proc_D()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt10 = myReader1.Item(0).ToString


        End While
        myConnection.Close()


    End Sub

    Sub proc_E()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt9 = myReader1.Item(0).ToString


        End While

        myConnection.Close()

    End Sub

    Sub proc_E5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            txt20 = myReader1.Item(0).ToString


        End While

        myConnection.Close()

    End Sub

    Function test() As Integer
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM listerDate", myConnection)
        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

        Dim nombre As Integer

        While myReader.Read
            Dim newListViewItem As New ListViewItem

            nombre = myReader.GetInt32(0)
            'MsgBox(nombre)

            'newListViewItem.SubItems.Add(myReader.GetInt32(4))

        End While

        'MsgBox(CInt(nombre))

        myConnection.Close()

        Return nombre

    End Function

End Class
