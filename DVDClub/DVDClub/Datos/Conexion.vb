Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection 'variable para establecer conexion a bd
    Public idUsuario As Integer

    Protected Function conectar()
        Try
            cnn = New SqlConnection("Data Source=MARTINPC\SQLExpress;User ID=sa;Password=qweasdzxc159753;Initial Catalog=dvdclubdb;Integrated Security=False")
            'TODO Ver usuario, contraseña y seguridad
            cnn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Atencion: Error al establecer la conexion a la base de datos" & Environment.NewLine & "Descripcion del error:" & Environment.NewLine & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Protected Function desconectar()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Atencion: Error al cerrar la conexion a la base de datos" & Environment.NewLine & "Descripcion del error:" & Environment.NewLine & ex.Message,
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
End Class
