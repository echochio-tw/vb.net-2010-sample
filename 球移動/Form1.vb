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
        If (yuan.Top >= Me.Height - 47) Or (yuan.Top < 0) Then
            y = -y
        End If
        If (yuan.Left >= Me.Width - 27) Or (yuan.Left < 0) Then
            x = -x
        End If

        '-----------------------------------------------------
        '�y�����
        '-----------------------------------------------------
        C1.Text = "X:" + CStr(yuan.Left)
        C2.Text = "Y:" + CStr(yuan.Top)
    End Sub

End Class
