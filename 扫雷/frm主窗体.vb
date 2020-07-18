'Imports CorePanel
Imports System.ComponentModel

Public Class frm主窗体

    Private Sub 刷新工具栏显示()
        If Not 设置.当前.显示时间标签 And Not 设置.当前.显示剩余雷数 And Not 设置.当前.显示分数 Then
            工具栏.Visible = False
        Else
            雷数图片.Visible = 设置.当前.显示剩余雷数
            雷数标签.Visible = 设置.当前.显示剩余雷数
            分数图像.Visible = 设置.当前.显示分数
            分数标签.Visible = 设置.当前.显示分数
            时间图像.Visible = 设置.当前.显示时间标签
            时间标签.Visible = 设置.当前.显示时间标签
            工具栏.Visible = True
        End If
        进度条面板.Visible = 设置.当前.显示游戏进度
    End Sub
    Private Sub 退出游戏前()
        If 设置.表.获取对象 IsNot Nothing Then
            暂停ToolStripMenuItem_Click(Nothing, Nothing)
            设置.保存设置到文件()
        End If
    End Sub


    '''''''''''''''''''''''''''''所有菜单'''''''''''''''''''''''''''''''' 
    Private Sub 选项OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选项OToolStripMenuItem.Click
        frm选项.ShowDialog()
    End Sub

    Public Sub 新游戏NToolStripMenuItem_Click(sender As Object， e As EventArgs) Handles 新游戏NToolStripMenuItem.Click
        If 设置.当前.显示新建游戏 = True Then
            Select Case frm新建游戏.ShowDialog()
                Case DialogResult.Retry '点击默认设置
                    GoTo Start
                Case DialogResult.Abort '点击上一次的设置
                    GoTo Start
                Case DialogResult.OK
                    GoTo Start
                Case DialogResult.Cancel '取消游戏
                    Return
            End Select
        ElseIf Not 设置.当前.使用上一次的设置 Then
            设置.当前.上一次的宽度 = 设置.当前.设置的宽度
            设置.当前.上一次的高度 = 设置.当前.设置的高度
            设置.当前.上一次的等级 = 设置.当前.设置的等级
            设置.当前.上一次的雷数 = 设置.当前.设置的雷数
        End If
Start:
        设置.新建游戏(设置.当前.上一次的宽度, 设置.当前.上一次的高度, 设置.当前.上一次的雷数, 设置.当前.上一次的等级)
        时间计时器.Enabled = True
        Toggle()
    End Sub
    Private Sub 统计TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 统计TToolStripMenuItem.Click

        统计.ShowDialog()
    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click

        退出游戏前()
        Me.Close()
    End Sub

    Private Sub 已用时间ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 已用时间ToolStripMenuItem.Click
        设置.当前.显示时间标签 = 已用时间ToolStripMenuItem.Checked
        刷新工具栏显示()
    End Sub

    Private Sub 剩余雷数ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剩余雷数ToolStripMenuItem.Click
        设置.当前.显示剩余雷数 = 剩余雷数ToolStripMenuItem.Checked
        刷新工具栏显示()
    End Sub

    Private Sub 得分ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 得分ToolStripMenuItem.Click
        设置.当前.显示分数 = 得分ToolStripMenuItem.Checked
        刷新工具栏显示()
    End Sub

    Private Sub 游戏进度ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 游戏进度ToolStripMenuItem.Click
        设置.当前.显示游戏进度 = 游戏进度ToolStripMenuItem.Checked
        刷新工具栏显示()
    End Sub
    Private Sub 关于扫雷AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于扫雷AToolStripMenuItem.Click
        关于.ShowDialog()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''窗体事件'''''''''''''''''''''''''''''''''''
    Private Sub frm主窗体_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        退出游戏前()
    End Sub
    Private Sub frm主窗体_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim t As New 游戏记录表
        t.读取存档()

        Toggle()

        If Not My.Computer.FileSystem.DirectoryExists("save") Then My.Computer.FileSystem.CreateDirectory("save")
        If Not My.Computer.FileSystem.DirectoryExists("image") Then My.Computer.FileSystem.CreateDirectory("image")

        '载入设置
        设置.从文件读取数据()

        '读取菜单显示选项
        已用时间ToolStripMenuItem.Checked = 设置.当前.显示时间标签
        剩余雷数ToolStripMenuItem.Checked = 设置.当前.显示剩余雷数
        游戏进度ToolStripMenuItem.Checked = 设置.当前.显示游戏进度
        得分ToolStripMenuItem.Checked = 设置.当前.显示分数

        '读取工具栏显示状况
        刷新工具栏显示()

        '载入图像
        设置.载入图像()
    End Sub
    Public Sub Toggle()
        If 设置.表.有效 Then
            If 设置.表.获取对象.状态 = 状态枚举.正在进行 Then
                暂停ToolStripMenuItem.Visible = True
                暂停ToolStripMenuItem.Enabled = True
                暂停ToolStripMenuItem.Text = "暂停(&P)"
                保存ToolStripMenuItem.Enabled = True
            ElseIf 设置.表.获取对象.状态 = 状态枚举.已暂停 Then
                暂停ToolStripMenuItem.Visible = True
                暂停ToolStripMenuItem.Enabled = True
                暂停ToolStripMenuItem.Text = "继续(&P)"
                保存ToolStripMenuItem.Enabled = True
            Else
                保存ToolStripMenuItem.Enabled = False
                暂停ToolStripMenuItem.Visible = False
                暂停ToolStripMenuItem.Enabled = False
            End If
        Else
            暂停ToolStripMenuItem.Visible = False
            暂停ToolStripMenuItem.Enabled = False
            保存ToolStripMenuItem.Enabled = False
        End If
    End Sub
    Public Sub 暂停ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 暂停ToolStripMenuItem.Click
        If 暂停ToolStripMenuItem.Tag = 0 Then
            时间计时器.Enabled = False
            设置.表.获取对象.游戏暂停()
            暂停ToolStripMenuItem.Tag = 1
        ElseIf 暂停ToolStripMenuItem.Tag = 1 Then
            暂停ToolStripMenuItem.Tag = 0
            时间计时器.Enabled = True
            设置.表.获取对象.游戏恢复()
        End If
        Toggle()
    End Sub

    Private Sub 时间计时器_Tick(sender As Object, e As EventArgs) Handles 时间计时器.Tick
        时间标签.Text = 设置.表.获取对象.get已用时间()
        雷数标签.Text = 设置.表.获取对象.剩余雷数
        分数标签.Text = 设置.表.获取对象.得分
        ProgressBar1.Value = 核心面板1.获取进度 * 100
    End Sub



    Private Sub 保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存ToolStripMenuItem.Click
        暂停ToolStripMenuItem_Click(sender, e)
        设置.保存游戏()
        暂停ToolStripMenuItem_Click(sender, e)
        Dim t2 As New 游戏记录表
        t2.读取存档()
    End Sub

    Private Sub 缩放模式ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 缩放模式ToolStripMenuItem.Click
        设置.缩放 = Not 设置.缩放
        缩放模式ToolStripMenuItem.Checked = 设置.缩放
        设置.保存设置到文件()
        If 核心面板1.已启用_ Then
            核心面板1.调整Panel()
            核心面板1.刷新全部图像()
        End If
    End Sub







    'Public Property title() As String
    '    Set(value As String)
    '        等待.ShowDialog()
    '        Me.Text = value
    '    End Set
    '    Get
    '        Return Me.Text
    '    End Get
    'End Property
End Class
