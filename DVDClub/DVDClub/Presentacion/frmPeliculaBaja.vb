Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeliculaBaja
    Dim comando As New SqlCommand
    Dim cliente As New DataTable
    Dim adaptador As New SqlDataAdapter
    Dim intID As Integer

    Private Sub cmbAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        'intID = row.Item("pelicula_id").ToString
        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
    End Sub
    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim funcPelicula As New fPelicula
        Dim idPelicula As Integer = cmbPelicula.SelectedValue
        If funcPelicula.bajaPelicula(idPelicula) Then
            MessageBox.Show("¡La Pelicula fue correctamente dada de baja!", "Baja pelicula", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub frmPeliculaBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcPelicula As New fPelicula
        Dim dt As DataTable = funcPelicula.mostrarDatosPeliculas()
        cmbPelicula.DataSource = dt
        cmbPelicula.DisplayMember = "nombre"
        cmbPelicula.ValueMember = "pelicula_id"
        'TODO cambiar en la ERS que da de baja todos los ejemplares de la pelicula, y no la pelicula en si.
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub
End Class