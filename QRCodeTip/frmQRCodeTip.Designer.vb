<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQRCodeTip
    Inherits QRCodeTip.baseFrom

    '窗体重写释放，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.txtCodeString = New System.Windows.Forms.TextBox
    Me.picQRImage = New System.Windows.Forms.PictureBox
    Me.lnkSave = New System.Windows.Forms.LinkLabel
    Me.pnlCenter.SuspendLayout()
    CType(Me.picQRImage, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlCenter
    '
    Me.pnlCenter.Controls.Add(Me.lnkSave)
    Me.pnlCenter.Controls.Add(Me.picQRImage)
    Me.pnlCenter.Controls.Add(Me.txtCodeString)
    Me.pnlCenter.Size = New System.Drawing.Size(328, 324)
    '
    'txtCodeString
    '
    Me.txtCodeString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtCodeString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodeString.Location = New System.Drawing.Point(6, 6)
    Me.txtCodeString.Multiline = True
    Me.txtCodeString.Name = "txtCodeString"
    Me.txtCodeString.Size = New System.Drawing.Size(316, 64)
    Me.txtCodeString.TabIndex = 0
    '
    'picQRImage
    '
    Me.picQRImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picQRImage.Location = New System.Drawing.Point(6, 76)
    Me.picQRImage.Name = "picQRImage"
    Me.picQRImage.Padding = New System.Windows.Forms.Padding(2)
    Me.picQRImage.Size = New System.Drawing.Size(119, 88)
    Me.picQRImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picQRImage.TabIndex = 1
    Me.picQRImage.TabStop = False
    '
    'lnkSave
    '
    Me.lnkSave.AutoSize = True
    Me.lnkSave.Location = New System.Drawing.Point(275, 76)
    Me.lnkSave.Name = "lnkSave"
    Me.lnkSave.Size = New System.Drawing.Size(47, 12)
    Me.lnkSave.TabIndex = 2
    Me.lnkSave.TabStop = True
    Me.lnkSave.Text = "Save..."
    '
    'frmQRCodeTip
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.ClientSize = New System.Drawing.Size(388, 368)
    Me.Name = "frmQRCodeTip"
    Me.pnlCenter.ResumeLayout(False)
    Me.pnlCenter.PerformLayout()
    CType(Me.picQRImage, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtCodeString As System.Windows.Forms.TextBox
  Friend WithEvents lnkSave As System.Windows.Forms.LinkLabel
  Friend WithEvents picQRImage As System.Windows.Forms.PictureBox

End Class
