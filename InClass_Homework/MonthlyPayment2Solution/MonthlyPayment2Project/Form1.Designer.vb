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
        Me.lblrate = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtCurrentVal = New System.Windows.Forms.TextBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Location = New System.Drawing.Point(69, 24)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(67, 15)
        Me.lblrate.TabIndex = 0
        Me.lblrate.Text = "Yearly Rate:"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Location = New System.Drawing.Point(61, 64)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(75, 15)
        Me.lblTerm.TabIndex = 1
        Me.lblTerm.Text = "Term (Years):"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(55, 104)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(81, 15)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "Current Value:"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(150, 20)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(103, 23)
        Me.txtRate.TabIndex = 3
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(150, 60)
        Me.txtTerm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(103, 23)
        Me.txtTerm.TabIndex = 4
        '
        'txtCurrentVal
        '
        Me.txtCurrentVal.Location = New System.Drawing.Point(150, 100)
        Me.txtCurrentVal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCurrentVal.Name = "txtCurrentVal"
        Me.txtCurrentVal.Size = New System.Drawing.Size(103, 23)
        Me.txtCurrentVal.TabIndex = 5
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(31, 142)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(105, 15)
        Me.lblPayment.TabIndex = 6
        Me.lblPayment.Text = "Monthly Payment:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(142, 208)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 81)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(20, 208)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(116, 81)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(150, 141)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(103, 20)
        Me.lblResult.TabIndex = 9
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 319)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.txtCurrentVal)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.lblrate)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "Monthly Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblrate As Label
    Friend WithEvents lblTerm As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtTerm As TextBox
    Friend WithEvents txtCurrentVal As TextBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblResult As Label
End Class
