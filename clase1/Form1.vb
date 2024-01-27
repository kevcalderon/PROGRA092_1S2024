Public Class Form1
    Private Sub buttonSumar_Click(sender As Object, e As EventArgs) Handles buttonSumar.Click

        Dim numero1 As String = textNumero1.Text
        Dim numero2 As String = textNumero2.Text

        If IsNumeric(numero1) AndAlso IsNumeric(numero2) Then
            textResultado.Text = Val(numero1) + Val(numero2)
        Else
            MessageBox.Show("Ingrese solo valores numericos. Por favor :)")
        End If


    End Sub
End Class
