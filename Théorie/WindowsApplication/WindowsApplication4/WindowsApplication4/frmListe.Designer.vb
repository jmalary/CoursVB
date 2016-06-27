<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListe
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTaille = New System.Windows.Forms.ListBox()
        Me.cboNom = New System.Windows.Forms.ComboBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnTransfert = New System.Windows.Forms.Button()
        Me.btnTout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choissiez votre place"
        '
        'lstTaille
        '
        Me.lstTaille.FormattingEnabled = True
        Me.lstTaille.Items.AddRange(New Object() {"8", "10", "12", "18", "20", "24"})
        Me.lstTaille.Location = New System.Drawing.Point(28, 76)
        Me.lstTaille.Name = "lstTaille"
        Me.lstTaille.Size = New System.Drawing.Size(29, 95)
        Me.lstTaille.TabIndex = 1
        '
        'cboNom
        '
        Me.cboNom.FormattingEnabled = True
        Me.cboNom.Items.AddRange(New Object() {"Courier New", "Microsoft Sans Serif", "Times New Roman"})
        Me.cboNom.Location = New System.Drawing.Point(83, 76)
        Me.cboNom.Name = "cboNom"
        Me.cboNom.Size = New System.Drawing.Size(121, 21)
        Me.cboNom.Sorted = True
        Me.cboNom.TabIndex = 2
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(210, 74)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 3
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Bozo", "Coco", "Krusty", "Patol"})
        Me.ListBox1.Location = New System.Drawing.Point(28, 223)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(66, 95)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(243, 223)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(62, 95)
        Me.ListBox2.TabIndex = 5
        '
        'btnTransfert
        '
        Me.btnTransfert.Location = New System.Drawing.Point(129, 235)
        Me.btnTransfert.Name = "btnTransfert"
        Me.btnTransfert.Size = New System.Drawing.Size(75, 23)
        Me.btnTransfert.TabIndex = 6
        Me.btnTransfert.Text = ">"
        Me.btnTransfert.UseVisualStyleBackColor = True
        '
        'btnTout
        '
        Me.btnTout.Location = New System.Drawing.Point(129, 273)
        Me.btnTout.Name = "btnTout"
        Me.btnTout.Size = New System.Drawing.Size(75, 23)
        Me.btnTout.TabIndex = 7
        Me.btnTout.Text = ">>"
        Me.btnTout.UseVisualStyleBackColor = True
        '
        'frmListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 368)
        Me.Controls.Add(Me.btnTout)
        Me.Controls.Add(Me.btnTransfert)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.cboNom)
        Me.Controls.Add(Me.lstTaille)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListe"
        Me.Text = "Exemple de contrôles de liste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstTaille As System.Windows.Forms.ListBox
    Friend WithEvents cboNom As System.Windows.Forms.ComboBox
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnTransfert As System.Windows.Forms.Button
    Friend WithEvents btnTout As System.Windows.Forms.Button
End Class
