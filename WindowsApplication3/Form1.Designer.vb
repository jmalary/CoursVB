<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.rbChien = New System.Windows.Forms.RadioButton()
        Me.rdHumaine = New System.Windows.Forms.RadioButton()
        Me.lstAnimal = New System.Windows.Forms.ListBox()
        Me.btmAfficher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(12, 44)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(123, 76)
        Me.btnAjouter.TabIndex = 0
        Me.btnAjouter.Text = "Ajouter un individu"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'rbChien
        '
        Me.rbChien.AutoSize = True
        Me.rbChien.Checked = True
        Me.rbChien.Location = New System.Drawing.Point(160, 44)
        Me.rbChien.Name = "rbChien"
        Me.rbChien.Size = New System.Drawing.Size(52, 17)
        Me.rbChien.TabIndex = 1
        Me.rbChien.TabStop = True
        Me.rbChien.Text = "Chien"
        Me.rbChien.UseVisualStyleBackColor = True
        '
        'rdHumaine
        '
        Me.rdHumaine.AutoSize = True
        Me.rdHumaine.Location = New System.Drawing.Point(160, 74)
        Me.rdHumaine.Name = "rdHumaine"
        Me.rdHumaine.Size = New System.Drawing.Size(67, 17)
        Me.rdHumaine.TabIndex = 2
        Me.rdHumaine.Text = "Humaine"
        Me.rdHumaine.UseVisualStyleBackColor = True
        '
        'lstAnimal
        '
        Me.lstAnimal.FormattingEnabled = True
        Me.lstAnimal.Location = New System.Drawing.Point(175, 161)
        Me.lstAnimal.Name = "lstAnimal"
        Me.lstAnimal.Size = New System.Drawing.Size(120, 95)
        Me.lstAnimal.TabIndex = 3
        '
        'btmAfficher
        '
        Me.btmAfficher.Location = New System.Drawing.Point(12, 186)
        Me.btmAfficher.Name = "btmAfficher"
        Me.btmAfficher.Size = New System.Drawing.Size(123, 38)
        Me.btmAfficher.TabIndex = 4
        Me.btmAfficher.Text = "Afficher la liste"
        Me.btmAfficher.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 315)
        Me.Controls.Add(Me.btmAfficher)
        Me.Controls.Add(Me.lstAnimal)
        Me.Controls.Add(Me.rdHumaine)
        Me.Controls.Add(Me.rbChien)
        Me.Controls.Add(Me.btnAjouter)
        Me.Name = "Form1"
        Me.Tag = " "
        Me.Text = "Exemple d'interface et de classe abstraite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents rbChien As System.Windows.Forms.RadioButton
    Friend WithEvents rdHumaine As System.Windows.Forms.RadioButton
    Friend WithEvents lstAnimal As System.Windows.Forms.ListBox
    Friend WithEvents btmAfficher As System.Windows.Forms.Button

End Class
