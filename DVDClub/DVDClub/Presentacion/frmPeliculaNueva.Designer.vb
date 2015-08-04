<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeliculaNueva
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
        Me.dtpFechaLanzamiento = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrProviderPeliculaNueva = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrProviderPeliculaNueva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaLanzamiento
        '
        Me.dtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLanzamiento.Location = New System.Drawing.Point(629, 127)
        Me.dtpFechaLanzamiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento"
        Me.dtpFechaLanzamiento.Size = New System.Drawing.Size(205, 22)
        Me.dtpFechaLanzamiento.TabIndex = 15
        Me.dtpFechaLanzamiento.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(485, 351)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(139, 58)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(264, 351)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 58)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(177, 209)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(584, 109)
        Me.txtDescripcion.TabIndex = 9
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(177, 127)
        Me.txtGenero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(188, 22)
        Me.txtGenero.TabIndex = 10
        '
        'txtIdioma
        '
        Me.txtIdioma.Location = New System.Drawing.Point(629, 37)
        Me.txtIdioma.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(205, 22)
        Me.txtIdioma.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(177, 33)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(188, 22)
        Me.txtNombre.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 213)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha de Lanzamiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Idioma:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre:"
        '
        'ErrProviderPeliculaNueva
        '
        Me.ErrProviderPeliculaNueva.ContainerControl = Me
        '
        'frmPeliculaNueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 453)
        Me.Controls.Add(Me.dtpFechaLanzamiento)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtIdioma)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPeliculaNueva"
        Me.Text = "PeliculaNueva"
        CType(Me.ErrProviderPeliculaNueva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaLanzamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtIdioma As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrProviderPeliculaNueva As System.Windows.Forms.ErrorProvider
End Class
