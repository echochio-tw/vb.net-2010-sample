Public Class Form1
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
        'if�ΨӧP�_��u
        '-----------------------------------------------------
        If (yuan.Top >= 295 And yuan.Top <= 296) Or (yuan.Top >= 9 And yuan.Top <= 11) Then
            y = -y
        End If
        If (yuan.Left >= 369 And yuan.Left <= 371) Or (yuan.Left >= 9 And yuan.Left <= 11) Then
            x = -x
        End If

        '-----------------------------------------------------
        '�y�����
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan.Left - 10)
        C2.Text = "Y:" + CStr(yuan.Top - 10)
    End Sub

End Class
