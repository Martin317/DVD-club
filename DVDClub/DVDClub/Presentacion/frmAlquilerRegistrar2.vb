Public Class frmAlquilerRegistrar2
    Private dt As New DataTable
    Private Sub frmAlquilerRegistrar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcMostrarClientes()
        funcMostrarPeliculas()
        cmbPeliculas.SelectedIndex = 0

    End Sub
    Private Sub funcMostrarClientes()
        Dim clientes As New fAlquiler
        dt = clientes.mostrarDatos("C")
        cmbBuscarClientes.DataSource = dt
        cmbBuscarClientes.DisplayMember = "Cliente"
        cmbBuscarClientes.ValueMember = "cliente_id"
    End Sub

    Private Sub funcMostrarPeliculas()
        Dim peliculas As New fAlquiler
        dt = peliculas.mostrarDatos("P")
        dgvPeliculas.DataSource = dt
    End Sub

    Private Sub btnBuscarPelicula_Click(sender As Object, e As EventArgs) Handles btnBuscarPelicula.Click
        Dim alquiler As New fAlquiler
        dt = alquiler.filtrar(cmbPeliculas.SelectedIndex, txtPeliculas.Text)
        dgvPeliculas.DataSource = dt
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim respuesta As Integer = MessageBox.Show("¿Desea registrar los datos del alquiler?", "Confirmacion de alquiler",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = MsgBoxResult.Yes Then
            Dim clienteID As Integer = Convert.ToInt32(txtNumero.Text)
            Dim peliculasID As New List(Of Integer)
            For Each dr As DataGridViewRow In Me.dgvPeliculas.Rows
                If dr.Cells(0).Value = True Then
                    peliculasID.Add(Convert.ToInt32(dr.Cells(1).Value))
                End If
            Next
            MsgBox(peliculasID(0))
            MsgBox(peliculasID(1))
            ' alquiler.insertarAlquiler()
            'TODO Cambiar estado de cliente inactivo a activo.
        End If
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        frmClienteNuevo.ShowDialog()
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        frmClienteModificar.ShowDialog()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    'Llenar textboxs
    Private Sub cmbBuscarClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscarClientes.SelectedIndexChanged
        Dim row As DataRowView = DirectCast(cmbBuscarClientes.SelectedItem, DataRowView)
        txtNumero.Text = row.Item("cliente_id").ToString
        txtNombre.Text = row.Item("nombre").ToString
        txtApellido.Text = row.Item("apellido").ToString
        txtDni.Text = row.Item("dni").ToString
        txtDireccion.Text = row.Item("direccion").ToString
        txtTelefono.Text = row.Item("telefono").ToString
        txtEmail.Text = row.Item("email").ToString
        If row.Item("es_deudor") = True Then
            checkBoxDeudor.Checked = True
        Else
            checkBoxDeudor.Checked = False
        End If

    End Sub
    Private Sub dgvPeliculas_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvPeliculas.CellContentClick
        'Cambio de estado del Checkbox
        If e.ColumnIndex = Me.clmSeleccionarPelicula.Index Then
            Dim value As Boolean = CType(Me.dgvPeliculas.CurrentCell.EditedFormattedValue, Boolean)
            If value = True Then
                Me.dgvPeliculas.CurrentCell.Value = False
            Else
                Me.dgvPeliculas.CurrentCell.Value = True
            End If
        End If
    End Sub


End Class