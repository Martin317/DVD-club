Imports System.Data.SqlClient

Public Class fAlquiler
    Inherits Conexion
    Dim cmd As SqlCommand

    Public Sub insertarAlquiler(alquiler As logAlquiler)
        Try
            conectar()
            cmd = New SqlCommand("procInsertarAlquiler")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IDCliente", (alquiler.gCliente).gClienteID)
            cmd.Parameters.AddWithValue("@FechaEntrega", alquiler.gFechaEntrega)
            cmd.Parameters.AddWithValue("@HoraEntrega", alquiler.gHoraEntrega)

            'Insertar detalles
            'Traer id del ultimo alquiler insertado
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = ("SELECT TOP 1 alquiler_id FROM alquiler ORDER BY alquiler_id DESC")
            Dim dt As New DataTable
            If cmd.ExecuteNonQuery Then

                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand = cmd
                da.Fill(dt)
            End If
            Dim funcDetalle As New fDetalleAlquiler
            Dim idAlquiler As Integer = dt(0)(0)
            funcDetalle.insertarDetalle(idAlquiler)
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar el alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub

End Class
