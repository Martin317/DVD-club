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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dvdclubdbDataSet = New DVDClub.dvdclubdbDataSet()
        Me.procMostrarClientesActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.procMostrarClientesActivosTableAdapter = New DVDClub.dvdclubdbDataSetTableAdapters.procMostrarClientesActivosTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SatasetDeudores = New DVDClub.SatasetDeudores()
        Me.procReporteClientesDeudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.procReporteClientesDeudoresTableAdapter = New DVDClub.SatasetDeudoresTableAdapters.procReporteClientesDeudoresTableAdapter()
        CType(Me.dvdclubdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.procMostrarClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatasetDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.procReporteClientesDeudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.procMostrarClientesActivosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DVDClub.rptClientesActivos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1182, 733)
        Me.ReportViewer1.TabIndex = 0
        '
        'dvdclubdbDataSet
        '
        Me.dvdclubdbDataSet.DataSetName = "dvdclubdbDataSet"
        Me.dvdclubdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'procMostrarClientesActivosBindingSource
        '
        Me.procMostrarClientesActivosBindingSource.DataMember = "procMostrarClientesActivos"
        Me.procMostrarClientesActivosBindingSource.DataSource = Me.dvdclubdbDataSet
        '
        'procMostrarClientesActivosTableAdapter
        '
        Me.procMostrarClientesActivosTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "SatasetDeudores"
        ReportDataSource2.Value = Me.procReporteClientesDeudoresBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "DVDClub.rptClientesDeudores.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1182, 733)
        Me.ReportViewer2.TabIndex = 1
        '
        'SatasetDeudores
        '
        Me.SatasetDeudores.DataSetName = "SatasetDeudores"
        Me.SatasetDeudores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'procReporteClientesDeudoresBindingSource
        '
        Me.procReporteClientesDeudoresBindingSource.DataMember = "procReporteClientesDeudores"
        Me.procReporteClientesDeudoresBindingSource.DataSource = Me.SatasetDeudores
        '
        'procReporteClientesDeudoresTableAdapter
        '
        Me.procReporteClientesDeudoresTableAdapter.ClearBeforeFill = True
        '
        'frmReportesClientesActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 733)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimumSize = New System.Drawing.Size(1200, 780)
        Me.Name = "frmReportesClientesActivos"
        Me.Text = "frmReportesClientesActivos"
        CType(Me.dvdclubdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.procMostrarClientesActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatasetDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.procReporteClientesDeudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents procMostrarClientesActivosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dvdclubdbDataSet As DVDClub.dvdclubdbDataSet
    Friend WithEvents procMostrarClientesActivosTableAdapter As DVDClub.dvdclubdbDataSetTableAdapters.procMostrarClientesActivosTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents procReporteClientesDeudoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SatasetDeudores As DVDClub.SatasetDeudores
    Friend WithEvents procReporteClientesDeudoresTableAdapter As DVDClub.SatasetDeudoresTableAdapters.procReporteClientesDeudoresTableAdapter
End Class
