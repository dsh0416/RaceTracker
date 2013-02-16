
Public Class main
    Public maploc As String = ""
    Public mapsloc As String = ""
    Public time As Integer = 0
    Public Mapname As String = ""
    Public MapIns As String = ""
    Public start1X As Integer = 0
    Public start1Y As Integer = 0
    Public start2X As Integer = 0
    Public start2Y As Integer = 0
    Public CP1X As Integer = 0
    Public CP1Y As Integer = 0
    Public CP2X As Integer = 0
    Public CP2Y As Integer = 0
    Public RX As Integer = 0
    Public RY As Integer = 0
    Public CP As Boolean = False
    Public Walk As Integer = 0
    Public bmp As Bitmap
    Public cbmp As Bitmap
    Public DColor As Color
    Public Speed As Double = 0
    Public TSpeed As Double = 0
    ' 初始化数据




    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MapLoader.ShowDialog()
            Dim temp() As Char = MapLoader.FileName
            For i = 0 To temp.Length - 4
                maploc += temp(i)
            Next
            maploc += "bmp"
            mapsloc = MapLoader.FileName
            Dim r As IO.StreamReader
            r = New IO.StreamReader(mapsloc, System.Text.Encoding.GetEncoding("GB2312"))
            Mapname = r.ReadLine
            MapIns = r.ReadLine
            start1X = r.ReadLine
            start1Y = r.ReadLine
            start2X = r.ReadLine
            start2Y = r.ReadLine
            CP1X = r.ReadLine
            CP1Y = r.ReadLine
            CP2X = r.ReadLine
            CP2Y = r.ReadLine
            r.Close()

            MapT.Text = "地图名称: " & Mapname
            Timer1.Enabled = True
            Position.Location = New Point((start1X + start2X) / 2 - 10, (start1Y + start2Y) / 2 - 10)
            Key7.Location = New Point((start1X + start2X) / 2 - 30, (start1Y + start2Y) / 2 - 30)
            Key8.Location = New Point((start1X + start2X) / 2 - 10, (start1Y + start2Y) / 2 - 30)
            Key9.Location = New Point((start1X + start2X) / 2 + 10, (start1Y + start2Y) / 2 - 30)
            Key4.Location = New Point((start1X + start2X) / 2 - 30, (start1Y + start2Y) / 2 - 10)
            Key5.Location = New Point((start1X + start2X) / 2 - 10, (start1Y + start2Y) / 2 - 10)
            Key6.Location = New Point((start1X + start2X) / 2 + 10, (start1Y + start2Y) / 2 - 10)
            Key1.Location = New Point((start1X + start2X) / 2 - 30, (start1Y + start2Y) / 2 + 10)
            Key2.Location = New Point((start1X + start2X) / 2 - 10, (start1Y + start2Y) / 2 + 10)
            Key3.Location = New Point((start1X + start2X) / 2 + 10, (start1Y + start2Y) / 2 + 10)


            SpeedLabel.Text = "赛车速度" & Int(Speed * 100) / 100 & "像素/每步"
            bmp = Bitmap.FromFile(maploc)
            cbmp = Bitmap.FromFile(maploc)
            DColor = bmp.GetPixel(1, 1)
            '初始化定义

            For i = 0 To 9
                For j = 0 To 9
                    bmp.SetPixel(Position.Location.X + i + 5, Position.Location.Y + j + 5, Color.Green)
                    PictureBox1.Image = bmp
                Next
            Next
        Catch Ex As Exception
            LoadForm.Close()
            Me.Close()
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time += 1
        TimeLabel.Text = "游戏时间：" & time & "秒"
        '计时器
    End Sub

    Private Sub Key5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key5.Click

        Dim Go As Point = Key5.Location
        If Key5.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)

    End Sub

    Private Sub Key7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key7.Click

        Dim Go As Point = Key7.Location
        If Key7.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)

    End Sub

    Private Sub Key8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key8.Click

        Dim Go As Point = Key8.Location
        If Key8.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub Key9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key9.Click

        Dim Go As Point = Key9.Location
        If Key9.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub Key4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key4.Click

        Dim Go As Point = Key4.Location
        If Key4.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub Key6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key6.Click

        Dim Go As Point = Key6.Location
        If Key6.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub Key1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key1.Click

        Dim Go As Point = Key1.Location
        If Key1.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub Key2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key2.Click

        Dim Go As Point = Key2.Location
        If Key2.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub Key3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Key3.Click

        Dim Go As Point = Key3.Location
        If Key3.BackColor = Color.Red Then
            RX = 0
            RY = 0
        Else
            RX = Go.X - Position.Location.X
            RY = Go.Y - Position.Location.Y
        End If

        MoveAction(Go)
    End Sub

    Private Sub MoveAction(ByVal Go As Point)
        Walk += 1
        Speed = Math.Sqrt(Math.Abs(Go.X - Position.Location.X) ^ 2 + Math.Abs(Go.Y - Position.Location.Y) ^ 2)
        SpeedLabel.Text = "赛车速度：" & Int(Speed * 100) / 100 & "像素/每步"
        TSpeed += Speed
        '速度计算

        For i As Integer = -Math.Abs(Go.Y - Position.Location.Y) / 40 To Math.Abs(Go.Y - Position.Location.Y) / 40 Step 1
            For k As Double = 1 To 100 Step 0.01
                bmp.SetPixel((Go.X - Position.Location.X) / k + i + Position.Location.X + 10, (Go.Y - Position.Location.Y) / k + Position.Location.Y + 10, Color.Green)
                If Int((Go.X - Position.Location.X) / k + Position.Location.X) >= CP1X And Int((Go.X - Position.Location.X) / k + Position.Location.X) <= CP2X And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) >= CP1Y And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) <= CP2Y Then
                    CP = True
                End If
                If Int((Go.X - Position.Location.X) / k + Position.Location.X) >= start1X And Int((Go.X - Position.Location.X) / k + Position.Location.X) <= start2X And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) >= start1Y And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) <= start2Y And CP = True Then
                    Award.Show()
                    Me.Visible = False
                End If
            Next
        Next
        For i As Integer = -Math.Abs(Go.X - Position.Location.X) / 40 To Math.Abs(Go.X - Position.Location.X) / 40 Step 1
            For k As Double = 1 To 50 Step 0.005
                bmp.SetPixel((Go.X - Position.Location.X) / k + Position.Location.X + 10, (Go.Y - Position.Location.Y) / k + i + Position.Location.Y + 10, Color.Green)
                If Int((Go.X - Position.Location.X) / k + Position.Location.X) >= CP1X And Int((Go.X - Position.Location.X) / k + Position.Location.X) <= CP2X And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) >= CP1Y And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) <= CP2Y Then
                    CP = True
                End If
                If Int((Go.X - Position.Location.X) / k + Position.Location.X) >= start1X And Int((Go.X - Position.Location.X) / k + Position.Location.X) <= start2X And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) >= start1Y And Int((Go.Y - Position.Location.Y) / k + Position.Location.Y) <= start2Y And CP = True Then
                    Award.Show()
                    Me.Visible = False
                End If
            Next
        Next
        PictureBox1.Image = bmp
        '绘制经过线路

        Position.Location = Go
        Key5.Location = New Point(Go.X + RX, Go.Y + RY)
        Key7.Location = New Point(Go.X + RX - 20, Go.Y + RY - 20)
        Key8.Location = New Point(Go.X + RX, Go.Y + RY - 20)
        Key9.Location = New Point(Go.X + RX + 20, Go.Y + RY - 20)
        Key4.Location = New Point(Go.X + RX - 20, Go.Y + RY)
        Key6.Location = New Point(Go.X + RX + 20, Go.Y + RY)
        Key1.Location = New Point(Go.X + RX - 20, Go.Y + RY + 20)
        Key2.Location = New Point(Go.X + RX, Go.Y + RY + 20)
        Key3.Location = New Point(Go.X + RX + 20, Go.Y + RY + 20)
        '车辆移动和方向盘移动



        If Key1.Location.X > 0 And Key1.Location.X + 10 < PictureBox1.Width And Key1.Location.Y > 0 And Key1.Location.Y + 10 < PictureBox1.Height Then
            '是否超出地图范围判断
            If cbmp.GetPixel(Key1.Location.X + 10, Key1.Location.Y + 10) = DColor Then
                Key1.BackColor = Color.Red
            Else
                Key1.BackColor = Color.White
            End If
            '是否擦线判断
            Key1.Enabled = True
        Else
            Key1.Enabled = False
        End If

        If Key2.Location.X > 0 And Key2.Location.X + 10 < PictureBox1.Width And Key2.Location.Y > 0 And Key2.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key2.Location.X + 10, Key2.Location.Y + 10) = DColor Then
                Key2.BackColor = Color.Red
            Else
                Key2.BackColor = Color.White
            End If
            Key2.Enabled = True
        Else
            Key2.Enabled = False
        End If

        If Key3.Location.X > 0 And Key3.Location.X + 10 < PictureBox1.Width And Key3.Location.Y > 0 And Key3.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key3.Location.X + 10, Key3.Location.Y + 10) = DColor Then
                Key3.BackColor = Color.Red
            Else
                Key3.BackColor = Color.White
            End If
            Key3.Enabled = True
        Else
            Key3.Enabled = False
        End If

        If Key4.Location.X > 0 And Key4.Location.X + 10 < PictureBox1.Width And Key4.Location.Y > 0 And Key4.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key4.Location.X + 10, Key4.Location.Y + 10) = DColor Then
                Key4.BackColor = Color.Red
            Else
                Key4.BackColor = Color.White
            End If
            Key4.Enabled = True
        Else
            Key4.Enabled = False
        End If

        If Key5.Location.X > 0 And Key5.Location.X + 10 < PictureBox1.Width And Key5.Location.Y > 0 And Key5.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key5.Location.X + 10, Key5.Location.Y + 10) = DColor Then
                Key5.BackColor = Color.Red
            Else
                Key5.BackColor = Color.White
            End If
            Key5.Enabled = True
        Else
            Key5.Enabled = False
        End If

        If Key6.Location.X > 0 And Key6.Location.X + 10 < PictureBox1.Width And Key6.Location.Y > 0 And Key6.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key6.Location.X + 10, Key6.Location.Y + 10) = DColor Then
                Key6.BackColor = Color.Red
            Else
                Key6.BackColor = Color.White
            End If
            Key6.Enabled = True
        Else
            Key6.Enabled = False
        End If

        If Key7.Location.X > 0 And Key7.Location.X + 10 < PictureBox1.Width And Key7.Location.Y > 0 And Key7.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key7.Location.X + 10, Key7.Location.Y + 10) = DColor Then
                Key7.BackColor = Color.Red
            Else
                Key7.BackColor = Color.White
            End If
            Key7.Enabled = True
        Else
            Key7.Enabled = False
        End If

        If Key8.Location.X > 0 And Key8.Location.X + 10 < PictureBox1.Width And Key8.Location.Y > 0 And Key8.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key8.Location.X + 10, Key8.Location.Y + 10) = DColor Then
                Key8.BackColor = Color.Red
            Else
                Key8.BackColor = Color.White
            End If
            Key8.Enabled = True
        Else
            Key8.Enabled = False
        End If

        If Key9.Location.X > 0 And Key9.Location.X + 10 < PictureBox1.Width And Key9.Location.Y > 0 And Key9.Location.Y + 10 < PictureBox1.Height Then
            If cbmp.GetPixel(Key9.Location.X + 10, Key9.Location.Y + 10) = DColor Then
                Key9.BackColor = Color.Red
            Else
                Key9.BackColor = Color.White
            End If
            Key9.Enabled = True
        Else
            Key9.Enabled = False
        End If

        If Key1.Enabled = False And Key2.Enabled = False And Key3.Enabled = False And Key4.Enabled = False And Key5.Enabled = False And Key6.Enabled = False And Key7.Enabled = False And Key8.Enabled = False And Key9.Enabled = False Then
            MsgBox("你的赛车开出了场地")
            Position.Visible = False
            Walk = -1
            Award.Show()
            Me.Close()
        End If
        For i = 0 To 9
            For j = 0 To 9
                bmp.SetPixel(Position.Location.X + i + 5, Position.Location.Y + j + 5, Color.Green)
                PictureBox1.Image = bmp
            Next
        Next

    End Sub



End Class
