Public Class GlobalVariables
#Region "données membres"
    'Public Shared User_Access As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\test2.mdb;"
    Public Shared User_Access As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.mdb;"


    Public Shared DateCourant As Date = Date.Today

    Public Shared debut As DateTime

    Public Shared demarrage As Boolean = True



    'Dim date1 As Date
#End Region

#Region "constructeur et destructeur"
    Public Sub New()
        User_Access = ""
        MessageBox.Show("Constructeur")

    End Sub

    Public Sub New(ByVal n As String)
        User_Access = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\test2.mdb;"
        MsgBox("const")
    End Sub

    Protected Overrides Sub Finalize()
        MsgBox("Destructeur")
    End Sub
#End Region



End Class
