Public Class 面板方块
    Public 雷 As Boolean
    Public 旗子 As Boolean
    Private Num As Byte
    Public 可见 As Boolean
    Public Sub New()
        雷 = False
        旗子 = False
        数目 = 0
        可见 = False
    End Sub

    Public Property 数目 As Byte
        Set(value As Byte)
            If value > 8 Then
                MessageBox.Show("雷数数据不合法!")
            Else
                Num = value
            End If
        End Set
        Get
            Return Num
        End Get
    End Property
    Public Function 面板方块转字符串() As String
        Return CType(雷, Integer) & "a" & CType(旗子, Integer) & "a" & Num & "a" & CType(可见, Integer)
    End Function
    Public Sub 字符串转面板方块(value As String)

        Dim ae() As Char = {"a"c}
        Dim str() As String = value.Split(ae, StringSplitOptions.RemoveEmptyEntries)
        雷 = CType(str(0), Integer)
        旗子 = CType(str(1), Integer)
        数目 = CType(str(2), Integer)
        可见 = CType(str(3), Integer)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
