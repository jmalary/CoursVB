Public Class frmChrono

    Dim temps As Date 'variable globale pour la feuille
    'compteur de type Date

    Private Sub frmChrono_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDemarrer_Click(sender As System.Object, e As System.EventArgs) Handles btnDemarrer.Click
        tmrChrono.Enabled = True
        btnArreter.Enabled = True
        btnDemarrer.Enabled = False
        btnReinst.Enabled = False ' si on démarre sans réiniatiliser
    End Sub

    Private Sub tmrChrono_Tick(sender As System.Object, e As System.EventArgs) Handles tmrChrono.Tick
        temps = temps.AddSeconds(1)
        lblChrono.Text = FormatDateTime(temps, DateFormat.LongTime)
    End Sub

    Private Sub btnArreter_Click(sender As System.Object, e As System.EventArgs) Handles btnArreter.Click
        tmrChrono.Enabled = False
        btnArreter.Enabled = False
        btnReinst.Enabled = True
        btnDemarrer.Enabled = True 'si on veut repartir le chrono sans réinistialiser
    End Sub

    Private Sub btnReinst_Click(sender As System.Object, e As System.EventArgs) Handles btnReinst.Click
        temps = Date.FromOADate(0)
        lblChrono.Text = "00:00:00"
        btnReinst.Enabled = False
        btnDemarrer.Enabled = True
    End Sub
End Class