﻿Imports System.Data.SqlClient
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
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de actualizar el estado del ejemplar." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
    Public Sub actualizarDevolucionEjemplar()
        Try
            conectar()
            Dim idPeliculaEspecifica As Integer
            For Each row As DataGridViewRow In frmAlquilerDevolucion.dgvDetalleAlquiler.Rows
                idPeliculaEspecifica = row.Cells(0).Value
                cmd = New SqlCommand
                cmd.CommandText = "UPDATE pelicula_especifica SET estado = 5 WHERE pelicula_especifica_id = '" & idPeliculaEspecifica & "' "
                cmd.Connection = cnn
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de actualizar el estado del ejemplar." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            desconectar()
        End Try
    End Sub
End Class
