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
        Me.listBoxMostrar = New System.Windows.Forms.ListBox()
        Me.buttonEjecutar = New System.Windows.Forms.Button()
        Me.comboBoxDatos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'listBoxMostrar
        '
        Me.listBoxMostrar.FormattingEnabled = True
        Me.listBoxMostrar.ItemHeight = 20
        Me.listBoxMostrar.Location = New System.Drawing.Point(41, 113)
        Me.listBoxMostrar.Name = "listBoxMostrar"
        Me.listBoxMostrar.Size = New System.Drawing.Size(321, 264)
        Me.listBoxMostrar.TabIndex = 0
        '
        'buttonEjecutar
        '
        Me.buttonEjecutar.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buttonEjecutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.buttonEjecutar.Location = New System.Drawing.Point(293, 41)
        Me.buttonEjecutar.Name = "buttonEjecutar"
        Me.buttonEjecutar.Size = New System.Drawing.Size(178, 47)
        Me.buttonEjecutar.TabIndex = 1
        Me.buttonEjecutar.Text = "Ejecutar Ciclo"
        Me.buttonEjecutar.UseVisualStyleBackColor = True
        '
        'comboBoxDatos
        '
        Me.comboBoxDatos.FormattingEnabled = True
        Me.comboBoxDatos.Location = New System.Drawing.Point(395, 117)
        Me.comboBoxDatos.Name = "comboBoxDatos"
        Me.comboBoxDatos.Size = New System.Drawing.Size(317, 28)
        Me.comboBoxDatos.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.comboBoxDatos)
        Me.Controls.Add(Me.buttonEjecutar)
        Me.Controls.Add(Me.listBoxMostrar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listBoxMostrar As ListBox
    Friend WithEvents buttonEjecutar As Button
    Friend WithEvents comboBoxDatos As ComboBox
End Class
