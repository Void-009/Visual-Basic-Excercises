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
        Me.AreaButton1 = New System.Windows.Forms.Button()
        Me.CircButton2 = New System.Windows.Forms.Button()
        Me.ExitButton3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ResultTextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AreaButton1
        '
        Me.AreaButton1.Location = New System.Drawing.Point(183, 136)
        Me.AreaButton1.Name = "AreaButton1"
        Me.AreaButton1.Size = New System.Drawing.Size(75, 23)
        Me.AreaButton1.TabIndex = 0
        Me.AreaButton1.Text = "Area"
        Me.AreaButton1.UseVisualStyleBackColor = True
        '
        'CircButton2
        '
        Me.CircButton2.Location = New System.Drawing.Point(183, 165)
        Me.CircButton2.Name = "CircButton2"
        Me.CircButton2.Size = New System.Drawing.Size(75, 23)
        Me.CircButton2.TabIndex = 1
        Me.CircButton2.Text = "Circomference"
        Me.CircButton2.UseVisualStyleBackColor = True
        '
        'ExitButton3
        '
        Me.ExitButton3.Location = New System.Drawing.Point(183, 193)
        Me.ExitButton3.Name = "ExitButton3"
        Me.ExitButton3.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton3.TabIndex = 2
        Me.ExitButton3.Text = "Exit"
        Me.ExitButton3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 3
        '
        'ResultTextBox2
        '
        Me.ResultTextBox2.Location = New System.Drawing.Point(68, 26)
        Me.ResultTextBox2.Name = "ResultTextBox2"
        Me.ResultTextBox2.Size = New System.Drawing.Size(142, 20)
        Me.ResultTextBox2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ResultTextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ExitButton3)
        Me.Controls.Add(Me.CircButton2)
        Me.Controls.Add(Me.AreaButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AreaButton1 As System.Windows.Forms.Button
    Friend WithEvents CircButton2 As System.Windows.Forms.Button
    Friend WithEvents ExitButton3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ResultTextBox2 As System.Windows.Forms.TextBox

End Class
