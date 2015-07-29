<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteBaja
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
        Me.labCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labCliente
        '
        Me.labCliente.AutoSize = True
        Me.labCliente.Location = New System.Drawing.Point(65, 46)
        Me.labCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCliente.Name = "labCliente"
        Me.labCliente.Size = New System.Drawing.Size(51, 17)
        Me.labCliente.TabIndex = 30
        Me.labCliente.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(125, 42)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(167, 24)
        Me.cmbCliente.TabIndex = 29
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(207, 91)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(100, 28)
        Me.btnAtras.TabIndex = 31
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(99, 91)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 28)
        Me.btnAceptar.TabIndex = 32
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmClienteBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 139)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.labCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClienteBaja"
        Me.Text = "ClienteBaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labCliente As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
