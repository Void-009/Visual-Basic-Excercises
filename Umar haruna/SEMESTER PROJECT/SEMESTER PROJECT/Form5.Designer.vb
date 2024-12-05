<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.print_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.t_txt = New System.Windows.Forms.TextBox()
        Me.n_txt = New System.Windows.Forms.TextBox()
        Me.v_txt = New System.Windows.Forms.TextBox()
        Me.p_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'print_btn
        '
        Me.print_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.print_btn.Location = New System.Drawing.Point(197, 217)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(75, 23)
        Me.print_btn.TabIndex = 6
        Me.print_btn.Text = "Print"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(103, 217)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.clear_btn.TabIndex = 5
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        't_txt
        '
        Me.t_txt.Location = New System.Drawing.Point(94, 170)
        Me.t_txt.Name = "t_txt"
        Me.t_txt.Size = New System.Drawing.Size(100, 20)
        Me.t_txt.TabIndex = 3
        '
        'n_txt
        '
        Me.n_txt.Location = New System.Drawing.Point(94, 128)
        Me.n_txt.Name = "n_txt"
        Me.n_txt.Size = New System.Drawing.Size(100, 20)
        Me.n_txt.TabIndex = 2
        '
        'v_txt
        '
        Me.v_txt.Location = New System.Drawing.Point(94, 88)
        Me.v_txt.Name = "v_txt"
        Me.v_txt.Size = New System.Drawing.Size(100, 20)
        Me.v_txt.TabIndex = 1
        '
        'p_txt
        '
        Me.p_txt.Location = New System.Drawing.Point(94, 51)
        Me.p_txt.Name = "p_txt"
        Me.p_txt.Size = New System.Drawing.Size(100, 20)
        Me.p_txt.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Enter The T"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Enter The N"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter The V"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enter The P"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "R=P*V/N*T"
        '
        'calc_btn
        '
        Me.calc_btn.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.calc_btn.Location = New System.Drawing.Point(13, 217)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(75, 23)
        Me.calc_btn.TabIndex = 4
        Me.calc_btn.Text = "Calculate"
        Me.calc_btn.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.print_btn)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.t_txt)
        Me.Controls.Add(Me.n_txt)
        Me.Controls.Add(Me.v_txt)
        Me.Controls.Add(Me.p_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calc_btn)
        Me.Name = "Form5"
        Me.Text = "RELATIVE  NUMBER MOLES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents print_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents t_txt As System.Windows.Forms.TextBox
    Friend WithEvents n_txt As System.Windows.Forms.TextBox
    Friend WithEvents v_txt As System.Windows.Forms.TextBox
    Friend WithEvents p_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
