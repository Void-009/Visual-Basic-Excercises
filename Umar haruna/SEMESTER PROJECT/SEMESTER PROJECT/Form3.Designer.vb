<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.pr_btn = New System.Windows.Forms.Button()
        Me.cl_btn = New System.Windows.Forms.Button()
        Me.TextBox4_p = New System.Windows.Forms.TextBox()
        Me.TextBox3_t = New System.Windows.Forms.TextBox()
        Me.TextBox2_r = New System.Windows.Forms.TextBox()
        Me.TextBox1_n = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calculat_btn = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'pr_btn
        '
        Me.pr_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.pr_btn.Location = New System.Drawing.Point(191, 219)
        Me.pr_btn.Name = "pr_btn"
        Me.pr_btn.Size = New System.Drawing.Size(75, 23)
        Me.pr_btn.TabIndex = 6
        Me.pr_btn.Text = "Print"
        Me.pr_btn.UseVisualStyleBackColor = True
        '
        'cl_btn
        '
        Me.cl_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cl_btn.Location = New System.Drawing.Point(97, 219)
        Me.cl_btn.Name = "cl_btn"
        Me.cl_btn.Size = New System.Drawing.Size(75, 23)
        Me.cl_btn.TabIndex = 5
        Me.cl_btn.Text = "Clear"
        Me.cl_btn.UseVisualStyleBackColor = True
        '
        'TextBox4_p
        '
        Me.TextBox4_p.Location = New System.Drawing.Point(94, 170)
        Me.TextBox4_p.Name = "TextBox4_p"
        Me.TextBox4_p.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4_p.TabIndex = 3
        '
        'TextBox3_t
        '
        Me.TextBox3_t.Location = New System.Drawing.Point(94, 128)
        Me.TextBox3_t.Name = "TextBox3_t"
        Me.TextBox3_t.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3_t.TabIndex = 2
        '
        'TextBox2_r
        '
        Me.TextBox2_r.Location = New System.Drawing.Point(94, 88)
        Me.TextBox2_r.Name = "TextBox2_r"
        Me.TextBox2_r.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2_r.TabIndex = 1
        '
        'TextBox1_n
        '
        Me.TextBox1_n.Location = New System.Drawing.Point(94, 51)
        Me.TextBox1_n.Name = "TextBox1_n"
        Me.TextBox1_n.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1_n.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Enter The P"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Enter The T"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter The R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enter The N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "V=N*R*T/P"
        '
        'calculat_btn
        '
        Me.calculat_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.calculat_btn.Location = New System.Drawing.Point(7, 219)
        Me.calculat_btn.Name = "calculat_btn"
        Me.calculat_btn.Size = New System.Drawing.Size(75, 23)
        Me.calculat_btn.TabIndex = 4
        Me.calculat_btn.Text = "Calculate"
        Me.calculat_btn.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pr_btn)
        Me.Controls.Add(Me.cl_btn)
        Me.Controls.Add(Me.TextBox4_p)
        Me.Controls.Add(Me.TextBox3_t)
        Me.Controls.Add(Me.TextBox2_r)
        Me.Controls.Add(Me.TextBox1_n)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calculat_btn)
        Me.Name = "Form3"
        Me.Text = "VOLUME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pr_btn As System.Windows.Forms.Button
    Friend WithEvents cl_btn As System.Windows.Forms.Button
    Friend WithEvents TextBox4_p As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3_t As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2_r As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1_n As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calculat_btn As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
