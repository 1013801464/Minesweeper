Public Class frm新建游戏
    Dim 宽度 As Byte
    Dim 高度 As Byte
    Dim 雷数 As Short
    Dim 等级 As Level


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb显示新建游戏.CheckedChanged
        设置.当前.显示新建游戏 = cb显示新建游戏.Checked
    End Sub

    Private Sub frm新建游戏_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb显示新建游戏.Checked = 设置.当前.显示新建游戏
        Me.AcceptButton = btn默认
        btn默认.SupplementalExplanation = 设置.当前.设置的等级.ToString & "(" & 设置.当前.设置的宽度 & "x" & 设置.当前.设置的高度 & "x" & 设置.当前.设置的雷数 & ")"
        If 设置.当前.存在上一次的记录 Then
            btn上一次.SupplementalExplanation = 设置.当前.上一次的等级.ToString & "(" & 设置.当前.上一次的宽度 & "x" & 设置.当前.上一次的高度 & "x" & 设置.当前.上一次的雷数 & ")"
            btn上一次.Enabled = True
        Else
            btn上一次.Enabled = False
            btn上一次.SupplementalExplanation = "没有上一次玩游戏的记录"
        End If
    End Sub

    Private Sub btn默认_Click(sender As Object, e As EventArgs)
        '提交数据

        '修改设置
        设置.当前.上一次的高度 = 设置.当前.设置的高度
        设置.当前.上一次的宽度 = 设置.当前.设置的宽度
        设置.当前.上一次的雷数 = 设置.当前.设置的雷数
        设置.当前.上一次的等级 = 设置.当前.设置的等级
        '最后关掉我
        设置.当前.存在上一次的记录 = True
        Close()
    End Sub

    Private Sub lnk取消_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk取消.LinkClicked
        '表明没有开始游戏
        '关闭窗体
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btn上一次_Click(sender As Object, e As EventArgs)
        '提交数据

        '修改设置
        '无需修改设置
        '最后关闭
        '一定存在上一次的记录,不谢修改了
        Close()
    End Sub
    '统一作为 "设置.当前.上一次的设置" 进行提交
    Private Sub btn开始自定义_Click(sender As Object, e As EventArgs) Handles btn开始自定义.Click
        Try
            宽度 = CType(txt宽度.Text, Integer)
            高度 = CType(txt高度.Text, Integer)
            雷数 = CType(txt雷数.Text, Integer)
            Dim 比率 As Single = 雷数 / 高度 / 宽度
            If 宽度 < 5 Or 宽度 > 50 Or 高度 < 5 Or 高度 > 30 Or 比率 > 0.95 Or 比率 < 0.05 Then
                消息框.Message = "请检查文本框，确保宽度在5～50之间" & ControlChars.CrLf & "高度在5～30之间，雷的比例在5%～95%之间"
                消息框.ShowDialog()
                Exit Sub
            End If
        Catch ex As Exception
            消息框.Message = "请确保输入的都是数字."
            消息框.ShowDialog()
            Exit Sub
        End Try
        设置.当前.上一次的宽度 = 宽度
        设置.当前.上一次的高度 = 高度
        设置.当前.上一次的等级 = 等级
        设置.当前.上一次的雷数 = 雷数
        设置.当前.存在上一次的记录 = True
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub lbl初级_Click(sender As Object, e As EventArgs) Handles lbl初级.Click
        '外观显示的变化
        txt宽度.Text = 9
        txt高度.Text = 9
        txt雷数.Text = 10

        '实际变量控制
        等级 = Level.初级
    End Sub

    Private Sub lbl中级_Click(sender As Object, e As EventArgs) Handles lbl中级.Click
        '外观显示的变化
        txt宽度.Text = 16
        txt雷数.Text = 40
        txt高度.Text = 16

        '实际变量控制
        等级 = Level.中级
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        '外观显示的变化
        txt宽度.Text = 30
        txt高度.Text = 16
        txt雷数.Text = 99

        '实际变量控制
        等级 = Level.高级
    End Sub

    Private Sub btn默认_Click_1(sender As Object, e As EventArgs) Handles btn默认.Click
        设置.当前.上一次的宽度 = 设置.当前.设置的宽度
        设置.当前.上一次的高度 = 设置.当前.设置的高度
        设置.当前.上一次的等级 = 设置.当前.设置的等级
        设置.当前.上一次的雷数 = 设置.当前.设置的雷数
        设置.当前.存在上一次的记录 = True
        Me.DialogResult = DialogResult.Retry
    End Sub

    Private Sub btn上一次_Click_1(sender As Object, e As EventArgs) Handles btn上一次.Click
        设置.当前.存在上一次的记录 = True
        Me.DialogResult = DialogResult.Abort
    End Sub

    Private Sub txt宽度_TextChanged(sender As Object, e As EventArgs) Handles txt宽度.TextChanged
        等级 = Level.自定义
    End Sub

    Private Sub txt高度_TextChanged(sender As Object, e As EventArgs) Handles txt高度.TextChanged
        等级 = Level.自定义
    End Sub

    Private Sub txt雷数_TextChanged(sender As Object, e As EventArgs) Handles txt雷数.TextChanged
        等级 = Level.自定义
    End Sub
End Class