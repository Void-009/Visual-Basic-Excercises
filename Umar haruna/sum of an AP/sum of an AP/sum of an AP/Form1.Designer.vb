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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ntxt = New System.Windows.Forms.TextBox()
        Me.dtxt = New System.Windows.Forms.TextBox()
        Me.rslttxt = New System.Windows.Forms.TextBox()
        Me.calbtn = New System.Windows.Forms.Button()
        Me.atxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.atxt)
        Me.GroupBox1.Controls.Add(Me.dtxt)
        Me.GroupBox1.Controls.Add(Me.ntxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "input values here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "enter the value of a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "enter the value of n"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "enter the value of d"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'ntxt
        '
        Me.ntxt.Location = New System.Drawing.Point(164, 80)
        Me.ntxt.Name = "ntxt"
        Me.ntxt.Size = New System.Drawing.Size(100, 20)
        Me.ntxt.TabIndex = 4
        '
        'dtxt
        '
        Me.dtxt.Location = New System.Drawing.Point(301, 80)
        Me.dtxt.Name = "dtxt"
        Me.dtxt.Size = New System.Drawing.Size(100, 20)
        Me.dtxt.TabIndex = 5
        '
        'rslttxt
        '
        Me.rslttxt.Location = New System.Drawing.Point(42, 256)
        Me.rslttxt.Multiline = True
        Me.rslttxt.Name = "rslttxt"
        Me.rslttxt.Size = New System.Drawing.Size(100, 106)
        Me.rslttxt.TabIndex = 6
        '
        'calbtn
        '
        Me.calbtn.Location = New System.Drawing.Point(313, 308)
        Me.calbtn.Name = "calbtn"
        Me.calbtn.Size = New System.Drawing.Size(75, 23)
        Me.calbtn.TabIndex = 1
        Me.calbtn.Text = "calculate"
        Me.calbtn.UseVisualStyleBackColor = True
        '
        'atxt
        '
        Me.atxt.Location = New System.Drawing.Point(30, 80)
        Me.atxt.Name = "atxt"
        Me.atxt.Size = New System.Drawing.Size(100, 20)
        Me.atxt.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 437)
        Me.Controls.Add(Me.rslttxt)
        Me.Controls.Add(Me.calbtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "sum of an AP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents atxt As System.Windows.Forms.TextBox
    Friend WithEvents dtxt As System.Windows.Forms.TextBox
    Friend WithEvents ntxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rslttxt As System.Windows.Forms.TextBox
    Friend WithEvents calbtn As System.Windows.Forms.Button

End Class
