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
        Me.Txt_r = New System.Windows.Forms.TextBox()
        Me.Txt_i = New System.Windows.Forms.TextBox()
        Me.Txt_v = New System.Windows.Forms.TextBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_r
        '
        Me.Txt_r.Location = New System.Drawing.Point(74, 133)
        Me.Txt_r.Name = "Txt_r"
        Me.Txt_r.Size = New System.Drawing.Size(100, 20)
        Me.Txt_r.TabIndex = 0
        '
        'Txt_i
        '
        Me.Txt_i.Location = New System.Drawing.Point(74, 54)
        Me.Txt_i.Name = "Txt_i"
        Me.Txt_i.Size = New System.Drawing.Size(100, 20)
        Me.Txt_i.TabIndex = 1
        '
        'Txt_v
        '
        Me.Txt_v.Location = New System.Drawing.Point(74, 96)
        Me.Txt_v.Name = "Txt_v"
        Me.Txt_v.Size = New System.Drawing.Size(100, 20)
        Me.Txt_v.TabIndex = 2
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(74, 185)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(75, 23)
        Me.calculate.TabIndex = 3
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the I"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the V"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter the R"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calculate)
        Me.Controls.Add(Me.Txt_v)
        Me.Controls.Add(Me.Txt_i)
        Me.Controls.Add(Me.Txt_r)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_r As System.Windows.Forms.TextBox
    Friend WithEvents Txt_i As System.Windows.Forms.TextBox
    Friend WithEvents Txt_v As System.Windows.Forms.TextBox
    Friend WithEvents calculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
