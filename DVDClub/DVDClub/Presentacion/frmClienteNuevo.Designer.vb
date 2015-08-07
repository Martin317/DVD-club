<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteNuevo
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
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrProviderClienteNuevo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrProviderClienteNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(125, 44)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(317, 22)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(125, 92)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(317, 22)
        Me.txtApellido.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(125, 188)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(317, 22)
        Me.txtDireccion.TabIndex = 3
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(125, 140)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDNI.MaxLength = 19
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(317, 22)
        Me.txtDNI.TabIndex = 2
        '
        'labNombre
        '
        Me.labNombre.AutoSize = True
        Me.labNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNombre.Location = New System.Drawing.Point(40, 47)
        Me.labNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNombre.Name = "labNombre"
        Me.labNombre.Size = New System.Drawing.Size(69, 17)
        Me.labNombre.TabIndex = 4
        Me.labNombre.Text = "Nombre:"
        '
        'labApellido
        '
        Me.labApellido.AutoSize = True
        Me.labApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labApellido.Location = New System.Drawing.Point(40, 95)
        Me.labApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labApellido.Name = "labApellido"
        Me.labApellido.Size = New System.Drawing.Size(71, 17)
        Me.labApellido.TabIndex = 5
        Me.labApellido.Text = "Apellido:"
        '
        'labDNI
        '
        Me.labDNI.AutoSize = True
        Me.labDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDNI.Location = New System.Drawing.Point(67, 143)
        Me.labDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDNI.Name = "labDNI"
        Me.labDNI.Size = New System.Drawing.Size(39, 17)
        Me.labDNI.TabIndex = 6
        Me.labDNI.Text = "DNI:"
        '
        'labDireccion
        '
        Me.labDireccion.AutoSize = True
        Me.labDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDireccion.Location = New System.Drawing.Point(31, 191)
        Me.labDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDireccion.Name = "labDireccion"
        Me.labDireccion.Size = New System.Drawing.Size(81, 17)
        Me.labDireccion.TabIndex = 7
        Me.labDireccion.Text = "Dirección:"
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEmail.Location = New System.Drawing.Point(56, 287)
        Me.labEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(52, 17)
        Me.labEmail.TabIndex = 9
        Me.labEmail.Text = "Email:"
        '
        'labTelefono
        '
        Me.labTelefono.AutoSize = True
        Me.labTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTelefono.Location = New System.Drawing.Point(35, 239)
        Me.labTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labTelefono.Name = "labTelefono"
        Me.labTelefono.Size = New System.Drawing.Size(77, 17)
        Me.labTelefono.TabIndex = 8
        Me.labTelefono.Text = "Teléfono:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(125, 284)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(317, 22)
        Me.txtEmail.TabIndex = 11
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(125, 236)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefono.MaxLength = 19
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(317, 22)
        Me.txtTelefono.TabIndex = 10
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(125, 335)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(147, 46)
        Me.btnConfirmar.TabIndex = 12
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(296, 335)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(147, 46)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnConfirmar)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.labNombre)
        Me.GroupBox1.Controls.Add(Me.labEmail)
        Me.GroupBox1.Controls.Add(Me.labApellido)
        Me.GroupBox1.Controls.Add(Me.labTelefono)
        Me.GroupBox1.Controls.Add(Me.labDNI)
        Me.GroupBox1.Controls.Add(Me.labDireccion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(497, 398)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ErrProviderClienteNuevo
        '
        Me.ErrProviderClienteNuevo.ContainerControl = Me
        '
        'frmClienteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 422)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClienteNuevo"
        Me.Text = "Registrar cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrProviderClienteNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrProviderClienteNuevo As System.Windows.Forms.ErrorProvider
End Class
