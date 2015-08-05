<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeliculaConsultar
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPeliculasConsultar = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPeliculasConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(518, 365)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(110, 37)
        Me.btnAtras.TabIndex = 0
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPeliculasConsultar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 347)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Peliculas"
        '
        'dgvPeliculasConsultar
        '
        Me.dgvPeliculasConsultar.AllowUserToAddRows = False
        Me.dgvPeliculasConsultar.AllowUserToDeleteRows = False
        Me.dgvPeliculasConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeliculasConsultar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPeliculasConsultar.Location = New System.Drawing.Point(3, 16)
        Me.dgvPeliculasConsultar.Name = "dgvPeliculasConsultar"
        Me.dgvPeliculasConsultar.ReadOnly = True
        Me.dgvPeliculasConsultar.Size = New System.Drawing.Size(610, 328)
        Me.dgvPeliculasConsultar.TabIndex = 0
        '
        'frmPeliculaConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmPeliculaConsultar"
        Me.Text = "frmPeliculaConsultar"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPeliculasConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPeliculasConsultar As System.Windows.Forms.DataGridView
End Class
