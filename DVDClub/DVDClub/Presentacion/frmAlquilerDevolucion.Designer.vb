<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlquilerDevolucion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAlquileres = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ErrProviderDevolucionAlquiler = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalleAlquiler = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTiempoAlquiler = New System.Windows.Forms.Label()
        Me.lblDeudor = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAlquileres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProviderDevolucionAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalleAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente:"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(134, 43)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(473, 24)
        Me.cmbCliente.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAlquileres)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 187)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alquileres"
        '
        'dgvAlquileres
        '
        Me.dgvAlquileres.AllowUserToAddRows = False
        Me.dgvAlquileres.AllowUserToDeleteRows = False
        Me.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlquileres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlquileres.Location = New System.Drawing.Point(3, 18)
        Me.dgvAlquileres.Name = "dgvAlquileres"
        Me.dgvAlquileres.ReadOnly = True
        Me.dgvAlquileres.RowTemplate.Height = 24
        Me.dgvAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlquileres.Size = New System.Drawing.Size(703, 166)
        Me.dgvAlquileres.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(574, 520)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(147, 45)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(421, 520)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(147, 45)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ErrProviderDevolucionAlquiler
        '
        Me.ErrProviderDevolucionAlquiler.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetalleAlquiler)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(709, 187)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de alquiler"
        '
        'dgvDetalleAlquiler
        '
        Me.dgvDetalleAlquiler.AllowUserToAddRows = False
        Me.dgvDetalleAlquiler.AllowUserToDeleteRows = False
        Me.dgvDetalleAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleAlquiler.Location = New System.Drawing.Point(3, 18)
        Me.dgvDetalleAlquiler.Name = "dgvDetalleAlquiler"
        Me.dgvDetalleAlquiler.ReadOnly = True
        Me.dgvDetalleAlquiler.RowTemplate.Height = 24
        Me.dgvDetalleAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleAlquiler.Size = New System.Drawing.Size(703, 166)
        Me.dgvDetalleAlquiler.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tiempo del alquiler:"
        '
        'lblTiempoAlquiler
        '
        Me.lblTiempoAlquiler.AutoSize = True
        Me.lblTiempoAlquiler.Location = New System.Drawing.Point(170, 307)
        Me.lblTiempoAlquiler.Name = "lblTiempoAlquiler"
        Me.lblTiempoAlquiler.Size = New System.Drawing.Size(0, 17)
        Me.lblTiempoAlquiler.TabIndex = 26
        '
        'lblDeudor
        '
        Me.lblDeudor.AutoSize = True
        Me.lblDeudor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeudor.ForeColor = System.Drawing.Color.Red
        Me.lblDeudor.Location = New System.Drawing.Point(587, 307)
        Me.lblDeudor.Name = "lblDeudor"
        Me.lblDeudor.Size = New System.Drawing.Size(134, 17)
        Me.lblDeudor.TabIndex = 27
        Me.lblDeudor.Text = "24 hs superadas."
        Me.lblDeudor.Visible = False
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(170, 307)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(0, 17)
        Me.lblTiempo.TabIndex = 28
        '
        'frmAlquilerDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 577)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblDeudor)
        Me.Controls.Add(Me.lblTiempoAlquiler)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlquilerDevolucion"
        Me.Text = "frmAlquilerDevolucion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAlquileres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProviderDevolucionAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalleAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAlquileres As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrProviderDevolucionAlquiler As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalleAlquiler As System.Windows.Forms.DataGridView
    Friend WithEvents lblDeudor As System.Windows.Forms.Label
    Friend WithEvents lblTiempoAlquiler As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
End Class
