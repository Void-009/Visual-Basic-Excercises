﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T2_F6
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.v1_txt = New System.Windows.Forms.TextBox()
        Me.p1_txt = New System.Windows.Forms.TextBox()
        Me.t1_txt = New System.Windows.Forms.TextBox()
        Me.v2_txt = New System.Windows.Forms.TextBox()
        Me.p2_txt = New System.Windows.Forms.TextBox()
        Me.cal_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Please Enter V1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Please Enter P1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Please Enter T1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Please Enter V2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Please Enter P2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'v1_txt
        '
        Me.v1_txt.Location = New System.Drawing.Point(114, 264)
        Me.v1_txt.Name = "v1_txt"
        Me.v1_txt.Size = New System.Drawing.Size(100, 20)
        Me.v1_txt.TabIndex = 4
        '
        'p1_txt
        '
        Me.p1_txt.Location = New System.Drawing.Point(114, 223)
        Me.p1_txt.Name = "p1_txt"
        Me.p1_txt.Size = New System.Drawing.Size(100, 20)
        Me.p1_txt.TabIndex = 3
        '
        't1_txt
        '
        Me.t1_txt.Location = New System.Drawing.Point(114, 183)
        Me.t1_txt.Name = "t1_txt"
        Me.t1_txt.Size = New System.Drawing.Size(100, 20)
        Me.t1_txt.TabIndex = 2
        '
        'v2_txt
        '
        Me.v2_txt.Location = New System.Drawing.Point(114, 143)
        Me.v2_txt.Name = "v2_txt"
        Me.v2_txt.Size = New System.Drawing.Size(100, 20)
        Me.v2_txt.TabIndex = 1
        '
        'p2_txt
        '
        Me.p2_txt.Location = New System.Drawing.Point(114, 105)
        Me.p2_txt.Name = "p2_txt"
        Me.p2_txt.Size = New System.Drawing.Size(100, 20)
        Me.p2_txt.TabIndex = 0
        '
        'cal_btn
        '
        Me.cal_btn.Location = New System.Drawing.Point(28, 297)
        Me.cal_btn.Name = "cal_btn"
        Me.cal_btn.Size = New System.Drawing.Size(75, 23)
        Me.cal_btn.TabIndex = 5
        Me.cal_btn.Text = "Calculate"
        Me.cal_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Lime
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Wide Latin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 56)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "T2=P2*V2*T1/P1*V1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T2_F6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AVOGADROS_PROGRAM.My.Resources.Resources.take_a_look
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 346)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.v1_txt)
        Me.Controls.Add(Me.p1_txt)
        Me.Controls.Add(Me.t1_txt)
        Me.Controls.Add(Me.v2_txt)
        Me.Controls.Add(Me.p2_txt)
        Me.Controls.Add(Me.cal_btn)
        Me.Name = "T2_F6"
        Me.Text = "TEMPERATURE TWO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents v1_txt As System.Windows.Forms.TextBox
    Friend WithEvents p1_txt As System.Windows.Forms.TextBox
    Friend WithEvents t1_txt As System.Windows.Forms.TextBox
    Friend WithEvents v2_txt As System.Windows.Forms.TextBox
    Friend WithEvents p2_txt As System.Windows.Forms.TextBox
    Friend WithEvents cal_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
