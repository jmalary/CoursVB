<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNAS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTaux = New System.Windows.Forms.TextBox()
        Me.btmCreer = New System.Windows.Forms.Button()
        Me.lstEmployes = New System.Windows.Forms.ListBox()
        Me.lblNbEmployes = New System.Windows.Forms.Label()
        Me.btmRetirer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstSalaire = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(149, 48)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAS:"
        '
        'txtNAS
        '
        Me.txtNAS.Location = New System.Drawing.Point(149, 83)
        Me.txtNAS.Name = "txtNAS"
        Me.txtNAS.Size = New System.Drawing.Size(100, 20)
        Me.txtNAS.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Taux horaire($/h)"
        '
        'txtTaux
        '
        Me.txtTaux.Location = New System.Drawing.Point(149, 126)
        Me.txtTaux.Name = "txtTaux"
        Me.txtTaux.Size = New System.Drawing.Size(100, 20)
        Me.txtTaux.TabIndex = 5
        '
        'btmCreer
        '
        Me.btmCreer.Location = New System.Drawing.Point(65, 179)
        Me.btmCreer.Name = "btmCreer"
        Me.btmCreer.Size = New System.Drawing.Size(75, 23)
        Me.btmCreer.TabIndex = 6
        Me.btmCreer.Text = "Créer"
        Me.btmCreer.UseVisualStyleBackColor = True
        '
        'lstEmployes
        '
        Me.lstEmployes.FormattingEnabled = True
        Me.lstEmployes.Location = New System.Drawing.Point(27, 233)
        Me.lstEmployes.Name = "lstEmployes"
        Me.lstEmployes.Size = New System.Drawing.Size(120, 95)
        Me.lstEmployes.TabIndex = 7
        '
        'lblNbEmployes
        '
        Me.lblNbEmployes.AutoSize = True
        Me.lblNbEmployes.Location = New System.Drawing.Point(286, 189)
        Me.lblNbEmployes.Name = "lblNbEmployes"
        Me.lblNbEmployes.Size = New System.Drawing.Size(106, 13)
        Me.lblNbEmployes.TabIndex = 8
        Me.lblNbEmployes.Text = "Nombre d'employé: 0"
        '
        'btmRetirer
        '
        Me.btmRetirer.Location = New System.Drawing.Point(289, 218)
        Me.btmRetirer.Name = "btmRetirer"
        Me.btmRetirer.Size = New System.Drawing.Size(75, 23)
        Me.btmRetirer.TabIndex = 9
        Me.btmRetirer.Text = "Retirer"
        Me.btmRetirer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Calculer les salaires"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstSalaire
        '
        Me.lstSalaire.FormattingEnabled = True
        Me.lstSalaire.Location = New System.Drawing.Point(255, 295)
        Me.lstSalaire.Name = "lstSalaire"
        Me.lstSalaire.Size = New System.Drawing.Size(120, 95)
        Me.lstSalaire.TabIndex = 11
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 451)
        Me.Controls.Add(Me.lstSalaire)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btmRetirer)
        Me.Controls.Add(Me.lblNbEmployes)
        Me.Controls.Add(Me.lstEmployes)
        Me.Controls.Add(Me.btmCreer)
        Me.Controls.Add(Me.txtTaux)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNAS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNAS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTaux As System.Windows.Forms.TextBox
    Friend WithEvents btmCreer As System.Windows.Forms.Button
    Friend WithEvents lstEmployes As System.Windows.Forms.ListBox
    Friend WithEvents lblNbEmployes As System.Windows.Forms.Label
    Friend WithEvents btmRetirer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstSalaire As System.Windows.Forms.ListBox

End Class
