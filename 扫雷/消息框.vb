Public Class 消息框
    Public Message As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles 图形.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub 图形_MouseEnter(sender As Object, e As EventArgs) Handles 图形.MouseEnter
        图形.BackColor = Color.LightSalmon
    End Sub

    Private Sub 图形_MouseLeave(sender As Object, e As EventArgs) Handles 图形.MouseLeave
        图形.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub 消息框_Load(sender As Object, e As EventArgs) Handles Me.Load
        标签.Text = Message
    End Sub


End Class