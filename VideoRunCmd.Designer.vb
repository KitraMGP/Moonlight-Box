<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoRunCmd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoRunCmd))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VidCmd = New System.Windows.Forms.TextBox()
        Me.VidCmdRun = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "命令："
        '
        'VidCmd
        '
        Me.VidCmd.Location = New System.Drawing.Point(99, 59)
        Me.VidCmd.Name = "VidCmd"
        Me.VidCmd.Size = New System.Drawing.Size(571, 21)
        Me.VidCmd.TabIndex = 2
        '
        'VidCmdRun
        '
        Me.VidCmdRun.Location = New System.Drawing.Point(602, 93)
        Me.VidCmdRun.Name = "VidCmdRun"
        Me.VidCmdRun.Size = New System.Drawing.Size(75, 23)
        Me.VidCmdRun.TabIndex = 3
        Me.VidCmdRun.Text = "运行"
        Me.VidCmdRun.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ffmpeg.exe +"
        '
        'VideoRunCmd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 138)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VidCmdRun)
        Me.Controls.Add(Me.VidCmd)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoRunCmd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "运行自定义命令"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents VidCmd As TextBox
    Friend WithEvents VidCmdRun As Button
    Friend WithEvents Label3 As Label
End Class
