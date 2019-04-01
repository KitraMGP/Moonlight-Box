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
        Me.Start_Close = New System.Windows.Forms.PictureBox()
        CType(Me.Start_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start_Close
        '
        Me.Start_Close.BackColor = System.Drawing.Color.Transparent
        Me.Start_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Start_Close.Location = New System.Drawing.Point(902, 12)
        Me.Start_Close.Name = "Start_Close"
        Me.Start_Close.Size = New System.Drawing.Size(30, 33)
        Me.Start_Close.TabIndex = 1
        Me.Start_Close.TabStop = False
        '
        'MainScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.Start_Close)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Start_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Start_Close As PictureBox
End Class
