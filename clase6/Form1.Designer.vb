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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textBoxSalario = New System.Windows.Forms.TextBox()
        Me.textBoxHoras = New System.Windows.Forms.TextBox()
        Me.textBoxBonificacion = New System.Windows.Forms.TextBox()
        Me.buttonCalcular = New System.Windows.Forms.Button()
        Me.listBoxResultados = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(888, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horas trabajadas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bonificacion"
        '
        'textBoxSalario
        '
        Me.textBoxSalario.Location = New System.Drawing.Point(197, 133)
        Me.textBoxSalario.Name = "textBoxSalario"
        Me.textBoxSalario.Size = New System.Drawing.Size(125, 27)
        Me.textBoxSalario.TabIndex = 4
        '
        'textBoxHoras
        '
        Me.textBoxHoras.Location = New System.Drawing.Point(197, 191)
        Me.textBoxHoras.Name = "textBoxHoras"
        Me.textBoxHoras.Size = New System.Drawing.Size(125, 27)
        Me.textBoxHoras.TabIndex = 5
        '
        'textBoxBonificacion
        '
        Me.textBoxBonificacion.Location = New System.Drawing.Point(197, 242)
        Me.textBoxBonificacion.Name = "textBoxBonificacion"
        Me.textBoxBonificacion.Size = New System.Drawing.Size(125, 27)
        Me.textBoxBonificacion.TabIndex = 6
        '
        'buttonCalcular
        '
        Me.buttonCalcular.Location = New System.Drawing.Point(165, 304)
        Me.buttonCalcular.Name = "buttonCalcular"
        Me.buttonCalcular.Size = New System.Drawing.Size(94, 29)
        Me.buttonCalcular.TabIndex = 7
        Me.buttonCalcular.Text = "Calcular"
        Me.buttonCalcular.UseVisualStyleBackColor = True
        '
        'listBoxResultados
        '
        Me.listBoxResultados.FormattingEnabled = True
        Me.listBoxResultados.ItemHeight = 20
        Me.listBoxResultados.Location = New System.Drawing.Point(56, 359)
        Me.listBoxResultados.Name = "listBoxResultados"
        Me.listBoxResultados.Size = New System.Drawing.Size(339, 144)
        Me.listBoxResultados.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 545)
        Me.Controls.Add(Me.listBoxResultados)
        Me.Controls.Add(Me.buttonCalcular)
        Me.Controls.Add(Me.textBoxBonificacion)
        Me.Controls.Add(Me.textBoxHoras)
        Me.Controls.Add(Me.textBoxSalario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textBoxSalario As TextBox
    Friend WithEvents textBoxHoras As TextBox
    Friend WithEvents textBoxBonificacion As TextBox
    Friend WithEvents buttonCalcular As Button
    Friend WithEvents listBoxResultados As ListBox
End Class
