<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FichierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FenêtreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeHorizontaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeVerticcaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangerLesIcônesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IcônesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 26)
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(117, 26)
        '
        'FichierToolStripMenuItem1
        '
        Me.FichierToolStripMenuItem1.Name = "FichierToolStripMenuItem1"
        Me.FichierToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.FichierToolStripMenuItem1.Text = "Fichier"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem2, Me.FenêtreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem2
        '
        Me.FichierToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem})
        Me.FichierToolStripMenuItem2.Name = "FichierToolStripMenuItem2"
        Me.FichierToolStripMenuItem2.Size = New System.Drawing.Size(50, 20)
        Me.FichierToolStripMenuItem2.Text = "Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'FenêtreToolStripMenuItem
        '
        Me.FenêtreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeHorizontaleToolStripMenuItem, Me.CascadeVerticcaleToolStripMenuItem, Me.ArrangerLesIcônesToolStripMenuItem, Me.IcônesToolStripMenuItem})
        Me.FenêtreToolStripMenuItem.Name = "FenêtreToolStripMenuItem"
        Me.FenêtreToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FenêtreToolStripMenuItem.Text = "Fenêtre"
        '
        'CascadeHorizontaleToolStripMenuItem
        '
        Me.CascadeHorizontaleToolStripMenuItem.Name = "CascadeHorizontaleToolStripMenuItem"
        Me.CascadeHorizontaleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CascadeHorizontaleToolStripMenuItem.Text = "Cascade Horizontale"
        '
        'CascadeVerticcaleToolStripMenuItem
        '
        Me.CascadeVerticcaleToolStripMenuItem.Name = "CascadeVerticcaleToolStripMenuItem"
        Me.CascadeVerticcaleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CascadeVerticcaleToolStripMenuItem.Text = "Cascade verticcale"
        '
        'ArrangerLesIcônesToolStripMenuItem
        '
        Me.ArrangerLesIcônesToolStripMenuItem.Name = "ArrangerLesIcônesToolStripMenuItem"
        Me.ArrangerLesIcônesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ArrangerLesIcônesToolStripMenuItem.Text = "Arranger les icônes"
        '
        'IcônesToolStripMenuItem
        '
        Me.IcônesToolStripMenuItem.Name = "IcônesToolStripMenuItem"
        Me.IcônesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.IcônesToolStripMenuItem.Text = "Icônes"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "Fenêtre MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FichierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FenêtreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeHorizontaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeVerticcaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangerLesIcônesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcônesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
