
Imports XDICTGRB
Imports ThoughtWorks.QRCode.Codec
Imports System.Runtime.InteropServices

Public Class frmQRCodeTip
  Implements XDICTGRB.IXDictGrabSink

  Dim i As Integer '取词的返回值，用于注册和注销取词
  Dim gp As XDICTGRB.GrabProxy = New XDICTGRB.GrabProxy() '取词代理对象

  <DllImport("user32.dll")> _
  Private Shared Function SetWindowPos( _
                                      ByVal hwnd As IntPtr, _
                                      ByVal hWndInsertAfter As Integer, _
                                      ByVal x As Integer, _
                                      ByVal y As Integer, _
                                      ByVal cx As Integer, _
                                      ByVal cy As Integer, _
                                      ByVal wFlags As Integer) As Integer
  End Function


  Public Function QueryWord(ByVal WordString As String, ByVal lCursorX As Integer, ByVal lCursorY As Integer, ByVal SentenceString As String, ByRef lLoc As Integer, ByRef lStart As Integer) As Integer Implements XDICTGRB.IXDictGrabSink.QueryWord
    lblCodeStr.Text = SentenceString.Trim

    Me.Show()
    Me.Location = New Point(lCursorX + 10, lCursorY + 10)

    Dim qrCodeEncoder As QRCodeEncoder = New QRCodeEncoder()
    Dim encoding As String = cboEncoding.Text
    If (encoding = "Byte") Then
      qrCodeEncoder.QRCodeEncodeMode = qrCodeEncoder.ENCODE_MODE.BYTE
    ElseIf (encoding = "AlphaNumeric") Then
      qrCodeEncoder.QRCodeEncodeMode = qrCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
    ElseIf (encoding = "Numeric") Then
      qrCodeEncoder.QRCodeEncodeMode = qrCodeEncoder.ENCODE_MODE.NUMERIC
    End If
    Try
      qrCodeEncoder.QRCodeScale = CInt(txtSize.Text)
    Catch ex As Exception
      MessageBox.Show("Invalid size!")
      Exit Function
    End Try

    Try
      qrCodeEncoder.QRCodeVersion = Convert.ToInt16(cboVersion.Text)
    Catch ex As Exception
      MessageBox.Show("Invalid version !")
    End Try

    Dim errorCorrect As String = cboCorrectionLevel.Text
    If (errorCorrect = "L") Then
      qrCodeEncoder.QRCodeErrorCorrect = qrCodeEncoder.ERROR_CORRECTION.L
    ElseIf (errorCorrect = "M") Then
      qrCodeEncoder.QRCodeErrorCorrect = qrCodeEncoder.ERROR_CORRECTION.M
    ElseIf (errorCorrect = "Q") Then
      qrCodeEncoder.QRCodeErrorCorrect = qrCodeEncoder.ERROR_CORRECTION.Q
    ElseIf (errorCorrect = "H") Then
      qrCodeEncoder.QRCodeErrorCorrect = qrCodeEncoder.ERROR_CORRECTION.H
    End If

    Dim image As Image
    Dim data As String = lblCodeStr.Text
    image = qrCodeEncoder.Encode(data)
    picQRImage.Image = image

  End Function

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SetWindowPos(Me.Handle, -1, Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2, Me.Width, Me.Height, 0)

    Dim XDictGrabDisableCaption As Integer = 8 '不取标题栏的文字
    Dim XDictGrabDisableButton As Integer = 4 '不取按钮上的文字
    Dim XDictGrabDisableMenu As Integer = 2 '不取菜单的文字
    Dim XDictGrabOnlyEnglish As Integer = 1 '只取英文

    gp.GrabInterval = 500 '指抓取时间间隔
    gp.GrabMode = XDictGrabModeEnum.XDictGrabMouse '设定取词的属性
    gp.GrabFlag = (XDictGrabOnlyEnglish & XDictGrabDisableMenu & XDictGrabDisableButton & XDictGrabDisableCaption)
    gp.GrabEnabled = True '是否取词的属性
    i = gp.AdviseGrab(Me) '要实现的接口

    cboEncoding.SelectedIndex = 0
    cboCorrectionLevel.SelectedIndex = 0
  End Sub

  Private Sub pnlClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlClose.Click
    Me.Hide()
  End Sub
End Class