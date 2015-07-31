Imports System.Data.SqlClient

Public Class fPelicula
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Sub insertarPelicula()
        Try

            conectar()
            cmd.CommandText = "insert into Pelicula (nombre, idioma, genero, fecha_lanzamiento, descripcion) Values ( '" & frmPeliculaNueva.txtNombre.Text & "',  '" & frmPeliculaNueva.txtIdioma.Text & "',  '" & frmPeliculaNueva.txtGenero.Text & "',  '" & frmPeliculaNueva.dtpFechaLanzamiento.Text & "',  '" & frmPeliculaNueva.txtGenero.Text & "')"
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            MsgBox("Pelicula Registrado con Éxito!", MsgBoxStyle.OkOnly)

        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes y peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try

    End Sub
    Public Sub modificarPelicula()
        Try
            conectar()
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE Pelicula SET nombre=( '" & frmPeliculaModificar.txtNombre.Text & "'), idioma=( '" & frmPeliculaModificar.txtIdioma.Text & "'),genero=( '" & frmPeliculaModificar.txtGenero.Text & "'),fecha_lanzamiento=( '" & frmPeliculaModificar.dtpFechaLanzamiento.Text & "'),descripcion=( '" & frmPeliculaModificar.txtDescripcion.Text & "') WHERE pelicula_id=( '" & frmPeliculaModificar.intId & "')"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de Actualizar la Pelicula." &
              Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try

    End Sub
    Public Function mostrardatos()

        Try
            conectar()
            cmd.Connection = cnn
            cmd.CommandText = "Select nombre as Pelicula, * from pelicula"
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand = cmd
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes y peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function


End Class
