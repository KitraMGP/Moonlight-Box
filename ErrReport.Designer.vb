<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorName = New System.Windows.Forms.TextBox()
        Me.ErrorReason = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrReportText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "程序运行时出现异常！请到该项目的Github仓库发送issue！"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "错误名称："
        '
        'ErrorName
        '
        Me.ErrorName.Location = New System.Drawing.Point(107, 44)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.ReadOnly = True
        Me.ErrorName.Size = New System.Drawing.Size(546, 21)
        Me.ErrorName.TabIndex = 2
        '
        'ErrorReason
        '
        Me.ErrorReason.Location = New System.Drawing.Point(107, 81)
        Me.ErrorReason.Name = "ErrorReason"
        Me.ErrorReason.ReadOnly = True
        Me.ErrorReason.Size = New System.Drawing.Size(546, 21)
        Me.ErrorReason.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "可能原因："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "崩溃报告："
        '
        'ErrReportText
        '
        Me.ErrReportText.AcceptsReturn = True
        Me.ErrReportText.AcceptsTab = True
        Me.ErrReportText.Location = New System.Drawing.Point(33, 138)
        Me.ErrReportText.MaxLength = 32767000
        Me.ErrReportText.Multiline = True
        Me.ErrReportText.Name = "ErrReportText"
        Me.ErrReportText.ReadOnly = True
        Me.ErrReportText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ErrReportText.Size = New System.Drawing.Size(620, 186)
        Me.ErrReportText.TabIndex = 6
        Me.ErrReportText.WordWrap = False
        '
        'ErrReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 336)
        Me.Controls.Add(Me.ErrReportText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ErrorReason)
        Me.Controls.Add(Me.ErrorName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出错啦！"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorName As TextBox
    Friend WithEvents ErrorReason As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrReportText As TextBox
End Class
