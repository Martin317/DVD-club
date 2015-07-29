Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeliculaNueva


    'Dim cmd As SqlCommand

    ''se le pasa a la variable conexion el String de conexion de nuestra BD
    ''Dim conexion As New SqlConnection("String de Conexion;")

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    '    'comprobacion de campos y guardado de pelicula en la BD

    '    If txtNombre.Text = "" Then
    '        MsgBox("El campo Nombre no puede estar Vacío", MsgBoxStyle.OkOnly)
    '    Else
    '        If txtIdioma.Text = "" Then
    '            MsgBox("El campo Idioma no puede estar Vacío", MsgBoxStyle.OkOnly)
    '        Else
    '            If txtGenero.Text = "" Then
    '                MsgBox("El campo Genero no puede estar Vacío", MsgBoxStyle.OkOnly)
    '            Else
    '                'Si todos los campos obligatorios estan correctos se ejecuta el Query
    '                Try
    '                    conectar()
    '                    cmd.CommandText = "insert into Pelicula (nombre, idioma, genero, fecha_lanzamiento, descripcion) Values ( '" & txtNombre.Text & "',  '" & txtIdioma.Text & "',  '" & txtGenero.Text & "',  '" & dtpFechaLanzamiento.Text & "',  '" & txtGenero.Text & "')"
    '                    cmd.Connection = cnn
    '                    cmd.ExecuteNonQuery()
    '                    MsgBox("Pelicula Registrado con Éxito!", MsgBoxStyle.OkOnly)

    '                Catch ex As Exception
    '                    MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes y peliculas." &
    '                                    Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
    '                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

    '                Finally
    '                    desconectar()
    '                End Try
    '            End If
    '        End If
    '    End If

    'End Sub


    'Private Sub frmPeliculaNueva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class
