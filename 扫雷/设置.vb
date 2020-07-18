Imports System.IO

Public Class 设置
    Public Shared 当前 As Settings
    Public Shared 备份 As Settings
    Public Shared 缩放 As Boolean
    Public Shared Sub 保存设置到文件()
        Dim str As String = "0.9;"
        Dim SW As New StreamWriter("setting.mper")
        str &= 当前.设置的等级 & ";"
        str &= 当前.设置的宽度 & ";"
        str &= 当前.设置的高度 & ";"
        str &= 当前.设置的雷数 & ";"
        str &= 当前.上一次的宽度 & ";"
        str &= 当前.上一次的高度 & ";"
        str &= 当前.上一次的雷数 & ";"
        str &= 当前.上一次的等级 & ";"
        str &= 当前.设置的自定义的宽度 & ";"
        str &= 当前.设置的自定义的高度 & ";"
        str &= 当前.设置的自定义的雷数 & ";"
        str &= CType(当前.显示新建游戏, Integer) & ";"
        str &= CType(当前.使用上一次的设置, Integer) & ";"
        str &= CType(当前.使用自动扩展, Integer) & ";"
        str &= CType(当前.使用自动标记, Integer) & ";"
        str &= CType(当前.存在上一次的记录, Integer) & ";"
        str &= CType(当前.显示时间标签, Integer) & ";"
        str &= CType(当前.显示剩余雷数, Integer) & ";"
        str &= CType(当前.显示游戏进度, Integer) & ";"
        str &= CType(当前.显示分数, Integer) & ";"
        str &= ImageFolder & ";"
        str &= CType(缩放, Integer) & ";"
        SW.Write(str)
        SW.Close()
    End Sub
    Public Shared Sub 从文件读取数据()
        Dim a() As String
        Try
            a = My.Computer.FileSystem.ReadAllText("setting.mper").Split(";"c)
            当前.设置的等级 = a(1)
            当前.设置的宽度 = a(2)
            当前.设置的高度 = a(3)
            当前.设置的雷数 = a(4)
            当前.上一次的宽度 = a(5)
            当前.上一次的高度 = a(6)
            当前.上一次的雷数 = a(7)
            当前.上一次的等级 = a(8)
            当前.设置的自定义的宽度 = a(9)
            当前.设置的自定义的高度 = a(10)
            当前.设置的自定义的雷数 = a(11)
            当前.显示新建游戏 = a(12)
            当前.使用上一次的设置 = a(13)
            当前.使用自动扩展 = a(14)
            当前.使用自动标记 = a(15)
            当前.存在上一次的记录 = a(16)
            当前.显示时间标签 = a(17)
            当前.显示剩余雷数 = a(18)
            当前.显示游戏进度 = a(19)
            当前.显示分数 = a(20)
            ImageFolder = a(21)
            缩放 = a(22)
        Catch ex As Exception
            当前.设置的等级 = Level.初级
            当前.设置的宽度 = 9
            当前.设置的高度 = 9
            当前.设置的雷数 = 10
            当前.上一次的等级 = Level.初级
            当前.上一次的宽度 = 9
            当前.上一次的高度 = 9
            当前.上一次的雷数 = 10
            当前.设置的自定义的宽度 = 15
            当前.设置的自定义的高度 = 15
            当前.设置的自定义的雷数 = 40
            当前.显示新建游戏 = True
            当前.使用上一次的设置 = True
            当前.使用自动扩展 = True
            当前.使用自动标记 = True
            当前.存在上一次的记录 = False
            当前.显示剩余雷数 = False
            当前.显示时间标签 = True
            当前.显示游戏进度 = True
            ImageFolder = "image\默认"
            缩放 = True
        End Try
        For Each folder As String In My.Computer.FileSystem.GetDirectories("image")
            Dim t As New 菜单项_颜色
            Dim str() As String = folder.Split("\")
            t.Text = str(str.Length - 1)
            t.文件夹 = str(str.Length - 2) & "\" & str(str.Length - 1)
            frm主窗体.主题ToolStripMenuItem.DropDownItems.Add(t)
            Dim str2() = ImageFolder.Split("\")
            If str(str.Length - 1) = str2(str2.Length - 1) Then
                t.Checked = True
            End If
        Next
        frm主窗体.缩放模式ToolStripMenuItem.Checked = 设置.缩放
    End Sub

    '以下是和游戏内容相关的数据和方法
    Public Shared 表 As New 游戏记录表
    Public Shared Sub 新建游戏(宽 As Byte, 高 As Byte, 雷 As Short, 等级 As Level)
        表.Add(宽, 高, 雷, 等级)
        frm主窗体.核心面板1.设定面板(设置.表.获取对象.获取面板, True)
        frm主窗体.核心面板1.启动()
        frm主窗体.核心面板1.初始化游戏()
    End Sub
    Public Shared Sub 保存游戏()
        表.添加对象到list并存档()
    End Sub



    ''图像资源'''''''''''''''''''''''''''''''''''''
    Public Shared num(8) As Bitmap      '数字+空白资源 num(0)作为空白
    Public Shared mine As Bitmap
    Public Shared flag As Bitmap
    Public Shared num_h(8) As Bitmap    '高亮
    Public Shared mine_h As Bitmap
    Public Shared flag_h As Bitmap
    Public Shared invisible As Bitmap
    Public Shared invisible_h As Bitmap
    Public Shared ImageFolder As String = ""

    Public Shared Sub 载入图像()
        Try
            For ix As Integer = 0 To 8
                num(ix) = New Bitmap(ImageFolder & "\num(" & ix & ").png")
                num_h(ix) = New Bitmap(ImageFolder & "\num_h(" & ix & ").png")
            Next
            mine = New Bitmap(ImageFolder & "\mine.png")
            mine_h = New Bitmap(ImageFolder & "\mine_h.png")
            flag = New Bitmap(ImageFolder & "\flag.png")
            flag_h = New Bitmap(ImageFolder & "\flag_h.png")
            invisible = New Bitmap(ImageFolder & "\invisible.png")
            invisible_h = New Bitmap(ImageFolder & "\invisible_h.png")
        Catch e As Exception
            MessageBox.Show("不能成功打开所有文件.")
        End Try
    End Sub
End Class
Class 菜单项_颜色
    Inherits ToolStripMenuItem
    Dim folder As String
    Private Sub 菜单项_颜色_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Checked = False Then
            设置.ImageFolder = folder
            设置.载入图像()
            设置.保存设置到文件()
            For Each c As ToolStripMenuItem In frm主窗体.主题ToolStripMenuItem.DropDownItems
                c.Checked = False
            Next
            Checked = True
            If frm主窗体.核心面板1.已启用_ Then
                frm主窗体.核心面板1.刷新全部图像()
                frm主窗体.核心面板1.调整Panel()
            End If
        End If
    End Sub
    Public WriteOnly Property 文件夹 As String
        Set(value As String)
            folder = value
        End Set
    End Property
End Class
