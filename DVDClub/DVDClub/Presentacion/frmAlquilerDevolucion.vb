Public Class frmAlquilerDevolucion

    Private Sub frmAlquilerDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcCliente As New fCliente
        Dim dt As DataTable = funcCliente.mostrarClientesConAlquiler()
        If dt.Rows.Count > 0 Then
            cmbCliente.DataSource = dt
            cmbCliente.DisplayMember = "Cliente"
            cmbCliente.ValueMember = "cliente_id"
        Else
            ErrProviderDevolucionAlquiler.SetError(cmbCliente, "No hay ningun cliente que haya realizado un alquiler")
        End If

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        Dim row As DataRowView = DirectCast(cmbCliente.SelectedItem, DataRowView)
        Dim funcAlquiler As New fAlquiler
        Dim dt As DataTable = funcAlquiler.mostrarAlquiler(row.Item("cliente_id"))
        If dt.Rows.Count > 0 Then
            dgvAlquileres.DataSource = dt
            dgvAlquileres.Columns(1).Width = 150
            dgvAlquileres.Columns(2).Width = 150
            dgvAlquileres.Columns(0).Visible = False
        End If
    End Sub
    Private Sub dgvAlquileres_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlquileres.SelectionChanged
        'TODO Fecha detalle a calcular porque no podemos

        
        If dgvAlquileres.CurrentRow IsNot Nothing Then
            Dim fechaActual = Convert.ToDateTime(System.DateTime.Now.ToShortDateString)
            Dim fechaVieja = dgvAlquileres.CurrentRow.Cells(1).Value
            Dim dias As Integer = DateDiff(DateInterval.Day, fechaVieja, fechaActual)
            If dias >= 1 Then
                lblDeudor.Visible = True
                If dias <> 1 Then
                    lblTiempo.Text = dias & " días"
                Else
                    lblTiempo.Text = dias & " día"
                End If

            Else
                lblDeudor.Visible = False
                lblTiempo.Text = ""
            End If
                Dim funcDetalleAlquiler As New fDetalleAlquiler
                Dim alquilerID As Integer = CType(dgvAlquileres.CurrentRow.Cells(0).Value, Integer)
                Dim dt As DataTable = funcDetalleAlquiler.mostrarDetalles(alquilerID)
                If dt.Rows.Count > 0 Then
                    dgvDetalleAlquiler.DataSource = dt
                End If
            End If



    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim funcAlquiler As New fAlquiler
        Dim alquilerID As Integer = CType(dgvAlquileres.CurrentRow.Cells(0).Value, Integer)
        Dim dt As New DataTable
        If funcAlquiler.registrarDevolucion(alquilerID) = True Then
            MessageBox.Show("Devolución registrada con Éxito!", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim funcPeliculaEspecifica As New fPeliculaEspecifica
            'dt = funcPeliculaEspecifica.SeleccionarPeliculasAlquiladas(alquilerID)
            funcPeliculaEspecifica.actualizarDevolucionEjemplar()

            'For Each row In dt.Rows
            '    Dim peliculaEspecificaID As Integer
            '    peliculaEspecificaID = row.item("pelicula_especifica_id")
            '    funcPeliculaEspecifica.actualizarDevolucionEjemplar()

            'Next row
            Me.Close()
        End If
    End Sub

End Class