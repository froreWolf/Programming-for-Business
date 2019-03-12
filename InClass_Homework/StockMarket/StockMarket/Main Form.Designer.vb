<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblIncrease = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDecrease = New System.Windows.Forms.Label()
        Me.lblSame = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(186, 11)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(115, 36)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "&Calculate Results"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Days Increased:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 53)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 36)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblIncrease
        '
        Me.lblIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncrease.Location = New System.Drawing.Point(110, 14)
        Me.lblIncrease.Name = "lblIncrease"
        Me.lblIncrease.Size = New System.Drawing.Size(55, 22)
        Me.lblIncrease.TabIndex = 3
        Me.lblIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Days Decreased:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Days Same:"
        '
        'lblDecrease
        '
        Me.lblDecrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDecrease.Location = New System.Drawing.Point(110, 52)
        Me.lblDecrease.Name = "lblDecrease"
        Me.lblDecrease.Size = New System.Drawing.Size(55, 22)
        Me.lblDecrease.TabIndex = 6
        Me.lblDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSame
        '
        Me.lblSame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSame.Location = New System.Drawing.Point(110, 90)
        Me.lblSame.Name = "lblSame"
        Me.lblSame.Size = New System.Drawing.Size(55, 22)
        Me.lblSame.TabIndex = 7
        Me.lblSame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(110, 128)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(55, 22)
        Me.lblAverage.TabIndex = 9
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Stock Average"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 167)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblSame)
        Me.Controls.Add(Me.lblDecrease)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblIncrease)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRun)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Stock Market"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRun As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblIncrease As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDecrease As Label
    Friend WithEvents lblSame As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents Label8 As Label
End Class
