<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm主窗体
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm主窗体))
        Me.主菜单条 = New System.Windows.Forms.MenuStrip()
        Me.游戏GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新游戏NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.读取进度OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.统计TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.已用时间ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.剩余雷数ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.得分ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.游戏进度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.选项OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.缩放模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于扫雷AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.暂停ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具栏 = New System.Windows.Forms.ToolStrip()
        Me.雷数图片 = New System.Windows.Forms.ToolStripLabel()
        Me.雷数标签 = New System.Windows.Forms.ToolStripLabel()
        Me.时间图像 = New System.Windows.Forms.ToolStripLabel()
        Me.时间标签 = New System.Windows.Forms.ToolStripLabel()
        Me.分数图像 = New System.Windows.Forms.ToolStripLabel()
        Me.分数标签 = New System.Windows.Forms.ToolStripLabel()
        Me.进度条面板 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.时间计时器 = New System.Windows.Forms.Timer(Me.components)
        Me.核心面板1 = New 扫雷.核心面板()
        Me.主菜单条.SuspendLayout()
        Me.工具栏.SuspendLayout()
        Me.进度条面板.SuspendLayout()
        Me.SuspendLayout()
        '
        '主菜单条
        '
        Me.主菜单条.BackColor = System.Drawing.SystemColors.Control
        Me.主菜单条.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.游戏GToolStripMenuItem, Me.工具ToolStripMenuItem, Me.帮助HToolStripMenuItem, Me.暂停ToolStripMenuItem})
        Me.主菜单条.Location = New System.Drawing.Point(0, 0)
        Me.主菜单条.Name = "主菜单条"
        Me.主菜单条.Size = New System.Drawing.Size(536, 25)
        Me.主菜单条.TabIndex = 0
        '
        '游戏GToolStripMenuItem
        '
        Me.游戏GToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.游戏GToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新游戏NToolStripMenuItem, Me.读取进度OToolStripMenuItem, Me.保存ToolStripMenuItem, Me.ToolStripMenuItem2, Me.统计TToolStripMenuItem, Me.ToolStripMenuItem6, Me.退出XToolStripMenuItem})
        Me.游戏GToolStripMenuItem.Name = "游戏GToolStripMenuItem"
        Me.游戏GToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.游戏GToolStripMenuItem.Text = "文件(&F)"
        '
        '新游戏NToolStripMenuItem
        '
        Me.新游戏NToolStripMenuItem.Name = "新游戏NToolStripMenuItem"
        Me.新游戏NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新游戏NToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.新游戏NToolStripMenuItem.Text = "新游戏(&N)"
        '
        '读取进度OToolStripMenuItem
        '
        Me.读取进度OToolStripMenuItem.Name = "读取进度OToolStripMenuItem"
        Me.读取进度OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.读取进度OToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.读取进度OToolStripMenuItem.Text = "读取进度(&O)"
        '
        '保存ToolStripMenuItem
        '
        Me.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        Me.保存ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存ToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.保存ToolStripMenuItem.Text = "保存进度(&S)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(186, 6)
        '
        '统计TToolStripMenuItem
        '
        Me.统计TToolStripMenuItem.Name = "统计TToolStripMenuItem"
        Me.统计TToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.统计TToolStripMenuItem.Text = "统计信息(&T)"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(186, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '工具ToolStripMenuItem
        '
        Me.工具ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示ToolStripMenuItem, Me.主题ToolStripMenuItem, Me.ToolStripMenuItem4, Me.选项OToolStripMenuItem, Me.缩放模式ToolStripMenuItem})
        Me.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem"
        Me.工具ToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.工具ToolStripMenuItem.Text = "工具(&T)"
        '
        '显示ToolStripMenuItem
        '
        Me.显示ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.已用时间ToolStripMenuItem, Me.剩余雷数ToolStripMenuItem, Me.得分ToolStripMenuItem, Me.ToolStripMenuItem5, Me.游戏进度ToolStripMenuItem})
        Me.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem"
        Me.显示ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.显示ToolStripMenuItem.Text = "显示"
        '
        '已用时间ToolStripMenuItem
        '
        Me.已用时间ToolStripMenuItem.CheckOnClick = True
        Me.已用时间ToolStripMenuItem.Name = "已用时间ToolStripMenuItem"
        Me.已用时间ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.已用时间ToolStripMenuItem.Text = "已用时间"
        '
        '剩余雷数ToolStripMenuItem
        '
        Me.剩余雷数ToolStripMenuItem.CheckOnClick = True
        Me.剩余雷数ToolStripMenuItem.Name = "剩余雷数ToolStripMenuItem"
        Me.剩余雷数ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.剩余雷数ToolStripMenuItem.Text = "剩余雷数"
        '
        '得分ToolStripMenuItem
        '
        Me.得分ToolStripMenuItem.CheckOnClick = True
        Me.得分ToolStripMenuItem.Name = "得分ToolStripMenuItem"
        Me.得分ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.得分ToolStripMenuItem.Text = "得分"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(121, 6)
        '
        '游戏进度ToolStripMenuItem
        '
        Me.游戏进度ToolStripMenuItem.CheckOnClick = True
        Me.游戏进度ToolStripMenuItem.Name = "游戏进度ToolStripMenuItem"
        Me.游戏进度ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.游戏进度ToolStripMenuItem.Text = "游戏进度"
        '
        '主题ToolStripMenuItem
        '
        Me.主题ToolStripMenuItem.Name = "主题ToolStripMenuItem"
        Me.主题ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.主题ToolStripMenuItem.Text = "主题"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(154, 6)
        '
        '选项OToolStripMenuItem
        '
        Me.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem"
        Me.选项OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.选项OToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.选项OToolStripMenuItem.Text = "选项(&O)"
        '
        '缩放模式ToolStripMenuItem
        '
        Me.缩放模式ToolStripMenuItem.Name = "缩放模式ToolStripMenuItem"
        Me.缩放模式ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.缩放模式ToolStripMenuItem.Text = "缩放模式(&S)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.帮助HToolStripMenuItem1, Me.关于扫雷AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '帮助HToolStripMenuItem1
        '
        Me.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1"
        Me.帮助HToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.帮助HToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.帮助HToolStripMenuItem1.Text = "帮助(&H)"
        '
        '关于扫雷AToolStripMenuItem
        '
        Me.关于扫雷AToolStripMenuItem.Name = "关于扫雷AToolStripMenuItem"
        Me.关于扫雷AToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.关于扫雷AToolStripMenuItem.Text = "关于扫雷(&A)..."
        '
        '暂停ToolStripMenuItem
        '
        Me.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem"
        Me.暂停ToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.暂停ToolStripMenuItem.Tag = "0"
        Me.暂停ToolStripMenuItem.Text = "暂停(&P)"
        '
        '工具栏
        '
        Me.工具栏.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.工具栏.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.雷数图片, Me.雷数标签, Me.时间图像, Me.时间标签, Me.分数图像, Me.分数标签})
        Me.工具栏.Location = New System.Drawing.Point(0, 25)
        Me.工具栏.Name = "工具栏"
        Me.工具栏.Size = New System.Drawing.Size(536, 43)
        Me.工具栏.TabIndex = 1
        Me.工具栏.Text = "ToolStrip1"
        '
        '雷数图片
        '
        Me.雷数图片.AutoSize = False
        Me.雷数图片.Image = CType(resources.GetObject("雷数图片.Image"), System.Drawing.Image)
        Me.雷数图片.Name = "雷数图片"
        Me.雷数图片.Size = New System.Drawing.Size(40, 40)
        '
        '雷数标签
        '
        Me.雷数标签.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.雷数标签.Name = "雷数标签"
        Me.雷数标签.Size = New System.Drawing.Size(31, 40)
        Me.雷数标签.Text = "0"
        '
        '时间图像
        '
        Me.时间图像.AutoSize = False
        Me.时间图像.Image = CType(resources.GetObject("时间图像.Image"), System.Drawing.Image)
        Me.时间图像.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.时间图像.Name = "时间图像"
        Me.时间图像.Size = New System.Drawing.Size(40, 40)
        '
        '时间标签
        '
        Me.时间标签.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.时间标签.Name = "时间标签"
        Me.时间标签.Size = New System.Drawing.Size(31, 40)
        Me.时间标签.Text = "0"
        '
        '分数图像
        '
        Me.分数图像.AutoSize = False
        Me.分数图像.Image = CType(resources.GetObject("分数图像.Image"), System.Drawing.Image)
        Me.分数图像.Name = "分数图像"
        Me.分数图像.Size = New System.Drawing.Size(40, 40)
        '
        '分数标签
        '
        Me.分数标签.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.分数标签.Name = "分数标签"
        Me.分数标签.Size = New System.Drawing.Size(31, 40)
        Me.分数标签.Text = "0"
        '
        '进度条面板
        '
        Me.进度条面板.Controls.Add(Me.ProgressBar1)
        Me.进度条面板.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.进度条面板.Location = New System.Drawing.Point(0, 482)
        Me.进度条面板.Name = "进度条面板"
        Me.进度条面板.Size = New System.Drawing.Size(536, 24)
        Me.进度条面板.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.MediumOrchid
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DimGray
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(536, 24)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 0
        '
        '时间计时器
        '
        Me.时间计时器.Interval = 500
        '
        '核心面板1
        '
        Me.核心面板1.AutoSize = True
        Me.核心面板1.BackColor = System.Drawing.Color.Black
        Me.核心面板1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.核心面板1.Location = New System.Drawing.Point(0, 68)
        Me.核心面板1.Name = "核心面板1"
        Me.核心面板1.Size = New System.Drawing.Size(536, 414)
        Me.核心面板1.TabIndex = 3
        '
        'frm主窗体
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 506)
        Me.Controls.Add(Me.核心面板1)
        Me.Controls.Add(Me.进度条面板)
        Me.Controls.Add(Me.工具栏)
        Me.Controls.Add(Me.主菜单条)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.主菜单条
        Me.Name = "frm主窗体"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "扫雷"
        Me.主菜单条.ResumeLayout(False)
        Me.主菜单条.PerformLayout()
        Me.工具栏.ResumeLayout(False)
        Me.工具栏.PerformLayout()
        Me.进度条面板.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 主菜单条 As MenuStrip
    Friend WithEvents 游戏GToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新游戏NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 读取进度OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 统计TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents 工具ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 主题ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents 选项OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 关于扫雷AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 工具栏 As ToolStrip
    Friend WithEvents 时间图像 As ToolStripLabel
    Friend WithEvents 雷数图片 As ToolStripLabel
    Friend WithEvents 显示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 已用时间ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 剩余雷数ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 游戏进度ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 进度条面板 As Panel
    Friend WithEvents 得分ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents 时间标签 As ToolStripLabel
    Friend WithEvents 雷数标签 As ToolStripLabel
    Friend WithEvents 分数图像 As ToolStripLabel
    Friend WithEvents 分数标签 As ToolStripLabel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents 时间计时器 As Timer
    Friend WithEvents 核心面板1 As 核心面板
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents 暂停ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 缩放模式ToolStripMenuItem As ToolStripMenuItem
End Class
