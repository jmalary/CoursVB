
Imports System.Data.OleDb
Imports Comptable_NBJMM.GlobalVariables




Public Class frmPaiement

    Public myConnToAccess As OleDbConnection
    Dim mySQLCommand As OleDbCommand
    Dim mySQLStrg As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection

    Dim myConnString As String = GlobalVariables.User_Access
    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlStr As String
    Dim tbxFocus As Boolean = False
    Dim lister As New ArrayList
    Dim tableau() As String
    Dim no_lign As Integer
    Dim tab_rep() As String
    Dim del_chaine As String



    Private Sub frmPaiement_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        Me.Close()
        frmListe_paiement_direct.Close()

        frmMenu.Show()


    End Sub

    Private Sub frmType_cheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myConnToAccess = New OleDbConnection(GlobalVariables.User_Access)
        myConnToAccess.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT description from employeur", myConnToAccess)
        da.Fill(ds, "employeur")
        Dim view1 As New DataView(tables(0))
        With ComboBox2
            .DataSource = ds.Tables("employeur")
            .DisplayMember = "description"
            .ValueMember = "description"
            .SelectedIndex = 0
            '.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        'Dim today = Date.Today
        Dim today = DateCourant

        Dim jour As String

        Dim day = today.Day

        Dim month = today.Month

        Dim years = today.Year

        ' MsgBox(Date.Today.DayOfWeek)


        Dim Mois As String

        Select Case Date.Today.DayOfWeek
            Case 0
                jour = "Dimanche"
            Case 1
                jour = "Lundi"
            Case 2
                jour = "Mardi"
            Case 3
                jour = "Mercredi"
            Case 4
                jour = "Jeudi"
            Case 5
                jour = "Vendredi"
            Case 6
                jour = "Samedi"

        End Select

        Select Case month
            Case 1
                Mois = "janvier"
            Case 2
                Mois = "février"
            Case 3
                Mois = "mars"
            Case 4
                Mois = "avril"
            Case 5
                Mois = "mai"
            Case 6
                Mois = "juin"
            Case 7
                Mois = "juillet"
            Case 8
                Mois = "aout"
            Case 9
                Mois = "septembre"
            Case 10
                Mois = "octobre"
            Case 11
                Mois = "novembre"
            Case 12
                Mois = "decembre"

        End Select

        Dim courant = String.Concat(jour, " ", day, " ", Mois, " ", years)

        'Label8.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Label2.Text = courant
        lblerreur.Text = ""

        Dim a As Byte
        ' for loop execution 
        For a = 0 To 30
            'Console.WriteLine("value of a: {0}", a)
            ComboBox3.Items.Add(a)
            ComboBox4.Items.Add(a)
        Next

        With ComboBox1
            .SelectedIndex = 0
        End With

        DateTimePicker2.Text = DateCourant


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim toto As String = ""

        If RadioButton4.Checked = False And RadioButton5.Checked = False Then

            MsgBox("Vous devez choisir le type de paiement")
        Else
            If ComboBox2.Text <> "Choisir un employeur" Then
                If RadioButton4.Checked = True Then
                    proc_A()
                Else
                    If ComboBox1.Text = "manuel" Then
                        proc_B()
                    ElseIf ComboBox1.Text = "mensuel" Then

                        proc_liste_mensuel()
                    Else
                        proc_liste_mi_mensuel()

                    End If
                End If

            Else
                MsgBox("Vous devez choisir le nom de fournisseur")
            End If
        End If


        





    End Sub

    Sub proc_A()
        'MsgBox("Paiement direct")

        Dim dt1 As DateTime = Date.Now

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)

        Dim nbr = Convert.ToInt32(ts.Days) + 1

        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()
            'copier la connection string above
            'ouvrir la connection 
            'MsgBox("connection Ok")
            'sqlStr = "INSERT INTO Paiement_direct (description,Date,courant,7jrs,14jrs,21jrs) VALUES('" & ComboBox2.SelectedValue.ToString & "', 'bbb',1, 2, 3, 4)"
            'write the sql query

            Select Case nbr
                Case 0 To 6
                    sqlStr = "INSERT INTO check_direct (nom,quand,date_paiement,un,deux,trois,quatre,cinq) VALUES('" & ComboBox2.SelectedValue.ToString & "', '" & Date.Now & "' ,'" & DateTimePicker2.Value.ToString() & "','" & TextBox1.Text & "', 0, 0, 0, 0)"
                Case 7 To 13
                    sqlStr = "INSERT INTO check_direct (nom,quand,date_paiement,un,deux,trois,quatre,cinq) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & Date.Now & "' , '" & DateTimePicker2.Value.ToString() & "',0, '" & TextBox1.Text & "', 0, 0, 0)"
                Case 14 To 20
                    sqlStr = "INSERT INTO check_direct (nom,quand,date_paiement,un,deux,trois,quatre,cinq) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & Date.Now & "' , '" & DateTimePicker2.Value.ToString() & "',0, 0, '" & TextBox1.Text & "', 0, 0)"
                Case 21 To 27
                    sqlStr = "INSERT INTO check_direct (nom,quand,date_paiement,un,deux,trois,quatre,cinq) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & Date.Now & "' , '" & DateTimePicker2.Value.ToString() & "',0, 0, 0, '" & TextBox1.Text & "', 0)"
                Case Else
                    sqlStr = "INSERT INTO check_direct (nom,quand,date_paiement,un,deux,trois,quatre,cinq) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & Date.Now & "' , '" & DateTimePicker2.Value.ToString() & "',0, 0, 0, 0, '" & TextBox1.Text & "')"
            End Select


            ' sqlStr = "INSERT INTO check_direct (nom,quand,un,deux,trois,quatre) VALUES('" & ComboBox2.SelectedValue.ToString & "', '" & DateTimePicker1.Value.ToString() & "',1, 2, 3, 4)"
            cmd = New OleDb.OleDbCommand(sqlStr, con)

            cmd.ExecuteNonQuery()
            lblerreur.Text = ""
            MsgBox("Paiement direct ajoutée 1")
            'MsgBox(DateTimePicker1.Value.Day)

            TextBox1.Text = " "
            ComboBox2.SelectedIndex = 0
            DateTimePicker2.Value = DateCourant


        Catch ex As Exception
            'MessageBox.Show("Vous devez choisir un fournisseur")
            lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"

            con.Close()
        End Try

    End Sub

    Sub proc_B()

        Dim dt1 As DateTime = Date.Now

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)

        Dim nbr = Convert.ToInt32(ts.Days) + 1


        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()
            'copier la connection string above
            'ouvrir la connection 
            'MsgBox("connection Ok")
            'sqlStr = "INSERT INTO Paiement_direct (description,Date,courant,7jrs,14jrs,21jrs) VALUES('" & ComboBox2.SelectedValue.ToString & "', 'bbb',1, 2, 3, 4)"
            'write the sql query

            Select Case nbr
                Case 1 To 6
                    sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & DateCourant & "' , '" & DateTimePicker2.Value.ToString() & "','" & TextBox1.Text & "', 0, 0, 0, 0,'" & "non" & "')"
                Case 7 To 13
                    sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & DateCourant & "' , '" & DateTimePicker2.Value.ToString() & "',0, '" & TextBox1.Text & "', 0, 0, 0,'" & "non" & "')"
                Case 14 To 20
                    sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & DateCourant & "' , '" & DateTimePicker2.Value.ToString() & "',0, 0, '" & TextBox1.Text & "', 0, 0,'" & "non" & "')"
                Case 21 To 27
                    sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & DateCourant & "' , '" & DateTimePicker2.Value.ToString() & "',0, 0, 0, '" & TextBox1.Text & "', 0,'" & "non" & "')"
                Case Else
                    sqlStr = "INSERT INTO check_preautorises (nom,quand,date_paiement,un,deux,trois,quatre,cinq, payer) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & DateCourant & "' , '" & DateTimePicker2.Value.ToString() & "',0, 0, 0, 0, '" & TextBox1.Text & "'7)"
            End Select


            ' sqlStr = "INSERT INTO check_direct (nom,quand,un,deux,trois,quatre) VALUES('" & ComboBox2.SelectedValue.ToString & "', '" & DateTimePicker1.Value.ToString() & "',1, 2, 3, 4)"
            cmd = New OleDb.OleDbCommand(sqlStr, con)

            cmd.ExecuteNonQuery()
            'MsgBox("Data insert")
            lblerreur.Text = ""
            MsgBox("Paiement préautorise manuel ajoutée")
            TextBox1.Text = " "
            ComboBox2.SelectedIndex = 0
            DateTimePicker2.Value = DateCourant

            'MsgBox(DateTimePicker1.Value.Day)
        Catch ex As Exception
            'MessageBox.Show("Vous devez choisir un fournisseur et indiquer le montant")
            lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
            con.Close()
        End Try

    End Sub

   


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'frmListe_paiement_direct.Close()

        frmMenu.Show()



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim allowedChars As String = "0123456789,"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf(","c) > -1 Then
            e.Handled = True
        End If


    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not IsNumeric(TextBox1.Text) Then
            'TextBox1.Text = ""
            'MessageBox.Show("nombre non valide")
            lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
            TextBox1.BackColor = Color.IndianRed



        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not IsNumeric(TextBox1.Text) Then
            'TextBox1.Text = ""
            'MessageBox.Show("nombre non valide")
            lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
            TextBox1.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not IsNumeric(TextBox1.Text) Then
            'TextBox1.Text = ""
            'MessageBox.Show("nombre non valide  ")
            lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
            TextBox1.BackColor = Color.IndianRed

        End If
    End Sub


    Private Sub frmPaiement_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
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

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        Panel2.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> Nothing = True Then
            ToolTip1.SetToolTip(TextBox1, "Entrez votre monétaire" & TextBox1.Text)
        Else
            ToolTip1.SetToolTip(TextBox1, "Videz champ" & TextBox1.Text)
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        If ComboBox1.Text = "manuel" Then

            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            DateTimePicker2.Enabled = True


        ElseIf ComboBox1.Text = "mensuel" Then

            ComboBox3.Enabled = True
            ComboBox4.Enabled = False
            DateTimePicker2.Enabled = False
        Else

            ComboBox3.Enabled = True
            ComboBox4.Enabled = True
            DateTimePicker2.Enabled = False


        End If


    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        Panel2.Visible = False

    End Sub

    Private Sub proc_liste_mensuel()

        Dim une_date As Date
        Dim lister As New List(Of Date)

        Dim date_courant As Date = Date.Now

        Dim NoJrs = date_courant.Day

        
        Dim newDate As Date = DateCourant

        Dim NumMonth As Integer = newDate.Month
        Dim NumDay As Integer = DateCourant.Day


        If NumDay < ComboBox3.Text Then
            'newDate.Day = ComboBox3.Text
            newDate = New Date(DateCourant.Year.ToString, DateCourant.Month.ToString, ComboBox3.Text)

            lister.Add(newDate)

        End If




        newDate = newDate.AddMonths(1)

        newDate = New Date(DateCourant.Year.ToString, newDate.Month.ToString, ComboBox3.Text)

        NumMonth = newDate.Month

        While NumMonth <> 4

            lister.Add(newDate)
            newDate = newDate.AddMonths(1)
            
            NumMonth = newDate.Month
        End While

       
        ' Get array of objects.
        Dim tab_dates As String = New String("")


        For Each element In lister
            ' Cast object to string.
            Dim value As Date = element
            'Console.WriteLine(value)

            tab_dates = tab_dates + value.Date + "?"

        Next



        tab_dates = tab_dates.Remove(tab_dates.Length - 1)

        Dim check_paiment As String = "non"

        If CheckBox1.Checked Then
            check_paiment = "oui"
        End If


        'TODO ajlaouter la liste des paiement selon le paiement mensuel

        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()

            Dim str As String = TextBox1.Text
            str = str.Remove(0, 2)



            sqlStr = "INSERT INTO mensuel (description,date_mens,montant, paiement) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & tab_dates & "' , '" & str & "', '" & check_paiment & "' )"

            cmd = New OleDb.OleDbCommand(sqlStr, con)

            cmd.ExecuteNonQuery()
            MsgBox("Paiement autorisé mensuel")
            TextBox1.Text = " "
            ComboBox2.SelectedIndex = 0
            'DateTimePicker2.Value = DateCourant
            ComboBox3.SelectedIndex = 1
        Catch ex As Exception
            'MessageBox.Show("Vous devez choisir un fournisseur et indiquer le montant")
            'lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
            MsgBox("FAIL")
            con.Close()
        End Try

        charger_lister()


    End Sub

    Private Sub proc_liste_mi_mensuel()

        'TODO proc_mens_bi


        Dim une_date As Date
        Dim lister As New List(Of Date)

        Dim date_courant As Date = Date.Now

        Dim NoJrs = date_courant.Day

        'MsgBox(DateTime.Now.AddMonths(1))

        'Dim newDate As DateTime = DateTime.Now.AddMonths(1)

        Dim newDate1 As Date = DateCourant
        Dim newDate2 As Date = DateCourant


        Dim NumMonth1 As Integer = newDate1.Month
        Dim NumMonth2 As Integer = newDate2.Month


        Dim NumDay As Integer = DateCourant.Day


        If NumDay < ComboBox3.Text Then
            'newDate.Day = ComboBox3.Text
            newDate1 = New Date(DateCourant.Year.ToString, DateCourant.Month.ToString, ComboBox3.Text)
            newDate2 = New Date(DateCourant.Year.ToString, DateCourant.Month.ToString, ComboBox4.Text)

            lister.Add(newDate1)
            lister.Add(newDate2)
        ElseIf NumDay < ComboBox4.Text Then

            newDate2 = New Date(DateCourant.Year.ToString, DateCourant.Month.ToString, ComboBox4.Text)
            lister.Add(newDate2)

        End If


        newDate1 = newDate1.AddMonths(1)
        newDate2 = newDate2.AddMonths(1)

        newDate1 = New Date(DateCourant.Year.ToString, newDate1.Month.ToString, ComboBox3.Text)
        newDate2 = New Date(DateCourant.Year.ToString, newDate2.Month.ToString, ComboBox4.Text)


        NumMonth1 = newDate1.Month
        NumMonth2 = newDate2.Month

        While NumMonth2 <> 4

            lister.Add(newDate1)
            lister.Add(newDate2)
            newDate1 = newDate1.AddMonths(1)
            newDate2 = newDate2.AddMonths(1)

            NumMonth1 = newDate1.Month
            NumMonth2 = newDate2.Month
        End While

        ' Get array of objects.
        Dim tab_dates As String = New String("")


        For Each element In lister
            ' Cast object to string.
            Dim value As Date = element
            'Console.WriteLine(value)
            'MsgBox(value.Date)
            tab_dates = tab_dates + value.Date + "?"

        Next



        tab_dates = tab_dates.Remove(tab_dates.Length - 1)

        Dim check_paiment As String = "non"

        If CheckBox1.Checked Then
            check_paiment = "oui"
        End If



        'TODO ajlaouter la liste des paiement selon le paiement mensuel
        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()

            Dim str As String = TextBox1.Text
            str = str.Remove(0, 2)
            'MsgBox(str)

            sqlStr = "INSERT INTO mensuel (description,date_mens,montant, paiement) VALUES('" & ComboBox2.SelectedValue.ToString & "','" & tab_dates & "' , '" & str & "', '" & check_paiment & "' )"

            cmd = New OleDb.OleDbCommand(sqlStr, con)

            cmd.ExecuteNonQuery()


            'lblerreur.Text = ""

            'MsgBox(DateTimePicker1.Value.Day)
        Catch ex As Exception
            'MessageBox.Show("Vous devez choisir un fournisseur et indiquer le montant")
            'lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
            MsgBox("FAIL")
            con.Close()
        End Try

        MsgBox("C'est confirmé update pour le mi-mensuel")

      
        charger_lister()


    End Sub


    Private Sub Load_form()

    End Sub

    Private Sub charger_lister()
        'TODO charger_lister
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

            lister.Add(str_mensuel)
            str_mensuel = ""


        End While

        'tableau = tab_periode.Split("?")

        'For count = 0 To tableau.Length - 1
        '    MsgBox(tableau(count))
        'Next

        For Each num In lister
            'MsgBox(num)
            tableau = num.Split("?")

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

        Dim check_paiment As String = "non"

        If CheckBox1.Checked Then
            check_paiment = "oui"
        End If

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
                lblerreur.Text = ""
                'MsgBox("Paiement ajoutée1")
                'TODO proc_remove_string()
                proc_remove_string()


            Catch ex As Exception
                'MessageBox.Show("Vous devez choisir un fournisseur et indiquer le montant")
                lblerreur.Text = "Veuillez entrer un montant en utilisant " & ControlChars.NewLine & "le format suivant comme exemple : 120,00"
                con.Close()
            End Try
            'TODO remove string
            'frmMenu.proc_load_db()
            frmMenu.proc_load_db()

        End If
        'Dim lngth As Integer = tableau.Length

        ComboBox2.SelectedIndex = 0
        'DateTimePicker2.Value = DateCourant
        ComboBox3.SelectedIndex = 1
        ComboBox4.SelectedIndex = 2








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
        'MsgBox("Update !!! ")

    End Sub

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



End Class