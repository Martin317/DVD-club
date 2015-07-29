Imports System.Data
Imports System.Data.SqlClient



Public Class frmPeliculaModificar
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter(cmd)
    Dim intId As Integer

    '    Private Sub PeliculaModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Try
    '            'Apertura de conexion con la Base de Datos
    '            conectar()
    '            'Query a ejecutar
    '            cmd.Connection = cnn
    '            cmd.CommandText = "Select nombre as Pelicula, * from pelicula"
    '            da.SelectCommand = cmd
    '            da.Fill(dt)

    '            'Captura de Errores
    '        Catch ex As Exception
    '            MessageBox.Show("Atención: se ha generado un error tratando de mostrar las Peliculas." &
    '                            Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
    '                            MessageBoxButtons.OK, MessageBoxIcon.Error)

    '        Finally
    '            'Cierre Conexion con la Base de Datos
    '            desconectar()
    '        End Try


    '        cmbPelicula.DataSource = dt
    '        cmbPelicula.DisplayMember = "Pelicula"
    '        cmbPelicula.ValueMember = "pelicula_id"
    '        desconectar()
    '    End Sub

    '    Private Sub cmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
    '        'Cuando cambia el objeto seleccionado del ComboBox, se actualizan los datos de los TextBox correspondientes

    '        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
    '        txtNombre.Text = row.Item("nombre").ToString
    '        txtIdioma.Text = row.Item("idioma").ToString
    '        txtGenero.Text = row.Item("genero").ToString
    '        dtpFechaLanzamiento.Text = row.Item("fecha_lanzamiento").ToString
    '        txtDescripcion.Text = row.Item("descripcion").ToString
    '        intId = row.Item("pelicula_id").ToString
    '    End Sub

    '    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    '        'Aperura de Conexio a la BD
    '        'comando.Connection = conexion
    '        'conexion.Open()

    '        'Actualizacion de los valores en la BD de el elemento seleccionado en el ComboBox
    '        If txtNombre.Text = "" Then
    '            MsgBox("El campo Nombre no puede estar Vacío", MsgBoxStyle.OkOnly)
    '        Else
    '            If txtIdioma.Text = "" Then
    '                MsgBox("El campo Idioma no puede estar Vacío", MsgBoxStyle.OkOnly)
    '            Else
    '                If txtGenero.Text = "" Then
    '                    MsgBox("El campo Genero no puede estar Vacío", MsgBoxStyle.OkOnly)
    '                Else
    '                    Try
    '                        conectar()
    '                        cmd.Connection = cnn
    '                        cmd.CommandText = "UPDATE Pelicula SET nombre=( '" & txtNombre.Text & "'), idioma=( '" & txtIdioma.Text & "'),genero=( '" & txtGenero.Text & "'),fecha_lanzamiento=( '" & dtpFechaLanzamiento.Text & "'),descripcion=( '" & txtDescripcion.Text & "') WHERE pelicula_id=( '" & intId & "')"
    '                        cmd.ExecuteNonQuery()
    '                    Catch ex As Exception
    '                        MessageBox.Show("Atención: se ha generado un error tratando de Actualizar la Pelicula." &
    '                          Environment.NewLine & "Descripción del error: " & Environment.NewLine & ex.Message, "Error",
    '                          MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    Finally
    '                        desconectar()
    '                    End Try
    '                End If
    '            End If
    '        End If

    '        MsgBox("¡Se modificaron los datos exitosamente!", MsgBoxStyle.OkOnly, "Notificación")

    '    End Sub

  
End Class