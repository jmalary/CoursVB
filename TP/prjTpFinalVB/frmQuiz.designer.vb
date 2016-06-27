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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuiz))
        Me.GbOpérations = New System.Windows.Forms.GroupBox()
        Me.btStartQuiz = New System.Windows.Forms.Button()
        Me.txtnbQuiz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbDivision = New System.Windows.Forms.CheckBox()
        Me.CbMultiplication = New System.Windows.Forms.CheckBox()
        Me.CbSoustraction = New System.Windows.Forms.CheckBox()
        Me.CbAddition = New System.Windows.Forms.CheckBox()
        Me.PannelQuiz = New System.Windows.Forms.Panel()
        Me.lblResultMessage = New System.Windows.Forms.Label()
        Me.btNouveau = New System.Windows.Forms.Button()
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
        Me.btmFermer = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GbOpérations.SuspendLayout()
        Me.PannelQuiz.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultat.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GbOpérations.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbOpérations.ForeColor = System.Drawing.Color.White
        Me.GbOpérations.Location = New System.Drawing.Point(66, 66)
        Me.GbOpérations.Name = "GbOpérations"
        Me.GbOpérations.Size = New System.Drawing.Size(339, 461)
        Me.GbOpérations.TabIndex = 0
        Me.GbOpérations.TabStop = False
        Me.GbOpérations.Text = "Choix Des Opérations"
        '
        'btStartQuiz
        '
        Me.btStartQuiz.Enabled = False
        Me.btStartQuiz.ForeColor = System.Drawing.Color.Black
        Me.btStartQuiz.Location = New System.Drawing.Point(34, 388)
        Me.btStartQuiz.Name = "btStartQuiz"
        Me.btStartQuiz.Size = New System.Drawing.Size(238, 57)
        Me.btStartQuiz.TabIndex = 6
        Me.btStartQuiz.Text = "Commencer"
        Me.btStartQuiz.UseVisualStyleBackColor = True
        '
        'txtnbQuiz
        '
        Me.txtnbQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnbQuiz.Location = New System.Drawing.Point(201, 333)
        Me.txtnbQuiz.Name = "txtnbQuiz"
        Me.txtnbQuiz.Size = New System.Drawing.Size(74, 35)
        Me.txtnbQuiz.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Combien ?"
        '
        'CbDivision
        '
        Me.CbDivision.AutoSize = True
        Me.CbDivision.Font = New System.Drawing.Font("Segoe Script", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDivision.ForeColor = System.Drawing.Color.White
        Me.CbDivision.Location = New System.Drawing.Point(23, 223)
        Me.CbDivision.Name = "CbDivision"
        Me.CbDivision.Size = New System.Drawing.Size(252, 65)
        Me.CbDivision.TabIndex = 3
        Me.CbDivision.Tag = "Division"
        Me.CbDivision.Text = "Division ?"
        Me.CbDivision.UseVisualStyleBackColor = True
        '
        'CbMultiplication
        '
        Me.CbMultiplication.AutoSize = True
        Me.CbMultiplication.Font = New System.Drawing.Font("Segoe Script", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMultiplication.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CbMultiplication.Location = New System.Drawing.Point(23, 169)
        Me.CbMultiplication.Name = "CbMultiplication"
        Me.CbMultiplication.Size = New System.Drawing.Size(281, 48)
        Me.CbMultiplication.TabIndex = 2
        Me.CbMultiplication.Tag = "Multiplication"
        Me.CbMultiplication.Text = "Multiplication ?"
        Me.CbMultiplication.UseVisualStyleBackColor = True
        '
        'CbSoustraction
        '
        Me.CbSoustraction.AutoSize = True
        Me.CbSoustraction.Font = New System.Drawing.Font("Segoe Script", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSoustraction.ForeColor = System.Drawing.Color.White
        Me.CbSoustraction.Location = New System.Drawing.Point(23, 105)
        Me.CbSoustraction.Name = "CbSoustraction"
        Me.CbSoustraction.Size = New System.Drawing.Size(260, 52)
        Me.CbSoustraction.TabIndex = 1
        Me.CbSoustraction.Tag = "Soustraction"
        Me.CbSoustraction.Text = "Soustraction ?"
        Me.CbSoustraction.UseVisualStyleBackColor = True
        '
        'CbAddition
        '
        Me.CbAddition.AutoSize = True
        Me.CbAddition.Font = New System.Drawing.Font("Segoe Script", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAddition.ForeColor = System.Drawing.Color.White
        Me.CbAddition.Location = New System.Drawing.Point(34, 41)
        Me.CbAddition.Name = "CbAddition"
        Me.CbAddition.Size = New System.Drawing.Size(210, 52)
        Me.CbAddition.TabIndex = 0
        Me.CbAddition.Tag = "Addition"
        Me.CbAddition.Text = "Addition ?"
        Me.CbAddition.UseVisualStyleBackColor = True
        '
        'PannelQuiz
        '
        Me.PannelQuiz.BackColor = System.Drawing.Color.Transparent
        Me.PannelQuiz.Controls.Add(Me.lblResultMessage)
        Me.PannelQuiz.Controls.Add(Me.btNouveau)
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
        Me.PannelQuiz.Location = New System.Drawing.Point(455, 150)
        Me.PannelQuiz.Name = "PannelQuiz"
        Me.PannelQuiz.Size = New System.Drawing.Size(452, 546)
        Me.PannelQuiz.TabIndex = 20
        Me.PannelQuiz.Visible = False
        '
        'lblResultMessage
        '
        Me.lblResultMessage.BackColor = System.Drawing.Color.White
        Me.lblResultMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultMessage.ForeColor = System.Drawing.Color.Red
        Me.lblResultMessage.Location = New System.Drawing.Point(69, 76)
        Me.lblResultMessage.Name = "lblResultMessage"
        Me.lblResultMessage.Size = New System.Drawing.Size(332, 93)
        Me.lblResultMessage.TabIndex = 28
        Me.lblResultMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResultMessage.Visible = False
        '
        'btNouveau
        '
        Me.btNouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNouveau.Location = New System.Drawing.Point(53, 467)
        Me.btNouveau.Name = "btNouveau"
        Me.btNouveau.Size = New System.Drawing.Size(274, 59)
        Me.btNouveau.TabIndex = 27
        Me.btNouveau.Text = "Nouveau Quiz"
        Me.btNouveau.UseVisualStyleBackColor = True
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.BackColor = System.Drawing.Color.White
        Me.lblResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultat.ForeColor = System.Drawing.Color.Black
        Me.lblResultat.Location = New System.Drawing.Point(327, 103)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(101, 31)
        Me.lblResultat.TabIndex = 25
        Me.lblResultat.Text = "Label2"
        Me.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(268, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 31)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(133, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 32)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValeur2
        '
        Me.lblValeur2.BackColor = System.Drawing.Color.White
        Me.lblValeur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValeur2.ForeColor = System.Drawing.Color.Black
        Me.lblValeur2.Location = New System.Drawing.Point(194, 102)
        Me.lblValeur2.Name = "lblValeur2"
        Me.lblValeur2.Size = New System.Drawing.Size(68, 32)
        Me.lblValeur2.TabIndex = 22
        Me.lblValeur2.Text = "Label2"
        Me.lblValeur2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValeur1
        '
        Me.lblValeur1.BackColor = System.Drawing.Color.White
        Me.lblValeur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValeur1.ForeColor = System.Drawing.Color.Black
        Me.lblValeur1.Location = New System.Drawing.Point(47, 101)
        Me.lblValeur1.Name = "lblValeur1"
        Me.lblValeur1.Size = New System.Drawing.Size(65, 32)
        Me.lblValeur1.TabIndex = 21
        Me.lblValeur1.Text = "Label2"
        Me.lblValeur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 313)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btSoustraction
        '
        Me.btSoustraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSoustraction.Location = New System.Drawing.Point(204, 340)
        Me.btSoustraction.Name = "btSoustraction"
        Me.btSoustraction.Size = New System.Drawing.Size(117, 52)
        Me.btSoustraction.TabIndex = 17
        Me.btSoustraction.Tag = "-"
        Me.btSoustraction.Text = "-"
        Me.btSoustraction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btSoustraction.UseVisualStyleBackColor = True
        Me.btSoustraction.Visible = False
        '
        'btdivision
        '
        Me.btdivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdivision.Location = New System.Drawing.Point(53, 398)
        Me.btdivision.Name = "btdivision"
        Me.btdivision.Size = New System.Drawing.Size(127, 53)
        Me.btdivision.TabIndex = 16
        Me.btdivision.Tag = "division"
        Me.btdivision.Text = ":"
        Me.btdivision.UseVisualStyleBackColor = True
        Me.btdivision.Visible = False
        '
        'btAddition
        '
        Me.btAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddition.Location = New System.Drawing.Point(53, 337)
        Me.btAddition.Name = "btAddition"
        Me.btAddition.Size = New System.Drawing.Size(127, 55)
        Me.btAddition.TabIndex = 15
        Me.btAddition.Tag = "+"
        Me.btAddition.Text = "+"
        Me.btAddition.UseVisualStyleBackColor = True
        Me.btAddition.Visible = False
        '
        'btmultiplication
        '
        Me.btmultiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmultiplication.Location = New System.Drawing.Point(204, 398)
        Me.btmultiplication.Name = "btmultiplication"
        Me.btmultiplication.Size = New System.Drawing.Size(117, 53)
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
        Me.gbResultat.Location = New System.Drawing.Point(924, 48)
        Me.gbResultat.Name = "gbResultat"
        Me.gbResultat.Size = New System.Drawing.Size(318, 260)
        Me.gbResultat.TabIndex = 21
        Me.gbResultat.TabStop = False
        Me.gbResultat.Visible = False
        '
        'lblReponsefausse
        '
        Me.lblReponsefausse.AutoSize = True
        Me.lblReponsefausse.Font = New System.Drawing.Font("Segoe Script", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReponsefausse.ForeColor = System.Drawing.Color.White
        Me.lblReponsefausse.Location = New System.Drawing.Point(6, 152)
        Me.lblReponsefausse.Name = "lblReponsefausse"
        Me.lblReponsefausse.Size = New System.Drawing.Size(216, 34)
        Me.lblReponsefausse.TabIndex = 2
        Me.lblReponsefausse.Text = "Réponse fausse:  0"
        '
        'lblresponseJuste
        '
        Me.lblresponseJuste.AutoSize = True
        Me.lblresponseJuste.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresponseJuste.ForeColor = System.Drawing.Color.White
        Me.lblresponseJuste.Location = New System.Drawing.Point(6, 78)
        Me.lblresponseJuste.Name = "lblresponseJuste"
        Me.lblresponseJuste.Size = New System.Drawing.Size(213, 34)
        Me.lblresponseJuste.TabIndex = 1
        Me.lblresponseJuste.Text = "Réponse exacte: 0"
        '
        'lblNumQuestion
        '
        Me.lblNumQuestion.AutoSize = True
        Me.lblNumQuestion.Font = New System.Drawing.Font("Segoe Script", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumQuestion.ForeColor = System.Drawing.Color.White
        Me.lblNumQuestion.Location = New System.Drawing.Point(6, 18)
        Me.lblNumQuestion.Name = "lblNumQuestion"
        Me.lblNumQuestion.Size = New System.Drawing.Size(219, 31)
        Me.lblNumQuestion.TabIndex = 0
        Me.lblNumQuestion.Text = "Numero Question: 1"
        '
        'btmFermer
        '
        Me.btmFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmFermer.Location = New System.Drawing.Point(158, 580)
        Me.btmFermer.Name = "btmFermer"
        Me.btmFermer.Size = New System.Drawing.Size(168, 96)
        Me.btmFermer.TabIndex = 22
        Me.btmFermer.Text = "Fermer"
        Me.btmFermer.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.prjTpFinalVB.My.Resources.Resources.reflexion
        Me.PictureBox2.Location = New System.Drawing.Point(925, 440)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(224, 256)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(490, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 106)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "QuizMath"
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.prjTpFinalVB.My.Resources.Resources.tableau_ecole
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btmFermer)
        Me.Controls.Add(Me.gbResultat)
        Me.Controls.Add(Me.PannelQuiz)
        Me.Controls.Add(Me.GbOpérations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuiZMath"
        Me.GbOpérations.ResumeLayout(False)
        Me.GbOpérations.PerformLayout()
        Me.PannelQuiz.ResumeLayout(False)
        Me.PannelQuiz.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultat.ResumeLayout(False)
        Me.gbResultat.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btmFermer As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
