Imports System.Data.SqlClient
Public Class fDetalleAlquiler
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Sub insertarDetalle(idAlquiler As Integer)
        Try
            Dim idPeliculaEspecifica As Integer
            For Each row As DataGridViewRow In frmAlquilerRegistrar.dgvDetalles.Rows
                idPeliculaEspecifica = row.Cells(0).Value
                conectar()
                cmd = New SqlCommand("procInsertarDetalle")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@Alquiler", idAlquiler)
                cmd.Parameters.AddWithValue("@PeliculaEspecifica", idPeliculaEspecifica)
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
