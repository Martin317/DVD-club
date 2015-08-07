Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeliculaNueva
    Dim cmd As SqlCommand

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtNombre.Text = "" Then
            ErrProviderPeliculaNueva.SetError(txtNombre, "El campo Nombre no puede estar Vacío")
            txtNombre.Focus()
        Else
            If txtIdioma.Text = "" Then
                ErrProviderPeliculaNueva.SetError(txtIdioma, "El campo Idioma no puede estar Vacío")
            Else
                If txtGenero.Text = "" Then
                    ErrProviderPeliculaNueva.SetError(txtGenero, "El campo Genero no puede estar Vacío")
                ElseIf dtpFechaLanzamiento.Value.Date > DateTime.Now.Date Then
                    ErrProviderPeliculaNueva.SetError(dtpFechaLanzamiento, "La fecha de lanzamiento no puede ser mayor a la fecha actual")
                Else
                    funcInsertarPelicula()
                End If
            End If
        End If

    End Sub
    Private Sub funcInsertarPelicula()
        Dim pelicula As New logPelicula
        pelicula.gNombre = txtNombre.Text
        pelicula.gIdioma = txtIdioma.Text
        pelicula.gGenero = txtGenero.Text
        pelicula.gFechaLanzamiento = Convert.ToDateTime(dtpFechaLanzamiento.Value)
        pelicula.gDescripcion = txtDescripcion.Text
        Dim funcPelicula As New fPelicula
        Dim ejecutado As Boolean = funcPelicula.insertarPelicula(pelicula)
        If ejecutado = True Then
            MessageBox.Show("Pelicula registrada con Éxito!", "Nueva pelicula", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescripcion.Clear()
            txtGenero.Clear()
            txtIdioma.Clear()
            txtNombre.Clear()
            dtpFechaLanzamiento.Value = DateTime.Now.Date
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub frmPeliculaNueva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaLanzamiento.Value = DateTime.Now.Date
    End Sub
    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
