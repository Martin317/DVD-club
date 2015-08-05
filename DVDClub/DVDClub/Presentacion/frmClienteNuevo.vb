Public Class frmClienteNuevo

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtNombre.Text = "" Then
            ErrProviderClienteNuevo.SetError(txtNombre, "El campo nombre no puede estar vacio")
        ElseIf txtApellido.Text = "" Then
            ErrProviderClienteNuevo.SetError(txtApellido, "El campo apellido no puede estar vacio")
        ElseIf txtDNI.Text = "" Then
            ErrProviderClienteNuevo.SetError(txtDNI, "El campo DNI no puede estar vacio")
        ElseIf txtDireccion.Text = "" Then
            ErrProviderClienteNuevo.SetError(txtDireccion, "El campo direccion no puede estar vacio")
        ElseIf txtTelefono.Text = "" Then
            ErrProviderClienteNuevo.SetError(txtTelefono, "El campo telefono no puede estar vacio")
        Else
            ingresarCliente()
        End If

    End Sub
    Private Sub ingresarCliente()
        Dim estado As New logEstado
        estado.gEstadoID = 1
        Dim cliente As New logCliente
        cliente.gNombre = txtNombre.Text
        cliente.gApellido = txtApellido.Text
        cliente.gDni = txtDNI.Text
        cliente.gDireccion = txtDireccion.Text
        cliente.gEmail = txtEmail.Text
        cliente.gFechaDeAlta = DateTime.Now.Date
        cliente.gDadoDeBaja = False
        cliente.gEstado = estado
        cliente.gEsDeudor = False
        Dim funcCliente As New fCliente
        If funcCliente.ingresarCliente(cliente) Then
            MessageBox.Show("Cliente registrado con Éxito!", "Cliente nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmAlquilerRegistrar.funcMostrarClientes()
        End If

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class