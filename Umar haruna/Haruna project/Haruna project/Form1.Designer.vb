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
        Me.m_rbtn = New System.Windows.Forms.RadioButton()
        Me.f_rbtn = New System.Windows.Forms.RadioButton()
        Me.area_rbtn = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.b_txt = New System.Windows.Forms.TextBox()
        Me.a_txt = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.b_lbl = New System.Windows.Forms.Label()
        Me.a_lbl = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.m_rbtn)
        Me.GroupBox1.Controls.Add(Me.f_rbtn)
        Me.GroupBox1.Controls.Add(Me.area_rbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select The Formula"
        '
        'm_rbtn
        '
        Me.m_rbtn.AutoSize = True
        Me.m_rbtn.Location = New System.Drawing.Point(11, 64)
        Me.m_rbtn.Name = "m_rbtn"
        Me.m_rbtn.Size = New System.Drawing.Size(91, 17)
        Me.m_rbtn.TabIndex = 2
        Me.m_rbtn.TabStop = True
        Me.m_rbtn.Text = "Magnetic Flux"
        Me.m_rbtn.UseVisualStyleBackColor = True
        '
        'f_rbtn
        '
        Me.f_rbtn.AutoSize = True
        Me.f_rbtn.Location = New System.Drawing.Point(11, 41)
        Me.f_rbtn.Name = "f_rbtn"
        Me.f_rbtn.Size = New System.Drawing.Size(82, 17)
        Me.f_rbtn.TabIndex = 1
        Me.f_rbtn.TabStop = True
        Me.f_rbtn.Text = "Flux Density"
        Me.f_rbtn.UseVisualStyleBackColor = True
        '
        'area_rbtn
        '
        Me.area_rbtn.AutoSize = True
        Me.area_rbtn.Location = New System.Drawing.Point(11, 18)
        Me.area_rbtn.Name = "area_rbtn"
        Me.area_rbtn.Size = New System.Drawing.Size(47, 17)
        Me.area_rbtn.TabIndex = 0
        Me.area_rbtn.TabStop = True
        Me.area_rbtn.Text = "Area"
        Me.area_rbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'b_txt
        '
        Me.b_txt.Location = New System.Drawing.Point(174, 98)
        Me.b_txt.Name = "b_txt"
        Me.b_txt.Size = New System.Drawing.Size(100, 20)
        Me.b_txt.TabIndex = 5
        '
        'a_txt
        '
        Me.a_txt.Location = New System.Drawing.Point(174, 55)
        Me.a_txt.Name = "a_txt"
        Me.a_txt.Size = New System.Drawing.Size(100, 20)
        Me.a_txt.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(232, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'b_lbl
        '
        Me.b_lbl.AutoSize = True
        Me.b_lbl.Location = New System.Drawing.Point(41, 105)
        Me.b_lbl.Name = "b_lbl"
        Me.b_lbl.Size = New System.Drawing.Size(29, 13)
        Me.b_lbl.TabIndex = 8
        Me.b_lbl.Text = "Area"
        '
        'a_lbl
        '
        Me.a_lbl.AutoSize = True
        Me.a_lbl.Location = New System.Drawing.Point(26, 58)
        Me.a_lbl.Name = "a_lbl"
        Me.a_lbl.Size = New System.Drawing.Size(119, 13)
        Me.a_lbl.TabIndex = 9
        Me.a_lbl.Text = "Enter The magnetic flux"
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
        Me.ClientSize = New System.Drawing.Size(319, 342)
        Me.Controls.Add(Me.a_lbl)
        Me.Controls.Add(Me.b_lbl)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.a_txt)
        Me.Controls.Add(Me.b_txt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Magnetic Flux Density"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents m_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents f_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents area_rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents b_txt As System.Windows.Forms.TextBox
    Friend WithEvents a_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents b_lbl As System.Windows.Forms.Label
    Friend WithEvents a_lbl As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
