Public Class frmLoginForm1


    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Public accounts As New Dictionary(Of String, String)


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Me.Close()
        If accounts.ContainsKey(UsernameTextBox.Text) Then
            Dim tempPassword As String = accounts.Item(UsernameTextBox.Text)
            If tempPassword = PasswordTextBox.Text Then
                'Me.Close()
                frmMenu.Show()


            Else
                MessageBox.Show("Passowrd pas correct!")
            End If
        Else
            MessageBox.Show("Username Erreur")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



    Private Sub frmLoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accounts.Add("Admin", "pass123")
        accounts.Add("Username", "password")
    End Sub
End Class
