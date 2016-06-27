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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Btn_Liste_Cheque = New System.Windows.Forms.Button()
        Me.Btm_Paiement_direct = New System.Windows.Forms.Button()
        Me.Btm_Preautorise = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(152, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(514, 113)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ajouter une chèque"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(152, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(514, 113)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ajouter un paiement"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(147, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(514, 113)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ajouter un fournisseur"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Btn_Liste_Cheque
        '
        Me.Btn_Liste_Cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Liste_Cheque.Location = New System.Drawing.Point(702, 57)
        Me.Btn_Liste_Cheque.Name = "Btn_Liste_Cheque"
        Me.Btn_Liste_Cheque.Size = New System.Drawing.Size(514, 113)
        Me.Btn_Liste_Cheque.TabIndex = 5
        Me.Btn_Liste_Cheque.Text = "Liste des cheques"
        Me.Btn_Liste_Cheque.UseVisualStyleBackColor = True
        '
        'Btm_Paiement_direct
        '
        Me.Btm_Paiement_direct.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_Paiement_direct.Location = New System.Drawing.Point(702, 207)
        Me.Btm_Paiement_direct.Name = "Btm_Paiement_direct"
        Me.Btm_Paiement_direct.Size = New System.Drawing.Size(514, 113)
        Me.Btm_Paiement_direct.TabIndex = 6
        Me.Btm_Paiement_direct.Text = "Liste des paiements direct"
        Me.Btm_Paiement_direct.UseVisualStyleBackColor = True
        '
        'Btm_Preautorise
        '
        Me.Btm_Preautorise.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btm_Preautorise.Location = New System.Drawing.Point(702, 331)
        Me.Btm_Preautorise.Name = "Btm_Preautorise"
        Me.Btm_Preautorise.Size = New System.Drawing.Size(514, 113)
        Me.Btm_Preautorise.TabIndex = 7
        Me.Btm_Preautorise.Text = "Liste des paiement preautorise"
        Me.Btm_Preautorise.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(138, 461)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(1078, 113)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Gestion de fond de roulement"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(285, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date: "
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 675)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Btm_Preautorise)
        Me.Controls.Add(Me.Btm_Paiement_direct)
        Me.Controls.Add(Me.Btn_Liste_Cheque)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(350, 350)
        Me.Name = "frmMenu"
        Me.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Liste_Cheque As System.Windows.Forms.Button
    Friend WithEvents Btm_Paiement_direct As System.Windows.Forms.Button
    Friend WithEvents Btm_Preautorise As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
