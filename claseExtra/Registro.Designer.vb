<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonBackRegistro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.textUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textContra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(270, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRO"
        '
        'buttonBackRegistro
        '
        Me.buttonBackRegistro.Location = New System.Drawing.Point(270, 449)
        Me.buttonBackRegistro.Name = "buttonBackRegistro"
        Me.buttonBackRegistro.Size = New System.Drawing.Size(213, 62)
        Me.buttonBackRegistro.TabIndex = 1
        Me.buttonBackRegistro.Text = "Regresar a Login"
        Me.buttonBackRegistro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'textNombre
        '
        Me.textNombre.Location = New System.Drawing.Point(289, 155)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(248, 27)
        Me.textNombre.TabIndex = 3
        '
        'textUsuario
        '
        Me.textUsuario.Location = New System.Drawing.Point(289, 214)
        Me.textUsuario.Name = "textUsuario"
        Me.textUsuario.Size = New System.Drawing.Size(248, 27)
        Me.textUsuario.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña"
        '
        'textContra
        '
        Me.textContra.Location = New System.Drawing.Point(289, 272)
        Me.textContra.Name = "textContra"
        Me.textContra.Size = New System.Drawing.Size(248, 27)
        Me.textContra.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(803, 549)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textContra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonBackRegistro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "-"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents buttonBackRegistro As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents textUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textContra As TextBox
    Friend WithEvents Button1 As Button
End Class
