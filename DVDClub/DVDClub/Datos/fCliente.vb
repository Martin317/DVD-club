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
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los clientes y peliculas." &
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
            MessageBox.Show("Atención: se ha generado un error tratando de registrar el alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
End Class
