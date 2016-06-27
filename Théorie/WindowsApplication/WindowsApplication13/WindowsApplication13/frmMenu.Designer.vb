<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExemplesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exemple1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exemple2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exemple3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExemplesToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExemplesToolStripMenuItem
        '
        Me.ExemplesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Exemple1ToolStripMenuItem, Me.Exemple2ToolStripMenuItem, Me.Exemple3ToolStripMenuItem})
        Me.ExemplesToolStripMenuItem.Name = "ExemplesToolStripMenuItem"
        Me.ExemplesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ExemplesToolStripMenuItem.Text = "Exemples"
        '
        'Exemple1ToolStripMenuItem
        '
        Me.Exemple1ToolStripMenuItem.Name = "Exemple1ToolStripMenuItem"
        Me.Exemple1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Exemple1ToolStripMenuItem.Text = "Exemple 1"
        '
        'Exemple2ToolStripMenuItem
        '
        Me.Exemple2ToolStripMenuItem.Name = "Exemple2ToolStripMenuItem"
        Me.Exemple2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Exemple2ToolStripMenuItem.Text = "Exemple 2"
        '
        'Exemple3ToolStripMenuItem
        '
        Me.Exemple3ToolStripMenuItem.Name = "Exemple3ToolStripMenuItem"
        Me.Exemple3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Exemple3ToolStripMenuItem.Text = "Exemple 3"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 329)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "Exemples de connexion à une base de données"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExemplesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exemple1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exemple2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exemple3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
