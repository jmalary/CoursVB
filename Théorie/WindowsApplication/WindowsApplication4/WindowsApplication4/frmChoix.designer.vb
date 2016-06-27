<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoix
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
        Me.chkItalique = New System.Windows.Forms.CheckBox()
        Me.chkGras = New System.Windows.Forms.CheckBox()
        Me.chkUnderline = New System.Windows.Forms.CheckBox()
        Me.chkStrikeOut = New System.Windows.Forms.CheckBox()
        Me.rb8 = New System.Windows.Forms.RadioButton()
        Me.rb10 = New System.Windows.Forms.RadioButton()
        Me.rb12 = New System.Windows.Forms.RadioButton()
        Me.rb24 = New System.Windows.Forms.RadioButton()
        Me.rbArial = New System.Windows.Forms.RadioButton()
        Me.gbPolice = New System.Windows.Forms.GroupBox()
        Me.rbCourier = New System.Windows.Forms.RadioButton()
        Me.gbPolice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choissez votre police"
        '
        'chkItalique
        '
        Me.chkItalique.AutoSize = True
        Me.chkItalique.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalique.Location = New System.Drawing.Point(12, 63)
        Me.chkItalique.Name = "chkItalique"
        Me.chkItalique.Size = New System.Drawing.Size(78, 24)
        Me.chkItalique.TabIndex = 1
        Me.chkItalique.Text = "italique"
        Me.chkItalique.UseVisualStyleBackColor = True
        '
        'chkGras
        '
        Me.chkGras.AutoSize = True
        Me.chkGras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGras.Location = New System.Drawing.Point(12, 93)
        Me.chkGras.Name = "chkGras"
        Me.chkGras.Size = New System.Drawing.Size(52, 17)
        Me.chkGras.TabIndex = 2
        Me.chkGras.Text = "Gras"
        Me.chkGras.UseVisualStyleBackColor = True
        '
        'chkUnderline
        '
        Me.chkUnderline.AutoSize = True
        Me.chkUnderline.Location = New System.Drawing.Point(12, 117)
        Me.chkUnderline.Name = "chkUnderline"
        Me.chkUnderline.Size = New System.Drawing.Size(71, 17)
        Me.chkUnderline.TabIndex = 3
        Me.chkUnderline.Text = "Underline"
        Me.chkUnderline.UseVisualStyleBackColor = True
        '
        'chkStrikeOut
        '
        Me.chkStrikeOut.AutoSize = True
        Me.chkStrikeOut.Location = New System.Drawing.Point(12, 141)
        Me.chkStrikeOut.Name = "chkStrikeOut"
        Me.chkStrikeOut.Size = New System.Drawing.Size(70, 17)
        Me.chkStrikeOut.TabIndex = 4
        Me.chkStrikeOut.Text = "StrikeOut"
        Me.chkStrikeOut.UseVisualStyleBackColor = True
        '
        'rb8
        '
        Me.rb8.AutoSize = True
        Me.rb8.Location = New System.Drawing.Point(146, 63)
        Me.rb8.Name = "rb8"
        Me.rb8.Size = New System.Drawing.Size(31, 17)
        Me.rb8.TabIndex = 5
        Me.rb8.Text = "8"
        Me.rb8.UseVisualStyleBackColor = True
        '
        'rb10
        '
        Me.rb10.AutoSize = True
        Me.rb10.Checked = True
        Me.rb10.Location = New System.Drawing.Point(146, 87)
        Me.rb10.Name = "rb10"
        Me.rb10.Size = New System.Drawing.Size(37, 17)
        Me.rb10.TabIndex = 6
        Me.rb10.TabStop = True
        Me.rb10.Text = "10"
        Me.rb10.UseVisualStyleBackColor = True
        '
        'rb12
        '
        Me.rb12.AutoSize = True
        Me.rb12.Location = New System.Drawing.Point(146, 111)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(37, 17)
        Me.rb12.TabIndex = 7
        Me.rb12.TabStop = True
        Me.rb12.Text = "12"
        Me.rb12.UseVisualStyleBackColor = True
        '
        'rb24
        '
        Me.rb24.AutoSize = True
        Me.rb24.Location = New System.Drawing.Point(146, 134)
        Me.rb24.Name = "rb24"
        Me.rb24.Size = New System.Drawing.Size(37, 17)
        Me.rb24.TabIndex = 8
        Me.rb24.TabStop = True
        Me.rb24.Text = "24"
        Me.rb24.UseVisualStyleBackColor = True
        '
        'rbArial
        '
        Me.rbArial.AutoSize = True
        Me.rbArial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArial.Location = New System.Drawing.Point(18, 30)
        Me.rbArial.Name = "rbArial"
        Me.rbArial.Size = New System.Drawing.Size(47, 18)
        Me.rbArial.TabIndex = 9
        Me.rbArial.TabStop = True
        Me.rbArial.Text = "Arial"
        Me.rbArial.UseVisualStyleBackColor = True
        '
        'gbPolice
        '
        Me.gbPolice.Controls.Add(Me.rbCourier)
        Me.gbPolice.Controls.Add(Me.rbArial)
        Me.gbPolice.Location = New System.Drawing.Point(218, 63)
        Me.gbPolice.Name = "gbPolice"
        Me.gbPolice.Size = New System.Drawing.Size(141, 141)
        Me.gbPolice.TabIndex = 10
        Me.gbPolice.TabStop = False
        Me.gbPolice.Text = "Nom de la police"
        '
        'rbCourier
        '
        Me.rbCourier.AutoSize = True
        Me.rbCourier.Location = New System.Drawing.Point(18, 55)
        Me.rbCourier.Name = "rbCourier"
        Me.rbCourier.Size = New System.Drawing.Size(83, 17)
        Me.rbCourier.TabIndex = 10
        Me.rbCourier.TabStop = True
        Me.rbCourier.Text = "Courier New"
        Me.rbCourier.UseVisualStyleBackColor = True
        '
        'frmChoix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 288)
        Me.Controls.Add(Me.rb24)
        Me.Controls.Add(Me.rb12)
        Me.Controls.Add(Me.rb10)
        Me.Controls.Add(Me.rb8)
        Me.Controls.Add(Me.chkStrikeOut)
        Me.Controls.Add(Me.chkUnderline)
        Me.Controls.Add(Me.chkGras)
        Me.Controls.Add(Me.chkItalique)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbPolice)
        Me.Name = "frmChoix"
        Me.Text = "Choix de police"
        Me.gbPolice.ResumeLayout(False)
        Me.gbPolice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkItalique As System.Windows.Forms.CheckBox
    Friend WithEvents chkGras As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnderline As System.Windows.Forms.CheckBox
    Friend WithEvents chkStrikeOut As System.Windows.Forms.CheckBox
    Friend WithEvents rb8 As System.Windows.Forms.RadioButton
    Friend WithEvents rb10 As System.Windows.Forms.RadioButton
    Friend WithEvents rb12 As System.Windows.Forms.RadioButton
    Friend WithEvents rb24 As System.Windows.Forms.RadioButton
    Friend WithEvents rbArial As System.Windows.Forms.RadioButton
    Friend WithEvents gbPolice As System.Windows.Forms.GroupBox
    Friend WithEvents rbCourier As System.Windows.Forms.RadioButton
End Class
