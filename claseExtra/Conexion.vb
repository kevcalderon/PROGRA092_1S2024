Imports MySql.Data.MySqlClient

Module Conexion
    Public connection As MySqlConnection
    Public commands As MySqlCommand

    Sub conexionBD()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userId=root;password='';database=clase7"
        Try
            connection.Open()
            MsgBox("Conexion correctamente a BD!!!! :)")
        Catch ex As Exception
            MsgBox("Error al conectarme, no funciono :C")
            connection.Close()
        End Try
    End Sub
End Module
