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
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstParties = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDem = New System.Windows.Forms.Label()
        Me.lblGOP = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInd = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(283, 3)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(137, 54)
        Me.btnWrite.TabIndex = 0
        Me.btnWrite.Text = "&Write To File"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(283, 63)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(137, 54)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "&Display Totals"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(283, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 54)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstParties
        '
        Me.lstParties.FormattingEnabled = True
        Me.lstParties.Location = New System.Drawing.Point(15, 25)
        Me.lstParties.Name = "lstParties"
        Me.lstParties.Size = New System.Drawing.Size(87, 56)
        Me.lstParties.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&Political Party"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(123, 25)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(72, 20)
        Me.txtAge.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Democrat"
        '
        'lblDem
        '
        Me.lblDem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDem.Location = New System.Drawing.Point(14, 38)
        Me.lblDem.Name = "lblDem"
        Me.lblDem.Size = New System.Drawing.Size(53, 34)
        Me.lblDem.TabIndex = 8
        '
        'lblGOP
        '
        Me.lblGOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGOP.Location = New System.Drawing.Point(89, 38)
        Me.lblGOP.Name = "lblGOP"
        Me.lblGOP.Size = New System.Drawing.Size(53, 34)
        Me.lblGOP.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Republican"
        '
        'lblInd
        '
        Me.lblInd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInd.Location = New System.Drawing.Point(157, 38)
        Me.lblInd.Name = "lblInd"
        Me.lblInd.Size = New System.Drawing.Size(53, 34)
        Me.lblInd.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(154, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Independant"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDem)
        Me.GroupBox1.Controls.Add(Me.lblInd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblGOP)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 88)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstParties)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstParties As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDem As Label
    Friend WithEvents lblGOP As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblInd As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
