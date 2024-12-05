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
        Me.GroupBox_one = New System.Windows.Forms.GroupBox()
        Me.gray = New System.Windows.Forms.RadioButton()
        Me.Yellow = New System.Windows.Forms.RadioButton()
        Me.Blue = New System.Windows.Forms.RadioButton()
        Me.Red = New System.Windows.Forms.RadioButton()
        Me.GroupBox_two = New System.Windows.Forms.GroupBox()
        Me.white = New System.Windows.Forms.RadioButton()
        Me.BLack = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_one.SuspendLayout()
        Me.GroupBox_two.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox_one
        '
        Me.GroupBox_one.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox_one.Controls.Add(Me.gray)
        Me.GroupBox_one.Controls.Add(Me.Yellow)
        Me.GroupBox_one.Controls.Add(Me.Blue)
        Me.GroupBox_one.Controls.Add(Me.Red)
        Me.GroupBox_one.Location = New System.Drawing.Point(65, 48)
        Me.GroupBox_one.Name = "GroupBox_one"
        Me.GroupBox_one.Size = New System.Drawing.Size(211, 132)
        Me.GroupBox_one.TabIndex = 0
        Me.GroupBox_one.TabStop = False
        Me.GroupBox_one.Text = "Form Background Color"
        '
        'gray
        '
        Me.gray.AutoSize = True
        Me.gray.ForeColor = System.Drawing.Color.Yellow
        Me.gray.Location = New System.Drawing.Point(31, 97)
        Me.gray.Name = "gray"
        Me.gray.Size = New System.Drawing.Size(55, 17)
        Me.gray.TabIndex = 3
        Me.gray.TabStop = True
        Me.gray.Text = "GRAY"
        Me.gray.UseVisualStyleBackColor = True
        '
        'Yellow
        '
        Me.Yellow.AutoSize = True
        Me.Yellow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Yellow.Location = New System.Drawing.Point(31, 74)
        Me.Yellow.Name = "Yellow"
        Me.Yellow.Size = New System.Drawing.Size(70, 17)
        Me.Yellow.TabIndex = 2
        Me.Yellow.TabStop = True
        Me.Yellow.Text = "YELLOW"
        Me.Yellow.UseVisualStyleBackColor = True
        '
        'Blue
        '
        Me.Blue.AutoSize = True
        Me.Blue.ForeColor = System.Drawing.Color.Blue
        Me.Blue.Location = New System.Drawing.Point(31, 51)
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(53, 17)
        Me.Blue.TabIndex = 1
        Me.Blue.TabStop = True
        Me.Blue.Text = "BLUE"
        Me.Blue.UseVisualStyleBackColor = True
        '
        'Red
        '
        Me.Red.AutoSize = True
        Me.Red.ForeColor = System.Drawing.Color.Red
        Me.Red.Location = New System.Drawing.Point(31, 28)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(48, 17)
        Me.Red.TabIndex = 0
        Me.Red.TabStop = True
        Me.Red.Text = "RED"
        Me.Red.UseVisualStyleBackColor = True
        '
        'GroupBox_two
        '
        Me.GroupBox_two.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox_two.Controls.Add(Me.white)
        Me.GroupBox_two.Controls.Add(Me.BLack)
        Me.GroupBox_two.Location = New System.Drawing.Point(65, 240)
        Me.GroupBox_two.Name = "GroupBox_two"
        Me.GroupBox_two.Size = New System.Drawing.Size(211, 97)
        Me.GroupBox_two.TabIndex = 0
        Me.GroupBox_two.TabStop = False
        Me.GroupBox_two.Text = "Select Text Color"
        '
        'white
        '
        Me.white.AutoSize = True
        Me.white.ForeColor = System.Drawing.Color.White
        Me.white.Location = New System.Drawing.Point(31, 42)
        Me.white.Name = "white"
        Me.white.Size = New System.Drawing.Size(61, 17)
        Me.white.TabIndex = 1
        Me.white.TabStop = True
        Me.white.Text = "WHITE"
        Me.white.UseVisualStyleBackColor = True
        '
        'BLack
        '
        Me.BLack.AutoSize = True
        Me.BLack.ForeColor = System.Drawing.Color.Black
        Me.BLack.Location = New System.Drawing.Point(31, 19)
        Me.BLack.Name = "BLack"
        Me.BLack.Size = New System.Drawing.Size(59, 17)
        Me.BLack.TabIndex = 0
        Me.BLack.TabStop = True
        Me.BLack.Text = "BLACK"
        Me.BLack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.change_color.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(350, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(493, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox_two)
        Me.Controls.Add(Me.GroupBox_one)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox_one.ResumeLayout(False)
        Me.GroupBox_one.PerformLayout()
        Me.GroupBox_two.ResumeLayout(False)
        Me.GroupBox_two.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_one As System.Windows.Forms.GroupBox
    Friend WithEvents gray As System.Windows.Forms.RadioButton
    Friend WithEvents Yellow As System.Windows.Forms.RadioButton
    Friend WithEvents Blue As System.Windows.Forms.RadioButton
    Friend WithEvents Red As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_two As System.Windows.Forms.GroupBox
    Friend WithEvents white As System.Windows.Forms.RadioButton
    Friend WithEvents BLack As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
