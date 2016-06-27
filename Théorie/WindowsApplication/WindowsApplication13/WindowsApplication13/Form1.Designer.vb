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
        Me.components = New System.ComponentModel.Container()
        Me.lstTitre = New System.Windows.Forms.ListBox()
        Me.lstComplete = New System.Windows.Forms.ListBox()
        Me.btnAfficher = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusiqueDataSet = New WindowsApplication1.musiqueDataSet()
        Me.TitreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitreTableAdapter = New WindowsApplication1.musiqueDataSetTableAdapters.TitreTableAdapter()
        Me.TitreBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusiqueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitreBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTitre
        '
        Me.lstTitre.DataSource = Me.TitreBindingSource1
        Me.lstTitre.DisplayMember = "Titre"
        Me.lstTitre.FormattingEnabled = True
        Me.lstTitre.Location = New System.Drawing.Point(1, 55)
        Me.lstTitre.Name = "lstTitre"
        Me.lstTitre.Size = New System.Drawing.Size(102, 147)
        Me.lstTitre.TabIndex = 0
        '
        'lstComplete
        '
        Me.lstComplete.FormattingEnabled = True
        Me.lstComplete.Location = New System.Drawing.Point(109, 55)
        Me.lstComplete.Name = "lstComplete"
        Me.lstComplete.Size = New System.Drawing.Size(163, 147)
        Me.lstComplete.TabIndex = 1
        '
        'btnAfficher
        '
        Me.btnAfficher.Location = New System.Drawing.Point(109, 12)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(75, 23)
        Me.btnAfficher.TabIndex = 2
        Me.btnAfficher.Text = "Afficher"
        Me.btnAfficher.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.MusiqueDataSet
        Me.BindingSource1.Position = 0
        '
        'MusiqueDataSet
        '
        Me.MusiqueDataSet.DataSetName = "musiqueDataSet"
        Me.MusiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitreBindingSource
        '
        Me.TitreBindingSource.DataMember = "Titre"
        Me.TitreBindingSource.DataSource = Me.BindingSource1
        '
        'TitreTableAdapter
        '
        Me.TitreTableAdapter.ClearBeforeFill = True
        '
        'TitreBindingSource1
        '
        Me.TitreBindingSource1.DataMember = "Titre"
        Me.TitreBindingSource1.DataSource = Me.BindingSource1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnAfficher)
        Me.Controls.Add(Me.lstComplete)
        Me.Controls.Add(Me.lstTitre)
        Me.Name = "Form1"
        Me.Text = "Exemple avec ListBox"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusiqueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitreBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstTitre As System.Windows.Forms.ListBox
    Friend WithEvents lstComplete As System.Windows.Forms.ListBox
    Friend WithEvents btnAfficher As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MusiqueDataSet As WindowsApplication1.musiqueDataSet
    Friend WithEvents TitreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitreTableAdapter As WindowsApplication1.musiqueDataSetTableAdapters.TitreTableAdapter
    Friend WithEvents TitreBindingSource1 As System.Windows.Forms.BindingSource
End Class
