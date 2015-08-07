<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteConsultar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.labCliente = New System.Windows.Forms.Label()
        Me.gboxDatos = New System.Windows.Forms.GroupBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.labTelefono = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.labDireccion = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.labDNI = New System.Windows.Forms.Label()
        Me.labApellido = New System.Windows.Forms.Label()
        Me.gboxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(356, 410)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(147, 45)
        Me.btnAtras.TabIndex = 26
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(136, 15)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(317, 24)
        Me.cmbCliente.TabIndex = 27
        '
        'labCliente
        '
        Me.labCliente.AutoSize = True
        Me.labCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCliente.Location = New System.Drawing.Point(57, 18)
        Me.labCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCliente.Name = "labCliente"
        Me.labCliente.Size = New System.Drawing.Size(58, 17)
        Me.labCliente.TabIndex = 28
        Me.labCliente.Text = "Cliente"
        '
        'gboxDatos
        '
        Me.gboxDatos.Controls.Add(Me.txtNumero)
        Me.gboxDatos.Controls.Add(Me.Label1)
        Me.gboxDatos.Controls.Add(Me.txtEmail)
        Me.gboxDatos.Controls.Add(Me.txtDireccion)
        Me.gboxDatos.Controls.Add(Me.txtTelefono)
        Me.gboxDatos.Controls.Add(Me.txtNombre)
        Me.gboxDatos.Controls.Add(Me.labEmail)
        Me.gboxDatos.Controls.Add(Me.txtApellido)
        Me.gboxDatos.Controls.Add(Me.labTelefono)
        Me.gboxDatos.Controls.Add(Me.txtDNI)
        Me.gboxDatos.Controls.Add(Me.labDireccion)
        Me.gboxDatos.Controls.Add(Me.labNombre)
        Me.gboxDatos.Controls.Add(Me.labDNI)
        Me.gboxDatos.Controls.Add(Me.labApellido)
        Me.gboxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxDatos.Location = New System.Drawing.Point(16, 48)
        Me.gboxDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.gboxDatos.Name = "gboxDatos"
        Me.gboxDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.gboxDatos.Size = New System.Drawing.Size(484, 355)
        Me.gboxDatos.TabIndex = 29
        Me.gboxDatos.TabStop = False
        Me.gboxDatos.Text = "Datos"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(120, 49)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.MaxLength = 50
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(99, 22)
        Me.txtNumero.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Numero"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(120, 301)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(317, 22)
        Me.txtEmail.TabIndex = 41
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(120, 217)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(317, 22)
        Me.txtDireccion.TabIndex = 33
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(120, 259)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(317, 22)
        Me.txtTelefono.TabIndex = 40
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(120, 91)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(317, 22)
        Me.txtNombre.TabIndex = 30
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmail.Location = New System.Drawing.Point(61, 304)
        Me.labEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(47, 17)
        Me.labEmail.TabIndex = 39
        Me.labEmail.Text = "Email"
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.SystemColors.Window
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(120, 133)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(317, 22)
        Me.txtApellido.TabIndex = 31
        '
        'labTelefono
        '
        Me.labTelefono.AutoSize = True
        Me.labTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTelefono.Location = New System.Drawing.Point(39, 262)
        Me.labTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labTelefono.Name = "labTelefono"
        Me.labTelefono.Size = New System.Drawing.Size(72, 17)
        Me.labTelefono.TabIndex = 38
        Me.labTelefono.Text = "Teléfono"
        '
        'txtDNI
        '
        Me.txtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(120, 175)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDNI.MaxLength = 50
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.ReadOnly = True
        Me.txtDNI.Size = New System.Drawing.Size(317, 22)
        Me.txtDNI.TabIndex = 32
        '
        'labDireccion
        '
        Me.labDireccion.AutoSize = True
        Me.labDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDireccion.Location = New System.Drawing.Point(36, 220)
        Me.labDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDireccion.Name = "labDireccion"
        Me.labDireccion.Size = New System.Drawing.Size(76, 17)
        Me.labDireccion.TabIndex = 37
        Me.labDireccion.Text = "Dirección"
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.Location = New System.Drawing.Point(45, 94)
        Me.labNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(64, 17)
        Me.labNombre.TabIndex = 34
        Me.labNombre.Text = "Nombre"
        '
        'labDNI
        '
        Me.labDNI.AutoSize = True
        Me.labDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDNI.Location = New System.Drawing.Point(72, 178)
        Me.labDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDNI.Name = "labDNI"
        Me.labDNI.Size = New System.Drawing.Size(34, 17)
        Me.labDNI.TabIndex = 36
        Me.labDNI.Text = "DNI"
        '
        'labApellido
        '
        Me.labApellido.AutoSize = True
        Me.labApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labApellido.Location = New System.Drawing.Point(45, 136)
        Me.labApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labApellido.Name = "labApellido"
        Me.labApellido.Size = New System.Drawing.Size(66, 17)
        Me.labApellido.TabIndex = 35
        Me.labApellido.Text = "Apellido"
        '
        'frmClienteConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 468)
        Me.Controls.Add(Me.gboxDatos)
        Me.Controls.Add(Me.labCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.btnAtras)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClienteConsultar"
        Me.Text = "ClienteConsultar"
        Me.gboxDatos.ResumeLayout(False)
        Me.gboxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents labCliente As System.Windows.Forms.Label
    Friend WithEvents gboxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents labEmail As System.Windows.Forms.Label
    Friend WithEvents labTelefono As System.Windows.Forms.Label
    Friend WithEvents labDireccion As System.Windows.Forms.Label
    Friend WithEvents labDNI As System.Windows.Forms.Label
    Friend WithEvents labApellido As System.Windows.Forms.Label
    Friend WithEvents labNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
End Class
