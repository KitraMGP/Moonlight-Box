<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoConvert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoConvert))
        Me.VidConvert_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VidConvert_Src = New System.Windows.Forms.TextBox()
        Me.VidConvert_Out = New System.Windows.Forms.TextBox()
        Me.VidConvertSrc_Explore = New System.Windows.Forms.Button()
        Me.VidConvertOut_Explore = New System.Windows.Forms.Button()
        Me.VidConvert_OutFile = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VidConvert_FPS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VidConvert_Kbps = New System.Windows.Forms.TextBox()
        Me.VidConvert_Cmd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VidConvert_Start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VidConvert_OpenFile
        '
        Me.VidConvert_OpenFile.FileName = "OpenFileDialog1"
        Me.VidConvert_OpenFile.Filter = "所有文件|*.*"
        Me.VidConvert_OpenFile.InitialDirectory = "C:\"
        Me.VidConvert_OpenFile.ShowHelp = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原视频路径："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "输出路径："
        '
        'VidConvert_Src
        '
        Me.VidConvert_Src.Location = New System.Drawing.Point(124, 25)
        Me.VidConvert_Src.Name = "VidConvert_Src"
        Me.VidConvert_Src.Size = New System.Drawing.Size(397, 21)
        Me.VidConvert_Src.TabIndex = 2
        Me.VidConvert_Src.WordWrap = False
        '
        'VidConvert_Out
        '
        Me.VidConvert_Out.Location = New System.Drawing.Point(124, 74)
        Me.VidConvert_Out.Name = "VidConvert_Out"
        Me.VidConvert_Out.Size = New System.Drawing.Size(397, 21)
        Me.VidConvert_Out.TabIndex = 3
        Me.VidConvert_Out.WordWrap = False
        '
        'VidConvertSrc_Explore
        '
        Me.VidConvertSrc_Explore.Location = New System.Drawing.Point(527, 25)
        Me.VidConvertSrc_Explore.Name = "VidConvertSrc_Explore"
        Me.VidConvertSrc_Explore.Size = New System.Drawing.Size(75, 23)
        Me.VidConvertSrc_Explore.TabIndex = 4
        Me.VidConvertSrc_Explore.Text = "浏览..."
        Me.VidConvertSrc_Explore.UseVisualStyleBackColor = True
        '
        'VidConvertOut_Explore
        '
        Me.VidConvertOut_Explore.Location = New System.Drawing.Point(527, 74)
        Me.VidConvertOut_Explore.Name = "VidConvertOut_Explore"
        Me.VidConvertOut_Explore.Size = New System.Drawing.Size(75, 23)
        Me.VidConvertOut_Explore.TabIndex = 5
        Me.VidConvertOut_Explore.Text = "浏览..."
        Me.VidConvertOut_Explore.UseVisualStyleBackColor = True
        '
        'VidConvert_OutFile
        '
        Me.VidConvert_OutFile.Filter = "所有文件|*.*"
        Me.VidConvert_OutFile.InitialDirectory = "C:\"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "帧率："
        '
        'VidConvert_FPS
        '
        Me.VidConvert_FPS.Location = New System.Drawing.Point(124, 118)
        Me.VidConvert_FPS.Name = "VidConvert_FPS"
        Me.VidConvert_FPS.Size = New System.Drawing.Size(59, 21)
        Me.VidConvert_FPS.TabIndex = 7
        Me.VidConvert_FPS.Text = "24"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "码率："
        '
        'VidConvert_Kbps
        '
        Me.VidConvert_Kbps.Location = New System.Drawing.Point(248, 118)
        Me.VidConvert_Kbps.Name = "VidConvert_Kbps"
        Me.VidConvert_Kbps.Size = New System.Drawing.Size(84, 21)
        Me.VidConvert_Kbps.TabIndex = 9
        Me.VidConvert_Kbps.Text = "4800"
        '
        'VidConvert_Cmd
        '
        Me.VidConvert_Cmd.Location = New System.Drawing.Point(124, 160)
        Me.VidConvert_Cmd.Name = "VidConvert_Cmd"
        Me.VidConvert_Cmd.ReadOnly = True
        Me.VidConvert_Cmd.Size = New System.Drawing.Size(397, 21)
        Me.VidConvert_Cmd.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "命令（不必填写）："
        '
        'VidConvert_Start
        '
        Me.VidConvert_Start.Location = New System.Drawing.Point(527, 115)
        Me.VidConvert_Start.Name = "VidConvert_Start"
        Me.VidConvert_Start.Size = New System.Drawing.Size(75, 23)
        Me.VidConvert_Start.TabIndex = 12
        Me.VidConvert_Start.Text = "开始转换"
        Me.VidConvert_Start.UseVisualStyleBackColor = True
        '
        'VideoConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 209)
        Me.Controls.Add(Me.VidConvert_Start)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.VidConvert_Cmd)
        Me.Controls.Add(Me.VidConvert_Kbps)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VidConvert_FPS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VidConvertOut_Explore)
        Me.Controls.Add(Me.VidConvertSrc_Explore)
        Me.Controls.Add(Me.VidConvert_Out)
        Me.Controls.Add(Me.VidConvert_Src)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "视频转换"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VidConvert_OpenFile As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VidConvert_Src As TextBox
    Friend WithEvents VidConvert_Out As TextBox
    Friend WithEvents VidConvertSrc_Explore As Button
    Friend WithEvents VidConvertOut_Explore As Button
    Friend WithEvents VidConvert_OutFile As SaveFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents VidConvert_FPS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VidConvert_Kbps As TextBox
    Friend WithEvents VidConvert_Cmd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents VidConvert_Start As Button
End Class
