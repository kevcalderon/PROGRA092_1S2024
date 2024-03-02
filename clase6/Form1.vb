Public Class Form1
    Private Sub buttonCalcular_Click(sender As Object, e As EventArgs) Handles buttonCalcular.Click
        Dim salario As Double = textBoxSalario.Text
        Dim horas As Integer = textBoxHoras.Text
        Dim bono As Double = textBoxBonificacion.Text

        'Calcular salario total
        Dim SalarioFinal As Double = CalcularSalario(salario, horas, bono)

        'imprimir valores al usuario
        listBoxResultados.Items.Add($"El salario total es: {SalarioFinal}")


        'ejemplo2
        Dim operacion = "#"
        Dim total = 0
        Dim numero1 = 10
        Dim numero2 = 80
        If operacion = "+" Then
            total = sumar(numero1, numero2)
        ElseIf operacion = "-" Then
            total = restar(numero1, numero2)
        ElseIf operacion = "*" Then
            total = multiplicacion(numero1, numero2)
        ElseIf operacion = "/" Then
            total = division(numero1, numero2)
        ElseIf operacion = "#" Then
            total = raiz(numero1)
        ElseIf operacion = "^" Then
            total = potencia(numero1, numero2)
        End If
        listBoxResultados.Items.Add($"Ejemplo 2, calculadora: {total}")


    End Sub


    Function CalcularSalario(salario As Double, horas As Integer, bono As Double) As Double
        'calcular salario sin bonificacion
        Dim salarioSinBonificacion As Double = salario * horas

        'salario incluendo bonificacion
        Dim salarioTotal As Double = salarioSinBonificacion + bono

        Return salarioTotal
    End Function


    Private Function sumar(num1, num2) As Double
        Return num1 + num2
    End Function

    Private Function restar(num1, num2) As Double
        Return num1 - num2
    End Function

    Private Function multiplicacion(num1, num2) As Double
        Return num1 * num2
    End Function

    Private Function division(num1, num2) As Double
        Return num1 / num2
    End Function

    Private Function raiz(num1) As Double
        Return Math.Sqrt(num1)
    End Function

    Private Function potencia(num1, num2) As Double
        'base, elevado a
        Return Math.Pow(num1, num2)
    End Function

End Class
