<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeTip
  Inherits QRCodeTip.baseFrom


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
    Me.lblCodeStr = New System.Windows.Forms.Label
    Me.picQRImage = New System.Windows.Forms.PictureBox
    Me.cboEncoding = New System.Windows.Forms.ComboBox
    Me.txtSize = New System.Windows.Forms.TextBox
    Me.cboVersion = New System.Windows.Forms.TextBox
    Me.cboCorrectionLevel = New System.Windows.Forms.ComboBox
    CType(Me.picQRImage, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlCenter
    '
    Me.pnlCenter.Size = New System.Drawing.Size(339, 313)
    '
    'lblCodeStr
    '
    Me.lblCodeStr.AutoEllipsis = True
    Me.lblCodeStr.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer))
    Me.lblCodeStr.Location = New System.Drawing.Point(0, 0)
    Me.lblCodeStr.Name = "lblCodeStr"
    Me.lblCodeStr.Size = New System.Drawing.Size(282, 33)
    Me.lblCodeStr.TabIndex = 0
    Me.lblCodeStr.Text = "..."
    '
    'picQRImage
    '
    Me.picQRImage.Location = New System.Drawing.Point(100, 0)
    Me.picQRImage.Name = "picQRImage"
    Me.picQRImage.Size = New System.Drawing.Size(238, 198)
    Me.picQRImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.picQRImage.TabIndex = 1
    Me.picQRImage.TabStop = False
    '
    'cboEncoding
    '
    Me.cboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEncoding.FormattingEnabled = True
    Me.cboEncoding.Items.AddRange(New Object() {"Byte", "AlphaNumeric", "Numeric"})
    Me.cboEncoding.Location = New System.Drawing.Point(0, 0)
    Me.cboEncoding.Name = "cboEncoding"
    Me.cboEncoding.Size = New System.Drawing.Size(121, 20)
    Me.cboEncoding.TabIndex = 2
    Me.cboEncoding.Visible = False
    '
    'txtSize
    '
    Me.txtSize.Location = New System.Drawing.Point(0, 0)
    Me.txtSize.Name = "txtSize"
    Me.txtSize.Size = New System.Drawing.Size(100, 21)
    Me.txtSize.TabIndex = 3
    Me.txtSize.Text = "4"
    Me.txtSize.Visible = False
    '
    'cboVersion
    '
    Me.cboVersion.Location = New System.Drawing.Point(0, 0)
    Me.cboVersion.Name = "cboVersion"
    Me.cboVersion.Size = New System.Drawing.Size(100, 21)
    Me.cboVersion.TabIndex = 4
    Me.cboVersion.Text = "7"
    Me.cboVersion.Visible = False
    '
    'cboCorrectionLevel
    '
    Me.cboCorrectionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCorrectionLevel.FormattingEnabled = True
    Me.cboCorrectionLevel.Items.AddRange(New Object() {"L", "M", "Q", "H"})
    Me.cboCorrectionLevel.Location = New System.Drawing.Point(0, 0)
    Me.cboCorrectionLevel.Name = "cboCorrectionLevel"
    Me.cboCorrectionLevel.Size = New System.Drawing.Size(121, 20)
    Me.cboCorrectionLevel.TabIndex = 5
    Me.cboCorrectionLevel.Visible = False
    '
    'frmQRCodeTip
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(399, 357)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmQRCodeTip"
    Me.Text = "QR Code Tip"
    Me.TopMost = True
    CType(Me.picQRImage, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblCodeStr As System.Windows.Forms.Label
  Friend WithEvents picQRImage As System.Windows.Forms.PictureBox
  Friend WithEvents cboEncoding As System.Windows.Forms.ComboBox
  Friend WithEvents txtSize As System.Windows.Forms.TextBox
  Friend WithEvents cboVersion As System.Windows.Forms.TextBox
  Friend WithEvents cboCorrectionLevel As System.Windows.Forms.ComboBox

End Class
