<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesClientesActivos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.procMostrarClientesActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds3 = New DVDClub.ds3()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.procMostrarClientesActivosTableAdapter = New DVDClub.ds3TableAdapters.procMostrarClientesActivosTableAdapter()
        CType(Me.procMostrarClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'procMostrarClientesActivosBindingSource
        '
        Me.procMostrarClientesActivosBindingSource.DataMember = "procMostrarClientesActivos"
        Me.procMostrarClientesActivosBindingSource.DataSource = Me.ds3
        '
        'ds3
        '
        Me.ds3.DataSetName = "ds3"
        Me.ds3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ds3"
        ReportDataSource1.Value = Me.procMostrarClientesActivosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DVDClub.rptClientesActivos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1182, 733)
        Me.ReportViewer1.TabIndex = 0
        '
        'procMostrarClientesActivosTableAdapter
        '
        Me.procMostrarClientesActivosTableAdapter.ClearBeforeFill = True
        '
        'frmReportesClientesActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 733)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimumSize = New System.Drawing.Size(1200, 780)
        Me.Name = "frmReportesClientesActivos"
        Me.Text = "Reporte de clientes activos"
        CType(Me.procMostrarClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents procMostrarClientesActivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ds3 As DVDClub.ds3
    Friend WithEvents procMostrarClientesActivosTableAdapter As DVDClub.ds3TableAdapters.procMostrarClientesActivosTableAdapter
End Class
