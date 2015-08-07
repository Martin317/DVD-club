Imports System.Data.SqlClient
Public Class fCliente
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function mostrarDatos() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("procMostrarClientes")
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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Sub actualizarEstadoCliente(numero As Integer)
        Try
            conectar()
            cmd = New SqlCommand
            'Traer estado del cliente con ese id
            cmd.Connection = cnn
            cmd.CommandText = "SELECT cliente.estado FROM cliente WHERE cliente.cliente_id = ( '" & numero & "')"
            Dim dt As New DataTable
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand = cmd
                da.Fill(dt)
            End If
            'Guardar el estado en la variable
            Dim estadoCliente As Integer = dt(0)(0)
            If estadoCliente = 4 Then
                cmd = New SqlCommand("procActualizarEstadoCliente")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@IDCliente", numero)
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de actualizar el estado del cliente." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Public Function ingresarCliente(cliente As logCliente) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procInsertarCliente")
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Nombre", cliente.gNombre)
            cmd.Parameters.AddWithValue("@Apellido", cliente.gApellido)
            cmd.Parameters.AddWithValue("@Dni", cliente.gDni)
            cmd.Parameters.AddWithValue("@Telefono", cliente.gTelefono)
            cmd.Parameters.AddWithValue("@Email", cliente.gEmail)
            cmd.Parameters.AddWithValue("@FechaDeAlta", cliente.gFechaDeAlta)
            cmd.Parameters.AddWithValue("@EstadoID", (cliente.gEstado).gEstadoID)
            cmd.Parameters.AddWithValue("@EsDeudor", cliente.gEsDeudor)
            cmd.Parameters.AddWithValue("@DadoDeBaja", cliente.gDadoDeBaja)
            cmd.Parameters.AddWithValue("@Direccion", cliente.gDireccion)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar un nuevo cliente." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
    Public Function modificarCliente(cliente As logCliente) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procModificarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@ID", cliente.gClienteID)
            cmd.Parameters.AddWithValue("@Nombre", cliente.gNombre)
            cmd.Parameters.AddWithValue("@Apellido", cliente.gApellido)
            cmd.Parameters.AddWithValue("@Direccion", cliente.gDireccion)
            cmd.Parameters.AddWithValue("@Dni", cliente.gDni)
            cmd.Parameters.AddWithValue("@Email", cliente.gEmail)
            cmd.Parameters.AddWithValue("@Telefono", cliente.gTelefono)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de modificar el cliente." &
              Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function bajaCliente(clienteID) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("procBajaCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@ID", clienteID)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de dar de baja el cliente." &
              Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function mostrarClientesActivos() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("procMostrarClientesActivos")
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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes activos." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
    Public Function mostrarClientesConAlquiler() As DataTable
        Try
            conectar()
            cmd = New SqlCommand("procMostrarClientesConAlquiler")
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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes con alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
End Class
