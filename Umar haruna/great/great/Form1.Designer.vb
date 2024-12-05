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
        Me.msgLbl = New System.Windows.Forms.Label()
        Me.Display_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'msgLbl
        '
        Me.msgLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.msgLbl.Location = New System.Drawing.Point(57, 28)
        Me.msgLbl.Name = "msgLbl"
        Me.msgLbl.Size = New System.Drawing.Size(172, 51)
        Me.msgLbl.TabIndex = 0
        '
        'Display_Button
        '
        Me.Display_Button.Location = New System.Drawing.Point(99, 97)
        Me.Display_Button.Name = "Display_Button"
        Me.Display_Button.Size = New System.Drawing.Size(75, 42)
        Me.Display_Button.TabIndex = 1
        Me.Display_Button.Text = "DIsplay"
        Me.Display_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(99, 145)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(75, 38)
        Me.Clear_Button.TabIndex = 2
        Me.Clear_Button.Text = "c&lear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(99, 189)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(74, 41)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Display_Button)
        Me.Controls.Add(Me.msgLbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents msgLbl As System.Windows.Forms.Label
    Friend WithEvents Display_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_Button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button

End Class
