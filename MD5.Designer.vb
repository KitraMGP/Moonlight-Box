<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MD5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MD5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GetMD5_File = New System.Windows.Forms.TextBox()
        Me.GetMD5_Explore = New System.Windows.Forms.Button()
        Me.GetMD5_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GetMD5_Result = New System.Windows.Forms.TextBox()
        Me.GetMD5_Run = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "文件路径："
        '
        'GetMD5_File
        '
        Me.GetMD5_File.Location = New System.Drawing.Point(84, 29)
        Me.GetMD5_File.Name = "GetMD5_File"
        Me.GetMD5_File.Size = New System.Drawing.Size(423, 21)
        Me.GetMD5_File.TabIndex = 1
        '
        'GetMD5_Explore
        '
        Me.GetMD5_Explore.Location = New System.Drawing.Point(513, 27)
        Me.GetMD5_Explore.Name = "GetMD5_Explore"
        Me.GetMD5_Explore.Size = New System.Drawing.Size(75, 23)
        Me.GetMD5_Explore.TabIndex = 2
        Me.GetMD5_Explore.Text = "浏览"
        Me.GetMD5_Explore.UseVisualStyleBackColor = True
        '
        'GetMD5_OpenFile
        '
        Me.GetMD5_OpenFile.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MD5："
        '
        'GetMD5_Result
        '
        Me.GetMD5_Result.Location = New System.Drawing.Point(84, 58)
        Me.GetMD5_Result.Name = "GetMD5_Result"
        Me.GetMD5_Result.ReadOnly = True
        Me.GetMD5_Result.Size = New System.Drawing.Size(423, 21)
        Me.GetMD5_Result.TabIndex = 4
        '
        'GetMD5_Run
        '
        Me.GetMD5_Run.Location = New System.Drawing.Point(513, 56)
        Me.GetMD5_Run.Name = "GetMD5_Run"
        Me.GetMD5_Run.Size = New System.Drawing.Size(75, 23)
        Me.GetMD5_Run.TabIndex = 5
        Me.GetMD5_Run.Text = "计算"
        Me.GetMD5_Run.UseVisualStyleBackColor = True
        '
        'MD5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 183)
        Me.Controls.Add(Me.GetMD5_Run)
        Me.Controls.Add(Me.GetMD5_Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GetMD5_Explore)
        Me.Controls.Add(Me.GetMD5_File)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MD5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计算MD5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GetMD5_File As TextBox
    Friend WithEvents GetMD5_Explore As Button
    Friend WithEvents GetMD5_OpenFile As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents GetMD5_Result As TextBox
    Friend WithEvents GetMD5_Run As Button
End Class
