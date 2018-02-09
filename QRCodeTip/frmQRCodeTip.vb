
Imports XDICTGRB
Imports ThoughtWorks.QRCode.Codec
Imports System.Runtime.InteropServices

Public Class frmQRCodeTip
  Implements XDICTGRB.IXDictGrabSink

  Dim i As Integer 'ȡ�ʵķ���ֵ������ע���ע��ȡ��
  Dim gp As XDICTGRB.GrabProxy = New XDICTGRB.GrabProxy() 'ȡ�ʴ�������

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
    txtCodeString.Text = SentenceString.Trim

    Me.Show()
    Me.Location = New Point(lCursorX + 10, lCursorY + 10)

    Dim qrCodeEncoder As QRCodeEncoder = New QRCodeEncoder()
    Dim encoding As String = "Byte"
    If (encoding = "Byte") Then
      qrCodeEncoder.QRCodeEncodeMode = qrCodeEncoder.ENCODE_MODE.BYTE
    ElseIf (encoding = "AlphaNumeric") Then
      qrCodeEncoder.QRCodeEncodeMode = qrCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
    ElseIf (encoding = "Numeric") Then
      qrCodeEncoder.QRCodeEncodeMode = qrCodeEncoder.ENCODE_MODE.NUMERIC
    End If
    Try
      qrCodeEncoder.QRCodeScale = CInt(7)
    Catch ex As Exception
      MessageBox.Show("Invalid size!")
      Exit Function
    End Try

    Try
      qrCodeEncoder.QRCodeVersion = Convert.ToInt16(4)
    Catch ex As Exception
      MessageBox.Show("Invalid version !")
    End Try

    Dim errorCorrect As String = "L"
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
    Dim data As String = txtCodeString.Text
    image = qrCodeEncoder.Encode(data)
    picQRImage.Image = image

  End Function

  Private Sub frmQRCodeTip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SetWindowPos(Me.Handle, -1, Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2, Me.Width, Me.Height, 0)

    Dim XDictGrabDisableCaption As Integer = 8 '��ȡ������������
    Dim XDictGrabDisableButton As Integer = 4 '��ȡ��ť�ϵ�����
    Dim XDictGrabDisableMenu As Integer = 2 '��ȡ�˵�������
    Dim XDictGrabOnlyEnglish As Integer = 1 'ֻȡӢ��

    gp.GrabInterval = 500 'ָץȡʱ����
    gp.GrabMode = XDictGrabModeEnum.XDictGrabMouse '�趨ȡ�ʵ�����
    gp.GrabFlag = (XDictGrabOnlyEnglish & XDictGrabDisableMenu & XDictGrabDisableButton & XDictGrabDisableCaption)
    gp.GrabEnabled = True '�Ƿ�ȡ�ʵ�����
    i = gp.AdviseGrab(Me) 'Ҫʵ�ֵĽӿ�

  End Sub
End Class