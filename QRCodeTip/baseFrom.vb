Public Class baseFrom

  Private Enum EnmCornerPosition As Integer
    All = 0
    LeftTop = 1
    RightTop = 2
    LeftBottom = 3
    RightBottom = 4
  End Enum

  Private mBlnFormDragging As Boolean = False
  Private mObjPointClicked As Point

  Private Sub baseFrom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SetFormPosition()
  End Sub

  Protected Sub SetFormPosition()
    If (Windows.Forms.Cursor.Position.X + Me.Size.Width > My.Computer.Screen.WorkingArea.Width) And _
          (Windows.Forms.Cursor.Position.Y + Me.Size.Height > My.Computer.Screen.WorkingArea.Height) Then
      SetCornerBgImage(EnmCornerPosition.RightBottom)
    ElseIf (Windows.Forms.Cursor.Position.X + Me.Size.Width > My.Computer.Screen.WorkingArea.Width) Then
      SetCornerBgImage(EnmCornerPosition.RightTop)
    ElseIf (Windows.Forms.Cursor.Position.Y + Me.Size.Height > My.Computer.Screen.WorkingArea.Height) Then
      SetCornerBgImage(EnmCornerPosition.LeftBottom)
    Else
      SetCornerBgImage(EnmCornerPosition.LeftTop)
    End If
  End Sub

  Private Sub SetCornerBgImage(ByVal aEnmCornerPosition As EnmCornerPosition)
    Select Case aEnmCornerPosition
      Case EnmCornerPosition.All
        Me.pnlLeftTop.BackgroundImage = My.Resources.ltr
        Me.pnlRightTop.BackgroundImage = My.Resources.rtr
        Me.pnlLeftBottom.BackgroundImage = My.Resources.lbr
        Me.pnlRightBottom.BackgroundImage = My.Resources.rbr
      Case EnmCornerPosition.LeftTop
        Me.pnlLeftTop.BackgroundImage = My.Resources.ltc
        Me.pnlRightTop.BackgroundImage = My.Resources.rtr
        Me.pnlLeftBottom.BackgroundImage = My.Resources.lbr
        Me.pnlRightBottom.BackgroundImage = My.Resources.rbr
        Me.Location = New Point(Windows.Forms.Cursor.Position.X + 10, Windows.Forms.Cursor.Position.Y + 10)
      Case EnmCornerPosition.RightTop
        Me.pnlRightTop.BackgroundImage = My.Resources.rtc
        Me.pnlLeftTop.BackgroundImage = My.Resources.ltr
        Me.pnlLeftBottom.BackgroundImage = My.Resources.lbr
        Me.pnlRightBottom.BackgroundImage = My.Resources.rbr
        Me.Location = New Point(Windows.Forms.Cursor.Position.X - Me.Size.Width - 10, Windows.Forms.Cursor.Position.Y + 10)
      Case EnmCornerPosition.LeftBottom
        Me.pnlLeftBottom.BackgroundImage = My.Resources.lbc
        Me.pnlLeftTop.BackgroundImage = My.Resources.ltr
        Me.pnlRightTop.BackgroundImage = My.Resources.rtr
        Me.pnlRightBottom.BackgroundImage = My.Resources.rbr
        Me.Location = New Point(Windows.Forms.Cursor.Position.X + 10, Windows.Forms.Cursor.Position.Y - Me.Size.Height - 10)
      Case EnmCornerPosition.RightBottom
        Me.pnlRightBottom.BackgroundImage = My.Resources.rbc
        Me.pnlLeftTop.BackgroundImage = My.Resources.ltr
        Me.pnlRightTop.BackgroundImage = My.Resources.rtr
        Me.pnlLeftBottom.BackgroundImage = My.Resources.lbr
        Me.Location = New Point(Windows.Forms.Cursor.Position.X - Me.Size.Width - 10, Windows.Forms.Cursor.Position.Y - Me.Size.Height - 10)
    End Select
  End Sub

  Private Sub baseFrom_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles pnlLeftTop.MouseDown, pnlCenterTop.MouseDown, pnlRightTop.MouseDown, pnlLeft.MouseDown, pnlRight.MouseDown, pnlLeftBottom.MouseDown, pnlCenterBottom.MouseDown, pnlRightBottom.MouseDown, pnlCenter.MouseDown
    If TopMost = False Then
      mBlnFormDragging = True
      mObjPointClicked = New Point(e.X, e.Y)
      Cursor = Cursors.SizeAll
    End If
  End Sub

  Private Sub baseFrom_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles pnlLeftTop.MouseUp, pnlCenterTop.MouseUp, pnlRightTop.MouseUp, pnlLeft.MouseUp, pnlRight.MouseUp, pnlLeftBottom.MouseUp, pnlCenterBottom.MouseUp, pnlRightBottom.MouseUp, pnlCenter.MouseUp
    If TopMost = False Then
      mBlnFormDragging = False
      Cursor = Cursors.Default
    End If
  End Sub

  Private Sub baseFrom_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles pnlLeftTop.MouseMove, pnlCenterTop.MouseMove, pnlRightTop.MouseMove, pnlLeft.MouseMove, pnlRight.MouseMove, pnlLeftBottom.MouseMove, pnlCenterBottom.MouseMove, pnlRightBottom.MouseMove, pnlCenter.MouseMove
    If mBlnFormDragging = True Then
      SetCornerBgImage(EnmCornerPosition.All)
      Dim lObjMoveToPoint As Point
      ' 以当前鼠标位置为基础，找出目标位置
      lObjMoveToPoint = PointToScreen(New Point(e.X, e.Y))
      ' 根据开始位置作出调整
      lObjMoveToPoint.Offset(mObjPointClicked.X * -1, _
         (mObjPointClicked.Y + _
         SystemInformation.BorderSize.Height * 0) * -1)
      ' 移动窗体
      Location = lObjMoveToPoint
    End If
  End Sub

  Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlClose.Click
    Me.Hide()
  End Sub

End Class
