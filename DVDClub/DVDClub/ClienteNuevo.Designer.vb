<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteNuevo
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.labNombre = New System.Windows.Forms.Label()
        Me.labApellido = New System.Windows.Forms.Label()
        Me.labDNI = New System.Windows.Forms.Label()
        Me.labDireccion = New System.Windows.Forms.Label()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.labTelefono = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 12)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(87, 51)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(126, 20)
        Me.txtApellido.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(87, 129)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(126, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(87, 90)
        Me.txtDNI.MaxLength = 50
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(126, 20)
        Me.txtDNI.TabIndex = 2
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Location = New System.Drawing.Point(28, 15)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(44, 13)
        Me.labNombre.TabIndex = 4
        Me.labNombre.Text = "Nombre"
        '
        'labApellido
        '
        Me.labApellido.AutoSize = True
        Me.labApellido.Location = New System.Drawing.Point(28, 54)
        Me.labApellido.Name = "labApellido"
        Me.labApellido.Size = New System.Drawing.Size(44, 13)
        Me.labApellido.TabIndex = 5
        Me.labApellido.Text = "Apellido"
        '
        'labDNI
        '
        Me.labDNI.AutoSize = True
        Me.labDNI.Location = New System.Drawing.Point(28, 93)
        Me.labDNI.Name = "labDNI"
        Me.labDNI.Size = New System.Drawing.Size(26, 13)
        Me.labDNI.TabIndex = 6
        Me.labDNI.Text = "DNI"
        '
        'labDireccion
        '
        Me.labDireccion.AutoSize = True
        Me.labDireccion.Location = New System.Drawing.Point(28, 132)
        Me.labDireccion.Name = "labDireccion"
        Me.labDireccion.Size = New System.Drawing.Size(52, 13)
        Me.labDireccion.TabIndex = 7
        Me.labDireccion.Text = "Direccion"
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Location = New System.Drawing.Point(28, 210)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(32, 13)
        Me.labEmail.TabIndex = 9
        Me.labEmail.Text = "Email"
        '
        'labTelefono
        '
        Me.labTelefono.AutoSize = True
        Me.labTelefono.Location = New System.Drawing.Point(28, 171)
        Me.labTelefono.Name = "labTelefono"
        Me.labTelefono.Size = New System.Drawing.Size(49, 13)
        Me.labTelefono.TabIndex = 8
        Me.labTelefono.Text = "Telefono"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(87, 207)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(126, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(87, 168)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(126, 20)
        Me.txtTelefono.TabIndex = 10
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(57, 244)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(138, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ClienteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 278)
        Me.Controls.Add(Me.btnCancelar)
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
        Me.Name = "ClienteNuevo"
        Me.Text = "ClienteNuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents labNombre As System.Windows.Forms.Label
    Friend WithEvents labApellido As System.Windows.Forms.Label
    Friend WithEvents labDNI As System.Windows.Forms.Label
    Friend WithEvents labDireccion As System.Windows.Forms.Label
    Friend WithEvents labEmail As System.Windows.Forms.Label
    Friend WithEvents labTelefono As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
