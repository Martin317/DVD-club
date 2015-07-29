Public Class frmAlquilerRegistrar

    Private dt As New DataTable
    Private Sub frmAlquilerRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcMostrarClientes()
        funcMostrarPeliculas()
        cmbClientes.SelectedIndex = 0
        cmbPeliculas.SelectedIndex = 0
    End Sub

    Private Sub funcMostrarClientes()
        Dim clientes As New fAlquiler
        dt = clientes.mostrarDatos("C")
        dgvClientes.DataSource = dt
    End Sub

    Private Sub funcMostrarPeliculas()
        Dim peliculas As New fAlquiler
        dt = peliculas.mostrarDatos("P")
        dgvPeliculas.DataSource = dt
    End Sub


    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

        Dim respuesta As Integer = MessageBox.Show("¿Desea registrar los datos del alquiler?", "Confirmacion de alquiler",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = MsgBoxResult.Yes Then
            'TODO codigo registrar alquiler

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarPelicula_Click(sender As Object, e As EventArgs) Handles btnBuscarPelicula.Click
        Dim alquiler As fAlquiler
        dt = alquiler.filtrar("P", cmbPeliculas.SelectedIndex, txtPeliculas.Text)

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim alquiler As fAlquiler
        dt = alquiler.filtrar("C", cmbClientes.SelectedIndex, txtClientes.Text)
    End Sub

  
End Class