<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 消息框
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
        Me.图形 = New System.Windows.Forms.Label()
        Me.标签 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '图形
        '
        Me.图形.BackColor = System.Drawing.Color.WhiteSmoke
        Me.图形.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.图形.ForeColor = System.Drawing.Color.Black
        Me.图形.Location = New System.Drawing.Point(330, 0)
        Me.图形.Name = "图形"
        Me.图形.Size = New System.Drawing.Size(70, 70)
        Me.图形.TabIndex = 0
        Me.图形.Text = ""
        Me.图形.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.图形.UseMnemonic = False
        '
        '标签
        '
        Me.标签.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.标签.ForeColor = System.Drawing.Color.Black
        Me.标签.Location = New System.Drawing.Point(12, 9)
        Me.标签.Name = "标签"
        Me.标签.Size = New System.Drawing.Size(312, 52)
        Me.标签.TabIndex = 1
        Me.标签.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '消息框
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 70)
        Me.ControlBox = False
        Me.Controls.Add(Me.标签)
        Me.Controls.Add(Me.图形)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "消息框"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "消息框"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 图形 As Label
    Friend WithEvents 标签 As Label
End Class
