<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChrono
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
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.btnDemarrer = New System.Windows.Forms.Button()
        Me.btnArreter = New System.Windows.Forms.Button()
        Me.btnReinst = New System.Windows.Forms.Button()
        Me.tmrChrono = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblChrono
        '
        Me.lblChrono.AutoSize = True
        Me.lblChrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblChrono.Location = New System.Drawing.Point(12, 25)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(143, 37)
        Me.lblChrono.TabIndex = 0
        Me.lblChrono.Text = "00:00:00"
        '
        'btnDemarrer
        '
        Me.btnDemarrer.Location = New System.Drawing.Point(33, 96)
        Me.btnDemarrer.Name = "btnDemarrer"
        Me.btnDemarrer.Size = New System.Drawing.Size(75, 23)
        Me.btnDemarrer.TabIndex = 1
        Me.btnDemarrer.Text = "Démarrer"
        Me.btnDemarrer.UseVisualStyleBackColor = True
        '
        'btnArreter
        '
        Me.btnArreter.Enabled = False
        Me.btnArreter.Location = New System.Drawing.Point(33, 138)
        Me.btnArreter.Name = "btnArreter"
        Me.btnArreter.Size = New System.Drawing.Size(75, 23)
        Me.btnArreter.TabIndex = 2
        Me.btnArreter.Text = "Arreter"
        Me.btnArreter.UseVisualStyleBackColor = True
        '
        'btnReinst
        '
        Me.btnReinst.Enabled = False
        Me.btnReinst.Location = New System.Drawing.Point(33, 177)
        Me.btnReinst.Name = "btnReinst"
        Me.btnReinst.Size = New System.Drawing.Size(75, 23)
        Me.btnReinst.TabIndex = 3
        Me.btnReinst.Text = "Réinitialiser"
        Me.btnReinst.UseVisualStyleBackColor = True
        '
        'tmrChrono
        '
        Me.tmrChrono.Interval = 1000
        '
        'frmChrono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 266)
        Me.Controls.Add(Me.btnReinst)
        Me.Controls.Add(Me.btnArreter)
        Me.Controls.Add(Me.btnDemarrer)
        Me.Controls.Add(Me.lblChrono)
        Me.Name = "frmChrono"
        Me.Text = "Chronomètre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChrono As System.Windows.Forms.Label
    Friend WithEvents btnDemarrer As System.Windows.Forms.Button
    Friend WithEvents btnArreter As System.Windows.Forms.Button
    Friend WithEvents btnReinst As System.Windows.Forms.Button
    Friend WithEvents tmrChrono As System.Windows.Forms.Timer
End Class
