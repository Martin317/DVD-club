Imports System.Data.SqlClient
Public Class fSesion
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function capturarSesionActual() As logSesion
        Try
            Dim sesion As New logSesion
            Dim usuario As New logUsuario
            conectar()
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT TOP 1 * FROM sesion ORDER BY sesion.sesion_id DESC"
            Dim dt As New DataTable
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand = cmd
                da.Fill(dt)
            End If
            usuario.gUsuarioID = dt(0)(1)
            sesion.gSesionID = dt(0)(0)
            sesion.gFechaHoraInicioSesion = dt(0)(2)
            sesion.gUsuario = usuario
            Return sesion
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar la sesion actual." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
    Public Function cerrarSesion(sesionActual As logSesion) As Boolean
        Try

            sesionActual.gFechaHoraCierreSesion = Convert.ToDateTime(DateAndTime.Now)
            conectar()
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "UPDATE sesion SET sesion.fecha_hora_cierre_sesion= ( '" & sesionActual.gFechaHoraCierreSesion & "') WHERE sesion.sesion_id = ( '" & sesionActual.gSesionID & "')"
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando de registrar la sesion actual." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
End Class
