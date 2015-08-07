Public Class frmReportesClientesActivos

    Private Sub frmReportesClientesActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ds3.procMostrarClientesActivos' table. You can move, or remove it, as needed.
        Me.procMostrarClientesActivosTableAdapter.Fill(Me.ds3.procMostrarClientesActivos)

        'TODO: This line of code loads data into the 'dvdclubdbDataSet.procMostrarClientesActivos' table. You can move, or remove it, as needed.
   

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class