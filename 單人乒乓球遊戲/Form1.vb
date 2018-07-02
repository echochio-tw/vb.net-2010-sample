Public Class Form1
    '-----------------------------------------------------
    '拍子隨著滑鼠移動
    '-----------------------------------------------------
    Private Sub BeiJing_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BeiJing.MouseMove
        If e.X > 12 And e.X < 325 Then
            L.Left = e.X
        End If
    End Sub
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
        '的三個if用來判斷邊線
        '-----------------------------------------------------
        If yuan.Top >= 275 And yuan.Top <= 276 Then
            If (yuan.Left >= L.Left - 3) And (yuan.Left <= L.Left + 58) Then
                y = -y
            End If
        End If
        If (yuan.Left >= 369 And yuan.Left <= 371) Or (yuan.Left >= 9 And yuan.Left <= 11) Then
            x = -x
        End If
        If yuan.Top >= 9 And yuan.Top <= 11 Then
            y = -y
        End If

        '-----------------------------------------------------
        '遊戲結束判定
        '-----------------------------------------------------
        If yuan.Top >= 295 Then
            Timer1.Enabled = False
            MessageBox.Show("Game Over", "多多練習吧", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End
        End If

        '-----------------------------------------------------
        '座標顯示
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan.Left - 10)
        C2.Text = "Y:" + CStr(yuan.Top - 10)
    End Sub

    Private Sub BeiJing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeiJing.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
