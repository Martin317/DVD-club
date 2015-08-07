Public Class frmPeliculaEspecificaRegistrar

    Private Sub frmPeliculaEspecificaRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable

        Dim funcPelicula As New fPelicula
        dt = funcPelicula.mostrarPeliculasExistentes()
        If dt.Rows.Count > 0 Then
            cmbPelicula.DataSource = dt
            cmbPelicula.DisplayMember = "nombre"
            cmbPelicula.ValueMember = "pelicula_id"
        Else
            MessageBox.Show("No hay peliculas disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim funcPelicula As New fPelicula
        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
        Dim indice As Integer = row.Item("pelicula_id")
        If txtCantidadEjemplar.Text = "" Then
            ErrProviderPeliculaEspecificaRegistrar.SetError(txtCantidadEjemplar, "Este campo no puede estar vacío")
        Else
            If funcPelicula.insertarEjemplar(indice, txtCantidadEjemplar.Text) = True Then
                MessageBox.Show("Ejemplares cargados con exito!", "Registrar Ejemplar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCantidadEjemplar.Clear()


            End If

        End If
    End Sub

    Private Sub txtCantidadEjemplar_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadEjemplar.TextChanged

    End Sub
End Class