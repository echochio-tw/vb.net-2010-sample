Public Class Form1
    Dim ILeft As Integer = 10
    Dim ITop As Integer = 10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1_Click()
    End Sub

    Private Sub Button1_Click()
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If ((Button1.Left + ILeft + 76) > Me.Width) Or ((Button1.Left + ILeft) < 0) Then
            ILeft = -ILeft
        End If

        If ((Button1.Top + ITop + 50) > Me.Height) Or ((Button1.Top + ITop) < 0) Then
            ITop = -ITop
        End If

        Button1.Top = Button1.Top + ITop
        Button1.Left = Button1.Left + ILeft
    End Sub
End Class
