<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoCut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoCut))
        Me.VidCut_Start = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VidCut_Cmd = New System.Windows.Forms.TextBox()
        Me.VidCutOut_Explore = New System.Windows.Forms.Button()
        Me.VidCutSrc_Explore = New System.Windows.Forms.Button()
        Me.VidCut_Out = New System.Windows.Forms.TextBox()
        Me.VidCut_Src = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VidCut_OutFile = New System.Windows.Forms.SaveFileDialog()
        Me.VidCut_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VidCut_StartTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VidCut_KeepTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VidCut_Start
        '
        Me.VidCut_Start.Location = New System.Drawing.Point(531, 116)
        Me.VidCut_Start.Name = "VidCut_Start"
        Me.VidCut_Start.Size = New System.Drawing.Size(75, 23)
        Me.VidCut_Start.TabIndex = 21
        Me.VidCut_Start.Text = "开始转换"
        Me.VidCut_Start.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "命令（不必填写）："
        '
        'VidCut_Cmd
        '
        Me.VidCut_Cmd.Location = New System.Drawing.Point(128, 161)
        Me.VidCut_Cmd.Name = "VidCut_Cmd"
        Me.VidCut_Cmd.ReadOnly = True
        Me.VidCut_Cmd.Size = New System.Drawing.Size(397, 21)
        Me.VidCut_Cmd.TabIndex = 19
        '
        'VidCutOut_Explore
        '
        Me.VidCutOut_Explore.Location = New System.Drawing.Point(531, 75)
        Me.VidCutOut_Explore.Name = "VidCutOut_Explore"
        Me.VidCutOut_Explore.Size = New System.Drawing.Size(75, 23)
        Me.VidCutOut_Explore.TabIndex = 18
        Me.VidCutOut_Explore.Text = "浏览..."
        Me.VidCutOut_Explore.UseVisualStyleBackColor = True
        '
        'VidCutSrc_Explore
        '
        Me.VidCutSrc_Explore.Location = New System.Drawing.Point(531, 26)
        Me.VidCutSrc_Explore.Name = "VidCutSrc_Explore"
        Me.VidCutSrc_Explore.Size = New System.Drawing.Size(75, 23)
        Me.VidCutSrc_Explore.TabIndex = 17
        Me.VidCutSrc_Explore.Text = "浏览..."
        Me.VidCutSrc_Explore.UseVisualStyleBackColor = True
        '
        'VidCut_Out
        '
        Me.VidCut_Out.Location = New System.Drawing.Point(128, 75)
        Me.VidCut_Out.Name = "VidCut_Out"
        Me.VidCut_Out.Size = New System.Drawing.Size(397, 21)
        Me.VidCut_Out.TabIndex = 16
        Me.VidCut_Out.WordWrap = False
        '
        'VidCut_Src
        '
        Me.VidCut_Src.Location = New System.Drawing.Point(128, 26)
        Me.VidCut_Src.Name = "VidCut_Src"
        Me.VidCut_Src.Size = New System.Drawing.Size(397, 21)
        Me.VidCut_Src.TabIndex = 15
        Me.VidCut_Src.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "输出路径："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "原视频路径："
        '
        'VidCut_OutFile
        '
        Me.VidCut_OutFile.Filter = "所有文件|*.*"
        Me.VidCut_OutFile.InitialDirectory = "C:\"
        '
        'VidCut_OpenFile
        '
        Me.VidCut_OpenFile.FileName = "OpenFileDialog1"
        Me.VidCut_OpenFile.Filter = "所有文件|*.*"
        Me.VidCut_OpenFile.InitialDirectory = "C:\"
        Me.VidCut_OpenFile.ShowHelp = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "开始时间："
        '
        'VidCut_StartTime
        '
        Me.VidCut_StartTime.Location = New System.Drawing.Point(128, 113)
        Me.VidCut_StartTime.Name = "VidCut_StartTime"
        Me.VidCut_StartTime.Size = New System.Drawing.Size(87, 21)
        Me.VidCut_StartTime.TabIndex = 23
        Me.VidCut_StartTime.Text = "00:00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "持续时间："
        '
        'VidCut_KeepTime
        '
        Me.VidCut_KeepTime.Location = New System.Drawing.Point(312, 113)
        Me.VidCut_KeepTime.Name = "VidCut_KeepTime"
        Me.VidCut_KeepTime.Size = New System.Drawing.Size(92, 21)
        Me.VidCut_KeepTime.TabIndex = 25
        Me.VidCut_KeepTime.Text = "00:00:00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "注：非h264编码的视频请去掉-bsf:v h264_mp4toannexb参数，使用自定义命令"
        '
        'VideoCut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 218)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.VidCut_KeepTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VidCut_StartTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VidCut_Start)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.VidCut_Cmd)
        Me.Controls.Add(Me.VidCutOut_Explore)
        Me.Controls.Add(Me.VidCutSrc_Explore)
        Me.Controls.Add(Me.VidCut_Out)
        Me.Controls.Add(Me.VidCut_Src)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoCut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "视频截取"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VidCut_Start As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents VidCut_Cmd As TextBox
    Friend WithEvents VidCutOut_Explore As Button
    Friend WithEvents VidCutSrc_Explore As Button
    Friend WithEvents VidCut_Out As TextBox
    Friend WithEvents VidCut_Src As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents VidCut_OutFile As SaveFileDialog
    Friend WithEvents VidCut_OpenFile As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents VidCut_StartTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VidCut_KeepTime As TextBox
    Friend WithEvents Label6 As Label
End Class
