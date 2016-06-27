Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb

Public Class frmGestion

    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlStr As String
    Dim myConnString As String = GlobalVariables.User_Access
    Dim AL As New Collection
    Dim somme_solde_enc As Double
    Dim num_temporaire As String

    Private Property OleDbDataReader As OleDbDataReader

    Private Sub frmGestion_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows

        frmMenu.Show()

    End Sub




    Private Sub frmGestion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub




    Private Sub frmGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        proc_ListerText()



        'Dim dLastSunday As Date = Now.AddDays(-(Now.DayOfWeek - 6))
        Dim currentDate As DateTime
        currentDate = Now.Date
        currentDate = currentDate.AddDays(6)
        ' MsgBox(currentDate)

        'MsgBox(dLastSunday)


        ' ******************************************************
        ' Solde Encaisse début
        '-********************************************************
        
        proc_tout()



        proc_restaurantion()



    End Sub

    Sub proc_ListerText()
        AL.Add(TextBox1)

    End Sub


    Sub proc_tout()

        proc_A()

        'proc_AC()
        'proc_AD()

        ' ******************************************************
        ' Apports
        '-********************************************************


        proc_B()
        proc_C()
        proc_D()
        proc_E()
        proc_E5()

        ' ******************************************************
        ' RETRAIRE MANUEL
        '-********************************************************

        proc_F()
        proc_G()
        proc_H()
        proc_I()
        proc_I5()

        ' ******************************************************
        'Cheque Direct
        '-********************************************************
        proc_J()
        proc_K()
        proc_L()
        proc_O()
        proc_O5()

        '' ******************************************************
        '' Cheque Preautorise
        ''-********************************************************
        proc_M()
        proc_N()
        proc_P()
        proc_Q()
        proc_Q5()

        '' ******************************************************
        '' Cheque Circulation
        ''-********************************************************
        proc_R()
        proc_S()
        proc_T()
        proc_U()
        proc_U5()


        '' ******************************************************
        '' Salaire paie courant
        ' ''-********************************************************
        proc_V()
        proc_W()
        proc_X()
        proc_Y()
        proc_Y5()

        '' ******************************************************
        '' Solde encaisse
        ''-********************************************************
        proc_AA()
        'proc_AB()
        'proc_AC()
        'proc_AD()

        '' ******************************************************
        '' Aregent à recevoir
        ''-********************************************************
        proc_BA()
        proc_BB()
        proc_BC()
        proc_BD()
        proc_BD5()


        '' ******************************************************
        '' Solde encaisse avant M/C
        ''-********************************************************

        proc_CA()
        proc_CB()
        proc_CC()
        'proc_CD()


        '' ******************************************************
        '' Marge de crédit utilisée
        ''-********************************************************
        proc_DA()
        proc_DAA()


        '' ******************************************************
        '' Besoin d'emprunt à CT
        ''-********************************************************

        proc_EA()
        proc_E25_1()
        proc_E25()


        proc_F25()




        '' ******************************************************
        '' Encaisse minimum requised
        ''-********************************************************

        proc_enc_min_req1()
        proc_enc_min_req2()
        proc_enc_min_req3()
        proc_enc_min_req4()
        proc_enc_min_req45()



        '' ******************************************************
        '' Marge de crédit disponible
        ''-********************************************************


        proc_marge_credit_disp_req1()
        proc_marge_credit_disp_req2()
        proc_marge_credit_disp_req3()




        '' ******************************************************
        '' Besoin d'emprunt à CT
        ''-********************************************************


        proc_besoin_emp_req1()
        'proc_besoin_emp_req2()
        'proc_besoin_emp_req3()
        proc_besoin_emp_req4()




        '' ******************************************************
        '' Solde encaisse début (DEUXIENE)
        ''-********************************************************

        proc_solde_enc_req1()
        proc_besoin_emp_req2()
        proc_solde_enc_req2()
        proc_besoin_emp_req3()

        proc_solde_enc_req3()
        proc_solde_enc_req35()


        '' ******************************************************
        '' Solde encaisse début
        ''-********************************************************


        proc_solde_enc_req1()

        ElementPlusMax()



    End Sub

    Sub proc_A()


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Solde_encaisses_debut where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox1.Text = Format$(myReader1.Item(0).ToString, "Currency")
            'TextBox1.Text = myReader1.Item(0).ToString
            'TextBox1.Text = FormatCurrency(myReader1.Item(0).ToString)


        End While

        myConnection.Close()

    End Sub

    Sub proc_A1()


        Dim num1 As Double
        Dim num2 As Double
        Dim SOMME As Double



        Label14.Text = Format$(Label60.Text, "Currency")

        'num1 = Label60.Text
        'num2 = Label32.Text

        'SOMME = num1 + num2

        'Label14.Text = Format$(SOMME, "Currency")

        proc_AB()

    End Sub

    ' ******************************************************
    ' Apports
    '-********************************************************
    Sub proc_B()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox12.Text = Format$(myReader1.Item(0).ToString, "Currency")
            'TextBox12.Text = myReader1.Item(0).ToString


        End While
        myConnection.Close()


    End Sub

    Sub proc_C()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read


            TextBox11.Text = Format$(myReader1.Item(0).ToString, "Currency")
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
            TextBox10.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While
        myConnection.Close()


    End Sub

    Sub proc_E()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox9.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()

    End Sub

    Sub proc_E5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Apports where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox20.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()

    End Sub


    ' ******************************************************
    ' RETRAIRE MANUEL
    '-********************************************************

    Sub proc_F()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox18.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()

    End Sub

    Sub proc_G()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox17.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_H()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox16.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()

    End Sub

    Sub proc_I()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox15.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_I5()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Retrait_manuel where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox21.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub


    ' ******************************************************
    ' Cheque direct
    '-********************************************************
    Sub proc_J()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label17.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_K()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label19.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

        myConnection.Close()


    End Sub

    Sub proc_L()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label20.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()


    End Sub

    Sub proc_O()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label21.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()


    End Sub

    Sub proc_O5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label36.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()


    End Sub

    ' ******************************************************
    ' Cheque PREAUTORISE
    '-********************************************************
    Sub proc_M()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label25.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While
        myConnection.Close()

    End Sub

    Sub proc_N()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label24.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()

    End Sub

    Sub proc_P()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label23.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

        myConnection.Close()

    End Sub

    Sub proc_Q()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label22.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

        myConnection.Close()

    End Sub

    Sub proc_Q5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label37.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

        myConnection.Close()

    End Sub

    ' ******************************************************
    ' Cheque Circulation
    '-********************************************************
    Sub proc_R()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label29.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()

    End Sub

    Sub proc_S()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label28.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

    End Sub

    Sub proc_T()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label27.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()


    End Sub

    Sub proc_U()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label26.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()


    End Sub


    Sub proc_U5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label41.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While
        myConnection.Close()


    End Sub

    ' ******************************************************
    ' Salaire paie courant
    '-********************************************************
    Sub proc_V()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox72.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While
        myConnection.Close()


    End Sub

    Sub proc_W()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox71.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_X()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox70.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While
        myConnection.Close()


    End Sub

    Sub proc_Y()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox69.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_Y5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox22.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub


    Sub proc_AB1()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Salaires_paie_courante where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox69.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub


    ' ******************************************************
    ' Solde encaisse
    '-********************************************************

    Sub proc_AA()

        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim nbr3 As Double
        Dim nbr4 As Double
        Dim nbr5 As Double
        Dim nbr6 As Double
        Dim nbr7 As Double

        Dim c As Double

        nbr1 = TextBox1.Text
        nbr2 = TextBox12.Text
        nbr3 = TextBox18.Text
        nbr4 = Label17.Text
        nbr5 = Label25.Text
        nbr6 = Label29.Text
        nbr7 = TextBox72.Text




        c = nbr1 + nbr2 - nbr3 - nbr4 - nbr5 - nbr6 - nbr7

        Label68.Text = Format$(c, "Currency")

        '********************************************************************************

        Dim S, s2 As String
        S = Label68.Text
        Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label68.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        '******************************************************************************************

    End Sub

    Sub proc_AB()

        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim nbr3 As Double
        Dim nbr4 As Double
        Dim nbr5 As Double
        Dim nbr6 As Double
        Dim nbr7 As Double

        Dim c As Double



        nbr1 = Label14.Text
        nbr2 = TextBox11.Text
        nbr3 = TextBox17.Text
        nbr4 = Label19.Text
        nbr5 = Label24.Text
        nbr6 = Label28.Text
        nbr7 = TextBox71.Text




        c = nbr1 + nbr2 - nbr3 - nbr4 - nbr5 - nbr6 - nbr7

        'MsgBox(c)


        Label67.Text = c

        Label67.Text = Format$(c, "Currency")

        proc_CB()

        proc_AC()



    End Sub

    Sub proc_AC()

        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim nbr3 As Double
        Dim nbr4 As Double
        Dim nbr5 As Double
        Dim nbr6 As Double
        Dim nbr7 As Double

        Dim c As Double

        nbr1 = Label15.Text
        nbr2 = TextBox10.Text
        nbr3 = TextBox16.Text
        nbr4 = Label20.Text
        nbr5 = Label23.Text
        nbr6 = Label27.Text
        nbr7 = TextBox70.Text




        c = nbr1 + nbr2 - nbr3 - nbr4 - nbr5 - nbr6 - nbr7

        'MsgBox(c)

        'Label67.Text = Format$(c, "Currency")
        Label66.Text = c

        proc_CC()

    End Sub

    Sub proc_AD()

        Dim nbr1 As Double
        Dim nbr2 As Double
        Dim nbr3 As Double
        Dim nbr4 As Double
        Dim nbr5 As Double
        Dim nbr6 As Double
        Dim nbr7 As Double

        Dim c As Double

        nbr1 = Label16.Text
        'nbr1 = 0
        nbr2 = TextBox9.Text
        nbr3 = TextBox15.Text
        nbr4 = Label21.Text
        nbr5 = Label22.Text
        nbr6 = Label26.Text
        nbr7 = TextBox69.Text




        c = nbr1 + nbr2 - nbr3 - nbr4 - nbr5 - nbr6 - nbr7

        'MsgBox(c)

        'Label67.Text = Format$(c, "Currency")
        Label65.Text = c

        proc_DD()


    End Sub
    ' ******************************************************
    ' Argent à recevoir
    '-********************************************************
    Sub proc_BA()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Argent_a_recevoir where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox14.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While
        myConnection.Close()

    End Sub

    Sub proc_BB()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Argent_a_recevoir where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox13.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_BC()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Argent_a_recevoir where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox8.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_BD()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Argent_a_recevoir where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox7.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub

    Sub proc_BD5()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Argent_a_recevoir where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox23.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

        myConnection.Close()


    End Sub




    ' ******************************************************
    ' Solde encaisse avant M/C
    '-********************************************************
    Sub proc_CA()

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox14.Text
        nbrB = Label68.Text

        c1 = nbrA + nbrB
        '***********
        Label60.Text = Format$(c1, "Currency")

        Dim Sa, s2a As String
        Sa = Label60.Text
        Dim answera As Char
        answera = Sa.Substring(0, 1)
        If answera = "(" Then

            s2a = Sa.Substring(0, Sa.Length - 1)

            Label60.Text = s2a.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If


        proc_A1()




    End Sub

    Sub proc_CB()

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox13.Text
        nbrB = Label67.Text


        c1 = nbrA + nbrB


        Label59.Text = Format$(c1, "Currency")


        '********************************************************************************

        Dim Sa, s2a As String
        Sa = Label59.Text
        Dim answera As Char
        answera = Sa.Substring(0, 1)
        If answera = "(" Then

            s2a = Sa.Substring(0, Sa.Length - 1)

            Label59.Text = s2a.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        '******************************************************************************************





        Label15.Text = Format$(c1, "Currency")

        'MsgBox(Label15.Text)   'TODO

        Dim S, s2 As String
        S = Label15.Text
        Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label15.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If


        'Label15.Text = c1





    End Sub

    Sub proc_CC()

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox8.Text
        nbrB = Label66.Text


        c1 = nbrA + nbrB

        Label58.Text = c1

        Label16.Text = c1

        'MsgBox(c1)

        proc_AD()


    End Sub

    Sub proc_DD()

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox7.Text
        nbrB = Label65.Text


        c1 = nbrA + nbrB

        Label57.Text = c1



        'MsgBox(c1)



    End Sub


    ' ******************************************************
    ' Besoin d'emprunt à CT
    '-********************************************************


    Sub proc_EA()

        Dim num As Double

        num = Label60.Text



    End Sub

    Sub proc_E25()

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double


        'Label56.Text = TextBox5.Text

        nbrA = Label60.Text

        nbrB = TextBox19.Text


        c1 = nbrA + nbrB


        Label52.Text = c1

        Label52.Text = FormatCurrency(Label52.Text)
    End Sub

    Sub proc_E25_1()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from marge_credit_disponible where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox19.Text = Format$(myReader1.Item(0).ToString, "Currency")
            'TextBox1.Text = myReader1.Item(0).ToString
            'TextBox1.Text = FormatCurrency(myReader1.Item(0).ToString)


        End While




    End Sub


    Sub proc_F25()
        'Dim nbrA As Double
        'Dim nbrB As Double

        'Dim c1 As Double


        'Label56.Text = TextBox5.Text

        'nbrA = Label60.Text
        'nbrB = Label56.Text


        'c1 = nbrA + nbrB
        'Label52.Text = c1


    End Sub

    ' ******************************************************
    ' Marge de crédit utilisée
    '-********************************************************

    Sub proc_DA()


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from marge_de_credit_utilise where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox5.Text = Format$(myReader1.Item(0).ToString, "Currency")
            'TextBox1.Text = myReader1.Item(0).ToString
            'TextBox1.Text = FormatCurrency(myReader1.Item(0).ToString)


        End While


    End Sub

    Sub proc_DAA()

        Dim num As Double
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double

        num = Label60.Text
        num1 = TextBox5.Text



        If num < 0 Then ' => SI condition validée ALORS
            'Instructions si vrai
        Else ' => SINON
            'Instructions si faux
        End If



    End Sub


    ' ******************************************************
    ' Encaisse minimum requise
    '-********************************************************


    Sub proc_enc_min_req1()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select courant from Encaisse_minimum_requise where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox6.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While


    End Sub

    Sub proc_enc_min_req2()


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sept from Encaisse_minimum_requise where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox4.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

    End Sub

    Sub proc_enc_min_req3()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select quatorze from Encaisse_minimum_requise where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox3.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

    End Sub

    Sub proc_enc_min_req4()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select vingt from Encaisse_minimum_requise where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox2.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

    End Sub

    Sub proc_enc_min_req45()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select cinq from Encaisse_minimum_requise where numero = 1", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            TextBox24.Text = Format$(myReader1.Item(0).ToString, "Currency")


        End While

    End Sub


    ' ******************************************************
    'Besoin d'emprunt à CT
    '-********************************************************


    Sub proc_besoin_emp_req1()

        Dim num As Double
        Dim num1 As Double
        Dim Somme As Double


        'e23
        num = Label60.Text

        'e29
        num1 = TextBox6.Text

        If num < num1 Then
            Somme = num1 - num
        Else
            Somme = 0
        End If


        Label32.Text = Somme
        Label32.Text = FormatCurrency(Label32.Text)

    End Sub



    Sub proc_besoin_emp_req2()

        Dim num As Double
        Dim num1 As Double
        Dim Somme As Double


        'e23
        num = Label59.Text

        'e29
        num1 = TextBox4.Text

        If num < num1 Then
            Somme = num1 - num
        Else
            Somme = 0
        End If

        'MsgBox(num)
        'MsgBox(num1)


        Label31.Text = Somme


    End Sub

    Sub proc_besoin_emp_req3()
        Dim num As Double
        Dim num1 As Double
        Dim Somme As Double


        'e23
        num = Label58.Text

        'e29
        num1 = TextBox3.Text

        If num < num1 Then
            Somme = num1 - num
        Else
            Somme = 0
        End If


        Label30.Text = Somme
        Label30.Text = Format$(Label30.Text, "Currency")

    End Sub

    Sub proc_besoin_emp_req4()
        Dim num As Double
        Dim num1 As Double
        Dim Somme As Double


        'e23
        num = Label57.Text

        'e29
        num1 = TextBox2.Text

        If num < num1 Then
            Somme = num1 - num
        Else
            Somme = 0
        End If


        Label13.Text = Somme
        Label13.Text = Format$(Label13.Text, "Currency")

    End Sub

    ' ******************************************************
    'Solde encaisse début (Deuxieme)
    '-********************************************************



    Sub proc_solde_enc_req1()

        Dim num1 As Double
        Dim num2 As Double
        Dim somme As Double

        num1 = Label60.Text
        num2 = Label32.Text

        somme = num1 + num2

        Label14.Text = somme
        Label14.Text = Format$(Label14.Text, "Currency")


        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox13.Text
        nbrB = Label67.Text


        c1 = nbrA + nbrB

        Label59.Text = Format$(c1, "Currency")

        '-----------------------------------------------------------------------------

        Dim S, s2 As String
        S = Label59.Text
        Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label59.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        '--------------------------------------------------------------------------

        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim num6 As Double
        Dim num7 As Double
        Dim num8 As Double
        Dim num9 As Double

        num3 = somme
        num4 = TextBox11.Text
        num5 = TextBox17.Text
        num6 = Label19.Text
        num7 = Label24.Text
        num8 = Label28.Text
        num9 = TextBox71.Text

        somme = num3 + num4 - num5 - num6 - num7 - num8 - num9

        Label67.Text = somme

        'Dim S, s2 As String
        S = Label67.Text
        'Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label67.Text = s2.Replace(CChar("("), CChar("-"))


        Else
            'MsgBox("Positif")
        End If

        'Label67.Text = Format$(Label67.Text, "Currency")
        Label67.Text = Label67.Text + " $"

        Dim num10 As Double
        Dim num11 As Double

        num10 = TextBox19.Text
        num11 = Label32.Text

        somme = num10 - num11

        Label55.Text = somme
        Label55.Text = Format$(Label55.Text, "Currency")

        nbrA = Label59.Text
        nbrB = Label55.Text

        c1 = nbrA + nbrB

        Label51.Text = Format$(c1, "Currency")

        nbrA = Label59.Text


        nbrB = TextBox4.Text

        If nbrA < nbrB Then
            somme = nbrB - nbrA
        Else
            somme = 0
        End If


        Label31.Text = Format$(somme, "Currency")




    End Sub

    Sub proc_solde_enc_req2()

        Dim num1 As Double
        Dim num2 As Double
        Dim somme As Double

        num1 = Label59.Text
        num2 = Label31.Text

        somme = num1 + num2

        Label15.Text = somme
        Label15.Text = Format$(Label15.Text, "Currency")





        '-----------------------------------------------------------------------------

        Dim S, s2 As String
        S = Label58.Text
        Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label58.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        '--------------------------------------------------------------------------

        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim num6 As Double
        Dim num7 As Double
        Dim num8 As Double
        Dim num9 As Double

        num3 = somme
        num4 = TextBox10.Text
        num5 = TextBox16.Text
        num6 = Label20.Text
        num7 = Label23.Text
        num8 = Label27.Text
        num9 = TextBox70.Text

        somme = num3 + num4 - num5 - num6 - num7 - num8 - num9

        Label66.Text = somme

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        S = Label66.Text
        'Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label66.Text = s2.Replace(CChar("("), CChar("-"))


        Else
            'MsgBox("Positif")
        End If


        Label66.Text = Label66.Text + " $"


        nbrA = TextBox8.Text
        nbrB = Label66.Text


        c1 = nbrA + nbrB

        Label58.Text = Format$(c1, "Currency")



        S = Label58.Text

        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label58.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        Dim num10 As Double
        Dim num11 As Double

        num10 = Label55.Text


        '*********************************************

        Dim numC As Double
        Dim numD As Double
        Dim total As Double

        'e23
        numC = Label67.Text

        'e29
        numD = TextBox13.Text

        total = numC + numD

        num11 = total


        '**********************************************






        somme = num10 + num11

        'MsgBox(num11)



        Label54.Text = somme
        Label54.Text = Format$(Label54.Text, "Currency")


        nbrA = Label58.Text
        nbrB = Label54.Text

        c1 = nbrA + nbrB


        Label50.Text = Format$(c1, "Currency")

        S = Label50.Text

        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label50.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        nbrA = Label58.Text


        nbrB = TextBox3.Text

        If nbrA < nbrB Then
            somme = nbrB - nbrA
        Else
            somme = 0
        End If

        Label30.Text = somme
        Label30.Text = Format$(Label30.Text, "Currency")

    End Sub

    Sub proc_solde_enc_req3()


        Dim num1 As Double
        Dim num2 As Double
        Dim somme As Double

        num1 = Label58.Text
        num2 = Label30.Text

        somme = num1 + num2

        Label16.Text = somme
        Label16.Text = Format$(Label16.Text, "Currency")




        '-----------------------------------------------------------------------------

        Dim S, s2 As String
        S = Label57.Text
        Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label57.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        '--------------------------------------------------------------------------

        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim num6 As Double
        Dim num7 As Double
        Dim num8 As Double
        Dim num9 As Double

        num3 = somme
        num4 = TextBox9.Text
        num5 = TextBox15.Text
        num6 = Label21.Text
        num7 = Label22.Text
        num8 = Label26.Text
        num9 = TextBox69.Text

        somme = num3 + num4 - num5 - num6 - num7 - num8 - num9

        Label65.Text = somme

        S = Label65.Text
        'Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label65.Text = s2.Replace(CChar("("), CChar("-"))


        Else
            'MsgBox("Positif")
        End If


        Label65.Text = Label65.Text + " $"


        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox7.Text
        nbrB = Label65.Text


        c1 = nbrA + nbrB

        Label57.Text = Format$(c1, "Currency")



        S = Label57.Text

        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label57.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        Dim num10 As Double
        Dim num11 As Double

        num10 = Label54.Text


        '*********************************************

        Dim numC As Double
        Dim numD As Double
        Dim total As Double

        'e23
        numC = Label66.Text

        'e29
        numD = TextBox8.Text

        total = numC + numD

        num11 = total


        '**********************************************






        somme = num10 + num11

        'MsgBox(num11)



        Label53.Text = somme
        Label53.Text = Format$(Label53.Text, "Currency")



        nbrA = Label57.Text
        nbrB = Label53.Text

        c1 = nbrA + nbrB


        Label49.Text = Format$(c1, "Currency")

        S = Label49.Text

        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label49.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        nbrA = Label57.Text


        nbrB = TextBox2.Text

        If nbrA < nbrB Then
            somme = nbrB - nbrA
        Else
            somme = 0
        End If

        Label13.Text = somme
        Label13.Text = Format$(Label13.Text, "Currency")

    End Sub

    Sub proc_solde_enc_req35()

        Dim num1 As Double
        Dim num2 As Double
        Dim somme As Double

        num1 = Label57.Text
        num2 = Label13.Text

        somme = num1 + num2

        Label35.Text = somme

        Label35.Text = Format$(Label35.Text, "Currency")


        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim num6 As Double
        Dim num7 As Double
        Dim num8 As Double
        Dim num9 As Double

        num3 = somme
        num4 = TextBox20.Text
        num5 = TextBox21.Text
        num6 = Label36.Text
        num7 = Label37.Text
        num8 = Label41.Text
        num9 = TextBox22.Text

        somme = num3 + num4 - num5 - num6 - num7 - num8 - num9

        Label42.Text = somme

        Dim S, s2 As String
        S = Label42.Text
        Dim answer As Char
        answer = S.Substring(0, 1)
        If answer = "(" Then

            s2 = S.Substring(0, S.Length - 1)

            Label42.Text = s2.Replace(CChar("("), CChar("-"))

        Else
            'MsgBox("Positif")
        End If

        Label42.Text = Label42.Text + " $"

        Dim nbrA As Double
        Dim nbrB As Double

        Dim c1 As Double

        nbrA = TextBox23.Text
        nbrB = Label42.Text


        c1 = nbrA + nbrB

        Label43.Text = Format$(c1, "Currency")


        Dim num10 As Double
        Dim num11 As Double

        num10 = Label54.Text


        '*********************************************

        Dim numC As Double
        Dim numD As Double
        Dim total As Double

        'e23
        numC = Label65.Text

        'e29
        numD = TextBox7.Text

        total = numC + numD

        num11 = total


        '**********************************************






        somme = num10 + num11

        'MsgBox(num11)



        Label44.Text = somme
        Label44.Text = Format$(Label44.Text, "Currency")

        nbrA = Label43.Text
        nbrB = Label44.Text

        c1 = nbrA + nbrB


        Label45.Text = Format$(c1, "Currency")


        nbrA = Label43.Text


        nbrB = TextBox24.Text

        If nbrA < nbrB Then
            somme = nbrB - nbrA
        Else
            somme = 0
        End If

        Label46.Text = somme

        Label46.Text = Format$(Label46.Text, "Currency")
        'ElementPlusMax()
        

    End Sub

    Private Sub ElementPlusMax()



        Dim element1 As Double = Label32.Text
        Dim element2 As Double = Label31.Text
        Dim element3 As Double = Label30.Text
        Dim element4 As Double = Label13.Text
        Dim element5 As Double = Label46.Text
        Dim reponse As Double

        If element1 > element2 Then
            reponse = element1
        Else
            reponse = element2
        End If

        If reponse < element3 Then
            reponse = element3

        End If

        If reponse < element4 Then
            reponse = element4

        End If

        If reponse < element5 Then
            reponse = element5

        End If

        Label39.Text = Format$(reponse, "Currency")

    End Sub

    Private Sub proc_restaurantion()



        proc_tab_paiement_direct()
        'proc_tab_paiement_preautorise()
        'proc_tab_cheque_emis()

        Dim myList As New ArrayList

        myList.Add(CDbl(TextBox1.Text))
        myList.Add(CDbl(TextBox12.Text))
        myList.Add(CDbl(TextBox11.Text))
        myList.Add(CDbl(TextBox10.Text))
        myList.Add(CDbl(TextBox9.Text))
        myList.Add(CDbl(TextBox20.Text))
        myList.Add(CDbl(TextBox18.Text))
        myList.Add(CDbl(TextBox17.Text))
        myList.Add(CDbl(TextBox16.Text))
        myList.Add(CDbl(TextBox15.Text))
        myList.Add(CDbl(TextBox21.Text))
        myList.Add(CDbl(TextBox72.Text))
        myList.Add(CDbl(TextBox71.Text))
        myList.Add(CDbl(TextBox70.Text))
        myList.Add(CDbl(TextBox69.Text))
        myList.Add(CDbl(TextBox22.Text))
        myList.Add(CDbl(TextBox14.Text))
        myList.Add(CDbl(TextBox13.Text))
        myList.Add(CDbl(TextBox8.Text))
        myList.Add(CDbl(TextBox7.Text))
        myList.Add(CDbl(TextBox23.Text))
        myList.Add(CDbl(TextBox19.Text))
        myList.Add(CDbl(TextBox6.Text))
        myList.Add(CDbl(TextBox4.Text))
        myList.Add(CDbl(TextBox3.Text))
        myList.Add(CDbl(TextBox2.Text))
        myList.Add(CDbl(TextBox24.Text))
        myList.Add(CDbl(TextBox5.Text))

        myList.Sort()
        Dim ligne As String = ""

        For Each item In myList
            System.Diagnostics.Debug.WriteLine(item)

            Dim DblA As Double = item
            Dim VarA As String = FormatNumber(DblA)
            ligne = ligne + VarA + "/"

            'MsgBox(item)

        Next






    End Sub

    Private Sub proc_tab_paiement_direct()

        'Dans la fonction proc_tab_paiement_direct()



    End Sub

    Private Sub TextBox12_DragLeave(sender As Object, e As EventArgs) Handles TextBox12.DragLeave

    End Sub

    Private Sub TextBox12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.Enter, TextBox11.Enter,
        TextBox10.Enter, TextBox9.Enter, TextBox20.Enter, TextBox1.Enter, TextBox18.Enter, TextBox17.Enter, TextBox16.Enter,
        TextBox15.Enter, TextBox21.Enter, TextBox72.Enter, TextBox71.Enter, TextBox70.Enter, TextBox69.Enter, TextBox22.Enter,
        TextBox14.Enter, TextBox13.Enter, TextBox8.Enter, TextBox7.Enter, TextBox23.Enter, TextBox19.Enter, TextBox6.Enter,
        TextBox4.Enter, TextBox3.Enter, TextBox2.Enter, TextBox24.Enter, TextBox5.Enter


        Dim tb As TextBox = CType(sender, TextBox)

        tb = CType(sender, TextBox)

        num_temporaire = tb.Text



    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown


        Dim tb As TextBox = New TextBox
        Dim categorie As String

        tb = CType(sender, TextBox)


        If num_temporaire <> "" Then



        End If

        'If rep = "Textbox1" Then
        '    categorie = "Solde_encaisses_debut"
        'End If



        If e.KeyCode = Keys.Enter Then
            num_temporaire = String.Empty
            TextBox12.Focus()

            
            periode_paiement_direct()
            periode_paiement_preautorise()
            periode_cheque_emis()


            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update Solde_encaisses_debut set courant = @description WHERE numero = @numero", myConnection)

            myCommand.Parameters.AddWithValue("@description", TextBox1.Text)
            num_temporaire = tb.Text


            'myCommand.Parameters.AddWithValue("@description", TextBox12.Text)
            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()

        End If

    End Sub


    Private Sub TextBox12_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyDown, TextBox11.KeyDown, TextBox10.KeyDown, TextBox9.KeyDown, TextBox20.KeyDown



        Dim tb As TextBox = New TextBox
        Dim categorie As String
        Dim nom_table As String


        tb = CType(sender, TextBox)


        If num_temporaire <> "" Then

            Select Case tb.Name
                Case "TextBox12"
                    categorie = "courant"
                    nom_table = "Apports"
                Case "TextBox11"
                    categorie = "sept"
                    nom_table = "Apports"
                Case "TextBox10"
                    categorie = "quatorze"
                    nom_table = "Apports"
                Case "TextBox9"
                    categorie = "vingt"
                    nom_table = "Apports"
                Case "TextBox20"
                    categorie = "cinq"
                    nom_table = "Apports"
            End Select

        End If

        'If rep = "Textbox1" Then
        '    categorie = "Solde_encaisses_debut"
        'End If

        If e.KeyCode = Keys.Enter Then
            num_temporaire = String.Empty
            Select Case tb.Name
                Case "TextBox12"
                    TextBox11.Focus()
                Case "TextBox11"
                    TextBox10.Focus()
                Case "TextBox10"
                    TextBox9.Focus()
                Case "TextBox9"
                    TextBox20.Focus()
                Case "TextBox20"
                    TextBox18.Focus()


            End Select

            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update Apports set " & categorie & " = @description WHERE numero = @numero", myConnection)




            Select Case tb.Name
                Case "TextBox12"
                    myCommand.Parameters.AddWithValue("@description", TextBox12.Text)
                    num_temporaire = tb.Text
                Case "TextBox11"
                    myCommand.Parameters.AddWithValue("@description", TextBox11.Text)
                    num_temporaire = tb.Text
                Case "TextBox10"
                    myCommand.Parameters.AddWithValue("@description", TextBox10.Text)
                    num_temporaire = tb.Text
                Case "TextBox9"
                    myCommand.Parameters.AddWithValue("@description", TextBox9.Text)
                    num_temporaire = tb.Text
                Case "TextBox20"
                    myCommand.Parameters.AddWithValue("@description", TextBox20.Text)
                    num_temporaire = tb.Text

            End Select


            'myCommand.Parameters.AddWithValue("@description", TextBox12.Text)

            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()

        End If

    End Sub

    ' ******************************************************
    ' Encaisse minimum requise
    '-********************************************************




    ' ******************************************************
    '*********************************************************
    '-********************************************************

    ' ******************************************************
    ' Marge de crédit disponible
    '-********************************************************


    Sub proc_marge_credit_disp_req1()

    End Sub

    Sub proc_marge_credit_disp_req2()

    End Sub

    Sub proc_marge_credit_disp_req3()

    End Sub

  


    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress, TextBox11.KeyPress,
        TextBox10.KeyPress, TextBox9.KeyPress, TextBox20.KeyPress, TextBox1.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress,
        TextBox16.KeyPress, TextBox15.KeyPress, TextBox21.KeyPress, TextBox72.KeyPress, TextBox71.KeyPress, TextBox70.KeyPress,
        TextBox69.KeyPress, TextBox22.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress,
        TextBox23.KeyPress, TextBox19.KeyPress, TextBox6.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress,
        TextBox24.KeyPress, TextBox5.KeyPress

        'MsgBox("retour")
        'num_temporaire = ""
        Dim allowedChars As String = "0123456789,"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If






        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
        '    'SendKeys.Send("{TAB}")
        '    e.Handled = True
        '    Me.Controls.Clear() 'removes all the controls on the form
        '    'TODO How to reload windows form without closing it using VB.NET

        '    InitializeComponent() 'load all the controls again

        '    frmGestion_Load(e, e) 'Load everything in your form load event again'
        '    MsgBox("Changed Success")


        'End If





    End Sub

    Private Sub TextBox12_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.Leave, TextBox11.Leave,
        TextBox10.Leave, TextBox9.Leave, TextBox20.Leave, TextBox1.Leave, TextBox12.Leave, TextBox11.Leave, TextBox10.Leave,
        TextBox9.Leave, TextBox20.Leave, TextBox18.Leave, TextBox17.Leave, TextBox16.Leave, TextBox15.Leave, TextBox21.Leave,
        TextBox72.Leave, TextBox71.Leave, TextBox70.Leave, TextBox69.Leave, TextBox22.Leave, TextBox14.Leave, TextBox13.Leave,
        TextBox8.Leave, TextBox7.Leave, TextBox23.Leave, TextBox19.Leave, TextBox6.Leave, TextBox4.Leave, TextBox3.Leave, TextBox2.Leave,
        TextBox24.Leave, TextBox5.Leave




        Dim tb As TextBox = New TextBox

        tb = CType(sender, TextBox)

        If num_temporaire <> "" Then
            'Select Case tb.Name
            '    Case "TextBox12"
            '        'MsgBox(tb.Text)
            '        'TextBox12.Text = Format(Double.Parse(TextBox12.Text), "###,###,##0.00")
            '        ' TextBox12.Text = Format(Double.Parse(num_temporaire), "###,###,##0.00")
            '        TextBox12.Text = num_temporaire

            '    Case "TextBox11"
            '        TextBox11.Text = num_temporaire
            '    Case "TextBox10"
            '        TextBox10.Text = num_temporaire
            '    Case "TextBox9"
            '        TextBox9.Text = num_temporaire
            '    Case "TextBox20"
            '        TextBox20.Text = num_temporaire
            '    Case "TextBox1"
            '        TextBox1.Text = num_temporaire
            '    Case "TextBox18"
            '        TextBox18.Text = num_temporaire
            '    Case "TextBox17"
            '        TextBox17.Text = num_temporaire
            '    Case "TextBox16"
            '        TextBox16.Text = num_temporaire
            '    Case "TextBox15"
            '        TextBox15.Text = num_temporaire
            '    Case "TextBox21"
            '        TextBox21.Text = num_temporaire
            '    Case "TextBox72"
            '        TextBox72.Text = num_temporaire
            '    Case "TextBox71"
            '        TextBox71.Text = num_temporaire
            '    Case "TextBox70"
            '        TextBox70.Text = num_temporaire
            '    Case "TextBox69"
            '        TextBox69.Text = num_temporaire
            '    Case "TextBox22"
            '        TextBox22.Text = num_temporaire
            '    Case "TextBox14"
            '        TextBox14.Text = num_temporaire
            '    Case "TextBox13"
            '        TextBox13.Text = num_temporaire
            '    Case "TextBox8"
            '        TextBox8.Text = num_temporaire
            '    Case "TextBox7"
            '        TextBox7.Text = num_temporaire
            '    Case "TextBox23"
            '        TextBox23.Text = num_temporaire
            '    Case "TextBox6"
            '        TextBox6.Text = num_temporaire
            '    Case "TextBox4"
            '        TextBox4.Text = num_temporaire
            '    Case "TextBox3"
            '        TextBox3.Text = num_temporaire
            '    Case "TextBox2"
            '        TextBox2.Text = num_temporaire
            '    Case "TextBox24"
            '        TextBox24.Text = num_temporaire
            '    Case "TextBox5"
            '        TextBox5.Text = num_temporaire
            'End Select

            tb.Text = num_temporaire




        End If

        'Try
        '    ' Try to divide by zero.

        '    tb = CType(sender, TextBox)
        '    ' This statement is sadly not reached.
        '    'Console.WriteLine("Hi")
        'Catch ex As Exception
        '    ' Display the message.
        '    Select Case tb.Name
        '        Case "TextBox12"
        '            'MsgBox(tb.Text)
        '            'TextBox12.Text = Format(Double.Parse(TextBox12.Text), "###,###,##0.00")
        '            MsgBox("hey")
        '            TextBox12.Text = num_temporaire
        '        Case "TextBox11"
        '            'TextBox11.Text = Format(Double.Parse(TextBox11.Text), "###,###,##0.00")
        '        Case "TextBox10"
        '            'TextBox10.Text = Format(Double.Parse(TextBox10.Text), "###,###,##0.00")
        '        Case "TextBox9"
        '            'TextBox9.Text = Format(Double.Parse(TextBox9.Text), "###,###,##0.00")
        '        Case "TextBox20"
        '            'TextBox20.Text = Format(Double.Parse(TextBox20.Text), "###,###,##0.00 $")
        '    End Select
        'End Try







    End Sub


    Private Sub TextBox12_LostFocus(sender As Object, e As EventArgs) Handles TextBox12.LostFocus

        'Dim myConnection As New OleDb.OleDbConnection(myConnString)
        'Dim oledbAdapter As New OleDb.OleDbDataAdapter
        'myConnection.Open()

        'Dim myCommand As New OleDb.OleDbCommand("update Apports set courant = @description WHERE numero = @numero", myConnection)
        'myCommand.Parameters.AddWithValue("@description", Val(TextBox12.Text))
        'myCommand.Parameters.AddWithValue("@numero", 1)

        'myCommand.ExecuteNonQuery()
        'myConnection.Close()

    End Sub

    'Private Sub TextBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        TextBox10.Focus()
    '        Dim myConnection As New OleDb.OleDbConnection(myConnString)
    '        Dim oledbAdapter As New OleDb.OleDbDataAdapter
    '        myConnection.Open()

    '        Dim myCommand As New OleDb.OleDbCommand("update Apports set sept = @description WHERE numero = @numero", myConnection)
    '        myCommand.Parameters.AddWithValue("@description", TextBox11.Text)
    '        myCommand.Parameters.AddWithValue("@numero", 1)

    '        myCommand.ExecuteNonQuery()
    '        myConnection.Close()

    '    End If

    'End Sub


    Private Sub TextBox11_LostFocus(sender As Object, e As EventArgs) Handles TextBox11.LostFocus

        'Dim myConnection As New OleDb.OleDbConnection(myConnString)
        'Dim oledbAdapter As New OleDb.OleDbDataAdapter
        'myConnection.Open()

        'Dim myCommand As New OleDb.OleDbCommand("update Apports set sept = @description WHERE numero = @numero", myConnection)
        'myCommand.Parameters.AddWithValue("@description", Val(TextBox11.Text))
        'myCommand.Parameters.AddWithValue("@numero", 1)

        'myCommand.ExecuteNonQuery()
        'myConnection.Close()

    End Sub





    Private Sub TextBox18_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox18.KeyDown, TextBox17.KeyDown, TextBox16.KeyDown, TextBox15.KeyDown, TextBox21.KeyDown



        Dim tb As TextBox = New TextBox
        Dim categorie As String

        tb = CType(sender, TextBox)

        If num_temporaire <> "" Then

            Select Case tb.Name
                Case "TextBox18"
                    categorie = "courant"
                Case "TextBox17"
                    categorie = "sept"
                Case "TextBox16"
                    categorie = "quatorze"
                Case "TextBox15"
                    categorie = "vingt"
                Case "TextBox21"
                    categorie = "cinq"
            End Select

        End If



        If e.KeyCode = Keys.Enter Then
            num_temporaire = String.Empty
            Select Case tb.Name
                Case "TextBox18"
                    TextBox17.Focus()
                Case "TextBox17"
                    TextBox16.Focus()
                Case "TextBox16"
                    TextBox15.Focus()
                Case "TextBox15"
                    TextBox21.Focus()
                Case "TextBox21"
                    TextBox72.Focus()


            End Select

            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update Retrait_manuel set " & categorie & "= @description WHERE numero = @numero", myConnection)
            myCommand.Parameters.AddWithValue("@description", tb.Text)
            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()

        End If
    End Sub

    ' ******************************************************
    ' RETRAIRE MANUEL
    '-********************************************************




   





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'test
       
        'frmMenu.Show()
        'Me.Dispose()

        'Me.Close()

        Me.Close()



        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows
        frmMenu.Show()



    End Sub

    Private Sub TextBox72_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox72.KeyDown, TextBox71.KeyDown, TextBox70.KeyDown, TextBox69.KeyDown, TextBox22.KeyDown

        Dim tb As TextBox = New TextBox
        Dim categorie As String

        tb = CType(sender, TextBox)

        If num_temporaire <> "" Then

            Select Case tb.Name
                Case "TextBox72"
                    categorie = "courant"

                Case "TextBox71"
                    categorie = "sept"

                Case "TextBox70"
                    categorie = "quatorze"

                Case "TextBox69"
                    categorie = "vingt"

                Case "TextBox22"
                    categorie = "cinq"

            End Select

        End If


        If e.KeyCode = Keys.Enter Then

            num_temporaire = String.Empty

            Select Case tb.Name
                Case "TextBox72"
                    TextBox71.Focus()
                Case "TextBox71"
                    TextBox70.Focus()
                Case "TextBox70"
                    TextBox69.Focus()
                Case "TextBox69"
                    TextBox22.Focus()
                Case "TextBox22"
                    TextBox14.Focus()


            End Select


            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update Salaires_paie_courante set " & categorie & " = @description WHERE numero = @numero", myConnection)


            Select Case tb.Name
                Case "TextBox72"
                    myCommand.Parameters.AddWithValue("@description", TextBox72.Text)
                    num_temporaire = tb.Text
                Case "TextBox71"
                    myCommand.Parameters.AddWithValue("@description", TextBox71.Text)
                    num_temporaire = tb.Text
                Case "TextBox70"
                    myCommand.Parameters.AddWithValue("@description", TextBox70.Text)
                    num_temporaire = tb.Text
                Case "TextBox69"
                    myCommand.Parameters.AddWithValue("@description", TextBox69.Text)
                    num_temporaire = tb.Text
                Case "TextBox22"
                    myCommand.Parameters.AddWithValue("@description", TextBox22.Text)
                    num_temporaire = tb.Text

            End Select



            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()


        End If

    End Sub

    ' ******************************************************
    ' Salaire paie courante
    '-********************************************************


    Private Sub TextBox72_LostFocus(sender As Object, e As EventArgs) Handles TextBox72.LostFocus
        'Dim myConnection As New OleDb.OleDbConnection(myConnString)
        'Dim oledbAdapter As New OleDb.OleDbDataAdapter
        'myConnection.Open()

        'Dim myCommand As New OleDb.OleDbCommand("update Salaires_paie_courante set courant = @description WHERE numero = @numero", myConnection)
        'myCommand.Parameters.AddWithValue("@description", Val(TextBox72.Text))
        'myCommand.Parameters.AddWithValue("@numero", 1)

        'myCommand.ExecuteNonQuery()
        'myConnection.Close()
    End Sub

    
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
    End Sub



    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'Dim myConnection As New OleDb.OleDbConnection(myConnString)
        'Dim oledbAdapter As New OleDb.OleDbDataAdapter
        'myConnection.Open()

        'Dim myCommand As New OleDb.OleDbCommand("update Solde_encaisses_debut set courant = @description WHERE numero = @numero", myConnection)
        'myCommand.Parameters.AddWithValue("@description", Val(TextBox1.Text))
        'myCommand.Parameters.AddWithValue("@numero", 1)

        'myCommand.ExecuteNonQuery()

        'myConnection.Close()

        'TextBox1.Text = FormatCurrency(TextBox1.Text)

        'Dim myText = TextBox1.Text
        'Dim dIndex = myText.IndexOf("5")
        'If (dIndex > -1) Then
        '    MsgBox("Trouve")
        'Else
        '    MsgBox("non trouvé")
        'End If
    End Sub






    Private Sub TextBox14_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox14.KeyDown, TextBox13.KeyDown, TextBox8.KeyDown, TextBox7.KeyDown, TextBox23.KeyDown

        Dim tb As TextBox = New TextBox
        Dim categorie As String

        tb = CType(sender, TextBox)

        If num_temporaire <> "" Then

            Select Case tb.Name
                Case "TextBox14"
                    categorie = "courant"

                Case "TextBox13"
                    categorie = "sept"

                Case "TextBox8"
                    categorie = "quatorze"

                Case "TextBox7"
                    categorie = "vingt"

                Case "TextBox23"
                    categorie = "cinq"

            End Select

        End If



        If e.KeyCode = Keys.Enter Then

            num_temporaire = String.Empty

            Select Case tb.Name
                Case "TextBox14"
                    TextBox13.Focus()
                Case "TextBox13"
                    TextBox8.Focus()
                Case "TextBox8"
                    TextBox7.Focus()
                Case "TextBox7"
                    TextBox23.Focus()
                Case "TextBox23"
                    TextBox19.Focus()


            End Select


            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update Argent_a_recevoir set " & categorie & "  = @description WHERE numero = @numero", myConnection)

            Select Case tb.Name
                Case "TextBox14"
                    myCommand.Parameters.AddWithValue("@description", TextBox14.Text)
                    num_temporaire = tb.Text
                Case "TextBox13"
                    myCommand.Parameters.AddWithValue("@description", TextBox13.Text)
                    num_temporaire = tb.Text
                Case "TextBox8"
                    myCommand.Parameters.AddWithValue("@description", TextBox8.Text)
                    num_temporaire = tb.Text
                Case "TextBox7"
                    myCommand.Parameters.AddWithValue("@description", TextBox7.Text)
                    num_temporaire = tb.Text
                Case "TextBox23"
                    myCommand.Parameters.AddWithValue("@description", TextBox23.Text)
                    num_temporaire = tb.Text

            End Select



            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()

        End If
    End Sub

  


  
    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown

        If e.KeyCode = Keys.Enter Then
            num_temporaire = String.Empty
            TextBox1.Focus()

            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update marge_de_credit_utilise set courant = @description WHERE numero = @numero", myConnection)
            myCommand.Parameters.AddWithValue("@description", TextBox5.Text)
            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()


        End If
    End Sub

    Private Sub TextBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown, TextBox4.KeyDown, TextBox3.KeyDown, TextBox2.KeyDown, TextBox24.KeyDown

        Dim tb As TextBox = New TextBox
        Dim categorie As String

        tb = CType(sender, TextBox)

        If num_temporaire <> "" Then

            Select Case tb.Name
                Case "TextBox6"
                    categorie = "courant"

                Case "TextBox4"
                    categorie = "sept"

                Case "TextBox3"
                    categorie = "quatorze"

                Case "TextBox2"
                    categorie = "vingt"

                Case "TextBox24"
                    categorie = "cinq"

            End Select

        End If


        If e.KeyCode = Keys.Enter Then

            num_temporaire = String.Empty

            Select tb.Name
                Case "TextBox6"
                    TextBox4.Focus()
                Case "TextBox4"
                    TextBox3.Focus()
                Case "TextBox3"
                    TextBox2.Focus()
                Case "TextBox2"
                    TextBox24.Focus()
                Case "TextBox24"
                    TextBox5.Focus()
            End Select






            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update Encaisse_minimum_requise set " & categorie & " = @description WHERE numero = @numero", myConnection)

            Select Case tb.Name
                Case "TextBox6"
                    myCommand.Parameters.AddWithValue("@description", TextBox6.Text)
                    num_temporaire = tb.Text
                Case "TextBox4"
                    myCommand.Parameters.AddWithValue("@description", TextBox4.Text)
                    num_temporaire = tb.Text
                Case "TextBox3"
                    myCommand.Parameters.AddWithValue("@description", TextBox3.Text)
                    num_temporaire = tb.Text
                Case "TextBox2"
                    myCommand.Parameters.AddWithValue("@description", TextBox2.Text)
                    num_temporaire = tb.Text
                Case "TextBox24"
                    myCommand.Parameters.AddWithValue("@description", TextBox24.Text)
                    num_temporaire = tb.Text

            End Select


            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()

        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    

    Private Sub TextBox19_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox19.KeyDown
        If e.KeyCode = Keys.Enter Then
            num_temporaire = String.Empty
            TextBox6.Focus()

            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            Dim oledbAdapter As New OleDb.OleDbDataAdapter
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("update marge_credit_disponible set courant = @description WHERE numero = @numero", myConnection)
            myCommand.Parameters.AddWithValue("@description", TextBox19.Text)
            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()
            proc_tout()

        End If

    End Sub

    Sub periode_paiement_direct()


        Dim numero As Integer
        Dim compteur As Integer = 0
        Dim montant As Double


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select * from check_direct", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()


        Dim tab As Double() = {0, 0, 0, 0, 0}


        While myReader1.Read
            numero = myReader1.Item(0)
            tab(0) = myReader1.Item(4)
            tab(1) = myReader1.Item(5)
            tab(2) = myReader1.Item(6)
            tab(3) = myReader1.Item(7)
            tab(4) = myReader1.Item(8)

            Dim periode As String = ""


            Dim date_paiement As DateTime


            If (tab(0) <> 0) Then
                periode = "un"
                montant = tab(0)
            End If

            If (tab(1) <> 0) Then
                periode = "deux"
                montant = tab(1)

            End If

            If (tab(2) <> 0) Then
                periode = "trois"
                montant = tab(2)
            End If

            If (tab(3) <> 0) Then
                periode = "quatre"
                montant = tab(3)

            End If

            If (tab(4) <> 0) Then
                periode = "cinq"
                montant = tab(4)

            End If

            date_paiement = myReader1.Item(3)

            fctable_paiement_direct(montant, numero, date_paiement)


        End While


        myConnection.Close()








    End Sub

    Sub periode_cheque_emis()

        Dim numero As Integer
        Dim compteur As Integer = 0
        Dim montant As Double


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select * from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()


        Dim tab As Double() = {0, 0, 0, 0, 0}


        While myReader1.Read
            numero = myReader1.Item(0)
            tab(0) = myReader1.Item(5)
            tab(1) = myReader1.Item(6)
            tab(2) = myReader1.Item(7)
            tab(3) = myReader1.Item(8)
            tab(4) = myReader1.Item(9)

            Dim periode As String = ""


            Dim date_paiement As DateTime


            If (tab(0) <> 0) Then
                periode = "un"
                montant = tab(0)
            End If

            If (tab(1) <> 0) Then
                periode = "deux"
                montant = tab(1)

            End If

            If (tab(2) <> 0) Then
                periode = "trois"
                montant = tab(2)
            End If

            If (tab(3) <> 0) Then
                periode = "quatre"
                montant = tab(3)

            End If

            If (tab(4) <> 0) Then
                periode = "cinq"
                montant = tab(4)

            End If

            date_paiement = myReader1.Item(3)

            fctable_cheque_emis(montant, numero, date_paiement)


        End While


        myConnection.Close()








    End Sub

    Sub periode_paiement_preautorise()

        Dim numero As Integer
        Dim compteur As Integer = 0
        Dim montant As Double


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select * from check_preautorises", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()


        Dim tab As Double() = {0, 0, 0, 0, 0}


        While myReader1.Read
            numero = myReader1.Item(0)
            tab(0) = myReader1.Item(4)
            tab(1) = myReader1.Item(5)
            tab(2) = myReader1.Item(6)
            tab(3) = myReader1.Item(7)
            tab(4) = myReader1.Item(8)

            Dim periode As String = ""


            Dim date_paiement As DateTime


            If (tab(0) <> 0) Then
                periode = "un"
                montant = tab(0)
            End If

            If (tab(1) <> 0) Then
                periode = "deux"
                montant = tab(1)

            End If

            If (tab(2) <> 0) Then
                periode = "trois"
                montant = tab(2)
            End If

            If (tab(3) <> 0) Then
                periode = "quatre"
                montant = tab(3)

            End If

            If (tab(4) <> 0) Then
                periode = "cinq"
                montant = tab(4)

            End If

            date_paiement = myReader1.Item(3)

            fctable_paiement_preautorise(montant, numero, date_paiement)


        End While


        myConnection.Close()








    End Sub




    Function fctable_paiement_direct(ByVal montant As Double, ByVal numero As Integer, ByVal date_ As DateTime)


        Dim reponse As String = ""
        Dim tab As Double() = {0, 0, 0, 0, 0}
        Dim cpt As Integer = 0
        'Dim currentDate As DateTime
        'currentDate = Now.Date


        ' Tester avant la date de paiement

        Dim dtnow As Date = Date.Now
        'If dtnow < date_ Then

        '    tab(0) = montant
        'End If

        Dim currentDate1 As Date

        'currentDate = currentDate.AddDays(1)

        Dim currentDate As Date = Date.Now



        If date_.Date <= currentDate.Date Then

            tab(cpt) = montant
        End If




        currentDate1 = currentDate.AddDays(6)



        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant
        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1


        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If


        If date_.Date >= currentDate.Date Then

            tab(cpt) = montant
        End If


        'If dtnow > date_ Then

        '    tab(4) = montant

        'End If



        'MsgBox("Test débogger")
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        Dim oledbAdapter As New OleDb.OleDbDataAdapter
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("update check_direct set un = @num1, deux = @num2, trois = @num3, quatre = @num4, cinq = @num5 WHERE numero = @numero", myConnection)

        myCommand.Parameters.AddWithValue("@num1", tab(0))
        myCommand.Parameters.AddWithValue("@num2", tab(1))
        myCommand.Parameters.AddWithValue("@num3", tab(2))
        myCommand.Parameters.AddWithValue("@num4", tab(3))
        myCommand.Parameters.AddWithValue("@num5", tab(4))
        'myCommand.Parameters.AddWithValue("@description", TextBox12.Text)
        myCommand.Parameters.AddWithValue("@numero", numero)

        myCommand.ExecuteNonQuery()
        myConnection.Close()











        'Dim myCommand2 As New OleDb.OleDbCommand("Select * from check_direct where numero ='" & numero & "'", myConnection)
        'Dim myCommand2 As New OleDb.OleDbCommand("Select * from check_direct where numero = 75", myConnection)


    End Function


    Function fctable_cheque_emis(ByVal montant As Double, ByVal numero As Integer, ByVal date_ As DateTime)


        Dim reponse As String = ""
        Dim tab As Double() = {0, 0, 0, 0, 0}
        Dim cpt As Integer = 0
        'Dim currentDate As DateTime
        'currentDate = Now.Date


        ' Tester avant la date de paiement

        Dim dtnow As Date = Date.Now
        'If dtnow < date_ Then

        '    tab(0) = montant
        'End If

        Dim currentDate1 As Date

        'currentDate = currentDate.AddDays(1)

        Dim currentDate As Date = Date.Now



        If date_.Date <= currentDate.Date Then

            tab(cpt) = montant
        End If




        currentDate1 = currentDate.AddDays(6)



        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant
        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1


        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If


        If date_.Date >= currentDate.Date Then

            tab(cpt) = montant
        End If


        'If dtnow > date_ Then

        '    tab(4) = montant

        'End If



        'MsgBox("Test débogger")
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        Dim oledbAdapter As New OleDb.OleDbDataAdapter
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("update check_emis set un = @num1, deux = @num2, trois = @num3, quatre = @num4, cinq = @num5 WHERE numero = @numero", myConnection)

        myCommand.Parameters.AddWithValue("@num1", tab(0))
        myCommand.Parameters.AddWithValue("@num2", tab(1))
        myCommand.Parameters.AddWithValue("@num3", tab(2))
        myCommand.Parameters.AddWithValue("@num4", tab(3))
        myCommand.Parameters.AddWithValue("@num5", tab(4))
        'myCommand.Parameters.AddWithValue("@description", TextBox12.Text)
        myCommand.Parameters.AddWithValue("@numero", numero)

        myCommand.ExecuteNonQuery()
        myConnection.Close()











        'Dim myCommand2 As New OleDb.OleDbCommand("Select * from check_direct where numero ='" & numero & "'", myConnection)
        'Dim myCommand2 As New OleDb.OleDbCommand("Select * from check_direct where numero = 75", myConnection)


    End Function


    Function fctable_paiement_preautorise(ByVal montant As Double, ByVal numero As Integer, ByVal date_ As DateTime)


        Dim reponse As String = ""
        Dim tab As Double() = {0, 0, 0, 0, 0}
        Dim cpt As Integer = 0
        'Dim currentDate As DateTime
        'currentDate = Now.Date


        ' Tester avant la date de paiement

        Dim dtnow As Date = Date.Now
        'If dtnow < date_ Then

        '    tab(0) = montant
        'End If

        Dim currentDate1 As Date

        'currentDate = currentDate.AddDays(1)

        Dim currentDate As Date = Date.Now



        If date_.Date <= currentDate.Date Then

            tab(cpt) = montant
        End If




        currentDate1 = currentDate.AddDays(6)



        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant
        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1

        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If

        currentDate = currentDate1.AddDays(1)
        currentDate1 = currentDate.AddDays(6)
        cpt = cpt + 1


        If date_.Date >= currentDate.Date And date_.Date <= currentDate1.Date And cpt < 5 Then

            tab(cpt) = montant

        End If


        If date_.Date >= currentDate.Date Then

            tab(cpt) = montant
        End If


        'If dtnow > date_ Then

        '    tab(4) = montant

        'End If



        'MsgBox("Test débogger")
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        Dim oledbAdapter As New OleDb.OleDbDataAdapter
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("update check_preautorises set un = @num1, deux = @num2, trois = @num3, quatre = @num4, cinq = @num5 WHERE numero = @numero", myConnection)

        myCommand.Parameters.AddWithValue("@num1", tab(0))
        myCommand.Parameters.AddWithValue("@num2", tab(1))
        myCommand.Parameters.AddWithValue("@num3", tab(2))
        myCommand.Parameters.AddWithValue("@num4", tab(3))
        myCommand.Parameters.AddWithValue("@num5", tab(4))
        'myCommand.Parameters.AddWithValue("@description", TextBox12.Text)
        myCommand.Parameters.AddWithValue("@numero", numero)

        myCommand.ExecuteNonQuery()
        myConnection.Close()











        'Dim myCommand2 As New OleDb.OleDbCommand("Select * from check_direct where numero ='" & numero & "'", myConnection)
        'Dim myCommand2 As New OleDb.OleDbCommand("Select * from check_direct where numero = 75", myConnection)


    End Function


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox12_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox12.MouseClick, TextBox1.MouseClick, TextBox11.MouseClick, TextBox10.MouseClick, TextBox9.MouseClick, TextBox20.MouseClick, TextBox18.MouseClick,
        TextBox17.MouseClick, TextBox16.MouseClick, TextBox15.MouseClick, TextBox21.MouseClick, TextBox72.MouseClick, TextBox71.MouseClick,
         TextBox70.MouseClick, TextBox69.MouseClick, TextBox22.MouseClick, TextBox14.MouseClick, TextBox13.MouseClick, TextBox8.MouseClick,
         TextBox7.MouseClick, TextBox23.MouseClick, TextBox19.MouseClick, TextBox6.MouseClick, TextBox4.MouseClick, TextBox3.MouseClick,
         TextBox2.MouseClick, TextBox24.MouseClick, TextBox5.MouseClick

        Dim tb As TextBox = New TextBox
        Dim categorie As String

        tb = CType(sender, TextBox)

        tb.SelectAll()





        'TextBox12.SelectAll()

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub


End Class
