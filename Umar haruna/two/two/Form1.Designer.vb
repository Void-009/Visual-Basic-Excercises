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
        Me.displayButton1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enterpinTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'displayButton1
        '
        Me.displayButton1.Location = New System.Drawing.Point(105, 112)
        Me.displayButton1.Name = "displayButton1"
        Me.displayButton1.Size = New System.Drawing.Size(75, 23)
        Me.displayButton1.TabIndex = 0
        Me.displayButton1.Text = "display"
        Me.displayButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "enter the pin"
        '
        'enterpinTextBox1
        '
        Me.enterpinTextBox1.Location = New System.Drawing.Point(90, 54)
        Me.enterpinTextBox1.Name = "enterpinTextBox1"
        Me.enterpinTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.enterpinTextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.enterpinTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.displayButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayButton1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents enterpinTextBox1 As System.Windows.Forms.TextBox

End Class
