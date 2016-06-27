Public Class frmMenu

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        
    End Sub

    Private Sub lblQuiz_Click(sender As System.Object, e As System.EventArgs) Handles lblQuiz.Click
        
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        
    End Sub


    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dock = DockStyle.Fill
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        frmQuiz.Show()
        frmQuiz.MdiParent = Form1
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        frmTable.Show()
        frmTable.MdiParent = Form1
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        frmFraction.Show()
        frmFraction.MdiParent = Form1
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        frmCalculatrice.Show()
        frmCalculatrice.MdiParent = Form1
        Me.Hide()
    End Sub
End Class
