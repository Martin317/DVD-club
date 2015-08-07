Public Class frmReporteClientesDeudores

    Private Sub frmReporteClientesDeudores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dvdclubdbDataSetDeudores.procReporteClientesDeudores' table. You can move, or remove it, as needed.
        Me.procReporteClientesDeudoresTableAdapter.Fill(Me.dvdclubdbDataSetDeudores.procReporteClientesDeudores)
        Me.ReportViewer1.RefreshReport()
 
    End Sub

    
End Class