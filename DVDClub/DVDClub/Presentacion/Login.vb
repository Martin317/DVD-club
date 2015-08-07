Public Class Login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresar()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub ingresar()
        If txtUsuario.Text = "" Then
            ErrProviderLogin.SetError(txtUsuario, "Debe ingresar un usuario")
        ElseIf txtContraseña.Text = "" Then
            ErrProviderLogin.SetError(txtContraseña, "Debe ingresar una contraseña")
        Else
            Dim funcUsuario As New fUsuario
            Dim usuario As New logUsuario
            usuario.gNombreUsuario = txtUsuario.Text
            usuario.gContrasenia = txtContraseña.Text
            Dim correcto As Boolean = funcUsuario.comprobarDatos(usuario)
            If correcto = True Then
                frmPrincipal.Show()
                Me.Visible = False
            Else
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Critical, "Error!")
                txtContraseña.Clear()
            End If
        End If
    End Sub
    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyData = Keys.Enter Then
            ingresar()
        End If
    End Sub
    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            ingresar()
        End If
    End Sub


End Class