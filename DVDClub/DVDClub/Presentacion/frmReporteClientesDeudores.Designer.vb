<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClientesDeudores
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
        Me.procReporteClientesDeudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dvdclubdbDataSetDeudores = New DVDClub.dvdclubdbDataSetDeudores()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.procReporteClientesDeudoresTableAdapter = New DVDClub.dvdclubdbDataSetDeudoresTableAdapters.procReporteClientesDeudoresTableAdapter()
        CType(Me.procReporteClientesDeudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvdclubdbDataSetDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'procReporteClientesDeudoresBindingSource
        '
        Me.procReporteClientesDeudoresBindingSource.DataMember = "procReporteClientesDeudores"
        Me.procReporteClientesDeudoresBindingSource.DataSource = Me.dvdclubdbDataSetDeudores
        '
        'dvdclubdbDataSetDeudores
        '
        Me.dvdclubdbDataSetDeudores.DataSetName = "dvdclubdbDataSetDeudores"
        Me.dvdclubdbDataSetDeudores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetDeudores"
        ReportDataSource1.Value = Me.procReporteClientesDeudoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DVDClub.rptClientesDeudores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1182, 733)
        Me.ReportViewer1.TabIndex = 0
        '
        'procReporteClientesDeudoresTableAdapter
        '
        Me.procReporteClientesDeudoresTableAdapter.ClearBeforeFill = True
        '
        'frmReporteClientesDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 733)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximumSize = New System.Drawing.Size(1200, 780)
        Me.Name = "frmReporteClientesDeudores"
        Me.Text = "Reporte de clientes deudores"
        CType(Me.procReporteClientesDeudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvdclubdbDataSetDeudores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents procReporteClientesDeudoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dvdclubdbDataSetDeudores As DVDClub.dvdclubdbDataSetDeudores
    Friend WithEvents procReporteClientesDeudoresTableAdapter As DVDClub.dvdclubdbDataSetDeudoresTableAdapters.procReporteClientesDeudoresTableAdapter
End Class
