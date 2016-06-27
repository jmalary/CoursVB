<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogue
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnPolice = New System.Windows.Forms.Button()
        Me.btnCouleur = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnCouleurText = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(268, 51)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Vive les vacances !"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPolice
        '
        Me.btnPolice.AutoSize = True
        Me.btnPolice.Location = New System.Drawing.Point(24, 75)
        Me.btnPolice.Name = "btnPolice"
        Me.btnPolice.Size = New System.Drawing.Size(99, 70)
        Me.btnPolice.TabIndex = 1
        Me.btnPolice.Text = "Changer la police"
        Me.btnPolice.UseVisualStyleBackColor = True
        '
        'btnCouleur
        '
        Me.btnCouleur.Location = New System.Drawing.Point(148, 75)
        Me.btnCouleur.Name = "btnCouleur"
        Me.btnCouleur.Size = New System.Drawing.Size(115, 70)
        Me.btnCouleur.TabIndex = 2
        Me.btnCouleur.Text = "Changer la couleur de la feuille"
        Me.btnCouleur.UseVisualStyleBackColor = True
        '
        'FontDialog1
        '
        '
        'btnCouleurText
        '
        Me.btnCouleurText.Location = New System.Drawing.Point(24, 163)
        Me.btnCouleurText.Name = "btnCouleurText"
        Me.btnCouleurText.Size = New System.Drawing.Size(108, 75)
        Me.btnCouleurText.TabIndex = 3
        Me.btnCouleurText.Text = "Changer la couleur du texte"
        Me.btnCouleurText.UseVisualStyleBackColor = True
        '
        'frmDialogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnCouleurText)
        Me.Controls.Add(Me.btnCouleur)
        Me.Controls.Add(Me.btnPolice)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmDialogue"
        Me.Text = "Exemple de boîtes de dialogue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnPolice As System.Windows.Forms.Button
    Friend WithEvents btnCouleur As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnCouleurText As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog2 As System.Windows.Forms.ColorDialog
End Class
