<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAffichage
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
        Me.btmAfficher = New System.Windows.Forms.Button()
        Me.lstPersonnes = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btmAfficher
        '
        Me.btmAfficher.Location = New System.Drawing.Point(35, 43)
        Me.btmAfficher.Name = "btmAfficher"
        Me.btmAfficher.Size = New System.Drawing.Size(75, 23)
        Me.btmAfficher.TabIndex = 0
        Me.btmAfficher.Text = "Afficher la liste"
        Me.btmAfficher.UseVisualStyleBackColor = True
        '
        'lstPersonnes
        '
        Me.lstPersonnes.FormattingEnabled = True
        Me.lstPersonnes.Location = New System.Drawing.Point(35, 84)
        Me.lstPersonnes.Name = "lstPersonnes"
        Me.lstPersonnes.Size = New System.Drawing.Size(120, 95)
        Me.lstPersonnes.TabIndex = 1
        '
        'frmAffichage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.lstPersonnes)
        Me.Controls.Add(Me.btmAfficher)
        Me.Name = "frmAffichage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Lecture de fichier"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btmAfficher As System.Windows.Forms.Button
    Friend WithEvents lstPersonnes As System.Windows.Forms.ListBox
End Class
