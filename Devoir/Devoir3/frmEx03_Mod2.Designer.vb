<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx03_Mod2
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
        Me.btmOperateur = New System.Windows.Forms.Button()
        Me.lblNb1 = New System.Windows.Forms.Label()
        Me.lblnb2 = New System.Windows.Forms.Label()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEssai = New System.Windows.Forms.Label()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btmFermer = New System.Windows.Forms.Button()
        Me.tmrChrono = New System.Windows.Forms.Timer(Me.components)
        Me.btmCorrige = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblOui_Non = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btmOperateur
        '
        Me.btmOperateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmOperateur.Location = New System.Drawing.Point(23, 12)
        Me.btmOperateur.Name = "btmOperateur"
        Me.btmOperateur.Size = New System.Drawing.Size(453, 52)
        Me.btmOperateur.TabIndex = 0
        Me.btmOperateur.Text = "Nouvelle operation"
        Me.btmOperateur.UseVisualStyleBackColor = True
        '
        'lblNb1
        '
        Me.lblNb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNb1.Location = New System.Drawing.Point(28, 94)
        Me.lblNb1.Name = "lblNb1"
        Me.lblNb1.Size = New System.Drawing.Size(74, 38)
        Me.lblNb1.TabIndex = 1
        Me.lblNb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblnb2
        '
        Me.lblnb2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblnb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnb2.Location = New System.Drawing.Point(215, 94)
        Me.lblnb2.Name = "lblnb2"
        Me.lblnb2.Size = New System.Drawing.Size(71, 38)
        Me.lblnb2.TabIndex = 2
        Me.lblnb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOp
        '
        Me.lblOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp.Location = New System.Drawing.Point(130, 94)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.Size = New System.Drawing.Size(60, 38)
        Me.lblOp.TabIndex = 3
        Me.lblOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nb.Essaie"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(247, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Secondes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEssai
        '
        Me.lblEssai.BackColor = System.Drawing.Color.White
        Me.lblEssai.Location = New System.Drawing.Point(44, 183)
        Me.lblEssai.Name = "lblEssai"
        Me.lblEssai.Size = New System.Drawing.Size(79, 44)
        Me.lblEssai.TabIndex = 6
        Me.lblEssai.Text = "0"
        Me.lblEssai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChrono
        '
        Me.lblChrono.BackColor = System.Drawing.Color.White
        Me.lblChrono.Location = New System.Drawing.Point(256, 183)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(82, 44)
        Me.lblChrono.TabIndex = 7
        Me.lblChrono.Text = "0"
        Me.lblChrono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 42)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(370, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(106, 38)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btmFermer
        '
        Me.btmFermer.Location = New System.Drawing.Point(615, 162)
        Me.btmFermer.Name = "btmFermer"
        Me.btmFermer.Size = New System.Drawing.Size(105, 57)
        Me.btmFermer.TabIndex = 10
        Me.btmFermer.Text = "Fermer"
        Me.btmFermer.UseVisualStyleBackColor = True
        '
        'tmrChrono
        '
        Me.tmrChrono.Interval = 1000
        '
        'btmCorrige
        '
        Me.btmCorrige.Enabled = False
        Me.btmCorrige.Location = New System.Drawing.Point(370, 162)
        Me.btmCorrige.Name = "btmCorrige"
        Me.btmCorrige.Size = New System.Drawing.Size(106, 57)
        Me.btmCorrige.TabIndex = 11
        Me.btmCorrige.Text = "Corriger"
        Me.btmCorrige.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Devoir3.My.Resources.Resources.bravo
        Me.PictureBox1.Location = New System.Drawing.Point(495, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblOui_Non
        '
        Me.lblOui_Non.AutoSize = True
        Me.lblOui_Non.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOui_Non.Location = New System.Drawing.Point(615, 42)
        Me.lblOui_Non.Name = "lblOui_Non"
        Me.lblOui_Non.Size = New System.Drawing.Size(130, 42)
        Me.lblOui_Non.TabIndex = 13
        Me.lblOui_Non.Text = "OUI !!!"
        Me.lblOui_Non.Visible = False
        '
        'frmEx03_Mod2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 231)
        Me.Controls.Add(Me.lblOui_Non)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btmCorrige)
        Me.Controls.Add(Me.btmFermer)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.lblEssai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOp)
        Me.Controls.Add(Me.lblnb2)
        Me.Controls.Add(Me.lblNb1)
        Me.Controls.Add(Me.btmOperateur)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "frmEx03_Mod2"
        Me.Text = "frmEx03_Mod2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btmOperateur As System.Windows.Forms.Button
    Friend WithEvents lblNb1 As System.Windows.Forms.Label
    Friend WithEvents lblnb2 As System.Windows.Forms.Label
    Friend WithEvents lblOp As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEssai As System.Windows.Forms.Label
    Friend WithEvents lblChrono As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btmFermer As System.Windows.Forms.Button
    Friend WithEvents tmrChrono As System.Windows.Forms.Timer
    Friend WithEvents btmCorrige As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Protected Friend WithEvents lblOui_Non As System.Windows.Forms.Label
End Class
