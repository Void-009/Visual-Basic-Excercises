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
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsqure = New System.Windows.Forms.Button()
        Me.txtsqure = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtL
        '
        Me.txtL.BackColor = System.Drawing.SystemColors.Info
        Me.txtL.Location = New System.Drawing.Point(74, 64)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(100, 20)
        Me.txtL.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "L="
        '
        'btnsqure
        '
        Me.btnsqure.Location = New System.Drawing.Point(86, 119)
        Me.btnsqure.Name = "btnsqure"
        Me.btnsqure.Size = New System.Drawing.Size(75, 23)
        Me.btnsqure.TabIndex = 3
        Me.btnsqure.Text = "square"
        Me.btnsqure.UseVisualStyleBackColor = True
        '
        'txtsqure
        '
        Me.txtsqure.Location = New System.Drawing.Point(74, 166)
        Me.txtsqure.Name = "txtsqure"
        Me.txtsqure.Size = New System.Drawing.Size(100, 20)
        Me.txtsqure.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtsqure)
        Me.Controls.Add(Me.btnsqure)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsqure As System.Windows.Forms.Button
    Friend WithEvents txtsqure As System.Windows.Forms.TextBox

End Class
