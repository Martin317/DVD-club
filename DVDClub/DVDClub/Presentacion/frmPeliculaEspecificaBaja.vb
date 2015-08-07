Public Class frmPeliculaEspecificaBaja

    Private Sub frmPeliculaEspecificaBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim funcPelicula As New fPelicula
        dt = funcPelicula.mostrarDatosPeliculas()
        If dt.Rows.Count > 0 Then
            cmbPelicula.DataSource = dt
            cmbPelicula.DisplayMember = "nombre"
            cmbPelicula.ValueMember = "pelicula_id"
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtCantidadEjemplares.Text = "" Then
            ErrProviderBajaPeliculaEspecifica.SetError(txtCantidadEjemplares, "Este campo no debe estar vacio")
        Else
            If CType(txtCantidadEjemplares.Text, Integer) < CType(txtDisponibles.Text, Integer) Then
                Dim funcPelicula As New fPelicula
                Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
                Dim indice As Integer = row.Item("pelicula_id")
                If funcPelicula.bajaEjemplares(txtCantidadEjemplares.Text, indice) = True Then
                    MessageBox.Show("Se han dado de baja " & txtCantidadEjemplares.Text & " ejemplares con exito!", "Registrar Ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtDisponibles.Text = funcPelicula.traerEjemplaresDisponibles(row.Item("pelicula_id"))
                End If
            Else
                ErrProviderBajaPeliculaEspecifica.SetError(txtCantidadEjemplares, "No puede ser mayor a la cantidad disponible")
            End If
        End If
    End Sub

    Private Sub cmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        Dim funcPelicula As New fPelicula
        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
        txtDisponibles.Text = funcPelicula.traerEjemplaresDisponibles(row.Item("pelicula_id"))
    End Sub
End Class