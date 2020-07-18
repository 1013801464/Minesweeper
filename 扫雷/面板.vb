Public Class 面板
    Private 方块数组() As 面板方块
    Public ReadOnly 宽 As Byte = 0
    Public ReadOnly 高 As Byte = 0
    Public 可见 As Boolean = True
    Public Sub New(width As Integer, height As Integer)
        ReDim 方块数组(width * height)
        Dim total As Short = width * height
        For i As Integer = 1 To total
            方块数组(i) = New 面板方块
        Next
        宽 = width
        高 = height
    End Sub
    Default Public ReadOnly Property Item(ByVal 行 As Integer, ByVal 列 As Integer)
        Get
            Try
                If 行 <= 高 And 行 > 0 And 列 <= 宽 And 列 > 0 Then
                    Return 方块数组((行 - 1) * 宽 + 列)
                Else
                    Return Nothing
                End If
            Catch e As Exception
                Return Nothing
            End Try
        End Get
    End Property
End Class
