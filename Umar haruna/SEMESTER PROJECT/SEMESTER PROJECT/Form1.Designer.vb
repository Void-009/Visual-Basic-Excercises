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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.p_rb = New System.Windows.Forms.RadioButton()
        Me.v_rb = New System.Windows.Forms.RadioButton()
        Me.t_rb = New System.Windows.Forms.RadioButton()
        Me.n_rb = New System.Windows.Forms.RadioButton()
        Me.r_rb = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.r_rb)
        Me.GroupBox1.Controls.Add(Me.n_rb)
        Me.GroupBox1.Controls.Add(Me.t_rb)
        Me.GroupBox1.Controls.Add(Me.v_rb)
        Me.GroupBox1.Controls.Add(Me.p_rb)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please Select The Formular"
        '
        'p_rb
        '
        Me.p_rb.AutoSize = True
        Me.p_rb.Location = New System.Drawing.Point(19, 19)
        Me.p_rb.Name = "p_rb"
        Me.p_rb.Size = New System.Drawing.Size(66, 17)
        Me.p_rb.TabIndex = 0
        Me.p_rb.TabStop = True
        Me.p_rb.Text = "Pressure"
        Me.p_rb.UseVisualStyleBackColor = True
        '
        'v_rb
        '
        Me.v_rb.AutoSize = True
        Me.v_rb.Location = New System.Drawing.Point(19, 42)
        Me.v_rb.Name = "v_rb"
        Me.v_rb.Size = New System.Drawing.Size(60, 17)
        Me.v_rb.TabIndex = 1
        Me.v_rb.TabStop = True
        Me.v_rb.Text = "Volume"
        Me.v_rb.UseVisualStyleBackColor = True
        '
        't_rb
        '
        Me.t_rb.AutoSize = True
        Me.t_rb.Location = New System.Drawing.Point(19, 65)
        Me.t_rb.Name = "t_rb"
        Me.t_rb.Size = New System.Drawing.Size(85, 17)
        Me.t_rb.TabIndex = 2
        Me.t_rb.TabStop = True
        Me.t_rb.Text = "Temperature"
        Me.t_rb.UseVisualStyleBackColor = True
        '
        'n_rb
        '
        Me.n_rb.AutoSize = True
        Me.n_rb.Location = New System.Drawing.Point(19, 88)
        Me.n_rb.Name = "n_rb"
        Me.n_rb.Size = New System.Drawing.Size(127, 17)
        Me.n_rb.TabIndex = 3
        Me.n_rb.TabStop = True
        Me.n_rb.Text = "Number Of Molecules"
        Me.n_rb.UseVisualStyleBackColor = True
        '
        'r_rb
        '
        Me.r_rb.AutoSize = True
        Me.r_rb.Location = New System.Drawing.Point(19, 111)
        Me.r_rb.Name = "r_rb"
        Me.r_rb.Size = New System.Drawing.Size(133, 17)
        Me.r_rb.TabIndex = 4
        Me.r_rb.TabStop = True
        Me.r_rb.Text = " Relative Number Mole"
        Me.r_rb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Script MT Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(197, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Script MT Bold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(197, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "PRINT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Vineta BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "THE PROGRAM TO CALCULATE  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           AVOGADRO'S  LAW"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "MAIN FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents r_rb As System.Windows.Forms.RadioButton
    Friend WithEvents n_rb As System.Windows.Forms.RadioButton
    Friend WithEvents t_rb As System.Windows.Forms.RadioButton
    Friend WithEvents v_rb As System.Windows.Forms.RadioButton
    Friend WithEvents p_rb As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
