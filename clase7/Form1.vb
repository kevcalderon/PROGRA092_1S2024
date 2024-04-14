Public Class Form1

    Dim nitClientes(5) As String
    Dim placaAutos(5) As String
    Dim marcaAutos(5) As String
    Dim diasAlquiler(5) As String
    Dim formaPago(5) As String
    Dim porcentajeEfectivo(5) As String
    Dim porcentajeTarjeta(5) As String
    Dim pagoParcial(5) As String
    Dim descuento(5) As String
    Dim recargo(5) As String
    Dim pagoFinal(5) As String


    Private Function CalcularPagoParcial(precioDia As Double, dias As Integer) As Double
        Return precioDia * dias
    End Function

    Private Function CalcularDescuento(parcial As Double, formaPago As String) As Double
        Dim desc As Double = 0
        If formaPago = "Efectivo" Then
            desc = parcial * 0.05
        End If
        Return desc
    End Function

    Private Function CalcularRegargo(parcial As Double, formaPago As String) As Double
        Dim rec As Double = 0
        If formaPago = "Tarjeta" Then
            rec = parcial * 0.025
        End If
        Return rec
    End Function

    Private Sub CalcularPagoFinal()
        For i As Integer = 0 To 5
            If Not String.IsNullOrEmpty(nitClientes(i)) Then
                Dim precioDia As Double
                Select Case marcaAutos(i)
                    Case "Honda"
                        precioDia = 250.0
                    Case "Mercedes Benz"
                        precioDia = 450.0
                    Case "Toyota"
                        precioDia = 325.0
                    Case "Mazda"
                        precioDia = 300.0
                End Select

                Dim parcial As Double = CalcularPagoParcial(precioDia, diasAlquiler(i))
                Dim desc As Double = CalcularDescuento(parcial, formaPago(i))
                Dim rec As Double = CalcularRegargo(parcial, formaPago(i))
                Dim pago As Double = parcial - desc + rec

                dgvAlquileres.Rows.Add(placaAutos(i), marcaAutos(i), diasAlquiler(i), parcial, pago)
            End If
        Next
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim index As Integer = Array.IndexOf(nitClientes, Nothing)
        Dim flagErrors As Boolean = False

        If index >= 0 Then
            dgvAlquileres.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtNitCliente.Text) AndAlso
             Not String.IsNullOrWhiteSpace(txtPlacaAuto.Text) AndAlso
             Not String.IsNullOrWhiteSpace(txtDiasAlquiler.Text) AndAlso
             cmbMarca.SelectedIndex >= 0 AndAlso
             cmbFormaPago.SelectedIndex >= 0 Then


                If cmbFormaPago.SelectedItem.ToString() = "Efectivo" And String.IsNullOrWhiteSpace(txtPorcentajeEfectivo.Text) Then
                    MessageBox.Show("Debe ingresar el porcentaje para la forma de pago en efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    flagErrors = True
                    Return
                End If

                If cmbFormaPago.SelectedItem.ToString() = "Tarjeta" And String.IsNullOrWhiteSpace(txtPorcentajeTarjeta.Text) Then
                    MessageBox.Show("Debe ingresar el porcentaje para la forma de pago con tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    flagErrors = True
                    Return
                End If

                Dim porcentajeEfect As Double = If(cmbFormaPago.SelectedItem.ToString() = "Efectivo", CDbl(txtPorcentajeEfectivo.Text), 0)
                Dim porcentajeTarj As Double = If(cmbFormaPago.SelectedItem.ToString() = "Tarjeta", CDbl(txtPorcentajeTarjeta.Text), 0)

                If porcentajeEfect + porcentajeTarj <> 100 Then
                    flagErrors = True
                    MessageBox.Show("La suma de los porcentajes de pago debe ser igual a 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                nitClientes(index) = txtNitCliente.Text
                placaAutos(index) = txtPlacaAuto.Text
                marcaAutos(index) = cmbMarca.SelectedItem.ToString()
                diasAlquiler(index) = CInt(txtDiasAlquiler.Text)
                formaPago(index) = cmbFormaPago.SelectedItem.ToString()
                porcentajeEfectivo(index) = porcentajeEfect
                porcentajeTarjeta(index) = porcentajeTarj

                CalcularPagoFinal()


            Else
                MessageBox.Show("Porfavor, complete todo los campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Ya se han ingresado 6 alquileres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub LimpiarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTodoToolStripMenuItem.Click

    End Sub



End Class
