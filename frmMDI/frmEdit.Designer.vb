<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.txtBlocNotes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBlocNotes
        '
        Me.txtBlocNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBlocNotes.Location = New System.Drawing.Point(0, 0)
        Me.txtBlocNotes.Multiline = True
        Me.txtBlocNotes.Name = "txtBlocNotes"
        Me.txtBlocNotes.Size = New System.Drawing.Size(292, 266)
        Me.txtBlocNotes.TabIndex = 0
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtBlocNotes)
        Me.Name = "frmEdit"
        Me.Text = "Bloc-Notes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBlocNotes As System.Windows.Forms.TextBox
End Class
