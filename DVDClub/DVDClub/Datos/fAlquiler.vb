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
   

End Class
