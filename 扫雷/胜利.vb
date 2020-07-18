Public Class 胜利
    Dim t As 状态枚举 = 状态枚举.失败
    Dim ra As New Random
    Dim winstr() As String = {"　　我们不能一有成绩,就象皮球一样,别人拍不得,轻轻一拍,就跳得老高.成绩越大,越要谦虚谨慎"}
    Dim failstr() As String = {"　　每一次失败，都是成功的伏笔；每一次考验，都有一份收获；每一次泪水，都有一次醒悟；每一次磨难，都有生命的财富。每一次伤痛，都是成长的支柱。每一次打击，都是坚强的后盾；活着必定要经历一些挫折，而我们依然坚强战胜每一次挫折，只要我们还活着，就值得庆幸。", "　　很多时候，人生就是在绝望与希望间徘徊，每一个活着的正常人，都会给自己一个目标，且不管这目标是高尚还是低俗。人们沿路走去，有阳光，也会有阴霾。", "　　人们通常不愿意承认自己的错误，总爱为自己辩解，但同时又不能容忍他人的过失，一旦有人做了错事，旁观者就立刻上去责备，而不能用一种平常心来处事；有了一颗平常心，我们就不会感到走投无路，就能够随机应变，灵活处事。就像流水遇到顽石，并不会为之苦恼，而是很自然地绕避而下。", "　　生命并非孤单，接受自己的能力和视野有限，需要和别人交流经验，交换能量，丰富自己和别人的生命。生命是互动的，一个人的生命有一份激情、一份快乐，两个人的生命，可以交换激情，分享快乐和痛苦，路，可以越走越远，越走越好。", "　　宁可自信，也不要盲目悲观。因为自信是一种力量，即使你的自信有些盲目，也无关大局，你可以在实践中调整心态，找到自己的恰当的位置。如果盲目自卑，你就必然失去一切。", "　　人生在世如身处荆棘之中，心不动，人不妄动，不动则不伤；如心动则人妄动，伤其身痛其骨，于是体会到世间诸般痛苦。我们日复一日地写下自身的命运，因为我们的所为，毫不留情地决定我们的命运。我相信这就是人生的最高逻辑和法则。"}
    Public Sub SetImage(value As 状态枚举, score As Integer, time As Long)
        t = value
        lbl得分.Text = score & "分"
        lbl用时.Text = (time \ 60) & "分" & (time Mod 60) & "秒"
    End Sub

    Private Sub 胜利_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl得分.Parent = img图片
        lbl用时.Parent = img图片
        lbl提示语.Parent = img图片
        If t = 状态枚举.胜利 Then
            img图片.Image = My.Resources.win
            lbl提示语.Text = winstr(ra.Next Mod winstr.Length)
        Else
            img图片.Image = My.Resources.fail
            lbl提示语.Text = failstr(ra.Next Mod failstr.Length)
        End If
    End Sub


    Private Sub img图片_Move(sender As Object, e As EventArgs) Handles img图片.Move

    End Sub

    Private Sub btn退出游戏_Click(sender As Object, e As EventArgs) Handles btn退出游戏.Click
        Me.DialogResult = DialogResult.No
    End Sub

    Private Sub btn关闭_Click(sender As Object, e As EventArgs) Handles btn关闭.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btn新游戏_Click(sender As Object, e As EventArgs) Handles btn新游戏.Click
        Me.DialogResult = DialogResult.Yes
    End Sub
End Class