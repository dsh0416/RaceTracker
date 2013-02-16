Public Class Award

    Private Sub Award_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If main.Walk = -1 Then
            Label1.Text = "你没有完赛"
        Else
            Label1.Text = "游戏时间：" & main.time & "秒，共计步数：" & main.Walk & "步，平均车速" & Int((main.TSpeed / main.Walk) * 100) / 100 & "像素/步"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main.Close()
        main.Show()
        Me.Close()
    End Sub
End Class