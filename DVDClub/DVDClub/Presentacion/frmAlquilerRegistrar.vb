Public Class frmAlquilerRegistrar

    Private dt As New DataTable
    Private Sub frmAlquilerRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funcMostrarClientes()
        funcMostrarPeliculas()
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

End Class