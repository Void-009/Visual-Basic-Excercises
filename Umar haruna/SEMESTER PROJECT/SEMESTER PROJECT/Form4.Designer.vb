<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.p_bt = New System.Windows.Forms.Button()
        Me.c_bt = New System.Windows.Forms.Button()
        Me.Txt4_t = New System.Windows.Forms.TextBox()
        Me.Txt3_r = New System.Windows.Forms.TextBox()
        Me.Txt2_v = New System.Windows.Forms.TextBox()
        Me.txt1_p = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cal_bt = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'p_bt
        '
        Me.p_bt.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.p_bt.Location = New System.Drawing.Point(230, 250)
        Me.p_bt.Name = "p_bt"
        Me.p_bt.Size = New System.Drawing.Size(87, 27)
        Me.p_bt.TabIndex = 6
        Me.p_bt.Text = "Print"
        Me.p_bt.UseVisualStyleBackColor = True
        '
        'c_bt
        '
        Me.c_bt.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.c_bt.Location = New System.Drawing.Point(120, 250)
        Me.c_bt.Name = "c_bt"
        Me.c_bt.Size = New System.Drawing.Size(87, 27)
        Me.c_bt.TabIndex = 5
        Me.c_bt.Text = "Clear"
        Me.c_bt.UseVisualStyleBackColor = True
        '
        'Txt4_t
        '
        Me.Txt4_t.Location = New System.Drawing.Point(110, 196)
        Me.Txt4_t.Name = "Txt4_t"
        Me.Txt4_t.Size = New System.Drawing.Size(116, 22)
        Me.Txt4_t.TabIndex = 3
        '
        'Txt3_r
        '
        Me.Txt3_r.Location = New System.Drawing.Point(110, 148)
        Me.Txt3_r.Name = "Txt3_r"
        Me.Txt3_r.Size = New System.Drawing.Size(116, 22)
        Me.Txt3_r.TabIndex = 2
        '
        'Txt2_v
        '
        Me.Txt2_v.Location = New System.Drawing.Point(110, 102)
        Me.Txt2_v.Name = "Txt2_v"
        Me.Txt2_v.Size = New System.Drawing.Size(116, 22)
        Me.Txt2_v.TabIndex = 1
        '
        'txt1_p
        '
        Me.txt1_p.Location = New System.Drawing.Point(110, 59)
        Me.txt1_p.Name = "txt1_p"
        Me.txt1_p.Size = New System.Drawing.Size(116, 22)
        Me.txt1_p.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Enter The T"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Enter The R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter The V"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enter The P"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "N=P*V/R*T"
        '
        'cal_bt
        '
        Me.cal_bt.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cal_bt.Location = New System.Drawing.Point(15, 250)
        Me.cal_bt.Name = "cal_bt"
        Me.cal_bt.Size = New System.Drawing.Size(87, 27)
        Me.cal_bt.TabIndex = 4
        Me.cal_bt.Text = "Calculate"
        Me.cal_bt.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(331, 301)
        Me.Controls.Add(Me.p_bt)
        Me.Controls.Add(Me.c_bt)
        Me.Controls.Add(Me.Txt4_t)
        Me.Controls.Add(Me.Txt3_r)
        Me.Controls.Add(Me.Txt2_v)
        Me.Controls.Add(Me.txt1_p)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cal_bt)
        Me.Font = New System.Drawing.Font("Romantic", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Name = "Form4"
        Me.Text = "NUMBER OF MOLES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents p_bt As System.Windows.Forms.Button
    Friend WithEvents c_bt As System.Windows.Forms.Button
    Friend WithEvents Txt4_t As System.Windows.Forms.TextBox
    Friend WithEvents Txt3_r As System.Windows.Forms.TextBox
    Friend WithEvents Txt2_v As System.Windows.Forms.TextBox
    Friend WithEvents txt1_p As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cal_bt As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
