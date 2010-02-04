<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeTip
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQRCodeTip))
    Me.lblCodeStr = New System.Windows.Forms.Label
    Me.picQRImage = New System.Windows.Forms.PictureBox
    Me.cboEncoding = New System.Windows.Forms.ComboBox
    Me.txtSize = New System.Windows.Forms.TextBox
    Me.cboVersion = New System.Windows.Forms.TextBox
    Me.cboCorrectionLevel = New System.Windows.Forms.ComboBox
    Me.pnlClose = New System.Windows.Forms.Panel
    Me.pnlTitle = New System.Windows.Forms.Panel
    CType(Me.picQRImage, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlTitle.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblCodeStr
    '
    Me.lblCodeStr.AutoEllipsis = True
    Me.lblCodeStr.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer))
    Me.lblCodeStr.Location = New System.Drawing.Point(9, 27)
    Me.lblCodeStr.Name = "lblCodeStr"
    Me.lblCodeStr.Size = New System.Drawing.Size(282, 33)
    Me.lblCodeStr.TabIndex = 0
    Me.lblCodeStr.Text = "..."
    '
    'picQRImage
    '
    Me.picQRImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(252, Byte), Integer))
    Me.picQRImage.Location = New System.Drawing.Point(9, 62)
    Me.picQRImage.Name = "picQRImage"
    Me.picQRImage.Size = New System.Drawing.Size(282, 197)
    Me.picQRImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.picQRImage.TabIndex = 1
    Me.picQRImage.TabStop = False
    '
    'cboEncoding
    '
    Me.cboEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEncoding.FormattingEnabled = True
    Me.cboEncoding.Items.AddRange(New Object() {"Byte", "AlphaNumeric", "Numeric"})
    Me.cboEncoding.Location = New System.Drawing.Point(385, 170)
    Me.cboEncoding.Name = "cboEncoding"
    Me.cboEncoding.Size = New System.Drawing.Size(121, 20)
    Me.cboEncoding.TabIndex = 2
    Me.cboEncoding.Visible = False
    '
    'txtSize
    '
    Me.txtSize.Location = New System.Drawing.Point(385, 143)
    Me.txtSize.Name = "txtSize"
    Me.txtSize.Size = New System.Drawing.Size(100, 21)
    Me.txtSize.TabIndex = 3
    Me.txtSize.Text = "4"
    Me.txtSize.Visible = False
    '
    'cboVersion
    '
    Me.cboVersion.Location = New System.Drawing.Point(376, 92)
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
    Me.cboCorrectionLevel.Location = New System.Drawing.Point(364, 40)
    Me.cboCorrectionLevel.Name = "cboCorrectionLevel"
    Me.cboCorrectionLevel.Size = New System.Drawing.Size(121, 20)
    Me.cboCorrectionLevel.TabIndex = 5
    Me.cboCorrectionLevel.Visible = False
    '
    'pnlClose
    '
    Me.pnlClose.BackgroundImage = CType(resources.GetObject("pnlClose.BackgroundImage"), System.Drawing.Image)
    Me.pnlClose.Cursor = System.Windows.Forms.Cursors.Hand
    Me.pnlClose.Location = New System.Drawing.Point(278, 4)
    Me.pnlClose.Name = "pnlClose"
    Me.pnlClose.Size = New System.Drawing.Size(18, 17)
    Me.pnlClose.TabIndex = 6
    '
    'pnlTitle
    '
    Me.pnlTitle.BackgroundImage = CType(resources.GetObject("pnlTitle.BackgroundImage"), System.Drawing.Image)
    Me.pnlTitle.Controls.Add(Me.pnlClose)
    Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
    Me.pnlTitle.Name = "pnlTitle"
    Me.pnlTitle.Size = New System.Drawing.Size(301, 24)
    Me.pnlTitle.TabIndex = 7
    '
    'frmQRCodeTip
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
    Me.ClientSize = New System.Drawing.Size(301, 273)
    Me.Controls.Add(Me.pnlTitle)
    Me.Controls.Add(Me.cboCorrectionLevel)
    Me.Controls.Add(Me.picQRImage)
    Me.Controls.Add(Me.lblCodeStr)
    Me.Controls.Add(Me.cboVersion)
    Me.Controls.Add(Me.txtSize)
    Me.Controls.Add(Me.cboEncoding)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmQRCodeTip"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.Text = "QR Code Tip"
    Me.TopMost = True
    Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
    CType(Me.picQRImage, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlTitle.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCodeStr As System.Windows.Forms.Label
  Friend WithEvents picQRImage As System.Windows.Forms.PictureBox
  Friend WithEvents cboEncoding As System.Windows.Forms.ComboBox
  Friend WithEvents txtSize As System.Windows.Forms.TextBox
  Friend WithEvents cboVersion As System.Windows.Forms.TextBox
  Friend WithEvents cboCorrectionLevel As System.Windows.Forms.ComboBox
  Friend WithEvents pnlClose As System.Windows.Forms.Panel
  Friend WithEvents pnlTitle As System.Windows.Forms.Panel

End Class
