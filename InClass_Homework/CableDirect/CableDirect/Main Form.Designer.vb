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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lstPremium = New System.Windows.Forms.ListBox()
        Me.lstConnections = New System.Windows.Forms.ListBox()
        Me.lblConnections = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.radBus = New System.Windows.Forms.RadioButton()
        Me.radRes = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(109, 154)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 33)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Total &Due"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblPremium
        '
        Me.lblPremium.AutoSize = True
        Me.lblPremium.Location = New System.Drawing.Point(99, 21)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(94, 13)
        Me.lblPremium.TabIndex = 1
        Me.lblPremium.Text = "&Premium Channels"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(9, 141)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalDue.TabIndex = 2
        Me.lblTotalDue.Text = "Total Due:"
        '
        'lstPremium
        '
        Me.lstPremium.FormattingEnabled = True
        Me.lstPremium.Location = New System.Drawing.Point(102, 37)
        Me.lstPremium.Name = "lstPremium"
        Me.lstPremium.Size = New System.Drawing.Size(73, 95)
        Me.lstPremium.TabIndex = 3
        '
        'lstConnections
        '
        Me.lstConnections.FormattingEnabled = True
        Me.lstConnections.Location = New System.Drawing.Point(211, 37)
        Me.lstConnections.Name = "lstConnections"
        Me.lstConnections.Size = New System.Drawing.Size(73, 95)
        Me.lstConnections.TabIndex = 5
        '
        'lblConnections
        '
        Me.lblConnections.AutoSize = True
        Me.lblConnections.Location = New System.Drawing.Point(208, 21)
        Me.lblConnections.Name = "lblConnections"
        Me.lblConnections.Size = New System.Drawing.Size(66, 13)
        Me.lblConnections.TabIndex = 4
        Me.lblConnections.Text = "&Connections"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(223, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(54, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(12, 154)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(91, 33)
        Me.lblOutput.TabIndex = 8
        '
        'radBus
        '
        Me.radBus.AutoSize = True
        Me.radBus.Location = New System.Drawing.Point(6, 37)
        Me.radBus.Name = "radBus"
        Me.radBus.Size = New System.Drawing.Size(67, 17)
        Me.radBus.TabIndex = 9
        Me.radBus.TabStop = True
        Me.radBus.Text = "&Business"
        Me.radBus.UseVisualStyleBackColor = True
        '
        'radRes
        '
        Me.radRes.AutoSize = True
        Me.radRes.Location = New System.Drawing.Point(6, 66)
        Me.radRes.Name = "radRes"
        Me.radRes.Size = New System.Drawing.Size(77, 17)
        Me.radRes.TabIndex = 10
        Me.radRes.TabStop = True
        Me.radRes.Text = "&Residential"
        Me.radRes.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 201)
        Me.Controls.Add(Me.radRes)
        Me.Controls.Add(Me.radBus)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstConnections)
        Me.Controls.Add(Me.lblConnections)
        Me.Controls.Add(Me.lstPremium)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblPremium)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmMain"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPremium As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lstPremium As ListBox
    Friend WithEvents lstConnections As ListBox
    Friend WithEvents lblConnections As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents radBus As RadioButton
    Friend WithEvents radRes As RadioButton
End Class
