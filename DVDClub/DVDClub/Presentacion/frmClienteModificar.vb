Public Class frmClienteModificar

    Private Sub frmClienteModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcCliente As New fCliente
        Dim dt As DataTable = funcCliente.mostrarDatos()
        cmbCliente.DataSource = dt
        cmbCliente.ValueMember = "cliente_id"
        cmbCliente.DisplayMember = "Cliente"
        If cmbCliente.Items.Count > 0 And frmAlquilerRegistrar.cmbBuscarClientes.SelectedIndex <> -1 Then
            cmbCliente.SelectedItem = frmAlquilerRegistrar.cmbBuscarClientes.SelectedItem
            llenarTextBox()
        End If

    End Sub
    Private Sub llenarTextBox()
        Dim row As DataRowView = DirectCast(cmbCliente.SelectedItem, DataRowView)
        txtNumero.Text = row.Item("cliente_id").ToString
        txtNombre.Text = row.Item("nombre").ToString
        txtApellido.Text = row.Item("apellido").ToString
        txtDNI.Text = row.Item("dni").ToString
        txtDireccion.Text = row.Item("direccion").ToString
        txtTelefono.Text = row.Item("telefono").ToString
        txtEmail.Text = row.Item("email").ToString
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub
    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        llenarTextBox()
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtNombre.Text = "" Then
            ErrProviderClienteModificar.SetError(txtNombre, "El campo nombre no puede estar vacio")
        ElseIf txtApellido.Text = "" Then
            ErrProviderClienteModificar.SetError(txtApellido, "El campo apellido no puede estar vacio")
        ElseIf txtDNI.Text = "" Then
            ErrProviderClienteModificar.SetError(txtDNI, "El campo DNI no puede estar vacio")
        ElseIf txtDireccion.Text = "" Then
            ErrProviderClienteModificar.SetError(txtDireccion, "El campo direccion no puede estar vacio")
        ElseIf txtTelefono.Text = "" Then
            ErrProviderClienteModificar.SetError(txtTelefono, "El campo telefono no puede estar vacio")
        Else
            modificarCliente()
        End If

    End Sub
    Public Sub modificarCliente()
        Dim cliente As New logCliente
        cliente.gNombre = txtNombre.Text
        cliente.gApellido = txtApellido.Text
        cliente.gDireccion = txtDireccion.Text
        cliente.gDni = txtDNI.Text
        cliente.gEmail = txtEmail.Text
        cliente.gTelefono = txtTelefono.Text
        cliente.gClienteID = txtNumero.Text
        Dim funcCliente As New fCliente
        If funcCliente.modificarCliente(cliente) Then
            MessageBox.Show("Cliente modificado con Éxito!", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

