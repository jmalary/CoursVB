Imports Comptable_NBJMM.GlobalVariables
Imports System.Globalization

Public Class frmMenu

    Dim myConnString As String = GlobalVariables.User_Access
    Dim lister As New ArrayList
    Dim tableau() As String
    Dim no_lign As Integer
    Dim tab_rep() As String
    Dim del_chaine As String
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim sqlStr As String



    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Label1.Text = Date.Today

        Dim string_date As String

        proc_load()
        proc_depasse()

        proc_load_db()



        'MsgBox(DateCourant)

        string_date = DateCourant.ToString("dddd dd MMMM yyyy", _
              CultureInfo.CreateSpecificCulture("fr-CA"))



        Label1.Text = string_date



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        frmCheque.Show()
        'frmCheque.MdiParent = Me
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmPaiement.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmEmployeur.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Liste_Cheque.Click
        Me.WindowState = FormWindowState.Maximized
        frmAfficherListeCheque.MdiParent = Form_windows
        frmAfficherListeCheque.Show()

        Me.Hide()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btm_Paiement_direct.Click
        Me.WindowState = FormWindowState.Maximized
        frmAfficherListePaiementDirect.MdiParent = Form_windows
        frmAfficherListePaiementDirect.Show()



        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btm_Preautorise.Click
        Me.WindowState = FormWindowState.Maximized
        frmAfficherListePaiementPreautorise.MdiParent = Form_windows
        frmAfficherListePaiementPreautorise.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Me.WindowState = FormWindowState.Maximized
        frmGestion.MdiParent = Form_windows
        frmGestion.Show()
        'frmLoading.Show()


        Me.Hide()




    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("message", "caption", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            MessageBox.Show("NON")
        ElseIf result = DialogResult.Yes Then
            Me.Close()
            Form_windows.Close()


        End If
    End Sub

    Private Sub frmMenu_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not Parent Is Nothing Then
            r = Parent.ClientRectangle
            x = r.Width - Me.Width + Parent.Left
            y = r.Height - Me.Height + Parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - Me.Width
            y = r.Height - Me.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(x, y)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        Me.WindowState = FormWindowState.Maximized
        frmAfficherListeCheque.MdiParent = Form_windows
        frmAfficherListeCheque.Show()
        'frmLoading.Show()


        Me.Hide()

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Sub proc_load()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("SELECT * FROM check_preautorises WHERE payer = '" & "oui" & "'", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()



        While myReader1.Read
            'Label2.Text = Format$(myReader1.Item(0).ToString, "Currency")

            Dim valueIntConverted As Integer = CInt(myReader1.Item(0).ToString)

            Dim montant As String

            Dim runningVB As Boolean
            Dim cpt As Integer = 4


            runningVB = True


            While runningVB

                montant = myReader1.Item(cpt).ToString()

                If montant = 0 Then
                    cpt += 1
                Else
                    runningVB = False

                End If



            End While


            Dim dt1 As DateTime = DateCourant



            Dim dt2 As DateTime = Convert.ToDateTime(myReader1.Item(3))
            Dim ts As TimeSpan = dt2.Subtract(dt1)

            'MsgBox(myReader1.Item(0))

            Dim nbr = Convert.ToInt32(ts.Days) + 1

            nbr = nbr - 1


            Dim myCommand As New OleDb.OleDbCommand("Update check_preautorises set un = @un, deux = @deux, trois = @trois, quatre = @quatre, cinq = @cinq WHERE numero = @numero", myConnection)
            
            Select Case nbr
                Case Is <= 6
                    myCommand.Parameters.AddWithValue("@un", montant)
                    myCommand.Parameters.AddWithValue("@deux", 0)
                    myCommand.Parameters.AddWithValue("@trois", 0)
                    myCommand.Parameters.AddWithValue("@quatre", 0)
                    myCommand.Parameters.AddWithValue("@cinq", 0)
                Case 7 To 13
                    myCommand.Parameters.AddWithValue("@un", 0)
                    myCommand.Parameters.AddWithValue("@deux", montant)
                    myCommand.Parameters.AddWithValue("@trois", 0)
                    myCommand.Parameters.AddWithValue("@quatre", 0)
                    myCommand.Parameters.AddWithValue("@cinq", 0)
                Case 14 To 20
                    myCommand.Parameters.AddWithValue("@un", 0)
                    myCommand.Parameters.AddWithValue("@deux", 0)
                    myCommand.Parameters.AddWithValue("@trois", montant)
                    myCommand.Parameters.AddWithValue("@quatre", 0)
                    myCommand.Parameters.AddWithValue("@cinq", 0)
                Case 21 To 27
                    myCommand.Parameters.AddWithValue("@un", 0)
                    myCommand.Parameters.AddWithValue("@deux", 0)
                    myCommand.Parameters.AddWithValue("@trois", 0)
                    myCommand.Parameters.AddWithValue("@quatre", montant)
                    myCommand.Parameters.AddWithValue("@cinq", 0)
                Case Else
                    myCommand.Parameters.AddWithValue("@un", 0)
                    myCommand.Parameters.AddWithValue("@deux", 0)
                    myCommand.Parameters.AddWithValue("@trois", 0)
                    myCommand.Parameters.AddWithValue("@quatre", 0)
                    myCommand.Parameters.AddWithValue("@cinq", montant)
            End Select


            myCommand.Parameters.AddWithValue("@numero", valueIntConverted)


            myCommand.ExecuteNonQuery()

            'MsgBox("Update !!! ")


        End While

        myConnection.Close()


    End Sub



    Sub proc_depasse()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("SELECT * FROM check_preautorises WHERE payer = '" & "oui" & "'", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        Dim numero As Integer
        Dim no_date As Date

        While myReader1.Read
            'tab_periode = myReader.GetStri
            'montant = myReader.GetDouble(3)
            'check_oui = myReader.GetString(4)
            'MsgBox("count")
            numero = myReader1.GetInt32(0)
            no_date = myReader1.GetDateTime(3)
            Find_diff(numero, no_date)
        End While


    End Sub

    Function Find_diff(ByVal numero As Integer, ByVal un_date As Date)

        Dim diff As TimeSpan = un_date - DateCourant

        Dim days = diff.Days

        'MsgBox(days.ToString)

        Dim value As Integer = Integer.Parse(days.ToString)

        If value < 0 Then

            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("DELETE FROM check_preautorises WHERE numero = @numero", myConnection)
            myCommand.Parameters.AddWithValue("@numero", numero)
            myCommand.ExecuteNonQuery()
            myConnection.Close()


        End If

    End Function


    Sub proc_load_db()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM mensuel", myConnection)
        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

        Dim str_mensuel As String = ""


        Dim tab_periode As String
        Dim montant As Double
        Dim check_oui As String


        While myReader.Read
            'tab_periode = myReader.GetString(2)
            'montant = myReader.GetDouble(3)
            'check_oui = myReader.GetString(4)
            'MsgBox("count")
            no_lign = myReader.GetInt32(0)

            str_mensuel = str_mensuel + myReader.GetString(1) + "?"
            str_mensuel = str_mensuel + myReader.GetString(2) + "?"
            del_chaine = myReader.GetString(2)
            str_mensuel = str_mensuel + myReader.GetString(3) + "/"
            str_mensuel = str_mensuel + myReader.GetString(4) + "/"
            str_mensuel = str_mensuel + Convert.ToString(myReader.GetInt32(0))

            Lister.Add(str_mensuel)
            str_mensuel = ""


        End While

        'tableau = tab_periode.Split("?")

        'For count = 0 To tableau.Length - 1
        '    MsgBox(tableau(count))
        'Next

        For Each num In Lister
            'MsgBox(num)
            Tableau = num.Split("?")

            proc_noday_mensuel()
        Next

    End Sub

    Private Sub proc_noday_mensuel()

        Dim offset = New Date(1, 1, 1)

        Dim laDate As String = tableau(1)

        Dim time As Date = Date.Parse(laDate)

        Dim diff As TimeSpan = time - DateCourant

        Dim days = diff.Days

        'Dim days As Double = span.TotalDays

        'MsgBox(days.ToString)



        Dim lngth As Integer = tableau.Length()

        Dim lstrLastValue As String = tableau(lngth - 1)



        tab_rep = lstrLastValue.Split("/")


        'MsgBox(tab_rep(0))
        'MsgBox(tab_rep(1))
        'MsgBox(tab_rep(2))


        Dim value As Integer = Integer.Parse(days.ToString)

        'TODO num_lign
        no_lign = Integer.Parse(tab_rep(2))

 
        If value < 31 Then

            Try
                con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
                con.Open()
                'copier la connection string above
                'ouvrir la connection 
                'MsgBox("connection Ok")
                'sqlStr = "INSERT INTO Paiement_direct (description,Date,courant,7jrs,14jrs,21jrs) VALUES('" & ComboBox2.SelectedValue.ToString & "', 'bbb',1, 2, 3, 4)"
                'write the sql query

                Select Case value
                    Case 1 To 6
                        sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & tableau(0) & "','" & DateCourant & "' , '" & tableau(1) & "','" & tab_rep(0) & "', 0, 0, 0, 0,'" & "oui" & "')"
                    Case 7 To 13
                        sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & tableau(0) & "','" & DateCourant & "' , '" & tableau(1) & "',0, '" & tab_rep(0) & "', 0, 0, 0,'" & "oui" & "')"
                    Case 14 To 20
                        sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & tableau(0) & "','" & DateCourant & "' , '" & tableau(1) & "',0, 0, '" & tab_rep(0) & "', 0, 0,'" & "oui" & "')"
                    Case 21 To 27
                        sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & tableau(0) & "','" & DateCourant & "' , '" & tableau(1) & "',0, 0, 0, '" & tab_rep(0) & "', 0,'" & "oui" & "')"
                    Case Else
                        sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & tableau(0) & "','" & DateCourant & "' , '" & tableau(1) & "',0, 0, 0, 0, '" & tab_rep(0) & "','" & "oui" & "')"
                End Select


                ' sqlStr = "INSERT INTO check_direct (nom,quand,un,deux,trois,quatre) VALUES('" & ComboBox2.SelectedValue.ToString & "', '" & DateTimePicker1.Value.ToString() & "',1, 2, 3, 4)"
                cmd = New OleDb.OleDbCommand(sqlStr, con)

                cmd.ExecuteNonQuery()

                'MsgBox("Paiement ajoutée")
                'TODO proc_remove_string()
                proc_remove_string()
            Catch ex As Exception
                'MessageBox.Show("Vous devez choisir un fournisseur et indiquer le montant")

                con.Close()
            End Try
            'proc_load_db()


        End If

    End Sub


    Private Sub proc_remove_string()




        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        Dim oledbAdapter As New OleDb.OleDbDataAdapter
        myConnection.Open()

        del_chaine = del_chaine.Remove(0, 11)


        Dim myCommand As New OleDb.OleDbCommand("Update mensuel set date_mens = @description WHERE numero = @numero", myConnection)
        myCommand.Parameters.AddWithValue("@description", del_chaine)
        myCommand.Parameters.AddWithValue("@numero", no_lign)


        myCommand.ExecuteNonQuery()
        myConnection.Close()


    End Sub

End Class