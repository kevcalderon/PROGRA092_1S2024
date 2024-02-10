Public Class Form1
    Private Sub buttonResultados_Click(sender As Object, e As EventArgs) Handles buttonResultados.Click
        'variable que recibe el valor de la nota
        Dim nota As Integer = textBoxNota.Text
        'variable que indica que check selecciono
        Dim selecciono As String
        'variable que indica que calificacion obtuvo
        Dim resultado As String


        'si selecciono IF ELSE
        If checkboxIF.Checked = True Then
            selecciono = "SELECCIONO IF"

            If nota < 0 Or nota > 100 Then
                MsgBox("Solo permiten notas mayores a cero y menor igual que 100.")
            ElseIf nota >= 90 Then
                resultado = "Calificacion A"
            ElseIf nota >= 80 Then
                resultado = "Calificacion B"
            ElseIf nota >= 70 Then
                resultado = "Calificacion C"
            ElseIf nota >= 60 Then
                resultado = "Calificacion D"
            ElseIf nota > 0 And nota <= 59 Then
                resultado = "Reprobado :("
            End If

        End If

        If checkBoxCase.Checked = True Then
            selecciono = "SELECCIONO CASE"

            Select Case nota
                Case < 0, Is > 100
                    MsgBox("Solo se permiten notas mayores a cero y menores o iguales a 100. ")
                Case >= 90
                    resultado = "Calificacion A"
                Case >= 80
                    resultado = "Calificacion B"
                Case >= 70
                    resultado = "Calificacion C"
                Case >= 60
                    resultado = "Calificacion D"
                Case Else
                    resultado = "Reprobado :("
            End Select

        End If

        'imprimir resultados
        If nota >= 0 And nota <= 100 Then
            listBoxResultados.Items.Add(selecciono)
            listBoxResultados.Items.Add("El alumno obtuvo: " + resultado)
        End If

    End Sub
End Class
