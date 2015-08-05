Public Class frmClienteConsultar

    Private Sub frmClienteConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcClientes As New fCliente
        Dim dt As DataTable = funcClientes.mostrarDatos()
        If dt.Rows.Count > 0 Then
            cmbCliente.DataSource = dt
            cmbCliente.DisplayMember = "Cliente"
            cmbCliente.ValueMember = "cliente_id"
            If cmbCliente.Items.Count > 0 Then
                cmbCliente.SelectedIndex = 1
            End If
            llenarTextBox()
        Else
            MessageBox.Show("No hay clientes disponibles", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If


    End Sub
    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        llenarTextBox()
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
End Class