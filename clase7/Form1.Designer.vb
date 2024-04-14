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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPorcentajeTarjeta = New System.Windows.Forms.TextBox()
        Me.txtPorcentajeEfectivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.txtDiasAlquiler = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.txtPlacaAuto = New System.Windows.Forms.TextBox()
        Me.txtNitCliente = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvAlquileres = New System.Windows.Forms.DataGridView()
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvAlquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nit cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Placa del auto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPorcentajeTarjeta)
        Me.GroupBox1.Controls.Add(Me.txtPorcentajeEfectivo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbFormaPago)
        Me.GroupBox1.Controls.Add(Me.txtDiasAlquiler)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbMarca)
        Me.GroupBox1.Controls.Add(Me.txtPlacaAuto)
        Me.GroupBox1.Controls.Add(Me.txtNitCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 458)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE CALCULO"
        '
        'txtPorcentajeTarjeta
        '
        Me.txtPorcentajeTarjeta.Location = New System.Drawing.Point(168, 350)
        Me.txtPorcentajeTarjeta.Name = "txtPorcentajeTarjeta"
        Me.txtPorcentajeTarjeta.Size = New System.Drawing.Size(151, 27)
        Me.txtPorcentajeTarjeta.TabIndex = 12
        '
        'txtPorcentajeEfectivo
        '
        Me.txtPorcentajeEfectivo.Location = New System.Drawing.Point(168, 302)
        Me.txtPorcentajeEfectivo.Name = "txtPorcentajeEfectivo"
        Me.txtPorcentajeEfectivo.Size = New System.Drawing.Size(151, 27)
        Me.txtPorcentajeEfectivo.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Porcentaje Tarjeta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Porcentaje efectivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Forma pago"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Ambos"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(168, 242)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(151, 28)
        Me.cmbFormaPago.TabIndex = 8
        '
        'txtDiasAlquiler
        '
        Me.txtDiasAlquiler.Location = New System.Drawing.Point(168, 184)
        Me.txtDiasAlquiler.Name = "txtDiasAlquiler"
        Me.txtDiasAlquiler.Size = New System.Drawing.Size(151, 27)
        Me.txtDiasAlquiler.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad de dias"
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.cmbMarca.Location = New System.Drawing.Point(168, 130)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(151, 28)
        Me.cmbMarca.TabIndex = 5
        '
        'txtPlacaAuto
        '
        Me.txtPlacaAuto.Location = New System.Drawing.Point(168, 82)
        Me.txtPlacaAuto.Name = "txtPlacaAuto"
        Me.txtPlacaAuto.Size = New System.Drawing.Size(151, 27)
        Me.txtPlacaAuto.TabIndex = 4
        '
        'txtNitCliente
        '
        Me.txtNitCliente.Location = New System.Drawing.Point(168, 39)
        Me.txtNitCliente.Name = "txtNitCliente"
        Me.txtNitCliente.Size = New System.Drawing.Size(151, 27)
        Me.txtNitCliente.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.LimpiarTodoToolStripMenuItem, Me.CalcularToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LimpiarTodoToolStripMenuItem
        '
        Me.LimpiarTodoToolStripMenuItem.Name = "LimpiarTodoToolStripMenuItem"
        Me.LimpiarTodoToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.LimpiarTodoToolStripMenuItem.Text = "Limpiar todo"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'dgvAlquileres
        '
        Me.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlquileres.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Placa, Me.Marca, Me.Dias, Me.Parcial, Me.Pago})
        Me.dgvAlquileres.Location = New System.Drawing.Point(412, 80)
        Me.dgvAlquileres.Name = "dgvAlquileres"
        Me.dgvAlquileres.RowHeadersWidth = 51
        Me.dgvAlquileres.RowTemplate.Height = 29
        Me.dgvAlquileres.Size = New System.Drawing.Size(680, 434)
        Me.dgvAlquileres.TabIndex = 5
        '
        'Placa
        '
        Me.Placa.Frozen = True
        Me.Placa.HeaderText = "Placa"
        Me.Placa.MinimumWidth = 6
        Me.Placa.Name = "Placa"
        Me.Placa.ReadOnly = True
        Me.Placa.Width = 125
        '
        'Marca
        '
        Me.Marca.Frozen = True
        Me.Marca.HeaderText = "Marca"
        Me.Marca.MinimumWidth = 6
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 125
        '
        'Dias
        '
        Me.Dias.Frozen = True
        Me.Dias.HeaderText = "Dias"
        Me.Dias.MinimumWidth = 6
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 125
        '
        'Parcial
        '
        Me.Parcial.Frozen = True
        Me.Parcial.HeaderText = "Parcial"
        Me.Parcial.MinimumWidth = 6
        Me.Parcial.Name = "Parcial"
        Me.Parcial.ReadOnly = True
        Me.Parcial.Width = 125
        '
        'Pago
        '
        Me.Pago.Frozen = True
        Me.Pago.HeaderText = "Pago"
        Me.Pago.MinimumWidth = 6
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        Me.Pago.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 550)
        Me.Controls.Add(Me.dgvAlquileres)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvAlquileres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPorcentajeTarjeta As TextBox
    Friend WithEvents txtPorcentajeEfectivo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents txtDiasAlquiler As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents txtPlacaAuto As TextBox
    Friend WithEvents txtNitCliente As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvAlquileres As DataGridView
    'Friend WithEvents PagoParcial As DataGridViewTextBoxColumn
    Friend WithEvents Placa As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Dias As DataGridViewTextBoxColumn
    Friend WithEvents Parcial As DataGridViewTextBoxColumn
    Friend WithEvents Pago As DataGridViewTextBoxColumn
End Class
