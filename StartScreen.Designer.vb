<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start_Screen))
        Me.Start_Close = New System.Windows.Forms.PictureBox()
        Me.Start_Name = New System.Windows.Forms.Label()
        Me.Start_Icon = New System.Windows.Forms.PictureBox()
        Me.Start_Progress = New System.Windows.Forms.ProgressBar()
        Me.Start_Status = New System.Windows.Forms.Label()
        CType(Me.Start_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start_Close
        '
        Me.Start_Close.BackColor = System.Drawing.Color.Transparent
        Me.Start_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Start_Close.Location = New System.Drawing.Point(598, 12)
        Me.Start_Close.Name = "Start_Close"
        Me.Start_Close.Size = New System.Drawing.Size(30, 33)
        Me.Start_Close.TabIndex = 0
        Me.Start_Close.TabStop = False
        '
        'Start_Name
        '
        Me.Start_Name.AutoSize = True
        Me.Start_Name.BackColor = System.Drawing.Color.Transparent
        Me.Start_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Start_Name.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_Name.ForeColor = System.Drawing.Color.White
        Me.Start_Name.Location = New System.Drawing.Point(174, 123)
        Me.Start_Name.Name = "Start_Name"
        Me.Start_Name.Size = New System.Drawing.Size(427, 102)
        Me.Start_Name.TabIndex = 1
        Me.Start_Name.Text = "月光宝盒"
        '
        'Start_Icon
        '
        Me.Start_Icon.BackColor = System.Drawing.Color.Transparent
        Me.Start_Icon.Image = Global.Moonlight_Box.My.Resources.Resources.icon
        Me.Start_Icon.Location = New System.Drawing.Point(36, 114)
        Me.Start_Icon.Name = "Start_Icon"
        Me.Start_Icon.Size = New System.Drawing.Size(132, 111)
        Me.Start_Icon.TabIndex = 2
        Me.Start_Icon.TabStop = False
        '
        'Start_Progress
        '
        Me.Start_Progress.Location = New System.Drawing.Point(0, 341)
        Me.Start_Progress.Name = "Start_Progress"
        Me.Start_Progress.Size = New System.Drawing.Size(640, 20)
        Me.Start_Progress.TabIndex = 3
        '
        'Start_Status
        '
        Me.Start_Status.AutoSize = True
        Me.Start_Status.BackColor = System.Drawing.Color.Transparent
        Me.Start_Status.Font = New System.Drawing.Font("锐字锐线俏皮简1.0", 20.0!)
        Me.Start_Status.ForeColor = System.Drawing.Color.White
        Me.Start_Status.Location = New System.Drawing.Point(12, 310)
        Me.Start_Status.Name = "Start_Status"
        Me.Start_Status.Size = New System.Drawing.Size(171, 28)
        Me.Start_Status.TabIndex = 4
        Me.Start_Status.Text = "正在初始化..."
        '
        'Start_Screen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.Start_Status)
        Me.Controls.Add(Me.Start_Progress)
        Me.Controls.Add(Me.Start_Icon)
        Me.Controls.Add(Me.Start_Name)
        Me.Controls.Add(Me.Start_Close)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Start_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Start_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_Close As PictureBox
    Friend WithEvents Start_Name As Label
    Friend WithEvents Start_Icon As PictureBox
    Friend WithEvents Start_Progress As ProgressBar
    Friend WithEvents Start_Status As Label
End Class
