Public Class Login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtContraseña.Text = "" Or txtUsuario.Text = "" Then
            MsgBox("¡Ningun campo puede estar vacio!", MsgBoxStyle.OkOnly, "Notificación")
        Else
            'TODO Comparar los textos usuario y contraseña con los de la tabla Usuarios de la BD
            MsgBox("Ha ingresado correctamente a DVDClub", MsgBoxStyle.Exclamation, "Bienvenido!")
            frmAlquilerRegistrar.Show()
        End If
        Me.Visible = False

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class