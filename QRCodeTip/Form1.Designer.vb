<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form


  'Form 重写 Dispose，以清理组件列表。
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

  'Windows 窗体设计器所必需的
  Private components As System.ComponentModel.IContainer

  '注意: 以下过程是 Windows 窗体设计器所必需的
  '可以使用 Windows 窗体设计器修改它。
  '不要使用代码编辑器修改它。
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.cboEncoding = New System.Windows.Forms.ComboBox
    Me.txtSize = New System.Windows.Forms.TextBox
    Me.cboVersion = New System.Windows.Forms.TextBox
    Me.cboCorrectionLevel = New System.Windows.Forms.ComboBox
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 12)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Label1"
    '
    'PictureBox1
    '
    Me.PictureBox1.Location = New System.Drawing.Point(13, 38)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(267, 223)
    Me.PictureBox1.TabIndex = 1
    Me.PictureBox1.TabStop = False
    '
    'cboEncoding
    '
    Me.cboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEncoding.FormattingEnabled = True
    Me.cboEncoding.Items.AddRange(New Object() {"Byte", "AlphaNumeric", "Numeric"})
    Me.cboEncoding.Location = New System.Drawing.Point(13, 278)
    Me.cboEncoding.Name = "cboEncoding"
    Me.cboEncoding.Size = New System.Drawing.Size(121, 20)
    Me.cboEncoding.TabIndex = 2
    '
    'txtSize
    '
    Me.txtSize.Location = New System.Drawing.Point(12, 369)
    Me.txtSize.Name = "txtSize"
    Me.txtSize.Size = New System.Drawing.Size(100, 21)
    Me.txtSize.TabIndex = 3
    Me.txtSize.Text = "4"
    '
    'cboVersion
    '
    Me.cboVersion.Location = New System.Drawing.Point(13, 327)
    Me.cboVersion.Name = "cboVersion"
    Me.cboVersion.Size = New System.Drawing.Size(100, 21)
    Me.cboVersion.TabIndex = 4
    Me.cboVersion.Text = "7"
    '
    'cboCorrectionLevel
    '
    Me.cboCorrectionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCorrectionLevel.FormattingEnabled = True
    Me.cboCorrectionLevel.Items.AddRange(New Object() {"L", "M", "Q", "H"})
    Me.cboCorrectionLevel.Location = New System.Drawing.Point(159, 278)
    Me.cboCorrectionLevel.Name = "cboCorrectionLevel"
    Me.cboCorrectionLevel.Size = New System.Drawing.Size(121, 20)
    Me.cboCorrectionLevel.TabIndex = 5
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(379, 418)
    Me.Controls.Add(Me.cboCorrectionLevel)
    Me.Controls.Add(Me.cboVersion)
    Me.Controls.Add(Me.txtSize)
    Me.Controls.Add(Me.cboEncoding)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents cboEncoding As System.Windows.Forms.ComboBox
  Friend WithEvents txtSize As System.Windows.Forms.TextBox
  Friend WithEvents cboVersion As System.Windows.Forms.TextBox
  Friend WithEvents cboCorrectionLevel As System.Windows.Forms.ComboBox

End Class
