Public Class frm选项
    Private rb难度(4) As RadioButton
    Private 初始化了 As Boolean
    Private 主动修改自定义 As Boolean = True
    Private Sub frm选项_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        初始化了 = False
        设置.备份 = 设置.当前
        rb难度(1) = rb初级
        rb难度(2) = rb中级
        rb难度(3) = rb高级
        rb难度(4) = rb自定义
        rb难度(设置.备份.设置的等级).Checked = True
        刷新显示难度区域()
        刷新显示设置区域()
        初始化了 = True
    End Sub
    Private Sub rb初级_CheckedChanged(sender As Object, e As EventArgs) Handles rb初级.CheckedChanged
        If rb初级.Checked Then
            设置.备份.设置的等级 = Level.初级
            设置.备份.设置的宽度 = 9
            设置.备份.设置的高度 = 9
            设置.备份.设置的雷数 = 10
            刷新显示难度区域()
        End If
    End Sub
    Private Sub 刷新显示难度区域()
        初始化了 = False
        If 设置.备份.设置的等级 = Level.初级 Then
            txt宽度.Text = 9
            txt高度.Text = 9
            txt雷数.Text = 10
        ElseIf 设置.备份.设置的等级 = Level.中级 Then
            txt宽度.Text = 16
            txt高度.Text = 16
            txt雷数.Text = 40
        ElseIf 设置.备份.设置的等级 = Level.高级 Then
            txt宽度.Text = 30
            txt高度.Text = 16
            txt雷数.Text = 99
        ElseIf 设置.备份.设置的等级 = Level.自定义 Then
            txt宽度.Text = 设置.备份.设置的宽度
            txt高度.Text = 设置.备份.设置的高度
            txt雷数.Text = 设置.备份.设置的雷数
        End If
        初始化了 = True
    End Sub
    Private Sub 刷新显示设置区域()
        rb以上一次的设置开始.Checked = 设置.备份.使用上一次的设置
        rb以默认设置开始.Checked = Not 设置.备份.使用上一次的设置
        cb显示新建游戏.Checked = 设置.备份.显示新建游戏
        panel以什么设置开始.Enabled = Not 设置.备份.显示新建游戏
        cb使用自动扩展.Checked = 设置.备份.使用自动扩展
        cb使用自动标记.Checked = 设置.备份.使用自动标记
    End Sub

    Private Sub rb中级_CheckedChanged(sender As Object, e As EventArgs) Handles rb中级.CheckedChanged
        If rb中级.Checked Then
            设置.备份.设置的等级 = Level.中级
            设置.备份.设置的宽度 = 16
            设置.备份.设置的高度 = 16
            设置.备份.设置的雷数 = 40
            刷新显示难度区域()
        End If
    End Sub

    Private Sub rb高级_CheckedChanged(sender As Object, e As EventArgs) Handles rb高级.CheckedChanged
        If rb高级.Checked Then
            设置.备份.设置的等级 = Level.高级
            设置.备份.设置的宽度 = 30
            设置.备份.设置的高度 = 16
            设置.备份.设置的雷数 = 99
            刷新显示难度区域()
        End If
    End Sub

    Private Sub rb自定义_CheckedChanged(sender As Object, e As EventArgs) Handles rb自定义.CheckedChanged
        If rb自定义.Checked And 主动修改自定义 Then
            设置.备份.设置的等级 = Level.自定义
            设置.备份.设置的宽度 = 设置.备份.设置的自定义的宽度
            设置.备份.设置的高度 = 设置.备份.设置的自定义的高度
            设置.备份.设置的雷数 = 设置.备份.设置的自定义的雷数
            刷新显示难度区域()
        End If
    End Sub

    Private Sub txt宽度_LostFocus(sender As Object, e As EventArgs) Handles txt宽度.LostFocus
        Try
            设置.备份.设置的宽度 = txt宽度.Text
            If 设置.备份.设置的宽度 < 5 Or 设置.备份.设置的宽度 > 50 Then
                消息框.Message = "宽度的有效范围是 5～50。"
                消息框.ShowDialog()
                txt宽度.Focus()
                txt宽度.Text = 设置.备份.设置的自定义的宽度
                设置.备份.设置的宽度 = 设置.备份.设置的自定义的宽度
            Else
                设置.备份.设置的自定义的宽度 = 设置.备份.设置的宽度
            End If
        Catch ex As Exception
            'MessageBox.Show("无法转换成数字", "扫雷", MessageBoxButtons.OK, MessageBoxIcon.Error)
            消息框.Message = txt宽度.Text & " 无法转换成数字。"
            消息框.ShowDialog()
            txt宽度.Focus()
            txt宽度.Text = 设置.备份.设置的自定义的宽度
            设置.备份.设置的宽度 = 设置.备份.设置的自定义的宽度
        End Try

    End Sub

    Private Sub txt高度_LostFocus(sender As Object, e As EventArgs) Handles txt高度.LostFocus
        Try
            设置.备份.设置的高度 = CType(txt高度.Text, Byte)
            If 设置.备份.设置的高度 < 5 Or 设置.备份.设置的高度 > 30 Then

                消息框.Message = "高度的有效范围是 5～30。"
                消息框.ShowDialog()
                txt高度.Focus()
                txt高度.Text = 设置.备份.设置的自定义的高度
                设置.备份.设置的高度 = 设置.备份.设置的自定义的高度
            Else
                设置.备份.设置的自定义的高度 = 设置.备份.设置的高度
            End If
        Catch ex As Exception
            'MessageBox.Show("无法转换成数字", "扫雷", MessageBoxButtons.OK, MessageBoxIcon.Error)
            消息框.Message = txt高度.Text & " 无法转换成数字。"
            消息框.ShowDialog()
            txt高度.Focus()
            txt高度.Text = 设置.备份.设置的自定义的高度
            设置.备份.设置的高度 = 设置.备份.设置的自定义的高度
        End Try

    End Sub

    Private Sub txt雷数_LostFocus(sender As Object, e As EventArgs) Handles txt雷数.LostFocus
        Try
            设置.备份.设置的雷数 = CType(txt雷数.Text, Short)
            Dim res As Single = 设置.备份.设置的雷数 / 设置.备份.设置的宽度 / 设置.备份.设置的高度
            If res < 0.05 Or res > 0.95 Then
                'MessageBox.Show("雷数的有效范围是 1%-90%", "扫雷", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                消息框.Message = "雷数的有效范围是 5%～95%。"
                消息框.ShowDialog()
                txt雷数.Focus()
                txt雷数.Text = 设置.备份.设置的自定义的雷数
                设置.备份.设置的雷数 = 设置.备份.设置的自定义的雷数
            Else
                设置.备份.设置的自定义的雷数 = 设置.备份.设置的雷数
            End If
        Catch ex As Exception
            'MessageBox.Show("无法转换成数字", "扫雷", MessageBoxButtons.OK, MessageBoxIcon.Error)
            消息框.Message = txt雷数.Text & " 无法转换成数字。"
            消息框.ShowDialog()
            txt雷数.Focus()
            txt雷数.Text = 设置.备份.设置的自定义的雷数
            设置.备份.设置的雷数 = 设置.备份.设置的自定义的雷数
        End Try
    End Sub

    Private Sub btn保存_Click(sender As Object, e As EventArgs) Handles btn保存.Click
        设置.当前 = 设置.备份
        设置.保存设置到文件()
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub cb显示新建游戏_CheckedChanged(sender As Object, e As EventArgs) Handles cb显示新建游戏.CheckedChanged
        设置.备份.显示新建游戏 = cb显示新建游戏.Checked
        刷新显示设置区域()
    End Sub

    Private Sub rb以上一次的设置开始_CheckedChanged(sender As Object, e As EventArgs) Handles rb以上一次的设置开始.CheckedChanged
        设置.备份.使用上一次的设置 = rb以上一次的设置开始.Checked
        刷新显示设置区域()
    End Sub

    Private Sub rb以默认设置开始_CheckedChanged(sender As Object, e As EventArgs) Handles rb以默认设置开始.CheckedChanged
        设置.备份.使用上一次的设置 = rb以上一次的设置开始.Checked
        刷新显示设置区域()
    End Sub
    Private Sub cb使用自动扩展_CheckedChanged(sender As Object, e As EventArgs) Handles cb使用自动扩展.CheckedChanged
        设置.备份.使用自动扩展 = cb使用自动扩展.Checked
        刷新显示设置区域()
    End Sub
    Private Sub cb使用自动标记_CheckedChanged(sender As Object, e As EventArgs) Handles cb使用自动标记.CheckedChanged
        设置.备份.使用自动标记 = cb使用自动标记.Checked
        刷新显示难度区域()
    End Sub
    Private Sub txt宽度_TextChanged(sender As Object, e As EventArgs) Handles txt宽度.TextChanged
        If rb自定义.Checked = False And 初始化了 Then

            主动修改自定义 = False
            设置.备份.设置的自定义的雷数 = 设置.备份.设置的雷数
            设置.备份.设置的自定义的高度 = 设置.备份.设置的高度
            设置.备份.设置的等级 = Level.自定义
            rb难度(4).Checked = True
            txt高度.Text = 设置.备份.设置的自定义的高度
            txt雷数.Text = 设置.备份.设置的自定义的雷数
            主动修改自定义 = True
        End If
    End Sub
    Private Sub txt高度_TextChanged(sender As Object, e As EventArgs) Handles txt高度.TextChanged
        If rb自定义.Checked = False And 初始化了 Then
            主动修改自定义 = False
            设置.备份.设置的自定义的宽度 = 设置.备份.设置的宽度
            设置.备份.设置的自定义的雷数 = 设置.备份.设置的雷数
            设置.备份.设置的等级 = Level.自定义
            rb难度(4).Checked = True
            txt宽度.Text = 设置.备份.设置的自定义的宽度
            txt雷数.Text = 设置.备份.设置的自定义的雷数
            主动修改自定义 = True
        End If
    End Sub

    Private Sub txt雷数_TextChanged(sender As Object, e As EventArgs) Handles txt雷数.TextChanged
        If rb自定义.Checked = False And 初始化了 Then
            主动修改自定义 = False
            设置.备份.设置的自定义的宽度 = 设置.备份.设置的宽度
            设置.备份.设置的自定义的高度 = 设置.备份.设置的高度
            设置.备份.设置的等级 = Level.自定义
            rb难度(4).Checked = True
            txt宽度.Text = 设置.备份.设置的自定义的宽度
            txt高度.Text = 设置.备份.设置的自定义的高度
            主动修改自定义 = True
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        设置.当前 = 设置.备份
        设置.保存设置到文件()
    End Sub


End Class