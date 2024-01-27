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
        Me.buttonSumar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textNumero1 = New System.Windows.Forms.TextBox()
        Me.textNumero2 = New System.Windows.Forms.TextBox()
        Me.textResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonSumar
        '
        Me.buttonSumar.Font = New System.Drawing.Font("Sitka Small", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonSumar.Location = New System.Drawing.Point(464, 156)
        Me.buttonSumar.Name = "buttonSumar"
        Me.buttonSumar.Size = New System.Drawing.Size(108, 44)
        Me.buttonSumar.TabIndex = 0
        Me.buttonSumar.Text = "Sumar"
        Me.buttonSumar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(168, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(168, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero 2"
        '
        'textNumero1
        '
        Me.textNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textNumero1.Location = New System.Drawing.Point(306, 105)
        Me.textNumero1.Name = "textNumero1"
        Me.textNumero1.Size = New System.Drawing.Size(125, 27)
        Me.textNumero1.TabIndex = 3
        '
        'textNumero2
        '
        Me.textNumero2.Location = New System.Drawing.Point(306, 156)
        Me.textNumero2.Name = "textNumero2"
        Me.textNumero2.Size = New System.Drawing.Size(125, 27)
        Me.textNumero2.TabIndex = 4
        '
        'textResultado
        '
        Me.textResultado.Location = New System.Drawing.Point(303, 214)
        Me.textResultado.Name = "textResultado"
        Me.textResultado.Size = New System.Drawing.Size(125, 27)
        Me.textResultado.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(154, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textResultado)
        Me.Controls.Add(Me.textNumero2)
        Me.Controls.Add(Me.textNumero1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonSumar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonSumar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textNumero1 As TextBox
    Friend WithEvents textNumero2 As TextBox
    Friend WithEvents textResultado As TextBox
    Friend WithEvents Label3 As Label
End Class
