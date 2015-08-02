Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtContraseña.Text = "" Or txtUsuario.Text = "" Then
            MsgBox("¡Ningun campo puede estar vacio!", MsgBoxStyle.OkOnly, "Notificación")
        Else
            'TODO Comparar los textos usuario y contraseña con los de la tabla Usuarios de la BD
            MsgBox("Ha ingresado correctamente a DVDClub", MsgBoxStyle.Exclamation, "Bienvenido!")
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class