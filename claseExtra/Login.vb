Imports MySql.Data.MySqlClient

Public Class Login
    Dim connection As MySqlConnection
    Dim comandos As MySqlCommand

    Private Sub buttonIrLogin_Click(sender As Object, e As EventArgs) Handles buttonIrLogin.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexionBD()
    End Sub
End Class
