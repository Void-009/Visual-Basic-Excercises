<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_p = New System.Windows.Forms.Button()
        Me.btn_c = New System.Windows.Forms.Button()
        Me.Txt_V = New System.Windows.Forms.TextBox()
        Me.Txt_T = New System.Windows.Forms.TextBox()
        Me.Txt_R = New System.Windows.Forms.TextBox()
        Me.Txt_N = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cal = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'btn_p
        '
        Me.btn_p.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_p.Location = New System.Drawing.Point(230, 250)
        Me.btn_p.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btn_p.Name = "btn_p"
        Me.btn_p.Size = New System.Drawing.Size(86, 26)
        Me.btn_p.TabIndex = 6
        Me.btn_p.Text = "Print"
        Me.btn_p.UseVisualStyleBackColor = True
        '
        'btn_c
        '
        Me.btn_c.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_c.Location = New System.Drawing.Point(120, 250)
        Me.btn_c.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btn_c.Name = "btn_c"
        Me.btn_c.Size = New System.Drawing.Size(86, 26)
        Me.btn_c.TabIndex = 5
        Me.btn_c.Text = "Clear"
        Me.btn_c.UseVisualStyleBackColor = True
        '
        'Txt_V
        '
        Me.Txt_V.Location = New System.Drawing.Point(110, 196)
        Me.Txt_V.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Txt_V.Name = "Txt_V"
        Me.Txt_V.Size = New System.Drawing.Size(116, 22)
        Me.Txt_V.TabIndex = 3
        '
        'Txt_T
        '
        Me.Txt_T.Location = New System.Drawing.Point(110, 148)
        Me.Txt_T.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Txt_T.Name = "Txt_T"
        Me.Txt_T.Size = New System.Drawing.Size(116, 22)
        Me.Txt_T.TabIndex = 2
        '
        'Txt_R
        '
        Me.Txt_R.Location = New System.Drawing.Point(110, 101)
        Me.Txt_R.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Txt_R.Name = "Txt_R"
        Me.Txt_R.Size = New System.Drawing.Size(116, 22)
        Me.Txt_R.TabIndex = 1
        '
        'Txt_N
        '
        Me.Txt_N.Location = New System.Drawing.Point(110, 59)
        Me.Txt_N.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Txt_N.Name = "Txt_N"
        Me.Txt_N.Size = New System.Drawing.Size(116, 22)
        Me.Txt_N.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 200)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Enter The V"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Enter The T"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Enter The R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enter The N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "P=N*R*T/V"
        '
        'btn_cal
        '
        Me.btn_cal.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btn_cal.Location = New System.Drawing.Point(15, 250)
        Me.btn_cal.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btn_cal.Name = "btn_cal"
        Me.btn_cal.Size = New System.Drawing.Size(86, 26)
        Me.btn_cal.TabIndex = 4
        Me.btn_cal.Text = "Calculate"
        Me.btn_cal.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 301)
        Me.Controls.Add(Me.btn_p)
        Me.Controls.Add(Me.btn_c)
        Me.Controls.Add(Me.Txt_V)
        Me.Controls.Add(Me.Txt_T)
        Me.Controls.Add(Me.Txt_R)
        Me.Controls.Add(Me.Txt_N)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cal)
        Me.Font = New System.Drawing.Font("Romantic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "Form2"
        Me.Text = "PRESSURE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_p As System.Windows.Forms.Button
    Friend WithEvents btn_c As System.Windows.Forms.Button
    Friend WithEvents Txt_V As System.Windows.Forms.TextBox
    Friend WithEvents Txt_T As System.Windows.Forms.TextBox
    Friend WithEvents Txt_R As System.Windows.Forms.TextBox
    Friend WithEvents Txt_N As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cal As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
