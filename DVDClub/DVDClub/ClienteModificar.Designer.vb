<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteModificar
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
        Me.labCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(104, 252)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(126, 20)
        Me.txtEmail.TabIndex = 57
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(104, 213)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(126, 20)
        Me.txtTelefono.TabIndex = 56
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(45, 255)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(32, 13)
        Me.labEmail.TabIndex = 55
        Me.labEmail.Text = "Email"
        '
        'labTelefono
        '
        Me.labTelefono.AutoSize = True
        Me.labTelefono.Location = New System.Drawing.Point(45, 216)
        Me.labTelefono.Name = "labTelefono"
        Me.labTelefono.Size = New System.Drawing.Size(49, 13)
        Me.labTelefono.TabIndex = 54
        Me.labTelefono.Text = "Teléfono"
        '
        'labDireccion
        '
        Me.labDireccion.AutoSize = True
        Me.labDireccion.Location = New System.Drawing.Point(45, 177)
        Me.labDireccion.Name = "labDireccion"
        Me.labDireccion.Size = New System.Drawing.Size(52, 13)
        Me.labDireccion.TabIndex = 53
        Me.labDireccion.Text = "Dirección"
        '
        'labDNI
        '
        Me.labDNI.AutoSize = True
        Me.labDNI.Location = New System.Drawing.Point(45, 138)
        Me.labDNI.Name = "labDNI"
        Me.labDNI.Size = New System.Drawing.Size(26, 13)
        Me.labDNI.TabIndex = 52
        Me.labDNI.Text = "DNI"
        '
        'labApellido
        '
        Me.labApellido.AutoSize = True
        Me.labApellido.Location = New System.Drawing.Point(45, 99)
        Me.labApellido.Name = "labApellido"
        Me.labApellido.Size = New System.Drawing.Size(44, 13)
        Me.labApellido.TabIndex = 51
        Me.labApellido.Text = "Apellido"
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Location = New System.Drawing.Point(45, 60)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(44, 13)
        Me.labNombre.TabIndex = 50
        Me.labNombre.Text = "Nombre"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(104, 174)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(126, 20)
        Me.txtDireccion.TabIndex = 49
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(104, 135)
        Me.txtDNI.MaxLength = 50
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(126, 20)
        Me.txtDNI.TabIndex = 48
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(104, 96)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(126, 20)
        Me.txtApellido.TabIndex = 47
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(104, 57)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 20)
        Me.txtNombre.TabIndex = 46
        '
        'gboxDatos
        '
        Me.gboxDatos.Location = New System.Drawing.Point(14, 39)
        Me.gboxDatos.Name = "gboxDatos"
        Me.gboxDatos.Size = New System.Drawing.Size(260, 239)
        Me.gboxDatos.TabIndex = 45
        Me.gboxDatos.TabStop = False
        Me.gboxDatos.Text = "Datos"
        '
        'labCliente
        '
        Me.labCliente.AutoSize = True
        Me.labCliente.Location = New System.Drawing.Point(45, 15)
        Me.labCliente.Name = "labCliente"
        Me.labCliente.Size = New System.Drawing.Size(39, 13)
        Me.labCliente.TabIndex = 44
        Me.labCliente.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(104, 12)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(126, 21)
        Me.cmbCliente.TabIndex = 43
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(155, 284)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 23)
        Me.btnAtras.TabIndex = 42
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(74, 284)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 58
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ClienteModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 317)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.labEmail)
        Me.Controls.Add(Me.labTelefono)
        Me.Controls.Add(Me.labDireccion)
        Me.Controls.Add(Me.labDNI)
        Me.Controls.Add(Me.labApellido)
        Me.Controls.Add(Me.labNombre)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.gboxDatos)
        Me.Controls.Add(Me.labCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "ClienteModificar"
        Me.Text = "ClienteModificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
