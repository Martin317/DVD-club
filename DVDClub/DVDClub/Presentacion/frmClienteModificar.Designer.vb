<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteModificar
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
        Me.components = New System.ComponentModel.Container()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.labTelefono = New System.Windows.Forms.Label()
        Me.labDireccion = New System.Windows.Forms.Label()
        Me.labDNI = New System.Windows.Forms.Label()
        Me.labApellido = New System.Windows.Forms.Label()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gboxDatos = New System.Windows.Forms.GroupBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrProviderClienteModificar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gboxDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrProviderClienteModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(118, 292)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(317, 22)
        Me.txtEmail.TabIndex = 57
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(118, 249)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(317, 22)
        Me.txtTelefono.TabIndex = 56
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmail.Location = New System.Drawing.Point(49, 295)
        Me.labEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(52, 17)
        Me.labEmail.TabIndex = 55
        Me.labEmail.Text = "Email:"
        '
        'labTelefono
        '
        Me.labTelefono.AutoSize = True
        Me.labTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTelefono.Location = New System.Drawing.Point(27, 252)
        Me.labTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labTelefono.Name = "labTelefono"
        Me.labTelefono.Size = New System.Drawing.Size(77, 17)
        Me.labTelefono.TabIndex = 54
        Me.labTelefono.Text = "Teléfono:"
        '
        'labDireccion
        '
        Me.labDireccion.AutoSize = True
        Me.labDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDireccion.Location = New System.Drawing.Point(24, 209)
        Me.labDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDireccion.Name = "labDireccion"
        Me.labDireccion.Size = New System.Drawing.Size(81, 17)
        Me.labDireccion.TabIndex = 53
        Me.labDireccion.Text = "Dirección:"
        '
        'labDNI
        '
        Me.labDNI.AutoSize = True
        Me.labDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDNI.Location = New System.Drawing.Point(60, 166)
        Me.labDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDNI.Name = "labDNI"
        Me.labDNI.Size = New System.Drawing.Size(39, 17)
        Me.labDNI.TabIndex = 52
        Me.labDNI.Text = "DNI:"
        '
        'labApellido
        '
        Me.labApellido.AutoSize = True
        Me.labApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labApellido.Location = New System.Drawing.Point(33, 123)
        Me.labApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labApellido.Name = "labApellido"
        Me.labApellido.Size = New System.Drawing.Size(71, 17)
        Me.labApellido.TabIndex = 51
        Me.labApellido.Text = "Apellido:"
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.Location = New System.Drawing.Point(33, 80)
        Me.labNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(69, 17)
        Me.labNombre.TabIndex = 50
        Me.labNombre.Text = "Nombre:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(118, 206)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(317, 22)
        Me.txtDireccion.TabIndex = 49
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(118, 163)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDNI.MaxLength = 50
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(317, 22)
        Me.txtDNI.TabIndex = 48
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(118, 120)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(317, 22)
        Me.txtApellido.TabIndex = 47
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(118, 77)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(317, 22)
        Me.txtNombre.TabIndex = 46
        '
        'gboxDatos
        '
        Me.gboxDatos.Controls.Add(Me.txtNumero)
        Me.gboxDatos.Controls.Add(Me.Label1)
        Me.gboxDatos.Controls.Add(Me.txtNombre)
        Me.gboxDatos.Controls.Add(Me.txtEmail)
        Me.gboxDatos.Controls.Add(Me.txtApellido)
        Me.gboxDatos.Controls.Add(Me.txtTelefono)
        Me.gboxDatos.Controls.Add(Me.txtDNI)
        Me.gboxDatos.Controls.Add(Me.labEmail)
        Me.gboxDatos.Controls.Add(Me.txtDireccion)
        Me.gboxDatos.Controls.Add(Me.labTelefono)
        Me.gboxDatos.Controls.Add(Me.labNombre)
        Me.gboxDatos.Controls.Add(Me.labDireccion)
        Me.gboxDatos.Controls.Add(Me.labApellido)
        Me.gboxDatos.Controls.Add(Me.labDNI)
        Me.gboxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxDatos.Location = New System.Drawing.Point(22, 102)
        Me.gboxDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.gboxDatos.Name = "gboxDatos"
        Me.gboxDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.gboxDatos.Size = New System.Drawing.Size(484, 339)
        Me.gboxDatos.TabIndex = 45
        Me.gboxDatos.TabStop = False
        Me.gboxDatos.Text = "Datos"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.Location = New System.Drawing.Point(118, 34)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.MaxLength = 50
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(99, 22)
        Me.txtNumero.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Numero:"
        '
        'labCliente
        '
        Me.labCliente.AutoSize = True
        Me.labCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCliente.Location = New System.Drawing.Point(39, 34)
        Me.labCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCliente.Name = "labCliente"
        Me.labCliente.Size = New System.Drawing.Size(58, 17)
        Me.labCliente.TabIndex = 44
        Me.labCliente.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(118, 31)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(317, 24)
        Me.cmbCliente.TabIndex = 43
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(307, 460)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(147, 45)
        Me.btnAtras.TabIndex = 42
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(135, 460)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(147, 45)
        Me.btnConfirmar.TabIndex = 58
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.labCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 83)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ErrProviderClienteModificar
        '
        Me.ErrProviderClienteModificar.ContainerControl = Me
        '
        'frmClienteModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 528)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.gboxDatos)
        Me.Controls.Add(Me.btnAtras)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClienteModificar"
        Me.Text = "Modificar cliente"
        Me.gboxDatos.ResumeLayout(False)
        Me.gboxDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrProviderClienteModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents gboxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents labCliente As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrProviderClienteModificar As System.Windows.Forms.ErrorProvider
End Class
