Public Class 统计
    Dim Table As New 游戏记录表
    Dim ms As Integer = 0
    Private Sub btn退出_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 内容右键菜单_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles 内容右键菜单.Opening

    End Sub

    Private Sub 统计_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        Table.读取对象到ListView()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ms = ListView1.SelectedItems.Count
        If ms = 1 Then
            Dim str As String = ListView1.SelectedItems.Item(0).SubItems(4).ToString.Substring(18).TrimEnd("}")
            Table.读取存档并建立对象("save\" & str, str)
            lbl详细信息.Text = Table.获取对象.得分 & "分, 难度" & CType((Table.获取对象.雷数 / Table.获取对象.获取面板.高 / Table.获取对象.获取面板.宽 * 484.85), Integer).ToString
            If 右边的面板.Visible = True Then
                右边的面板.设定面板(Table.获取对象.获取面板, False)
                右边的面板.启动_用于ListView查看()
            End If

        End If
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        lnk清空选定内容_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If 右边的面板.Visible Then
            Button1.Text = "SHOW"
            右边的面板.Visible = False
            Me.MinimumSize = New Size(360, 200)
        Else
            Button1.Text = "HIDE"
            右边的面板.Visible = True
            Me.MinimumSize = New Size(640, 200)
        End If
    End Sub

    Private Sub lnk清空_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk清空.LinkClicked
        游戏记录表.清空记录()
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub lnk清空失败记录_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk清空失败记录.LinkClicked
        Dim str2 = String.Empty
        Dim st = String.Empty
        For Each mr As ListViewItem In ListView1.Items
            st = mr.SubItems(3).ToString.Substring(18).TrimEnd("}")

            If st = "失败" Then
                str2 = mr.SubItems(4).ToString.Substring(18).TrimEnd("}")
                Table.删除记录(str2)
            End If
        Next
        ListView1.Items.Clear()
        Table.读取对象到ListView()
    End Sub

    Private Sub lnk清空选定内容_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk清空选定内容.LinkClicked
        Dim str2 = String.Empty
        For Each mr As ListViewItem In ListView1.SelectedItems
            str2 = mr.SubItems(4).ToString.Substring(18).TrimEnd("}")
            Table.删除记录(str2)
        Next
        ListView1.Items.Clear()
        Table.读取对象到ListView()
    End Sub

    Private Sub lnk清空分数低于x的记录_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 
        Dim str2 = String.Empty
        Dim st = String.Empty
        For Each mr As ListViewItem In ListView1.Items
            st = mr.SubItems(3).ToString.Substring(18).TrimEnd("}")
            If st = "失败" Then
                str2 = mr.SubItems(4).ToString.Substring(18).TrimEnd("}")
                Table.删除记录(str2)
            End If
        Next
        ListView1.Items.Clear()
        Table.读取对象到ListView()
    End Sub

    Private Sub 查看详细信息ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class