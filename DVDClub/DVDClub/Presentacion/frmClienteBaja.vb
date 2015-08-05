Public Class frmClienteBaja

    Private Sub frmClienteBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funcCliente As New fCliente
        Dim dt As DataTable = funcCliente.mostrarDatos()
        cmbCliente.DataSource = dt
        cmbCliente.ValueMember = "cliente_id"
        cmbCliente.DisplayMember = "Cliente"
        If cmbCliente.Items.Count > 0 Then
            cmbCliente.SelectedItem = 1
        End If
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        bajaCliente()
    End Sub
    Private Sub bajaCliente()
        Dim funcCliente As New fCliente
        Dim clienteID As Integer = cmbCliente.SelectedValue
        If funcCliente.bajaCliente(clienteID) = True Then
            MessageBox.Show("Cliente dado de baja con Éxito!", "Baja cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class