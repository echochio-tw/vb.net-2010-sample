﻿Public Class frmgame
    'OIZLT
    Public sign(10, 20) As Integer
    Public active(10, 20) As Boolean
    Public activemove(10, 20) As Boolean
    Public lbcell(10, 20) As Label

    Public figuretype As Integer
    Public drawx As Integer, drawy As Integer
    WithEvents figurefalldown As New Timer

    Private Sub frmgame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then Call lmove()
        If e.KeyCode = Keys.Right Then Call rmove()
        If e.KeyCode = Keys.Down Then Call fastdown()
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Up Then
            If init(figuretype) = False Then
                Call rollfigure(drawx, drawy)
            End If
        End If
    End Sub

    Private Sub frmgame_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Randomize()
        Call loadlbcell()
        Call creatfigure(Fix(Rnd() * 19) + 1)
        figurefalldown.Enabled = True
        figurefalldown.Interval = 1000
        Me.AutoSize = True
    End Sub

    Public Function loadlbcell()
        For i As Integer = 0 To 9
            For o As Integer = 0 To 19
                lbcell(i, o) = New Label
                With lbcell(i, o)
                    .Name = "lbcell" & i & "," & o
                    .Width = 13
                    .Height = 13
                    .Left = 15 * i + 15
                    .Top = 15 * o + 10
                    .BackColor = Color.White
                End With
                Me.Controls.Add(lbcell(i, o))
            Next
        Next
        Return 0
    End Function '創建用於顯示方塊的label
    Public Function updatacell()
        For i As Integer = 0 To 9
            For o As Integer = 0 To 19
                If active(i, o) = True Or activemove(i, o) = True Then
                    lbcell(i, o).BackColor = Color.Black
                Else
                    lbcell(i, o).BackColor = Color.White
                End If
            Next
        Next
        Return 0
    End Function '更新格子顯示
    Public Function clearactivemove(ByVal ParamArray temp() As Object)
        For i As Integer = 0 To 9
            For o As Integer = 0 To 19
                activemove(i, o) = False
            Next
        Next
        Return 0
    End Function '清除當前處於移動狀態的cell的標誌,為下一次移動初始化

    Public Function creatfigure(ByVal figtype As Integer)
        Randomize()
        clearactivemove()
        Select Case figtype
            Case 1 'O
                figuretype = 1
                drawx = 4 : drawy = 0
                activemove(4, 0) = True : activemove(5, 0) = True
                activemove(4, 1) = True : activemove(5, 1) = True
            Case 2 'I
                figuretype = 2
                drawx = 5 : drawy = 1
                activemove(5, 0) = True
                activemove(5, 1) = True
                activemove(5, 2) = True
                activemove(5, 3) = True
            Case 3 '一
                figuretype = 3
                drawx = 5 : drawy = 0
                activemove(3, 0) = True : activemove(4, 0) = True : activemove(5, 0) = True : activemove(6, 0) = True
            Case 4 'Z
                figuretype = 4
                drawx = 5 : drawy = 0
                activemove(4, 0) = True : activemove(5, 0) = True
                activemove(5, 1) = True : activemove(6, 1) = True '->
            Case 5 'Z2
                figuretype = 5
                drawx = 6 : drawy = 1
                activemove(6, 0) = True '->
                activemove(5, 1) = True : activemove(6, 1) = True
                activemove(5, 2) = True
            Case 6 '反Z
                figuretype = 6
                drawx = 5 : drawy = 0
                activemove(5, 0) = True : activemove(6, 0) = True '->
                activemove(4, 1) = True : activemove(5, 1) = True
            Case 7 '反Z2
                figuretype = 7
                drawx = 5 : drawy = 1
                activemove(5, 0) = True
                activemove(5, 1) = True : activemove(6, 1) = True
                activemove(6, 2) = True '->
            Case 8 'L
                figuretype = 8
                drawx = 4 : drawy = 1
                activemove(4, 0) = True
                activemove(4, 1) = True
                activemove(4, 2) = True : activemove(5, 2) = True
            Case 9 'L2
                figuretype = 9
                drawx = 5 : drawy = 0
                activemove(4, 0) = True : activemove(5, 0) = True : activemove(6, 0) = True
                activemove(4, 1) = True
            Case 10 'L3
                figuretype = 10
                drawx = 6 : drawy = 1
                activemove(5, 0) = True : activemove(6, 0) = True
                activemove(6, 1) = True '->
                activemove(6, 2) = True '->
            Case 11 'L4
                figuretype = 11
                drawx = 5 : drawy = 1
                activemove(6, 0) = True '-->
                activemove(4, 1) = True : activemove(5, 1) = True : activemove(6, 1) = True
            Case 12 '反L
                figuretype = 12
                drawx = 6 : drawy = 1
                activemove(6, 0) = True '->
                activemove(6, 1) = True '->
                activemove(5, 2) = True : activemove(6, 2) = True
            Case 13 '反L2
                figuretype = 13
                drawx = 5 : drawy = 1
                activemove(4, 0) = True
                activemove(4, 1) = True : activemove(5, 1) = True : activemove(6, 1) = True
            Case 14 '反L3
                figuretype = 14
                drawx = 5 : drawy = 1
                activemove(5, 0) = True : activemove(6, 0) = True
                activemove(5, 1) = True
                activemove(5, 2) = True
            Case 15 '反L4
                figuretype = 15
                drawx = 5 : drawy = 0
                activemove(4, 0) = True : activemove(5, 0) = True : activemove(6, 0) = True
                activemove(6, 1) = True '-->
            Case 16 'T
                figuretype = 16
                drawx = 5 : drawy = 0
                activemove(4, 0) = True : activemove(5, 0) = True : activemove(6, 0) = True
                activemove(5, 1) = True '->
            Case 17 'T2
                figuretype = 17
                drawx = 6 : drawy = 1
                activemove(6, 0) = True '->
                activemove(5, 1) = True : activemove(6, 1) = True
                activemove(6, 2) = True '->
            Case 18 'T3
                figuretype = 18
                drawx = 5 : drawy = 1
                activemove(5, 0) = True '->
                activemove(4, 1) = True : activemove(5, 1) = True : activemove(6, 1) = True
            Case 19 'T4
                figuretype = 19
                drawx = 5 : drawy = 1
                activemove(5, 0) = True
                activemove(5, 1) = True : activemove(6, 1) = True
                activemove(5, 2) = True
        End Select
        updatacell()
        Return 0
    End Function '創建一個圖形,設置figuretype,activemove
    Public Function lmove()
        For i As Integer = 0 To 9
            For o As Integer = 0 To 19
                If activemove(i, o) = True Then
                    If i = 0 Then Return 0 : Exit Function
                    activemove(i - 1, o) = True : activemove(i, o) = False
                    drawx -= 1
                End If
            Next
        Next
        drawx += 3
        Me.Text = drawx & "," & drawy
        updatacell()
        Return 0
    End Function '向左移動圖形
    Public Function rmove()
        For i As Integer = 9 To 0 Step -1
            For o As Integer = 19 To 0 Step -1

                If activemove(i, o) = True Then
                    If i = 9 Then Return 0 : Exit Function
                    activemove(i + 1, o) = True : activemove(i, o) = False
                    drawx += 1
                End If
            Next
        Next
        drawx -= 3
        Me.Text = drawx & "," & drawy
        updatacell()
        Return 0
    End Function '向右移動圖形
    Public Function dmove()
        For i As Integer = 9 To 0 Step -1
            For o As Integer = 19 To 0 Step -1
                If activemove(i, o) = True Then
                    activemove(i, o + 1) = True : activemove(i, o) = False
                End If
            Next
        Next
        drawy += 1
        Me.Text = drawx & "," & drawy
        updatacell()
        Return 0
    End Function '向下移動圖形

    Public Function rollfigure(ByVal x As Integer, ByVal y As Integer)
        clearactivemove()
        Select Case Me.figuretype
            Case 1 'O型方塊,不用旋轉

                activemove(x, y) = True : activemove(x + 1, y) = True
                activemove(x, y + 1) = True : activemove(x + 1, y + 1) = True

            Case 2 'I型方塊 -> 一型方塊

                If x = 9 Then
                    drawx = 8
                    For o As Integer = 0 To 3
                        activemove(x - o, y) = True
                    Next

                ElseIf x <= 2 Then
                    drawx = 2
                    For o As Integer = 0 To 3
                        activemove(o, y) = True
                    Next

                Else
                    activemove(x - 2, y) = True : activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                End If
                figuretype = 3

            Case 3 '一型方塊 -> I型方塊
                If y = 0 Then
                    drawy = 1
                    For o As Integer = 0 To 3
                        activemove(x, o) = True
                    Next
                Else
                    activemove(x, y - 1) = True
                    activemove(x, y) = True
                    activemove(x, y + 1) = True
                    activemove(x, y + 2) = True
                End If
                figuretype = 2

            Case 4 'Z型方塊 -> Z2型方塊
                If y = 0 Then
                    drawy = 1
                    activemove(x, y) = True '->
                    activemove(x - 1, y + 1) = True : activemove(x, y + 1) = True
                    activemove(x - 1, y + 2) = True
                Else
                    activemove(x, y - 1) = True '->
                    activemove(x - 1, y) = True : activemove(x, y) = True
                    activemove(x - 1, y + 1) = True
                End If
                figuretype = 5

            Case 5 'Z2型方塊 -> Z型方塊
                If x = 9 Then
                    drawx = 8
                    activemove(x - 2, y) = True : activemove(x - 1, y) = True
                    activemove(x - 1, y + 1) = True : activemove(x, y + 1) = True  '->
                Else
                    activemove(x - 1, y) = True : activemove(x, y) = True
                    activemove(x, y + 1) = True : activemove(x + 1, y + 1) = True  '->
                End If
                figuretype = 4

            Case 6 '反Z型方塊 -> 反Z2型方塊
                If y = 0 Then
                    drawy = 1
                    activemove(x, y) = True
                    activemove(x, y + 1) = True : activemove(x + 1, y + 1) = True
                    activemove(x + 1, y + 2) = True '->
                Else
                    activemove(x, y - 1) = True
                    activemove(x, y) = True : activemove(x + 1, y) = True
                    activemove(x + 1, y + 1) = True '->
                End If
                figuretype = 7

            Case 7 '反Z2型方塊 -> 反Z型方塊
                If x = 0 Then
                    drawx = 1
                    activemove(x + 1, y) = True : activemove(x + 2, y) = True '->
                    activemove(x, y + 1) = True : activemove(x + 1, y + 1) = True
                Else
                    activemove(x, y) = True : activemove(x + 1, y) = True '->
                    activemove(x - 1, y + 1) = True : activemove(x, y + 1) = True
                End If
                figuretype = 6

            Case 8 'L -> L1
                If x = 0 Then
                    drawx = 1
                    activemove(x, y) = True : activemove(x + 1, y) = True : activemove(x + 2, y) = True
                    activemove(x, y + 1) = True
                Else
                    activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                    activemove(x - 1, y + 1) = True
                End If
                figuretype = 9

            Case 9 'L1 -> L2
                If y = 0 Then
                    drawy = 1
                    activemove(x - 1, y) = True : activemove(x, y) = True
                    activemove(x, y + 1) = True '->
                    activemove(x, y + 2) = True '->
                Else
                    activemove(x - 1, y - 1) = True : activemove(x, y - 1) = True
                    activemove(x, y) = True '->
                    activemove(x, y + 1) = True '->
                End If
                figuretype = 10

            Case 10 'L2 -> L3
                If x = 9 Then
                    drawx = 8
                    activemove(x, y - 1) = True '-->
                    activemove(x - 2, y) = True : activemove(x - 1, y) = True : activemove(x, y) = True
                Else
                    activemove(x + 1, y - 1) = True '-->
                    activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                End If
                figuretype = 11

            Case 11 'L3 -> L
                activemove(x, y - 1) = True
                activemove(x, y) = True
                activemove(x, y + 1) = True : activemove(x + 1, y + 1) = True
                figuretype = 8

            Case 12 '反L -> 反L1
                If x = 9 Then
                    drawx = 8
                    activemove(x - 2, y - 1) = True
                    activemove(x - 2, y) = True : activemove(x - 1, y) = True : activemove(x, y) = True
                Else
                    activemove(x - 1, y - 1) = True
                    activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                End If
                figuretype = 13

            Case 13 '反L1 -> 反L2
                activemove(x, y - 1) = True : activemove(x + 1, y - 1) = True
                activemove(x, y) = True
                activemove(x, y + 1) = True
                figuretype = 14

            Case 14 '反L2 -> 反L3
                If x = 0 Then
                    drawx = 1
                    activemove(x, y) = True : activemove(x + 1, y) = True : activemove(x + 2, y) = True
                    activemove(x + 2, y + 1) = True '-->
                Else
                    activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                    activemove(x + 1, y + 1) = True '-->
                End If
                figuretype = 15

            Case 15 '反L3 -> 反L
                If y = 0 Then
                    drawy = 1
                    activemove(x, y) = True '->
                    activemove(x, y + 1) = True '->
                    activemove(x, y + 2) = True : activemove(x + 1, y + 1) = True
                Else
                    activemove(x, y - 1) = True '->
                    activemove(x, y) = True '->
                    activemove(x - 1, y + 1) = True : activemove(x, y + 1) = True
                End If
                figuretype = 12

            Case 16 'T -> T1
                If y = 0 Then
                    drawy = 1
                    activemove(x, y) = True '->
                    activemove(x - 1, y + 1) = True : activemove(x, y + 1) = True
                    activemove(x, y + 2) = True '->
                Else
                    activemove(x, y - 1) = True '->
                    activemove(x - 1, y) = True : activemove(x, y) = True
                    activemove(x, y + 1) = True '->
                End If
                figuretype = 17

            Case 17 'T1 -> T2
                If x = 9 Then
                    drawx = 8
                    activemove(x - 1, y - 1) = True '->
                    activemove(x - 2, y) = True : activemove(x - 1, y) = True : activemove(x, y) = True
                Else
                    activemove(x, y - 1) = True '->
                    activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                End If
                figuretype = 18

            Case 18 'T2 -> T3
                activemove(x, y - 1) = True
                activemove(x, y) = True : activemove(x + 1, y) = True
                activemove(x, y + 1) = True
                figuretype = 19
            Case 19 'T3 -> T
                If x = 0 Then
                    drawx = 1
                    activemove(x, y) = True : activemove(x + 1, y) = True : activemove(x + 2, y) = True
                    activemove(x + 1, y + 1) = True '->
                Else
                    activemove(x - 1, y) = True : activemove(x, y) = True : activemove(x + 1, y) = True
                    activemove(x, y + 1) = True '->
                End If
                figuretype = 16
        End Select
        updatacell()
        Me.Text = drawx & "," & drawy
        Return 0
    End Function ' '以drawx,和deawy為參數,繪製旋轉後的圖形


    Public Function touchhead(ByVal figtype As Integer) As Boolean
        For i As Integer = 0 To 9
            For o As Integer = 0 To 19
                If activemove(i, o) = True And active(i, o + 1) = True Then Call passactive() : touchhead = True : Return touchhead '下方存在圖形
                If activemove(i, o) = True And o = 19 Then Call passactive() : touchhead = True : Return touchhead '到達區域底部
            Next
        Next
        touchhead = False : Return touchhead
    End Function '判斷圖形如果向下運動是否會碰撞到已有圖形或區域底部
    Public Function init(ByVal figtype As Integer) As Boolean
        Try
            Select Case figtype
                Case 1
                    Return False
                Case 2
                    Return (active(drawx - 2, drawy) = True Or active(drawx - 1, drawy) = True Or active(drawx + 1, drawy) = True)
                Case 3
                    Return (active(drawx, drawy - 1) = True Or active(drawx, drawy + 1) = True Or active(drawx + 1, drawy + 2) = True Or drawy >= 18)
                Case 4
                    Return (active(drawx, drawy - 1) = True Or active(drawx - 1, drawy + 1) = True)
                Case 5
                    Return (active(drawx + 1, drawy + 1) = True Or active(drawx, drawy + 1) = True)
                Case 6
                    Return (active(drawx + 1, drawy + 1) = True Or active(drawx, drawy - 1) = True)
                Case 7
                    Return (active(drawx - 1, drawy + 1) = True Or active(drawx, drawy + 1) = True)
                Case 8
                    Return (active(drawx - 1, drawy) = True Or active(drawx + 1, drawy) = True Or active(drawx - 1, drawy + 1) = True)
                Case 9
                    Return (active(drawx - 1, drawy - 1) = True Or active(drawx, drawy - 1) = True Or active(drawx, drawy + 1) = True)
                Case 10
                    Return (active(drawx - 1, drawy) = True Or active(drawx + 1, drawy) = True Or active(drawx + 1, drawy + 1) = True)
                Case 11
                    Return (active(drawx, drawy - 1) = True Or active(drawx, drawy + 1) = True Or active(drawx + 1, drawy + 1) = True)
                Case 12
                    Return (active(drawx - 1, drawy) = True Or active(drawx + 1, drawy) = True Or active(drawx - 1, drawy - 1) = True)
                Case 13
                    Return (active(drawx + 1, drawy + 1) = True Or active(drawx, drawy - 1) = True Or active(drawx, drawy + 1) = True)
                Case 14
                    Return (active(drawx - 1, drawy) = True Or active(drawx + 1, drawy) = True Or active(drawx + 1, drawy + 1) = True)
                Case 15
                    Return (active(drawx - 1, drawy + 1) = True Or active(drawx, drawy - 1) = True Or active(drawx, drawy + 1) = True)
                Case 16
                    Return (active(drawx, drawy - 1) = True)
                Case 17
                    Return (active(drawx + 1, drawy) = True)
                Case 18
                    init = (active(drawx, drawy + 1) = True)
                Case 19
                    Return (active(drawx - 1, drawy) = True)
            End Select
        Catch ex As Exception
            Return True
        End Try
        Return False
    End Function '判斷旋轉後的圖形是否與已有圖形或區域底部重合並返回結果
    Public Function passactive()
        For i As Integer = 0 To 9
            For o As Integer = 0 To 19
                If activemove(i, o) = True Then active(i, o) = True
            Next
        Next
        clearactivemove()
        Return 0
    End Function '將activemove傳遞給active
    Public Function fastdown()
        Dim n As Integer
        Do While touchhead(figuretype) = False
            Call dmove()
        Loop
        For w = 0 To 3
            For o As Integer = 0 To 19
                For i As Integer = 0 To 9
                    If active(i, o) = False Then n += 1
                Next
                If n = 0 Then
                    For linex = 0 To 9
                        active(linex, o) = False
                    Next
                    For liney = o To 1 Step -1
                        For linexx = 0 To 9
                            active(linexx, liney) = active(linexx, liney - 1)
                        Next
                    Next
                End If
                n = 0
            Next
        Next
        updatacell()
        passactive()
        creatfigure(Fix(Rnd() * 19) + 1)
        Return 0
    End Function '快速下落
    Public Function clearline()
        Return 0
    End Function '消除已滿的一行

    Private Sub figurefalldown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles figurefalldown.Tick
        Dim n As Integer
        n = 0
        If touchhead(figuretype) = False Then
            Call dmove()
        Else
            passactive()
            For w = 0 To 3
                For o As Integer = 0 To 19
                    For i As Integer = 0 To 9
                        If active(i, o) = False Then n += 1
                    Next
                    If n = 0 Then
                        For linex = 0 To 9
                            active(linex, o) = False
                        Next
                        For liney = o To 1 Step -1
                            For linexx = 0 To 9
                                active(linexx, liney) = active(linexx, liney - 1)
                            Next
                        Next
                    End If
                    n = 0
                Next
            Next
            Call creatfigure(Fix(Rnd() * 19) + 1)
        End If
    End Sub '方塊下落的計時器
End Class
