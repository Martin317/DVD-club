﻿Public Class frmReportesClientesActivos

    Private Sub frmReportesClientesActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'TODO: This line of code loads data into the 'dvdclubdbDataSet.procMostrarClientesActivos' table. You can move, or remove it, as needed.
        Me.procMostrarClientesActivosTableAdapter.Fill(Me.dvdclubdbDataSet.procMostrarClientesActivos)

        Me.ReportViewer1.RefreshReport()

    End Sub


End Class