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
        Me.lstUsefulLife = New System.Windows.Forms.ListBox()
        Me.txtSalvageValue = New System.Windows.Forms.TextBox()
        Me.txtAssetCost = New System.Windows.Forms.TextBox()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.lblAssetCost = New System.Windows.Forms.Label()
        Me.lblUsefulLife = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.lblSalvage = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstUsefulLife
        '
        Me.lstUsefulLife.FormattingEnabled = True
        Me.lstUsefulLife.ItemHeight = 15
        Me.lstUsefulLife.Location = New System.Drawing.Point(140, 54)
        Me.lstUsefulLife.Name = "lstUsefulLife"
        Me.lstUsefulLife.Size = New System.Drawing.Size(60, 109)
        Me.lstUsefulLife.TabIndex = 3
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Location = New System.Drawing.Point(208, 54)
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.Size = New System.Drawing.Size(97, 23)
        Me.txtSalvageValue.TabIndex = 5
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Location = New System.Drawing.Point(35, 54)
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.Size = New System.Drawing.Size(97, 23)
        Me.txtAssetCost.TabIndex = 1
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(28, 199)
        Me.txtSchedule.Multiline = True
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.ReadOnly = True
        Me.txtSchedule.Size = New System.Drawing.Size(277, 137)
        Me.txtSchedule.TabIndex = 3
        '
        'lblAssetCost
        '
        Me.lblAssetCost.AutoSize = True
        Me.lblAssetCost.Location = New System.Drawing.Point(35, 36)
        Me.lblAssetCost.Name = "lblAssetCost"
        Me.lblAssetCost.Size = New System.Drawing.Size(65, 15)
        Me.lblAssetCost.TabIndex = 0
        Me.lblAssetCost.Text = "&Asset Cost:"
        '
        'lblUsefulLife
        '
        Me.lblUsefulLife.AutoSize = True
        Me.lblUsefulLife.Location = New System.Drawing.Point(137, 36)
        Me.lblUsefulLife.Name = "lblUsefulLife"
        Me.lblUsefulLife.Size = New System.Drawing.Size(65, 15)
        Me.lblUsefulLife.TabIndex = 2
        Me.lblUsefulLife.Text = "&Useful Life:"
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Location = New System.Drawing.Point(25, 181)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(128, 15)
        Me.lblSchedule.TabIndex = 2
        Me.lblSchedule.Text = "Depreciation Schedule:"
        '
        'lblSalvage
        '
        Me.lblSalvage.AutoSize = True
        Me.lblSalvage.Location = New System.Drawing.Point(215, 36)
        Me.lblSalvage.Name = "lblSalvage"
        Me.lblSalvage.Size = New System.Drawing.Size(81, 15)
        Me.lblSalvage.TabIndex = 4
        Me.lblSalvage.Text = "S&alvage Value:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(28, 371)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(189, 48)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "&Display Depreciating Value"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(227, 371)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 48)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 432)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblSalvage)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.lblUsefulLife)
        Me.Controls.Add(Me.lblAssetCost)
        Me.Controls.Add(Me.txtSchedule)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.lstUsefulLife)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Sonheim Manufacturing Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstUsefulLife As ListBox
    Friend WithEvents txtSalvageValue As TextBox
    Friend WithEvents txtAssetCost As TextBox
    Friend WithEvents txtSchedule As TextBox
    Friend WithEvents lblAssetCost As Label
    Friend WithEvents lblUsefulLife As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblSalvage As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
