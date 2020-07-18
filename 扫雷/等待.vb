Public Class 等待
    Private Sub 等待_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.DialogResult = 1
    End Sub
End Class