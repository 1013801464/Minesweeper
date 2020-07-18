<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 统计
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.内容右键菜单 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnk清空 = New System.Windows.Forms.LinkLabel()
        Me.lnk清空失败记录 = New System.Windows.Forms.LinkLabel()
        Me.lnk清空选定内容 = New System.Windows.Forms.LinkLabel()
        Me.btn退出 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.hd开始时间 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hd难度 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hd用时 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hd胜利 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.右边的面板 = New 扫雷.核心面板()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl详细信息 = New System.Windows.Forms.Label()
        Me.内容右键菜单.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '内容右键菜单
        '
        Me.内容右键菜单.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除ToolStripMenuItem})
        Me.内容右键菜单.Name = "内容右键菜单"
        Me.内容右键菜单.Size = New System.Drawing.Size(101, 26)
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btn退出)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 60)
        Me.Panel1.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lnk清空)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnk清空失败记录)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnk清空选定内容)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 8, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(516, 60)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'lnk清空
        '
        Me.lnk清空.AutoSize = True
        Me.lnk清空.LinkColor = System.Drawing.Color.Khaki
        Me.lnk清空.Location = New System.Drawing.Point(8, 8)
        Me.lnk清空.Name = "lnk清空"
        Me.lnk清空.Size = New System.Drawing.Size(32, 17)
        Me.lnk清空.TabIndex = 0
        Me.lnk清空.TabStop = True
        Me.lnk清空.Text = "清空"
        '
        'lnk清空失败记录
        '
        Me.lnk清空失败记录.AutoSize = True
        Me.lnk清空失败记录.LinkColor = System.Drawing.Color.Khaki
        Me.lnk清空失败记录.Location = New System.Drawing.Point(46, 8)
        Me.lnk清空失败记录.Name = "lnk清空失败记录"
        Me.lnk清空失败记录.Size = New System.Drawing.Size(80, 17)
        Me.lnk清空失败记录.TabIndex = 1
        Me.lnk清空失败记录.TabStop = True
        Me.lnk清空失败记录.Text = "清空失败记录"
        '
        'lnk清空选定内容
        '
        Me.lnk清空选定内容.AutoSize = True
        Me.lnk清空选定内容.LinkColor = System.Drawing.Color.Khaki
        Me.lnk清空选定内容.Location = New System.Drawing.Point(132, 8)
        Me.lnk清空选定内容.Name = "lnk清空选定内容"
        Me.lnk清空选定内容.Size = New System.Drawing.Size(80, 17)
        Me.lnk清空选定内容.TabIndex = 2
        Me.lnk清空选定内容.TabStop = True
        Me.lnk清空选定内容.Text = "清空选定项目"
        '
        'btn退出
        '
        Me.btn退出.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn退出.BackColor = System.Drawing.Color.Transparent
        Me.btn退出.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn退出.ForeColor = System.Drawing.Color.Blue
        Me.btn退出.Location = New System.Drawing.Point(530, 17)
        Me.btn退出.Name = "btn退出"
        Me.btn退出.Size = New System.Drawing.Size(82, 31)
        Me.btn退出.TabIndex = 1
        Me.btn退出.Text = "关闭"
        Me.btn退出.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hd开始时间, Me.hd难度, Me.hd用时, Me.hd胜利})
        Me.ListView1.ContextMenuStrip = Me.内容右键菜单
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(387, 304)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'hd开始时间
        '
        Me.hd开始时间.Text = "开始时间"
        Me.hd开始时间.Width = 128
        '
        'hd难度
        '
        Me.hd难度.Text = "难度"
        Me.hd难度.Width = 125
        '
        'hd用时
        '
        Me.hd用时.Text = "用时"
        '
        'hd胜利
        '
        Me.hd胜利.Text = "胜利"
        Me.hd胜利.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.hd胜利.Width = 50
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.右边的面板)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(387, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 304)
        Me.Panel2.TabIndex = 10
        '
        '右边的面板
        '
        Me.右边的面板.AutoSize = True
        Me.右边的面板.BackColor = System.Drawing.Color.Black
        Me.右边的面板.Dock = System.Windows.Forms.DockStyle.Fill
        Me.右边的面板.Location = New System.Drawing.Point(0, 26)
        Me.右边的面板.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.右边的面板.Name = "右边的面板"
        Me.右边的面板.Size = New System.Drawing.Size(237, 278)
        Me.右边的面板.TabIndex = 12
        Me.右边的面板.Visible = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.Yellow
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl详细信息)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(237, 26)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(193, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 20)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SHOW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl详细信息
        '
        Me.lbl详细信息.AutoSize = True
        Me.lbl详细信息.BackColor = System.Drawing.Color.Transparent
        Me.lbl详细信息.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl详细信息.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl详细信息.Location = New System.Drawing.Point(187, 0)
        Me.lbl详细信息.Name = "lbl详细信息"
        Me.lbl详细信息.Size = New System.Drawing.Size(0, 21)
        Me.lbl详细信息.TabIndex = 1
        '
        '统计
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(640, 200)
        Me.Name = "统计"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "统计"
        Me.内容右键菜单.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 内容右键菜单 As ContextMenuStrip
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lnk清空 As LinkLabel
    Friend WithEvents lnk清空失败记录 As LinkLabel
    Friend WithEvents lnk清空选定内容 As LinkLabel
    Friend WithEvents btn退出 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents hd开始时间 As ColumnHeader
    Friend WithEvents hd难度 As ColumnHeader
    Friend WithEvents hd用时 As ColumnHeader
    Friend WithEvents hd胜利 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents 右边的面板 As 核心面板
    Friend WithEvents lbl详细信息 As Label
End Class
