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
        Me.Icon_Win = New System.Windows.Forms.PictureBox()
        Me.Icon_MMedia = New System.Windows.Forms.PictureBox()
        Me.Icon_Others = New System.Windows.Forms.PictureBox()
        Me.Icon_Settings = New System.Windows.Forms.PictureBox()
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.Panel_Win = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_MMedia = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Others = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Settings = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Main_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_MMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Others, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsPanel.SuspendLayout()
        Me.Panel_Win.SuspendLayout()
        Me.Panel_MMedia.SuspendLayout()
        Me.Panel_Others.SuspendLayout()
        Me.Panel_Settings.SuspendLayout()
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
        'Icon_Win
        '
        Me.Icon_Win.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Win.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.winicon_0
        Me.Icon_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Win.Location = New System.Drawing.Point(16, 17)
        Me.Icon_Win.Name = "Icon_Win"
        Me.Icon_Win.Size = New System.Drawing.Size(100, 100)
        Me.Icon_Win.TabIndex = 3
        Me.Icon_Win.TabStop = False
        '
        'Icon_MMedia
        '
        Me.Icon_MMedia.BackColor = System.Drawing.Color.Transparent
        Me.Icon_MMedia.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.video_0
        Me.Icon_MMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_MMedia.Location = New System.Drawing.Point(16, 123)
        Me.Icon_MMedia.Name = "Icon_MMedia"
        Me.Icon_MMedia.Size = New System.Drawing.Size(100, 100)
        Me.Icon_MMedia.TabIndex = 4
        Me.Icon_MMedia.TabStop = False
        '
        'Icon_Others
        '
        Me.Icon_Others.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Others.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.pen_0
        Me.Icon_Others.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Others.Location = New System.Drawing.Point(16, 229)
        Me.Icon_Others.Name = "Icon_Others"
        Me.Icon_Others.Size = New System.Drawing.Size(100, 100)
        Me.Icon_Others.TabIndex = 5
        Me.Icon_Others.TabStop = False
        '
        'Icon_Settings
        '
        Me.Icon_Settings.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Settings.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.settings_0
        Me.Icon_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Settings.Location = New System.Drawing.Point(16, 335)
        Me.Icon_Settings.Name = "Icon_Settings"
        Me.Icon_Settings.Size = New System.Drawing.Size(100, 100)
        Me.Icon_Settings.TabIndex = 6
        Me.Icon_Settings.TabStop = False
        '
        'ButtonsPanel
        '
        Me.ButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonsPanel.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.main_left
        Me.ButtonsPanel.Controls.Add(Me.Icon_Win)
        Me.ButtonsPanel.Controls.Add(Me.Icon_Settings)
        Me.ButtonsPanel.Controls.Add(Me.Icon_Others)
        Me.ButtonsPanel.Controls.Add(Me.Icon_MMedia)
        Me.ButtonsPanel.Location = New System.Drawing.Point(12, 20)
        Me.ButtonsPanel.Name = "ButtonsPanel"
        Me.ButtonsPanel.Size = New System.Drawing.Size(132, 461)
        Me.ButtonsPanel.TabIndex = 9
        '
        'Panel_Win
        '
        Me.Panel_Win.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Win.Controls.Add(Me.Label1)
        Me.Panel_Win.Location = New System.Drawing.Point(167, 20)
        Me.Panel_Win.Name = "Panel_Win"
        Me.Panel_Win.Size = New System.Drawing.Size(720, 461)
        Me.Panel_Win.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1"
        '
        'Panel_MMedia
        '
        Me.Panel_MMedia.BackColor = System.Drawing.Color.Transparent
        Me.Panel_MMedia.Controls.Add(Me.Label2)
        Me.Panel_MMedia.Location = New System.Drawing.Point(167, 20)
        Me.Panel_MMedia.Name = "Panel_MMedia"
        Me.Panel_MMedia.Size = New System.Drawing.Size(720, 461)
        Me.Panel_MMedia.TabIndex = 11
        Me.Panel_MMedia.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "2"
        '
        'Panel_Others
        '
        Me.Panel_Others.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Others.Controls.Add(Me.Label3)
        Me.Panel_Others.Location = New System.Drawing.Point(167, 20)
        Me.Panel_Others.Name = "Panel_Others"
        Me.Panel_Others.Size = New System.Drawing.Size(720, 461)
        Me.Panel_Others.TabIndex = 12
        Me.Panel_Others.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "3"
        '
        'Panel_Settings
        '
        Me.Panel_Settings.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Settings.Controls.Add(Me.Label4)
        Me.Panel_Settings.Location = New System.Drawing.Point(167, 20)
        Me.Panel_Settings.Name = "Panel_Settings"
        Me.Panel_Settings.Size = New System.Drawing.Size(720, 461)
        Me.Panel_Settings.TabIndex = 13
        Me.Panel_Settings.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "4"
        '
        'MainScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.Panel_Settings)
        Me.Controls.Add(Me.Panel_Others)
        Me.Controls.Add(Me.Panel_MMedia)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.Main_Close)
        Me.Controls.Add(Me.Panel_Win)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Main_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_MMedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Others, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonsPanel.ResumeLayout(False)
        Me.Panel_Win.ResumeLayout(False)
        Me.Panel_Win.PerformLayout()
        Me.Panel_MMedia.ResumeLayout(False)
        Me.Panel_MMedia.PerformLayout()
        Me.Panel_Others.ResumeLayout(False)
        Me.Panel_Others.PerformLayout()
        Me.Panel_Settings.ResumeLayout(False)
        Me.Panel_Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Main_Close As PictureBox
    Friend WithEvents Icon_Win As PictureBox
    Friend WithEvents Icon_MMedia As PictureBox
    Friend WithEvents Icon_Others As PictureBox
    Friend WithEvents Icon_Settings As PictureBox
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents Panel_Win As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_MMedia As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Others As Panel
    Friend WithEvents Panel_Settings As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
