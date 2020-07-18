Public Class 游戏记录表
    Private act As 游戏状态类
    Private FileName As String
    Public Sub Add(宽 As Byte, 高 As Byte, 雷 As Short, 等级 As Level)
        FileName = String.Empty
        act = New 游戏状态类(宽, 高, 雷, 等级)
    End Sub

    '获取对象
    Public ReadOnly Property 获取对象() As 游戏状态类
        Get
            Return act
        End Get
    End Property
    Public Function 有效() As Boolean
        Return act IsNot Nothing
    End Function
    Public Sub 添加对象到list并存档()
        If FileName.Equals(String.Empty) Then
            Dim x As New Random
            FileName = Now.Year & Now.Day & Now.Hour & Now.Second & x.Next.ToString
            追加记录_list(FileName)
        End If
        保存游戏记录到存档()
    End Sub

    '''''''''''''''''''''''''''''文件操作'''''''''''''''''''''
    Public Sub 读取存档()
        frm主窗体.读取进度OToolStripMenuItem.Enabled = False
        frm主窗体.读取进度OToolStripMenuItem.DropDownItems.Clear()

        If My.Computer.FileSystem.FileExists("save\list") Then
            Try
                Dim ae() As Char = {";"c}
                Dim str() As String = My.Computer.FileSystem.ReadAllText("save\list").Split(ae, StringSplitOptions.RemoveEmptyEntries)
                Dim e = str.Length - 1
                Do While e >= 0
                    读取存档并建立对象("save\" & str(e), str(e))
                    If act.状态 = 状态枚举.已暂停 Then
                        Dim m As New 菜单项用于最近的列表
                        frm主窗体.读取进度OToolStripMenuItem.Enabled = True
                        m.Text = "开始于" & act.get开始时间.ToShortDateString & " " & act.get开始时间.ToShortTimeString
                        m.SetFile(str(e))
                        frm主窗体.读取进度OToolStripMenuItem.DropDownItems.Add(m)
                    End If
                    e -= 1
                Loop
            Catch ex As Exception
                'My.Computer.FileSystem.DeleteFile("save\list")
            End Try
        Else
            My.Computer.FileSystem.WriteAllText("save\list", "", False)
        End If
    End Sub
    Public Sub 读取对象到ListView()
        '暂时不清空

        If My.Computer.FileSystem.FileExists("save\list") Then
            Try
                Dim ae() As Char = {";"c}
                Dim str() As String = My.Computer.FileSystem.ReadAllText("save\list").Split(ae, StringSplitOptions.RemoveEmptyEntries)
                Dim e = str.Length - 1
                Do While e >= 0
                    读取存档并建立对象("save\" & str(e), str(e))
                    Dim m As New ListViewItem
                    m.Text = act.get开始时间.ToString
                    m.SubItems.Add(act.get等级.ToString & "(" & act.获取面板.宽 & "x" & act.获取面板.高 & "x" & act.雷数 & ")")
                    m.SubItems.Add(act.get已用时间.ToString & "秒")
                    m.SubItems.Add(act.状态.ToString)
                    m.SubItems.Add(str(e))
                    统计.ListView1.Items.Add(m)
                    e -= 1
                Loop
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Shared Sub 清空记录()
        For Each file In My.Computer.FileSystem.GetFiles("save")
            My.Computer.FileSystem.DeleteFile(file)
        Next
    End Sub
    Public Sub 删除记录(value As String)
        Dim c() As Char = {";"c}
        Try
            My.Computer.FileSystem.DeleteFile("save\" & value)
        Catch ex As Exception
        End Try
        Dim str() As String = My.Computer.FileSystem.ReadAllText("save\list").Split(c, StringSplitOptions.RemoveEmptyEntries)
        My.Computer.FileSystem.WriteAllText("save\list", "", False)
        For Each s As String In str
            If s <> value Then 追加记录_list(s)
        Next
    End Sub
    Public Sub 追加记录_list(value As String)
        My.Computer.FileSystem.WriteAllText("save\list", value & ";", True)
    End Sub
    Public Sub 保存游戏记录到存档()
        If act IsNot Nothing Then
            My.Computer.FileSystem.WriteAllText("save\" & FileName, act.游戏状态类转字符串(), False)
        End If
    End Sub

    Public Sub 读取存档并建立对象(ByRef value As String, file As String)
        ' Try
        FileName = file
        Dim str = My.Computer.FileSystem.ReadAllText(value)
        If str <> String.Empty Then
            act = 游戏状态类.字符串转游戏状态类(str)
        Else
        End If
    End Sub
End Class
Class 菜单项用于最近的列表
    Inherits ToolStripMenuItem
    Private filename As String = ""
    Public Sub SetFile(文件名 As String)
        Me.filename = 文件名
    End Sub
    Private Sub 菜单项用于最近的列表_Click(sender As Object, e As EventArgs) Handles Me.Click
        If 设置.表.获取对象 IsNot Nothing Then
            If 设置.表.获取对象.状态 = 状态枚举.正在进行 Then
                If MessageBox.Show("确定要取消当前记录并读取旧的记录?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If
        设置.表.读取存档并建立对象("save\" & filename, filename)

        frm主窗体.核心面板1.从暂停状态恢复()
    End Sub
End Class
Class 列表项
    Inherits ListViewItem

    Private filename As String = String.Empty

    Public Sub New()
        Me.BeginEdit()
    End Sub

    Public Property file As String
        Get
            Return filename
        End Get
        Set(value As String)
            filename = value
        End Set
    End Property
End Class
