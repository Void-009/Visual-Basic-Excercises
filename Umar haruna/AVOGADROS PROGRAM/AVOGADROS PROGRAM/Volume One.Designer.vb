﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V1_F1
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
        Me.t2_txt = New System.Windows.Forms.TextBox()
        Me.p1_txt = New System.Windows.Forms.TextBox()
        Me.t1_txt = New System.Windows.Forms.TextBox()
        Me.v2_txt = New System.Windows.Forms.TextBox()
        Me.p2_txt = New System.Windows.Forms.TextBox()
        Me.compute_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Please Enter T2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Please Enter P1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Please Enter T1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Please Enter V2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Please Enter P2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        't2_txt
        '
        Me.t2_txt.Location = New System.Drawing.Point(114, 267)
        Me.t2_txt.Name = "t2_txt"
        Me.t2_txt.Size = New System.Drawing.Size(100, 20)
        Me.t2_txt.TabIndex = 4
        '
        'p1_txt
        '
        Me.p1_txt.Location = New System.Drawing.Point(114, 226)
        Me.p1_txt.Name = "p1_txt"
        Me.p1_txt.Size = New System.Drawing.Size(100, 20)
        Me.p1_txt.TabIndex = 3
        '
        't1_txt
        '
        Me.t1_txt.Location = New System.Drawing.Point(114, 186)
        Me.t1_txt.Name = "t1_txt"
        Me.t1_txt.Size = New System.Drawing.Size(100, 20)
        Me.t1_txt.TabIndex = 2
        '
        'v2_txt
        '
        Me.v2_txt.Location = New System.Drawing.Point(114, 146)
        Me.v2_txt.Name = "v2_txt"
        Me.v2_txt.Size = New System.Drawing.Size(100, 20)
        Me.v2_txt.TabIndex = 1
        '
        'p2_txt
        '
        Me.p2_txt.Location = New System.Drawing.Point(114, 108)
        Me.p2_txt.Name = "p2_txt"
        Me.p2_txt.Size = New System.Drawing.Size(100, 20)
        Me.p2_txt.TabIndex = 0
        '
        'compute_btn
        '
        Me.compute_btn.Location = New System.Drawing.Point(28, 300)
        Me.compute_btn.Name = "compute_btn"
        Me.compute_btn.Size = New System.Drawing.Size(75, 23)
        Me.compute_btn.TabIndex = 5
        Me.compute_btn.Text = "Calculate"
        Me.compute_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 56)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "P2*V1*T2/P2*T1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'V1_F1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AVOGADROS_PROGRAM.My.Resources.Resources.rose
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 349)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.t2_txt)
        Me.Controls.Add(Me.p1_txt)
        Me.Controls.Add(Me.t1_txt)
        Me.Controls.Add(Me.v2_txt)
        Me.Controls.Add(Me.p2_txt)
        Me.Controls.Add(Me.compute_btn)
        Me.Name = "V1_F1"
        Me.Text = "VOLUME ONE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents t2_txt As System.Windows.Forms.TextBox
    Friend WithEvents p1_txt As System.Windows.Forms.TextBox
    Friend WithEvents t1_txt As System.Windows.Forms.TextBox
    Friend WithEvents v2_txt As System.Windows.Forms.TextBox
    Friend WithEvents p2_txt As System.Windows.Forms.TextBox
    Friend WithEvents compute_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
