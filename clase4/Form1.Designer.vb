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
        Me.checkBoxVegetal = New System.Windows.Forms.CheckBox()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.comboNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonPagar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textDescuento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'checkBoxVegetal
        '
        Me.checkBoxVegetal.AutoSize = True
        Me.checkBoxVegetal.Location = New System.Drawing.Point(190, 128)
        Me.checkBoxVegetal.Name = "checkBoxVegetal"
        Me.checkBoxVegetal.Size = New System.Drawing.Size(123, 24)
        Me.checkBoxVegetal.TabIndex = 0
        Me.checkBoxVegetal.Text = "Leche Vegetal"
        Me.checkBoxVegetal.UseVisualStyleBackColor = True
        '
        'comboTipo
        '
        Me.comboTipo.Enabled = False
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Items.AddRange(New Object() {"Soja", "Almendra", "Coco"})
        Me.comboTipo.Location = New System.Drawing.Point(190, 184)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(151, 28)
        Me.comboTipo.TabIndex = 1
        '
        'comboNombre
        '
        Me.comboNombre.Enabled = False
        Me.comboNombre.FormattingEnabled = True
        Me.comboNombre.Items.AddRange(New Object() {"Barista1", "Barista2", "Barista3"})
        Me.comboNombre.Location = New System.Drawing.Point(190, 233)
        Me.comboNombre.Name = "comboNombre"
        Me.comboNombre.Size = New System.Drawing.Size(151, 28)
        Me.comboNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo de leche"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de Barista"
        '
        'buttonPagar
        '
        Me.buttonPagar.Enabled = False
        Me.buttonPagar.Location = New System.Drawing.Point(208, 436)
        Me.buttonPagar.Name = "buttonPagar"
        Me.buttonPagar.Size = New System.Drawing.Size(94, 29)
        Me.buttonPagar.TabIndex = 5
        Me.buttonPagar.Text = "Pagar"
        Me.buttonPagar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descuento"
        '
        'textDescuento
        '
        Me.textDescuento.Location = New System.Drawing.Point(194, 336)
        Me.textDescuento.Name = "textDescuento"
        Me.textDescuento.Size = New System.Drawing.Size(125, 27)
        Me.textDescuento.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 579)
        Me.Controls.Add(Me.textDescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buttonPagar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboNombre)
        Me.Controls.Add(Me.comboTipo)
        Me.Controls.Add(Me.checkBoxVegetal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkBoxVegetal As CheckBox
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents comboNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonPagar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents textDescuento As TextBox
End Class
