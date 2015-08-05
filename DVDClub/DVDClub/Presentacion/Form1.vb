Public Class Form1

 


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAlquilerRegistrar.ShowDialog()

    End Sub

    Private Sub RegistrarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem2.Click
        frmAlquilerRegistrar.ShowDialog()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        frmPeliculaNueva.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        frmPeliculaModificar.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        frmPeliculaBaja.ShowDialog()
    End Sub

    Private Sub IniciarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesionToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        frmClienteConsultar.ShowDialog()
    End Sub

    Private Sub BajaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaClienteToolStripMenuItem.Click
        frmClientesActivos.ShowDialog()
    End Sub
End Class
