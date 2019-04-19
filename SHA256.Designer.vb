<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHA256
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SHA256))
        Me.GetSHA256_Explore = New System.Windows.Forms.Button()
        Me.GetSHA256_File = New System.Windows.Forms.TextBox()
        Me.GetSHA256_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GetSHA256_Run = New System.Windows.Forms.Button()
        Me.GetSHA256_Result = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GetSHA256_Explore
        '
        Me.GetSHA256_Explore.Location = New System.Drawing.Point(513, 19)
        Me.GetSHA256_Explore.Name = "GetSHA256_Explore"
        Me.GetSHA256_Explore.Size = New System.Drawing.Size(75, 23)
        Me.GetSHA256_Explore.TabIndex = 14
        Me.GetSHA256_Explore.Text = "浏览"
        Me.GetSHA256_Explore.UseVisualStyleBackColor = True
        '
        'GetSHA256_File
        '
        Me.GetSHA256_File.Location = New System.Drawing.Point(84, 21)
        Me.GetSHA256_File.Name = "GetSHA256_File"
        Me.GetSHA256_File.Size = New System.Drawing.Size(423, 21)
        Me.GetSHA256_File.TabIndex = 13
        '
        'GetSHA256_Run
        '
        Me.GetSHA256_Run.Location = New System.Drawing.Point(513, 48)
        Me.GetSHA256_Run.Name = "GetSHA256_Run"
        Me.GetSHA256_Run.Size = New System.Drawing.Size(75, 23)
        Me.GetSHA256_Run.TabIndex = 17
        Me.GetSHA256_Run.Text = "计算"
        Me.GetSHA256_Run.UseVisualStyleBackColor = True
        '
        'GetSHA256_Result
        '
        Me.GetSHA256_Result.Location = New System.Drawing.Point(84, 50)
        Me.GetSHA256_Result.Name = "GetSHA256_Result"
        Me.GetSHA256_Result.ReadOnly = True
        Me.GetSHA256_Result.Size = New System.Drawing.Size(423, 21)
        Me.GetSHA256_Result.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "SHA256："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "文件路径："
        '
        'SHA256
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 91)
        Me.Controls.Add(Me.GetSHA256_Explore)
        Me.Controls.Add(Me.GetSHA256_File)
        Me.Controls.Add(Me.GetSHA256_Run)
        Me.Controls.Add(Me.GetSHA256_Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SHA256"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHA256"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetSHA256_Explore As Button
    Friend WithEvents GetSHA256_File As TextBox
    Friend WithEvents GetSHA256_OpenFile As OpenFileDialog
    Friend WithEvents GetSHA256_Run As Button
    Friend WithEvents GetSHA256_Result As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
