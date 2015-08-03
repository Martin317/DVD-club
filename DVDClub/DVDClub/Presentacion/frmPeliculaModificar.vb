﻿Imports System.Data
Imports System.Data.SqlClient



Public Class frmPeliculaModificar
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter(cmd)
    Public intId As Integer

    Private Sub PeliculaModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcMostrarDatos()
    End Sub

    Private Sub cmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        'Cuando cambia el objeto seleccionado del ComboBox, se actualizan los datos de los TextBox correspondientes

        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
        txtNombre.Text = row.Item("nombre").ToString
        txtIdioma.Text = row.Item("idioma").ToString
        txtGenero.Text = row.Item("genero").ToString
        dtpFechaLanzamiento.Text = row.Item("fecha_lanzamiento").ToString
        txtDescripcion.Text = row.Item("descripcion").ToString
        intId = row.Item("pelicula_id").ToString
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    
        'Actualizacion de los valores en la BD de el elemento seleccionado en el ComboBox
        If txtNombre.Text = "" Then
            MsgBox("El campo Nombre no puede estar Vacío", MsgBoxStyle.OkOnly)
        Else
            If txtIdioma.Text = "" Then
                MsgBox("El campo Idioma no puede estar Vacío", MsgBoxStyle.OkOnly)
            Else
                If txtGenero.Text = "" Then
                    MsgBox("El campo Genero no puede estar Vacío", MsgBoxStyle.OkOnly)
                Else
                    funcModificarPelicula()
                End If
            End If
        End If

        MsgBox("¡Se modificaron los datos exitosamente!", MsgBoxStyle.OkOnly, "Notificación")

    End Sub

    Private Sub funcModificarPelicula()
        Dim pelicula As New logPelicula
        pelicula.gNombre = txtNombre.Text
        pelicula.gIdioma = txtIdioma.Text
        pelicula.gGenero = txtGenero.Text
        pelicula.gDescripcion = txtDescripcion.Text
        dtpFechaLanzamiento.Format = DateTimePickerFormat.Custom
        dtpFechaLanzamiento.CustomFormat = "yyyy-mm-dd"
        pelicula.gFechaLanzamiento = Convert.ToDateTime(dtpFechaLanzamiento.Value)
        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
        pelicula.gPeliculaID = row.Item("pelicula_id")
        Dim funcPelicula As New fPelicula
        funcPelicula.modificarPelicula(pelicula)
    End Sub

    Private Sub funcMostrarDatos()
        Dim funcPelicula As New fPelicula
        Dim dt As DataTable = funcPelicula.mostrarDatosPeliculas()
        cmbPelicula.DataSource = dt
        cmbPelicula.DisplayMember = "Pelicula"
        cmbPelicula.ValueMember = "pelicula_id"
    End Sub
   
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub
End Class