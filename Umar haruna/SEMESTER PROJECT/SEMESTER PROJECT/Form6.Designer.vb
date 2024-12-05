<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.cal_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_p = New System.Windows.Forms.TextBox()
        Me.Txt_v = New System.Windows.Forms.TextBox()
        Me.Txt_n = New System.Windows.Forms.TextBox()
        Me.Txt_r = New System.Windows.Forms.TextBox()
        Me.c_btn = New System.Windows.Forms.Button()
        Me.p_btn = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'cal_btn
        '
        Me.cal_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cal_btn.Location = New System.Drawing.Point(13, 226)
        Me.cal_btn.Name = "cal_btn"
        Me.cal_btn.Size = New System.Drawing.Size(75, 23)
        Me.cal_btn.TabIndex = 4
        Me.cal_btn.Text = "Calculate"
        Me.cal_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "T=P*V/N*R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter The P"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter The V"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Enter The N"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enter The R"
        '
        'Txt_p
        '
        Me.Txt_p.Location = New System.Drawing.Point(94, 60)
        Me.Txt_p.Name = "Txt_p"
        Me.Txt_p.Size = New System.Drawing.Size(100, 20)
        Me.Txt_p.TabIndex = 0
        '
        'Txt_v
        '
        Me.Txt_v.Location = New System.Drawing.Point(94, 97)
        Me.Txt_v.Name = "Txt_v"
        Me.Txt_v.Size = New System.Drawing.Size(100, 20)
        Me.Txt_v.TabIndex = 1
        '
        'Txt_n
        '
        Me.Txt_n.Location = New System.Drawing.Point(94, 137)
        Me.Txt_n.Name = "Txt_n"
        Me.Txt_n.Size = New System.Drawing.Size(100, 20)
        Me.Txt_n.TabIndex = 2
        '
        'Txt_r
        '
        Me.Txt_r.Location = New System.Drawing.Point(94, 179)
        Me.Txt_r.Name = "Txt_r"
        Me.Txt_r.Size = New System.Drawing.Size(100, 20)
        Me.Txt_r.TabIndex = 3
        '
        'c_btn
        '
        Me.c_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.c_btn.Location = New System.Drawing.Point(103, 226)
        Me.c_btn.Name = "c_btn"
        Me.c_btn.Size = New System.Drawing.Size(75, 23)
        Me.c_btn.TabIndex = 5
        Me.c_btn.Text = "Clear"
        Me.c_btn.UseVisualStyleBackColor = True
        '
        'p_btn
        '
        Me.p_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.p_btn.Location = New System.Drawing.Point(197, 226)
        Me.p_btn.Name = "p_btn"
        Me.p_btn.Size = New System.Drawing.Size(75, 23)
        Me.p_btn.TabIndex = 6
        Me.p_btn.Text = "Print"
        Me.p_btn.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.p_btn)
        Me.Controls.Add(Me.c_btn)
        Me.Controls.Add(Me.Txt_r)
        Me.Controls.Add(Me.Txt_n)
        Me.Controls.Add(Me.Txt_v)
        Me.Controls.Add(Me.Txt_p)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cal_btn)
        Me.Name = "Form6"
        Me.Text = "TEMPERATURE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cal_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_p As System.Windows.Forms.TextBox
    Friend WithEvents Txt_v As System.Windows.Forms.TextBox
    Friend WithEvents Txt_n As System.Windows.Forms.TextBox
    Friend WithEvents Txt_r As System.Windows.Forms.TextBox
    Friend WithEvents c_btn As System.Windows.Forms.Button
    Friend WithEvents p_btn As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
