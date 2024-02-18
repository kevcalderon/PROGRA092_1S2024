Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonPagar.Click
        comboTipo.SelectedIndex = 0

        If textDescuento.Text = "TEMPORADA12" Then
            MsgBox("Se aplico el descuento")
            'aplicar logica de descuento.
        Else
            MsgBox("No tenemos registrado ningun codigo con ese nombre. No aplicará el descuento.")
        End If
    End Sub

    Private Sub checkBoxVegetal_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxVegetal.CheckedChanged
        If checkBoxVegetal.Checked Then
            comboTipo.Enabled = True
        Else
            comboTipo.Enabled = False
        End If
    End Sub

    Private Sub comboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipo.SelectedIndexChanged
        comboNombre.Enabled = True
    End Sub

    Private Sub comboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboNombre.SelectedIndexChanged
        buttonPagar.Enabled = True
    End Sub
End Class
