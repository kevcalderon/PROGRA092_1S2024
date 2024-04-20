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
        Me.eliminar = New System.Windows.Forms.Button()
        Me.listUsuarios = New System.Windows.Forms.ListBox()
        Me.conectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(314, 327)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(163, 34)
        Me.eliminar.TabIndex = 0
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'listUsuarios
        '
        Me.listUsuarios.FormattingEnabled = True
        Me.listUsuarios.ItemHeight = 20
        Me.listUsuarios.Location = New System.Drawing.Point(170, 105)
        Me.listUsuarios.Name = "listUsuarios"
        Me.listUsuarios.Size = New System.Drawing.Size(448, 204)
        Me.listUsuarios.TabIndex = 1
        '
        'conectar
        '
        Me.conectar.Location = New System.Drawing.Point(31, 388)
        Me.conectar.Name = "conectar"
        Me.conectar.Size = New System.Drawing.Size(115, 30)
        Me.conectar.TabIndex = 2
        Me.conectar.Text = "Conectar BD"
        Me.conectar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(262, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eliminar Usuario"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.conectar)
        Me.Controls.Add(Me.listUsuarios)
        Me.Controls.Add(Me.eliminar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents eliminar As Button
    Friend WithEvents listUsuarios As ListBox
    Friend WithEvents conectar As Button
    Friend WithEvents Label1 As Label
End Class
