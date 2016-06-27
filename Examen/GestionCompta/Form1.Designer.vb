<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumCompte = New System.Windows.Forms.TextBox()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.txtSolde = New System.Windows.Forms.TextBox()
        Me.bCreerCompte = New System.Windows.Forms.Button()
        Me.bDepot = New System.Windows.Forms.Button()
        Me.bRetrait = New System.Windows.Forms.Button()
        Me.LbSolde = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbErreur = New System.Windows.Forms.Label()
        Me.gbOperations = New System.Windows.Forms.GroupBox()
        Me.gbCompte = New System.Windows.Forms.GroupBox()
        Me.bFermer = New System.Windows.Forms.Button()
        Me.gbOperations.SuspendLayout()
        Me.gbCompte.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numéro de Compte :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom du client :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Solde :"
        '
        'txtNumCompte
        '
        Me.txtNumCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCompte.Location = New System.Drawing.Point(271, 33)
        Me.txtNumCompte.Name = "txtNumCompte"
        Me.txtNumCompte.Size = New System.Drawing.Size(180, 22)
        Me.txtNumCompte.TabIndex = 3
        '
        'txtNomClient
        '
        Me.txtNomClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomClient.Location = New System.Drawing.Point(271, 58)
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.Size = New System.Drawing.Size(180, 22)
        Me.txtNomClient.TabIndex = 4
        '
        'txtSolde
        '
        Me.txtSolde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolde.Location = New System.Drawing.Point(271, 84)
        Me.txtSolde.Name = "txtSolde"
        Me.txtSolde.Size = New System.Drawing.Size(180, 22)
        Me.txtSolde.TabIndex = 5
        '
        'bCreerCompte
        '
        Me.bCreerCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCreerCompte.Location = New System.Drawing.Point(6, 112)
        Me.bCreerCompte.Name = "bCreerCompte"
        Me.bCreerCompte.Size = New System.Drawing.Size(569, 42)
        Me.bCreerCompte.TabIndex = 6
        Me.bCreerCompte.Text = "Créer le compte"
        Me.bCreerCompte.UseVisualStyleBackColor = True
        '
        'bDepot
        '
        Me.bDepot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDepot.Location = New System.Drawing.Point(17, 16)
        Me.bDepot.Name = "bDepot"
        Me.bDepot.Size = New System.Drawing.Size(280, 39)
        Me.bDepot.TabIndex = 7
        Me.bDepot.Text = "&Dépot"
        Me.bDepot.UseVisualStyleBackColor = True
        '
        'bRetrait
        '
        Me.bRetrait.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRetrait.Location = New System.Drawing.Point(303, 16)
        Me.bRetrait.Name = "bRetrait"
        Me.bRetrait.Size = New System.Drawing.Size(272, 39)
        Me.bRetrait.TabIndex = 8
        Me.bRetrait.Text = "&Retrait"
        Me.bRetrait.UseVisualStyleBackColor = True
        '
        'LbSolde
        '
        Me.LbSolde.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LbSolde.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSolde.Location = New System.Drawing.Point(17, 84)
        Me.LbSolde.Name = "LbSolde"
        Me.LbSolde.Size = New System.Drawing.Size(557, 88)
        Me.LbSolde.TabIndex = 9
        Me.LbSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(557, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Solde"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbErreur
        '
        Me.LbErreur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LbErreur.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbErreur.ForeColor = System.Drawing.Color.Red
        Me.LbErreur.Location = New System.Drawing.Point(19, 173)
        Me.LbErreur.Name = "LbErreur"
        Me.LbErreur.Size = New System.Drawing.Size(555, 64)
        Me.LbErreur.TabIndex = 11
        Me.LbErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LbErreur.Visible = False
        '
        'gbOperations
        '
        Me.gbOperations.Controls.Add(Me.LbErreur)
        Me.gbOperations.Controls.Add(Me.bDepot)
        Me.gbOperations.Controls.Add(Me.Label4)
        Me.gbOperations.Controls.Add(Me.bRetrait)
        Me.gbOperations.Controls.Add(Me.LbSolde)
        Me.gbOperations.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOperations.Location = New System.Drawing.Point(15, 180)
        Me.gbOperations.Name = "gbOperations"
        Me.gbOperations.Size = New System.Drawing.Size(581, 248)
        Me.gbOperations.TabIndex = 12
        Me.gbOperations.TabStop = False
        Me.gbOperations.Text = "Opérations"
        Me.gbOperations.Visible = False
        '
        'gbCompte
        '
        Me.gbCompte.Controls.Add(Me.bCreerCompte)
        Me.gbCompte.Controls.Add(Me.Label1)
        Me.gbCompte.Controls.Add(Me.Label2)
        Me.gbCompte.Controls.Add(Me.txtSolde)
        Me.gbCompte.Controls.Add(Me.Label3)
        Me.gbCompte.Controls.Add(Me.txtNomClient)
        Me.gbCompte.Controls.Add(Me.txtNumCompte)
        Me.gbCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCompte.Location = New System.Drawing.Point(15, 12)
        Me.gbCompte.Name = "gbCompte"
        Me.gbCompte.Size = New System.Drawing.Size(581, 162)
        Me.gbCompte.TabIndex = 13
        Me.gbCompte.TabStop = False
        Me.gbCompte.Text = "Compte"
        '
        'bFermer
        '
        Me.bFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bFermer.Location = New System.Drawing.Point(15, 434)
        Me.bFermer.Name = "bFermer"
        Me.bFermer.Size = New System.Drawing.Size(581, 34)
        Me.bFermer.TabIndex = 14
        Me.bFermer.Text = "&Fermer"
        Me.bFermer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 481)
        Me.Controls.Add(Me.bFermer)
        Me.Controls.Add(Me.gbCompte)
        Me.Controls.Add(Me.gbOperations)
        Me.Name = "Form1"
        Me.Text = "Gestion d'un compte"
        Me.gbOperations.ResumeLayout(False)
        Me.gbCompte.ResumeLayout(False)
        Me.gbCompte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumCompte As System.Windows.Forms.TextBox
    Friend WithEvents txtNomClient As System.Windows.Forms.TextBox
    Friend WithEvents txtSolde As System.Windows.Forms.TextBox
    Friend WithEvents bCreerCompte As System.Windows.Forms.Button
    Friend WithEvents bDepot As System.Windows.Forms.Button
    Friend WithEvents bRetrait As System.Windows.Forms.Button
    Friend WithEvents LbSolde As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LbErreur As System.Windows.Forms.Label
    Friend WithEvents gbOperations As System.Windows.Forms.GroupBox
    Friend WithEvents gbCompte As System.Windows.Forms.GroupBox
    Friend WithEvents bFermer As System.Windows.Forms.Button

End Class
