<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GbOpérations = New System.Windows.Forms.GroupBox()
        Me.btStartQuiz = New System.Windows.Forms.Button()
        Me.txtnbQuiz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbDivision = New System.Windows.Forms.CheckBox()
        Me.CbMultiplication = New System.Windows.Forms.CheckBox()
        Me.CbSoustraction = New System.Windows.Forms.CheckBox()
        Me.CbAddition = New System.Windows.Forms.CheckBox()
        Me.PannelQuiz = New System.Windows.Forms.Panel()
        Me.btNouveau = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblValeur2 = New System.Windows.Forms.Label()
        Me.lblValeur1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btSoustraction = New System.Windows.Forms.Button()
        Me.btdivision = New System.Windows.Forms.Button()
        Me.btAddition = New System.Windows.Forms.Button()
        Me.btmultiplication = New System.Windows.Forms.Button()
        Me.gbResultat = New System.Windows.Forms.GroupBox()
        Me.lblReponsefausse = New System.Windows.Forms.Label()
        Me.lblresponseJuste = New System.Windows.Forms.Label()
        Me.lblNumQuestion = New System.Windows.Forms.Label()
        Me.lblResultMessage = New System.Windows.Forms.Label()
        Me.GbOpérations.SuspendLayout()
        Me.PannelQuiz.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultat.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbOpérations
        '
        Me.GbOpérations.BackColor = System.Drawing.Color.Transparent
        Me.GbOpérations.Controls.Add(Me.btStartQuiz)
        Me.GbOpérations.Controls.Add(Me.txtnbQuiz)
        Me.GbOpérations.Controls.Add(Me.Label1)
        Me.GbOpérations.Controls.Add(Me.CbDivision)
        Me.GbOpérations.Controls.Add(Me.CbMultiplication)
        Me.GbOpérations.Controls.Add(Me.CbSoustraction)
        Me.GbOpérations.Controls.Add(Me.CbAddition)
        Me.GbOpérations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbOpérations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbOpérations.Location = New System.Drawing.Point(3, 5)
        Me.GbOpérations.Name = "GbOpérations"
        Me.GbOpérations.Size = New System.Drawing.Size(191, 273)
        Me.GbOpérations.TabIndex = 0
        Me.GbOpérations.TabStop = False
        Me.GbOpérations.Text = "Choix Des Opérations"
        '
        'btStartQuiz
        '
        Me.btStartQuiz.Enabled = False
        Me.btStartQuiz.Location = New System.Drawing.Point(30, 228)
        Me.btStartQuiz.Name = "btStartQuiz"
        Me.btStartQuiz.Size = New System.Drawing.Size(116, 28)
        Me.btStartQuiz.TabIndex = 6
        Me.btStartQuiz.Text = "Commencer"
        Me.btStartQuiz.UseVisualStyleBackColor = True
        '
        'txtnbQuiz
        '
        Me.txtnbQuiz.Location = New System.Drawing.Point(94, 187)
        Me.txtnbQuiz.Name = "txtnbQuiz"
        Me.txtnbQuiz.Size = New System.Drawing.Size(74, 22)
        Me.txtnbQuiz.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Combien ?"
        '
        'CbDivision
        '
        Me.CbDivision.AutoSize = True
        Me.CbDivision.Location = New System.Drawing.Point(7, 147)
        Me.CbDivision.Name = "CbDivision"
        Me.CbDivision.Size = New System.Drawing.Size(95, 20)
        Me.CbDivision.TabIndex = 3
        Me.CbDivision.Tag = "Division"
        Me.CbDivision.Text = "Division ?"
        Me.CbDivision.UseVisualStyleBackColor = True
        '
        'CbMultiplication
        '
        Me.CbMultiplication.AutoSize = True
        Me.CbMultiplication.Location = New System.Drawing.Point(7, 110)
        Me.CbMultiplication.Name = "CbMultiplication"
        Me.CbMultiplication.Size = New System.Drawing.Size(130, 20)
        Me.CbMultiplication.TabIndex = 2
        Me.CbMultiplication.Tag = "Multiplication"
        Me.CbMultiplication.Text = "Multiplication ?"
        Me.CbMultiplication.UseVisualStyleBackColor = True
        '
        'CbSoustraction
        '
        Me.CbSoustraction.AutoSize = True
        Me.CbSoustraction.Location = New System.Drawing.Point(7, 75)
        Me.CbSoustraction.Name = "CbSoustraction"
        Me.CbSoustraction.Size = New System.Drawing.Size(125, 20)
        Me.CbSoustraction.TabIndex = 1
        Me.CbSoustraction.Tag = "Soustraction"
        Me.CbSoustraction.Text = "Soustraction ?"
        Me.CbSoustraction.UseVisualStyleBackColor = True
        '
        'CbAddition
        '
        Me.CbAddition.AutoSize = True
        Me.CbAddition.Location = New System.Drawing.Point(7, 38)
        Me.CbAddition.Name = "CbAddition"
        Me.CbAddition.Size = New System.Drawing.Size(96, 20)
        Me.CbAddition.TabIndex = 0
        Me.CbAddition.Tag = "Addition"
        Me.CbAddition.Text = "Addition ?"
        Me.CbAddition.UseVisualStyleBackColor = True
        '
        'PannelQuiz
        '
        Me.PannelQuiz.Controls.Add(Me.lblResultMessage)
        Me.PannelQuiz.Controls.Add(Me.btNouveau)
        Me.PannelQuiz.Controls.Add(Me.PictureBox2)
        Me.PannelQuiz.Controls.Add(Me.lblResultat)
        Me.PannelQuiz.Controls.Add(Me.Label3)
        Me.PannelQuiz.Controls.Add(Me.Label2)
        Me.PannelQuiz.Controls.Add(Me.lblValeur2)
        Me.PannelQuiz.Controls.Add(Me.lblValeur1)
        Me.PannelQuiz.Controls.Add(Me.PictureBox1)
        Me.PannelQuiz.Controls.Add(Me.btSoustraction)
        Me.PannelQuiz.Controls.Add(Me.btdivision)
        Me.PannelQuiz.Controls.Add(Me.btAddition)
        Me.PannelQuiz.Controls.Add(Me.btmultiplication)
        Me.PannelQuiz.Location = New System.Drawing.Point(224, 12)
        Me.PannelQuiz.Name = "PannelQuiz"
        Me.PannelQuiz.Size = New System.Drawing.Size(290, 266)
        Me.PannelQuiz.TabIndex = 20
        Me.PannelQuiz.Visible = False
        '
        'btNouveau
        '
        Me.btNouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNouveau.Location = New System.Drawing.Point(4, 221)
        Me.btNouveau.Name = "btNouveau"
        Me.btNouveau.Size = New System.Drawing.Size(101, 42)
        Me.btNouveau.TabIndex = 27
        Me.btNouveau.Text = "Nouveau Quiz"
        Me.btNouveau.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MathFun.My.Resources.Resources.reflechit
        Me.PictureBox2.Location = New System.Drawing.Point(204, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultat.ForeColor = System.Drawing.Color.Red
        Me.lblResultat.Location = New System.Drawing.Point(129, 106)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(63, 20)
        Me.lblResultat.TabIndex = 25
        Me.lblResultat.Text = "Label2"
        Me.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(127, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(138, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValeur2
        '
        Me.lblValeur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValeur2.ForeColor = System.Drawing.Color.Red
        Me.lblValeur2.Location = New System.Drawing.Point(189, 32)
        Me.lblValeur2.Name = "lblValeur2"
        Me.lblValeur2.Size = New System.Drawing.Size(42, 32)
        Me.lblValeur2.TabIndex = 22
        Me.lblValeur2.Text = "Label2"
        Me.lblValeur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValeur1
        '
        Me.lblValeur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValeur1.ForeColor = System.Drawing.Color.Red
        Me.lblValeur1.Location = New System.Drawing.Point(69, 32)
        Me.lblValeur1.Name = "lblValeur1"
        Me.lblValeur1.Size = New System.Drawing.Size(46, 32)
        Me.lblValeur1.TabIndex = 21
        Me.lblValeur1.Text = "Label2"
        Me.lblValeur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MathFun.My.Resources.Resources.bulle_de_dialogue_t22865
        Me.PictureBox1.Location = New System.Drawing.Point(22, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btSoustraction
        '
        Me.btSoustraction.Location = New System.Drawing.Point(54, 175)
        Me.btSoustraction.Name = "btSoustraction"
        Me.btSoustraction.Size = New System.Drawing.Size(51, 24)
        Me.btSoustraction.TabIndex = 17
        Me.btSoustraction.Tag = "-"
        Me.btSoustraction.Text = "-"
        Me.btSoustraction.UseVisualStyleBackColor = True
        Me.btSoustraction.Visible = False
        '
        'btdivision
        '
        Me.btdivision.Location = New System.Drawing.Point(3, 197)
        Me.btdivision.Name = "btdivision"
        Me.btdivision.Size = New System.Drawing.Size(51, 24)
        Me.btdivision.TabIndex = 16
        Me.btdivision.Tag = "division"
        Me.btdivision.Text = ":"
        Me.btdivision.UseVisualStyleBackColor = True
        Me.btdivision.Visible = False
        '
        'btAddition
        '
        Me.btAddition.Location = New System.Drawing.Point(3, 175)
        Me.btAddition.Name = "btAddition"
        Me.btAddition.Size = New System.Drawing.Size(51, 24)
        Me.btAddition.TabIndex = 15
        Me.btAddition.Tag = "+"
        Me.btAddition.Text = "+"
        Me.btAddition.UseVisualStyleBackColor = True
        Me.btAddition.Visible = False
        '
        'btmultiplication
        '
        Me.btmultiplication.Location = New System.Drawing.Point(54, 198)
        Me.btmultiplication.Name = "btmultiplication"
        Me.btmultiplication.Size = New System.Drawing.Size(51, 24)
        Me.btmultiplication.TabIndex = 14
        Me.btmultiplication.Tag = "multiplication"
        Me.btmultiplication.Text = "*"
        Me.btmultiplication.UseVisualStyleBackColor = True
        Me.btmultiplication.Visible = False
        '
        'gbResultat
        '
        Me.gbResultat.BackColor = System.Drawing.Color.Transparent
        Me.gbResultat.Controls.Add(Me.lblReponsefausse)
        Me.gbResultat.Controls.Add(Me.lblresponseJuste)
        Me.gbResultat.Controls.Add(Me.lblNumQuestion)
        Me.gbResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResultat.Location = New System.Drawing.Point(546, 78)
        Me.gbResultat.Name = "gbResultat"
        Me.gbResultat.Size = New System.Drawing.Size(232, 136)
        Me.gbResultat.TabIndex = 21
        Me.gbResultat.TabStop = False
        Me.gbResultat.Visible = False
        '
        'lblReponsefausse
        '
        Me.lblReponsefausse.AutoSize = True
        Me.lblReponsefausse.Location = New System.Drawing.Point(6, 103)
        Me.lblReponsefausse.Name = "lblReponsefausse"
        Me.lblReponsefausse.Size = New System.Drawing.Size(141, 16)
        Me.lblReponsefausse.TabIndex = 2
        Me.lblReponsefausse.Text = "Réponse fausse:  0"
        '
        'lblresponseJuste
        '
        Me.lblresponseJuste.AutoSize = True
        Me.lblresponseJuste.Location = New System.Drawing.Point(6, 56)
        Me.lblresponseJuste.Name = "lblresponseJuste"
        Me.lblresponseJuste.Size = New System.Drawing.Size(133, 16)
        Me.lblresponseJuste.TabIndex = 1
        Me.lblresponseJuste.Text = "Réponse exacte:0"
        '
        'lblNumQuestion
        '
        Me.lblNumQuestion.AutoSize = True
        Me.lblNumQuestion.Location = New System.Drawing.Point(6, 18)
        Me.lblNumQuestion.Name = "lblNumQuestion"
        Me.lblNumQuestion.Size = New System.Drawing.Size(143, 16)
        Me.lblNumQuestion.TabIndex = 0
        Me.lblNumQuestion.Text = "Numero Question: 1"
        '
        'lblResultMessage
        '
        Me.lblResultMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultMessage.ForeColor = System.Drawing.Color.Red
        Me.lblResultMessage.Location = New System.Drawing.Point(69, 21)
        Me.lblResultMessage.Name = "lblResultMessage"
        Me.lblResultMessage.Size = New System.Drawing.Size(158, 79)
        Me.lblResultMessage.TabIndex = 28
        Me.lblResultMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResultMessage.Visible = False
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 283)
        Me.Controls.Add(Me.gbResultat)
        Me.Controls.Add(Me.PannelQuiz)
        Me.Controls.Add(Me.GbOpérations)
        Me.Name = "frmQuiz"
        Me.Text = "QuiZMath"
        Me.GbOpérations.ResumeLayout(False)
        Me.GbOpérations.PerformLayout()
        Me.PannelQuiz.ResumeLayout(False)
        Me.PannelQuiz.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultat.ResumeLayout(False)
        Me.gbResultat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbOpérations As System.Windows.Forms.GroupBox
    Friend WithEvents CbDivision As System.Windows.Forms.CheckBox
    Friend WithEvents CbMultiplication As System.Windows.Forms.CheckBox
    Friend WithEvents CbSoustraction As System.Windows.Forms.CheckBox
    Friend WithEvents CbAddition As System.Windows.Forms.CheckBox
    Friend WithEvents txtnbQuiz As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btStartQuiz As System.Windows.Forms.Button
    Friend WithEvents PannelQuiz As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblResultat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblValeur2 As System.Windows.Forms.Label
    Friend WithEvents lblValeur1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btSoustraction As System.Windows.Forms.Button
    Friend WithEvents btdivision As System.Windows.Forms.Button
    Friend WithEvents btAddition As System.Windows.Forms.Button
    Friend WithEvents btmultiplication As System.Windows.Forms.Button
    Friend WithEvents btNouveau As System.Windows.Forms.Button
    Friend WithEvents gbResultat As System.Windows.Forms.GroupBox
    Friend WithEvents lblReponsefausse As System.Windows.Forms.Label
    Friend WithEvents lblresponseJuste As System.Windows.Forms.Label
    Friend WithEvents lblNumQuestion As System.Windows.Forms.Label
    Friend WithEvents lblResultMessage As System.Windows.Forms.Label
End Class
