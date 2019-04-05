<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.Main_Close = New System.Windows.Forms.PictureBox()
        Me.Icon_Win = New System.Windows.Forms.PictureBox()
        Me.Icon_MMedia = New System.Windows.Forms.PictureBox()
        Me.Icon_Others = New System.Windows.Forms.PictureBox()
        Me.Icon_Settings = New System.Windows.Forms.PictureBox()
        Me.ButtonsPanel = New System.Windows.Forms.Panel()
        Me.Panel_Win = New System.Windows.Forms.Panel()
        Me.Panel_Win_Main = New System.Windows.Forms.Panel()
        Me.Win_OpenControl = New System.Windows.Forms.Button()
        Me.Panel_Win_Icon = New System.Windows.Forms.PictureBox()
        Me.Panel_Win_Desc = New System.Windows.Forms.Label()
        Me.Panel_MMedia = New System.Windows.Forms.Panel()
        Me.Panel2_Desc = New System.Windows.Forms.Label()
        Me.Panel_Others = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Settings = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Win_OpenTempFolder = New System.Windows.Forms.Button()
        Me.Win_GPEDIT = New System.Windows.Forms.Button()
        Me.Win_WinVer = New System.Windows.Forms.Button()
        Me.Win_Services = New System.Windows.Forms.Button()
        Me.Win_Devices = New System.Windows.Forms.Button()
        Me.Win_OpenCmd = New System.Windows.Forms.Button()
        Me.Win_Tasks = New System.Windows.Forms.Button()
        Me.Win_OSInfo = New System.Windows.Forms.Button()
        Me.Win_Events = New System.Windows.Forms.Button()
        Me.Win_BootOptions = New System.Windows.Forms.Button()
        Me.Win_IPConfig = New System.Windows.Forms.Button()
        Me.Win_Regedit = New System.Windows.Forms.Button()
        Me.Win_TroubleShooting = New System.Windows.Forms.Button()
        Me.Win_Programs = New System.Windows.Forms.Button()
        Me.Win_Securily = New System.Windows.Forms.Button()
        Me.Win_Cleaner = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2_Icon = New System.Windows.Forms.PictureBox()
        Me.Vid_Conv = New System.Windows.Forms.Button()
        Me.Vid_Cut = New System.Windows.Forms.Button()
        Me.Vid_Merge = New System.Windows.Forms.Button()
        Me.Vid_FFMpeg = New System.Windows.Forms.Button()
        CType(Me.Main_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_MMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Others, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsPanel.SuspendLayout()
        Me.Panel_Win.SuspendLayout()
        Me.Panel_Win_Main.SuspendLayout()
        CType(Me.Panel_Win_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MMedia.SuspendLayout()
        Me.Panel_Others.SuspendLayout()
        Me.Panel_Settings.SuspendLayout()
        CType(Me.Panel2_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Main_Close
        '
        Me.Main_Close.BackColor = System.Drawing.Color.Transparent
        Me.Main_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Main_Close.Image = Global.Moonlight_Box.My.Resources.Resources.close_0
        Me.Main_Close.Location = New System.Drawing.Point(902, 12)
        Me.Main_Close.Name = "Main_Close"
        Me.Main_Close.Size = New System.Drawing.Size(30, 33)
        Me.Main_Close.TabIndex = 1
        Me.Main_Close.TabStop = False
        '
        'Icon_Win
        '
        Me.Icon_Win.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Win.BackgroundImage = CType(resources.GetObject("Icon_Win.BackgroundImage"), System.Drawing.Image)
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
        Me.Icon_MMedia.BackgroundImage = CType(resources.GetObject("Icon_MMedia.BackgroundImage"), System.Drawing.Image)
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
        Me.Icon_Others.BackgroundImage = CType(resources.GetObject("Icon_Others.BackgroundImage"), System.Drawing.Image)
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
        Me.Icon_Settings.BackgroundImage = CType(resources.GetObject("Icon_Settings.BackgroundImage"), System.Drawing.Image)
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
        Me.Panel_Win.Controls.Add(Me.Panel_Win_Main)
        Me.Panel_Win.Controls.Add(Me.Panel_Win_Icon)
        Me.Panel_Win.Controls.Add(Me.Panel_Win_Desc)
        Me.Panel_Win.Location = New System.Drawing.Point(167, 20)
        Me.Panel_Win.Name = "Panel_Win"
        Me.Panel_Win.Size = New System.Drawing.Size(720, 461)
        Me.Panel_Win.TabIndex = 10
        '
        'Panel_Win_Main
        '
        Me.Panel_Win_Main.AutoScroll = True
        Me.Panel_Win_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_Win_Main.Controls.Add(Me.Button2)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Cleaner)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Securily)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Programs)
        Me.Panel_Win_Main.Controls.Add(Me.Win_TroubleShooting)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Regedit)
        Me.Panel_Win_Main.Controls.Add(Me.Win_IPConfig)
        Me.Panel_Win_Main.Controls.Add(Me.Win_BootOptions)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Events)
        Me.Panel_Win_Main.Controls.Add(Me.Win_OSInfo)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Tasks)
        Me.Panel_Win_Main.Controls.Add(Me.Win_OpenCmd)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Devices)
        Me.Panel_Win_Main.Controls.Add(Me.Win_Services)
        Me.Panel_Win_Main.Controls.Add(Me.Win_WinVer)
        Me.Panel_Win_Main.Controls.Add(Me.Win_GPEDIT)
        Me.Panel_Win_Main.Controls.Add(Me.Win_OpenTempFolder)
        Me.Panel_Win_Main.Controls.Add(Me.Win_OpenControl)
        Me.Panel_Win_Main.Location = New System.Drawing.Point(17, 68)
        Me.Panel_Win_Main.Name = "Panel_Win_Main"
        Me.Panel_Win_Main.Size = New System.Drawing.Size(682, 379)
        Me.Panel_Win_Main.TabIndex = 2
        '
        'Win_OpenControl
        '
        Me.Win_OpenControl.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_OpenControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_OpenControl.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_OpenControl.ForeColor = System.Drawing.Color.White
        Me.Win_OpenControl.Location = New System.Drawing.Point(28, 13)
        Me.Win_OpenControl.Name = "Win_OpenControl"
        Me.Win_OpenControl.Size = New System.Drawing.Size(275, 60)
        Me.Win_OpenControl.TabIndex = 0
        Me.Win_OpenControl.Text = "打开控制面板"
        Me.Win_OpenControl.UseVisualStyleBackColor = False
        '
        'Panel_Win_Icon
        '
        Me.Panel_Win_Icon.BackgroundImage = CType(resources.GetObject("Panel_Win_Icon.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Win_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_Win_Icon.Location = New System.Drawing.Point(0, 13)
        Me.Panel_Win_Icon.Name = "Panel_Win_Icon"
        Me.Panel_Win_Icon.Size = New System.Drawing.Size(82, 41)
        Me.Panel_Win_Icon.TabIndex = 1
        Me.Panel_Win_Icon.TabStop = False
        '
        'Panel_Win_Desc
        '
        Me.Panel_Win_Desc.AutoSize = True
        Me.Panel_Win_Desc.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 26.0!)
        Me.Panel_Win_Desc.ForeColor = System.Drawing.Color.White
        Me.Panel_Win_Desc.Location = New System.Drawing.Point(88, 17)
        Me.Panel_Win_Desc.Name = "Panel_Win_Desc"
        Me.Panel_Win_Desc.Size = New System.Drawing.Size(232, 37)
        Me.Panel_Win_Desc.TabIndex = 0
        Me.Panel_Win_Desc.Text = "Windows工具"
        '
        'Panel_MMedia
        '
        Me.Panel_MMedia.BackColor = System.Drawing.Color.Transparent
        Me.Panel_MMedia.Controls.Add(Me.Vid_FFMpeg)
        Me.Panel_MMedia.Controls.Add(Me.Vid_Merge)
        Me.Panel_MMedia.Controls.Add(Me.Vid_Cut)
        Me.Panel_MMedia.Controls.Add(Me.Vid_Conv)
        Me.Panel_MMedia.Controls.Add(Me.Panel2_Icon)
        Me.Panel_MMedia.Controls.Add(Me.Panel2_Desc)
        Me.Panel_MMedia.Location = New System.Drawing.Point(167, 20)
        Me.Panel_MMedia.Name = "Panel_MMedia"
        Me.Panel_MMedia.Size = New System.Drawing.Size(720, 461)
        Me.Panel_MMedia.TabIndex = 11
        Me.Panel_MMedia.Visible = False
        '
        'Panel2_Desc
        '
        Me.Panel2_Desc.AutoSize = True
        Me.Panel2_Desc.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 26.0!)
        Me.Panel2_Desc.ForeColor = System.Drawing.Color.White
        Me.Panel2_Desc.Location = New System.Drawing.Point(88, 17)
        Me.Panel2_Desc.Name = "Panel2_Desc"
        Me.Panel2_Desc.Size = New System.Drawing.Size(387, 37)
        Me.Panel2_Desc.TabIndex = 0
        Me.Panel2_Desc.Text = "视频工具-基于FFMpeg"
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
        'Win_OpenTempFolder
        '
        Me.Win_OpenTempFolder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_OpenTempFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_OpenTempFolder.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_OpenTempFolder.ForeColor = System.Drawing.Color.White
        Me.Win_OpenTempFolder.Location = New System.Drawing.Point(337, 13)
        Me.Win_OpenTempFolder.Name = "Win_OpenTempFolder"
        Me.Win_OpenTempFolder.Size = New System.Drawing.Size(275, 60)
        Me.Win_OpenTempFolder.TabIndex = 1
        Me.Win_OpenTempFolder.Text = "打开系统缓存文件夹"
        Me.Win_OpenTempFolder.UseVisualStyleBackColor = False
        '
        'Win_GPEDIT
        '
        Me.Win_GPEDIT.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_GPEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_GPEDIT.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_GPEDIT.ForeColor = System.Drawing.Color.White
        Me.Win_GPEDIT.Location = New System.Drawing.Point(337, 345)
        Me.Win_GPEDIT.Name = "Win_GPEDIT"
        Me.Win_GPEDIT.Size = New System.Drawing.Size(275, 60)
        Me.Win_GPEDIT.TabIndex = 2
        Me.Win_GPEDIT.Text = "打开组策略编辑器"
        Me.Win_GPEDIT.UseVisualStyleBackColor = False
        '
        'Win_WinVer
        '
        Me.Win_WinVer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_WinVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_WinVer.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_WinVer.ForeColor = System.Drawing.Color.White
        Me.Win_WinVer.Location = New System.Drawing.Point(337, 97)
        Me.Win_WinVer.Name = "Win_WinVer"
        Me.Win_WinVer.Size = New System.Drawing.Size(275, 60)
        Me.Win_WinVer.TabIndex = 3
        Me.Win_WinVer.Text = "显示系统版本信息"
        Me.Win_WinVer.UseVisualStyleBackColor = False
        '
        'Win_Services
        '
        Me.Win_Services.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Services.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Services.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Services.ForeColor = System.Drawing.Color.White
        Me.Win_Services.Location = New System.Drawing.Point(28, 345)
        Me.Win_Services.Name = "Win_Services"
        Me.Win_Services.Size = New System.Drawing.Size(275, 60)
        Me.Win_Services.TabIndex = 4
        Me.Win_Services.Text = "管理系统服务"
        Me.Win_Services.UseVisualStyleBackColor = False
        '
        'Win_Devices
        '
        Me.Win_Devices.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Devices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Devices.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Devices.ForeColor = System.Drawing.Color.White
        Me.Win_Devices.Location = New System.Drawing.Point(337, 181)
        Me.Win_Devices.Name = "Win_Devices"
        Me.Win_Devices.Size = New System.Drawing.Size(275, 60)
        Me.Win_Devices.TabIndex = 5
        Me.Win_Devices.Text = "打开设备管理器"
        Me.Win_Devices.UseVisualStyleBackColor = False
        '
        'Win_OpenCmd
        '
        Me.Win_OpenCmd.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_OpenCmd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_OpenCmd.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_OpenCmd.ForeColor = System.Drawing.Color.White
        Me.Win_OpenCmd.Location = New System.Drawing.Point(28, 262)
        Me.Win_OpenCmd.Name = "Win_OpenCmd"
        Me.Win_OpenCmd.Size = New System.Drawing.Size(275, 60)
        Me.Win_OpenCmd.TabIndex = 6
        Me.Win_OpenCmd.Text = "打开命令行"
        Me.Win_OpenCmd.UseVisualStyleBackColor = False
        '
        'Win_Tasks
        '
        Me.Win_Tasks.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Tasks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Tasks.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Tasks.ForeColor = System.Drawing.Color.White
        Me.Win_Tasks.Location = New System.Drawing.Point(337, 265)
        Me.Win_Tasks.Name = "Win_Tasks"
        Me.Win_Tasks.Size = New System.Drawing.Size(275, 60)
        Me.Win_Tasks.TabIndex = 7
        Me.Win_Tasks.Text = "打开任务计划程序"
        Me.Win_Tasks.UseVisualStyleBackColor = False
        '
        'Win_OSInfo
        '
        Me.Win_OSInfo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_OSInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_OSInfo.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_OSInfo.ForeColor = System.Drawing.Color.White
        Me.Win_OSInfo.Location = New System.Drawing.Point(28, 179)
        Me.Win_OSInfo.Name = "Win_OSInfo"
        Me.Win_OSInfo.Size = New System.Drawing.Size(275, 60)
        Me.Win_OSInfo.TabIndex = 8
        Me.Win_OSInfo.Text = "查看系统基本配置"
        Me.Win_OSInfo.UseVisualStyleBackColor = False
        '
        'Win_Events
        '
        Me.Win_Events.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Events.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Events.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Events.ForeColor = System.Drawing.Color.White
        Me.Win_Events.Location = New System.Drawing.Point(28, 518)
        Me.Win_Events.Name = "Win_Events"
        Me.Win_Events.Size = New System.Drawing.Size(275, 60)
        Me.Win_Events.TabIndex = 9
        Me.Win_Events.Text = "打开事件查看器"
        Me.Win_Events.UseVisualStyleBackColor = False
        '
        'Win_BootOptions
        '
        Me.Win_BootOptions.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_BootOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_BootOptions.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_BootOptions.ForeColor = System.Drawing.Color.White
        Me.Win_BootOptions.Location = New System.Drawing.Point(337, 598)
        Me.Win_BootOptions.Name = "Win_BootOptions"
        Me.Win_BootOptions.Size = New System.Drawing.Size(275, 60)
        Me.Win_BootOptions.TabIndex = 10
        Me.Win_BootOptions.Text = "Windows引导选项"
        Me.Win_BootOptions.UseVisualStyleBackColor = False
        '
        'Win_IPConfig
        '
        Me.Win_IPConfig.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_IPConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_IPConfig.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_IPConfig.ForeColor = System.Drawing.Color.White
        Me.Win_IPConfig.Location = New System.Drawing.Point(337, 518)
        Me.Win_IPConfig.Name = "Win_IPConfig"
        Me.Win_IPConfig.Size = New System.Drawing.Size(275, 60)
        Me.Win_IPConfig.TabIndex = 11
        Me.Win_IPConfig.Text = "网络连接属性"
        Me.Win_IPConfig.UseVisualStyleBackColor = False
        '
        'Win_Regedit
        '
        Me.Win_Regedit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Regedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Regedit.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Regedit.ForeColor = System.Drawing.Color.White
        Me.Win_Regedit.Location = New System.Drawing.Point(337, 433)
        Me.Win_Regedit.Name = "Win_Regedit"
        Me.Win_Regedit.Size = New System.Drawing.Size(275, 60)
        Me.Win_Regedit.TabIndex = 12
        Me.Win_Regedit.Text = "注册表编辑器"
        Me.Win_Regedit.UseVisualStyleBackColor = False
        '
        'Win_TroubleShooting
        '
        Me.Win_TroubleShooting.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_TroubleShooting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_TroubleShooting.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_TroubleShooting.ForeColor = System.Drawing.Color.White
        Me.Win_TroubleShooting.Location = New System.Drawing.Point(28, 433)
        Me.Win_TroubleShooting.Name = "Win_TroubleShooting"
        Me.Win_TroubleShooting.Size = New System.Drawing.Size(275, 60)
        Me.Win_TroubleShooting.TabIndex = 13
        Me.Win_TroubleShooting.Text = "Windows疑难解答"
        Me.Win_TroubleShooting.UseVisualStyleBackColor = False
        '
        'Win_Programs
        '
        Me.Win_Programs.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Programs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Programs.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Programs.ForeColor = System.Drawing.Color.White
        Me.Win_Programs.Location = New System.Drawing.Point(28, 96)
        Me.Win_Programs.Name = "Win_Programs"
        Me.Win_Programs.Size = New System.Drawing.Size(275, 60)
        Me.Win_Programs.TabIndex = 14
        Me.Win_Programs.Text = "Windows程序管理"
        Me.Win_Programs.UseVisualStyleBackColor = False
        '
        'Win_Securily
        '
        Me.Win_Securily.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Securily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Securily.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Securily.ForeColor = System.Drawing.Color.White
        Me.Win_Securily.Location = New System.Drawing.Point(28, 598)
        Me.Win_Securily.Name = "Win_Securily"
        Me.Win_Securily.Size = New System.Drawing.Size(275, 60)
        Me.Win_Securily.TabIndex = 15
        Me.Win_Securily.Text = "打开安全与维护"
        Me.Win_Securily.UseVisualStyleBackColor = False
        '
        'Win_Cleaner
        '
        Me.Win_Cleaner.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Win_Cleaner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Win_Cleaner.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Win_Cleaner.ForeColor = System.Drawing.Color.White
        Me.Win_Cleaner.Location = New System.Drawing.Point(28, 673)
        Me.Win_Cleaner.Name = "Win_Cleaner"
        Me.Win_Cleaner.Size = New System.Drawing.Size(275, 60)
        Me.Win_Cleaner.TabIndex = 16
        Me.Win_Cleaner.Text = "Windows磁盘清理"
        Me.Win_Cleaner.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(337, 673)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(275, 60)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "磁盘碎片整理"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2_Icon
        '
        Me.Panel2_Icon.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.video
        Me.Panel2_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2_Icon.Location = New System.Drawing.Point(0, 13)
        Me.Panel2_Icon.Name = "Panel2_Icon"
        Me.Panel2_Icon.Size = New System.Drawing.Size(82, 41)
        Me.Panel2_Icon.TabIndex = 1
        Me.Panel2_Icon.TabStop = False
        '
        'Vid_Conv
        '
        Me.Vid_Conv.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Vid_Conv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Vid_Conv.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Vid_Conv.ForeColor = System.Drawing.Color.White
        Me.Vid_Conv.Location = New System.Drawing.Point(20, 68)
        Me.Vid_Conv.Name = "Vid_Conv"
        Me.Vid_Conv.Size = New System.Drawing.Size(275, 60)
        Me.Vid_Conv.TabIndex = 5
        Me.Vid_Conv.Text = "视频转换"
        Me.Vid_Conv.UseVisualStyleBackColor = False
        '
        'Vid_Cut
        '
        Me.Vid_Cut.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Vid_Cut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Vid_Cut.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Vid_Cut.ForeColor = System.Drawing.Color.White
        Me.Vid_Cut.Location = New System.Drawing.Point(326, 68)
        Me.Vid_Cut.Name = "Vid_Cut"
        Me.Vid_Cut.Size = New System.Drawing.Size(275, 60)
        Me.Vid_Cut.TabIndex = 6
        Me.Vid_Cut.Text = "视频裁剪"
        Me.Vid_Cut.UseVisualStyleBackColor = False
        '
        'Vid_Merge
        '
        Me.Vid_Merge.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Vid_Merge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Vid_Merge.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Vid_Merge.ForeColor = System.Drawing.Color.White
        Me.Vid_Merge.Location = New System.Drawing.Point(20, 147)
        Me.Vid_Merge.Name = "Vid_Merge"
        Me.Vid_Merge.Size = New System.Drawing.Size(275, 60)
        Me.Vid_Merge.TabIndex = 7
        Me.Vid_Merge.Text = "视频合并"
        Me.Vid_Merge.UseVisualStyleBackColor = False
        '
        'Vid_FFMpeg
        '
        Me.Vid_FFMpeg.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Vid_FFMpeg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Vid_FFMpeg.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Vid_FFMpeg.ForeColor = System.Drawing.Color.White
        Me.Vid_FFMpeg.Location = New System.Drawing.Point(326, 147)
        Me.Vid_FFMpeg.Name = "Vid_FFMpeg"
        Me.Vid_FFMpeg.Size = New System.Drawing.Size(275, 60)
        Me.Vid_FFMpeg.TabIndex = 8
        Me.Vid_FFMpeg.Text = "运行FFMpeg"
        Me.Vid_FFMpeg.UseVisualStyleBackColor = False
        '
        'MainScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Moonlight_Box.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.ButtonsPanel)
        Me.Controls.Add(Me.Main_Close)
        Me.Controls.Add(Me.Panel_MMedia)
        Me.Controls.Add(Me.Panel_Win)
        Me.Controls.Add(Me.Panel_Settings)
        Me.Controls.Add(Me.Panel_Others)
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
        Me.Panel_Win_Main.ResumeLayout(False)
        CType(Me.Panel_Win_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MMedia.ResumeLayout(False)
        Me.Panel_MMedia.PerformLayout()
        Me.Panel_Others.ResumeLayout(False)
        Me.Panel_Others.PerformLayout()
        Me.Panel_Settings.ResumeLayout(False)
        Me.Panel_Settings.PerformLayout()
        CType(Me.Panel2_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Main_Close As PictureBox
    Friend WithEvents Icon_Win As PictureBox
    Friend WithEvents Icon_MMedia As PictureBox
    Friend WithEvents Icon_Others As PictureBox
    Friend WithEvents Icon_Settings As PictureBox
    Friend WithEvents ButtonsPanel As Panel
    Friend WithEvents Panel_Win As Panel
    Friend WithEvents Panel_MMedia As Panel
    Friend WithEvents Panel2_Desc As Label
    Friend WithEvents Panel_Others As Panel
    Friend WithEvents Panel_Settings As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_Win_Desc As Label
    Friend WithEvents Panel_Win_Icon As PictureBox
    Friend WithEvents Panel_Win_Main As Panel
    Friend WithEvents Win_OpenControl As Button
    Friend WithEvents Win_Tasks As Button
    Friend WithEvents Win_OpenCmd As Button
    Friend WithEvents Win_Devices As Button
    Friend WithEvents Win_Services As Button
    Friend WithEvents Win_WinVer As Button
    Friend WithEvents Win_GPEDIT As Button
    Friend WithEvents Win_OpenTempFolder As Button
    Friend WithEvents Win_Programs As Button
    Friend WithEvents Win_TroubleShooting As Button
    Friend WithEvents Win_Regedit As Button
    Friend WithEvents Win_IPConfig As Button
    Friend WithEvents Win_BootOptions As Button
    Friend WithEvents Win_Events As Button
    Friend WithEvents Win_OSInfo As Button
    Friend WithEvents Win_Securily As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Win_Cleaner As Button
    Friend WithEvents Panel2_Icon As PictureBox
    Friend WithEvents Vid_FFMpeg As Button
    Friend WithEvents Vid_Merge As Button
    Friend WithEvents Vid_Cut As Button
    Friend WithEvents Vid_Conv As Button
End Class
