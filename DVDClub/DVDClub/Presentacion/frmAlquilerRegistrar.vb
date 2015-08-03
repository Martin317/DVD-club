Public Class frmAlquilerRegistrar
    Private dt As New DataTable
    Private primeraVez As Boolean
    Private Sub frmAlquilerRegistrar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcMostrarClientes()
        funcMostrarPeliculas()
        cmbPeliculas.SelectedIndex = 0
        primeraVez = True
        dgvDetalles.DataSource = Nothing
    End Sub
    Private Sub funcMostrarClientes()
        Dim clientes As New fCliente
        dt = clientes.mostrarDatos()
        cmbBuscarClientes.DataSource = dt
        cmbBuscarClientes.DisplayMember = "Cliente"
        cmbBuscarClientes.ValueMember = "cliente_id"
    End Sub

    Private Sub funcMostrarPeliculas()
        Dim peliculas As New fPelicula
        dt = peliculas.mostrarDatos()
        dgvPeliculas.DataSource = dt
        dgvPeliculas.Columns(1).Visible = False
        dgvPeliculas.Columns(2).Width = 210
    End Sub

    Private Sub btnBuscarPelicula_Click(sender As Object, e As EventArgs) Handles btnBuscarPelicula.Click
        Dim peliculas As New fPelicula
        dt = peliculas.filtrar(cmbPeliculas.SelectedIndex, txtPeliculas.Text)
        dgvPeliculas.DataSource = dt
        'TODO Cuando se selecciona una pelicula y se busca otra, se borra la seleccion ._.
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim respuesta As Integer = MessageBox.Show("¿Desea registrar los datos del alquiler?", "Confirmacion de alquiler",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = MsgBoxResult.Yes Then
            Dim cliente As New logCliente
            cliente.gClienteID = Convert.ToInt32(txtNumero.Text)
            Dim alquiler As New logAlquiler
            alquiler.gCliente = cliente
            alquiler.gFechaEntrega = System.DateTime.Now.ToString("yyyy/mm/dd")
            alquiler.gHoraEntrega = System.DateTime.Now.ToString("hh:mm:ss")  
            'TODO Agregar datos de Sesion.
            Dim usuario As logUsuario
            Dim sesion As logSesion
            sesion.gSesionID = 1
            alquiler.gSesion = sesion

            Dim peliculasID As New List(Of Integer)
            For Each dr As DataGridViewRow In Me.dgvPeliculas.Rows
                If dr.Cells(0).Value = True Then
                    peliculasID.Add(Convert.ToInt32(dr.Cells(1).Value))
                End If
            Next

            Dim funcAlquiler As New fAlquiler
            funcAlquiler.insertarAlquiler(alquiler)
<<<<<<< HEAD
            Dim funcPeliculaEspecfica As New fPeliculaEspecifica
            funcPeliculaEspecfica.actualizarEstadoPelicula()
            Dim funcCliente As New fCliente
            funcCliente.actualizarEstadoCliente(CType(txtNumero.Text, Integer))
=======
            Dim peliculaEspecfica As New fPeliculaEspecifica
            'peliculaEspecfica.actualizarEstadoPelicula()
>>>>>>> origin/master
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

    'Funcion que inserta un ejemplar disponible de cada pelicula seleccionada en el dgvDetalles
    Private Sub btnAgregarADetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarADetalle.Click
        If primeraVez = True Then
            Dim peliculasID As New List(Of Integer)
            For Each dr As DataGridViewRow In Me.dgvPeliculas.Rows
                If dr.Cells(0).Value = True Then
                    peliculasID.Add(Convert.ToInt32(dr.Cells(1).Value))
                End If
            Next
            Dim num As Integer
            Dim peliculas As New fPelicula
            Dim dtTemp As New DataTable
            For Each num In peliculasID
                dt = peliculas.mostrarEjemplaresDisponibles(num)
                dtTemp = TryCast(dgvDetalles.DataSource, DataTable)
                If Not (dtTemp Is Nothing) Then
                    For Each row As DataRow In dtTemp.Rows
                        dt.ImportRow(row)
                    Next
                    dgvDetalles.DataSource = dt
                    dgvPeliculas.Refresh()
                Else
                    dgvDetalles.DataSource = dt
                    dgvPeliculas.Refresh()
                End If
                'TODO cambiar estado del ejemplar a no disponible
            Next
            primeraVez = False
        End If
        dgvDetalles.Columns(0).Width = 150
        dgvDetalles.Columns(1).Width = 210
    End Sub
End Class