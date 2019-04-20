<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateDialog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DownloadUpdate = New System.Windows.Forms.Button()
        Me.ChangeLogBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "发现新版本"
        '
        'DownloadUpdate
        '
        Me.DownloadUpdate.Location = New System.Drawing.Point(539, 294)
        Me.DownloadUpdate.Name = "DownloadUpdate"
        Me.DownloadUpdate.Size = New System.Drawing.Size(75, 23)
        Me.DownloadUpdate.TabIndex = 1
        Me.DownloadUpdate.Text = "下载"
        Me.DownloadUpdate.UseVisualStyleBackColor = True
        '
        'ChangeLogBox
        '
        Me.ChangeLogBox.AcceptsReturn = True
        Me.ChangeLogBox.Location = New System.Drawing.Point(38, 51)
        Me.ChangeLogBox.MaxLength = 9999999
        Me.ChangeLogBox.Multiline = True
        Me.ChangeLogBox.Name = "ChangeLogBox"
        Me.ChangeLogBox.ReadOnly = True
        Me.ChangeLogBox.Size = New System.Drawing.Size(576, 227)
        Me.ChangeLogBox.TabIndex = 2
        '
        'UpdateDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 329)
        Me.Controls.Add(Me.ChangeLogBox)
        Me.Controls.Add(Me.DownloadUpdate)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateDialog"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "发现更新"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DownloadUpdate As Button
    Friend WithEvents ChangeLogBox As TextBox
End Class
