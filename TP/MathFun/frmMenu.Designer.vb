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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtQuiz = New System.Windows.Forms.Button()
        Me.BtTable = New System.Windows.Forms.Button()
        Me.BtFraction = New System.Windows.Forms.Button()
        Me.btcalculatrice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calculatrice"
        '
        'BtQuiz
        '
        Me.BtQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtQuiz.Location = New System.Drawing.Point(29, 52)
        Me.BtQuiz.Name = "BtQuiz"
        Me.BtQuiz.Size = New System.Drawing.Size(75, 45)
        Me.BtQuiz.TabIndex = 2
        Me.BtQuiz.Text = "QUIZ?"
        Me.BtQuiz.UseVisualStyleBackColor = True
        '
        'BtTable
        '
        Me.BtTable.Location = New System.Drawing.Point(29, 181)
        Me.BtTable.Name = "BtTable"
        Me.BtTable.Size = New System.Drawing.Size(75, 52)
        Me.BtTable.TabIndex = 3
        Me.BtTable.Text = "Table"
        Me.BtTable.UseVisualStyleBackColor = True
        '
        'BtFraction
        '
        Me.BtFraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFraction.Location = New System.Drawing.Point(29, 113)
        Me.BtFraction.Name = "BtFraction"
        Me.BtFraction.Size = New System.Drawing.Size(75, 50)
        Me.BtFraction.TabIndex = 4
        Me.BtFraction.Text = "Fraction"
        Me.BtFraction.UseVisualStyleBackColor = True
        '
        'btcalculatrice
        '
        Me.btcalculatrice.Image = Global.MathFun.My.Resources.Resources.calculatrice
        Me.btcalculatrice.Location = New System.Drawing.Point(29, 255)
        Me.btcalculatrice.Name = "btcalculatrice"
        Me.btcalculatrice.Size = New System.Drawing.Size(75, 65)
        Me.btcalculatrice.TabIndex = 0
        Me.btcalculatrice.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(565, 391)
        Me.Controls.Add(Me.BtFraction)
        Me.Controls.Add(Me.BtTable)
        Me.Controls.Add(Me.BtQuiz)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btcalculatrice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMenu"
        Me.Text = "MathFun: Jouons avec les chiffres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btcalculatrice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtQuiz As System.Windows.Forms.Button
    Friend WithEvents BtTable As System.Windows.Forms.Button
    Friend WithEvents BtFraction As System.Windows.Forms.Button

End Class
