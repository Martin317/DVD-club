﻿Public Class Form1

 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   frmPeliculaNueva.Show()

    End Sub

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
End Class
