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
        Me.components = New System.ComponentModel.Container()
        Me.Green = New System.Windows.Forms.Button()
        Me.black = New System.Windows.Forms.Button()
        Me.Red = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Green
        '
        Me.Green.Location = New System.Drawing.Point(193, 140)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(196, 82)
        Me.Green.TabIndex = 1
        Me.Green.Text = "Green"
        Me.Green.UseVisualStyleBackColor = True
        '
        'black
        '
        Me.black.Location = New System.Drawing.Point(193, 244)
        Me.black.Name = "black"
        Me.black.Size = New System.Drawing.Size(196, 86)
        Me.black.TabIndex = 2
        Me.black.Text = "Black"
        Me.black.UseVisualStyleBackColor = True
        '
        'Red
        '
        Me.Red.Location = New System.Drawing.Point(193, 362)
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(196, 73)
        Me.Red.TabIndex = 3
        Me.Red.Text = "Red"
        Me.Red.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(40, 66)
        Me.Result.Multiline = True
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(451, 68)
        Me.Result.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 461)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Red)
        Me.Controls.Add(Me.black)
        Me.Controls.Add(Me.Green)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Green As System.Windows.Forms.Button
    Friend WithEvents black As System.Windows.Forms.Button
    Friend WithEvents Red As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Result As System.Windows.Forms.TextBox

End Class
