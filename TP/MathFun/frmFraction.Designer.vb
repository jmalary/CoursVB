<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFraction
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
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.txtValue3 = New System.Windows.Forms.TextBox()
        Me.txtValue4 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblResultFrac1 = New System.Windows.Forms.Label()
        Me.lblResultFrac2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbDivision = New System.Windows.Forms.RadioButton()
        Me.RbMultplication = New System.Windows.Forms.RadioButton()
        Me.RBSoustraction = New System.Windows.Forms.RadioButton()
        Me.RBAddition = New System.Windows.Forms.RadioButton()
        Me.lblOperateur = New System.Windows.Forms.Label()
        Me.btCalculuer = New System.Windows.Forms.Button()
        Me.btReduire = New System.Windows.Forms.Button()
        Me.btFermer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValue1
        '
        Me.txtValue1.Location = New System.Drawing.Point(21, 47)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(30, 20)
        Me.txtValue1.TabIndex = 0
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(21, 83)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(30, 20)
        Me.txtValue2.TabIndex = 1
        '
        'txtValue3
        '
        Me.txtValue3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValue3.Location = New System.Drawing.Point(85, 47)
        Me.txtValue3.Name = "txtValue3"
        Me.txtValue3.Size = New System.Drawing.Size(30, 20)
        Me.txtValue3.TabIndex = 2
        '
        'txtValue4
        '
        Me.txtValue4.Location = New System.Drawing.Point(85, 81)
        Me.txtValue4.Name = "txtValue4"
        Me.txtValue4.Size = New System.Drawing.Size(30, 20)
        Me.txtValue4.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(383, 204)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 164
        Me.LineShape3.X2 = 211
        Me.LineShape3.Y1 = 74
        Me.LineShape3.Y2 = 74
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 85
        Me.LineShape2.X2 = 115
        Me.LineShape2.Y1 = 74
        Me.LineShape2.Y2 = 74
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 20
        Me.LineShape1.X2 = 49
        Me.LineShape1.Y1 = 75
        Me.LineShape1.Y2 = 75
        '
        'lblResultFrac1
        '
        Me.lblResultFrac1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultFrac1.Location = New System.Drawing.Point(162, 39)
        Me.lblResultFrac1.Name = "lblResultFrac1"
        Me.lblResultFrac1.Size = New System.Drawing.Size(56, 34)
        Me.lblResultFrac1.TabIndex = 5
        Me.lblResultFrac1.Text = "Label1"
        Me.lblResultFrac1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResultFrac2
        '
        Me.lblResultFrac2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultFrac2.Location = New System.Drawing.Point(162, 86)
        Me.lblResultFrac2.Name = "lblResultFrac2"
        Me.lblResultFrac2.Size = New System.Drawing.Size(56, 25)
        Me.lblResultFrac2.TabIndex = 6
        Me.lblResultFrac2.Text = "Label2"
        Me.lblResultFrac2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "="
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbDivision)
        Me.GroupBox1.Controls.Add(Me.RbMultplication)
        Me.GroupBox1.Controls.Add(Me.RBSoustraction)
        Me.GroupBox1.Controls.Add(Me.RBAddition)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(275, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 189)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opérateur"
        '
        'RbDivision
        '
        Me.RbDivision.AutoSize = True
        Me.RbDivision.Location = New System.Drawing.Point(6, 163)
        Me.RbDivision.Name = "RbDivision"
        Me.RbDivision.Size = New System.Drawing.Size(31, 20)
        Me.RbDivision.TabIndex = 13
        Me.RbDivision.Tag = "/"
        Me.RbDivision.Text = "/"
        Me.RbDivision.UseVisualStyleBackColor = True
        '
        'RbMultplication
        '
        Me.RbMultplication.AutoSize = True
        Me.RbMultplication.Location = New System.Drawing.Point(6, 112)
        Me.RbMultplication.Name = "RbMultplication"
        Me.RbMultplication.Size = New System.Drawing.Size(32, 20)
        Me.RbMultplication.TabIndex = 12
        Me.RbMultplication.Tag = "*"
        Me.RbMultplication.Text = "*"
        Me.RbMultplication.UseVisualStyleBackColor = True
        '
        'RBSoustraction
        '
        Me.RBSoustraction.AutoSize = True
        Me.RBSoustraction.Location = New System.Drawing.Point(6, 67)
        Me.RBSoustraction.Name = "RBSoustraction"
        Me.RBSoustraction.Size = New System.Drawing.Size(31, 20)
        Me.RBSoustraction.TabIndex = 11
        Me.RBSoustraction.Tag = "-"
        Me.RBSoustraction.Text = "-"
        Me.RBSoustraction.UseVisualStyleBackColor = True
        '
        'RBAddition
        '
        Me.RBAddition.AutoSize = True
        Me.RBAddition.Location = New System.Drawing.Point(6, 21)
        Me.RBAddition.Name = "RBAddition"
        Me.RBAddition.Size = New System.Drawing.Size(34, 20)
        Me.RBAddition.TabIndex = 10
        Me.RBAddition.Tag = "+"
        Me.RBAddition.Text = "+"
        Me.RBAddition.UseVisualStyleBackColor = True
        '
        'lblOperateur
        '
        Me.lblOperateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperateur.Location = New System.Drawing.Point(60, 67)
        Me.lblOperateur.Name = "lblOperateur"
        Me.lblOperateur.Size = New System.Drawing.Size(17, 20)
        Me.lblOperateur.TabIndex = 11
        Me.lblOperateur.Tag = "+"
        Me.lblOperateur.Text = "+"
        '
        'btCalculuer
        '
        Me.btCalculuer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalculuer.Location = New System.Drawing.Point(18, 157)
        Me.btCalculuer.Name = "btCalculuer"
        Me.btCalculuer.Size = New System.Drawing.Size(75, 23)
        Me.btCalculuer.TabIndex = 12
        Me.btCalculuer.Text = "Calculer"
        Me.btCalculuer.UseVisualStyleBackColor = True
        '
        'btReduire
        '
        Me.btReduire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReduire.Location = New System.Drawing.Point(98, 157)
        Me.btReduire.Name = "btReduire"
        Me.btReduire.Size = New System.Drawing.Size(114, 23)
        Me.btReduire.TabIndex = 13
        Me.btReduire.Text = "Réduire Fraction"
        Me.btReduire.UseVisualStyleBackColor = True
        '
        'btFermer
        '
        Me.btFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFermer.Location = New System.Drawing.Point(20, 181)
        Me.btFermer.Name = "btFermer"
        Me.btFermer.Size = New System.Drawing.Size(192, 23)
        Me.btFermer.TabIndex = 14
        Me.btFermer.Text = "Fermer"
        Me.btFermer.UseVisualStyleBackColor = True
        '
        'frmFraction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 204)
        Me.Controls.Add(Me.btFermer)
        Me.Controls.Add(Me.btReduire)
        Me.Controls.Add(Me.btCalculuer)
        Me.Controls.Add(Me.lblOperateur)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultFrac2)
        Me.Controls.Add(Me.lblResultFrac1)
        Me.Controls.Add(Me.txtValue4)
        Me.Controls.Add(Me.txtValue3)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.txtValue1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmFraction"
        Me.Text = "Fraction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValue1 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue2 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue3 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue4 As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblResultFrac1 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblResultFrac2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbDivision As System.Windows.Forms.RadioButton
    Friend WithEvents RbMultplication As System.Windows.Forms.RadioButton
    Friend WithEvents RBSoustraction As System.Windows.Forms.RadioButton
    Friend WithEvents RBAddition As System.Windows.Forms.RadioButton
    Friend WithEvents lblOperateur As System.Windows.Forms.Label
    Friend WithEvents btCalculuer As System.Windows.Forms.Button
    Friend WithEvents btReduire As System.Windows.Forms.Button
    Friend WithEvents btFermer As System.Windows.Forms.Button
End Class
