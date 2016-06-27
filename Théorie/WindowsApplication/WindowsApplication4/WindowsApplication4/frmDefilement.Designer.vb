<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefilement
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Ovale = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.hsbLongueur = New System.Windows.Forms.HScrollBar()
        Me.vsbHauteur = New System.Windows.Forms.VScrollBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Ovale})
        Me.ShapeContainer1.Size = New System.Drawing.Size(525, 430)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Ovale
        '
        Me.Ovale.BorderColor = System.Drawing.Color.Red
        Me.Ovale.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Ovale.BorderWidth = 5
        Me.Ovale.FillColor = System.Drawing.Color.Blue
        Me.Ovale.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.ForwardDiagonal
        Me.Ovale.Location = New System.Drawing.Point(93, 96)
        Me.Ovale.Name = "Ovale"
        Me.Ovale.Size = New System.Drawing.Size(69, 54)
        '
        'hsbLongueur
        '
        Me.hsbLongueur.Location = New System.Drawing.Point(40, 303)
        Me.hsbLongueur.Maximum = 200
        Me.hsbLongueur.Name = "hsbLongueur"
        Me.hsbLongueur.Size = New System.Drawing.Size(312, 19)
        Me.hsbLongueur.TabIndex = 1
        Me.hsbLongueur.Value = 70
        '
        'vsbHauteur
        '
        Me.vsbHauteur.Location = New System.Drawing.Point(323, 43)
        Me.vsbHauteur.Maximum = 200
        Me.vsbHauteur.Name = "vsbHauteur"
        Me.vsbHauteur.Size = New System.Drawing.Size(29, 193)
        Me.vsbHauteur.TabIndex = 2
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(40, 339)
        Me.TrackBar1.Maximum = 5
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(312, 45)
        Me.TrackBar1.TabIndex = 3
        Me.TrackBar1.Value = 1
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(376, 123)
        Me.TrackBar2.Maximum = 5
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrackBar2.Size = New System.Drawing.Size(45, 104)
        Me.TrackBar2.TabIndex = 4
        Me.TrackBar2.Value = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(63, 176)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'frmDefilement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 430)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.vsbHauteur)
        Me.Controls.Add(Me.hsbLongueur)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmDefilement"
        Me.Text = "Barre de défilement et controle graphique"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Ovale As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents hsbLongueur As System.Windows.Forms.HScrollBar
    Friend WithEvents vsbHauteur As System.Windows.Forms.VScrollBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
