Public Class frmNotepad
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'Check if there's text added to the textbox
        If TextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "New Document")
            If ask = MsgBoxResult.No Then
                TextBox1.Clear()
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                TextBox1.Clear()
            End If
            'If textbox's text is still the same, notepad will open a new page:
        Else
            TextBox1.Clear()
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Check if there's text added to the textbox
        If TextBox1.Modified Then
            'If the text of notepad changed, the program will ask the user if they want to save the changes
            Dim ask As MsgBoxResult
            ask = MsgBox("Do you want to save the changes", MsgBoxStyle.YesNoCancel, "Open Document")
            If ask = MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                SaveFileDialog1.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
                TextBox1.Clear()
            End If
        Else
            'If textbox's text is still the same, notepad will show the OpenFileDialog
            OpenFileDialog1.ShowDialog()
            Try
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()

        ' the application will check if the file is already exists, if exists, it will ask the user if they want to replace it

        If My.Computer.FileSystem.FileExists(SaveFileDialog1.FileName) Then

            Dim ask As MsgBoxResult

            ask = MsgBox("File already exists, would you like to replace it?", MsgBoxStyle.YesNo, "File Exists")

            'if the user decides not to replace the existing file

            If ask = MsgBoxResult.No Then

                SaveFileDialog1.ShowDialog()

                'if the user decides to replace the existing file

            ElseIf ask = MsgBoxResult.Yes Then

                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)

            End If

            'if the file doesn't exist

        Else
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
            Catch ex As Exception

            End Try




        End If

    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exit the program
        Me.Close()

        'End
    End Sub
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click

        'check if textbox can undo

        If TextBox1.CanUndo Then

            TextBox1.Undo()

        Else

        End If

    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click

        My.Computer.Clipboard.Clear()

        If TextBox1.SelectionLength > 0 Then

            My.Computer.Clipboard.SetText(TextBox1.SelectedText)



        End If

        TextBox1.SelectedText = ""

    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click



        My.Computer.Clipboard.Clear()

        If TextBox1.SelectionLength > 0 Then

            My.Computer.Clipboard.SetText(TextBox1.SelectedText)



        End If

    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click

        If My.Computer.Clipboard.ContainsText Then

            TextBox1.Paste()

        End If

    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click

        TextBox1.SelectAll()

    End Sub
    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click

        Dim a As String

        Dim b As String

        a = InputBox("Enter text to be found")

        b = InStr(TextBox1.Text, a)

        If b Then

            TextBox1.Focus()

            TextBox1.SelectionStart = b - 1

            TextBox1.SelectionLength = Len(a)

        Else

            MsgBox("Text not found.")

        End If



    End Sub
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click

        FontDialog1.ShowDialog()

        TextBox1.Font = FontDialog1.Font

    End Sub
    Private Sub FontColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColorToolStripMenuItem.Click

        ColorDialog1.ShowDialog()

        TextBox1.ForeColor = ColorDialog1.Color

    End Sub
    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click

        TextBox1.TextAlign = HorizontalAlignment.Left

        LeftToolStripMenuItem.Checked = True

        CenterToolStripMenuItem.Checked = False

        RightToolStripMenuItem.Checked = False



    End Sub
    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click

        TextBox1.TextAlign = HorizontalAlignment.Center

        LeftToolStripMenuItem.Checked = False

        CenterToolStripMenuItem.Checked = True

        RightToolStripMenuItem.Checked = False



    End Sub
    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click

        TextBox1.TextAlign = HorizontalAlignment.Right

        LeftToolStripMenuItem.Checked = False

        CenterToolStripMenuItem.Checked = False

        RightToolStripMenuItem.Checked = True

    End Sub
    Private Sub BackColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackColorToolStripMenuItem.Click

        ColorDialog1.ShowDialog()

        TextBox1.BackColor = ColorDialog1.Color

    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("Your Text")

    End Sub

    Private Sub frmNotepad_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        'Form_windows.FenêtreToolStripMenuItem.Visible = True

        Form_windows.FichierToolStripMenuItem.Visible = True

        Form_windows.OutilsToolStripMenuItem.Visible = True
        Form_windows.AideToolStripMenuItem.Visible = True
        Form_windows.SaisieAutomatiqueToolStripMenuItem.Visible = True
        Form_windows.SaisieManuelleToolStripMenuItem.Visible = True
        Form_windows.SaisieToolStripMenuItem.Visible = True

        Me.WindowState = FormWindowState.Maximized
        frmMenu.MdiParent = Form_windows

        frmMenu.Show()

    End Sub

    Private Sub frmNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form_windows.FenêtreToolStripMenuItem.Visible = False
        Form_windows.FichierToolStripMenuItem.Visible = False
        'Form_windows.ÉditionToolStripMenuItem.Visible = False
        Form_windows.OutilsToolStripMenuItem.Visible = False
        Form_windows.AideToolStripMenuItem.Visible = False
        Form_windows.SaisieAutomatiqueToolStripMenuItem.Visible = False
        Form_windows.SaisieManuelleToolStripMenuItem.Visible = False
        Form_windows.SaisieToolStripMenuItem.Visible = False



    End Sub

    Private Sub frmNotepad_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
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

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

  
    Private Sub ToolStripContainer1_TopToolStripPanel_Click(sender As Object, e As EventArgs) Handles ToolStripContainer1.TopToolStripPanel.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class
