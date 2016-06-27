<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.AssemblyNamesComboBox = New System.Windows.Forms.ComboBox()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AssemblyDetailsListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageAssemblyDetails = New System.Windows.Forms.TabPage()
        Me.colAssemblyCodeBase = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAssemblyBuilt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAssemblyVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAssemblyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AssemblyInfoListView = New System.Windows.Forms.ListView()
        Me.TabPageAssemblies = New System.Windows.Forms.TabPage()
        Me.colValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AppInfoListView = New System.Windows.Forms.ListView()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.AppDateLabel = New System.Windows.Forms.Label()
        Me.SysInfoButton = New System.Windows.Forms.Button()
        Me.AppCopyrightLabel = New System.Windows.Forms.Label()
        Me.AppVersionLabel = New System.Windows.Forms.Label()
        Me.AppDescriptionLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppTitleLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.MoreRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPanelDetails = New System.Windows.Forms.TabControl()
        Me.TabPageApplication = New System.Windows.Forms.TabPage()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.TabPageAssemblyDetails.SuspendLayout()
        Me.TabPageAssemblies.SuspendLayout()
        Me.TabPanelDetails.SuspendLayout()
        Me.TabPageApplication.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssemblyNamesComboBox
        '
        Me.AssemblyNamesComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.AssemblyNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssemblyNamesComboBox.Location = New System.Drawing.Point(0, 0)
        Me.AssemblyNamesComboBox.Name = "AssemblyNamesComboBox"
        Me.AssemblyNamesComboBox.Size = New System.Drawing.Size(368, 21)
        Me.AssemblyNamesComboBox.Sorted = True
        Me.AssemblyNamesComboBox.TabIndex = 18
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Assembly Key"
        Me.ColumnHeader1.Width = 120
        '
        'AssemblyDetailsListView
        '
        Me.AssemblyDetailsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.AssemblyDetailsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssemblyDetailsListView.FullRowSelect = True
        Me.AssemblyDetailsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AssemblyDetailsListView.Location = New System.Drawing.Point(0, 21)
        Me.AssemblyDetailsListView.Name = "AssemblyDetailsListView"
        Me.AssemblyDetailsListView.Size = New System.Drawing.Size(368, 65)
        Me.AssemblyDetailsListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AssemblyDetailsListView.TabIndex = 19
        Me.AssemblyDetailsListView.UseCompatibleStateImageBehavior = False
        Me.AssemblyDetailsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 700
        '
        'TabPageAssemblyDetails
        '
        Me.TabPageAssemblyDetails.Controls.Add(Me.AssemblyDetailsListView)
        Me.TabPageAssemblyDetails.Controls.Add(Me.AssemblyNamesComboBox)
        Me.TabPageAssemblyDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails"
        Me.TabPageAssemblyDetails.Size = New System.Drawing.Size(368, 86)
        Me.TabPageAssemblyDetails.TabIndex = 2
        Me.TabPageAssemblyDetails.Text = "Assembly Details"
        '
        'colAssemblyCodeBase
        '
        Me.colAssemblyCodeBase.Text = "CodeBase"
        Me.colAssemblyCodeBase.Width = 750
        '
        'colAssemblyBuilt
        '
        Me.colAssemblyBuilt.Text = "Built"
        Me.colAssemblyBuilt.Width = 130
        '
        'colAssemblyVersion
        '
        Me.colAssemblyVersion.Text = "Version"
        Me.colAssemblyVersion.Width = 100
        '
        'colAssemblyName
        '
        Me.colAssemblyName.Text = "Assembly"
        Me.colAssemblyName.Width = 123
        '
        'AssemblyInfoListView
        '
        Me.AssemblyInfoListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colAssemblyName, Me.colAssemblyVersion, Me.colAssemblyBuilt, Me.colAssemblyCodeBase})
        Me.AssemblyInfoListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssemblyInfoListView.FullRowSelect = True
        Me.AssemblyInfoListView.Location = New System.Drawing.Point(0, 0)
        Me.AssemblyInfoListView.MultiSelect = False
        Me.AssemblyInfoListView.Name = "AssemblyInfoListView"
        Me.AssemblyInfoListView.Size = New System.Drawing.Size(368, 86)
        Me.AssemblyInfoListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AssemblyInfoListView.TabIndex = 13
        Me.AssemblyInfoListView.UseCompatibleStateImageBehavior = False
        Me.AssemblyInfoListView.View = System.Windows.Forms.View.Details
        '
        'TabPageAssemblies
        '
        Me.TabPageAssemblies.Controls.Add(Me.AssemblyInfoListView)
        Me.TabPageAssemblies.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAssemblies.Name = "TabPageAssemblies"
        Me.TabPageAssemblies.Size = New System.Drawing.Size(368, 86)
        Me.TabPageAssemblies.TabIndex = 1
        Me.TabPageAssemblies.Text = "Assemblies"
        '
        'colValue
        '
        Me.colValue.Text = "Value"
        Me.colValue.Width = 700
        '
        'colKey
        '
        Me.colKey.Text = "Application Key"
        Me.colKey.Width = 120
        '
        'AppInfoListView
        '
        Me.AppInfoListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKey, Me.colValue})
        Me.AppInfoListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppInfoListView.FullRowSelect = True
        Me.AppInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AppInfoListView.Location = New System.Drawing.Point(0, 0)
        Me.AppInfoListView.Name = "AppInfoListView"
        Me.AppInfoListView.Size = New System.Drawing.Size(368, 86)
        Me.AppInfoListView.TabIndex = 16
        Me.AppInfoListView.UseCompatibleStateImageBehavior = False
        Me.AppInfoListView.View = System.Windows.Forms.View.Details
        '
        'DetailsButton
        '
        Me.DetailsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsButton.Location = New System.Drawing.Point(227, 244)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(76, 23)
        Me.DetailsButton.TabIndex = 25
        Me.DetailsButton.Text = "&Details >>"
        '
        'AppDateLabel
        '
        Me.AppDateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppDateLabel.Location = New System.Drawing.Point(7, 80)
        Me.AppDateLabel.Name = "AppDateLabel"
        Me.AppDateLabel.Size = New System.Drawing.Size(378, 16)
        Me.AppDateLabel.TabIndex = 23
        Me.AppDateLabel.Text = "Built on %builddate%"
        '
        'SysInfoButton
        '
        Me.SysInfoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SysInfoButton.Location = New System.Drawing.Point(211, 244)
        Me.SysInfoButton.Name = "SysInfoButton"
        Me.SysInfoButton.Size = New System.Drawing.Size(92, 23)
        Me.SysInfoButton.TabIndex = 22
        Me.SysInfoButton.Text = "&System Info..."
        Me.SysInfoButton.Visible = False
        '
        'AppCopyrightLabel
        '
        Me.AppCopyrightLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppCopyrightLabel.Location = New System.Drawing.Point(7, 100)
        Me.AppCopyrightLabel.Name = "AppCopyrightLabel"
        Me.AppCopyrightLabel.Size = New System.Drawing.Size(378, 16)
        Me.AppCopyrightLabel.TabIndex = 21
        Me.AppCopyrightLabel.Text = "Copyright © %year%, %company%"
        '
        'AppVersionLabel
        '
        Me.AppVersionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppVersionLabel.Location = New System.Drawing.Point(7, 60)
        Me.AppVersionLabel.Name = "AppVersionLabel"
        Me.AppVersionLabel.Size = New System.Drawing.Size(378, 16)
        Me.AppVersionLabel.TabIndex = 20
        Me.AppVersionLabel.Text = "Version %version%"
        '
        'AppDescriptionLabel
        '
        Me.AppDescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppDescriptionLabel.Location = New System.Drawing.Point(59, 28)
        Me.AppDescriptionLabel.Name = "AppDescriptionLabel"
        Me.AppDescriptionLabel.Size = New System.Drawing.Size(326, 16)
        Me.AppDescriptionLabel.TabIndex = 19
        Me.AppDescriptionLabel.Text = "%description%"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 2)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AppTitleLabel
        '
        Me.AppTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppTitleLabel.Location = New System.Drawing.Point(59, 8)
        Me.AppTitleLabel.Name = "AppTitleLabel"
        Me.AppTitleLabel.Size = New System.Drawing.Size(326, 16)
        Me.AppTitleLabel.TabIndex = 17
        Me.AppTitleLabel.Text = "%title%"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(311, 244)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(76, 23)
        Me.OKButton.TabIndex = 16
        Me.OKButton.Text = "OK"
        '
        'MoreRichTextBox
        '
        Me.MoreRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoreRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MoreRichTextBox.Location = New System.Drawing.Point(7, 124)
        Me.MoreRichTextBox.Name = "MoreRichTextBox"
        Me.MoreRichTextBox.ReadOnly = True
        Me.MoreRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.MoreRichTextBox.Size = New System.Drawing.Size(378, 112)
        Me.MoreRichTextBox.TabIndex = 26
        Me.MoreRichTextBox.Text = "%product% is %copyright%, %trademark%"
        '
        'TabPanelDetails
        '
        Me.TabPanelDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPanelDetails.Controls.Add(Me.TabPageApplication)
        Me.TabPanelDetails.Controls.Add(Me.TabPageAssemblies)
        Me.TabPanelDetails.Controls.Add(Me.TabPageAssemblyDetails)
        Me.TabPanelDetails.Location = New System.Drawing.Point(7, 124)
        Me.TabPanelDetails.Name = "TabPanelDetails"
        Me.TabPanelDetails.SelectedIndex = 0
        Me.TabPanelDetails.Size = New System.Drawing.Size(376, 112)
        Me.TabPanelDetails.TabIndex = 27
        Me.TabPanelDetails.Visible = False
        '
        'TabPageApplication
        '
        Me.TabPageApplication.Controls.Add(Me.AppInfoListView)
        Me.TabPageApplication.Location = New System.Drawing.Point(4, 22)
        Me.TabPageApplication.Name = "TabPageApplication"
        Me.TabPageApplication.Size = New System.Drawing.Size(368, 86)
        Me.TabPageApplication.TabIndex = 0
        Me.TabPageApplication.Text = "Application"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Location = New System.Drawing.Point(15, 8)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(32, 32)
        Me.ImagePictureBox.TabIndex = 24
        Me.ImagePictureBox.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 275)
        Me.Controls.Add(Me.DetailsButton)
        Me.Controls.Add(Me.AppDateLabel)
        Me.Controls.Add(Me.SysInfoButton)
        Me.Controls.Add(Me.AppCopyrightLabel)
        Me.Controls.Add(Me.AppVersionLabel)
        Me.Controls.Add(Me.AppDescriptionLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AppTitleLabel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.MoreRichTextBox)
        Me.Controls.Add(Me.TabPanelDetails)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        Me.TabPageAssemblyDetails.ResumeLayout(False)
        Me.TabPageAssemblies.ResumeLayout(False)
        Me.TabPanelDetails.ResumeLayout(False)
        Me.TabPageApplication.ResumeLayout(False)
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AssemblyNamesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AssemblyDetailsListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPageAssemblyDetails As System.Windows.Forms.TabPage
    Friend WithEvents colAssemblyCodeBase As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAssemblyBuilt As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAssemblyVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAssemblyName As System.Windows.Forms.ColumnHeader
    Friend WithEvents AssemblyInfoListView As System.Windows.Forms.ListView
    Friend WithEvents TabPageAssemblies As System.Windows.Forms.TabPage
    Friend WithEvents colValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents colKey As System.Windows.Forms.ColumnHeader
    Friend WithEvents AppInfoListView As System.Windows.Forms.ListView
    Private WithEvents DetailsButton As System.Windows.Forms.Button
    Private WithEvents AppDateLabel As System.Windows.Forms.Label
    Private WithEvents SysInfoButton As System.Windows.Forms.Button
    Private WithEvents AppCopyrightLabel As System.Windows.Forms.Label
    Private WithEvents AppVersionLabel As System.Windows.Forms.Label
    Private WithEvents AppDescriptionLabel As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents AppTitleLabel As System.Windows.Forms.Label
    Private WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents MoreRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPanelDetails As System.Windows.Forms.TabControl
    Friend WithEvents TabPageApplication As System.Windows.Forms.TabPage
    Private WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
End Class
