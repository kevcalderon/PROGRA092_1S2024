Public Class Form1
    Private Sub buttonEjecutar_Click(sender As Object, e As EventArgs) Handles buttonEjecutar.Click
        'FOR
        ''Dim i As Integer = 0
        Dim totalRepeticiones As Integer = 10

        'EJEMPLO1 - Incremental
        'For i = 1 To totalRepeticiones
        '    listBoxMostrar.Items.Add($"Esta linea ha sido repetida {i} veces")
        'Next

        'EJEMPLO2 - Decrement
        'For x As Integer = 25 To 0 Step -5
        '    listBoxMostrar.Items.Add($"El valor actual de X es de {x}")
        'Next


        'EJEMPLO3 - DO WHILE

        'Dim suma As Integer = 0
        'Dim contador As Integer = 0

        'Do While suma < 100
        '    '1era. suma = 0 + 20 = 20
        '    '2do. suma = 20 +20 = 40

        '    suma = suma + 20
        '    '1era. contador = 0 + 1 = 1
        '    '1era. contador = 1 + 1 = 2

        '    contador = contador + 1
        '    listBoxMostrar.Items.Add($"El valor de suma en este ciclo es de: {suma} y el valor de contador es de {contador}")
        'Loop


        'EJEMPLO4 - FIGURA
        '*
        '**
        '***
        '****
        ''*****
        'Dim filas As Integer = 5

        'For i As Integer = 1 To filas
        '    Dim linea As String = ""
        '    For j As Integer = 1 To i
        '        linea &= "*"
        '    Next
        '    listBoxMostrar.Items.Add(linea)
        'Next


        'EJEMPLO 5 - COMBOBOX
        'inicializar datos del combox
        Dim Descuentos As String() = {"Descuentos Premium", "Descuento Basico", "Descuento Medium"}

        'limpiar el combobox antes de agregar elementos nuevos
        comboBoxDatos.Items.Clear()

        'Utilizar ciclo
        For Each item As String In Descuentos
            comboBoxDatos.Items.Add(item)
        Next




    End Sub
End Class
