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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberSold = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFullTime = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPartTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNewCar = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUsedCar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(111, 25)
        Me.txtID.MaxLength = 4
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(75, 20)
        Me.txtID.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(111, 51)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 62)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 51)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumberSold
        '
        Me.txtNumberSold.Location = New System.Drawing.Point(192, 25)
        Me.txtNumberSold.Name = "txtNumberSold"
        Me.txtNumberSold.Size = New System.Drawing.Size(75, 20)
        Me.txtNumberSold.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Number Sold"
        '
        'lblFullTime
        '
        Me.lblFullTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullTime.Location = New System.Drawing.Point(189, 88)
        Me.lblFullTime.Name = "lblFullTime"
        Me.lblFullTime.Size = New System.Drawing.Size(68, 21)
        Me.lblFullTime.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cars sold by full-time employees:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cars sold by part-time employees:"
        '
        'lblPartTime
        '
        Me.lblPartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartTime.Location = New System.Drawing.Point(189, 118)
        Me.lblPartTime.Name = "lblPartTime"
        Me.lblPartTime.Size = New System.Drawing.Size(68, 21)
        Me.lblPartTime.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cars sold by new car employees:"
        '
        'lblNewCar
        '
        Me.lblNewCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewCar.Location = New System.Drawing.Point(189, 148)
        Me.lblNewCar.Name = "lblNewCar"
        Me.lblNewCar.Size = New System.Drawing.Size(68, 21)
        Me.lblNewCar.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cars sold by used car employees:"
        '
        'lblUsedCar
        '
        Me.lblUsedCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsedCar.Location = New System.Drawing.Point(189, 178)
        Me.lblUsedCar.Name = "lblUsedCar"
        Me.lblUsedCar.Size = New System.Drawing.Size(68, 21)
        Me.lblUsedCar.TabIndex = 14
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 214)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblUsedCar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNewCar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPartTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFullTime)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtNumberSold)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Huntington Motors"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNumberSold As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFullTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPartTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNewCar As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblUsedCar As Label
End Class
