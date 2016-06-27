<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusiqueDataSet = New WindowsApplication1.musiqueDataSet()
        Me.TitreTableAdapter = New WindowsApplication1.musiqueDataSetTableAdapters.TitreTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NTitreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterprèteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLancementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusiqueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Titre"
        Me.BindingSource1.DataSource = Me.MusiqueDataSet
        '
        'MusiqueDataSet
        '
        Me.MusiqueDataSet.DataSetName = "musiqueDataSet"
        Me.MusiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitreTableAdapter
        '
        Me.TitreTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTitreDataGridViewTextBoxColumn, Me.InterprèteDataGridViewTextBoxColumn, Me.TitreDataGridViewTextBoxColumn, Me.DateLancementDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(441, 167)
        Me.DataGridView1.TabIndex = 0
        '
        'NTitreDataGridViewTextBoxColumn
        '
        Me.NTitreDataGridViewTextBoxColumn.DataPropertyName = "N°Titre"
        Me.NTitreDataGridViewTextBoxColumn.HeaderText = "N°Titre"
        Me.NTitreDataGridViewTextBoxColumn.Name = "NTitreDataGridViewTextBoxColumn"
        Me.NTitreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InterprèteDataGridViewTextBoxColumn
        '
        Me.InterprèteDataGridViewTextBoxColumn.DataPropertyName = "Interprète"
        Me.InterprèteDataGridViewTextBoxColumn.HeaderText = "Interprète"
        Me.InterprèteDataGridViewTextBoxColumn.Name = "InterprèteDataGridViewTextBoxColumn"
        Me.InterprèteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitreDataGridViewTextBoxColumn
        '
        Me.TitreDataGridViewTextBoxColumn.DataPropertyName = "Titre"
        Me.TitreDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitreDataGridViewTextBoxColumn.Name = "TitreDataGridViewTextBoxColumn"
        Me.TitreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateLancementDataGridViewTextBoxColumn
        '
        Me.DateLancementDataGridViewTextBoxColumn.DataPropertyName = "DateLancement"
        Me.DateLancementDataGridViewTextBoxColumn.HeaderText = "DateLancement"
        Me.DateLancementDataGridViewTextBoxColumn.Name = "DateLancementDataGridViewTextBoxColumn"
        Me.DateLancementDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 347)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Exemple avec DateGridView"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusiqueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MusiqueDataSet As WindowsApplication1.musiqueDataSet
    Friend WithEvents TitreTableAdapter As WindowsApplication1.musiqueDataSetTableAdapters.TitreTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NTitreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterprèteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateLancementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
