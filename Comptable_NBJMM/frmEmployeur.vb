Imports System.Data.SqlClient
Imports Comptable_NBJMM.GlobalVariables

Public Class frmEmployeur

    Dim con As System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim sqlStr As String
    Dim myConnString As String = GlobalVariables.User_Access



    Dim con1 As SqlConnection

    Dim stcon As String
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private Sub btmAjouter_Click(sender As Object, e As EventArgs) Handles btmAjouter.Click

        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()
            'copier la connection string above
            'ouvrir la connection 
            ' MsgBox("connection Ok")
            sqlStr = "INSERT INTO employeur (description,adresse,ville) VALUES('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
            'write the sql query
            cmd = New OleDb.OleDbCommand(sqlStr, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record inserf ok")
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            proc_A()
        Catch ex As Exception
            MessageBox.Show("could not insert record")
            con.Close()
        End Try


    End Sub

    Sub proc_A()


        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM employeur", myConnection)
        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

        ListView1.Items.Clear()

        For Each selection As ListViewItem In ListView1.SelectedItems()

            If selection.Selected = True Then
                ListView1.SelectedItems.Clear()
            End If
        Next

        ListView1.Refresh()


        While myReader.Read

            Dim nom As String = myReader.GetString(1)

            If nom <> "Choisir un employeur" Then
                Dim newListViewItem As New ListViewItem
                newListViewItem.Text = myReader.GetInt32(0)
                newListViewItem.SubItems.Add(myReader.GetString(1))
                newListViewItem.SubItems.Add(myReader.GetString(2))
                newListViewItem.SubItems.Add(myReader.GetString(3))
                ListView1.Items.Add(newListViewItem)
            End If
        End While

        myConnection.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id As Integer
        id = Val(InputBox("Enter the emp id"))

        'id  contain the value of ID

        Try
            con = New System.Data.OleDb.OleDbConnection(GlobalVariables.User_Access)
            con.Open()
            'copier la connection string above
            'ouvrir la connection 
            'MsgBox("connection Ok")
            sqlStr = "Select * from employeur where numero=" & id & ""

            'write the sql query
            cmd = New OleDb.OleDbCommand(sqlStr, con)
            'cmd.ExecuteNonQuery()

            dr = cmd.ExecuteReader()
            If dr.HasRows = True Then
                While dr.Read()
                    TextBox1.Text = dr(0)
                    TextBox2.Text = dr(1)
                End While
            End If
            'ExecuteReader fo
            MsgBox("Record Found")
        Catch ex As Exception
            MessageBox.Show("could not find record")
            con.Close()
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""

        MsgBox("Please enter the data")

        TextBox1.Focus()

    End Sub

    Private Sub frmEmployeur_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows

        frmMenu.Show()

    End Sub

    Private Sub frmEmployeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.mdb;")
        'stcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.mdb;"
        'con1 = New SqlConnection(stcon)
        'con = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.mdb;")
        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM employeur", myConnection)
        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

        While myReader.Read

            'Dim nom As String companyCode = myReader.GetValue(0).ToString();
            Dim nom As String = myReader.GetString(1)

            If nom <> "Choisir un employeur" Then
                Dim newListViewItem As New ListViewItem
                newListViewItem.Text = myReader.GetInt32(0)
                newListViewItem.SubItems.Add(myReader.GetString(1))
                newListViewItem.SubItems.Add(myReader.GetString(2))
                newListViewItem.SubItems.Add(myReader.GetString(3))
                ListView1.Items.Add(newListViewItem)
            End If

        End While

        myConnection.Close()

        'con.Open()




        'sqlStr = "Select * from employeur"

        'cmd = New OleDb.OleDbCommand(sqlStr, con)
        'dr = cmd.ExecuteReader()

        ''da = New SqlDataAdapter("Select * from employeur ", con)
        ''cmd = New OleDb.OleDbCommand(sqlStr, con)
        'ds = New DataSet
        ''da.Fill(dr, "employeur")

        ''DataGridView1.DataMember = "employeur"
        ''DataGridView1.DataSource = cmd





        'add column
        'With Me.DataGridView1
        '    .Columns.Add("numero", "Numero")
        '    .Columns.Add("description", "Description")
        'End With

        ''define columns width

        'With Me.DataGridView1
        '    .Columns("numero").Width = 200
        '    .Columns("description").Width = 500

        'End With
        ''add data(10 rows)
        'For i As Integer = 1 To 5
        '    Me.DataGridView1.Rows.Add()
        '    With Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 2)
        '        .Cells("numero").Value = i
        '        .Cells("description").Value = "Description " & i
        '    End With

        'Next



    End Sub

    Private Sub btmRefresh_Click(sender As Object, e As EventArgs) Handles btmRefresh.Click

        Dim myConnection As New OleDb.OleDbConnection(myConnString)
        myConnection.Open()

        Dim myCommand As New OleDb.OleDbCommand("SELECT * FROM employeur", myConnection)
        Dim myReader As OleDb.OleDbDataReader = myCommand.ExecuteReader()

        For Each selection As ListViewItem In ListView1.SelectedItems()

            If selection.Selected = True Then
                ListView1.SelectedItems.Clear()
            End If
        Next
        ListView1.Refresh()


        While myReader.Read
            Dim newListViewItem As New ListViewItem
            newListViewItem.Text = myReader.GetInt32(0)
            newListViewItem.SubItems.Add(myReader.GetString(1))
            ListView1.Items.Add(newListViewItem)
        End While

        myConnection.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Dim myConnection As New OleDb.OleDbConnection(myConnString)
        'myConnection.Open()

        'Dim myCommand As New OleDb.OleDbCommand("UPDATE employeur SET numero = @numero, description = @description WHERE numero = @numero", myConnection)
        'myCommand.Parameters.AddWithValue("@description", TextBox2.Text)
        'myCommand.Parameters.AddWithValue("@numero", 1)

        'myCommand.ExecuteNonQuery()
        'myConnection.Close()


        If (ListView1.SelectedItems.Count > 0) Then
            'MsgBox(ListView1.SelectedItems(0).SubItems(0).Text)

            'frmUpdate_check.Show()
            Dim myConnection As New OleDb.OleDbConnection(myConnString)
            myConnection.Open()

            Dim myCommand As New OleDb.OleDbCommand("UPDATE employeur SET numero = @numero, description = @description WHERE numero = @numero", myConnection)
            myCommand.Parameters.AddWithValue("@description", TextBox2.Text)
            myCommand.Parameters.AddWithValue("@numero", 1)

            myCommand.ExecuteNonQuery()
            myConnection.Close()



        Else
            MessageBox.Show("please select an item to update")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (ListView1.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView1.SelectedItems
                Dim myConnection As New OleDb.OleDbConnection(myConnString)
                myConnection.Open()

                Dim myCommand As New OleDb.OleDbCommand("DELETE FROM employeur WHERE numero = @numero", myConnection)
                myCommand.Parameters.AddWithValue("@numero", i.Text)

                myCommand.ExecuteNonQuery()
                myConnection.Close()

                ListView1.Items.Remove(i)
            Next
        Else
            MessageBox.Show("s'il vous plaît sélectionner un élément à supprimer")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmMenu.Show()
        Me.Hide()

    End Sub

    Private Sub frmEmployeur_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
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
End Class