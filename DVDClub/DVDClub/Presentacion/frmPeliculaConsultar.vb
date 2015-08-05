Public Class frmPeliculaConsultar

    Private Sub frmPeliculaConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcPelicula As New fPelicula
        Dim dt As DataTable = funcPelicula.mostrarDatos()
        If dt.Rows.Count > 0 Then
            dgvPeliculasConsultar.DataSource = dt
        Else
            MessageBox.Show("No hay peliculas disponibles", "Peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub
End Class