<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitreArticle = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.btmCreer = New System.Windows.Forms.Button()
        Me.lblTitreStock = New System.Windows.Forms.Label()
        Me.lblQuantite = New System.Windows.Forms.Label()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.btmEntree = New System.Windows.Forms.Button()
        Me.btmSortie = New System.Windows.Forms.Button()
        Me.lblQuantiteEnStock = New System.Windows.Forms.Label()
        Me.lblAffStock = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btmFermer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitreArticle
        '
        Me.lblTitreArticle.AutoSize = True
        Me.lblTitreArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreArticle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitreArticle.Name = "lblTitreArticle"
        Me.lblTitreArticle.Size = New System.Drawing.Size(79, 25)
        Me.lblTitreArticle.TabIndex = 0
        Me.lblTitreArticle.Text = "Article"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef.Location = New System.Drawing.Point(19, 46)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(78, 20)
        Me.lblRef.TabIndex = 1
        Me.lblRef.Text = "Ref.      :"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(19, 79)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(80, 20)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom      :"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(19, 113)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(80, 20)
        Me.lblStock.TabIndex = 3
        Me.lblStock.Text = "Stock    :"
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(100, 46)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(100, 20)
        Me.txtRef.TabIndex = 4
        '
        'txtNom
        '
        Me.txtNom.AcceptsReturn = True
        Me.txtNom.Location = New System.Drawing.Point(100, 81)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 5
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(100, 115)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 6
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(293, 90)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(93, 20)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "Stock min."
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(446, 90)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(97, 20)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "Stock max."
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(286, 115)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 20)
        Me.txtMin.TabIndex = 9
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(450, 115)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 20)
        Me.txtMax.TabIndex = 10
        '
        'btmCreer
        '
        Me.btmCreer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmCreer.Location = New System.Drawing.Point(22, 157)
        Me.btmCreer.Name = "btmCreer"
        Me.btmCreer.Size = New System.Drawing.Size(528, 45)
        Me.btmCreer.TabIndex = 11
        Me.btmCreer.Text = "Créer Article"
        Me.btmCreer.UseVisualStyleBackColor = True
        '
        'lblTitreStock
        '
        Me.lblTitreStock.AutoSize = True
        Me.lblTitreStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreStock.Location = New System.Drawing.Point(12, 231)
        Me.lblTitreStock.Name = "lblTitreStock"
        Me.lblTitreStock.Size = New System.Drawing.Size(71, 25)
        Me.lblTitreStock.TabIndex = 12
        Me.lblTitreStock.Text = "Stock"
        '
        'lblQuantite
        '
        Me.lblQuantite.AutoSize = True
        Me.lblQuantite.Enabled = False
        Me.lblQuantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantite.Location = New System.Drawing.Point(43, 273)
        Me.lblQuantite.Name = "lblQuantite"
        Me.lblQuantite.Size = New System.Drawing.Size(93, 20)
        Me.lblQuantite.TabIndex = 13
        Me.lblQuantite.Text = "Quantité  :"
        '
        'txtQuantite
        '
        Me.txtQuantite.Enabled = False
        Me.txtQuantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantite.Location = New System.Drawing.Point(47, 312)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.Size = New System.Drawing.Size(153, 26)
        Me.txtQuantite.TabIndex = 14
        '
        'btmEntree
        '
        Me.btmEntree.Enabled = False
        Me.btmEntree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmEntree.Location = New System.Drawing.Point(47, 349)
        Me.btmEntree.Name = "btmEntree"
        Me.btmEntree.Size = New System.Drawing.Size(153, 30)
        Me.btmEntree.TabIndex = 15
        Me.btmEntree.Text = "Entrée en stock"
        Me.btmEntree.UseVisualStyleBackColor = True
        '
        'btmSortie
        '
        Me.btmSortie.Enabled = False
        Me.btmSortie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmSortie.Location = New System.Drawing.Point(47, 385)
        Me.btmSortie.Name = "btmSortie"
        Me.btmSortie.Size = New System.Drawing.Size(153, 30)
        Me.btmSortie.TabIndex = 16
        Me.btmSortie.Text = "Sortie du stock"
        Me.btmSortie.UseVisualStyleBackColor = True
        '
        'lblQuantiteEnStock
        '
        Me.lblQuantiteEnStock.AutoSize = True
        Me.lblQuantiteEnStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantiteEnStock.Location = New System.Drawing.Point(360, 232)
        Me.lblQuantiteEnStock.Name = "lblQuantiteEnStock"
        Me.lblQuantiteEnStock.Size = New System.Drawing.Size(190, 24)
        Me.lblQuantiteEnStock.TabIndex = 17
        Me.lblQuantiteEnStock.Text = "Quantité en stock  :"
        '
        'lblAffStock
        '
        Me.lblAffStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAffStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAffStock.Location = New System.Drawing.Point(361, 273)
        Me.lblAffStock.Name = "lblAffStock"
        Me.lblAffStock.Size = New System.Drawing.Size(189, 142)
        Me.lblAffStock.TabIndex = 18
        Me.lblAffStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(20, 449)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(530, 52)
        Me.lblMessage.TabIndex = 19
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btmFermer
        '
        Me.btmFermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmFermer.Location = New System.Drawing.Point(22, 517)
        Me.btmFermer.Name = "btmFermer"
        Me.btmFermer.Size = New System.Drawing.Size(528, 44)
        Me.btmFermer.TabIndex = 20
        Me.btmFermer.Text = "Fermer"
        Me.btmFermer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 570)
        Me.Controls.Add(Me.btmFermer)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblAffStock)
        Me.Controls.Add(Me.lblQuantiteEnStock)
        Me.Controls.Add(Me.btmSortie)
        Me.Controls.Add(Me.btmEntree)
        Me.Controls.Add(Me.txtQuantite)
        Me.Controls.Add(Me.lblQuantite)
        Me.Controls.Add(Me.lblTitreStock)
        Me.Controls.Add(Me.btmCreer)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblRef)
        Me.Controls.Add(Me.lblTitreArticle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitreArticle As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents btmCreer As System.Windows.Forms.Button
    Friend WithEvents lblTitreStock As System.Windows.Forms.Label
    Friend WithEvents lblQuantite As System.Windows.Forms.Label
    Friend WithEvents txtQuantite As System.Windows.Forms.TextBox
    Friend WithEvents btmEntree As System.Windows.Forms.Button
    Friend WithEvents btmSortie As System.Windows.Forms.Button
    Friend WithEvents lblQuantiteEnStock As System.Windows.Forms.Label
    Friend WithEvents lblAffStock As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Protected WithEvents btmFermer As System.Windows.Forms.Button

End Class
