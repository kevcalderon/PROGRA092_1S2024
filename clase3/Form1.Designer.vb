<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkboxIF = New System.Windows.Forms.CheckBox()
        Me.checkBoxCase = New System.Windows.Forms.CheckBox()
        Me.textBoxNota = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listBoxResultados = New System.Windows.Forms.ListBox()
        Me.buttonResultados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(138, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota"
        '
        'checkboxIF
        '
        Me.checkboxIF.AutoSize = True
        Me.checkboxIF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.checkboxIF.Location = New System.Drawing.Point(138, 162)
        Me.checkboxIF.Name = "checkboxIF"
        Me.checkboxIF.Size = New System.Drawing.Size(157, 28)
        Me.checkboxIF.TabIndex = 3
        Me.checkboxIF.Text = "SENTENCIA IF"
        Me.checkboxIF.UseVisualStyleBackColor = True
        '
        'checkBoxCase
        '
        Me.checkBoxCase.AutoSize = True
        Me.checkBoxCase.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.checkBoxCase.Location = New System.Drawing.Point(138, 196)
        Me.checkBoxCase.Name = "checkBoxCase"
        Me.checkBoxCase.Size = New System.Drawing.Size(186, 28)
        Me.checkBoxCase.TabIndex = 4
        Me.checkBoxCase.Text = "SENTENCIA CASE"
        Me.checkBoxCase.UseVisualStyleBackColor = True
        '
        'textBoxNota
        '
        Me.textBoxNota.Location = New System.Drawing.Point(199, 101)
        Me.textBoxNota.Name = "textBoxNota"
        Me.textBoxNota.Size = New System.Drawing.Size(125, 27)
        Me.textBoxNota.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(266, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "EJEMPLO IF / CASE"
        '
        'listBoxResultados
        '
        Me.listBoxResultados.FormattingEnabled = True
        Me.listBoxResultados.ItemHeight = 20
        Me.listBoxResultados.Location = New System.Drawing.Point(27, 259)
        Me.listBoxResultados.Name = "listBoxResultados"
        Me.listBoxResultados.Size = New System.Drawing.Size(743, 144)
        Me.listBoxResultados.TabIndex = 7
        '
        'buttonResultados
        '
        Me.buttonResultados.BackColor = System.Drawing.SystemColors.Desktop
        Me.buttonResultados.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonResultados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonResultados.Location = New System.Drawing.Point(454, 138)
        Me.buttonResultados.Name = "buttonResultados"
        Me.buttonResultados.Size = New System.Drawing.Size(152, 40)
        Me.buttonResultados.TabIndex = 8
        Me.buttonResultados.Text = "Mostrar Nota"
        Me.buttonResultados.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.buttonResultados)
        Me.Controls.Add(Me.listBoxResultados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textBoxNota)
        Me.Controls.Add(Me.checkboxIF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkBoxCase)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents checkboxIF As CheckBox
    Friend WithEvents checkBoxCase As CheckBox
    Friend WithEvents textBoxNota As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents listBoxResultados As ListBox
    Friend WithEvents buttonResultados As Button
End Class
