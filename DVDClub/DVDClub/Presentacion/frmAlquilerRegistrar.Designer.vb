<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlquilerRegistrar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarPelicula = New System.Windows.Forms.Button()
        Me.txtPeliculas = New System.Windows.Forms.TextBox()
        Me.cmbPeliculas = New System.Windows.Forms.ComboBox()
        Me.dgvPeliculas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtClientes = New System.Windows.Forms.TextBox()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.clmSeleccionarPelicula = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscarPelicula)
        Me.GroupBox1.Controls.Add(Me.txtPeliculas)
        Me.GroupBox1.Controls.Add(Me.cmbPeliculas)
        Me.GroupBox1.Controls.Add(Me.dgvPeliculas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 303)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Peliculas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filtrar por:"
        '
        'btnBuscarPelicula
        '
        Me.btnBuscarPelicula.Location = New System.Drawing.Point(652, 26)
        Me.btnBuscarPelicula.Name = "btnBuscarPelicula"
        Me.btnBuscarPelicula.Size = New System.Drawing.Size(166, 44)
        Me.btnBuscarPelicula.TabIndex = 3
        Me.btnBuscarPelicula.Text = "Buscar"
        Me.btnBuscarPelicula.UseVisualStyleBackColor = True
        '
        'txtPeliculas
        '
        Me.txtPeliculas.Location = New System.Drawing.Point(219, 37)
        Me.txtPeliculas.MaxLength = 50
        Me.txtPeliculas.Name = "txtPeliculas"
        Me.txtPeliculas.Size = New System.Drawing.Size(408, 22)
        Me.txtPeliculas.TabIndex = 2
        '
        'cmbPeliculas
        '
        Me.cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeliculas.FormattingEnabled = True
        Me.cmbPeliculas.Items.AddRange(New Object() {"Nombre", "Genero", "Idioma"})
        Me.cmbPeliculas.Location = New System.Drawing.Point(92, 37)
        Me.cmbPeliculas.Name = "cmbPeliculas"
        Me.cmbPeliculas.Size = New System.Drawing.Size(121, 24)
        Me.cmbPeliculas.TabIndex = 1
        '
        'dgvPeliculas
        '
        Me.dgvPeliculas.AllowUserToAddRows = False
        Me.dgvPeliculas.AllowUserToDeleteRows = False
        Me.dgvPeliculas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeliculas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccionarPelicula})
        Me.dgvPeliculas.Location = New System.Drawing.Point(6, 76)
        Me.dgvPeliculas.Name = "dgvPeliculas"
        Me.dgvPeliculas.ReadOnly = True
        Me.dgvPeliculas.RowTemplate.Height = 24
        Me.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPeliculas.Size = New System.Drawing.Size(812, 221)
        Me.dgvPeliculas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnModificarCliente)
        Me.GroupBox2.Controls.Add(Me.btnRegistrarCliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.txtClientes)
        Me.GroupBox2.Controls.Add(Me.cmbClientes)
        Me.GroupBox2.Controls.Add(Me.dgvClientes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(824, 303)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clientes"
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(652, 126)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(166, 44)
        Me.btnModificarCliente.TabIndex = 5
        Me.btnModificarCliente.Text = "Modificar Cliente"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(652, 76)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(166, 44)
        Me.btnRegistrarCliente.TabIndex = 5
        Me.btnRegistrarCliente.Text = "Nuevo cliente"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filtrar por:"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(652, 26)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(166, 44)
        Me.btnBuscarCliente.TabIndex = 3
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtClientes
        '
        Me.txtClientes.Location = New System.Drawing.Point(219, 37)
        Me.txtClientes.MaxLength = 50
        Me.txtClientes.Name = "txtClientes"
        Me.txtClientes.Size = New System.Drawing.Size(408, 22)
        Me.txtClientes.TabIndex = 2
        '
        'cmbClientes
        '
        Me.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI"})
        Me.cmbClientes.Location = New System.Drawing.Point(92, 37)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(121, 24)
        Me.cmbClientes.TabIndex = 1
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(6, 76)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(621, 221)
        Me.dgvClientes.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(670, 630)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(166, 44)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(498, 630)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(166, 44)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'clmSeleccionarPelicula
        '
        Me.clmSeleccionarPelicula.FalseValue = "0"
        Me.clmSeleccionarPelicula.HeaderText = "Seleccionar"
        Me.clmSeleccionarPelicula.Name = "clmSeleccionarPelicula"
        Me.clmSeleccionarPelicula.ReadOnly = True
        Me.clmSeleccionarPelicula.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmSeleccionarPelicula.TrueValue = "1"
        '
        'frmAlquilerRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 687)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlquilerRegistrar"
        Me.Text = "frmAlquilerRegistrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPelicula As System.Windows.Forms.Button
    Friend WithEvents txtPeliculas As System.Windows.Forms.TextBox
    Friend WithEvents cmbPeliculas As System.Windows.Forms.ComboBox
    Friend WithEvents dgvPeliculas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarCliente As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarCliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txtClientes As System.Windows.Forms.TextBox
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents clmSeleccionarPelicula As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
