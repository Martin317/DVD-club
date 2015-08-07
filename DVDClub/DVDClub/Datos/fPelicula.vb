Imports System.Data.SqlClient

Public Class fPelicula
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function insertarPelicula(pelicula As logPelicula) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procInsertarPelicula")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Nombre", pelicula.gNombre)
            cmd.Parameters.AddWithValue("@Idioma", pelicula.gIdioma)
            cmd.Parameters.AddWithValue("@Genero", pelicula.gGenero)
            cmd.Parameters.AddWithValue("@FechaLanzamiento", pelicula.gFechaLanzamiento)
            cmd.Parameters.AddWithValue("@Descripcion", pelicula.gDescripcion)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar una nueva pelicula." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
    Public Function modificarPelicula(pelicula As logPelicula) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procModificarPelicula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nombre", pelicula.gNombre)
            cmd.Parameters.AddWithValue("@Idioma", pelicula.gIdioma)
            cmd.Parameters.AddWithValue("@Genero", pelicula.gGenero)
            cmd.Parameters.AddWithValue("@FechaLanzamiento", pelicula.gFechaLanzamiento)
            cmd.Parameters.AddWithValue("@Descripcion", pelicula.gDescripcion)
            cmd.Parameters.AddWithValue("@ID", pelicula.gPeliculaID)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de modificar la Pelicula." &
              Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
    Public Function mostrarDatosPeliculas() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("procMostraPeliculasCombo")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure

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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar las peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function mostrarEjemplaresDisponibles(ByVal num As Integer) As DataTable
        Try
            conectar()
            cmd = New SqlCommand("mostrarEjemplaresDisponibles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@peliculaID", num)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los ejemplares disponibles de las peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function mostrarDatos() As DataTable

        Try
            conectar()
            cmd = New SqlCommand("procMostrarPeliculas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar las peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function bajaPelicula(idPelicula As Integer) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procBajaPelicula")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("IDPelicula", idPelicula)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de dar de baja la pelicula." &
                         Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function

    Public Function insertarEjemplar(pelicula_id As Integer, cantidad As Integer) As Boolean

        Try
            conectar()

            cmd = New SqlCommand("procInsertarEjemplar")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Pelicula_id", pelicula_id)
            For i = 1 To cantidad
                cmd.ExecuteNonQuery()
            Next
            Return True

        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de insertar ejemplar." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function

    Public Function mostrarPeliculasExistentes()

        Try
            conectar()
            cmd = New SqlCommand("procMostrarPeliculasExistentes")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure

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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar las peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function

    Public Function bajaEjemplares(cantidad As Integer, id As Integer) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procBajaEjemplar")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Id", id)
            For i = 1 To cantidad
                cmd.ExecuteNonQuery()
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de dar de baja ejemplar." &
                                    Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function traerEjemplaresDisponibles(id As Integer) As Integer
        Try
            conectar()
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT COUNT(pelicula_especifica.pelicula_especifica_id) FROM pelicula_especifica INNER JOIN estado ON(estado.estado_id = pelicula_especifica.estado) WHERE estado.estado_id = 5 And pelicula_especifica.pelicula = '" & id & "'"
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand = cmd
                da.Fill(dt)
                Return Convert.ToInt32(dt(0)(0))
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de dar de baja ejemplar." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class
