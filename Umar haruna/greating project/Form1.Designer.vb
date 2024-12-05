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
        Me.massageLbl = New System.Windows.Forms.Label()
        Me.Display_botton = New System.Windows.Forms.Button()
        Me.Clear_button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'massageLbl
        '
        Me.massageLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.massageLbl.Location = New System.Drawing.Point(61, 28)
        Me.massageLbl.Name = "massageLbl"
        Me.massageLbl.Size = New System.Drawing.Size(161, 60)
        Me.massageLbl.TabIndex = 0
        '
        'Display_botton
        '
        Me.Display_botton.Location = New System.Drawing.Point(103, 117)
        Me.Display_botton.Name = "Display_botton"
        Me.Display_botton.Size = New System.Drawing.Size(75, 23)
        Me.Display_botton.TabIndex = 1
        Me.Display_botton.Text = "Display"
        Me.Display_botton.UseVisualStyleBackColor = True
        '
        'Clear_button
        '
        Me.Clear_button.Location = New System.Drawing.Point(103, 159)
        Me.Clear_button.Name = "Clear_button"
        Me.Clear_button.Size = New System.Drawing.Size(75, 23)
        Me.Clear_button.TabIndex = 2
        Me.Clear_button.Text = "Clear"
        Me.Clear_button.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(103, 202)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
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
        Me.Controls.Add(Me.Clear_button)
        Me.Controls.Add(Me.Display_botton)
        Me.Controls.Add(Me.massageLbl)
        Me.Enabled = False
        Me.Name = "Form1"
        Me.Text = "Greting"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents massageLbl As System.Windows.Forms.Label
    Friend WithEvents Display_botton As System.Windows.Forms.Button
    Friend WithEvents Clear_button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button

End Class
