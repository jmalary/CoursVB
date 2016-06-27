<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorloge
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
        Me.lblHorloge = New System.Windows.Forms.Label()
        Me.tmrHorloge = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblHorloge
        '
        Me.lblHorloge.AutoSize = True
        Me.lblHorloge.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorloge.Location = New System.Drawing.Point(25, 55)
        Me.lblHorloge.Name = "lblHorloge"
        Me.lblHorloge.Size = New System.Drawing.Size(0, 33)
        Me.lblHorloge.TabIndex = 0
        '
        'tmrHorloge
        '
        Me.tmrHorloge.Enabled = True
        Me.tmrHorloge.Interval = 1000
        '
        'frmHorloge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.lblHorloge)
        Me.Name = "frmHorloge"
        Me.Text = "Horloge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHorloge As System.Windows.Forms.Label
    Friend WithEvents tmrHorloge As System.Windows.Forms.Timer
End Class
