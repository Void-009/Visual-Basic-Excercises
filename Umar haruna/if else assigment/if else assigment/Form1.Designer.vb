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
        Me.compute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.printButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'compute
        '
        Me.compute.Location = New System.Drawing.Point(270, 106)
        Me.compute.Name = "compute"
        Me.compute.Size = New System.Drawing.Size(75, 23)
        Me.compute.TabIndex = 1
        Me.compute.Text = "Co&mpute"
        Me.compute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "M&ark&"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(83, 31)
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 20)
        Me.Txt1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(110, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "G&rade"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(59, 121)
        Me.txt2.Multiline = True
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(130, 87)
        Me.txt2.TabIndex = 3
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(270, 146)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(270, 185)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(127, 267)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 6
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 357)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.compute)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents compute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents printButton As System.Windows.Forms.Button

End Class
