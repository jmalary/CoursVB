Public Class frmHorloge

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles lblHorloge.Click

    End Sub

    Private Sub frmHorloge_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblHorloge.Text = FormatDateTime(Date.Now, DateFormat.LongTime)
    End Sub

    Private Sub tmrHorloge_Tick(sender As System.Object, e As System.EventArgs) Handles tmrHorloge.Tick
        lblHorloge.Text = FormatDateTime(Date.Now, DateFormat.LongTime)
    End Sub
End Class