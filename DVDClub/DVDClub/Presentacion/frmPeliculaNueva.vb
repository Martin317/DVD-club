Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeliculaNueva


    Dim cmd As SqlCommand

    'se le pasa a la variable conexion el String de conexion de nuestra BD
    'Dim conexion As New SqlConnection("String de Conexion;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'comprobacion de campos y guardado de pelicula en la BD

        If txtNombre.Text = "" Then
            MsgBox("El campo Nombre no puede estar Vacío", MsgBoxStyle.OkOnly)
        Else
            If txtIdioma.Text = "" Then
                MsgBox("El campo Idioma no puede estar Vacío", MsgBoxStyle.OkOnly)
            Else
                If txtGenero.Text = "" Then
                    MsgBox("El campo Genero no puede estar Vacío", MsgBoxStyle.OkOnly)
                Else
                    funcInsertarPelicula()
                End If
            End If
        End If

    End Sub


    

    Private Sub funcInsertarPelicula()
        Dim Pelicula As New fPelicula
        Pelicula.insertarPelicula()

    End Sub
End Class
