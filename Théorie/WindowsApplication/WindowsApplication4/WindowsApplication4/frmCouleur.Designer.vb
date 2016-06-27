<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCouleur
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
        Me.hsbRouge = New System.Windows.Forms.HScrollBar()
        Me.hsbVert = New System.Windows.Forms.HScrollBar()
        Me.hsbBleu = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hsbRouge
        '
        Me.hsbRouge.Location = New System.Drawing.Point(25, 92)
        Me.hsbRouge.Maximum = 255
        Me.hsbRouge.Name = "hsbRouge"
        Me.hsbRouge.Size = New System.Drawing.Size(209, 21)
        Me.hsbRouge.TabIndex = 0
        '
        'hsbVert
        '
        Me.hsbVert.Location = New System.Drawing.Point(25, 153)
        Me.hsbVert.Maximum = 255
        Me.hsbVert.Name = "hsbVert"
        Me.hsbVert.Size = New System.Drawing.Size(209, 21)
        Me.hsbVert.TabIndex = 1
        '
        'hsbBleu
        '
        Me.hsbBleu.Location = New System.Drawing.Point(28, 212)
        Me.hsbBleu.Maximum = 255
        Me.hsbBleu.Name = "hsbBleu"
        Me.hsbBleu.Size = New System.Drawing.Size(206, 22)
        Me.hsbBleu.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rouge"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vert"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bleu"
        '
        'frmCouleur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hsbBleu)
        Me.Controls.Add(Me.hsbVert)
        Me.Controls.Add(Me.hsbRouge)
        Me.Name = "frmCouleur"
        Me.Text = "Choissez la couleur de fond de la fenêtre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hsbRouge As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbVert As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbBleu As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
