Imports System.Data.SqlClient
Public Class fUsuario
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function comprobarDatos(usuario As logUsuario) As Boolean
        Try
            conectar()
            cmd = New SqlCommand
            cmd.Connection = cnn
            cmd.CommandText = "SELECT * FROM usuario"
            Dim dt As New DataTable

            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                da.SelectCommand = cmd
                da.Fill(dt)
            End If
            Dim correcto As Boolean = False
            For Each row In dt.Rows
                If row("nombre_usuario") = usuario.gNombreUsuario And row("contrasenia") = usuario.gContrasenia Then
                    My.Settings.UltimoUsuario = usuario.gNombreUsuario
                    My.Settings.Save()
                    usuario.gNombre = row("nombre")
                    usuario.gDni = row("dni")
                    usuario.gApellido = row("apellido")
                    usuario.gUsuarioID = row("usuario_id")
                    Dim sesion As New logSesion
                    sesion.gUsuario = usuario
                    sesion.gFechaHoraInicioSesion = Convert.ToDateTime(DateAndTime.Now)
                    cmd = New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandText = "INSERT INTO sesion(usuario,fecha_hora_inicio_sesion) VALUES('" & (sesion.gUsuario).gUsuarioID & "', '" & sesion.gFechaHoraInicioSesion & "')"
                    cmd.ExecuteNonQuery()
                    Return True
                Else
                    correcto = False
                End If
            Next
            Return correcto

        Catch ex As Exception
            MessageBox.Show("Atención: se ha generado un error tratando acceder a los usuarios del sistema." &
                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            desconectar()
        End Try

    End Function
End Class
