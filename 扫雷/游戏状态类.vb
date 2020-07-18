Imports System.Text

Public Enum Level As Byte
    初级 = 1
    中级 = 2
    高级 = 3
    自定义 = 4
End Enum
Public Enum 状态枚举 As Byte
    胜利 = 1
    失败 = 0
    正在进行 = 2
    尚未开始 = 3
    未完成 = 4
    已暂停 = 5
End Enum
Public Class 游戏状态类
    ''难度控制区域
    Private 等级 As Level
    Private 宽度 As Byte
    Private 高度 As Byte
    Public 雷数 As Short
    Public 剩余雷数 As Short
    Public 得分 As Short
    ''时间区域
    Private 游戏开始时间 As Date
    Private 游戏用时 As Long
    Private 暂停的时间 As Date

    ''游戏面板
    Private 游戏面板 As 面板

    ''游戏状态
    Public 状态 As 状态枚举
    Public ReadOnly Property 获取面板() As 面板
        Get
            Return 游戏面板
        End Get
    End Property
    Public Function get开始时间() As Date
        Return 游戏开始时间
    End Function
    Public Function get等级() As Level
        Return 等级
    End Function
    Public Sub New(宽度 As Byte, 高度 As Byte, 雷数 As Short, 等级 As Level)
        Me.宽度 = 宽度
        Me.高度 = 高度
        Me.雷数 = 雷数
        Me.等级 = 等级
        游戏面板 = New 面板(宽度, 高度)
        状态 = 状态枚举.尚未开始
    End Sub
    Public Sub 游戏开始()
        状态 = 状态枚举.正在进行
        游戏开始时间 = Now
        暂停的时间 = 游戏开始时间
        游戏用时 = 0
    End Sub
    Public Sub 游戏结束(ByRef 胜利了吗 As 状态枚举)
        状态 = 胜利了吗
        If 状态 = 状态枚举.失败 Then
            For i As Integer = 1 To 高度
                For j As Integer = 1 To 宽度
                    游戏面板(i, j).可见 = True
                Next
            Next
        End If
        游戏用时 += DateDiff(DateInterval.Second, 暂停的时间, Now)
    End Sub
    Public Sub 游戏暂停()
        游戏用时 += DateDiff(DateInterval.Second, 暂停的时间, Now)
        状态 = 状态枚举.已暂停
        暂停的时间 = Nothing
    End Sub
    Public Sub 游戏恢复()
        暂停的时间 = Now
        状态 = 状态枚举.正在进行
    End Sub
    Public Function get已用时间() As Long
        If 状态 = 状态枚举.正在进行 Then
            Return 游戏用时 + DateDiff(DateInterval.Second, 暂停的时间, Now)
        Else
            Return 游戏用时
        End If
    End Function
    Public Function 游戏状态类转字符串() As String
        Dim str As New StringBuilder
        str.Append(等级 & "," & 宽度 & "," & 高度 & "," & CType(状态, Integer) & "," & 雷数 & "," & 日期转字符串(游戏开始时间) & "," & CType(游戏用时, String) & "," & 日期转字符串(暂停的时间) & ",")
        str.Append(面板转字符串(游戏面板))
        str.Append("," & 剩余雷数 & "," & 得分)
        Return str.ToString
    End Function
    Public Shared Function 字符串转游戏状态类(value As String) As 游戏状态类
        Dim i As New 游戏状态类(5, 5, 5, Level.初级)
        Dim str() As String = value.Split(","c)
        i.等级 = CType(str(0), Integer)
        i.宽度 = CType(str(1), Byte)
        i.高度 = CType(str(2), Byte)
        i.状态 = CType(str(3), Byte)
        i.雷数 = CType(str(4), Short)
        i.游戏开始时间 = 字符串转日期(str(5))
        i.游戏用时 = CType(str(6), Long)
        i.暂停的时间 = 字符串转日期(str(7))
        i.游戏面板 = 字符串转面板(str(8), i.宽度, i.高度)
        i.剩余雷数 = CType(str(9), Integer)
        i.得分 = CType(str(10), Integer)
        Return i
    End Function
    Public Function 日期转字符串(ByRef d As Date) As String
        Return d.Year & "-" & d.Month & "-" & d.Day & "-" & d.Hour & "-" & d.Minute & "-" & d.Second
    End Function
    Public Shared Function 字符串转日期(value As String) As Date
        Dim str() As String = value.Split("-"c)
        Dim year As Integer = CType(str(0), Integer)
        Dim month As Integer = CType(str(1), Integer)
        Dim day As Integer = CType(str(2), Integer)
        Dim hour As Integer = CType(str(3), Integer)
        Dim minutes As Integer = CType(str(4), Integer)
        Dim seconds As Integer = CType(str(5), Integer)
        Return New Date(year, month, day, hour, minutes, day)
    End Function
    Public Function 面板转字符串(i As 面板) As String
        Dim sb As New StringBuilder(CType(i.可见, Integer).ToString)
        If i IsNot Nothing Then
            For x As Byte = 1 To i.高
                For y As Byte = 1 To i.宽
                    sb.Append("*" & i(x, y).面板方块转字符串)
                Next
            Next
        End If
        Return sb.ToString
    End Function
    Public Shared Function 字符串转面板(value As String, 宽度 As Byte, 高度 As Byte) As 面板
        Dim i As New 面板(宽度, 高度)
        Dim str() As String = value.Split("*"c)
        i.可见 = CType(str(0), Boolean)
        Dim t As Short = 0
        For x As Byte = 1 To i.高
            For y As Byte = 1 To i.宽
                t += 1
                i(x, y).字符串转面板方块(str(t))
            Next
        Next
        Return i
    End Function
End Class
