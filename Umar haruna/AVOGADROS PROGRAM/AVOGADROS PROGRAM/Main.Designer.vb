<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.v1_btn = New System.Windows.Forms.Button()
        Me.p1_btn = New System.Windows.Forms.Button()
        Me.v2_btn = New System.Windows.Forms.Button()
        Me.p2_btn = New System.Windows.Forms.Button()
        Me.t1_btn = New System.Windows.Forms.Button()
        Me.t2_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'v1_btn
        '
        Me.v1_btn.Location = New System.Drawing.Point(28, 37)
        Me.v1_btn.Name = "v1_btn"
        Me.v1_btn.Size = New System.Drawing.Size(84, 23)
        Me.v1_btn.TabIndex = 0
        Me.v1_btn.Text = "Volume One"
        Me.v1_btn.UseVisualStyleBackColor = True
        '
        'p1_btn
        '
        Me.p1_btn.Location = New System.Drawing.Point(168, 37)
        Me.p1_btn.Name = "p1_btn"
        Me.p1_btn.Size = New System.Drawing.Size(87, 23)
        Me.p1_btn.TabIndex = 2
        Me.p1_btn.Text = "Pressure One"
        Me.p1_btn.UseVisualStyleBackColor = True
        '
        'v2_btn
        '
        Me.v2_btn.Location = New System.Drawing.Point(28, 78)
        Me.v2_btn.Name = "v2_btn"
        Me.v2_btn.Size = New System.Drawing.Size(84, 23)
        Me.v2_btn.TabIndex = 1
        Me.v2_btn.Text = "Volume Two"
        Me.v2_btn.UseVisualStyleBackColor = True
        '
        'p2_btn
        '
        Me.p2_btn.Location = New System.Drawing.Point(168, 78)
        Me.p2_btn.Name = "p2_btn"
        Me.p2_btn.Size = New System.Drawing.Size(87, 23)
        Me.p2_btn.TabIndex = 3
        Me.p2_btn.Text = "Pressure Two"
        Me.p2_btn.UseVisualStyleBackColor = True
        '
        't1_btn
        '
        Me.t1_btn.Location = New System.Drawing.Point(85, 120)
        Me.t1_btn.Name = "t1_btn"
        Me.t1_btn.Size = New System.Drawing.Size(113, 23)
        Me.t1_btn.TabIndex = 4
        Me.t1_btn.Text = "Temperature One"
        Me.t1_btn.UseVisualStyleBackColor = True
        '
        't2_btn
        '
        Me.t2_btn.Location = New System.Drawing.Point(85, 162)
        Me.t2_btn.Name = "t2_btn"
        Me.t2_btn.Size = New System.Drawing.Size(113, 23)
        Me.t2_btn.TabIndex = 5
        Me.t2_btn.Text = "Temperature Two"
        Me.t2_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(180, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AVOGADROS_PROGRAM.My.Resources.Resources.mr_london
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.t2_btn)
        Me.Controls.Add(Me.t1_btn)
        Me.Controls.Add(Me.p2_btn)
        Me.Controls.Add(Me.v2_btn)
        Me.Controls.Add(Me.p1_btn)
        Me.Controls.Add(Me.v1_btn)
        Me.Name = "Main"
        Me.Text = "Main Menu form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents v1_btn As System.Windows.Forms.Button
    Friend WithEvents p1_btn As System.Windows.Forms.Button
    Friend WithEvents v2_btn As System.Windows.Forms.Button
    Friend WithEvents p2_btn As System.Windows.Forms.Button
    Friend WithEvents t1_btn As System.Windows.Forms.Button
    Friend WithEvents t2_btn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
