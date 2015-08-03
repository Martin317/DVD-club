Imports System.Data.SqlClient
Public Class fPeliculaEspecifica
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Sub actualizarEstadoPelicula()
        Try
            conectar()
            Dim idPeliculaEspecifica As Integer
            For Each row As DataGridViewRow In frmAlquilerRegistrar.dgvDetalles.Rows
                idPeliculaEspecifica = row.Cells(0).Value
                cmd = New SqlCommand("procActualizarEstadoPeliculaEspecifica")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@idPelicula", idPeliculaEspecifica)
            Next
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar el alquiler." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
End Class
