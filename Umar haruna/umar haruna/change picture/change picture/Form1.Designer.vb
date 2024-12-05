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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sunset = New System.Windows.Forms.RadioButton()
        Me.waterlilies = New System.Windows.Forms.RadioButton()
        Me.winter = New System.Windows.Forms.RadioButton()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.winter)
        Me.GroupBox1.Controls.Add(Me.waterlilies)
        Me.GroupBox1.Controls.Add(Me.sunset)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 369)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Picture To Display"
        '
        'sunset
        '
        Me.sunset.AutoSize = True
        Me.sunset.Location = New System.Drawing.Point(17, 24)
        Me.sunset.Name = "sunset"
        Me.sunset.Size = New System.Drawing.Size(58, 17)
        Me.sunset.TabIndex = 0
        Me.sunset.TabStop = True
        Me.sunset.Text = "&Sunset"
        Me.sunset.UseVisualStyleBackColor = True
        '
        'waterlilies
        '
        Me.waterlilies.AutoSize = True
        Me.waterlilies.ImageKey = "(none)"
        Me.waterlilies.Location = New System.Drawing.Point(141, 24)
        Me.waterlilies.Name = "waterlilies"
        Me.waterlilies.Size = New System.Drawing.Size(76, 17)
        Me.waterlilies.TabIndex = 1
        Me.waterlilies.TabStop = True
        Me.waterlilies.Text = "Water lilies"
        Me.waterlilies.UseVisualStyleBackColor = True
        '
        'winter
        '
        Me.winter.AutoSize = True
        Me.winter.Location = New System.Drawing.Point(253, 24)
        Me.winter.Name = "winter"
        Me.winter.Size = New System.Drawing.Size(90, 17)
        Me.winter.TabIndex = 2
        Me.winter.TabStop = True
        Me.winter.Text = "Winter Scene"
        Me.winter.UseVisualStyleBackColor = True
        '
        'photo
        '
        Me.photo.Location = New System.Drawing.Point(32, 48)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(362, 275)
        Me.photo.TabIndex = 0
        Me.photo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 522)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.photo)
        Me.Name = "Form1"
        Me.Text = "Change  Picture"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents photo As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents winter As System.Windows.Forms.RadioButton
    Friend WithEvents waterlilies As System.Windows.Forms.RadioButton
    Friend WithEvents sunset As System.Windows.Forms.RadioButton

End Class
