Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeliculaModificar

    Dim comando As New SqlCommand
    'se le pasa a la variable conexion el String de conexion de nuestra BD
    'Dim conexion As New SqlConnection("String de Conexion;")
    Dim cliente As New DataTable
    Dim adaptador As New SqlDataAdapter
    Dim intID As Integer

    Private Sub PeliculaModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Aperura de Conexio a la BD
        'conexion.Open()
        'comando.Connection = conexion

        'Llenado de ComboBox Alumno
        comando.CommandText = "Select nombre as Pelicula, * from alumno"
        adaptador.SelectCommand = comando
        cliente.Rows.Clear()
        adaptador.Fill(cliente)
        cmbPelicula.DataSource = cliente
        cmbPelicula.DisplayMember = "Pelicula"
        cmbPelicula.ValueMember = "pelicula_id"
        'conexion.Close()
    End Sub

    Private Sub cmbPelicula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        'Cuando cambia el objeto seleccionado del ComboBox, se actualizan los datos de los TextBox correspondientes
        'Dim row As DataRowView = DirectCast(cmbAlumno.SelectedItem, DataRowView)
        'txtNombre.Text = row.Item("nombre").ToString
        'txtIdioma.Text = row.Item("idioma").ToString
        'txtGenero.Text = row.Item("genero").ToString
        'dtpFechaLanzamiento.Text = row.Item("fecha_lanzamiento").ToString
        'txtDescripcion.Text = row.Item("descripcion").ToString
        'intID = row.Item("pelicula_id").ToString
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'Aperura de Conexio a la BD
        'comando.Connection = conexion
        'conexion.Open()

        'Actualizacion de los valores en la BD de el elemento seleccionado en el ComboBox
        If txtNombre.Text = "" Then
            MsgBox("El campo Nombre no puede estar Vacío", MsgBoxStyle.OkOnly)
        Else
            If txtIdioma.Text = "" Then
                MsgBox("El campo Idioma no puede estar Vacío", MsgBoxStyle.OkOnly)
            Else
                If txtGenero.Text = "" Then
                    MsgBox("El campo Genero no puede estar Vacío", MsgBoxStyle.OkOnly)
                Else
                    comando.CommandText = "UPDATE Pelicula SET nombre=( '" & txtNombre.Text & "'), idioma=( '" & txtIdioma.Text & "'),genero=( '" & txtGenero.Text & "'),fecha_lanzamiento=( '" & dtpFechaLanzamiento.Text & "'),descripcion=( '" & txtDescripcion.Text & "') WHERE pelicula_id=( '" & intID & "')"
                    comando.ExecuteNonQuery()
                    'conexion.Close()
                End If
            End If
        End If

        MsgBox("¡Se modificaron los datos exitosamente!", MsgBoxStyle.OkOnly, "Notificación")
        Me.Close()
    End Sub
End Class