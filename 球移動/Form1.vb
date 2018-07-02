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
        If (yuan.Top >= 295 And yuan.Top <= 296) Or (yuan.Top >= 9 And yuan.Top <= 11) Then
            y = -y
        End If
        If (yuan.Left >= 369 And yuan.Left <= 371) Or (yuan.Left >= 9 And yuan.Left <= 11) Then
            x = -x
        End If

        '-----------------------------------------------------
        '座標顯示
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan.Left - 10)
        C2.Text = "Y:" + CStr(yuan.Top - 10)
    End Sub

End Class
