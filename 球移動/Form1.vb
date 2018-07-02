Public Class Form1
    '-----------------------------------------------------
    '定義移動變數
    '-----------------------------------------------------
    Dim x As Integer = 2
    Dim y As Integer = 2
    '-----------------------------------------------------
    '時間迴圈，每0.01秒執行一次
    '-----------------------------------------------------
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '-----------------------------------------------------
        '圓移動
        '-----------------------------------------------------
        yuan.Left = yuan.Left + x
        yuan.Top = yuan.Top + y
        '-----------------------------------------------------
        'if用來判斷邊線
        '-----------------------------------------------------
        If (yuan.Top >= Me.Height - 47) Or (yuan.Top < 0) Then
            y = -y
        End If
        If (yuan.Left >= Me.Width - 27) Or (yuan.Left < 0) Then
            x = -x
        End If

        '-----------------------------------------------------
        '座標顯示
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan.Left)
        C2.Text = "Y:" + CStr(yuan.Top)
    End Sub

End Class
