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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblPrinciple = New System.Windows.Forms.Label()
        Me.picHouse = New System.Windows.Forms.PictureBox()
        Me.txtPrinciple = New System.Windows.Forms.TextBox()
        Me.lstRates = New System.Windows.Forms.ListBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.lblPayments = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrinciple
        '
        Me.lblPrinciple.AutoSize = True
        Me.lblPrinciple.Location = New System.Drawing.Point(134, 30)
        Me.lblPrinciple.Name = "lblPrinciple"
        Me.lblPrinciple.Size = New System.Drawing.Size(47, 13)
        Me.lblPrinciple.TabIndex = 0
        Me.lblPrinciple.Text = "Principle"
        '
        'picHouse
        '
        Me.picHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHouse.Image = CType(resources.GetObject("picHouse.Image"), System.Drawing.Image)
        Me.picHouse.Location = New System.Drawing.Point(21, 26)
        Me.picHouse.Name = "picHouse"
        Me.picHouse.Size = New System.Drawing.Size(95, 115)
        Me.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHouse.TabIndex = 1
        Me.picHouse.TabStop = False
        '
        'txtPrinciple
        '
        Me.txtPrinciple.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinciple.Location = New System.Drawing.Point(134, 46)
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(100, 23)
        Me.txtPrinciple.TabIndex = 2
        '
        'lstRates
        '
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.Location = New System.Drawing.Point(243, 46)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(69, 108)
        Me.lstRates.TabIndex = 3
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(21, 170)
        Me.txtMonthlyPayment.Multiline = True
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(171, 80)
        Me.txtMonthlyPayment.TabIndex = 4
        '
        'lblPayments
        '
        Me.lblPayments.AutoSize = True
        Me.lblPayments.Location = New System.Drawing.Point(28, 154)
        Me.lblPayments.Name = "lblPayments"
        Me.lblPayments.Size = New System.Drawing.Size(88, 13)
        Me.lblPayments.TabIndex = 5
        Me.lblPayments.Text = "Monthly Payment"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(240, 30)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(52, 13)
        Me.lblRate.TabIndex = 6
        Me.lblRate.Text = "Rates (%)"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(207, 163)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 39)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(207, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 259)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblPayments)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.lstRates)
        Me.Controls.Add(Me.txtPrinciple)
        Me.Controls.Add(Me.picHouse)
        Me.Controls.Add(Me.lblPrinciple)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrinciple As Label
    Friend WithEvents picHouse As PictureBox
    Friend WithEvents txtPrinciple As TextBox
    Friend WithEvents lstRates As ListBox
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents lblPayments As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
