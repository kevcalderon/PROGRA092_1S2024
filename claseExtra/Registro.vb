Imports MySql.Data.MySqlClient

Public Class Registro


    Private Sub buttonBackRegistro_Click(sender As Object, e As EventArgs) Handles buttonBackRegistro.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlQuery = $"INSERT INTO Usuario (Nombre, Username, PasswordHash, TipoUsuario) VALUES ('{textNombre.Text}', '{textUsuario.Text}', '{textContra.Text}', 'Cliente');"
        Dim reader As MySqlDataReader
        commands = New MySqlCommand(sqlQuery, connection)
        reader = commands.ExecuteReader
        MsgBox("Usuario ingresado con exito.")
    End Sub
End Class