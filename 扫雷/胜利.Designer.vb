<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 胜利
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
        Me.img图片 = New System.Windows.Forms.PictureBox()
        Me.btn退出游戏 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn关闭 = New System.Windows.Forms.Button()
        Me.btn新游戏 = New System.Windows.Forms.Button()
        Me.lbl提示语 = New System.Windows.Forms.Label()
        Me.lbl得分 = New System.Windows.Forms.Label()
        Me.lbl用时 = New System.Windows.Forms.Label()
        CType(Me.img图片, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img图片
        '
        Me.img图片.Image = Global.扫雷.My.Resources.Resources.win
        Me.img图片.Location = New System.Drawing.Point(0, 0)
        Me.img图片.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.img图片.Name = "img图片"
        Me.img图片.Size = New System.Drawing.Size(600, 480)
        Me.img图片.TabIndex = 0
        Me.img图片.TabStop = False
        '
        'btn退出游戏
        '
        Me.btn退出游戏.BackColor = System.Drawing.Color.White
        Me.btn退出游戏.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn退出游戏.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn退出游戏.ForeColor = System.Drawing.Color.MediumBlue
        Me.btn退出游戏.Location = New System.Drawing.Point(260, 414)
        Me.btn退出游戏.Name = "btn退出游戏"
        Me.btn退出游戏.Size = New System.Drawing.Size(86, 35)
        Me.btn退出游戏.TabIndex = 1
        Me.btn退出游戏.Text = "退出游戏"
        Me.btn退出游戏.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 680)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.White
        Me.btn关闭.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn关闭.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn关闭.ForeColor = System.Drawing.Color.Indigo
        Me.btn关闭.Location = New System.Drawing.Point(373, 414)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(86, 35)
        Me.btn关闭.TabIndex = 1
        Me.btn关闭.Text = "关闭"
        Me.btn关闭.UseVisualStyleBackColor = False
        '
        'btn新游戏
        '
        Me.btn新游戏.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn新游戏.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn新游戏.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn新游戏.ForeColor = System.Drawing.Color.Honeydew
        Me.btn新游戏.Location = New System.Drawing.Point(486, 414)
        Me.btn新游戏.Name = "btn新游戏"
        Me.btn新游戏.Size = New System.Drawing.Size(86, 35)
        Me.btn新游戏.TabIndex = 1
        Me.btn新游戏.Text = "新游戏"
        Me.btn新游戏.UseVisualStyleBackColor = False
        '
        'lbl提示语
        '
        Me.lbl提示语.BackColor = System.Drawing.Color.Transparent
        Me.lbl提示语.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl提示语.ForeColor = System.Drawing.Color.White
        Me.lbl提示语.Location = New System.Drawing.Point(57, 100)
        Me.lbl提示语.Name = "lbl提示语"
        Me.lbl提示语.Size = New System.Drawing.Size(495, 201)
        Me.lbl提示语.TabIndex = 2
        Me.lbl提示语.UseCompatibleTextRendering = True
        '
        'lbl得分
        '
        Me.lbl得分.AutoSize = True
        Me.lbl得分.BackColor = System.Drawing.Color.Transparent
        Me.lbl得分.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl得分.Location = New System.Drawing.Point(67, 412)
        Me.lbl得分.Name = "lbl得分"
        Me.lbl得分.Size = New System.Drawing.Size(40, 22)
        Me.lbl得分.TabIndex = 3
        Me.lbl得分.Text = "356"
        '
        'lbl用时
        '
        Me.lbl用时.AutoSize = True
        Me.lbl用时.BackColor = System.Drawing.Color.Transparent
        Me.lbl用时.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl用时.Location = New System.Drawing.Point(67, 433)
        Me.lbl用时.Name = "lbl用时"
        Me.lbl用时.Size = New System.Drawing.Size(72, 22)
        Me.lbl用时.TabIndex = 4
        Me.lbl用时.Text = "2分18秒"
        '
        '胜利
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 480)
        Me.Controls.Add(Me.lbl用时)
        Me.Controls.Add(Me.lbl得分)
        Me.Controls.Add(Me.lbl提示语)
        Me.Controls.Add(Me.btn新游戏)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn退出游戏)
        Me.Controls.Add(Me.img图片)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "胜利"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "胜利"
        CType(Me.img图片, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img图片 As PictureBox
    Friend WithEvents btn退出游戏 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn关闭 As Button
    Friend WithEvents btn新游戏 As Button
    Friend WithEvents lbl提示语 As Label
    Friend WithEvents lbl得分 As Label
    Friend WithEvents lbl用时 As Label
End Class
