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
        Me.txtLon1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLat1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLat2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLon2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLon1
        '
        Me.txtLon1.Location = New System.Drawing.Point(88, 5)
        Me.txtLon1.Name = "txtLon1"
        Me.txtLon1.Size = New System.Drawing.Size(116, 23)
        Me.txtLon1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Longitude 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Latitude 1"
        '
        'txtLat1
        '
        Me.txtLat1.Location = New System.Drawing.Point(88, 35)
        Me.txtLat1.Name = "txtLat1"
        Me.txtLat1.Size = New System.Drawing.Size(116, 23)
        Me.txtLat1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Latitude 2"
        '
        'txtLat2
        '
        Me.txtLat2.Location = New System.Drawing.Point(88, 95)
        Me.txtLat2.Name = "txtLat2"
        Me.txtLat2.Size = New System.Drawing.Size(116, 23)
        Me.txtLat2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Longitude 2"
        '
        'txtLon2
        '
        Me.txtLon2.Location = New System.Drawing.Point(88, 65)
        Me.txtLon2.Name = "txtLon2"
        Me.txtLon2.Size = New System.Drawing.Size(116, 23)
        Me.txtLon2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Calculate Distance"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(210, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(218, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "E&xit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblDistance
        '
        Me.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDistance.Location = New System.Drawing.Point(210, 92)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(221, 23)
        Me.lblDistance.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Distance:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 129)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLat2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLon2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLat1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLon1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Distance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLon1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLat1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLat2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLon2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblDistance As Label
    Friend WithEvents Label5 As Label
End Class
