Imports System.Data.SqlClient
Public Class fDetalleAlquiler
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Sub insertarDetalle(idAlquiler As Integer)
        Try
            conectar()
            Dim idPeliculaEspecifica As Integer
            For Each row As DataGridViewRow In frmAlquilerRegistrar.dgvDetalles.Rows
                idPeliculaEspecifica = row.Cells(0).Value
                cmd = New SqlCommand("procInsertarDetalle")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@Alquiler", idAlquiler)
                cmd.Parameters.AddWithValue("@IDPeliculaEspecifica", idPeliculaEspecifica)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar los detalles del alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Public Function mostrarDetalles(alquiler_id As Integer) As DataTable
        Try
            conectar()
            cmd = New SqlCommand("procMostrarDetalles")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@ID", alquiler_id)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de mostrar los detalles del alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class
