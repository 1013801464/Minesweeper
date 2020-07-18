<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm选项
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btn取消 = New System.Windows.Forms.Button()
        Me.btn保存 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt雷数 = New System.Windows.Forms.TextBox()
        Me.txt高度 = New System.Windows.Forms.TextBox()
        Me.txt宽度 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb自定义 = New System.Windows.Forms.RadioButton()
        Me.rb高级 = New System.Windows.Forms.RadioButton()
        Me.rb中级 = New System.Windows.Forms.RadioButton()
        Me.rb初级 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb使用自动标记 = New System.Windows.Forms.CheckBox()
        Me.cb使用自动扩展 = New System.Windows.Forms.CheckBox()
        Me.panel以什么设置开始 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rb以上一次的设置开始 = New System.Windows.Forms.RadioButton()
        Me.rb以默认设置开始 = New System.Windows.Forms.RadioButton()
        Me.cb显示新建游戏 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.panel以什么设置开始.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnApply)
        Me.Panel1.Controls.Add(Me.btn取消)
        Me.Panel1.Controls.Add(Me.btn保存)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 298)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 48)
        Me.Panel1.TabIndex = 2
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnApply.Location = New System.Drawing.Point(262, 8)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(80, 31)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "应用"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btn取消
        '
        Me.btn取消.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn取消.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn取消.Location = New System.Drawing.Point(174, 8)
        Me.btn取消.Name = "btn取消"
        Me.btn取消.Size = New System.Drawing.Size(80, 31)
        Me.btn取消.TabIndex = 3
        Me.btn取消.Text = "取消"
        Me.btn取消.UseVisualStyleBackColor = True
        '
        'btn保存
        '
        Me.btn保存.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn保存.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn保存.Location = New System.Drawing.Point(86, 8)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(80, 31)
        Me.btn保存.TabIndex = 2
        Me.btn保存.Text = "确定"
        Me.btn保存.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt雷数)
        Me.GroupBox1.Controls.Add(Me.txt高度)
        Me.GroupBox1.Controls.Add(Me.txt宽度)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rb自定义)
        Me.GroupBox1.Controls.Add(Me.rb高级)
        Me.GroupBox1.Controls.Add(Me.rb中级)
        Me.GroupBox1.Controls.Add(Me.rb初级)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 134)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "默认难度"
        '
        'txt雷数
        '
        Me.txt雷数.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt雷数.Location = New System.Drawing.Point(194, 75)
        Me.txt雷数.MaxLength = 4
        Me.txt雷数.Name = "txt雷数"
        Me.txt雷数.Size = New System.Drawing.Size(125, 23)
        Me.txt雷数.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt雷数, "雷的密度必须在1%到95%。")
        '
        'txt高度
        '
        Me.txt高度.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt高度.Location = New System.Drawing.Point(194, 48)
        Me.txt高度.MaxLength = 3
        Me.txt高度.Name = "txt高度"
        Me.txt高度.Size = New System.Drawing.Size(125, 23)
        Me.txt高度.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt高度, "宽度最小值为5,最大值为51。")
        '
        'txt宽度
        '
        Me.txt宽度.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt宽度.Location = New System.Drawing.Point(194, 21)
        Me.txt宽度.MaxLength = 3
        Me.txt宽度.Name = "txt宽度"
        Me.txt宽度.Size = New System.Drawing.Size(125, 23)
        Me.txt宽度.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt宽度, "高度最小值为5,最大值为30。")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(133, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "雷数(&N):"
        Me.ToolTip1.SetToolTip(Me.Label3, "雷的密度必须在1%到95%。")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(133, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "高度(&H):"
        Me.ToolTip1.SetToolTip(Me.Label2, "宽度最小值为5,最大值为51。")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(133, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "宽度(&W):"
        Me.ToolTip1.SetToolTip(Me.Label1, "高度最小值为5,最大值为30。")
        '
        'rb自定义
        '
        Me.rb自定义.AutoSize = True
        Me.rb自定义.ForeColor = System.Drawing.Color.Black
        Me.rb自定义.Location = New System.Drawing.Point(10, 103)
        Me.rb自定义.Name = "rb自定义"
        Me.rb自定义.Size = New System.Drawing.Size(77, 21)
        Me.rb自定义.TabIndex = 0
        Me.rb自定义.TabStop = True
        Me.rb自定义.Text = "自定义(&4)"
        Me.rb自定义.UseVisualStyleBackColor = True
        '
        'rb高级
        '
        Me.rb高级.AutoSize = True
        Me.rb高级.ForeColor = System.Drawing.Color.Black
        Me.rb高级.Location = New System.Drawing.Point(10, 76)
        Me.rb高级.Name = "rb高级"
        Me.rb高级.Size = New System.Drawing.Size(65, 21)
        Me.rb高级.TabIndex = 0
        Me.rb高级.TabStop = True
        Me.rb高级.Text = "高级(&3)"
        Me.rb高级.UseVisualStyleBackColor = True
        '
        'rb中级
        '
        Me.rb中级.AutoSize = True
        Me.rb中级.ForeColor = System.Drawing.Color.Black
        Me.rb中级.Location = New System.Drawing.Point(10, 49)
        Me.rb中级.Name = "rb中级"
        Me.rb中级.Size = New System.Drawing.Size(65, 21)
        Me.rb中级.TabIndex = 0
        Me.rb中级.TabStop = True
        Me.rb中级.Text = "中级(&2)"
        Me.rb中级.UseVisualStyleBackColor = True
        '
        'rb初级
        '
        Me.rb初级.AutoSize = True
        Me.rb初级.ForeColor = System.Drawing.Color.Black
        Me.rb初级.Location = New System.Drawing.Point(10, 22)
        Me.rb初级.Name = "rb初级"
        Me.rb初级.Size = New System.Drawing.Size(65, 21)
        Me.rb初级.TabIndex = 0
        Me.rb初级.TabStop = True
        Me.rb初级.Text = "初级(&1)"
        Me.rb初级.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cb使用自动标记)
        Me.GroupBox2.Controls.Add(Me.cb使用自动扩展)
        Me.GroupBox2.Controls.Add(Me.panel以什么设置开始)
        Me.GroupBox2.Controls.Add(Me.cb显示新建游戏)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 141)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "行为"
        '
        'cb使用自动标记
        '
        Me.cb使用自动标记.AutoSize = True
        Me.cb使用自动标记.ForeColor = System.Drawing.Color.Black
        Me.cb使用自动标记.Location = New System.Drawing.Point(10, 110)
        Me.cb使用自动标记.Name = "cb使用自动标记"
        Me.cb使用自动标记.Size = New System.Drawing.Size(99, 21)
        Me.cb使用自动标记.TabIndex = 2
        Me.cb使用自动标记.Text = "使用自动标记"
        Me.cb使用自动标记.UseVisualStyleBackColor = True
        '
        'cb使用自动扩展
        '
        Me.cb使用自动扩展.AutoSize = True
        Me.cb使用自动扩展.ForeColor = System.Drawing.Color.Black
        Me.cb使用自动扩展.Location = New System.Drawing.Point(10, 83)
        Me.cb使用自动扩展.Name = "cb使用自动扩展"
        Me.cb使用自动扩展.Size = New System.Drawing.Size(99, 21)
        Me.cb使用自动扩展.TabIndex = 2
        Me.cb使用自动扩展.Text = "使用自动扩展"
        Me.cb使用自动扩展.UseVisualStyleBackColor = True
        '
        'panel以什么设置开始
        '
        Me.panel以什么设置开始.Controls.Add(Me.rb以上一次的设置开始)
        Me.panel以什么设置开始.Controls.Add(Me.rb以默认设置开始)
        Me.panel以什么设置开始.Location = New System.Drawing.Point(8, 49)
        Me.panel以什么设置开始.Name = "panel以什么设置开始"
        Me.panel以什么设置开始.Size = New System.Drawing.Size(292, 28)
        Me.panel以什么设置开始.TabIndex = 1
        '
        'rb以上一次的设置开始
        '
        Me.rb以上一次的设置开始.AutoSize = True
        Me.rb以上一次的设置开始.ForeColor = System.Drawing.Color.Black
        Me.rb以上一次的设置开始.Location = New System.Drawing.Point(3, 3)
        Me.rb以上一次的设置开始.Name = "rb以上一次的设置开始"
        Me.rb以上一次的设置开始.Size = New System.Drawing.Size(134, 21)
        Me.rb以上一次的设置开始.TabIndex = 0
        Me.rb以上一次的设置开始.TabStop = True
        Me.rb以上一次的设置开始.Text = "以上一次的设置开始"
        Me.rb以上一次的设置开始.UseVisualStyleBackColor = True
        '
        'rb以默认设置开始
        '
        Me.rb以默认设置开始.AutoSize = True
        Me.rb以默认设置开始.ForeColor = System.Drawing.Color.Black
        Me.rb以默认设置开始.Location = New System.Drawing.Point(143, 3)
        Me.rb以默认设置开始.Name = "rb以默认设置开始"
        Me.rb以默认设置开始.Size = New System.Drawing.Size(110, 21)
        Me.rb以默认设置开始.TabIndex = 1
        Me.rb以默认设置开始.TabStop = True
        Me.rb以默认设置开始.Text = "以默认设置开始"
        Me.rb以默认设置开始.UseVisualStyleBackColor = True
        '
        'cb显示新建游戏
        '
        Me.cb显示新建游戏.AutoSize = True
        Me.cb显示新建游戏.ForeColor = System.Drawing.Color.Black
        Me.cb显示新建游戏.Location = New System.Drawing.Point(10, 22)
        Me.cb显示新建游戏.Name = "cb显示新建游戏"
        Me.cb显示新建游戏.Size = New System.Drawing.Size(169, 21)
        Me.cb显示新建游戏.TabIndex = 0
        Me.cb显示新建游戏.Text = "始终显示""新建游戏""对话框"
        Me.cb显示新建游戏.UseVisualStyleBackColor = True
        '
        'frm选项
        '
        Me.AcceptButton = Me.btn保存
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btn取消
        Me.ClientSize = New System.Drawing.Size(350, 346)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(264, 38)
        Me.Name = "frm选项"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "选项"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panel以什么设置开始.ResumeLayout(False)
        Me.panel以什么设置开始.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn取消 As Button
    Friend WithEvents btn保存 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt雷数 As TextBox
    Friend WithEvents txt高度 As TextBox
    Friend WithEvents txt宽度 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rb自定义 As RadioButton
    Friend WithEvents rb高级 As RadioButton
    Friend WithEvents rb中级 As RadioButton
    Friend WithEvents rb初级 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb显示新建游戏 As CheckBox
    Friend WithEvents panel以什么设置开始 As FlowLayoutPanel
    Friend WithEvents rb以上一次的设置开始 As RadioButton
    Friend WithEvents rb以默认设置开始 As RadioButton
    Friend WithEvents cb使用自动标记 As CheckBox
    Friend WithEvents cb使用自动扩展 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnApply As Button
End Class
