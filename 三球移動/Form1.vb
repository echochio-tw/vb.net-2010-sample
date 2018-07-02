Public Class Form1
    '-----------------------------------------------------
    '定義移動變數
    '-----------------------------------------------------
    Dim x1 As Integer = 2
    Dim y1 As Integer = 2
    Dim x2 As Integer = 2
    Dim y2 As Integer = 2
    Dim x3 As Integer = 2
    Dim y3 As Integer = 2
    '-----------------------------------------------------
    '時間迴圈，每0.01秒執行一次
    '-----------------------------------------------------
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '-----------------------------------------------------
        '圓移動
        '-----------------------------------------------------
        yuan1.Left = yuan1.Left + x1
        yuan1.Top = yuan1.Top + y1
        yuan2.Left = yuan2.Left + x2
        yuan2.Top = yuan2.Top + y2
        yuan3.Left = yuan3.Left + x3
        yuan3.Top = yuan3.Top + y3
        '-----------------------------------------------------
        'if用來判斷邊線
        '-----------------------------------------------------
        If (yuan1.Top >= Me.Height - 47) Or (yuan1.Top < 0) Then
            y1 = -y1
        End If
        If (yuan1.Left >= Me.Width - 27) Or (yuan1.Left < 0) Then
            x1 = -x1
        End If
        '-----------------------------------------------------
        If (yuan2.Top >= Me.Height - 47) Or (yuan2.Top < 0) Then
            y2 = -y2
        End If
        If (yuan2.Left >= Me.Width - 27) Or (yuan2.Left < 0) Then
            x2 = -x2
        End If
         '-----------------------------------------------------
        If (yuan3.Top >= Me.Height - 47) Or (yuan3.Top < 0) Then
            y3 = -y3
        End If
        If (yuan3.Left >= Me.Width - 27) Or (yuan3.Left < 0) Then
            x3 = -x3
        End If

        '-----------------------------------------------------
        '座標顯示
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan1.Left)
        C2.Text = "Y:" + CStr(yuan1.Top)
        C3.Text = "X:" + CStr(yuan2.Left)
        C4.Text = "Y:" + CStr(yuan2.Top)
        C5.Text = "X:" + CStr(yuan3.Left)
        C6.Text = "Y:" + CStr(yuan3.Top)
    End Sub

End Class
