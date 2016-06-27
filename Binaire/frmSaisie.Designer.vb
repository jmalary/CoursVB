<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisie
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
        Me.txtSalaire = New System.Windows.Forms.TextBox()
        Me.btmEnregistrer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(79, 28)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salaire"
        '
        'txtSalaire
        '
        Me.txtSalaire.Location = New System.Drawing.Point(79, 72)
        Me.txtSalaire.Name = "txtSalaire"
        Me.txtSalaire.Size = New System.Drawing.Size(100, 20)
        Me.txtSalaire.TabIndex = 3
        '
        'btmEnregistrer
        '
        Me.btmEnregistrer.Location = New System.Drawing.Point(79, 141)
        Me.btmEnregistrer.Name = "btmEnregistrer"
        Me.btmEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.btmEnregistrer.TabIndex = 4
        Me.btmEnregistrer.Text = "Enregistrer"
        Me.btmEnregistrer.UseVisualStyleBackColor = True
        '
        'frmSaisie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btmEnregistrer)
        Me.Controls.Add(Me.txtSalaire)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSaisie"
        Me.Text = "Saisie d'une personne"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalaire As System.Windows.Forms.TextBox
    Friend WithEvents btmEnregistrer As System.Windows.Forms.Button
End Class
