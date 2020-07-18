Public Class PicBox
    Inherits PictureBox
    Public ReadOnly Y As Byte
    Public ReadOnly X As Byte
    Private ReadOnly cont As 核心面板

    Public Sub New(ByRef x As Byte, ByRef y As Byte, ByRef cont As 核心面板, ra As Boolean)
        Me.X = x
        Me.Y = y
        Me.cont = cont
        Me.Enabled = ra
    End Sub
    Private Sub PicBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = MouseButtons.Left Then
            frm主窗体.核心面板1.点击(X, Y, True)
        ElseIf e.Button = MouseButtons.Right Then
            frm主窗体.核心面板1.标记(X, Y, True)
        End If
    End Sub

    Private Sub PicBox_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        cont.刷新高光位置图像(X, Y)
    End Sub

    Private Sub PicBox_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        cont.刷新指定位置图像(X, Y)
    End Sub
End Class
