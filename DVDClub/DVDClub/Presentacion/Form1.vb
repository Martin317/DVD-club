﻿Public Class Form1

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
        Dim funcSesion As New fSesion
        Dim sesionActual As logSesion = funcSesion.capturarSesionActual()
        If funcSesion.cerrarSesion(sesionActual) = True Then
            MessageBox.Show("Usted ha cerrado sesion", "Sesion",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Hemos tenido un problema al cerrar sesion", "Sesion",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        frmClienteConsultar.ShowDialog()
    End Sub

    Private Sub BajaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaClienteToolStripMenuItem.Click
        frmClientesActivos.ShowDialog()
    End Sub

    Private Sub BajaClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaClientesToolStripMenuItem.Click
        frmClienteBaja.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem1.Click
        frmPeliculaConsultar.ShowDialog()
    End Sub
End Class
