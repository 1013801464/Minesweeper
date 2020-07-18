Public Class 核心面板
    Private 已启用 As Boolean = False
    Private pb() As PicBox
    Dim r As 面板
    Dim FirstClick As Boolean = False
    Dim u As Integer
    Default ReadOnly Property ImageItem(X As Byte, y As Byte) As PicBox
        Get
            Return pb((X - 1) * r.宽 + y)
        End Get
    End Property
    Public ReadOnly Property 已启用_
        Get
            Return 已启用
        End Get
    End Property
    Public Sub 设定面板(ByRef r As 面板, Ena As Boolean)
        Panel1.Visible = False
        Panel1.Controls.Clear()
        Dim n As Integer = 0
        Me.r = r
        ReDim pb(CType(r.高, Integer) * CType(r.宽, Integer))
        For i As Integer = 1 To r.高
            For j As Integer = 1 To r.宽
                n += 1
                Dim x As Integer = Panel1.Width / r.宽
                pb(n) = New PicBox(i, j, Me, Ena)
                pb(n).Margin = New Padding(0, 0, 0, 0)
                pb(n).Size = New Size(x, x)
                pb(n).Image = New Bitmap(设置.invisible)
                pb(n).SizeMode = PictureBoxSizeMode.StretchImage
                Panel1.Controls.Add(pb(n))
            Next
        Next
        u = CType(r.宽, Integer) * CType(r.高, Integer)
    End Sub
    Public Sub 启动()
        设置.表.获取对象.得分 = 0
        设置.表.获取对象.剩余雷数 = 设置.表.获取对象.雷数
        已启用 = True
        调整Panel()
    End Sub
    Public Sub 启动_用于ListView查看()
        已启用 = True
        调整Panel()
        刷新全部图像()
    End Sub

    Public Sub 从暂停状态恢复()
        设定面板(设置.表.获取对象.获取面板, True)
        已启用 = True
        frm主窗体.时间计时器.Enabled = True
        调整Panel()
        刷新全部图像()
        frm主窗体.Toggle()
        frm主窗体.暂停ToolStripMenuItem.Tag = 1
        Panel1.Visible = True
        frm主窗体.暂停ToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Public Sub 初始化游戏()
        frm主窗体.Toggle()
        FirstClick = True
        设置.表.获取对象.游戏开始()
    End Sub
    Public Sub 关闭()
        已启用 = False
        Panel1.Visible = False
        r = Nothing
    End Sub
    Public Sub 点击(x As Byte, y As Byte, 主动 As Boolean)
        If 设置.表.获取对象.状态 = 状态枚举.正在进行 And x > 0 And x <= r.高 And y > 0 And y <= r.宽 Then
            If r(x, y).旗子 = False Then      '什么任务都建立在没有旗子的前提下
                If FirstClick Then
                    FirstClick = False
                    Dim mine As Integer = 设置.当前.上一次的雷数, 已经 As Integer = 0
                    Dim t As New Random
                    Dim xr As Byte, yr As Byte
                    'If mine / r.宽 / r.高 < 0.5 Then
                    '    Do While 已经 < mine
                    '        xr = t.Next Mod r.高 + 1
                    '        yr = t.Next Mod r.宽 + 1
                    '        If xr <> x And yr <> y And r(xr, yr).雷 = False Then
                    '            r(xr, yr).雷 = True
                    '            已经 += 1
                    '        End If
                    '    Loop
                    'Else
                    '    Dim temp As Short = CType(r.宽, Short) * CType(r.高, Short)
                    '    Dim remain As Short = temp - 设置.表.获取对象.雷数 - 1
                    '    For i As Integer = 1 To r.高
                    '        For j As Integer = 1 To r.宽
                    '            r(i, j).雷 = True
                    '        Next
                    '    Next
                    '    r(x, y).雷 = False
                    '    Do While 已经 < remain        '前面减过1了
                    '        xr = t.Next Mod r.高 + 1
                    '        yr = t.Next Mod r.宽 + 1
                    '        If xr <> x And yr <> y And r(xr, yr).雷 = True Then
                    '            r(xr, yr).雷 = False
                    '            已经 += 1
                    '        End If
                    '    Loop
                    'End If
                    r(2, 6).雷 = True
                    r(2, 16).雷 = True
                    r(3, 7).雷 = True
                    r(3, 16).雷 = True
                    r(3, 21).雷 = True
                    r(3, 22).雷 = True
                    r(3, 25).雷 = True
                    r(4, 3).雷 = True
                    r(4, 4).雷 = True
                    r(4, 5).雷 = True
                    r(4, 6).雷 = True
                    r(4, 7).雷 = True
                    r(4, 8).雷 = True
                    r(4, 9).雷 = True
                    r(4, 10).雷 = True
                    r(4, 16).雷 = True
                    r(4, 23).雷 = True
                    r(4, 27).雷 = True
                    r(5, 3).雷 = True
                    r(5, 5).雷 = True
                    r(5, 8).雷 = True
                    r(5, 10).雷 = True
                    r(5, 16).雷 = True
                    r(5, 27).雷 = True
                    r(6, 4).雷 = True
                    r(6, 5).雷 = True
                    r(6, 6).雷 = True
                    r(6, 7).雷 = True
                    r(6, 8).雷 = True
                    r(6, 9).雷 = True
                    r(6, 16).雷 = True
                    r(6, 21).雷 = True
                    r(7, 5).雷 = True
                    r(7, 8).雷 = True
                    r(7, 14).雷 = True
                    r(7, 16).雷 = True
                    r(7, 18).雷 = True
                    r(7, 22).雷 = True
                    r(7, 25).雷 = True
                    r(8, 3).雷 = True
                    r(8, 4).雷 = True
                    r(8, 5).雷 = True
                    r(8, 6).雷 = True
                    r(8, 7).雷 = True
                    r(8, 8).雷 = True
                    r(8, 9).雷 = True
                    r(8, 10).雷 = True
                    r(8, 13).雷 = True
                    r(8, 16).雷 = True
                    r(8, 19).雷 = True
                    r(8, 24).雷 = True
                    r(8, 25).雷 = True
                    r(8, 29).雷 = True
                    r(9, 4).雷 = True
                    r(9, 9).雷 = True
                    r(9, 12).雷 = True
                    r(9, 16).雷 = True
                    r(9, 20).雷 = True
                    r(9, 23).雷 = True
                    r(9, 25).雷 = True
                    r(9, 29).雷 = True
                    r(10, 3).雷 = True
                    r(10, 4).雷 = True
                    r(10, 5).雷 = True
                    r(10, 6).雷 = True
                    r(10, 7).雷 = True
                    r(10, 8).雷 = True
                    r(10, 9).雷 = True
                    r(10, 10).雷 = True
                    r(10, 16).雷 = True
                    r(10, 22).雷 = True
                    r(10, 25).雷 = True
                    r(10, 30).雷 = True
                    r(11, 2).雷 = True
                    r(11, 4).雷 = True
                    r(11, 5).雷 = True
                    r(11, 6).雷 = True
                    r(11, 7).雷 = True
                    r(11, 8).雷 = True
                    r(11, 9).雷 = True
                    r(11, 11).雷 = True
                    r(11, 16).雷 = True
                    r(11, 22).雷 = True
                    r(11, 25).雷 = True
                    r(11, 30).雷 = True
                    r(12, 6).雷 = True
                    r(12, 16).雷 = True
                    r(12, 22).雷 = True
                    r(12, 25).雷 = True
                    r(12, 30).雷 = True
                    r(13, 4).雷 = True
                    r(13, 6).雷 = True
                    r(13, 7).雷 = True
                    r(13, 8).雷 = True
                    r(13, 9).雷 = True
                    r(13, 14).雷 = True
                    r(13, 16).雷 = True
                    r(13, 20).雷 = True
                    r(13, 21).雷 = True
                    r(13, 25).雷 = True
                    r(13, 30).雷 = True
                    r(14, 4).雷 = True
                    r(14, 5).雷 = True
                    r(14, 6).雷 = True
                    r(14, 15).雷 = True
                    r(14, 16).雷 = True
                    r(14, 26).雷 = True
                    r(14, 28).雷 = True
                    r(15, 3).雷 = True
                    r(15, 7).雷 = True
                    r(15, 16).雷 = True
                    r(15, 26).雷 = True
                    r(15, 27).雷 = True
                    r(15, 28).雷 = True
                    r(16, 2).雷 = True
                    r(16, 8).雷 = True
                    r(16, 9).雷 = True
                    r(16, 10).雷 = True


                    Dim totalnum As Byte = 0
                    For a As Byte = 1 To r.高
                        For b As Byte = 1 To r.宽
                            totalnum = 0
                            If r(a - 1, b - 1) IsNot Nothing Then
                                If r(a - 1, b - 1).雷 Then totalnum += 1
                            End If
                            If r(a - 1, b) IsNot Nothing Then
                                If r(a - 1, b).雷 Then totalnum += 1
                            End If
                            If r(a - 1, b + 1) IsNot Nothing Then
                                If r(a - 1, b + 1).雷 Then totalnum += 1
                            End If
                            If r(a, b - 1) IsNot Nothing Then
                                If r(a, b - 1).雷 Then totalnum += 1
                            End If
                            If r(a, b + 1) IsNot Nothing Then
                                If r(a, b + 1).雷 Then totalnum += 1
                            End If
                            If r(a + 1, b - 1) IsNot Nothing Then
                                If r(a + 1, b - 1).雷 Then totalnum += 1
                            End If
                            If r(a + 1, b) IsNot Nothing Then
                                If r(a + 1, b).雷 Then totalnum += 1
                            End If
                            If r(a + 1, b + 1) IsNot Nothing Then
                                If r(a + 1, b + 1).雷 Then totalnum += 1
                            End If
                            r(a, b).数目 = totalnum
                        Next
                    Next
                    r(x, y).可见 = True
                    刷新指定位置图像(x, y)
                    扩展()
                Else    '这是非第一次单击
                    If r(x, y).可见 = False Then
                        If r(x, y).雷 = False Then
                            r(x, y).可见 = True
                            设置.表.获取对象.得分 += 2
                            刷新指定位置图像(x, y)
                            扩展()
                        Else
                            If r(x, y).旗子 = False Then
                                '游戏失败代码


                                设置.表.获取对象.游戏结束(状态枚举.失败)
                                刷新全部图像()
                                设置.保存游戏()
                                frm主窗体.时间计时器.Enabled = False
                                frm主窗体.Toggle()

                                '进行报告
                                胜利.SetImage(状态枚举.失败, 设置.表.获取对象.得分, 设置.表.获取对象.get已用时间)
                                Select Case 胜利.ShowDialog()
                                    Case DialogResult.Yes
                                        frm主窗体.新游戏NToolStripMenuItem_Click(Nothing, Nothing)
                                        Exit Sub
                                    Case DialogResult.No
                                        End
                                    Case DialogResult.Cancel
                                        Exit Sub
                                End Select
                                '退出函数
                                Exit Sub
                            End If
                        End If
                        If 判断胜利() Then
                            '游戏胜利代码

                            设置.表.获取对象.游戏结束(状态枚举.胜利)
                            设置.保存游戏()
                            刷新全部图像()
                            frm主窗体.时间计时器.Enabled = False
                            frm主窗体.ProgressBar1.Value = 100
                            胜利.SetImage(状态枚举.胜利, 设置.表.获取对象.得分, 设置.表.获取对象.get已用时间)
                            frm主窗体.Toggle()
                            Select Case 胜利.ShowDialog()
                                Case DialogResult.Yes
                                    frm主窗体.新游戏NToolStripMenuItem_Click(Nothing, Nothing)
                                    Exit Sub
                                Case DialogResult.No
                                    End

                                Case DialogResult.Cancel
                                    Exit Sub
                            End Select
                        End If
                    ElseIf (主动)    '执行双击任务
                        '先算出来没有标记的数量和没有打开的数量
                        Dim NoneFlag As Byte = 0, HaveFlag As Byte = 0
                        If r(x - 1, y - 1) IsNot Nothing Then
                            If r(x - 1, y - 1).可见 = False Then
                                If r(x - 1, y - 1).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x - 1, y) IsNot Nothing Then
                            If r(x - 1, y).可见 = False Then
                                If r(x - 1, y).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x - 1, y + 1) IsNot Nothing Then
                            If r(x - 1, y + 1).可见 = False Then
                                If r(x - 1, y + 1).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x, y - 1) IsNot Nothing Then
                            If r(x, y - 1).可见 = False Then
                                If r(x, y - 1).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x, y + 1) IsNot Nothing Then
                            If r(x, y + 1).可见 = False Then
                                If r(x, y + 1).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x + 1, y - 1) IsNot Nothing Then
                            If r(x + 1, y - 1).可见 = False Then
                                If r(x + 1, y - 1).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x + 1, y) IsNot Nothing Then
                            If r(x + 1, y).可见 = False Then
                                If r(x + 1, y).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If r(x + 1, y + 1) IsNot Nothing Then
                            If r(x + 1, y + 1).可见 = False Then
                                If r(x + 1, y + 1).旗子 Then
                                    HaveFlag += 1
                                Else
                                    NoneFlag += 1
                                End If
                            End If
                        End If
                        If NoneFlag <> 0 Then
                            If 设置.当前.使用自动扩展 And r(x, y).数目 = HaveFlag Then
                                '任务一:双击扩展算法,需要条件
                                点击(x - 1, y - 1, False)
                                点击(x - 1, y, False)
                                点击(x - 1, y + 1, False)
                                点击(x, y - 1, False)
                                点击(x, y + 1, False)
                                点击(x + 1, y - 1, False)
                                点击(x + 1, y, False)
                                点击(x + 1, y + 1, False)
                            ElseIf 设置.当前.使用自动标记 And r(x, y).数目 - HaveFlag = NoneFlag Then
                                '任务二:双击标记算法,需要条件
                                标记(x - 1, y - 1, False)
                                标记(x - 1, y, False)
                                标记(x - 1, y + 1, False)
                                标记(x, y - 1, False)
                                标记(x, y + 1, False)
                                标记(x + 1, y - 1, False)
                                标记(x + 1, y, False)
                                标记(x + 1, y + 1, False)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub 扩展()
        Dim FindNew = False
        Dim FindEmpty = False
        Do
            FindNew = False
            For x As Byte = 1 To r.高
                For y As Byte = 1 To r.宽
                    If r(x, y).可见 Then Continue For
                    FindEmpty = False
                    If r(x - 1, y - 1) IsNot Nothing Then
                        If r(x - 1, y - 1).可见 = True And r(x - 1, y - 1).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x - 1, y) IsNot Nothing Then
                        If r(x - 1, y).可见 = True And r(x - 1, y).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x - 1, y + 1) IsNot Nothing Then
                        If r(x - 1, y + 1).可见 = True And r(x - 1, y + 1).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x, y - 1) IsNot Nothing Then
                        If r(x, y - 1).可见 = True And r(x, y - 1).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x, y + 1) IsNot Nothing Then
                        If r(x, y + 1).可见 = True And r(x, y + 1).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x + 1, y - 1) IsNot Nothing Then
                        If r(x + 1, y - 1).可见 = True And r(x + 1, y - 1).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x + 1, y) IsNot Nothing Then
                        If r(x + 1, y).可见 = True And r(x + 1, y).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If r(x + 1, y + 1) IsNot Nothing Then
                        If r(x + 1, y + 1).可见 = True And r(x + 1, y + 1).数目 = 0 Then
                            FindEmpty = True
                        End If
                    End If
                    If FindEmpty Then
                        r(x, y).可见 = True
                        设置.表.获取对象.得分 += 1
                        刷新指定位置图像(x, y)
                        FindNew = True
                    End If
                Next y
            Next x
        Loop While FindNew
    End Sub
    Public Sub 标记(x As Byte, y As Byte, 主动 As Boolean)
        If 设置.表.获取对象.状态 = 状态枚举.正在进行 And x > 0 And x <= r.高 And y > 0 And y <= r.宽 Then
            If r(x, y).可见 = False Then
                If r(x, y).旗子 = False Then
                    r(x, y).旗子 = True
                    设置.表.获取对象.剩余雷数 -= 1
                ElseIf r(x, y).旗子 And 主动 Then
                    r(x, y).旗子 = False
                    设置.表.获取对象.剩余雷数 += 1
                End If
                刷新指定位置图像(x, y)
            End If
        End If
    End Sub
    Private Function 判断胜利() As Boolean
        Dim t = True
        For x As Byte = 1 To r.高
            For y As Byte = 1 To r.宽
                If r(x, y).雷 = False Then
                    If r(x, y).可见 = False Then
                        t = False
                        Exit For
                    End If
                End If
            Next
            If t = False Then Exit For
        Next
        Return t
    End Function
    Public Sub 调整Panel()
        If pb IsNot Nothing And 已启用 Then
            Panel1.Cursor = Cursors.WaitCursor

            If 设置.缩放 = True Then
                Panel1.Visible = False
                Dim y As Integer, x As Integer, q As Integer, newx As Integer, newy As Integer
                Try
                    If CType(r.高, Double) / r.宽 > CType(Height, Double) / Width Then
                        Panel1.Size = New Size(Height * r.宽 / r.高, Height)
                        y = 0
                        x = (Width - Panel1.Width) / 2
                    Else
                        Panel1.Size = New Size(Width, Width * r.高 / r.宽)
                        x = 0
                        y = (Height - Panel1.Height) / 2
                    End If
                Catch e As Exception
                End Try
                q = Math.Floor(Panel1.Width / CType(r.宽, Single))
                newx = q * r.宽
                newy = q * r.高
                x += (Panel1.Size.Width - newx) / 2
                y += (Panel1.Size.Height - newy) / 2
                Panel1.Size = New Size(newx, newy)
                Panel1.Location = New Point(x, y)
                Dim newsize As New Size(q, q)

                For i As Integer = 1 To u
                    pb(i).Size = newsize
                Next

            Else
                Dim newsize As Size = 设置.flag.Size
                Panel1.Size = New Size(newsize.Width * r.宽, newsize.Height * r.高)
                Panel1.Location = New Point((Me.Width - Panel1.Width) / 2, (Me.Height - Panel1.Height) / 2)
                For i As Integer = 1 To u
                    pb(i).Size = newsize
                Next
            End If
            Panel1.Visible = True
            Panel1.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub 核心面板_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If 已启用 Then 调整Panel()
    End Sub

    ''图像控制区域''''''''''''''''''''''''''''''''''
    Public Sub 刷新全部图像()
        For i As Byte = 1 To r.高
            For j As Byte = 1 To r.宽
                刷新指定位置图像(i, j)
            Next
        Next
    End Sub
    Public Sub 刷新指定位置图像(ByVal x As Byte, ByVal y As Byte)
        If r(x, y).可见 = False Then
            If r(x, y).旗子 Then
                Me(x, y).Image = 设置.flag
            Else
                Me(x, y).Image = 设置.invisible
            End If
        Else
            If r(x, y).雷 Then
                Me(x, y).Image = 设置.mine
            Else
                Me(x, y).Image = 设置.num(r(x, y).数目)
            End If
        End If
    End Sub
    Public Sub 刷新高光位置图像(x As Byte, y As Byte)
        If r(x, y).可见 = False Then
            If r(x, y).旗子 Then
                Me(x, y).Image = 设置.flag_h
            Else
                Me(x, y).Image = 设置.invisible_h
            End If
        Else
            If r(x, y).雷 Then
                Me(x, y).Image = 设置.mine_h
            Else
                Me(x, y).Image = 设置.num_h(r(x, y).数目)
            End If
        End If
    End Sub
    Public Function 获取进度() As Double
        Dim valid As Short = 0
        For i As Byte = 1 To r.高
            For j As Byte = 1 To r.宽
                If r(i, j).可见 Or r(i, j).旗子 Then valid += 1
            Next
        Next
        Return CType(valid, Double) / CType(r.宽, Double) / CType(r.高, Double)
    End Function
End Class
