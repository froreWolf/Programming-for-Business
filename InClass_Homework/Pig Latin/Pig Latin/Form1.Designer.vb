<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.lblInputLabel = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutputLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(163, 4)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(97, 23)
        Me.btnTranslate.TabIndex = 0
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'lblInputLabel
        '
        Me.lblInputLabel.AutoSize = True
        Me.lblInputLabel.Location = New System.Drawing.Point(20, 9)
        Me.lblInputLabel.Name = "lblInputLabel"
        Me.lblInputLabel.Size = New System.Drawing.Size(34, 13)
        Me.lblInputLabel.TabIndex = 1
        Me.lblInputLabel.Text = "Input:"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(57, 32)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(57, 5)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(163, 31)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutputLabel
        '
        Me.lblOutputLabel.AutoSize = True
        Me.lblOutputLabel.Location = New System.Drawing.Point(12, 36)
        Me.lblOutputLabel.Name = "lblOutputLabel"
        Me.lblOutputLabel.Size = New System.Drawing.Size(42, 13)
        Me.lblOutputLabel.TabIndex = 5
        Me.lblOutputLabel.Text = "Output:"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnTranslate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 60)
        Me.Controls.Add(Me.lblOutputLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInputLabel)
        Me.Controls.Add(Me.btnTranslate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTranslate As Button
    Friend WithEvents lblInputLabel As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutputLabel As Label
End Class
