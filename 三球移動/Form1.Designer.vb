<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.yuan1 = New System.Windows.Forms.Label()
        Me.C2 = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.Label()
        Me.yuan3 = New System.Windows.Forms.Label()
        Me.yuan2 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.Label()
        Me.C4 = New System.Windows.Forms.Label()
        Me.C5 = New System.Windows.Forms.Label()
        Me.C6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'yuan1
        '
        Me.yuan1.BackColor = System.Drawing.Color.Transparent
        Me.yuan1.ForeColor = System.Drawing.Color.Red
        Me.yuan1.Location = New System.Drawing.Point(115, 75)
        Me.yuan1.Name = "yuan1"
        Me.yuan1.Size = New System.Drawing.Size(11, 11)
        Me.yuan1.TabIndex = 2
        Me.yuan1.Text = "●"
        Me.yuan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Location = New System.Drawing.Point(66, 9)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(37, 12)
        Me.C2.TabIndex = 4
        Me.C2.Text = "Label1"
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(12, 9)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(37, 12)
        Me.C1.TabIndex = 5
        Me.C1.Text = "Label1"
        '
        'yuan3
        '
        Me.yuan3.BackColor = System.Drawing.Color.Transparent
        Me.yuan3.ForeColor = System.Drawing.Color.Red
        Me.yuan3.Location = New System.Drawing.Point(191, 178)
        Me.yuan3.Name = "yuan3"
        Me.yuan3.Size = New System.Drawing.Size(11, 11)
        Me.yuan3.TabIndex = 6
        Me.yuan3.Text = "●"
        Me.yuan3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'yuan2
        '
        Me.yuan2.BackColor = System.Drawing.Color.Transparent
        Me.yuan2.ForeColor = System.Drawing.Color.Red
        Me.yuan2.Location = New System.Drawing.Point(274, 75)
        Me.yuan2.Name = "yuan2"
        Me.yuan2.Size = New System.Drawing.Size(11, 11)
        Me.yuan2.TabIndex = 7
        Me.yuan2.Text = "●"
        Me.yuan2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Location = New System.Drawing.Point(12, 21)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(37, 12)
        Me.C3.TabIndex = 8
        Me.C3.Text = "Label1"
        '
        'C4
        '
        Me.C4.AutoSize = True
        Me.C4.Location = New System.Drawing.Point(66, 21)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(37, 12)
        Me.C4.TabIndex = 9
        Me.C4.Text = "Label1"
        '
        'C5
        '
        Me.C5.AutoSize = True
        Me.C5.Location = New System.Drawing.Point(12, 33)
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(37, 12)
        Me.C5.TabIndex = 10
        Me.C5.Text = "Label1"
        '
        'C6
        '
        Me.C6.AutoSize = True
        Me.C6.Location = New System.Drawing.Point(66, 33)
        Me.C6.Name = "C6"
        Me.C6.Size = New System.Drawing.Size(37, 12)
        Me.C6.TabIndex = 11
        Me.C6.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 366)
        Me.Controls.Add(Me.C6)
        Me.Controls.Add(Me.C5)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.yuan2)
        Me.Controls.Add(Me.yuan3)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.yuan1)
        Me.Name = "Form1"
        Me.Text = "三球移動"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents yuan1 As System.Windows.Forms.Label
    Friend WithEvents C2 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.Label
    Friend WithEvents yuan3 As System.Windows.Forms.Label
    Friend WithEvents yuan2 As System.Windows.Forms.Label
    Friend WithEvents C3 As System.Windows.Forms.Label
    Friend WithEvents C4 As System.Windows.Forms.Label
    Friend WithEvents C5 As System.Windows.Forms.Label
    Friend WithEvents C6 As System.Windows.Forms.Label

End Class
