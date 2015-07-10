Imports System.Data
Imports System.Data.SqlClient

Public Class PeliculaBaja

    'Declaraciones
    Dim comando As New SqlCommand
    'se le pasa a la variable conexion el String de conexion de nuestra BD
    'Dim conexion As New SqlConnection("String de Conexion;")
    Dim cliente As New DataTable
    Dim adaptador As New SqlDataAdapter
    Dim intID As Integer

    Private Sub AlumnoBaja_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub cmbAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPelicula.SelectedIndexChanged
        'intID = row.Item("pelicula_id").ToString
        Dim row As DataRowView = DirectCast(cmbPelicula.SelectedItem, DataRowView)
    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        'Declaraciones

        'Aperura de Conexio a la BD
        'conexion.Open()
        'comando.Connection = conexion

        'se actualiza el estado_ID por el de DadoBaja
        'comando.CommandText = "UPDATE alumno SET estado_ID=2 WHERE alumno_ID=( '" & intID & "')"
        comando.ExecuteNonQuery()
        'conexion.Close()
        MsgBox("¡La Pelicula fue correctamente dado de baja!", MsgBoxStyle.OkOnly, "Notificación")
    End Sub
   

End Class