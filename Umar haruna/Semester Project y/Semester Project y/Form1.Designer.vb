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
        Me.Txt_m = New System.Windows.Forms.TextBox()
        Me.Txt_v = New System.Windows.Forms.TextBox()
        Me.Txt3_h = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_m
        '
        Me.Txt_m.Location = New System.Drawing.Point(98, 53)
        Me.Txt_m.Name = "Txt_m"
        Me.Txt_m.Size = New System.Drawing.Size(100, 20)
        Me.Txt_m.TabIndex = 0
        '
        'Txt_v
        '
        Me.Txt_v.Location = New System.Drawing.Point(98, 92)
        Me.Txt_v.Name = "Txt_v"
        Me.Txt_v.Size = New System.Drawing.Size(100, 20)
        Me.Txt_v.TabIndex = 1
        '
        'Txt3_h
        '
        Me.Txt3_h.Location = New System.Drawing.Point(98, 133)
        Me.Txt3_h.Name = "Txt3_h"
        Me.Txt3_h.Size = New System.Drawing.Size(100, 20)
        Me.Txt3_h.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the M"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter the V"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter the H"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt3_h)
        Me.Controls.Add(Me.Txt_v)
        Me.Controls.Add(Me.Txt_m)
        Me.Name = "Form1"
        Me.Text = "Kinetic and potential energy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_m As System.Windows.Forms.TextBox
    Friend WithEvents Txt_v As System.Windows.Forms.TextBox
    Friend WithEvents Txt3_h As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
