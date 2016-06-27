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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SMSDataSet = New test_db.SMSDataSet()
        Me.DareddBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DareddTableAdapter = New test_db.SMSDataSetTableAdapters.DareddTableAdapter()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DareddBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.Add1DataGridViewTextBoxColumn, Me.Add2DataGridViewTextBoxColumn, Me.Add3DataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DareddBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(664, 147)
        Me.DataGridView1.TabIndex = 0
        '
        'SMSDataSet
        '
        Me.SMSDataSet.DataSetName = "SMSDataSet"
        Me.SMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DareddBindingSource
        '
        Me.DareddBindingSource.DataMember = "Daredd"
        Me.DareddBindingSource.DataSource = Me.SMSDataSet
        '
        'DareddTableAdapter
        '
        Me.DareddTableAdapter.ClearBeforeFill = True
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "Dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "Dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'Add1DataGridViewTextBoxColumn
        '
        Me.Add1DataGridViewTextBoxColumn.DataPropertyName = "Add1"
        Me.Add1DataGridViewTextBoxColumn.HeaderText = "Add1"
        Me.Add1DataGridViewTextBoxColumn.Name = "Add1DataGridViewTextBoxColumn"
        '
        'Add2DataGridViewTextBoxColumn
        '
        Me.Add2DataGridViewTextBoxColumn.DataPropertyName = "Add2"
        Me.Add2DataGridViewTextBoxColumn.HeaderText = "Add2"
        Me.Add2DataGridViewTextBoxColumn.Name = "Add2DataGridViewTextBoxColumn"
        '
        'Add3DataGridViewTextBoxColumn
        '
        Me.Add3DataGridViewTextBoxColumn.DataPropertyName = "Add3"
        Me.Add3DataGridViewTextBoxColumn.HeaderText = "Add3"
        Me.Add3DataGridViewTextBoxColumn.Name = "Add3DataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 444)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DareddBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SMSDataSet As test_db.SMSDataSet
    Friend WithEvents DareddBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DareddTableAdapter As test_db.SMSDataSetTableAdapters.DareddTableAdapter
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Add1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Add2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Add3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
