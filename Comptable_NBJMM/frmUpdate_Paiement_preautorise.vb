Imports System.Data.OleDb
Imports Comptable_NBJMM.GlobalVariables


Public Class frmUpdate_Paiement_preautorise
    Dim myConnString As String = GlobalVariables.User_Access
    Public myConnToAccess As OleDbConnection
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection
    Dim Courant_now As DateTime


    Private Sub frmUpdate_Paiement_preautorise_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim numero As String = frmAfficherListePaiementPreautorise.ListView1.SelectedItems(0).SubItems(0).Text
        'Dim numero As String = Label2.Text

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM check_preautorises where numero = " & numero & "", myConnection)

        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

        Dim nombre As Integer

        getListe()
        While myReader.Read
            Dim newListViewItem As New ListViewItem

            Label11.Text = myReader.GetDateTime(2)

            getdate()

            DateTimePicker1.Text = myReader.GetDateTime(3)

            Dim index As Integer
            index = ComboBox1.FindString(myReader.GetString(1))
            ComboBox1.SelectedIndex = index

            'TextBox2.Text = myReader.GetInt32(4)
            Dim compte As Integer = 5

            If myReader.GetValue(4) <> 0 Then
                TextBox3.Text = Format$(myReader.GetValue(4), "Currency")
            ElseIf myReader.GetValue(5) <> 0 Then
                TextBox3.Text = Format$(myReader.GetValue(5), "Currency")
            ElseIf myReader.GetValue(6) <> 0 Then
                TextBox3.Text = Format$(myReader.GetValue(6), "Currency")
            ElseIf myReader.GetValue(7) <> 0 Then
                TextBox3.Text = Format$(myReader.GetValue(7), "Currency")
            Else
                TextBox3.Text = Format$(myReader.GetValue(8), "Currency")
            End If

            'MsgBox(myReader.GetValue(5))
        End While

    End Sub

    Sub getListe()
        myConnToAccess = New OleDbConnection(GlobalVariables.User_Access)
        myConnToAccess.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT description from employeur", myConnToAccess)
        da.Fill(ds, "employeur")
        Dim view1 As New DataView(tables(0))
        With ComboBox1
            .DataSource = ds.Tables("employeur")
            .DisplayMember = "description"
            .ValueMember = "description"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Sub getdate()

        Dim jour As String

        Dim quand As Date = Label11.Text


        Courant_now = quand

        Dim day = quand.Day

        Dim month = quand.Month

        Dim years = quand.Year

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

        Label11.Text = courant


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        Dim oledbAdapter As New OleDb.OleDbDataAdapter
        myConnection.Open()

        MsgBox(Label8.Text)

        Dim dt1 As DateTime = courant_now 

        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)

        Dim nbr = Convert.ToInt32(ts.Days) + 1



        Dim myCommand As New OleDb.OleDbCommand("update check_preautorises set nom = @description, date_paiement = @date_paiement, un = @un, deux = @deux, trois = @trois, quatre = @quatre WHERE numero = @numero", myConnection)
        myCommand.Parameters.AddWithValue("@description", ComboBox2.SelectedValue.ToString)
        myCommand.Parameters.AddWithValue("@date_paiement", DateTimePicker2.Value.ToString())

        Select Case nbr
            Case 1 To 6
                myCommand.Parameters.AddWithValue("@un", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case 7 To 13
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case 14 To 20
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case 21 To 27
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case Else
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", TextBox1.Text)
        End Select

        myCommand.Parameters.AddWithValue("@numero", Label2.Text)


        myCommand.ExecuteNonQuery()
        myConnection.Close()
        MsgBox("Update !!! ")


        frmAfficherListePaiementPreautorise.Show()


        Me.Close()




    End Sub

    Private Sub frmUpdate_check_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        Dim oledbAdapter As New OleDb.OleDbDataAdapter
        myConnection.Open()


        Dim dt1 As DateTime = Courant_now


        Dim dt2 As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim ts As TimeSpan = dt2.Subtract(dt1)

        Dim nbr = Convert.ToInt32(ts.Days) + 1



        Dim myCommand As New OleDb.OleDbCommand("Update check_preautorises set nom = @description, date_paiement = @date_paiement, un = @un, deux = @deux, trois = @trois, quatre = @quatre, cinq = @cinq WHERE numero = @numero", myConnection)
        myCommand.Parameters.AddWithValue("@description", ComboBox1.SelectedValue.ToString)
        myCommand.Parameters.AddWithValue("@date_paiement", DateTimePicker1.Value.ToString())

        Select Case nbr
            Case 1 To 6
                myCommand.Parameters.AddWithValue("@un", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case 7 To 13
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case 14 To 20
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case 21 To 27
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", TextBox3.Text)
                myCommand.Parameters.AddWithValue("@cinq", 0)
            Case Else
                myCommand.Parameters.AddWithValue("@un", 0)
                myCommand.Parameters.AddWithValue("@deux", 0)
                myCommand.Parameters.AddWithValue("@trois", 0)
                myCommand.Parameters.AddWithValue("@quatre", 0)
                myCommand.Parameters.AddWithValue("@cinq", TextBox3.Text)
        End Select


        myCommand.Parameters.AddWithValue("@numero", Label7.Text)


        myCommand.ExecuteNonQuery()
        myConnection.Close()
        MsgBox("Update !!! ")


        Me.WindowState = FormWindowState.Maximized
        frmAfficherListePaiementPreautorise.MdiParent = Form_windows
        frmAfficherListePaiementPreautorise.Show()
        'frmLoading.Show()




        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Maximized
        frmAfficherListePaiementPreautorise.MdiParent = Form_windows
        frmAfficherListePaiementPreautorise.Show()
        'frmLoading.Show()




        Me.Close()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim allowedChars As String = "0123456789,"
        If allowedChars.IndexOf(e.KeyChar) = -1 AndAlso
            Not e.KeyChar = ChrW(8) Then
            ' Invalid Character
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class