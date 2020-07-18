<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm新建游戏
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn开始自定义 = New CommandLink.CommandLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt雷数 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt高度 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt宽度 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lnk取消 = New System.Windows.Forms.LinkLabel()
        Me.cb显示新建游戏 = New System.Windows.Forms.CheckBox()
        Me.lbl初级 = New System.Windows.Forms.Label()
        Me.lbl中级 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn上一次 = New CommandLink.CommandLink()
        Me.btn默认 = New CommandLink.CommandLink()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn开始自定义
        '
        Me.btn开始自定义.BackColor = System.Drawing.Color.Transparent
        Me.btn开始自定义.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn开始自定义.Image = Nothing
        Me.btn开始自定义.Location = New System.Drawing.Point(219, 188)
        Me.btn开始自定义.Name = "btn开始自定义"
        Me.btn开始自定义.Size = New System.Drawing.Size(245, 45)
        Me.btn开始自定义.SupplementalExplanation = ""
        Me.btn开始自定义.TabIndex = 6
        Me.btn开始自定义.Text = "开始游戏"
        Me.btn开始自定义.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt雷数)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt高度)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt宽度)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(219, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 140)
        Me.Panel1.TabIndex = 5
        '
        'txt雷数
        '
        Me.txt雷数.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt雷数.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt雷数.Location = New System.Drawing.Point(53, 96)
        Me.txt雷数.Name = "txt雷数"
        Me.txt雷数.Size = New System.Drawing.Size(189, 36)
        Me.txt雷数.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "雷数:"
        '
        'txt高度
        '
        Me.txt高度.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt高度.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt高度.Location = New System.Drawing.Point(53, 50)
        Me.txt高度.Name = "txt高度"
        Me.txt高度.Size = New System.Drawing.Size(189, 36)
        Me.txt高度.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(5, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "高度:"
        '
        'txt宽度
        '
        Me.txt宽度.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt宽度.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt宽度.Location = New System.Drawing.Point(53, 4)
        Me.txt宽度.Name = "txt宽度"
        Me.txt宽度.Size = New System.Drawing.Size(189, 36)
        Me.txt宽度.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "宽度:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.lnk取消)
        Me.Panel2.Controls.Add(Me.cb显示新建游戏)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 25)
        Me.Panel2.TabIndex = 6
        '
        'lnk取消
        '
        Me.lnk取消.AutoSize = True
        Me.lnk取消.LinkColor = System.Drawing.Color.White
        Me.lnk取消.Location = New System.Drawing.Point(438, 5)
        Me.lnk取消.Name = "lnk取消"
        Me.lnk取消.Size = New System.Drawing.Size(32, 17)
        Me.lnk取消.TabIndex = 7
        Me.lnk取消.TabStop = True
        Me.lnk取消.Text = "取消"
        '
        'cb显示新建游戏
        '
        Me.cb显示新建游戏.AutoSize = True
        Me.cb显示新建游戏.BackColor = System.Drawing.Color.Transparent
        Me.cb显示新建游戏.Checked = True
        Me.cb显示新建游戏.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb显示新建游戏.ForeColor = System.Drawing.Color.White
        Me.cb显示新建游戏.Location = New System.Drawing.Point(12, 4)
        Me.cb显示新建游戏.Name = "cb显示新建游戏"
        Me.cb显示新建游戏.Size = New System.Drawing.Size(138, 21)
        Me.cb显示新建游戏.TabIndex = 11
        Me.cb显示新建游戏.Text = "始终显示本对话框(&S)"
        Me.cb显示新建游戏.UseVisualStyleBackColor = False
        '
        'lbl初级
        '
        Me.lbl初级.BackColor = System.Drawing.Color.DarkGreen
        Me.lbl初级.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl初级.ForeColor = System.Drawing.Color.White
        Me.lbl初级.Location = New System.Drawing.Point(218, 9)
        Me.lbl初级.Name = "lbl初级"
        Me.lbl初级.Size = New System.Drawing.Size(70, 29)
        Me.lbl初级.TabIndex = 8
        Me.lbl初级.Text = "初级"
        Me.lbl初级.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl中级
        '
        Me.lbl中级.BackColor = System.Drawing.Color.Gold
        Me.lbl中级.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl中级.ForeColor = System.Drawing.Color.White
        Me.lbl中级.Location = New System.Drawing.Point(303, 9)
        Me.lbl中级.Name = "lbl中级"
        Me.lbl中级.Size = New System.Drawing.Size(70, 29)
        Me.lbl中级.TabIndex = 9
        Me.lbl中级.Text = "中级"
        Me.lbl中级.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(388, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "高级"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.btn上一次)
        Me.Panel3.Controls.Add(Me.btn默认)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(212, 249)
        Me.Panel3.TabIndex = 8
        '
        'btn上一次
        '
        Me.btn上一次.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn上一次.Image = Nothing
        Me.btn上一次.Location = New System.Drawing.Point(3, 73)
        Me.btn上一次.Name = "btn上一次"
        Me.btn上一次.Size = New System.Drawing.Size(194, 60)
        Me.btn上一次.SupplementalExplanation = "读取宽度,高度和雷数 "
        Me.btn上一次.TabIndex = 2
        Me.btn上一次.Text = "上一次的设置"
        Me.btn上一次.UseVisualStyleBackColor = True
        '
        'btn默认
        '
        Me.btn默认.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn默认.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn默认.Image = Nothing
        Me.btn默认.Location = New System.Drawing.Point(3, 7)
        Me.btn默认.Name = "btn默认"
        Me.btn默认.Size = New System.Drawing.Size(194, 60)
        Me.btn默认.SupplementalExplanation = "读取宽度,高度和雷数 "
        Me.btn默认.TabIndex = 1
        Me.btn默认.Text = "默认设置"
        Me.btn默认.UseMnemonic = False
        Me.btn默认.UseVisualStyleBackColor = True
        '
        'frm新建游戏
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 274)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl中级)
        Me.Controls.Add(Me.lbl初级)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn开始自定义)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm新建游戏"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "新游戏"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn开始自定义 As CommandLink.CommandLink
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt雷数 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt高度 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt宽度 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cb显示新建游戏 As CheckBox
    Friend WithEvents lnk取消 As LinkLabel
    Friend WithEvents lbl初级 As Label
    Friend WithEvents lbl中级 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn上一次 As CommandLink.CommandLink
    Friend WithEvents btn默认 As CommandLink.CommandLink
End Class
