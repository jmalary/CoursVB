<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx04_Mod2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btmEclair = New System.Windows.Forms.Button()
        Me.btmStop = New System.Windows.Forms.Button()
        Me.btmPompiers = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lblchange)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(30, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 343)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Devoir3.My.Resources.Resources.pompier3
        Me.PictureBox5.Location = New System.Drawing.Point(52, 265)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 71)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Devoir3.My.Resources.Resources.pompier3
        Me.PictureBox4.Location = New System.Drawing.Point(52, 162)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 81)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Devoir3.My.Resources.Resources.Feu_5
        Me.PictureBox3.Location = New System.Drawing.Point(172, 238)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(122, 98)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Location = New System.Drawing.Point(178, 23)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(25, 13)
        Me.lblchange.TabIndex = 5
        Me.lblchange.Text = "true"
        Me.lblchange.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox2.Image = Global.Devoir3.My.Resources.Resources.bmparbre
        Me.PictureBox2.Location = New System.Drawing.Point(158, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(155, 126)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Devoir3.My.Resources.Resources.nuage0
        Me.PictureBox1.Location = New System.Drawing.Point(283, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btmEclair
        '
        Me.btmEclair.Location = New System.Drawing.Point(482, 32)
        Me.btmEclair.Name = "btmEclair"
        Me.btmEclair.Size = New System.Drawing.Size(122, 38)
        Me.btmEclair.TabIndex = 0
        Me.btmEclair.Text = "Eclair"
        Me.btmEclair.UseVisualStyleBackColor = True
        '
        'btmStop
        '
        Me.btmStop.Enabled = False
        Me.btmStop.Location = New System.Drawing.Point(482, 76)
        Me.btmStop.Name = "btmStop"
        Me.btmStop.Size = New System.Drawing.Size(122, 42)
        Me.btmStop.TabIndex = 1
        Me.btmStop.Text = "Stop"
        Me.btmStop.UseVisualStyleBackColor = True
        '
        'btmPompiers
        '
        Me.btmPompiers.Enabled = False
        Me.btmPompiers.Location = New System.Drawing.Point(482, 133)
        Me.btmPompiers.Name = "btmPompiers"
        Me.btmPompiers.Size = New System.Drawing.Size(122, 39)
        Me.btmPompiers.TabIndex = 2
        Me.btmPompiers.Text = "Pompier"
        Me.btmPompiers.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Timer3
        '
        '
        'frmEx04_Mod2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 416)
        Me.Controls.Add(Me.btmPompiers)
        Me.Controls.Add(Me.btmStop)
        Me.Controls.Add(Me.btmEclair)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEx04_Mod2"
        Me.Text = "frmEx04_Mod2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btmEclair As System.Windows.Forms.Button
    Friend WithEvents btmStop As System.Windows.Forms.Button
    Friend WithEvents btmPompiers As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblchange As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
