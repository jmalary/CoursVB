<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.btmDepart = New System.Windows.Forms.Button()
        Me.btmRecommencer = New System.Windows.Forms.Button()
        Me.TmrCourse = New System.Windows.Forms.Timer()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.linArrive = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'btmDepart
        '
        Me.btmDepart.Location = New System.Drawing.Point(12, 153)
        Me.btmDepart.Name = "btmDepart"
        Me.btmDepart.Size = New System.Drawing.Size(93, 38)
        Me.btmDepart.TabIndex = 0
        Me.btmDepart.Text = "Départ"
        Me.btmDepart.UseVisualStyleBackColor = True
        '
        'btmRecommencer
        '
        Me.btmRecommencer.Location = New System.Drawing.Point(138, 153)
        Me.btmRecommencer.Name = "btmRecommencer"
        Me.btmRecommencer.Size = New System.Drawing.Size(90, 34)
        Me.btmRecommencer.TabIndex = 1
        Me.btmRecommencer.Text = "Recommencer"
        Me.btmRecommencer.UseVisualStyleBackColor = True
        '
        'TmrCourse
        '
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linArrive})
        Me.ShapeContainer1.Size = New System.Drawing.Size(292, 266)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'linArrive
        '
        Me.linArrive.Name = "linArrive"
        Me.linArrive.X1 = 240
        Me.linArrive.X2 = 240
        Me.linArrive.Y1 = 12
        Me.linArrive.Y2 = 112
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btmRecommencer)
        Me.Controls.Add(Me.btmDepart)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmCourse"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btmDepart As System.Windows.Forms.Button
    Friend WithEvents btmRecommencer As System.Windows.Forms.Button
    Friend WithEvents TmrCourse As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents linArrive As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
