<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.Main_Close = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Icon_Win = New System.Windows.Forms.PictureBox()
        Me.Icon_MMedia = New System.Windows.Forms.PictureBox()
        Me.Icon_Others = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Group_Win = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group_MMedia = New System.Windows.Forms.GroupBox()
        Me.Group_Others = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Main_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_MMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Others, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Win.SuspendLayout()
        Me.Group_MMedia.SuspendLayout()
        Me.Group_Others.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main_Close
        '
        Me.Main_Close.BackColor = System.Drawing.Color.Transparent
        Me.Main_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Main_Close.Location = New System.Drawing.Point(902, 12)
        Me.Main_Close.Name = "Main_Close"
        Me.Main_Close.Size = New System.Drawing.Size(30, 33)
        Me.Main_Close.TabIndex = 1
        Me.Main_Close.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 461)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Icon_Win
        '
        Me.Icon_Win.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Win.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.winicon
        Me.Icon_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Win.Location = New System.Drawing.Point(23, 35)
        Me.Icon_Win.Name = "Icon_Win"
        Me.Icon_Win.Size = New System.Drawing.Size(100, 100)
        Me.Icon_Win.TabIndex = 3
        Me.Icon_Win.TabStop = False
        '
        'Icon_MMedia
        '
        Me.Icon_MMedia.BackColor = System.Drawing.Color.Transparent
        Me.Icon_MMedia.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.video
        Me.Icon_MMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_MMedia.Location = New System.Drawing.Point(23, 147)
        Me.Icon_MMedia.Name = "Icon_MMedia"
        Me.Icon_MMedia.Size = New System.Drawing.Size(100, 100)
        Me.Icon_MMedia.TabIndex = 4
        Me.Icon_MMedia.TabStop = False
        '
        'Icon_Others
        '
        Me.Icon_Others.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Others.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.pen
        Me.Icon_Others.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Others.Location = New System.Drawing.Point(23, 259)
        Me.Icon_Others.Name = "Icon_Others"
        Me.Icon_Others.Size = New System.Drawing.Size(100, 100)
        Me.Icon_Others.TabIndex = 5
        Me.Icon_Others.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Location = New System.Drawing.Point(23, 371)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'Group_Win
        '
        Me.Group_Win.BackColor = System.Drawing.Color.Transparent
        Me.Group_Win.Controls.Add(Me.Label1)
        Me.Group_Win.Location = New System.Drawing.Point(150, 20)
        Me.Group_Win.Name = "Group_Win"
        Me.Group_Win.Size = New System.Drawing.Size(746, 461)
        Me.Group_Win.TabIndex = 7
        Me.Group_Win.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Group_MMedia
        '
        Me.Group_MMedia.BackColor = System.Drawing.Color.Transparent
        Me.Group_MMedia.Controls.Add(Me.Label2)
        Me.Group_MMedia.Location = New System.Drawing.Point(150, 20)
        Me.Group_MMedia.Name = "Group_MMedia"
        Me.Group_MMedia.Size = New System.Drawing.Size(746, 461)
        Me.Group_MMedia.TabIndex = 1
        Me.Group_MMedia.TabStop = False
        Me.Group_MMedia.Visible = False
        '
        'Group_Others
        '
        Me.Group_Others.BackColor = System.Drawing.Color.Transparent
        Me.Group_Others.Controls.Add(Me.Label3)
        Me.Group_Others.Location = New System.Drawing.Point(150, 20)
        Me.Group_Others.Name = "Group_Others"
        Me.Group_Others.Size = New System.Drawing.Size(746, 461)
        Me.Group_Others.TabIndex = 1
        Me.Group_Others.TabStop = False
        Me.Group_Others.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'MainScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.Group_Others)
        Me.Controls.Add(Me.Group_MMedia)
        Me.Controls.Add(Me.Group_Win)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Icon_Others)
        Me.Controls.Add(Me.Icon_MMedia)
        Me.Controls.Add(Me.Icon_Win)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Main_Close)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Main_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_MMedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Others, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Win.ResumeLayout(False)
        Me.Group_Win.PerformLayout()
        Me.Group_MMedia.ResumeLayout(False)
        Me.Group_MMedia.PerformLayout()
        Me.Group_Others.ResumeLayout(False)
        Me.Group_Others.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Main_Close As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Icon_Win As PictureBox
    Friend WithEvents Icon_MMedia As PictureBox
    Friend WithEvents Icon_Others As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Group_Win As GroupBox
    Friend WithEvents Group_MMedia As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Group_Others As GroupBox
    Friend WithEvents Label3 As Label
End Class
