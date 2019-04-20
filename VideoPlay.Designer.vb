<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoPlay))
        Me.VidPlaySrc_Explore = New System.Windows.Forms.Button()
        Me.VidPlay_Src = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VidPlay_Play = New System.Windows.Forms.Button()
        Me.VidPlay_Explore = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'VidPlaySrc_Explore
        '
        Me.VidPlaySrc_Explore.Location = New System.Drawing.Point(500, 27)
        Me.VidPlaySrc_Explore.Name = "VidPlaySrc_Explore"
        Me.VidPlaySrc_Explore.Size = New System.Drawing.Size(75, 23)
        Me.VidPlaySrc_Explore.TabIndex = 7
        Me.VidPlaySrc_Explore.Text = "浏览..."
        Me.VidPlaySrc_Explore.UseVisualStyleBackColor = True
        '
        'VidPlay_Src
        '
        Me.VidPlay_Src.Location = New System.Drawing.Point(105, 27)
        Me.VidPlay_Src.Name = "VidPlay_Src"
        Me.VidPlay_Src.Size = New System.Drawing.Size(389, 21)
        Me.VidPlay_Src.TabIndex = 6
        Me.VidPlay_Src.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "本地路径/URL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "F:全屏 Space:暂停 →:快进 ←:快退 s:逐帧播放 q:退出"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "常用直播地址/示例："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 117)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(569, 95)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "CCTV1高清：http://ivi.bupt.edu.cn/hls/cctv1hd.m3u8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CCTV3高清：http://ivi.bupt.edu.cn/h" &
    "ls/cctv3hd.m3u8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CCTV5+高清：http://ivi.bupt.edu.cn/hls/cctv5phd.m3u8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CCTV6高清：http" &
    "://ivi.bupt.edu.cn/hls/cctv6hd.m3u8"
        '
        'VidPlay_Play
        '
        Me.VidPlay_Play.Location = New System.Drawing.Point(500, 65)
        Me.VidPlay_Play.Name = "VidPlay_Play"
        Me.VidPlay_Play.Size = New System.Drawing.Size(75, 23)
        Me.VidPlay_Play.TabIndex = 11
        Me.VidPlay_Play.Text = "播放"
        Me.VidPlay_Play.UseVisualStyleBackColor = True
        '
        'VidPlay_Explore
        '
        Me.VidPlay_Explore.FileName = "OpenFileDialog1"
        Me.VidPlay_Explore.Filter = "所有文件|*.*"
        '
        'VideoPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 222)
        Me.Controls.Add(Me.VidPlay_Play)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VidPlaySrc_Explore)
        Me.Controls.Add(Me.VidPlay_Src)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "视频/直播播放"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VidPlaySrc_Explore As Button
    Friend WithEvents VidPlay_Src As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VidPlay_Play As Button
    Friend WithEvents VidPlay_Explore As OpenFileDialog
End Class
