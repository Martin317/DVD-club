Public Class frmClientesActivos

    Private Sub frmClientesActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcCliente As New fCliente
        Dim dt As DataTable = funcCliente.mostrarClientesActivos()
        If dt IsNot Nothing Then
            lstClientesActivos.DataSource = dt
            lstClientesActivos.DisplayMember = "ClienteActivo"
            lstClientesActivos.ValueMember = "cliente_id"
        End If
    End Sub
End Class