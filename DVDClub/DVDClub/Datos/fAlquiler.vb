Imports System.Data.SqlClient

Public Class fAlquiler
    Inherits Conexion
    Dim cmd As SqlCommand

  
    

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
