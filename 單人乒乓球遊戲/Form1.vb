Public Class Form1
    '-----------------------------------------------------
    '��l�H�۷ƹ�����
    '-----------------------------------------------------
    Private Sub BeiJing_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BeiJing.MouseMove
        If e.X > 12 And e.X < 325 Then
            L.Left = e.X
        End If
    End Sub
    '-----------------------------------------------------
    '�w�q�����ܼ�
    '-----------------------------------------------------
    Dim x As Integer = 2
    Dim y As Integer = 2

    '-----------------------------------------------------
    '�ɶ��j��A�C0.01�����@��
    '-----------------------------------------------------
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '-----------------------------------------------------
        '�겾��
        '-----------------------------------------------------
        yuan.Left = yuan.Left + x
        yuan.Top = yuan.Top + y
        '-----------------------------------------------------
        '���T��if�ΨӧP�_��u
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
        '�C�������P�w
        '-----------------------------------------------------
        If yuan.Top >= 295 Then
            Timer1.Enabled = False
            MessageBox.Show("Game Over", "�h�h�m�ߧa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End
        End If

        '-----------------------------------------------------
        '�y�����
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan.Left - 10)
        C2.Text = "Y:" + CStr(yuan.Top - 10)
    End Sub

    Private Sub BeiJing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeiJing.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
