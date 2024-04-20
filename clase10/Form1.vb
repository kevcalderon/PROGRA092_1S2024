Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If listUsuarios.SelectedIndex <> -1 Then
            Dim elementoSeleccionado As String = listUsuarios.SelectedItem.ToString()
            '1,NOMBRE,APELLIDO
            Dim separacion As String() = elementoSeleccionado.Split(","c)
            '[1],[NOMBRE],[APELLIDO]
            Dim idUsuario As String = separacion(0)

            'eliminar el usuario en listbox
            listUsuarios.Items.RemoveAt(listUsuarios.SelectedIndex)

            'eliminar a nivel de bd
            Dim connectionString As String = "server=localhost;userId=root;password='';database=clase9"
            Dim consulta As String = "DELETE FROM Usuario WHERE id = @id"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(consulta, connection)
                    command.Parameters.AddWithValue("id", idUsuario)
                    command.ExecuteNonQuery()
                End Using
            End Using

            'update USUARIO
            'Dim connectionString As String = "server=localhost;userId=root;password='';database=clase9"
            'Dim consulta As String = "UPDATE Usuario SET nombre=@nombre, apellido=@apellido WHERE id=@id" 

            'Using connection As New MySqlConnection(connectionString)
            '    connection.Open()
            '    Using command As New MySqlCommand(consulta, connection)
            '        command.Parameters.AddWithValue("id", idUsuario)
            '        Command.Parameters.AddWithValue("nombre", textboxNombre.Text)
            '        Command.Parameters.AddWithValue("apellido", textboxApellido.Text)
            '        command.ExecuteNonQuery()
            '    End Using
            'End Using
        End If
    End Sub

    Private Sub conectar_Click(sender As Object, e As EventArgs) Handles conectar.Click
        Dim connectionString As String = "server=localhost;userId=root;password='';database=clase9"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim tabla As String = "SELECT id, nombre, apellido FROM Usuario"
        Dim command As New MySqlCommand(tabla, connection)
        Dim lectura As MySqlDataReader = command.ExecuteReader()

        listUsuarios.Items.Clear()

        While lectura.Read()
            'GetString -> varchar
            'GetUInt16/32 -> enteros
            listUsuarios.Items.Add(lectura.GetUInt32("id").ToString + "," + lectura.GetString("nombre") + "," + lectura.GetString("apellido"))
        End While
        connection.Close()
    End Sub
End Class
