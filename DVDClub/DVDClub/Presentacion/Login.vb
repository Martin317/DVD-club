Public Class Login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtContraseña.Text = "" Or txtUsuario.Text = "" Then
            MsgBox("¡Ningun campo puede estar vacio!", MsgBoxStyle.OkOnly, "Notificación")
        Else
            'TODO Comparar los textos usuario y contraseña con los de la tabla Usuarios de la BD
            Dim funcUsuario As New fUsuario
            Dim usuario As New logUsuario
            usuario.gNombreUsuario = txtUsuario.Text
            usuario.gContrasenia = txtContraseña.Text
            Dim correcto As Boolean = funcUsuario.comprobarDatos(usuario)
            If correcto = True Then
                frmAlquilerRegistrar.Show()
                Me.Visible = False
            Else
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Critical, "Error!")
                txtContraseña.Clear()
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class