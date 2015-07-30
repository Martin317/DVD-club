Public Class frmAlquilerRegistrar

    Private dt As New DataTable
    Private Sub frmAlquilerRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcMostrarClientes()
        funcMostrarPeliculas()
        cmbClientes.SelectedIndex = 0
        cmbPeliculas.SelectedIndex = 0
    End Sub

    Private Sub funcMostrarClientes()
        Dim clientes As New fAlquiler
        dt = clientes.mostrarDatos("C")
        dgvClientes.DataSource = dt
    End Sub

    Private Sub funcMostrarPeliculas()
        Dim peliculas As New fAlquiler
        dt = peliculas.mostrarDatos("P")
        dgvPeliculas.DataSource = dt
    End Sub


    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Dim respuesta As Integer = MessageBox.Show("¿Desea registrar los datos del alquiler?", "Confirmacion de alquiler",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = MsgBoxResult.Yes Then
            Dim clienteID As Integer = Convert.ToInt32(dgvClientes.CurrentRow.Cells(0).Value)
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPelicula_Click(sender As Object, e As EventArgs) Handles btnBuscarPelicula.Click
        Dim alquiler As New fAlquiler
        dt = alquiler.filtrar("P", cmbPeliculas.SelectedIndex, txtPeliculas.Text)
        dgvPeliculas.DataSource = dt

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim alquiler As New fAlquiler
        dt = alquiler.filtrar("C", cmbClientes.SelectedIndex, txtClientes.Text)
        dgvClientes.DataSource = dt
        dgvClientes.Refresh()
    End Sub


    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        frmClienteNuevo.ShowDialog()
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        frmClienteModificar.ShowDialog()
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