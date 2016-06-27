<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.comboOperation = New System.Windows.Forms.ComboBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.btmFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.Location = New System.Drawing.Point(22, 9)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(136, 29)
        Me.lblOperation.TabIndex = 0
        Me.lblOperation.Text = "Opération:"
        '
        'comboOperation
        '
        Me.comboOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboOperation.FormattingEnabled = True
        Me.comboOperation.Items.AddRange(New Object() {"Addition", "Soustraction", "Multiplication", "Modulo"})
        Me.comboOperation.Location = New System.Drawing.Point(27, 41)
        Me.comboOperation.Name = "comboOperation"
        Me.comboOperation.Size = New System.Drawing.Size(320, 33)
        Me.comboOperation.TabIndex = 5
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(35, 84)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(41, 39)
        Me.lblA.TabIndex = 2
        Me.lblA.Text = "A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(281, 84)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(41, 39)
        Me.lblB.TabIndex = 3
        Me.lblB.Text = "B"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(42, 135)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(77, 31)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(275, 135)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(72, 31)
        Me.txtB.TabIndex = 1
        '
        'lblOp
        '
        Me.lblOp.AutoSize = True
        Me.lblOp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp.Location = New System.Drawing.Point(144, 135)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.Size = New System.Drawing.Size(111, 37)
        Me.lblOp.TabIndex = 6
        Me.lblOp.Text = "Label1"
        Me.lblOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculer
        '
        Me.btnCalculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculer.Location = New System.Drawing.Point(42, 192)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(305, 38)
        Me.btnCalculer.TabIndex = 3
        Me.btnCalculer.Text = "Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'lblResultat
        '
        Me.lblResultat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblResultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblResultat.Location = New System.Drawing.Point(39, 245)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(308, 68)
        Me.lblResultat.TabIndex = 8
        Me.lblResultat.Text = "Label1"
        Me.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btmFermer
        '
        Me.btmFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btmFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmFermer.Location = New System.Drawing.Point(42, 330)
        Me.btmFermer.Name = "btmFermer"
        Me.btmFermer.Size = New System.Drawing.Size(305, 44)
        Me.btmFermer.TabIndex = 4
        Me.btmFermer.Text = "&Femer"
        Me.btmFermer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btmFermer
        Me.ClientSize = New System.Drawing.Size(380, 396)
        Me.ControlBox = False
        Me.Controls.Add(Me.btmFermer)
        Me.Controls.Add(Me.lblResultat)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.lblOp)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.comboOperation)
        Me.Controls.Add(Me.lblOperation)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Calculatrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents comboOperation As System.Windows.Forms.ComboBox
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lblOp As System.Windows.Forms.Label
    Friend WithEvents btnCalculer As System.Windows.Forms.Button
    Friend WithEvents lblResultat As System.Windows.Forms.Label
    Friend WithEvents btmFermer As System.Windows.Forms.Button

End Class
