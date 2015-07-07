Public Class Form1

    
    Private Sub btnNuevaPelicula_Click(sender As Object, e As EventArgs) Handles btnNuevaPelicula.Click
        PeliculaNueva.Show()
    End Sub

    Private Sub btnModificarPelicula_Click(sender As Object, e As EventArgs) Handles btnModificarPelicula.Click
        PeliculaConsultar.Show()
    End Sub

    Private Sub btnConsultarPelicula_Click(sender As Object, e As EventArgs) Handles btnConsultarPelicula.Click
        PeliculaModificar.Show()
    End Sub

    Private Sub btnBajaPelicula_Click(sender As Object, e As EventArgs) Handles btnBajaPelicula.Click
        PeliculaBaja.Show()
    End Sub
End Class
