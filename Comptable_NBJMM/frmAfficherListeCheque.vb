Imports Comptable_NBJMM.GlobalVariables
Imports System.Data.OleDb

Public Class frmAfficherListeCheque
    Public myConnToAccess As OleDbConnection
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection

    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader

    Dim sqlStr As String
    'Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.mdb;"




    Dim myConnString As String = GlobalVariables.User_Access

    Private Sub frmAfficherListeCheque_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows

        frmMenu.Show()
    End Sub

   




    Private Sub frmAfficherListeCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        ChargerLister()


    End Sub



    Sub ChargerLister()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM check_emis", myConnection)
        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()


        Dim value1 As String = "xxxxxxxxx"

        While myReader.Read
            Dim newListViewItem As New ListViewItem

            newListViewItem.Text = myReader.GetInt32(0)
            newListViewItem.SubItems.Add(myReader.GetString(1))



            '*************************************************************************************

            Dim today = myReader.GetDateTime(2)

            Dim jour As String

            Dim day = today.Day

            Dim month = today.Month

            Dim years = today.Year

            ' MsgBox(Date.Today.DayOfWeek)


            Dim Mois As String

            Select Case today.DayOfWeek
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

            newListViewItem.SubItems.Add(courant)

            '*************************************************************************************

            today = myReader.GetDateTime(3)



            day = today.Day

            month = today.Month

            years = today.Year

            ' MsgBox(Date.Today.DayOfWeek)




            Select Case today.DayOfWeek
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

            courant = String.Concat(jour, " ", day, " ", Mois, " ", years)

            newListViewItem.SubItems.Add(courant)


            '*************************************************************************************


            newListViewItem.SubItems.Add(myReader.GetInt32(4))

            newListViewItem.SubItems.Add(Format$(myReader.GetDouble(5), "Currency"))
            newListViewItem.SubItems.Add(Format$(myReader.GetDouble(6), "Currency"))
            newListViewItem.SubItems.Add(Format$(myReader.GetDouble(7), "Currency"))
            newListViewItem.SubItems.Add(Format$(myReader.GetDouble(8), "Currency"))
            newListViewItem.SubItems.Add(Format$(myReader.GetDouble(9), "Currency"))
            ListView1.Items.Add(newListViewItem)
        End While

        If ListView1.Items.Count = 0 Then
            proc_zero()
        Else
            proc_A()
            proc_B()
            proc_C()
            proc_D()
            proc_E()

        End If

        'proc_A()
        'proc_B()
        'proc_C()
        'proc_D()
        'proc_E()


        myConnection.Close()

        proc_Vider()


    End Sub


    Sub proc_A()
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(un) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()





        While myReader1.Read
            Label2.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

    End Sub

    Sub proc_B()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(deux) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        While myReader1.Read
            Label3.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While

    End Sub

    Sub proc_C()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(trois) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()


        While myReader1.Read
            Label4.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While


    End Sub

    Sub proc_D()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(quatre) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

       

        While myReader1.Read
            Label5.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While


    End Sub

    Sub proc_E()

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()
        Dim myCommand1 As New OleDb.OleDbCommand("Select sum(cinq) from check_emis", myConnection)
        Dim myReader1 As OleDb.OleDbDataReader = myCommand1.ExecuteReader()

        

        While myReader1.Read
            Label7.Text = Format$(myReader1.Item(0).ToString, "Currency")
        End While


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'frmMenu.Show()
        Me.Close()



        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows
        frmMenu.Show()



    End Sub

    Sub proc_zero()

        Label2.Text = "0.00 $"
        Label3.Text = "0.00 $"
        Label4.Text = "0.00 $"
        Label5.Text = "0.00 $"

        Label7.Text = "0.00 $"


    End Sub


    Sub proc_Vider()



        myConnToAccess = New OleDbConnection(GlobalVariables.User_Access)
        myConnToAccess.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT numero from check_emis", myConnToAccess)
        da.Fill(ds, "employeur")
        myConnToAccess.Dispose()

        myConnToAccess = Nothing



        Dim quantity As Integer = ds.Tables.Count

        'If ds.Tables.Count > 0 Then

        '    quantity += 1
        '    'MsgBox(ds.Tables(0).Rows(-1).Item(0))
        '    MsgBox(ds.Tables(0).Rows(quantity).Item(0))
        'Else

        '    MsgBox("aucunn")
        'End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        If (ListView1.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView1.SelectedItems
                Dim myConnection As New OleDb.OleDbConnection(myConnString)
                myConnection.Open()

                Dim myCommand As New OleDb.OleDbCommand("DELETE FROM check_emis WHERE numero = @numero", myConnection)
                myCommand.Parameters.AddWithValue("@numero", i.Text)

                myCommand.ExecuteNonQuery()
                myConnection.Close()

                ListView1.Items.Remove(i)


                If ListView1.Items.Count = 0 Then
                    proc_zero()
                Else
                    proc_A()
                    proc_B()
                    proc_C()
                    proc_D()
                    proc_E()
                    MsgBox("Element supprimé")
                End If

                'proc_A()
                'proc_B()
                'proc_C()
                'proc_D()
                'proc_E()
                'MsgBox("Element supprimé")
            Next
        Else
            MessageBox.Show("s'il vous plaît sélectionner un élément à supprimer")
        End If
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (ListView1.SelectedItems.Count > 0) Then

            frmUpdate_check.Show()
            frmUpdate_check.Label2.Text = ListView1.SelectedItems(0).SubItems(0).Text
            Me.Close()
            frmMenu.Close()

            frmUpdate_check.MdiParent = Form_windows
            frmUpdate_check.Show()

        Else
            MessageBox.Show("s'il vous plaît sélectionner un élément à mettre à jour")
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub frmListe_cheque_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged



        'Dim x As Integer
        'Dim y As Integer
        'Dim r As Rectangle

        'If Not Parent Is Nothing Then
        '    r = Parent.ClientRectangle
        '    x = r.Width - Me.Width + Parent.Left
        '    y = r.Height - Me.Height + Parent.Top
        'Else
        '    r = Screen.PrimaryScreen.WorkingArea
        '    x = r.Width - Me.Width
        '    y = r.Height - Me.Height
        'End If

        'x = CInt(x / 2)
        'y = CInt(y / 2)

        'Me.StartPosition = FormStartPosition.Manual
        'Me.Location = New Point(x, y)
    End Sub


    'Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles ListView1.ColumnWidthChanging
    '    e.Cancel = True;
    '    If e.ColumnIndex = 0 AndAlso ListView1.Columns(e.ColumnIndex).Width <> 10 Then
    '        ListView1.Columns(e.ColumnIndex).Width = 10
    '    End If

    'End Sub


    Private Sub listView1_ColumnWidthChanging(ByVal sender As Object, ByVal e As ColumnWidthChangingEventArgs)
        MsgBox("click")
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub



    Private Sub listView1_ColumnWidthChanged(ByVal sender As Object, ByVal e As ColumnWidthChangedEventArgs)
        MsgBox("click")
        If e.ColumnIndex = 0 AndAlso ListView1.Columns(e.ColumnIndex).Width <> 10 Then
            ListView1.Columns(e.ColumnIndex).Width = 10
        End If
    End Sub

   
    
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'MsgBox("clickl")
      


    End Sub
    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        'Dim lvi As ListViewItem = ListView1.HitTest(e.Location).Item
        'If lvi IsNot Nothing Then
        '    'Process.Start(lvi.SubItems(1).Text)
        '    MsgBox(lvi.SubItems(1).Text)
        'End If
        'For Each lvi As ListViewItem In ListView1.SelectedItems
        '    lvi.BackColor = Color.LightSteelBlue

        'Next

    End Sub

    



    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click

        Dim tmpClor As String
        tmpClor = "Blue"
       
        'MsgBox(ListView1.SelectedItems(0).Text)
        Dim numero As Integer = ListView1.SelectedItems(0).Text
        'ListView1.Items(numero).SubItems.Item(1).Text = "aas"
        'ListView1.Items(numero).BackColor = Color.Red

        Dim itm As ListViewItem


        'With ListView1

        '    itm = .FindItemWithText(numero, False, 0, True)
        '    If Not itm Is Nothing Then
        '        .Items(itm.Index).Selected = True
        '        ListView1.Items(itm.Index).BackColor = Color.LightBlue

        '    End If
        'End With
        'MsgBox(itm)



    End Sub

   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As Double
        id = Val(InputBox("Entrez le montant"))

        'id  contain the value of ID

        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()
            'copier la connection string above
            'ouvrir la connection 
            'MsgBox("connection Ok")
            sqlStr = "Select * from check_emis where un=" & id & ""

            'write the sql query
            cmd = New OleDb.OleDbCommand(sqlStr, con)
            'cmd.ExecuteNonQuery()

            dr = cmd.ExecuteReader()
            If dr.HasRows = True Then
                While dr.Read()
                    'TextBox1.Text = dr(0)
                    'TextBox2.Text = dr(1)
                End While
            End If
            'ExecuteReader fo
            MsgBox("Record Found")
        Catch ex As Exception
            MessageBox.Show("could not find record")
            con.Close()
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        'Dim I As Integer
        If (ListView1.SelectedItems.Count > 0) Then
            Dim a = MsgBox("Vous etes certain de supprimer quelques entrée ?", MsgBoxStyle.YesNo, "Confirmation")
            If a = vbYes Then

                For Each i As ListViewItem In ListView1.SelectedItems
                    Dim myConnection As New OleDb.OleDbConnection(myConnString)
                    myConnection.Open()

                    Dim myCommand As New OleDb.OleDbCommand("DELETE FROM check_emis WHERE numero = @numero", myConnection)
                    myCommand.Parameters.AddWithValue("@numero", i.Text)
                    myCommand.ExecuteNonQuery()
                    myConnection.Close()

                    ListView1.Items.Remove(i)

                Next

            End If

            If ListView1.Items.Count = 0 Then
                proc_zero()
            Else
                proc_A()
                proc_B()
                proc_C()
                proc_D()
                proc_E()

            End If


          
        Else
            MessageBox.Show("s'il vous plaît sélectionner un élément à supprimer")
        End If


    End Sub
End Class
