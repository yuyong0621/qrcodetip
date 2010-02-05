<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseFrom
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
    Me.pnlTop = New System.Windows.Forms.Panel
    Me.pnlCenterTop = New System.Windows.Forms.Panel
    Me.pnlRightTop = New System.Windows.Forms.Panel
    Me.pnlLeftTop = New System.Windows.Forms.Panel
    Me.pnlBottom = New System.Windows.Forms.Panel
    Me.pnlCenterBottom = New System.Windows.Forms.Panel
    Me.pnlRightBottom = New System.Windows.Forms.Panel
    Me.pnlLeftBottom = New System.Windows.Forms.Panel
    Me.pnlCenter = New System.Windows.Forms.Panel
    Me.pnlClose = New System.Windows.Forms.Panel
    Me.pnlLeft = New System.Windows.Forms.Panel
    Me.pnlRight = New System.Windows.Forms.Panel
    Me.pnlTop.SuspendLayout()
    Me.pnlBottom.SuspendLayout()
    Me.pnlRight.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlTop
    '
    Me.pnlTop.Controls.Add(Me.pnlCenterTop)
    Me.pnlTop.Controls.Add(Me.pnlRightTop)
    Me.pnlTop.Controls.Add(Me.pnlLeftTop)
    Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlTop.Location = New System.Drawing.Point(0, 0)
    Me.pnlTop.Name = "pnlTop"
    Me.pnlTop.Size = New System.Drawing.Size(502, 22)
    Me.pnlTop.TabIndex = 0
    '
    'pnlCenterTop
    '
    Me.pnlCenterTop.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.tl
    Me.pnlCenterTop.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlCenterTop.Location = New System.Drawing.Point(30, 0)
    Me.pnlCenterTop.Name = "pnlCenterTop"
    Me.pnlCenterTop.Size = New System.Drawing.Size(442, 22)
    Me.pnlCenterTop.TabIndex = 1
    '
    'pnlRightTop
    '
    Me.pnlRightTop.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.rtr
    Me.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Right
    Me.pnlRightTop.Location = New System.Drawing.Point(472, 0)
    Me.pnlRightTop.Name = "pnlRightTop"
    Me.pnlRightTop.Size = New System.Drawing.Size(30, 22)
    Me.pnlRightTop.TabIndex = 2
    '
    'pnlLeftTop
    '
    Me.pnlLeftTop.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.ltr
    Me.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Left
    Me.pnlLeftTop.Location = New System.Drawing.Point(0, 0)
    Me.pnlLeftTop.Name = "pnlLeftTop"
    Me.pnlLeftTop.Size = New System.Drawing.Size(30, 22)
    Me.pnlLeftTop.TabIndex = 0
    '
    'pnlBottom
    '
    Me.pnlBottom.Controls.Add(Me.pnlCenterBottom)
    Me.pnlBottom.Controls.Add(Me.pnlRightBottom)
    Me.pnlBottom.Controls.Add(Me.pnlLeftBottom)
    Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlBottom.Location = New System.Drawing.Point(0, 421)
    Me.pnlBottom.Name = "pnlBottom"
    Me.pnlBottom.Size = New System.Drawing.Size(502, 22)
    Me.pnlBottom.TabIndex = 3
    '
    'pnlCenterBottom
    '
    Me.pnlCenterBottom.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.bl
    Me.pnlCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlCenterBottom.Location = New System.Drawing.Point(30, 0)
    Me.pnlCenterBottom.Name = "pnlCenterBottom"
    Me.pnlCenterBottom.Size = New System.Drawing.Size(442, 22)
    Me.pnlCenterBottom.TabIndex = 2
    '
    'pnlRightBottom
    '
    Me.pnlRightBottom.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.rbr
    Me.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Right
    Me.pnlRightBottom.Location = New System.Drawing.Point(472, 0)
    Me.pnlRightBottom.Name = "pnlRightBottom"
    Me.pnlRightBottom.Size = New System.Drawing.Size(30, 22)
    Me.pnlRightBottom.TabIndex = 1
    '
    'pnlLeftBottom
    '
    Me.pnlLeftBottom.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.lbr
    Me.pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Left
    Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 0)
    Me.pnlLeftBottom.Name = "pnlLeftBottom"
    Me.pnlLeftBottom.Size = New System.Drawing.Size(30, 22)
    Me.pnlLeftBottom.TabIndex = 0
    '
    'pnlCenter
    '
    Me.pnlCenter.BackColor = System.Drawing.Color.White
    Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlCenter.Location = New System.Drawing.Point(30, 22)
    Me.pnlCenter.Name = "pnlCenter"
    Me.pnlCenter.Size = New System.Drawing.Size(442, 399)
    Me.pnlCenter.TabIndex = 4
    '
    'pnlClose
    '
    Me.pnlClose.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.close
    Me.pnlClose.Cursor = System.Windows.Forms.Cursors.Hand
    Me.pnlClose.Location = New System.Drawing.Point(0, 0)
    Me.pnlClose.Name = "pnlClose"
    Me.pnlClose.Size = New System.Drawing.Size(12, 12)
    Me.pnlClose.TabIndex = 0
    '
    'pnlLeft
    '
    Me.pnlLeft.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.ll
    Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
    Me.pnlLeft.Location = New System.Drawing.Point(0, 22)
    Me.pnlLeft.Name = "pnlLeft"
    Me.pnlLeft.Size = New System.Drawing.Size(30, 399)
    Me.pnlLeft.TabIndex = 1
    '
    'pnlRight
    '
    Me.pnlRight.BackgroundImage = Global.QRCodeTip.My.Resources.Resources.rl
    Me.pnlRight.Controls.Add(Me.pnlClose)
    Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
    Me.pnlRight.Location = New System.Drawing.Point(472, 22)
    Me.pnlRight.Name = "pnlRight"
    Me.pnlRight.Size = New System.Drawing.Size(30, 399)
    Me.pnlRight.TabIndex = 2
    '
    'baseFrom
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(502, 443)
    Me.Controls.Add(Me.pnlCenter)
    Me.Controls.Add(Me.pnlLeft)
    Me.Controls.Add(Me.pnlRight)
    Me.Controls.Add(Me.pnlBottom)
    Me.Controls.Add(Me.pnlTop)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "baseFrom"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.TransparencyKey = System.Drawing.Color.Fuchsia
    Me.pnlTop.ResumeLayout(False)
    Me.pnlBottom.ResumeLayout(False)
    Me.pnlRight.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlTop As System.Windows.Forms.Panel
  Friend WithEvents pnlCenterTop As System.Windows.Forms.Panel
  Friend WithEvents pnlRightTop As System.Windows.Forms.Panel
  Friend WithEvents pnlLeftTop As System.Windows.Forms.Panel
  Friend WithEvents pnlLeft As System.Windows.Forms.Panel
  Friend WithEvents pnlRight As System.Windows.Forms.Panel
  Friend WithEvents pnlBottom As System.Windows.Forms.Panel
  Friend WithEvents pnlCenterBottom As System.Windows.Forms.Panel
  Friend WithEvents pnlRightBottom As System.Windows.Forms.Panel
  Friend WithEvents pnlLeftBottom As System.Windows.Forms.Panel
  Friend WithEvents pnlClose As System.Windows.Forms.Panel
  Protected WithEvents pnlCenter As System.Windows.Forms.Panel

End Class
