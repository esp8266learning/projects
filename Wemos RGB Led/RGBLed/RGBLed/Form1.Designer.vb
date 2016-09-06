<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRGBLed
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
        Me.cboPorts = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBlueOff = New System.Windows.Forms.Button()
        Me.btmBlueOn = New System.Windows.Forms.Button()
        Me.btnGreenOff = New System.Windows.Forms.Button()
        Me.btnGreenOn = New System.Windows.Forms.Button()
        Me.btnRedOff = New System.Windows.Forms.Button()
        Me.blnRedOn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboPorts
        '
        Me.cboPorts.FormattingEnabled = True
        Me.cboPorts.Location = New System.Drawing.Point(51, 12)
        Me.cboPorts.Name = "cboPorts"
        Me.cboPorts.Size = New System.Drawing.Size(204, 21)
        Me.cboPorts.TabIndex = 0
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(27, 58)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(116, 49)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "CONNECT"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(170, 58)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(116, 49)
        Me.btnDisconnect.TabIndex = 2
        Me.btnDisconnect.Text = "DISCONNECT"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBlueOff)
        Me.GroupBox1.Controls.Add(Me.btmBlueOn)
        Me.GroupBox1.Controls.Add(Me.btnGreenOff)
        Me.GroupBox1.Controls.Add(Me.btnGreenOn)
        Me.GroupBox1.Controls.Add(Me.btnRedOff)
        Me.GroupBox1.Controls.Add(Me.blnRedOn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 257)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LED Control"
        '
        'btnBlueOff
        '
        Me.btnBlueOff.Location = New System.Drawing.Point(158, 167)
        Me.btnBlueOff.Name = "btnBlueOff"
        Me.btnBlueOff.Size = New System.Drawing.Size(116, 49)
        Me.btnBlueOff.TabIndex = 7
        Me.btnBlueOff.Text = "BLUE Off"
        Me.btnBlueOff.UseVisualStyleBackColor = True
        '
        'btmBlueOn
        '
        Me.btmBlueOn.Location = New System.Drawing.Point(15, 167)
        Me.btmBlueOn.Name = "btmBlueOn"
        Me.btmBlueOn.Size = New System.Drawing.Size(116, 49)
        Me.btmBlueOn.TabIndex = 6
        Me.btmBlueOn.Text = "BLUE On"
        Me.btmBlueOn.UseVisualStyleBackColor = True
        '
        'btnGreenOff
        '
        Me.btnGreenOff.Location = New System.Drawing.Point(158, 99)
        Me.btnGreenOff.Name = "btnGreenOff"
        Me.btnGreenOff.Size = New System.Drawing.Size(116, 49)
        Me.btnGreenOff.TabIndex = 5
        Me.btnGreenOff.Text = "GREEN Off"
        Me.btnGreenOff.UseVisualStyleBackColor = True
        '
        'btnGreenOn
        '
        Me.btnGreenOn.Location = New System.Drawing.Point(15, 99)
        Me.btnGreenOn.Name = "btnGreenOn"
        Me.btnGreenOn.Size = New System.Drawing.Size(116, 49)
        Me.btnGreenOn.TabIndex = 4
        Me.btnGreenOn.Text = "GREEN On"
        Me.btnGreenOn.UseVisualStyleBackColor = True
        '
        'btnRedOff
        '
        Me.btnRedOff.Location = New System.Drawing.Point(158, 32)
        Me.btnRedOff.Name = "btnRedOff"
        Me.btnRedOff.Size = New System.Drawing.Size(116, 49)
        Me.btnRedOff.TabIndex = 3
        Me.btnRedOff.Text = "RED Off"
        Me.btnRedOff.UseVisualStyleBackColor = True
        '
        'blnRedOn
        '
        Me.blnRedOn.Location = New System.Drawing.Point(15, 32)
        Me.blnRedOn.Name = "blnRedOn"
        Me.blnRedOn.Size = New System.Drawing.Size(116, 49)
        Me.blnRedOn.TabIndex = 2
        Me.blnRedOn.Text = "RED On"
        Me.blnRedOn.UseVisualStyleBackColor = True
        '
        'frmRGBLed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cboPorts)
        Me.Name = "frmRGBLed"
        Me.Text = "RGB LED Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboPorts As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBlueOff As System.Windows.Forms.Button
    Friend WithEvents btmBlueOn As System.Windows.Forms.Button
    Friend WithEvents btnGreenOff As System.Windows.Forms.Button
    Friend WithEvents btnGreenOn As System.Windows.Forms.Button
    Friend WithEvents btnRedOff As System.Windows.Forms.Button
    Friend WithEvents blnRedOn As System.Windows.Forms.Button

End Class
