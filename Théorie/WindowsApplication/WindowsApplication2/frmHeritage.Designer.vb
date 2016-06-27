<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeritage
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
        Me.panCree = New System.Windows.Forms.Panel()
        Me.btmCréer = New System.Windows.Forms.Button()
        Me.rbEmpPat = New System.Windows.Forms.RadioButton()
        Me.rbPatron = New System.Windows.Forms.RadioButton()
        Me.rbEmploye = New System.Windows.Forms.RadioButton()
        Me.txtNbHeure = New System.Windows.Forms.TextBox()
        Me.lblNbHeure = New System.Windows.Forms.Label()
        Me.txtSalaire = New System.Windows.Forms.TextBox()
        Me.lblSalaire = New System.Windows.Forms.Label()
        Me.txtNAS = New System.Windows.Forms.TextBox()
        Me.lblNas = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.panMethodes = New System.Windows.Forms.Panel()
        Me.btmAugmenter = New System.Windows.Forms.Button()
        Me.btmCalculer = New System.Windows.Forms.Button()
        Me.btVacances = New System.Windows.Forms.Button()
        Me.btmDetruire = New System.Windows.Forms.Button()
        Me.panCree.SuspendLayout()
        Me.panMethodes.SuspendLayout()
        Me.SuspendLayout()
        '
        'panCree
        '
        Me.panCree.Controls.Add(Me.btmCréer)
        Me.panCree.Controls.Add(Me.rbEmpPat)
        Me.panCree.Controls.Add(Me.rbPatron)
        Me.panCree.Controls.Add(Me.rbEmploye)
        Me.panCree.Controls.Add(Me.txtNbHeure)
        Me.panCree.Controls.Add(Me.lblNbHeure)
        Me.panCree.Controls.Add(Me.txtSalaire)
        Me.panCree.Controls.Add(Me.lblSalaire)
        Me.panCree.Controls.Add(Me.txtNAS)
        Me.panCree.Controls.Add(Me.lblNas)
        Me.panCree.Controls.Add(Me.txtNom)
        Me.panCree.Controls.Add(Me.lblNom)
        Me.panCree.Location = New System.Drawing.Point(12, 0)
        Me.panCree.Name = "panCree"
        Me.panCree.Size = New System.Drawing.Size(444, 178)
        Me.panCree.TabIndex = 0
        '
        'btmCréer
        '
        Me.btmCréer.Location = New System.Drawing.Point(310, 111)
        Me.btmCréer.Name = "btmCréer"
        Me.btmCréer.Size = New System.Drawing.Size(75, 23)
        Me.btmCréer.TabIndex = 11
        Me.btmCréer.Text = "Créer"
        Me.btmCréer.UseVisualStyleBackColor = True
        '
        'rbEmpPat
        '
        Me.rbEmpPat.AutoSize = True
        Me.rbEmpPat.Location = New System.Drawing.Point(310, 79)
        Me.rbEmpPat.Name = "rbEmpPat"
        Me.rbEmpPat.Size = New System.Drawing.Size(116, 17)
        Me.rbEmpPat.TabIndex = 10
        Me.rbEmpPat.TabStop = True
        Me.rbEmpPat.Text = "Employé sur Patron"
        Me.rbEmpPat.UseVisualStyleBackColor = True
        '
        'rbPatron
        '
        Me.rbPatron.AutoSize = True
        Me.rbPatron.Location = New System.Drawing.Point(310, 56)
        Me.rbPatron.Name = "rbPatron"
        Me.rbPatron.Size = New System.Drawing.Size(56, 17)
        Me.rbPatron.TabIndex = 9
        Me.rbPatron.TabStop = True
        Me.rbPatron.Text = "Patron"
        Me.rbPatron.UseVisualStyleBackColor = True
        '
        'rbEmploye
        '
        Me.rbEmploye.AutoSize = True
        Me.rbEmploye.Checked = True
        Me.rbEmploye.Location = New System.Drawing.Point(310, 33)
        Me.rbEmploye.Name = "rbEmploye"
        Me.rbEmploye.Size = New System.Drawing.Size(65, 17)
        Me.rbEmploye.TabIndex = 8
        Me.rbEmploye.TabStop = True
        Me.rbEmploye.Text = "Employé"
        Me.rbEmploye.UseVisualStyleBackColor = True
        '
        'txtNbHeure
        '
        Me.txtNbHeure.Location = New System.Drawing.Point(114, 111)
        Me.txtNbHeure.Name = "txtNbHeure"
        Me.txtNbHeure.Size = New System.Drawing.Size(100, 20)
        Me.txtNbHeure.TabIndex = 7
        '
        'lblNbHeure
        '
        Me.lblNbHeure.AutoSize = True
        Me.lblNbHeure.Location = New System.Drawing.Point(3, 111)
        Me.lblNbHeure.Name = "lblNbHeure"
        Me.lblNbHeure.Size = New System.Drawing.Size(88, 13)
        Me.lblNbHeure.TabIndex = 6
        Me.lblNbHeure.Text = "nombre d'heures:"
        '
        'txtSalaire
        '
        Me.txtSalaire.Location = New System.Drawing.Point(114, 76)
        Me.txtSalaire.Name = "txtSalaire"
        Me.txtSalaire.Size = New System.Drawing.Size(100, 20)
        Me.txtSalaire.TabIndex = 5
        '
        'lblSalaire
        '
        Me.lblSalaire.AutoSize = True
        Me.lblSalaire.Location = New System.Drawing.Point(3, 76)
        Me.lblSalaire.Name = "lblSalaire"
        Me.lblSalaire.Size = New System.Drawing.Size(39, 13)
        Me.lblSalaire.TabIndex = 4
        Me.lblSalaire.Text = "Salaire"
        '
        'txtNAS
        '
        Me.txtNAS.Location = New System.Drawing.Point(114, 45)
        Me.txtNAS.Name = "txtNAS"
        Me.txtNAS.Size = New System.Drawing.Size(100, 20)
        Me.txtNAS.TabIndex = 3
        '
        'lblNas
        '
        Me.lblNas.AutoSize = True
        Me.lblNas.Location = New System.Drawing.Point(3, 48)
        Me.lblNas.Name = "lblNas"
        Me.lblNas.Size = New System.Drawing.Size(32, 13)
        Me.lblNas.TabIndex = 2
        Me.lblNas.Text = "NAS:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(114, 18)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 1
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(3, 18)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(27, 13)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "nom"
        '
        'panMethodes
        '
        Me.panMethodes.Controls.Add(Me.btmAugmenter)
        Me.panMethodes.Controls.Add(Me.btmCalculer)
        Me.panMethodes.Controls.Add(Me.btVacances)
        Me.panMethodes.Enabled = False
        Me.panMethodes.Location = New System.Drawing.Point(464, 0)
        Me.panMethodes.Name = "panMethodes"
        Me.panMethodes.Size = New System.Drawing.Size(200, 144)
        Me.panMethodes.TabIndex = 1
        '
        'btmAugmenter
        '
        Me.btmAugmenter.Location = New System.Drawing.Point(50, 111)
        Me.btmAugmenter.Name = "btmAugmenter"
        Me.btmAugmenter.Size = New System.Drawing.Size(75, 23)
        Me.btmAugmenter.TabIndex = 2
        Me.btmAugmenter.Text = "Augmenter"
        Me.btmAugmenter.UseVisualStyleBackColor = True
        '
        'btmCalculer
        '
        Me.btmCalculer.Location = New System.Drawing.Point(50, 71)
        Me.btmCalculer.Name = "btmCalculer"
        Me.btmCalculer.Size = New System.Drawing.Size(75, 23)
        Me.btmCalculer.TabIndex = 1
        Me.btmCalculer.Text = "Calculer"
        Me.btmCalculer.UseVisualStyleBackColor = True
        '
        'btVacances
        '
        Me.btVacances.Location = New System.Drawing.Point(50, 30)
        Me.btVacances.Name = "btVacances"
        Me.btVacances.Size = New System.Drawing.Size(75, 23)
        Me.btVacances.TabIndex = 0
        Me.btVacances.Text = "Vacances"
        Me.btVacances.UseVisualStyleBackColor = True
        '
        'btmDetruire
        '
        Me.btmDetruire.Enabled = False
        Me.btmDetruire.Location = New System.Drawing.Point(514, 166)
        Me.btmDetruire.Name = "btmDetruire"
        Me.btmDetruire.Size = New System.Drawing.Size(75, 23)
        Me.btmDetruire.TabIndex = 3
        Me.btmDetruire.Text = "Détruire"
        Me.btmDetruire.UseVisualStyleBackColor = True
        '
        'frmHeritage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 280)
        Me.Controls.Add(Me.btmDetruire)
        Me.Controls.Add(Me.panMethodes)
        Me.Controls.Add(Me.panCree)
        Me.Name = "frmHeritage"
        Me.Text = "Exemple d'héritage"
        Me.panCree.ResumeLayout(False)
        Me.panCree.PerformLayout()
        Me.panMethodes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panCree As System.Windows.Forms.Panel
    Friend WithEvents btmCréer As System.Windows.Forms.Button
    Friend WithEvents rbEmpPat As System.Windows.Forms.RadioButton
    Friend WithEvents rbPatron As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmploye As System.Windows.Forms.RadioButton
    Friend WithEvents txtNbHeure As System.Windows.Forms.TextBox
    Friend WithEvents lblNbHeure As System.Windows.Forms.Label
    Friend WithEvents txtSalaire As System.Windows.Forms.TextBox
    Friend WithEvents lblSalaire As System.Windows.Forms.Label
    Friend WithEvents txtNAS As System.Windows.Forms.TextBox
    Friend WithEvents lblNas As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents panMethodes As System.Windows.Forms.Panel
    Friend WithEvents btmAugmenter As System.Windows.Forms.Button
    Friend WithEvents btmCalculer As System.Windows.Forms.Button
    Friend WithEvents btVacances As System.Windows.Forms.Button
    Friend WithEvents btmDetruire As System.Windows.Forms.Button

End Class
