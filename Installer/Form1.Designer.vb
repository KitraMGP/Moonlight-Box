<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Start = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LICENSE = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InstallLocation = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Start.SuspendLayout()
        Me.LICENSE.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.Controls.Add(Me.Button1)
        Me.Start.Controls.Add(Me.Label2)
        Me.Start.Controls.Add(Me.Label1)
        Me.Start.Location = New System.Drawing.Point(13, 13)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(610, 330)
        Me.Start.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("黑体", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "月光宝盒安装向导"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(529, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "欢迎使用月光宝盒，此程序将指引您将它安装在计算机上。"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "下一步"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LICENSE
        '
        Me.LICENSE.BackColor = System.Drawing.Color.Transparent
        Me.LICENSE.Controls.Add(Me.Button3)
        Me.LICENSE.Controls.Add(Me.Button2)
        Me.LICENSE.Controls.Add(Me.TextBox1)
        Me.LICENSE.Controls.Add(Me.Label3)
        Me.LICENSE.Location = New System.Drawing.Point(13, 13)
        Me.LICENSE.Name = "LICENSE"
        Me.LICENSE.Size = New System.Drawing.Size(610, 330)
        Me.LICENSE.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(589, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "您必须同意以下协议才能安装，若不同意，安装程序将立即退出。"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Font = New System.Drawing.Font("黑体", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(22, 56)
        Me.TextBox1.MaxLength = 3276700
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(560, 237)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(506, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "我不同意"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(415, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "我同意"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.Transparent
        Me.Settings.Controls.Add(Me.Label6)
        Me.Settings.Controls.Add(Me.Button4)
        Me.Settings.Controls.Add(Me.InstallLocation)
        Me.Settings.Controls.Add(Me.Label5)
        Me.Settings.Controls.Add(Me.Label4)
        Me.Settings.Location = New System.Drawing.Point(13, 13)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(610, 330)
        Me.Settings.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "安装位置："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(61, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "安装设置"
        '
        'InstallLocation
        '
        Me.InstallLocation.Location = New System.Drawing.Point(134, 136)
        Me.InstallLocation.Name = "InstallLocation"
        Me.InstallLocation.Size = New System.Drawing.Size(386, 21)
        Me.InstallLocation.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(527, 137)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "浏览"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(249, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "大约所需磁盘空间：136MiB"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Installer.My.Resources.Resources.startbg
        Me.ClientSize = New System.Drawing.Size(635, 355)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.LICENSE)
        Me.Controls.Add(Me.Start)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "安装"
        Me.Start.ResumeLayout(False)
        Me.Start.PerformLayout()
        Me.LICENSE.ResumeLayout(False)
        Me.LICENSE.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Start As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LICENSE As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Settings As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents InstallLocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label6 As Label
End Class
