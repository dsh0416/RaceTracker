<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MapT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SpeedLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MapLoader = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Key7 = New System.Windows.Forms.Button()
        Me.Key8 = New System.Windows.Forms.Button()
        Me.Key9 = New System.Windows.Forms.Button()
        Me.Key1 = New System.Windows.Forms.Button()
        Me.Key2 = New System.Windows.Forms.Button()
        Me.Key3 = New System.Windows.Forms.Button()
        Me.Key6 = New System.Windows.Forms.Button()
        Me.Key4 = New System.Windows.Forms.Button()
        Me.Position = New System.Windows.Forms.Button()
        Me.Key5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 768)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MapT, Me.TimeLabel, Me.SpeedLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 788)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1026, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MapT
        '
        Me.MapT.Name = "MapT"
        Me.MapT.Size = New System.Drawing.Size(68, 17)
        Me.MapT.Text = "当前地图："
        '
        'TimeLabel
        '
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(68, 17)
        Me.TimeLabel.Text = "游戏时间："
        '
        'SpeedLabel
        '
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(68, 17)
        Me.SpeedLabel.Text = "赛车速度："
        '
        'MapLoader
        '
        Me.MapLoader.Filter = "纸上赛车地图文件|*.map|所有文件|*.*"
        Me.MapLoader.InitialDirectory = "\Map\"
        Me.MapLoader.Title = "请换取一张地图"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Key7
        '
        Me.Key7.BackColor = System.Drawing.Color.White
        Me.Key7.Location = New System.Drawing.Point(27, 12)
        Me.Key7.Name = "Key7"
        Me.Key7.Size = New System.Drawing.Size(20, 20)
        Me.Key7.TabIndex = 2
        Me.Key7.Text = "↖"
        Me.Key7.UseVisualStyleBackColor = False
        '
        'Key8
        '
        Me.Key8.BackColor = System.Drawing.Color.White
        Me.Key8.Location = New System.Drawing.Point(53, 12)
        Me.Key8.Name = "Key8"
        Me.Key8.Size = New System.Drawing.Size(20, 20)
        Me.Key8.TabIndex = 3
        Me.Key8.Text = "↑"
        Me.Key8.UseVisualStyleBackColor = False
        '
        'Key9
        '
        Me.Key9.BackColor = System.Drawing.Color.White
        Me.Key9.Location = New System.Drawing.Point(79, 12)
        Me.Key9.Name = "Key9"
        Me.Key9.Size = New System.Drawing.Size(20, 20)
        Me.Key9.TabIndex = 4
        Me.Key9.Text = "↗"
        Me.Key9.UseVisualStyleBackColor = False
        '
        'Key1
        '
        Me.Key1.BackColor = System.Drawing.Color.White
        Me.Key1.Location = New System.Drawing.Point(27, 64)
        Me.Key1.Name = "Key1"
        Me.Key1.Size = New System.Drawing.Size(20, 20)
        Me.Key1.TabIndex = 5
        Me.Key1.Text = "↙"
        Me.Key1.UseVisualStyleBackColor = False
        '
        'Key2
        '
        Me.Key2.BackColor = System.Drawing.Color.White
        Me.Key2.Location = New System.Drawing.Point(53, 64)
        Me.Key2.Name = "Key2"
        Me.Key2.Size = New System.Drawing.Size(20, 20)
        Me.Key2.TabIndex = 6
        Me.Key2.Text = "↓"
        Me.Key2.UseVisualStyleBackColor = False
        '
        'Key3
        '
        Me.Key3.BackColor = System.Drawing.Color.White
        Me.Key3.Location = New System.Drawing.Point(79, 64)
        Me.Key3.Name = "Key3"
        Me.Key3.Size = New System.Drawing.Size(20, 20)
        Me.Key3.TabIndex = 7
        Me.Key3.Text = "↘"
        Me.Key3.UseVisualStyleBackColor = False
        '
        'Key6
        '
        Me.Key6.BackColor = System.Drawing.Color.White
        Me.Key6.Location = New System.Drawing.Point(79, 38)
        Me.Key6.Name = "Key6"
        Me.Key6.Size = New System.Drawing.Size(20, 20)
        Me.Key6.TabIndex = 8
        Me.Key6.Text = "→"
        Me.Key6.UseVisualStyleBackColor = False
        '
        'Key4
        '
        Me.Key4.BackColor = System.Drawing.Color.White
        Me.Key4.Location = New System.Drawing.Point(27, 38)
        Me.Key4.Name = "Key4"
        Me.Key4.Size = New System.Drawing.Size(20, 20)
        Me.Key4.TabIndex = 9
        Me.Key4.Text = "←"
        Me.Key4.UseVisualStyleBackColor = False
        '
        'Position
        '
        Me.Position.BackColor = System.Drawing.Color.White
        Me.Position.Enabled = False
        Me.Position.Location = New System.Drawing.Point(53, 149)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(20, 20)
        Me.Position.TabIndex = 10
        Me.Position.Text = "M"
        Me.Position.UseVisualStyleBackColor = False
        '
        'Key5
        '
        Me.Key5.BackColor = System.Drawing.Color.White
        Me.Key5.Location = New System.Drawing.Point(52, 39)
        Me.Key5.Name = "Key5"
        Me.Key5.Size = New System.Drawing.Size(20, 20)
        Me.Key5.TabIndex = 11
        Me.Key5.Text = "○"
        Me.Key5.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 810)
        Me.Controls.Add(Me.Key5)
        Me.Controls.Add(Me.Position)
        Me.Controls.Add(Me.Key4)
        Me.Controls.Add(Me.Key6)
        Me.Controls.Add(Me.Key3)
        Me.Controls.Add(Me.Key2)
        Me.Controls.Add(Me.Key1)
        Me.Controls.Add(Me.Key9)
        Me.Controls.Add(Me.Key8)
        Me.Controls.Add(Me.Key7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "main"
        Me.Text = "像素赛车"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MapT As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimeLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MapLoader As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Key7 As System.Windows.Forms.Button
    Friend WithEvents Key8 As System.Windows.Forms.Button
    Friend WithEvents Key9 As System.Windows.Forms.Button
    Friend WithEvents Key1 As System.Windows.Forms.Button
    Friend WithEvents Key2 As System.Windows.Forms.Button
    Friend WithEvents Key3 As System.Windows.Forms.Button
    Friend WithEvents Key6 As System.Windows.Forms.Button
    Friend WithEvents Key4 As System.Windows.Forms.Button
    Friend WithEvents Position As System.Windows.Forms.Button
    Friend WithEvents Key5 As System.Windows.Forms.Button
    Friend WithEvents SpeedLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
