<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateChecking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateChecking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkUpdProcess = New System.ComponentModel.BackgroundWorker()
        Me.CancelUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "正在检查更新..."
        '
        'ChkUpdProcess
        '
        Me.ChkUpdProcess.WorkerReportsProgress = True
        Me.ChkUpdProcess.WorkerSupportsCancellation = True
        '
        'CancelUpdate
        '
        Me.CancelUpdate.Location = New System.Drawing.Point(58, 44)
        Me.CancelUpdate.Name = "CancelUpdate"
        Me.CancelUpdate.Size = New System.Drawing.Size(75, 23)
        Me.CancelUpdate.TabIndex = 1
        Me.CancelUpdate.Text = "取消"
        Me.CancelUpdate.UseVisualStyleBackColor = True
        '
        'UpdateChecking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 79)
        Me.Controls.Add(Me.CancelUpdate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateChecking"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "请稍候..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ChkUpdProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents CancelUpdate As Button
End Class
