Imports System.Data.SqlClient

Public Class fAlquiler
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Function mostrarDatos(ByVal opcion As Char) As DataTable

        Try
            conectar()
            If (opcion = "C") Then
                cmd = New SqlCommand("procMostrarClientes")
            ElseIf (opcion = "P") Then
                cmd = New SqlCommand("procMostrarPeliculas")
            End If
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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes y peliculas." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function filtrar(ByVal opcion As Char, ByVal index As Integer, ByVal text As String) As DataTable
        Try
            conectar()
            If opcion = "P" Then
                Select Case index
                    Case 0
                        cmd = New SqlCommand("procFiltrarPeliculasNombre")
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@Nombre", "%" + text + "%")

                        If cmd.ExecuteNonQuery Then
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                            Return dt
                        Else
                            Return Nothing
                        End If
                    Case 1
                        cmd = New SqlCommand("procFiltrarPeliculasGenero")
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@Genero", "%" + text + "%")

                        If cmd.ExecuteNonQuery Then
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                            Return dt
                        Else
                            Return Nothing
                        End If
                    Case 2
                        cmd = New SqlCommand("procFiltrarPeliculasIdioma")
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@Idioma", "%" + text + "%")

                        If cmd.ExecuteNonQuery Then
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                            Return dt
                        Else
                            Return Nothing
                        End If
                End Select
            ElseIf opcion = "C" Then
                Select Case index
                    Case 0
                        cmd = New SqlCommand("procFiltrarClientesNombre")
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@Nombre", "%" + text + "%")
                        If cmd.ExecuteNonQuery Then
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                            Return dt
                        Else
                            Return Nothing
                        End If
                    Case 1
                        cmd = New SqlCommand("procFiltrarClientesApellido")
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@Apellido", "%" + text + "%")
                        If cmd.ExecuteNonQuery Then
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                            Return dt
                        Else
                            Return Nothing
                        End If
                    Case 2
                        Dim dni = CType(text, Integer)
                        cmd = New SqlCommand("procFiltrarClientesDNI")
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@DNI", dni)
                        If cmd.ExecuteNonQuery Then
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                            Return dt
                        Else
                            Return Nothing
                        End If
                End Select

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
    Public Sub insertarAlquiler(ByVal idCliente As Integer, ByVal idPelicula As Integer)
        Try
            conectar()
            cmd = New SqlCommand("procInsertarAlquiler")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDCliente", idCliente)
            cmd.Parameters.AddWithValue("@IDPelicula", idPelicula)

            'TODO Cambiar estado de cliente inactivo a activo.
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar el alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            desconectar()
        End Try

    End Sub

End Class
